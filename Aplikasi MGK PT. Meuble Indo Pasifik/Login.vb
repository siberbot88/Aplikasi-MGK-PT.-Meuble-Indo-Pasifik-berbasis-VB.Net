Imports MySql.Data.MySqlClient
Public Class FormLogin
    Public strSql As String
    Public db As MySqlConnection
    Public cmd As MySqlCommand
    Public dadapter As MySqlDataAdapter
    Public datard As MySqlDataReader
    Public ds As New DataSet
    Dim conn As New AksesData.KoneksiDB

    Sub seleksi_divisi()
        Try
            If cboBag.SelectedIndex = 1 Then
                'Hak akses akun Gudang (menu Gudang)
                FormUtama.LogoutToolStripMenuItem.Enabled = True
                FormUtama.LoginToolStripMenuItem.Enabled = False
                FormUtama.KontrolAdminToolStripMenuItem.Enabled = False
                FormUtama.KategoriToolStripMenuItem.Enabled = False
                FormUtama.BarangToolStripMenuItem.Enabled = False
                FormUtama.GudangToolStripMenuItem.Enabled = True
                FormUtama.Show()
                Me.Hide()
                Exit Sub

            Else
                'untuk hak akses akun master (semua Menu)
                FormUtama.LogoutToolStripMenuItem.Enabled = True
                FormUtama.LoginToolStripMenuItem.Enabled = False
                FormUtama.KontrolAdminToolStripMenuItem.Enabled = True
                FormUtama.KategoriToolStripMenuItem.Enabled = True
                FormUtama.BarangToolStripMenuItem.Enabled = True
                FormUtama.LaporanToolStripMenuItem.Enabled = True
                FormUtama.GudangToolStripMenuItem.Enabled = True
                FormUtama.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString())
        End Try
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBatal_Click(sender, e)
        Call bukaDB()
        cmd = New MySqlCommand("select * from admin", Koneksi)
        datard = cmd.ExecuteReader
        cboName.Items.Clear()
        Do While datard.Read
            cboName.Items.Add(datard("username"))
        Loop
        datard.Close()
    End Sub

    Private Sub FormLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormUtama.Enabled = True
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If cboName.Text = " " Then
            MsgBox("Username Kosong..", vbExclamation, "PILIH")
            cboName.Focus()
            Exit Sub

        ElseIf txtPassword.Text = " " Then
            MsgBox("Password Kosong", vbExclamation, "INPUT")
            txtPassword.Focus()
            Exit Sub

        ElseIf cbobag.Text = "" Then
            MsgBox("Divisi Kosong", vbExclamation, "PILIH")
            cboBag.Focus()

        ElseIf cboName.Text & txtPassword.Text & cboBag.SelectedItem.ToString <> "" Then
            If MessageBox.Show("Anda melakukan login dengan kode admin :" + cboName.Text.ToString + " Bagian :" + cboBag.SelectedItem.ToString + " ", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim StrSQL As String = "SELECT * FROM `admin` WHERE `username` = @B_us AND `userpass` = @B_ps AND `divisi`= @div"
                    Dim MyCommand As New MySqlCommand(StrSQL, conn.open)
                    MyCommand.Parameters.Add("@B_us", MySqlDbType.Text).Value = cboName.SelectedItem
                    MyCommand.Parameters.Add("@B_ps", MySqlDbType.Text).Value = txtPassword.Text
                    MyCommand.Parameters.Add("@div", MySqlDbType.Text).Value = cboBag.SelectedIndex.ToString

                    Dim rdr As MySqlDataReader = MyCommand.ExecuteReader
                    If rdr.Read = False Then
                        MsgBox("Data tidak Ada !!", vbYes, "Login")
                        cboName.Text = ""
                        txtPassword.Text = ""
                        cboBag.Text = ""

                    Else
                        MsgBox("Data ada!!", vbYes, "Login")
                        seleksi_divisi()
                    End If
                    rdr.Close()
                Catch sqlex As Exception
                    Throw New Exception(sqlex.Message.ToString())
                End Try
            End If
        End If
    End Sub

    Private Sub cboName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboName.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            MessageBox.Show("Pilih", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cboBag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboBag.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            MessageBox.Show("Pilih", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cboBag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBag.SelectedIndexChanged
        btnMasuk.Enabled = True

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        cboName.Text = ""
        txtPassword.Text = ""
        cboBag.Text = ""
        btnMasuk.Enabled = False
        cboName.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class