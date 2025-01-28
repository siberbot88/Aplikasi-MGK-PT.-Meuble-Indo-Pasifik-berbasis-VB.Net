<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangMasuk
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbtd = New System.Windows.Forms.TextBox()
        Me.tbjb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtprc = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbnsp = New System.Windows.Forms.ComboBox()
        Me.cbnk = New System.Windows.Forms.ComboBox()
        Me.tbkdrc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DTGVBM = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DTGVBM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Barang Masuk "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbtd)
        Me.Panel1.Controls.Add(Me.tbjb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtprc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbnsp)
        Me.Panel1.Controls.Add(Me.cbnk)
        Me.Panel1.Controls.Add(Me.tbkdrc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(26, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 150)
        Me.Panel1.TabIndex = 1
        '
        'tbtd
        '
        Me.tbtd.Location = New System.Drawing.Point(462, 100)
        Me.tbtd.Name = "tbtd"
        Me.tbtd.Size = New System.Drawing.Size(143, 23)
        Me.tbtd.TabIndex = 11
        '
        'tbjb
        '
        Me.tbjb.Location = New System.Drawing.Point(462, 57)
        Me.tbjb.Name = "tbjb"
        Me.tbjb.Size = New System.Drawing.Size(143, 23)
        Me.tbjb.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total dibayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jumlah Barang"
        '
        'dtprc
        '
        Me.dtprc.Location = New System.Drawing.Point(462, 16)
        Me.dtprc.Name = "dtprc"
        Me.dtprc.Size = New System.Drawing.Size(143, 23)
        Me.dtprc.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(345, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tanggal Receiving"
        '
        'cbnsp
        '
        Me.cbnsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbnsp.FormattingEnabled = True
        Me.cbnsp.Location = New System.Drawing.Point(119, 100)
        Me.cbnsp.Name = "cbnsp"
        Me.cbnsp.Size = New System.Drawing.Size(200, 23)
        Me.cbnsp.TabIndex = 5
        '
        'cbnk
        '
        Me.cbnk.FormattingEnabled = True
        Me.cbnk.Location = New System.Drawing.Point(121, 57)
        Me.cbnk.Name = "cbnk"
        Me.cbnk.Size = New System.Drawing.Size(198, 23)
        Me.cbnk.TabIndex = 4
        '
        'tbkdrc
        '
        Me.tbkdrc.Location = New System.Drawing.Point(123, 14)
        Me.tbkdrc.Name = "tbkdrc"
        Me.tbkdrc.Size = New System.Drawing.Size(196, 23)
        Me.tbkdrc.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Kayu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Receiving"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTambah.Location = New System.Drawing.Point(650, 55)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(69, 33)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(650, 114)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(69, 33)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKeluar.Location = New System.Drawing.Point(650, 173)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(69, 33)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBatal.Location = New System.Drawing.Point(734, 55)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(69, 33)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUbah.Location = New System.Drawing.Point(734, 114)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(69, 33)
        Me.btnUbah.TabIndex = 6
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Location = New System.Drawing.Point(734, 173)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 33)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'DTGVBM
        '
        Me.DTGVBM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DTGVBM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTGVBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVBM.Location = New System.Drawing.Point(28, 227)
        Me.DTGVBM.Name = "DTGVBM"
        Me.DTGVBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGVBM.Size = New System.Drawing.Size(774, 199)
        Me.DTGVBM.TabIndex = 8
        '
        'BarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.DTGVBM)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BarangMasuk"
        Me.Text = "BarangMasuk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DTGVBM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtprc As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbnsp As ComboBox
    Friend WithEvents cbnk As ComboBox
    Friend WithEvents tbkdrc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbtd As TextBox
    Friend WithEvents tbjb As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DTGVBM As DataGridView
End Class
