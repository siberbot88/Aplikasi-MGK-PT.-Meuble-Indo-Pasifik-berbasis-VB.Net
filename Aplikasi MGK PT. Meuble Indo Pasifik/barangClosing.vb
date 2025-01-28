Imports MySql.Data.MySqlClient
Public Class barangClosing
    Public strSQL As String
    Public databases As MySqlConnection
    Public command As MySqlCommand
    Public dataadapter As MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public dataset As DataSet
    Public simpan, hapus As String

    Sub bersih()
        tbkdcl.Text = ""
        cbnm.Text = ""
        cbnmi.Text = ""
        'bendera
        dtpcl.Text = ""
        tbjbr.Text = ""
        tbtdr.Text = ""
    End Sub

    Function GenerateCode(baseText As String) As String
        Dim upperText As String
        upperText = Microsoft.VisualBasic.UCase(baseText) ' Konversi ke huruf besar
        GenerateCode = "CLS" & Format(Now, "0HHss") ' Kombinasi 3 huruf + waktu detik
    End Function

    Sub generatekode()
        'fungsi GenerateCode untuk menghasilkan kode
        Dim inputText As String
        inputText = "MITRA"
        tbkdcl.Text = GenerateCode(inputText)
    End Sub

    Sub isigrid()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT barang_closing.ID_closing, kayu.nm_kayu, mitra.nama_mitra, barang_closing.tanggal_closing, barang_closing.jumlah_barang_closing, barang_closing.nilai_closing FROM barang_closing JOIN kayu ON barang_closing.kd_kayu = kayu.kd_kayu JOIN mitra ON barang_closing.ID_mitra = mitra.ID_mitra"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "barang_closing")
        DTGVBK.DataSource = dataset.Tables("barang_closing")
        DTGVBK.ReadOnly = True
    End Sub

    Sub isicbbkayu()
        Call bukaDB()
        Try
            command = New MySqlCommand("select nm_kayu from kayu", Koneksi)
            datareader = command.ExecuteReader
            cbnm.Items.Clear()
            Do While datareader.Read
                cbnm.Items.Add(datareader("nm_kayu").ToString())
            Loop
            datareader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub isicbbmitra()
        Call bukaDB()
        Try
            command = New MySqlCommand("select nama_mitra from mitra", Koneksi)
            datareader = command.ExecuteReader
            cbnmi.Items.Clear()
            Do While datareader.Read
                cbnmi.Items.Add(datareader("nama_mitra").ToString())
            Loop
            datareader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormUtama.Show()
        Me.Hide()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call bukaDB()
        generatekode()

        ' Hitung nilai_closing
        Dim hargaJual As Decimal = 0
        Dim nilaiClosing As Decimal = 0

        Try
            ' Ambil harga jual kayu berdasarkan nama kayu
            Dim queryHarga As String = "SELECT harga_jual FROM kayu WHERE nm_kayu = @nm_kayu"
            Dim commandHarga As New MySqlCommand(queryHarga, Koneksi)
            commandHarga.Parameters.AddWithValue("@nm_kayu", cbnm.Text)

            datareader = commandHarga.ExecuteReader()
            If datareader.Read() Then
                hargaJual = Decimal.Parse(datareader("harga_jual").ToString())
            End If
            datareader.Close()

            ' Hitung nilai closing
            nilaiClosing = Integer.Parse(tbjbr.Text) * hargaJual

            ' Query untuk menyimpan data ke database
            Dim query As String = "
            INSERT INTO barang_closing (ID_closing, kd_kayu, ID_mitra, tanggal_closing, jumlah_barang_closing, nilai_closing)
            VALUES (
            @ID_closing, 
            (SELECT kd_kayu FROM kayu WHERE nm_kayu = @nm_kayu), 
            (SELECT ID_mitra FROM mitra WHERE nama_mitra = @nama_mitra), 
            @tanggal_closing, 
            @jumlah_barang_closing, 
            @nilai_closing
            )"

            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@ID_closing", tbkdcl.Text)
            command.Parameters.AddWithValue("@nm_kayu", cbnm.Text)
            command.Parameters.AddWithValue("@nama_mitra", cbnmi.Text)
            command.Parameters.AddWithValue("@tanggal_closing", DateTime.Parse(dtpcl.Text))
            command.Parameters.AddWithValue("@jumlah_barang_closing", Integer.Parse(tbjbr.Text))
            command.Parameters.AddWithValue("@nilai_closing", nilaiClosing)

            ' Eksekusi query
            command.ExecuteNonQuery()

            ' Tampilkan nilai closing di TextBox
            tbtdr.Text = nilaiClosing.ToString("N0") ' Format angka dengan pemisah ribuan

            MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")
            bersih()
            btnTambah.Enabled = True
        Catch ex As MySqlException
            MsgBox("Kesalahan: " & ex.Message, vbCritical, "Error")
        Catch ex As Exception
            MsgBox("Kesalahan: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub




    Private Sub cbnm_TextChanged(sender As Object, e As EventArgs) Handles cbnm.TextChanged
        Try
            ModulKoneksi.bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query untuk LIKE nm_kayu dengan parameter terikat
            Dim query As String = "SELECT barang_closing.ID_closing, kayu.nm_kayu, mitra.nama_mitra, barang_closing.tanggal_closing, barang_closing.jumlah_barang_closing, barang_closing.nilai_closing FROM barang_closing JOIN kayu ON barang_closing.kd_kayu = kayu.kd_kayu JOIN mitra ON barang_closing.ID_mitra = mitra.ID_mitra " &
                              "WHERE kayu.nm_kayu LIKE @namaKayu"

            ' Gunakan parameter untuk menggantikan penggabungan string langsung
            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@namaKayu", "%" & cbnm.Text & "%")

            adapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "barang_closing")
            DTGVBK.DataSource = dataset.Tables("barang_closing")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Pastikan koneksi database ditutup
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub


    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Call bukaDB()

        Dim hargaJual As Decimal = 0
        Dim nilaiClosing As Decimal = 0

        Try

            Dim queryHarga As String = "SELECT harga_jual FROM kayu WHERE nm_kayu = @nm_kayu"
            Dim commandHarga As New MySqlCommand(queryHarga, Koneksi)
            commandHarga.Parameters.AddWithValue("@nm_kayu", cbnm.Text)

            Dim reader As MySqlDataReader = commandHarga.ExecuteReader()
            If reader.Read() Then
                hargaJual = Decimal.Parse(reader("harga_jual").ToString())
            End If
            reader.Close()

            ' Hitung nilai closing
            nilaiClosing = Integer.Parse(tbjbr.Text) * hargaJual

            Dim query As String = "
            UPDATE barang_closing 
            SET 
            kd_kayu = (SELECT kd_kayu FROM kayu WHERE nm_kayu = @nm_kayu), 
            ID_mitra = (SELECT ID_mitra FROM mitra WHERE nama_mitra = @nama_mitra), 
            tanggal_closing = @tanggal_closing, 
            jumlah_barang_closing = @jumlah_barang_closing, 
            nilai_closing = @nilai_closing
            WHERE 
            ID_closing = @ID_closing"

            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@ID_closing", tbkdcl.Text)
            command.Parameters.AddWithValue("@nm_kayu", cbnm.Text)
            command.Parameters.AddWithValue("@nama_mitra", cbnmi.Text)
            command.Parameters.AddWithValue("@tanggal_closing", DateTime.Parse(dtpcl.Text))
            command.Parameters.AddWithValue("@jumlah_barang_closing", Integer.Parse(tbjbr.Text))
            command.Parameters.AddWithValue("@nilai_closing", nilaiClosing)

            ' Eksekusi query
            Dim baris As Integer = command.ExecuteNonQuery()

            ' Periksa apakah data berhasil diperbarui
            If baris > 0 Then
                tbtdr.Text = nilaiClosing.ToString("N0") ' Format angka dengan pemisah ribuan
                MsgBox("Data Berhasil Diperbarui", vbInformation, "Sukses")
                bersih()
                btnTambah.Enabled = True
            Else
                MsgBox("Data tidak ditemukan atau tidak ada perubahan.", vbInformation, "Info")
            End If
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
            If MessageBox.Show("Hapus data untuk ID_closing: " & tbkdcl.Text & "?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim query As String = "DELETE FROM barang_closing WHERE ID_closing = @ID_closing"
                Dim command As New MySqlCommand(query, Koneksi)
                command.Parameters.AddWithValue("@ID_closing", tbkdcl.Text)


                Dim baris As Integer = command.ExecuteNonQuery()

                ' Periksa apakah ada data yang dihapus
                If baris > 0 Then
                    Call isigrid()
                    Call bersih()
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

    Private Sub barangClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        isicbbkayu()
        isicbbmitra()
        tbkdcl.ReadOnly = True
        tbtdr.ReadOnly = True
    End Sub

    Private Sub dtpcl_ValueChanged(sender As Object, e As EventArgs) Handles dtpcl.ValueChanged
        Try
            Call bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query untuk seleksi berdasarkan tanggal
            Dim query As String = "
            SELECT barang_closing.ID_closing, kayu.nm_kayu, mitra.nama_mitra, barang_closing.tanggal_closing, 
               barang_closing.jumlah_barang_closing, barang_closing.nilai_closing 
            FROM barang_closing 
            JOIN kayu ON barang_closing.kd_kayu = kayu.kd_kayu 
            JOIN mitra ON barang_closing.ID_mitra = mitra.ID_mitra 
            WHERE DATE(barang_closing.tanggal_closing) = @tanggal"

            ' Format tanggal sesuai MySQL dan parameter query
            Dim command As New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@tanggal", dtpcl.Value.ToString("yyyy-MM-dd"))
            Dim adapter As New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "barang_closing")
            DTGVBK.DataSource = dataset.Tables("barang_closing")

        Catch ex As Exception
            ' Tampilkan pesan kesalahan jika ada
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Pastikan koneksi database ditutup
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub


    Private Sub DTGVBK_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGVBK.CellClick
        Try
            Dim gridbaris As DataGridViewRow = DTGVBK.Rows(e.RowIndex)
            tbkdcl.Text = If(IsDBNull(gridbaris.Cells(0).Value) OrElse gridbaris.Cells(0).Value Is Nothing, "", gridbaris.Cells(0).Value.ToString())
            cbnm.Text = If(IsDBNull(gridbaris.Cells(1).Value) OrElse gridbaris.Cells(1).Value Is Nothing, "", gridbaris.Cells(1).Value.ToString())
            cbnmi.Text = If(IsDBNull(gridbaris.Cells(2).Value) OrElse gridbaris.Cells(2).Value Is Nothing, "", gridbaris.Cells(2).Value.ToString())
            dtpcl.Text = If(IsDBNull(gridbaris.Cells(3).Value) OrElse gridbaris.Cells(3).Value Is Nothing, "", gridbaris.Cells(3).Value.ToString())
            tbjbr.Text = If(IsDBNull(gridbaris.Cells(4).Value) OrElse gridbaris.Cells(4).Value Is Nothing, "", gridbaris.Cells(4).Value.ToString())
            tbtdr.Text = If(IsDBNull(gridbaris.Cells(5).Value) OrElse gridbaris.Cells(5).Value Is Nothing, "", gridbaris.Cells(5).Value.ToString())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Detail: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class