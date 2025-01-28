Imports MySql.Data.MySqlClient
Public Class LaporanBarang
    Public strSQL As String
    Public databases As MySqlConnection
    Public command As MySqlCommand
    Public dataadapter As MySqlDataAdapter
    Public datareader As MySqlDataReader
    Public dataset As DataSet
    Public simpan, hapus As String

    Sub bersih()
        tbnmk.Text = ""
    End Sub

    Sub isigrid()
        ModulKoneksi.bukaDB()
        Dim query1 As String = "SELECT * from sisa_stok"
        adapter = New MySqlDataAdapter(query1, Koneksi)
        dataset = New DataSet
        adapter.Fill(dataset, "sisa_stok")
        DGTVLB.DataSource = dataset.Tables("sisa_stok")
        DGTVLB.ReadOnly = True
    End Sub

    Private Sub tbnmk_TextChanged(sender As Object, e As EventArgs) Handles tbnmk.TextChanged
        Try
            ModulKoneksi.bukaDB()

            If dataset IsNot Nothing Then
                dataset.Clear()
            Else
                dataset = New DataSet()
            End If


            Dim query As String = "SELECT * FROM sisa_stok WHERE nama_kayu LIKE @namaKayu"
            command = New MySqlCommand(query, Koneksi)
            command.Parameters.AddWithValue("@namaKayu", "%" & tbnmk.Text & "%")
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dataset, "sisa_stok")
            DGTVLB.DataSource = dataset.Tables("sisa_stok")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Pastikan koneksi database ditutup
            If Koneksi IsNot Nothing AndAlso Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormUtama.Show()
        Me.Hide()

    End Sub

    Private Sub LaporanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()

    End Sub
End Class