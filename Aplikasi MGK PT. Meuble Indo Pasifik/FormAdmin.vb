Imports MySql.Data.MySqlClient
Public Class FormAdmin
    Public strSql As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public datardr As MySqlDataReader
    Public DS As New DataSet
    Public simpan, hapus As String

    Sub bersih()
        txtKdadmin.Text = ""
        txtUsername.Text = ""
        txtUsername.Focus()
        txtPassword.Text = ""
        CboBag.Text = ""
    End Sub

    Sub generateKode()
        Dim myPhrase As String
        myPhrase = txtUsername.Text
        txtKdadmin.Text = DateTime.Now.ToString("ddyy") & DateTime.Now.ToString("HHmmss") & Mid(myPhrase, 1, 3) & CboBag.SelectedIndex.ToString
    End Sub

    Sub isiGrid()
        ModulKoneksi.bukaDB()
        adapter = New MySqlDataAdapter("select `kd_admin`, `username` from admin", Koneksi)
        DS = New DataSet
        adapter.Fill(DS, "admin")
        DataGridView1.DataSource = DS.Tables("admin")
        DataGridView1.ReadOnly = True
    End Sub

    Sub cari()
        Dim userMsg As String
        If cbKA.Checked = True Then
            userMsg = Microsoft.VisualBasic.InputBox("Masukkan KODE ADMIN disini", "FIELD KODE ADMIN", "Masukkan Pencarian...", 500, 300)
            If userMsg <> "" Then
                txtKdadmin.Text = userMsg
                ModulKoneksi.bukaDB()

                adapter = New MySqlDataAdapter("select `kd_admin`, `username` from `admin` where `kd_admin` LIKE '" + "%" & txtKdadmin.Text & "%" + "'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "admin")
                DataGridView1.DataSource = DS.Tables("admin")
                DataGridView1.ReadOnly = True

            Else
                isiGrid()
                bersih()
                cbUN.Checked = False
                MessageBox.Show("Masukkan Kode Admin!!")
            End If
        End If

        If cbUN.Checked = True Then
            userMsg = Microsoft.VisualBasic.InputBox("Masukkan USERNAME disini", "FIELD USERNAME", "Masukkan Pencarian...", 500, 300)
            If userMsg <> "" Then
                txtUsername.Text = userMsg
                ModulKoneksi.bukaDB()

                adapter = New MySqlDataAdapter("select `kd_admin`,`username` from `admin` where `username` LIKE '" + "%" & txtUsername.Text & "%" + "'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "admin")
                DataGridView1.DataSource = DS.Tables("admin")
                DataGridView1.ReadOnly = True
            Else
                isiGrid()
                bersih()
                cbKA.Checked = False
                MessageBox.Show("Masukkan Username!!")
            End If
        End If
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
        txtKdadmin.Text = ""
        txtUsername.Text = ""
        txtUsername.Focus()
        txtPassword.Text = ""
        CboBag.Text = ""
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub FormAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormUtama.Show()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim userMsg As String
        If txtUsername.Text = "" Then
            MsgBox("Username Kosong.", vbExclamation, "INPUT")
            userMsg = Microsoft.VisualBasic.InputBox("Masukan Username disini", "Field Username", "Masukan Username...", 500, 300)
            txtUsername.Text = userMsg
            txtUsername.Focus()
            Exit Sub
        ElseIf TxtPassword.Text = "" Then
            MsgBox("Password Kosong", vbExclamation, "INPUT")
            txtPassword.Focus()
            Exit Sub
        ElseIf CboBag.Text = "" Then
            MsgBox("Divisi Kosong", vbExclamation, "PILIH")
            CboBag.Focus()
            Exit Sub
        Else
            If txtKdadmin.Text <> "" And txtUsername.Text <> "" And txtPassword.Text <> "" Then
                generateKode()
                If MessageBox.Show(" [kd_admin: " & txtKdadmin.Text.ToString & "] [username : " & txtUsername.Text.ToString & "] [Password : **************] [Bagian : " & CboBag.SelectedItem.ToString & "]...Simpan data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Call bukaDB()
                        Dim cmd As New MySqlCommand("insert into admin(`kd_admin`, `username`, `userpass`, `divisi`) values('" & txtKdadmin.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & CboBag.SelectedIndex.ToString & "')", Koneksi)

                        cmd.ExecuteNonQuery()
                        MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")

                        isiGrid()
                        bersih()
                        btnTambah.Enabled = True
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
            End If
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If cbKA.Checked = True Then
            If MessageBox.Show("[Kode Admin" + txtKdadmin.Text.ToString + "]...Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                hapus = "DELETE FROM admin WHERE kd_admin='" & txtKdadmin.Text & "'"
                CMD = New MySqlCommand(hapus, Koneksi)
                CMD.ExecuteNonQuery()
                Call isiGrid()
                Call bersih()
                txtKdadmin.Focus()
                MessageBox.Show(txtKdadmin.Text.ToString + "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbUN.Checked = True Then
            If MessageBox.Show("[User name " + txtUsername.Text.ToString + "]...Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call bukaDB()
                hapus = "DELETE FROM admin WHERE username='" & txtUsername.Text & "'"
                CMD = New MySqlCommand(hapus, Koneksi)
                CMD.ExecuteNonQuery()
                Call isiGrid()
                Call bersih()
                txtUsername.Focus()
                MessageBox.Show(txtUsername.Text.ToString + "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("UPDATE admin SET kd_admin=@kd_ad, username=@B_us, userpass=@B_ps, divisi=@div WHERE kd_admin=@kd_ad", conn)
                With command.Parameters
                    .AddWithValue("@kd_ad", txtKdadmin.Text)
                    .AddWithValue("@B_us", txtUsername.Text)
                    .AddWithValue("@B_ps", txtPassword.Text)
                    .AddWithValue("@div", CboBag.SelectedIndex.ToString)
                End With
                command.ExecuteNonQuery()
                MessageBox.Show("Data sukses tersimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call isiGrid()
                Call cari()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "...Cek, Kesalahan pada input data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Hide()
        FormUtama.Show()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        btnTambah.Enabled = False
    End Sub

    Private Sub CboBag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboBag.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            MessageBox.Show("pilih", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cbKA_CheckedChanged(sender As Object, e As EventArgs) Handles cbKA.CheckedChanged
        If cbKA.Checked = True Then
            cari()
            cbUN.Checked = False
        Else
            cbKA.Checked = False
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtKdadmin.Text = gridbaris.Cells(0).Value.ToString
            txtUsername.Text = gridbaris.Cells(1).Value.ToString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        btnKeluar.Enabled = True
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnUbah.Enabled = True
        btnTambah.Enabled = True
        btnHapus.Enabled = True
    End Sub
End Class