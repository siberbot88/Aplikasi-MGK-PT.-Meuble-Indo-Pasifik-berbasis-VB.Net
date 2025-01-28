<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanGudang
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
        Me.tblg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtplg = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.DTGVLPBC = New System.Windows.Forms.DataGridView()
        Me.DTGVLGBM = New System.Windows.Forms.DataGridView()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DTGVLPBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGVLGBM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Gudang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tblg)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtplg)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(20, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 79)
        Me.Panel1.TabIndex = 1
        '
        'tblg
        '
        Me.tblg.Location = New System.Drawing.Point(100, 42)
        Me.tblg.Name = "tblg"
        Me.tblg.Size = New System.Drawing.Size(196, 23)
        Me.tblg.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama kayu"
        '
        'dtplg
        '
        Me.dtplg.Location = New System.Drawing.Point(97, 12)
        Me.dtplg.Name = "dtplg"
        Me.dtplg.Size = New System.Drawing.Size(200, 23)
        Me.dtplg.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal "
        '
        'DTGVLPBC
        '
        Me.DTGVLPBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGVLPBC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DTGVLPBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVLPBC.Location = New System.Drawing.Point(20, 285)
        Me.DTGVLPBC.Name = "DTGVLPBC"
        Me.DTGVLPBC.Size = New System.Drawing.Size(774, 147)
        Me.DTGVLPBC.TabIndex = 2
        '
        'DTGVLGBM
        '
        Me.DTGVLGBM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGVLGBM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DTGVLGBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVLGBM.Location = New System.Drawing.Point(19, 132)
        Me.DTGVLGBM.Name = "DTGVLGBM"
        Me.DTGVLGBM.Size = New System.Drawing.Size(774, 147)
        Me.DTGVLGBM.TabIndex = 3
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCetak.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCetak.Location = New System.Drawing.Point(370, 92)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 34)
        Me.btnCetak.TabIndex = 5
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKeluar.Location = New System.Drawing.Point(370, 47)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 34)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'LaporanGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.DTGVLGBM)
        Me.Controls.Add(Me.DTGVLPBC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LaporanGudang"
        Me.Text = "LaporanGudang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DTGVLPBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGVLGBM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtplg As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DTGVLPBC As DataGridView
    Friend WithEvents DTGVLGBM As DataGridView
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents tblg As TextBox
    Friend WithEvents Label3 As Label
End Class
