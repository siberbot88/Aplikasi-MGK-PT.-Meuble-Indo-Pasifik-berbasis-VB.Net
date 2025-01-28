<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.MySqlConnection1 = New MySql.Data.MySqlClient.MySqlConnection()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontrolAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GudangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdusenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKategoriKayuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKayuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanGudangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.top2
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.GudangToolStripMenuItem, Me.KategoriToolStripMenuItem, Me.BarangToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.KontrolAdminToolStripMenuItem})
        Me.AdminToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.LoginToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'KontrolAdminToolStripMenuItem
        '
        Me.KontrolAdminToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.KontrolAdminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.KontrolAdminToolStripMenuItem.Image = CType(resources.GetObject("KontrolAdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KontrolAdminToolStripMenuItem.Name = "KontrolAdminToolStripMenuItem"
        Me.KontrolAdminToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.KontrolAdminToolStripMenuItem.Text = "Kontrol Admin"
        '
        'GudangToolStripMenuItem
        '
        Me.GudangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.ProdusenToolStripMenuItem})
        Me.GudangToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GudangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GudangToolStripMenuItem.Image = CType(resources.GetObject("GudangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GudangToolStripMenuItem.Name = "GudangToolStripMenuItem"
        Me.GudangToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.GudangToolStripMenuItem.Text = "Gudang"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BarangMasukToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BarangMasukToolStripMenuItem.Image = CType(resources.GetObject("BarangMasukToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BarangKeluarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BarangKeluarToolStripMenuItem.Image = CType(resources.GetObject("BarangKeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Closing"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.AutoToolTip = True
        Me.SupplierToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SupplierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'ProdusenToolStripMenuItem
        '
        Me.ProdusenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ProdusenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProdusenToolStripMenuItem.Name = "ProdusenToolStripMenuItem"
        Me.ProdusenToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProdusenToolStripMenuItem.Text = "Produsen"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKategoriToolStripMenuItem, Me.DataKategoriKayuToolStripMenuItem})
        Me.KategoriToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KategoriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KategoriToolStripMenuItem.Image = CType(resources.GetObject("KategoriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        '
        'TambahKategoriToolStripMenuItem
        '
        Me.TambahKategoriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TambahKategoriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TambahKategoriToolStripMenuItem.Image = CType(resources.GetObject("TambahKategoriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TambahKategoriToolStripMenuItem.Name = "TambahKategoriToolStripMenuItem"
        Me.TambahKategoriToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.TambahKategoriToolStripMenuItem.Text = "Tambah Kategori"
        '
        'DataKategoriKayuToolStripMenuItem
        '
        Me.DataKategoriKayuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataKategoriKayuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DataKategoriKayuToolStripMenuItem.Image = CType(resources.GetObject("DataKategoriKayuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataKategoriKayuToolStripMenuItem.Name = "DataKategoriKayuToolStripMenuItem"
        Me.DataKategoriKayuToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DataKategoriKayuToolStripMenuItem.Text = "Data Kategori Kayu"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahBarangToolStripMenuItem, Me.DataKayuToolStripMenuItem})
        Me.BarangToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BarangToolStripMenuItem.Image = CType(resources.GetObject("BarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.BarangToolStripMenuItem.Text = "Kayu"
        '
        'TambahBarangToolStripMenuItem
        '
        Me.TambahBarangToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TambahBarangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TambahBarangToolStripMenuItem.Image = CType(resources.GetObject("TambahBarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TambahBarangToolStripMenuItem.Name = "TambahBarangToolStripMenuItem"
        Me.TambahBarangToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TambahBarangToolStripMenuItem.Text = "Tambah Kayu"
        '
        'DataKayuToolStripMenuItem
        '
        Me.DataKayuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataKayuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DataKayuToolStripMenuItem.Image = CType(resources.GetObject("DataKayuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataKayuToolStripMenuItem.Name = "DataKayuToolStripMenuItem"
        Me.DataKayuToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DataKayuToolStripMenuItem.Text = "Data Kayu"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanGudangToolStripMenuItem, Me.LaporanBarangToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanGudangToolStripMenuItem
        '
        Me.LaporanGudangToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.LaporanGudangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LaporanGudangToolStripMenuItem.Name = "LaporanGudangToolStripMenuItem"
        Me.LaporanGudangToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LaporanGudangToolStripMenuItem.Text = "Laporan Gudang"
        '
        'LaporanBarangToolStripMenuItem
        '
        Me.LaporanBarangToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.LaporanBarangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LaporanBarangToolStripMenuItem.Name = "LaporanBarangToolStripMenuItem"
        Me.LaporanBarangToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LaporanBarangToolStripMenuItem.Text = "Laporan Barang"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory2
        Me.ClientSize = New System.Drawing.Size(824, 501)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Manajemen Stok Kayu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MySqlConnection1 As MySql.Data.MySqlClient.MySqlConnection
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KontrolAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanGudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKategoriKayuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKayuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdusenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanBarangToolStripMenuItem As ToolStripMenuItem
End Class
