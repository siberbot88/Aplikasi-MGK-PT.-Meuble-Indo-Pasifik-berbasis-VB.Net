Imports MySql.Data.MySqlClient
Public Class LaporanGudang
    Public strSQL As String
    Public databases As MySqlConnection
    Public command As MySqlCommand
    Public dataadapter As MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public dataset As DataSet
    Public simpan, hapus As String

    Sub bersih()
        tblg.Text = ""
        dtplg.Text = ""
    End Sub

    Sub isigridbarangmasuk()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT barang_masuk.ID_receiving, kayu.nm_kayu, supplier.nama_supplier, barang_masuk.tanggal_receiving, barang_masuk.jumlah_barang_receiving, barang_masuk.nilai_receiving FROM barang_masuk JOIN kayu ON barang_masuk.kd_kayu = kayu.kd_kayu JOIN supplier ON barang_masuk.ID_supplier = supplier.ID_supplier"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "barang_masuk")
        DTGVLGBM.DataSource = dataset.Tables("barang_masuk")
        DTGVLGBM.ReadOnly = True
    End Sub

    Sub isigridbarangkeluar()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT barang_closing.ID_closing, kayu.nm_kayu, mitra.nama_mitra, barang_closing.tanggal_closing, barang_closing.jumlah_barang_closing, barang_closing.nilai_closing FROM barang_closing JOIN kayu ON barang_closing.kd_kayu = kayu.kd_kayu JOIN mitra ON barang_closing.ID_mitra = mitra.ID_mitra"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "barang_closing")
        DTGVLPBC.DataSource = dataset.Tables("barang_closing")
        DTGVLPBC.ReadOnly = True
    End Sub

    Private Sub tblg_TextChanged(sender As Object, e As EventArgs) Handles tblg.TextChanged
        ' Barang Masuk
        Try
            ModulKoneksi.bukaDB()
            Dim datasetMasuk As New DataSet()
            Dim queryMasuk As String = "SELECT barang_masuk.ID_receiving, kayu.nm_kayu, supplier.nama_supplier, barang_masuk.tanggal_receiving, barang_masuk.jumlah_barang_receiving, barang_masuk.nilai_receiving " &
                                   "FROM barang_masuk " &
                                   "JOIN kayu ON barang_masuk.kd_kayu = kayu.kd_kayu " &
                                   "JOIN supplier ON barang_masuk.ID_supplier = supplier.ID_supplier " &
                                   "WHERE kayu.nm_kayu LIKE @namaKayu"

            Dim commandMasuk As New MySqlCommand(queryMasuk, Koneksi)
            commandMasuk.Parameters.AddWithValue("@namaKayu", "%" & tblg.Text & "%")

            Dim adapterMasuk As New MySqlDataAdapter(commandMasuk)
            adapterMasuk.Fill(datasetMasuk, "barang_masuk")
            DTGVLGBM.DataSource = datasetMasuk.Tables("barang_masuk")
        Catch ex As Exception
            MessageBox.Show("Kesalahan Barang Masuk: " & ex.Message)
        Finally
            ' Tutup koneksi untuk barang_masuk
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try


        ' Barang Closing
        Try
            ModulKoneksi.bukaDB()
            Dim datasetClosing As New DataSet()
            Dim queryClosing As String = "SELECT barang_closing.ID_closing, kayu.nm_kayu, mitra.nama_mitra, barang_closing.tanggal_closing, barang_closing.jumlah_barang_closing, barang_closing.nilai_closing " &
                                     "FROM barang_closing " &
                                     "JOIN kayu ON barang_closing.kd_kayu = kayu.kd_kayu " &
                                     "JOIN mitra ON barang_closing.ID_mitra = mitra.ID_mitra " &
                                     "WHERE kayu.nm_kayu LIKE @namaKayu"

            Dim commandClosing As New MySqlCommand(queryClosing, Koneksi)
            commandClosing.Parameters.AddWithValue("@namaKayu", "%" & tblg.Text & "%")

            Dim adapterClosing As New MySqlDataAdapter(commandClosing)
            adapterClosing.Fill(datasetClosing, "barang_closing")

            DTGVLPBC.DataSource = datasetClosing.Tables("barang_closing")
        Catch ex As Exception
            MessageBox.Show("Kesalahan Barang Closing: " & ex.Message)
        Finally
            ' Tutup koneksi untuk barang_closing
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub

    Private Sub dtplg_ValueChanged(sender As Object, e As EventArgs) Handles dtplg.ValueChanged
        'barang masuk
        Try
            Call bukaDB()

            ' Bersihkan dataset sebelum query baru
            Dim datasetMasuk As New DataSet()

            ' Query untuk seleksi berdasarkan tanggal
            Dim query As String = "
            SELECT barang_masuk.ID_receiving, kayu.nm_kayu, supplier.nama_supplier, barang_masuk.tanggal_receiving, 
               barang_masuk.jumlah_barang_receiving, barang_masuk.nilai_receiving 
            FROM barang_masuk 
            JOIN kayu ON barang_masuk.kd_kayu = kayu.kd_kayu 
            JOIN supplier ON barang_masuk.ID_supplier = supplier.ID_supplier 
            WHERE DATE(barang_masuk.tanggal_receiving) = @tanggal"


            Dim command As New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@tanggal", dtplg.Value.ToString("yyyy-MM-dd"))
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(datasetMasuk, "barang_masuk")

            DTGVLGBM.DataSource = datasetMasuk.Tables("barang_masuk")
        Catch ex As Exception
            MessageBox.Show("Kesalahan Barang Masuk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try

        'barang keluar
        Try
            Call bukaDB()

            ' Bersihkan dataset sebelum query baru
            Dim datasetClosing As New DataSet()

            ' Query untuk seleksi berdasarkan tanggal
            Dim query As String = "
            SELECT barang_closing.ID_closing, kayu.nm_kayu, mitra.nama_mitra, barang_closing.tanggal_closing, 
               barang_closing.jumlah_barang_closing, barang_closing.nilai_closing 
            FROM barang_closing 
            JOIN kayu ON barang_closing.kd_kayu = kayu.kd_kayu 
            JOIN mitra ON barang_closing.ID_mitra = mitra.ID_mitra 
            WHERE DATE(barang_closing.tanggal_closing) = @tanggal"

            ' Parameter tanggal
            Dim command As New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@tanggal", dtplg.Value.ToString("yyyy-MM-dd"))
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(datasetClosing, "barang_closing")

            ' Bind data ke DataGridView
            DTGVLPBC.DataSource = datasetClosing.Tables("barang_closing")
        Catch ex As Exception
            MessageBox.Show("Kesalahan Barang Closing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormUtama.Show()
        Me.Hide()

    End Sub

    Private Sub LaporanGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigridbarangkeluar()
        isigridbarangmasuk()

    End Sub
End Class