Imports MySql.Data.MySqlClient
Public Class BarangMasuk
    Public strSQL As String
    Public databases As MySqlConnection
    Public command As MySqlCommand
    Public dataadapter As MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public dataset As DataSet
    Public simpan, hapus As String

    Sub bersih()
        tbkdrc.Text = ""
        cbnk.Text = ""
        cbnsp.Text = ""
        'bendera
        dtprc.Text = ""
        tbjb.Text = ""
        tbtd.Text = ""
    End Sub

    Function GenerateCode(baseText As String) As String
        Dim upperText As String
        upperText = Microsoft.VisualBasic.UCase(baseText) ' Konversi ke huruf besar
        GenerateCode = "RCV" & Format(Now, "0HHss") ' Kombinasi 3 huruf + waktu detik
    End Function

    Sub generatekode()
        'fungsi GenerateCode untuk menghasilkan kode
        Dim inputText As String
        inputText = "SUPPLIER"
        tbkdrc.Text = GenerateCode(inputText)
    End Sub

    Sub isigrid()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT barang_masuk.ID_receiving, kayu.nm_kayu, supplier.nama_supplier, barang_masuk.tanggal_receiving, barang_masuk.jumlah_barang_receiving, barang_masuk.nilai_receiving FROM barang_masuk JOIN kayu ON barang_masuk.kd_kayu = kayu.kd_kayu JOIN supplier ON barang_masuk.ID_supplier = supplier.ID_supplier"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "barang_masuk")
        DTGVBM.DataSource = dataset.Tables("barang_masuk")
        DTGVBM.ReadOnly = True
    End Sub

    Sub isicbbkayu()
        Call bukaDB()
        Try
            command = New MySqlCommand("select nm_kayu from kayu", Koneksi)
            datareader = command.ExecuteReader
            cbnk.Items.Clear()
            Do While datareader.Read
                cbnk.Items.Add(datareader("nm_kayu").ToString())
            Loop
            datareader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub isicbbsupplier()
        Call bukaDB()
        Try
            command = New MySqlCommand("select nama_supplier from supplier", Koneksi)
            datareader = command.ExecuteReader
            cbnsp.Items.Clear()
            Do While datareader.Read
                cbnsp.Items.Add(datareader("nama_supplier").ToString())
            Loop
            datareader.Close()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        isicbbkayu()
        isicbbsupplier()
        tbkdrc.ReadOnly = True

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call bukaDB()
        generatekode()
        Dim query As String = "INSERT INTO barang_masuk (ID_receiving, kd_kayu, ID_supplier, tanggal_receiving, jumlah_barang_receiving, nilai_receiving) 
                               VALUES (@ID_receiving, 
                               (SELECT kd_kayu FROM kayu WHERE nm_kayu = @nm_kayu), 
                               (SELECT ID_supplier FROM supplier WHERE nama_supplier = @nama_supplier), 
                               @tanggal_receiving, 
                               @jumlah_barang_receiving, 
                               @nilai_receiving)"

        Dim command As New MySqlCommand(query, Koneksi)
        command.Parameters.AddWithValue("@ID_receiving", tbkdrc.Text)
        command.Parameters.AddWithValue("@nm_kayu", cbnk.Text)
        command.Parameters.AddWithValue("@nama_supplier", cbnsp.Text)
        command.Parameters.AddWithValue("@tanggal_receiving", DateTime.Parse(dtprc.Text))
        command.Parameters.AddWithValue("@jumlah_barang_receiving", Integer.Parse(tbjb.Text))
        command.Parameters.AddWithValue("@nilai_receiving", Decimal.Parse(tbtd.Text))

        Try
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")
            bersih()
            btnTambah.Enabled = True
        Catch ex As MySqlException
            MsgBox("Kesalahan: " & ex.Message, vbCritical, "Error")
        End Try


    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Try
            Call bukaDB() ' Pastikan fungsi bukaDB membuka koneksi ke database dengan benar.

            ' Query SQL menggunakan parameter
            Dim query As String = "UPDATE barang_masuk 
                               SET kd_kayu = (SELECT kd_kayu FROM kayu WHERE nm_kayu = @nm_kayu), 
                                   ID_supplier = (SELECT ID_supplier FROM supplier WHERE nama_supplier = @nama_supplier), 
                                   tanggal_receiving = @tanggal_receiving, 
                                   jumlah_barang_receiving = @jumlah_barang_receiving, 
                                   nilai_receiving = @nilai_receiving 
                               WHERE ID_receiving = @ID_receiving"

            ' Buat objek command
            Dim command As New MySqlCommand(query, Koneksi)

            ' Tambahkan parameter untuk menghindari masalah format dan SQL Injection
            command.Parameters.AddWithValue("@nm_kayu", cbnk.Text)
            command.Parameters.AddWithValue("@nama_supplier", cbnsp.Text)
            command.Parameters.AddWithValue("@tanggal_receiving", DateTime.Parse(dtprc.Text).ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@jumlah_barang_receiving", Integer.Parse(tbjb.Text))
            command.Parameters.AddWithValue("@nilai_receiving", Decimal.Parse(tbtd.Text))
            command.Parameters.AddWithValue("@ID_receiving", tbkdrc.Text)

            ' Eksekusi query
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", vbInformation, "Sukses")

            ' Bersihkan form dan atur ulang tombol
            bersih()
            btnTambah.Enabled = True
        Catch ex As MySqlException
            MsgBox("Kesalahan: " & ex.Message, vbCritical, "Error")
        Catch ex As Exception
            MsgBox("Kesalahan: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            Call bukaDB() ' Pastikan fungsi ini membuka koneksi database dengan benar.

            ' Konfirmasi penghapusan
            If MessageBox.Show("Hapus data untuk ID_receiving: " & tbkdrc.Text & "?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ' Query SQL dengan parameter
                Dim query As String = "DELETE FROM barang_masuk WHERE ID_receiving = @ID_receiving"
                Dim command As New MySqlCommand(query, Koneksi)

                ' Tambahkan parameter
                command.Parameters.AddWithValue("@ID_receiving", tbkdrc.Text)

                ' Eksekusi query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Periksa apakah ada data yang dihapus
                If rowsAffected > 0 Then
                    Call isigrid() ' Refresh data grid
                    Call bersih()  ' Bersihkan form
                    cbnk.Focus()   ' Set fokus ke combobox
                    MessageBox.Show("Data berhasil dihapus.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data tidak ditemukan.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show("Kesalahan database: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormUtama.Show()
        Me.Hide()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        bersih()
        btnTambah.Enabled = False
        btnKeluar.Enabled = True
        btnUbah.Enabled = True
        btnHapus.Enabled = False
        btnBatal.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersih()
        btnKeluar.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnHapus.Enabled = True
        btnUbah.Enabled = True
        btnTambah.Enabled = True
    End Sub

    Private Sub cbnk_TextChanged(sender As Object, e As EventArgs) Handles cbnk.TextChanged
        Try
            ModulKoneksi.bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query untuk LIKE nm_kayu dengan parameter terikat
            Dim query As String = "SELECT barang_masuk.ID_receiving, kayu.nm_kayu, supplier.nama_supplier, barang_masuk.tanggal_receiving, barang_masuk.jumlah_barang_receiving, barang_masuk.nilai_receiving " &
                              "FROM barang_masuk JOIN kayu ON barang_masuk.kd_kayu = kayu.kd_kayu JOIN supplier ON barang_masuk.ID_supplier = supplier.ID_supplier " &
                              "WHERE kayu.nm_kayu LIKE @namaKayu"

            ' Gunakan parameter untuk menggantikan penggabungan string langsung
            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@namaKayu", "%" & cbnk.Text & "%")

            adapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "barang_masuk")
            DTGVBM.DataSource = dataset.Tables("barang_masuk")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Pastikan koneksi database ditutup
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub


    Private Sub DTGVBM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGVBM.CellContentClick

    End Sub

    Private Sub dtprc_ValueChanged(sender As Object, e As EventArgs) Handles dtprc.ValueChanged
        Try
            ModulKoneksi.bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query dengan operator "=" untuk kolom tanggal
            Dim query As String = "SELECT barang_masuk.ID_receiving, kayu.nm_kayu, supplier.nama_supplier, barang_masuk.tanggal_receiving, barang_masuk.jumlah_barang_receiving, barang_masuk.nilai_receiving " &
                              "FROM barang_masuk " &
                              "JOIN kayu ON barang_masuk.kd_kayu = kayu.kd_kayu " &
                              "JOIN supplier ON barang_masuk.ID_supplier = supplier.ID_supplier " &
                              "WHERE DATE(barang_masuk.tanggal_receiving) = @tanggal"

            ' format tanggal sesuai MySQL
            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@tanggal", dtprc.Value.ToString("yyyy-MM-dd"))

            adapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "barang_masuk")
            DTGVBM.DataSource = dataset.Tables("barang_masuk")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Pastikan koneksi database ditutup
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub

    Private Sub DTGVBM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGVBM.CellClick
        Try
            Dim gridbaris As DataGridViewRow = DTGVBM.Rows(e.RowIndex)
            tbkdrc.Text = If(IsDBNull(gridbaris.Cells(0).Value) OrElse gridbaris.Cells(0).Value Is Nothing, "", gridbaris.Cells(0).Value.ToString())
            cbnk.Text = If(IsDBNull(gridbaris.Cells(1).Value) OrElse gridbaris.Cells(1).Value Is Nothing, "", gridbaris.Cells(1).Value.ToString())
            cbnsp.Text = If(IsDBNull(gridbaris.Cells(2).Value) OrElse gridbaris.Cells(2).Value Is Nothing, "", gridbaris.Cells(2).Value.ToString())
            dtprc.Text = If(IsDBNull(gridbaris.Cells(3).Value) OrElse gridbaris.Cells(3).Value Is Nothing, "", gridbaris.Cells(3).Value.ToString())
            tbjb.Text = If(IsDBNull(gridbaris.Cells(4).Value) OrElse gridbaris.Cells(4).Value Is Nothing, "", gridbaris.Cells(4).Value.ToString())
            tbtd.Text = If(IsDBNull(gridbaris.Cells(5).Value) OrElse gridbaris.Cells(5).Value Is Nothing, "", gridbaris.Cells(5).Value.ToString())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Detail: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class