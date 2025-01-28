<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBarang
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
        Me.tbck = New System.Windows.Forms.TextBox()
        Me.cbbkh = New System.Windows.Forms.ComboBox()
        Me.cbbhg = New System.Windows.Forms.ComboBox()
        Me.cbbktk = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVdk = New System.Windows.Forms.DataGridView()
        Me.btcari = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVdk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Data Kayu"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbck)
        Me.Panel1.Controls.Add(Me.cbbkh)
        Me.Panel1.Controls.Add(Me.cbbhg)
        Me.Panel1.Controls.Add(Me.cbbktk)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(26, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 93)
        Me.Panel1.TabIndex = 1
        '
        'tbck
        '
        Me.tbck.Location = New System.Drawing.Point(363, 27)
        Me.tbck.Name = "tbck"
        Me.tbck.Size = New System.Drawing.Size(138, 23)
        Me.tbck.TabIndex = 8
        '
        'cbbkh
        '
        Me.cbbkh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbkh.FormattingEnabled = True
        Me.cbbkh.Items.AddRange(New Object() {"Termurah", "Termahal"})
        Me.cbbkh.Location = New System.Drawing.Point(364, 58)
        Me.cbbkh.Name = "cbbkh"
        Me.cbbkh.Size = New System.Drawing.Size(138, 23)
        Me.cbbkh.TabIndex = 7
        '
        'cbbhg
        '
        Me.cbbhg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbhg.FormattingEnabled = True
        Me.cbbhg.Items.AddRange(New Object() {"Harga Beli", "Harga Pokok", "Harga Jual"})
        Me.cbbhg.Location = New System.Drawing.Point(107, 56)
        Me.cbbhg.Name = "cbbhg"
        Me.cbbhg.Size = New System.Drawing.Size(138, 23)
        Me.cbbhg.TabIndex = 6
        '
        'cbbktk
        '
        Me.cbbktk.FormattingEnabled = True
        Me.cbbktk.Location = New System.Drawing.Point(107, 27)
        Me.cbbktk.Name = "cbbktk"
        Me.cbbktk.Size = New System.Drawing.Size(138, 23)
        Me.cbbktk.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(268, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "kategori harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cari kayu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Kategori Kayu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Filter :"
        '
        'DGVdk
        '
        Me.DGVdk.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DGVdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdk.Location = New System.Drawing.Point(26, 164)
        Me.DGVdk.Name = "DGVdk"
        Me.DGVdk.Size = New System.Drawing.Size(774, 263)
        Me.DGVdk.TabIndex = 2
        '
        'btcari
        '
        Me.btcari.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btcari.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcari.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btcari.Location = New System.Drawing.Point(562, 52)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(74, 30)
        Me.btcari.TabIndex = 3
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.bthapus.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bthapus.Location = New System.Drawing.Point(562, 89)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(74, 30)
        Me.bthapus.TabIndex = 4
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'btkeluar
        '
        Me.btkeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btkeluar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btkeluar.Location = New System.Drawing.Point(562, 126)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(74, 30)
        Me.btkeluar.TabIndex = 5
        Me.btkeluar.Text = "Keluar"
        Me.btkeluar.UseVisualStyleBackColor = False
        '
        'FormDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btcari)
        Me.Controls.Add(Me.DGVdk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormDataBarang"
        Me.Text = "FormDataBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVdk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbkh As ComboBox
    Friend WithEvents cbbhg As ComboBox
    Friend WithEvents cbbktk As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbck As TextBox
    Friend WithEvents DGVdk As DataGridView
    Friend WithEvents btcari As Button
    Friend WithEvents bthapus As Button
    Friend WithEvents btkeluar As Button
End Class
