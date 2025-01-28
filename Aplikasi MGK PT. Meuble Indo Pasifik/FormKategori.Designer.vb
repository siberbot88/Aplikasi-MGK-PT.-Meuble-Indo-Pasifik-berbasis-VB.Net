<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbnk = New System.Windows.Forms.CheckBox()
        Me.cbkk = New System.Windows.Forms.CheckBox()
        Me.txtNmKtg = New System.Windows.Forms.TextBox()
        Me.txtKdKtg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.BackColor = System.Drawing.Color.Transparent
        Me.Lb1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lb1.Location = New System.Drawing.Point(28, 23)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(142, 33)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "KATEGORI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbnk)
        Me.Panel1.Controls.Add(Me.cbkk)
        Me.Panel1.Controls.Add(Me.txtNmKtg)
        Me.Panel1.Controls.Add(Me.txtKdKtg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lb2)
        Me.Panel1.Location = New System.Drawing.Point(34, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 191)
        Me.Panel1.TabIndex = 1
        '
        'cbnk
        '
        Me.cbnk.AutoSize = True
        Me.cbnk.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnk.Location = New System.Drawing.Point(459, 65)
        Me.cbnk.Name = "cbnk"
        Me.cbnk.Size = New System.Drawing.Size(101, 17)
        Me.cbnk.TabIndex = 5
        Me.cbnk.Text = "Nama Kategori"
        Me.cbnk.UseVisualStyleBackColor = True
        '
        'cbkk
        '
        Me.cbkk.AutoSize = True
        Me.cbkk.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkk.Location = New System.Drawing.Point(459, 27)
        Me.cbkk.Name = "cbkk"
        Me.cbkk.Size = New System.Drawing.Size(96, 17)
        Me.cbkk.TabIndex = 4
        Me.cbkk.Text = "Kode Kategori"
        Me.cbkk.UseVisualStyleBackColor = True
        '
        'txtNmKtg
        '
        Me.txtNmKtg.Location = New System.Drawing.Point(145, 65)
        Me.txtNmKtg.MaxLength = 25
        Me.txtNmKtg.Name = "txtNmKtg"
        Me.txtNmKtg.Size = New System.Drawing.Size(259, 20)
        Me.txtNmKtg.TabIndex = 3
        '
        'txtKdKtg
        '
        Me.txtKdKtg.Location = New System.Drawing.Point(145, 24)
        Me.txtKdKtg.MaxLength = 15
        Me.txtKdKtg.Name = "txtKdKtg"
        Me.txtKdKtg.Size = New System.Drawing.Size(259, 20)
        Me.txtKdKtg.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Kategori"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.Location = New System.Drawing.Point(30, 29)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(100, 15)
        Me.Lb2.TabIndex = 0
        Me.Lb2.Text = "Kode Kategori"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 285)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(729, 159)
        Me.DataGridView1.TabIndex = 2
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(624, 75)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(139, 29)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTambah.Location = New System.Drawing.Point(624, 110)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(139, 29)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBatal.Location = New System.Drawing.Point(624, 215)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(139, 29)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnUbah.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUbah.Location = New System.Drawing.Point(624, 145)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(139, 29)
        Me.btnUbah.TabIndex = 5
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Location = New System.Drawing.Point(624, 180)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(139, 29)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnKeluar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKeluar.Location = New System.Drawing.Point(624, 250)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(139, 29)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "FormKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKategori"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lb2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbnk As CheckBox
    Friend WithEvents cbkk As CheckBox
    Friend WithEvents txtNmKtg As TextBox
    Friend WithEvents txtKdKtg As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
End Class
