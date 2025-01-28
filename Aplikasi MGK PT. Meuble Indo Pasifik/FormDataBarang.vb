Imports MySql.Data.MySqlClient
Public Class FormDataBarang
    Public strsql As String
    Public database As MySqlConnection
    Public command As MySqlCommand
    Public dataadp As MySqlDataAdapter
    Public dataread As MySqlDataReader
    Public dataset As DataSet
    Dim hapus As String


    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Hide()
        FormUtama.Show()

    End Sub

    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        isicbb()
        DGVdk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    'untuk mengisi datagrid
    Sub isigrid()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT k.kd_kayu, k.nm_kayu, kt.nm_kat, k.stok, k.harga_beli, k.harga_pokok, k.harga_jual FROM kayu k JOIN kategori kt ON k.kd_kat = kt.kd_kat"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "kayu")
        DGVdk.DataSource = dataset.Tables("kayu")
        DGVdk.ReadOnly = True
    End Sub

    'untuk mengisi combobox kategori
    Sub isicbb()
        Call bukaDB()
        Try
            command = New MySqlCommand("select nm_kat from kategori", Koneksi)
            dataread = command.ExecuteReader
            cbbktk.Items.Clear()
            Do While dataread.Read
                cbbktk.Items.Add(dataread("nm_kat").ToString())
            Loop
            dataread.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub bersih()
        tbck.Text = ""
    End Sub


    'untuk melakukan filtering data
    Sub filterdata()
        Try
            ModulKoneksi.bukaDB()
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If
            'Dim query As String = "SELECT k.kd_kayu, k.nm_kayu, kt.nm_kat, k.stok, k.harga_beli, k.harga_pokok, k.harga_jual FROM kayu k JOIN kategori kt ON k.kd_kat = kt.kd_kat"
            Dim query As String = "SELECT k.kd_kayu, k.nm_kayu, kt.nm_kat, k.stok, k.harga_beli, k.harga_pokok, k.harga_jual FROM kayu k JOIN kategori kt ON k.kd_kat = kt.kd_kat"


            'ambil input data filtering
            Dim selectedkategorikayu As String = If(cbbktk.SelectedItem, "").ToString()
            Dim selectedharga As String = If(cbbhg.SelectedItem, "").ToString()
            Dim selectedkategoriharga As String = If(cbbkh.SelectedItem, "").ToString()

            'filter kategori kayu
            If Not String.IsNullOrEmpty(selectedkategorikayu) Then
                Select Case selectedkategorikayu
                    Case "Kayu Ringan/ olahan"
                        query &= " WHERE kt.kd_kat = 'KAY1811240901' "
                    Case "Kayu Lunak"
                        query &= " WHERE kt.kd_kat = 'KAY1811240928' "
                    Case "Kayu Keras"
                        query &= " WHERE kt.kd_kat = 'KAY1811240933' "
                    Case "Kayu Tropis"
                        query &= " WHERE kt.kd_kat = 'KAY1811240959' "
                End Select

            End If

            If Not String.IsNullOrEmpty(selectedharga) Then
                Select Case selectedharga
                    Case "Harga Beli"
                        query &= " ORDER BY k.harga_beli"
                    Case "Harga Pokok"
                        query &= " ORDER BY k.harga_pokok"
                    Case "Harga Jual"
                        query &= " ORDER BY k.harga_jual"
                End Select
            End If

            If selectedkategoriharga = "Termurah" Then
                query &= " ASC"
            ElseIf selectedkategoriharga = "Termahal" Then
                query &= " DESC"
            End If

            command = New MySqlCommand(query, Koneksi)

            'parameter 
            If Not String.IsNullOrEmpty(selectedkategorikayu) Then
                command.Parameters.AddWithValue("@kategori", selectedkategorikayu)
            End If

            'menampilkan data pada datagrid
            adapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "kayu")
            DGVdk.DataSource = dataset.Tables("kayu")
            query = ""

        Catch ex As Exception
            MessageBox.Show("terjadi kesalahan: " & ex.Message)
        Finally
            Koneksi.Close()
        End Try
    End Sub

    'untuk mencari
    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        filterdata()
    End Sub

    Private Sub tbck_TextChanged(sender As Object, e As EventArgs) Handles tbck.TextChanged
        Try
            ModulKoneksi.bukaDB()

            ' Bersihkan dataset sebelum query baru
            If dataset IsNot Nothing Then
                dataset.Clear()
            End If

            ' Query untuk LIKE nm_kayu
            Dim query As String = "SELECT k.kd_kayu, k.nm_kayu, kt.nm_kat, k.stok, k.harga_beli, k.harga_pokok, k.harga_jual " &
                              "FROM kayu k JOIN kategori kt ON k.kd_kat = kt.kd_kat " &
                              "WHERE k.nm_kayu LIKE @namaKayu"

            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@namaKayu", "%" & tbck.Text & "%")
            adapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset, "kayu")
            DGVdk.DataSource = dataset.Tables("kayu")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Koneksi.Close()
        End Try
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click

        If MessageBox.Show("[nama kayu " + tbck.Text.ToString + "]...Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call bukaDB()
            hapus = "DELETE FROM kayu WHERE nm_kayu='" & tbck.Text & "'"
            command = New MySqlCommand(hapus, Koneksi)
            command.ExecuteNonQuery()
            Call isigrid()
            Call bersih()
            tbck.Focus()
            MessageBox.Show(tbck.Text.ToString + "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    'klik datagridview
    Private Sub DGVdk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdk.CellContentClick
        Try
            Dim gridbaris As DataGridViewRow = DGVdk.Rows(e.RowIndex)
            tbck.Text = gridbaris.Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

End Class