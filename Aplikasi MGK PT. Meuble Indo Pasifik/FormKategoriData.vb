Imports MySql.Data.MySqlClient
Public Class FormKategoriData
    Public strSql As String
    Public hitung As String
    Public Dbase As MySqlConnection
    Public Com As MySqlCommand
    Public Adap As MySqlDataAdapter
    Public dread As MySqlDataReader
    Public DS As New DataSet
    Private Sub FormKategoriData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        Call bukaDB()
        Com = New MySqlCommand("select * from kategori", Koneksi)
        dread = Com.ExecuteReader
        cbbkat.Items.Clear()
        Do While dread.Read
            cbbkat.Items.Add(dread("nm_kat"))
        Loop
        dgvKtgKayu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dread.Close()

    End Sub

    Sub isigrid()

        ModulKoneksi.bukaDB()
        adapter = New MySqlDataAdapter("SELECT kd_kat, kd_kayu, nm_kayu, deskripsi FROM kayu", Koneksi)
        DS = New DataSet
        adapter.Fill(DS, "kayu")
        dgvKtgKayu.DataSource = DS.Tables("kayu")
        dgvKtgKayu.ReadOnly = True

        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM kayu", Koneksi)
        Dim totalData As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lbTtl.Text = "" & totalData.ToString()

    End Sub

    Private Sub cbbkat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbkat.SelectedIndexChanged
        Try
            If cbbkat.SelectedIndex = 0 Then
                'tampilan Data kayu ringan/olahan
                ModulKoneksi.bukaDB()
                adapter = New MySqlDataAdapter("SELECT kd_kat, kd_kayu, nm_kayu, deskripsi FROM kayu where kd_kat = 'KAY1811240901'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "kayu")
                dgvKtgKayu.DataSource = DS.Tables("kayu")
                dgvKtgKayu.ReadOnly = True

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM kayu", Koneksi)
                Dim totalData As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lbTtl.Text = "" & totalData.ToString()

                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM kayu WHERE kd_kat = 'KAY1811240901'", Koneksi)
                Dim totalDatakat As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                lbang.Text = ": " & totalDatakat.ToString()

                lbname.Text = cbbkat.Text


            ElseIf cbbkat.SelectedIndex = 1 Then
                'tampilan Data kayu lunak
                ModulKoneksi.bukaDB()
                adapter = New MySqlDataAdapter("SELECT kd_kat, kd_kayu, nm_kayu, deskripsi FROM kayu where kd_kat = 'KAY1811240928'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "kayu")
                dgvKtgKayu.DataSource = DS.Tables("kayu")
                dgvKtgKayu.ReadOnly = True

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM kayu", Koneksi)
                Dim totalData As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lbTtl.Text = "" & totalData.ToString()

                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM kayu WHERE kd_kat = 'KAY1811240928'", Koneksi)
                Dim totalDatakat As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                lbang.Text = ": " & totalDatakat.ToString()

                lbname.Text = cbbkat.Text

            ElseIf cbbkat.SelectedIndex = 2 Then
                'tampilan Data kayu Keras
                ModulKoneksi.bukaDB()
                adapter = New MySqlDataAdapter("SELECT kd_kat, kd_kayu, nm_kayu, deskripsi FROM kayu where kd_kat = 'KAY1811240933'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "kayu")
                dgvKtgKayu.DataSource = DS.Tables("kayu")
                dgvKtgKayu.ReadOnly = True

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM kayu", Koneksi)
                Dim totalData As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lbTtl.Text = "" & totalData.ToString()

                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM kayu WHERE kd_kat = 'KAY1811240933'", Koneksi)
                Dim totalDatakat As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                lbang.Text = ": " & totalDatakat.ToString()

                lbname.Text = cbbkat.Text

            ElseIf cbbkat.SelectedIndex = 3 Then
                'tampilan Data kayu Tropis
                ModulKoneksi.bukaDB()
                adapter = New MySqlDataAdapter("SELECT kd_kat, kd_kayu, nm_kayu, deskripsi FROM kayu where kd_kat = 'KAY1811240959'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "kayu")
                dgvKtgKayu.DataSource = DS.Tables("kayu")
                dgvKtgKayu.ReadOnly = True

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM kayu", Koneksi)
                Dim totalData As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lbTtl.Text = "" & totalData.ToString()

                Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM kayu WHERE kd_kat = 'KAY1811240959'", Koneksi)
                Dim totalDatakat As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                lbang.Text = ": " & totalDatakat.ToString()
            Else
                isigrid()

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FormKategoriData_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormUtama.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormUtama.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvKtgKayu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKtgKayu.CellContentClick

    End Sub
End Class