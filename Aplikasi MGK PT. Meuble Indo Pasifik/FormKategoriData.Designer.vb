<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKategoriData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategoriData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbkat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvKtgKayu = New System.Windows.Forms.DataGridView()
        Me.lbtdata = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbang = New System.Windows.Forms.Label()
        Me.lbname = New System.Windows.Forms.Label()
        Me.lbTtkat = New System.Windows.Forms.Label()
        Me.lbTtl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvKtgKayu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Kategori Kayu"
        '
        'cbbkat
        '
        Me.cbbkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbkat.FormattingEnabled = True
        Me.cbbkat.Location = New System.Drawing.Point(88, 57)
        Me.cbbkat.Name = "cbbkat"
        Me.cbbkat.Size = New System.Drawing.Size(170, 21)
        Me.cbbkat.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(15, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kategori"
        '
        'dgvKtgKayu
        '
        Me.dgvKtgKayu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.dgvKtgKayu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKtgKayu.Location = New System.Drawing.Point(20, 97)
        Me.dgvKtgKayu.Name = "dgvKtgKayu"
        Me.dgvKtgKayu.Size = New System.Drawing.Size(783, 319)
        Me.dgvKtgKayu.TabIndex = 3
        '
        'lbtdata
        '
        Me.lbtdata.AutoSize = True
        Me.lbtdata.BackColor = System.Drawing.Color.Transparent
        Me.lbtdata.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtdata.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbtdata.Location = New System.Drawing.Point(33, 16)
        Me.lbtdata.Name = "lbtdata"
        Me.lbtdata.Size = New System.Drawing.Size(71, 15)
        Me.lbtdata.TabIndex = 4
        Me.lbtdata.Text = "Total Data :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbang)
        Me.GroupBox1.Controls.Add(Me.lbname)
        Me.GroupBox1.Controls.Add(Me.lbTtkat)
        Me.GroupBox1.Controls.Add(Me.lbTtl)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lbtdata)
        Me.GroupBox1.Location = New System.Drawing.Point(309, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 50)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lbang
        '
        Me.lbang.AutoSize = True
        Me.lbang.BackColor = System.Drawing.Color.Transparent
        Me.lbang.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbang.ForeColor = System.Drawing.Color.Black
        Me.lbang.Location = New System.Drawing.Point(287, 24)
        Me.lbang.Name = "lbang"
        Me.lbang.Size = New System.Drawing.Size(21, 15)
        Me.lbang.TabIndex = 9
        Me.lbang.Text = "--:"
        '
        'lbname
        '
        Me.lbname.AutoSize = True
        Me.lbname.BackColor = System.Drawing.Color.Transparent
        Me.lbname.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbname.Location = New System.Drawing.Point(159, 24)
        Me.lbname.Name = "lbname"
        Me.lbname.Size = New System.Drawing.Size(21, 15)
        Me.lbname.TabIndex = 8
        Me.lbname.Text = "--:"
        '
        'lbTtkat
        '
        Me.lbTtkat.AutoSize = True
        Me.lbTtkat.BackColor = System.Drawing.Color.Transparent
        Me.lbTtkat.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTtkat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbTtkat.Location = New System.Drawing.Point(159, 9)
        Me.lbTtkat.Name = "lbTtkat"
        Me.lbTtkat.Size = New System.Drawing.Size(67, 15)
        Me.lbTtkat.TabIndex = 7
        Me.lbTtkat.Text = "Total Data "
        '
        'lbTtl
        '
        Me.lbTtl.AutoSize = True
        Me.lbTtl.BackColor = System.Drawing.Color.Transparent
        Me.lbTtl.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTtl.ForeColor = System.Drawing.Color.Black
        Me.lbTtl.Location = New System.Drawing.Point(99, 16)
        Me.lbTtl.Name = "lbTtl"
        Me.lbTtl.Size = New System.Drawing.Size(12, 15)
        Me.lbTtl.TabIndex = 6
        Me.lbTtl.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(687, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormKategoriData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvKtgKayu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbbkat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKategoriData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKategoriData"
        CType(Me.dgvKtgKayu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbbkat As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvKtgKayu As DataGridView
    Friend WithEvents lbtdata As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbTtl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbang As Label
    Friend WithEvents lbname As Label
    Friend WithEvents lbTtkat As Label
    Friend WithEvents Button1 As Button
End Class
