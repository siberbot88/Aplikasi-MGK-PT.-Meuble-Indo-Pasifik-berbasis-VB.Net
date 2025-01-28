<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.GroupBox()
        Me.cbUN = New System.Windows.Forms.CheckBox()
        Me.cbKA = New System.Windows.Forms.CheckBox()
        Me.CboBag = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtKdadmin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(319, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kontrol Admin"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbUN)
        Me.Panel1.Controls.Add(Me.cbKA)
        Me.Panel1.Controls.Add(Me.CboBag)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtKdadmin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(14, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 205)
        Me.Panel1.TabIndex = 1
        Me.Panel1.TabStop = False
        '
        'cbUN
        '
        Me.cbUN.AutoSize = True
        Me.cbUN.Location = New System.Drawing.Point(499, 62)
        Me.cbUN.Name = "cbUN"
        Me.cbUN.Size = New System.Drawing.Size(91, 19)
        Me.cbUN.TabIndex = 9
        Me.cbUN.Text = "User Name"
        Me.cbUN.UseVisualStyleBackColor = True
        '
        'cbKA
        '
        Me.cbKA.AutoSize = True
        Me.cbKA.Location = New System.Drawing.Point(499, 37)
        Me.cbKA.Name = "cbKA"
        Me.cbKA.Size = New System.Drawing.Size(95, 19)
        Me.cbKA.TabIndex = 8
        Me.cbKA.Text = "Kode Admin"
        Me.cbKA.UseVisualStyleBackColor = True
        '
        'CboBag
        '
        Me.CboBag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBag.FormattingEnabled = True
        Me.CboBag.Items.AddRange(New Object() {"Master", "Gudang"})
        Me.CboBag.Location = New System.Drawing.Point(115, 148)
        Me.CboBag.Name = "CboBag"
        Me.CboBag.Size = New System.Drawing.Size(330, 23)
        Me.CboBag.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(115, 103)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(330, 23)
        Me.txtPassword.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(115, 69)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(330, 23)
        Me.txtUsername.TabIndex = 5
        '
        'txtKdadmin
        '
        Me.txtKdadmin.Location = New System.Drawing.Point(115, 32)
        Me.txtKdadmin.Name = "txtKdadmin"
        Me.txtKdadmin.Size = New System.Drawing.Size(330, 23)
        Me.txtKdadmin.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bagian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Admin"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 302)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(791, 131)
        Me.DataGridView1.TabIndex = 2
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(671, 83)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(106, 32)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTambah.Location = New System.Drawing.Point(671, 119)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(106, 32)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUbah.Location = New System.Drawing.Point(671, 155)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(106, 32)
        Me.btnUbah.TabIndex = 5
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Location = New System.Drawing.Point(671, 191)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(106, 32)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBatal.Location = New System.Drawing.Point(671, 227)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(106, 32)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKeluar.Location = New System.Drawing.Point(671, 263)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(106, 32)
        Me.btnKeluar.TabIndex = 8
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As GroupBox
    Friend WithEvents cbUN As CheckBox
    Friend WithEvents cbKA As CheckBox
    Friend WithEvents CboBag As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtKdadmin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKeluar As Button
End Class
