Public Class FormUtama


    'akses tertutup jika user logout
    Private Sub logout_sistem()
        KategoriToolStripMenuItem.Enabled = False
        BarangToolStripMenuItem.Enabled = False
        GudangToolStripMenuItem.Enabled = False
        KontrolAdminToolStripMenuItem.Enabled = False

    End Sub
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logout_sistem()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End 'Coding otomatis keluar
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Anda keluar dari sistem ?", "KONFIRMASI LOGOUT DARI SISTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            logout_sistem()
            FormLogin.cboName.Text = " "
            FormLogin.txtPassword.Text = " "
            FormLogin.cboBag.Text = " "
            FormLogin.btnMasuk.Enabled = False
            FormLogin.cboName.Focus()
            FormLogin.Show()
            LogoutToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.cboName.Text = ""
        FormLogin.txtPassword.Text = ""
        FormLogin.cboBag.Text = ""
        FormLogin.btnMasuk.Enabled = False
        FormLogin.cboName.Focus()
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub FormUtama_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub TambahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahBarangToolStripMenuItem.Click
        formBarang.Show()
        Me.Hide()

    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        BarangMasuk.Show()
        Me.Hide()

    End Sub

    Private Sub KontrolAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KontrolAdminToolStripMenuItem.Click
        FormAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub TambahKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKategoriToolStripMenuItem.Click
        FormKategori.Show()
        Me.Hide()

    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click

    End Sub

    Private Sub DataKategoriKayuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKategoriKayuToolStripMenuItem.Click
        FormKategoriData.Show()
        Me.Hide()

    End Sub

    Private Sub DataKayuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKayuToolStripMenuItem.Click
        FormDataBarang.Show()
        Me.Hide()

    End Sub

    Private Sub ProdusesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier.Show()
        Me.Hide()

    End Sub

    Private Sub LaporanAdminToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdusenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdusenToolStripMenuItem.Click
        Produsen.Show()
        Me.Hide()

    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        barangClosing.Show()
        Me.Hide()

    End Sub

    Private Sub LaporanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanBarangToolStripMenuItem.Click
        LaporanBarang.Show()
        Me.Hide()

    End Sub

    Private Sub LaporanGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanGudangToolStripMenuItem.Click
        LaporanGudang.Show()
        Me.Hide()

    End Sub
End Class
