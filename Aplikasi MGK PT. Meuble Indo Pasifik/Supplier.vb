Imports MySql.Data.MySqlClient
Public Class Supplier
    Public strSql As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public datardr As MySqlDataReader
    Public DS As DataSet
    Public simpan, hapus As String


    Sub bersih()
        'untuk membersihkan textbox ketika selesai di eksekusi
        tbkdsp.Text = ""
        tbnmsp.Text = ""

    End Sub

    ' Fungsi untuk menghasilkan kode otomatis berdasarkan input teks
    Function GenerateCode(baseText As String) As String
        Dim upperText As String
        upperText = Microsoft.VisualBasic.UCase(baseText) ' Konversi ke huruf besar
        GenerateCode = Mid(upperText, 1, 3) & Format(Now, "0ss") ' Kombinasi 3 huruf pertama + waktu detik
    End Function

    Sub generatekode()
        ' Gunakan fungsi GenerateCode untuk menghasilkan kode
        Dim inputText As String
        inputText = "SUPPLIER" ' Masukkan teks dasar
        tbkdsp.Text = GenerateCode(inputText) ' Hasilkan dan tampilkan di tbkdsp
    End Sub


    Sub isigrid()
        ModulKoneksi.bukaDB()
        adapter = New MySqlDataAdapter("select * from supplier order by nama_supplier ASC", Koneksi)
        DS = New DataSet
        adapter.Fill(DS, "supplier")
        DTGVSUP.DataSource = DS.Tables("supplier")
        DTGVSUP.ReadOnly = True

        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM supplier", Koneksi)
        Dim totalData As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        total.Text = "" & totalData.ToString()
        status.Text = "-"

    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        tbkdsp.ReadOnly = True

    End Sub

    Private Sub tbnmsp_TextChanged(sender As Object, e As EventArgs) Handles tbnmsp.TextChanged
        Try
            ModulKoneksi.bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query untuk LIKE nama supplier
            Dim query As String = " select ID_supplier, nama_supplier from supplier where nama_supplier LIKE @namasupplier"

            CMD = New MySqlCommand(query, Koneksi)
            CMD.Parameters.AddWithValue("@namasupplier", "%" & tbnmsp.Text & "%")
            adapter = New MySqlDataAdapter(CMD)
            dataset = New DataSet
            adapter.Fill(dataset, "supplier")
            DTGVSUP.DataSource = dataset.Tables("supplier")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Koneksi.Close()
        End Try
    End Sub

    Private Sub DTGVSUP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGVSUP.CellContentClick
        Try
            Dim gridbaris As DataGridViewRow = DTGVSUP.Rows(e.RowIndex)
            tbkdsp.Text = If(IsDBNull(gridbaris.Cells(0).Value) OrElse gridbaris.Cells(0).Value Is Nothing, "", gridbaris.Cells(0).Value.ToString())
            tbnmsp.Text = If(IsDBNull(gridbaris.Cells(1).Value) OrElse gridbaris.Cells(1).Value Is Nothing, "", gridbaris.Cells(1).Value.ToString())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Detail: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'untuk menambahkan data
        Dim userMsg As String
        If tbnmsp.Text = "" Then
            MsgBox("Nama supplier Kosong..", vbExclamation, "INPUT")
            userMsg = Microsoft.VisualBasic.InputBox("Masukkan Nama supplier disini", "Field Nama supplier", "Masukkan Nama supplier..", 500, 300)
            tbnmsp.Text = userMsg
            tbnmsp.Focus()
            Exit Sub

        ElseIf tbnmsp.Text <> "" Then
            generatekode()
            If MessageBox.Show("Kode supplier: " & tbkdsp.Text.ToString & " || Nama supplier: " & tbnmsp.Text.ToString & vbNewLine & "Simpan data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Call bukaDB()
                    Dim cmd As New MySqlCommand("INSERT INTO supplier (ID_supplier, nama_supplier) VALUES ('" & tbkdsp.Text & "', '" & tbnmsp.Text & "')", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")
                    isigrid()
                    bersih()
                    btnTambah.Enabled = True
                    status.Text = "Data Disimpan"

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        'update data
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("UPDATE supplier SET ID_supplier=@IDSP, nama_supplier=@np WHERE ID_supplier=@IDSP", conn)

                With command.Parameters
                    .AddWithValue("@IDSP", tbkdsp.Text)
                    .AddWithValue("@np", tbnmsp.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("...Data sukses tersimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call isigrid()
                status.Text = "Data Diubah"
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "...Cek, Kesalahan pada input data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If MessageBox.Show("[Nama supplier : " + tbnmsp.Text.ToString + "]...Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call bukaDB()
                hapus = "Delete from supplier where nama_supplier='" & tbnmsp.Text & "'"
                CMD = New MySqlCommand(hapus, Koneksi)
                CMD.ExecuteNonQuery()
                Call isigrid()
                Call bersih()
                MessageBox.Show(tbnmsp.Text.ToString & "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                status.Text = "Data Dihapus"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "...Cek, Kesalahan pada hapus data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        bersih()
        btnTambah.Enabled = False
        btnHapus.Enabled = False
        btnKeluar.Enabled = True
        btnUbah.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
        btnKeluar.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnUbah.Enabled = True
        btnTambah.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub




End Class