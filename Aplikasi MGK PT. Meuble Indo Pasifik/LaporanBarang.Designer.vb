<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanBarang
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
        Me.tbnmk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGTVLB = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGTVLB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbnmk)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(17, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 70)
        Me.Panel1.TabIndex = 1
        '
        'tbnmk
        '
        Me.tbnmk.Location = New System.Drawing.Point(100, 15)
        Me.tbnmk.Name = "tbnmk"
        Me.tbnmk.Size = New System.Drawing.Size(223, 23)
        Me.tbnmk.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Kayu "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(374, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DGTVLB
        '
        Me.DGTVLB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGTVLB.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DGTVLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGTVLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTVLB.Location = New System.Drawing.Point(17, 150)
        Me.DGTVLB.Name = "DGTVLB"
        Me.DGTVLB.Size = New System.Drawing.Size(787, 275)
        Me.DGTVLB.TabIndex = 4
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrint.Location = New System.Drawing.Point(374, 60)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 32)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Cetak"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'LaporanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DGTVLB)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "LaporanBarang"
        Me.Text = "LaporanBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGTVLB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbnmk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DGTVLB As DataGridView
    Friend WithEvents btnPrint As Button
End Class
