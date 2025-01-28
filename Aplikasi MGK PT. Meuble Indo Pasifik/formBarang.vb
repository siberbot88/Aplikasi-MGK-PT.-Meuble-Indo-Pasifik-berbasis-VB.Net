Imports MySql.Data.MySqlClient
Public Class formBarang
    Public strSQL As String
    Public databases As MySqlConnection
    Public command As MySqlCommand
    Public dataadapter As MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public dataset As DataSet
    Public simpan, hapus As String

    Sub bersih()
        txtky.Text = ""
        tbnmy.Text = ""
        cbkt.Text = ""
        rtbdes.Text = ""
        tbhb.Text = ""
        tbpk.Text = ""
        tbhj.Text = ""
        tbstok.Text = ""
    End Sub

    Sub generateCode()
        Dim genCode As String
        genCode = Microsoft.VisualBasic.UCase(cbkt.Text)
        txtky.Text = Mid(genCode, 1, 3) & Format(Now, "ss")
    End Sub

    Sub isigrid()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT k.kd_kayu, k.nm_kayu, kt.nm_kat, k.deskripsi, k.harga_beli, k.harga_pokok, k.harga_jual, k.stok FROM kayu k JOIN kategori kt ON k.kd_kat = kt.kd_kat"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "kayu")
        DGVB.DataSource = dataset.Tables("kayu")
        DGVB.ReadOnly = True
    End Sub

    Sub isicbb()
        Call bukaDB()
        Try
            command = New MySqlCommand("select nm_kat from kategori", Koneksi)
            datareader = command.ExecuteReader
            cbkt.Items.Clear()
            Do While datareader.Read
                cbkt.Items.Add(datareader("nm_kat").ToString())
            Loop
            datareader.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim usermsg As String
        Dim kategorikayu As String = cbkt.SelectedItem
        Dim kategori As String = ""
        txtky.Focus()
        If tbnmy.Text = "" Then
            MsgBox("Nama kayu Kosong..", vbExclamation, "INPUT")
            usermsg = Microsoft.VisualBasic.InputBox("Masukkan Nama kayu disini", "Field Nama kayu", "Masukkan Nama kayu..", 500, 300)
            tbnmy.Text = usermsg
            tbnmy.Focus()
            Exit Sub
        ElseIf tbnmy.Text <> "" Then
            generateCode()

            If Not String.IsNullOrEmpty(kategorikayu) Then
                Select Case kategorikayu
                    Case "Kayu Ringan/ olahan"
                        kategori = "KAY1811240901"
                    Case "Kayu Lunak"
                        kategori = "KAY1811240928"
                    Case "Kayu Keras"
                        kategori = "KAY1811240933"
                    Case "Kayu Tropis"
                        kategori = "KAY1811240959"
                End Select
            End If

            If MessageBox.Show("Kode kayu: " & tbnmy.Text.ToString & " || Nama kayu: " & tbnmy.Text.ToString & vbNewLine & "Simpan data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Call bukaDB()
                    Dim query As String = "INSERT INTO kayu (kd_kayu, nm_kayu, kd_kat, deskripsi, harga_beli, harga_pokok, harga_jual, stok) VALUES (@kd_kayu, @nm_kayu, @kd_kat, @deskripsi, @harga_beli, @harga_pokok, @harga_jual,@stok)"
                    Dim cmd As New MySqlCommand(query, Koneksi)
                    cmd.Parameters.AddWithValue("@kd_kayu", txtky.Text)
                    cmd.Parameters.AddWithValue("@nm_kayu", tbnmy.Text)
                    cmd.Parameters.AddWithValue("@kd_kat", kategori)
                    cmd.Parameters.AddWithValue("@deskripsi", rtbdes.Text)
                    cmd.Parameters.AddWithValue("@harga_beli", Convert.ToDouble(tbhb.Text))
                    cmd.Parameters.AddWithValue("@harga_pokok", Convert.ToDouble(tbpk.Text))
                    cmd.Parameters.AddWithValue("@harga_jual", Convert.ToDouble(tbhj.Text))
                    cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(tbstok.Text))
                    cmd.ExecuteNonQuery()

                    MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")
                    bersih()
                    btntambah.Enabled = True


                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, vbCritical, "Kesalahan")
                Finally
                    If Koneksi IsNot Nothing Then
                        Koneksi.Close()
                    End If

                End Try
            End If
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        bersih()
        btntambah.Enabled = False
        btnkeluar.Enabled = True
        btnubah.Enabled = True
        btnhapus.Enabled = False
        btnbatal.Enabled = True
        btnsimpan.Enabled = True
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        btnkeluar.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnhapus.Enabled = True
        btnubah.Enabled = True
        btntambah.Enabled = True
    End Sub

    Private Sub formBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isicbb()
        isigrid()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Hide()
        FormUtama.Show()
    End Sub

    Private Sub btnhapus_Click_1(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MessageBox.Show("[nama kayu " + tbnmy.Text.ToString + "]...Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call bukaDB()
            hapus = "DELETE FROM kayu WHERE nm_kayu='" & tbnmy.Text & "'"
            command = New MySqlCommand(hapus, Koneksi)
            command.ExecuteNonQuery()
            Call isigrid()
            Call bersih()
            tbnmy.Focus()
            MessageBox.Show(tbnmy.Text.ToString + "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    'mencari nama kayu %like
    Private Sub tbnmy_TextChanged(sender As Object, e As EventArgs) Handles tbnmy.TextChanged
        Try
            ModulKoneksi.bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query untuk LIKE nm_kayu
            Dim query As String = "SELECT k.kd_kayu, k.nm_kayu, kt.nm_kat, k.deskripsi, k.harga_beli, k.harga_pokok, k.harga_jual, k.stok " &
                              "FROM kayu k JOIN kategori kt ON k.kd_kat = kt.kd_kat " &
                              "WHERE k.nm_kayu LIKE @namaKayu"

            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@namaKayu", "%" & tbnmy.Text & "%")
            adapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "kayu")
            DGVB.DataSource = dataset.Tables("kayu")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Koneksi.Close()
        End Try
    End Sub

    'mengubah data
    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        Dim kategorikayu1 As String = cbkt.SelectedItem
        Dim kategori As String = " "
        Call bukaDB()
        Try
            If Not String.IsNullOrEmpty(kategorikayu1) Then
                Select Case kategorikayu1
                    Case "Kayu Ringan/ olahan"
                        kategori = "KAY1811240901"
                    Case "Kayu Lunak"
                        kategori = "KAY1811240928"
                    Case "Kayu Keras"
                        kategori = "KAY1811240933"
                    Case "Kayu Tropis"
                        kategori = "KAY1811240959"
                End Select
            End If
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("UPDATE kayu SET kd_kayu=@kkd, nm_kayu=@nm, kd_kat=@kdkat, deskripsi=@des, harga_beli=@hb, harga_pokok=@hp, harga_jual=@hj, stok=@st WHERE kd_kayu=@kkd", conn)

                With command.Parameters
                    .AddWithValue("@kkd", txtky.Text)
                    .AddWithValue("@nm", tbnmy.Text)
                    .AddWithValue("@kdkat", kategori)
                    .AddWithValue("@des", rtbdes.Text)
                    .AddWithValue("@hb", tbhb.Text)
                    .AddWithValue("@hp", tbpk.Text)
                    .AddWithValue("@hj", tbhj.Text)
                    .AddWithValue("@st", tbstok.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("...Data sukses tersimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call isigrid()
                Call bersih()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "...Cek, Kesalahan pada input data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'klik datagridview
    Private Sub DGVB_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVB.CellClick
        Try
            Dim gridbaris As DataGridViewRow = DGVB.Rows(e.RowIndex)
            txtky.Text = If(IsDBNull(gridbaris.Cells(0).Value) OrElse gridbaris.Cells(0).Value Is Nothing, "", gridbaris.Cells(0).Value.ToString())
            tbnmy.Text = If(IsDBNull(gridbaris.Cells(1).Value) OrElse gridbaris.Cells(1).Value Is Nothing, "", gridbaris.Cells(1).Value.ToString())
            cbkt.Text = If(IsDBNull(gridbaris.Cells(2).Value) OrElse gridbaris.Cells(2).Value Is Nothing, "", gridbaris.Cells(2).Value.ToString())
            rtbdes.Text = If(IsDBNull(gridbaris.Cells(3).Value) OrElse gridbaris.Cells(3).Value Is Nothing, "", gridbaris.Cells(3).Value.ToString())
            tbhb.Text = If(IsDBNull(gridbaris.Cells(4).Value) OrElse gridbaris.Cells(4).Value Is Nothing, "", gridbaris.Cells(4).Value.ToString())
            tbpk.Text = If(IsDBNull(gridbaris.Cells(5).Value) OrElse gridbaris.Cells(5).Value Is Nothing, "", gridbaris.Cells(5).Value.ToString())
            tbhj.Text = If(IsDBNull(gridbaris.Cells(6).Value) OrElse gridbaris.Cells(6).Value Is Nothing, "", gridbaris.Cells(6).Value.ToString())
            tbstok.Text = If(IsDBNull(gridbaris.Cells(7).Value) OrElse gridbaris.Cells(7).Value Is Nothing, "", gridbaris.Cells(7).Value.ToString())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Detail: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class