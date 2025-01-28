Imports MySql.Data.MySqlClient
Public Class FormKategori
    Public strSql As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public datardr As MySqlDataReader
    Public DS As DataSet
    Public simpan, hapus As String

    Sub bersih()
        txtKdKtg.Text = ""
        txtNmKtg.Text = ""
    End Sub

    Sub generateCode()
        Dim genCode As String
        genCode = Microsoft.VisualBasic.UCase(txtNmKtg.Text)
        txtKdKtg.Text = Mid(genCode, 1, 3) & Format(Now, "ddMMyyhhss")
    End Sub

    Sub isigrid()
        ModulKoneksi.bukaDB()
        adapter = New MySqlDataAdapter("SELECT `kd_kat` AS `KD. Kategori`, `nm_kat` AS `Nama Kategori` FROM `kategori` ORDER BY `kategori`.`kd_kat` ASC", Koneksi)
        DS = New DataSet
        adapter.Fill(DS, "kategori")
        DataGridView1.DataSource = DS.Tables("kategori")
        DataGridView1.ReadOnly = True
    End Sub

    Sub cari()
        Dim userMsg1 As String
        If cbkk.Checked = True Then
            userMsg1 = Microsoft.VisualBasic.InputBox("Masukan Kode kategori disini", "FIELD Kode kategori", "Masukan pencarian...", 500, 300)
            If userMsg1 <> "" Then
                txtKdKtg.Text = userMsg1
                ModulKoneksi.bukaDB()
                adapter = New MySqlDataAdapter("SELECT `kd_kat` AS `KD. Kategori`, `nm_kat` AS `Nama Kategori` FROM `kategori` WHERE `kd_kat` LIKE '%" & txtKdKtg.Text & "%' ORDER BY `kategori`.`kd_kat` ASC", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "kategori")
                DataGridView1.DataSource = DS.Tables("kategori")
                DataGridView1.ReadOnly = True
            Else
                isigrid()
                bersih()
                cbnk.Checked = False
                MessageBox.Show("Masukan Kode kategori!")
            End If
        End If

        Dim userMsg As String
        If cbnk.Checked = True Then
            userMsg = Microsoft.VisualBasic.InputBox("Masukan Nama kategori disini", "FIELD Nama kategori", "Masukan pencarian...", 500, 300)
            If userMsg <> "" Then
                txtNmKtg.Text = userMsg
                ModulKoneksi.bukaDB()
                adapter = New MySqlDataAdapter("SELECT `kd_kat` AS `KD. Kategori`, `nm_kat` AS `Nama Kategori` FROM `kategori` WHERE `nm_kat` LIKE '%" & txtNmKtg.Text & "%'", Koneksi)
                DS = New DataSet
                adapter.Fill(DS, "kategori")
                DataGridView1.DataSource = DS.Tables("kategori")
                DataGridView1.ReadOnly = True
            Else
                isigrid()
                bersih()
                cbkk.Checked = False
                MessageBox.Show("Masukkan Nama Kategori!!")
            End If
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormKategori_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormUtama.Show()

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

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("UPDATE kategori SET kd_kat=@Bkd, nm_kat=@nm WHERE kd_kat=@Bkd", conn)

                With command.Parameters
                    .AddWithValue("@Bkd", txtKdKtg.Text)
                    .AddWithValue("@nm", txtNmKtg.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("...Data sukses tersimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call isigrid()
                Call cari()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "...Cek, Kesalahan pada input data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKdKtg.Text <> "" Then
            If MessageBox.Show("[Nama kategori " + txtKdKtg.Text.ToString + "] ... Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call bukaDB()
                hapus = "Delete from kategori where kd_kat='" & txtKdKtg.Text & "'"
                CMD = New MySqlCommand(hapus, Koneksi)
                CMD.ExecuteNonQuery()
                Call isigrid()
                Call bersih()
                txtKdKtg.Focus()

                MessageBox.Show(txtKdKtg.Text.ToString & "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf txtKdKtg.Text <> "" Then
            If MessageBox.Show("[Nama kategori : " + txtNmKtg.Text.ToString + "]...Hapus data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call bukaDB()
                hapus = "Delete from kategori where nm_kat='" & txtNmKtg.Text & "'"
                CMD = New MySqlCommand(hapus, Koneksi)
                CMD.ExecuteNonQuery()
                Call isigrid()
                Call bersih()
                MessageBox.Show(txtNmKtg.Text.ToString & "...Data sudah dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Tidak ada data untuk dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        btnKeluar.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnUbah.Enabled = True
        btnTambah.Enabled = True
        btnHapus.Enabled = True

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Hide()
        FormUtama.Show()

    End Sub

    Private Sub cbkk_CheckedChanged(sender As Object, e As EventArgs) Handles cbkk.CheckedChanged
        If cbkk.Checked = True Then
            cari()
            cbnk.Checked = False
        Else
            cbkk.Checked = False
        End If
    End Sub

    Private Sub cbnk_CheckedChanged(sender As Object, e As EventArgs) Handles cbnk.CheckedChanged
        If cbnk.Checked = True Then
            cbkk.Checked = False
            cari()
        Else
            cbnk.Checked = False
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call bukaDB()
        Try
            CMD = New MySqlCommand("select*from kategori where kd_kat='" & txtKdKtg.Text & "'", Koneksi)
            Try
                Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                txtKdKtg.Text = gridbaris.Cells(0).Value.ToString
                txtNmKtg.Text = gridbaris.Cells(1).Value.ToString
                datardr = CMD.ExecuteReader
                If datardr.HasRows Then
                    Do While datardr.Read
                        txtNmKtg.Text = datardr("nm_kat")
                    Loop
                    datardr.Close()
                Else
                End If
                datardr.Close()
            Catch ex As Exception
                MsgBox("Pilih data didalam tabel", MsgBoxStyle.Information, "INFORMASI")
            End Try
        Catch ex As Exception
            MsgBox("Pilih data didalam tabel", MsgBoxStyle.Information, "INFORMASI")
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim userMsg As String
        If txtNmKtg.Text = "" Then
            MsgBox("Nama kategori Kosong..", vbExclamation, "INPUT")
            userMsg = Microsoft.VisualBasic.InputBox("Masukkan Nama kategori disini", "Field Nama kategori", "Masukkan Nama kategori..", 500, 300)
            txtNmKtg.Text = userMsg
            txtNmKtg.Focus()
            Exit Sub

        ElseIf txtNmKtg.Text <> "" Then
            generateCode()
            If MessageBox.Show("Kode kategori: " & txtKdKtg.Text.ToString & " || Nama kategori: " & txtNmKtg.Text.ToString & vbNewLine & "Simpan data?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Call bukaDB()
                    Dim cmd As New MySqlCommand("INSERT INTO kategori (kd_kat, nm_kat) VALUES ('" & txtKdKtg.Text & "', '" & txtNmKtg.Text & "')", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")
                    isigrid()
                    bersih()
                    btnTambah.Enabled = True

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isigrid()
        txtKdKtg.Text = ""
        txtNmKtg.Text = ""

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        btnKeluar.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnUbah.Enabled = True
        btnTambah.Enabled = True
        btnHapus.Enabled = True
    End Sub
End Class