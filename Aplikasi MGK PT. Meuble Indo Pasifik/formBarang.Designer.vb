<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTB = New System.Windows.Forms.Panel()
        Me.rtbdes = New System.Windows.Forms.RichTextBox()
        Me.cbkt = New System.Windows.Forms.ComboBox()
        Me.tbnmy = New System.Windows.Forms.TextBox()
        Me.txtky = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTB2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbstok = New System.Windows.Forms.TextBox()
        Me.tbhj = New System.Windows.Forms.TextBox()
        Me.tbpk = New System.Windows.Forms.TextBox()
        Me.tbhb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.DGVB = New System.Windows.Forms.DataGridView()
        Me.PanelTB.SuspendLayout()
        Me.PanelTB2.SuspendLayout()
        CType(Me.DGVB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah kayu"
        '
        'PanelTB
        '
        Me.PanelTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelTB.Controls.Add(Me.rtbdes)
        Me.PanelTB.Controls.Add(Me.cbkt)
        Me.PanelTB.Controls.Add(Me.tbnmy)
        Me.PanelTB.Controls.Add(Me.txtky)
        Me.PanelTB.Controls.Add(Me.Label5)
        Me.PanelTB.Controls.Add(Me.Label4)
        Me.PanelTB.Controls.Add(Me.Label3)
        Me.PanelTB.Controls.Add(Me.Label2)
        Me.PanelTB.Location = New System.Drawing.Point(14, 65)
        Me.PanelTB.Name = "PanelTB"
        Me.PanelTB.Size = New System.Drawing.Size(387, 210)
        Me.PanelTB.TabIndex = 1
        '
        'rtbdes
        '
        Me.rtbdes.Location = New System.Drawing.Point(114, 110)
        Me.rtbdes.Name = "rtbdes"
        Me.rtbdes.Size = New System.Drawing.Size(251, 78)
        Me.rtbdes.TabIndex = 7
        Me.rtbdes.Text = ""
        '
        'cbkt
        '
        Me.cbkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbkt.FormattingEnabled = True
        Me.cbkt.Location = New System.Drawing.Point(111, 70)
        Me.cbkt.Name = "cbkt"
        Me.cbkt.Size = New System.Drawing.Size(223, 23)
        Me.cbkt.TabIndex = 6
        '
        'tbnmy
        '
        Me.tbnmy.Location = New System.Drawing.Point(112, 40)
        Me.tbnmy.MaxLength = 100
        Me.tbnmy.Name = "tbnmy"
        Me.tbnmy.Size = New System.Drawing.Size(223, 23)
        Me.tbnmy.TabIndex = 5
        '
        'txtky
        '
        Me.txtky.Location = New System.Drawing.Point(112, 13)
        Me.txtky.MaxLength = 10
        Me.txtky.Name = "txtky"
        Me.txtky.ReadOnly = True
        Me.txtky.Size = New System.Drawing.Size(223, 23)
        Me.txtky.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Deskripsi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kategori kayu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama kayu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode kayu"
        '
        'PanelTB2
        '
        Me.PanelTB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelTB2.Controls.Add(Me.Label15)
        Me.PanelTB2.Controls.Add(Me.Label14)
        Me.PanelTB2.Controls.Add(Me.Label13)
        Me.PanelTB2.Controls.Add(Me.Label12)
        Me.PanelTB2.Controls.Add(Me.tbstok)
        Me.PanelTB2.Controls.Add(Me.tbhj)
        Me.PanelTB2.Controls.Add(Me.tbpk)
        Me.PanelTB2.Controls.Add(Me.tbhb)
        Me.PanelTB2.Controls.Add(Me.Label9)
        Me.PanelTB2.Controls.Add(Me.Label8)
        Me.PanelTB2.Controls.Add(Me.Label7)
        Me.PanelTB2.Controls.Add(Me.Label6)
        Me.PanelTB2.Location = New System.Drawing.Point(418, 65)
        Me.PanelTB2.Name = "PanelTB2"
        Me.PanelTB2.Size = New System.Drawing.Size(393, 210)
        Me.PanelTB2.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(336, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 15)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "(pcs)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(336, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "(Rp.)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(336, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "(Rp.)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(336, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "(Rp.)"
        '
        'tbstok
        '
        Me.tbstok.Location = New System.Drawing.Point(130, 97)
        Me.tbstok.Name = "tbstok"
        Me.tbstok.Size = New System.Drawing.Size(200, 23)
        Me.tbstok.TabIndex = 17
        '
        'tbhj
        '
        Me.tbhj.Location = New System.Drawing.Point(130, 70)
        Me.tbhj.Name = "tbhj"
        Me.tbhj.Size = New System.Drawing.Size(200, 23)
        Me.tbhj.TabIndex = 16
        '
        'tbpk
        '
        Me.tbpk.Location = New System.Drawing.Point(130, 41)
        Me.tbpk.Name = "tbpk"
        Me.tbpk.Size = New System.Drawing.Size(200, 23)
        Me.tbpk.TabIndex = 15
        '
        'tbhb
        '
        Me.tbhb.Location = New System.Drawing.Point(130, 12)
        Me.tbhb.Name = "tbhb"
        Me.tbhb.Size = New System.Drawing.Size(200, 23)
        Me.tbhb.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Stok "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Harga jual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Harga pokok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Harga beli"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnsimpan.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsimpan.Location = New System.Drawing.Point(12, 285)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(115, 34)
        Me.btnsimpan.TabIndex = 3
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btntambah.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btntambah.Location = New System.Drawing.Point(148, 285)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(115, 34)
        Me.btntambah.TabIndex = 4
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnubah.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnubah.Location = New System.Drawing.Point(284, 285)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(115, 34)
        Me.btnubah.TabIndex = 5
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnbatal.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnbatal.Location = New System.Drawing.Point(420, 285)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(115, 34)
        Me.btnbatal.TabIndex = 7
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnkeluar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnkeluar.Location = New System.Drawing.Point(692, 285)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(115, 34)
        Me.btnkeluar.TabIndex = 8
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnhapus.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnhapus.Location = New System.Drawing.Point(556, 285)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(115, 34)
        Me.btnhapus.TabIndex = 9
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'DGVB
        '
        Me.DGVB.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DGVB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVB.Location = New System.Drawing.Point(15, 346)
        Me.DGVB.Name = "DGVB"
        Me.DGVB.Size = New System.Drawing.Size(791, 152)
        Me.DGVB.TabIndex = 10
        '
        'formBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(824, 501)
        Me.Controls.Add(Me.DGVB)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.PanelTB2)
        Me.Controls.Add(Me.PanelTB)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formBarang"
        Me.Text = "formBarang"
        Me.PanelTB.ResumeLayout(False)
        Me.PanelTB.PerformLayout()
        Me.PanelTB2.ResumeLayout(False)
        Me.PanelTB2.PerformLayout()
        CType(Me.DGVB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelTB As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTB2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rtbdes As RichTextBox
    Friend WithEvents cbkt As ComboBox
    Friend WithEvents tbnmy As TextBox
    Friend WithEvents txtky As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbstok As TextBox
    Friend WithEvents tbhj As TextBox
    Friend WithEvents tbpk As TextBox
    Friend WithEvents tbhb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents DGVB As DataGridView
End Class
