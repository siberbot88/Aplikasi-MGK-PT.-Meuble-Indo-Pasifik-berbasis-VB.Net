<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.lblogin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gboxlogin = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cboBag = New System.Windows.Forms.ComboBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxlogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblogin
        '
        Me.lblogin.AutoSize = True
        Me.lblogin.BackColor = System.Drawing.Color.Transparent
        Me.lblogin.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblogin.Location = New System.Drawing.Point(222, 42)
        Me.lblogin.Name = "lblogin"
        Me.lblogin.Size = New System.Drawing.Size(72, 25)
        Me.lblogin.TabIndex = 0
        Me.lblogin.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(191, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'gboxlogin
        '
        Me.gboxlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.gboxlogin.Controls.Add(Me.btnKeluar)
        Me.gboxlogin.Controls.Add(Me.btnBatal)
        Me.gboxlogin.Controls.Add(Me.btnMasuk)
        Me.gboxlogin.Controls.Add(Me.txtPassword)
        Me.gboxlogin.Controls.Add(Me.cboBag)
        Me.gboxlogin.Controls.Add(Me.cboName)
        Me.gboxlogin.Controls.Add(Me.Label4)
        Me.gboxlogin.Controls.Add(Me.Label3)
        Me.gboxlogin.Controls.Add(Me.Label2)
        Me.gboxlogin.Controls.Add(Me.Label1)
        Me.gboxlogin.Location = New System.Drawing.Point(12, 241)
        Me.gboxlogin.Name = "gboxlogin"
        Me.gboxlogin.Size = New System.Drawing.Size(501, 192)
        Me.gboxlogin.TabIndex = 2
        Me.gboxlogin.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(380, 130)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(94, 30)
        Me.btnKeluar.TabIndex = 9
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBatal.Location = New System.Drawing.Point(380, 95)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(94, 30)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnMasuk.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMasuk.Location = New System.Drawing.Point(380, 60)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(94, 30)
        Me.btnMasuk.TabIndex = 7
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(112, 101)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(231, 23)
        Me.txtPassword.TabIndex = 6
        '
        'cboBag
        '
        Me.cboBag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBag.FormattingEnabled = True
        Me.cboBag.Items.AddRange(New Object() {"Master", "Gudang"})
        Me.cboBag.Location = New System.Drawing.Point(112, 138)
        Me.cboBag.Name = "cboBag"
        Me.cboBag.Size = New System.Drawing.Size(231, 23)
        Me.cboBag.TabIndex = 5
        '
        'cboName
        '
        Me.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(112, 62)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(231, 23)
        Me.cboName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bagian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pengguna"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 441)
        Me.Controls.Add(Me.gboxlogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblogin)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxlogin.ResumeLayout(False)
        Me.gboxlogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblogin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gboxlogin As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnMasuk As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboBag As ComboBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
