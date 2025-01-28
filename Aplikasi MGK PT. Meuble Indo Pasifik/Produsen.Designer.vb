<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produsen
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
        Me.tbnmmt = New System.Windows.Forms.TextBox()
        Me.tbkdmt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTGVMT = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DTGVMT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Mitra"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbnmmt)
        Me.Panel1.Controls.Add(Me.tbkdmt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(29, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 101)
        Me.Panel1.TabIndex = 1
        '
        'tbnmmt
        '
        Me.tbnmmt.Location = New System.Drawing.Point(101, 51)
        Me.tbnmmt.Name = "tbnmmt"
        Me.tbnmmt.Size = New System.Drawing.Size(255, 23)
        Me.tbnmmt.TabIndex = 3
        '
        'tbkdmt
        '
        Me.tbkdmt.Location = New System.Drawing.Point(101, 16)
        Me.tbkdmt.Name = "tbkdmt"
        Me.tbkdmt.Size = New System.Drawing.Size(255, 23)
        Me.tbkdmt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Mitra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Mitra"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTambah.Location = New System.Drawing.Point(29, 178)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(91, 38)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKeluar.Location = New System.Drawing.Point(323, 178)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(91, 38)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(176, 178)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(91, 38)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBatal.Location = New System.Drawing.Point(30, 235)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(91, 38)
        Me.btnBatal.TabIndex = 6
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUbah.Location = New System.Drawing.Point(175, 235)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(91, 38)
        Me.btnUbah.TabIndex = 7
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Location = New System.Drawing.Point(323, 235)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(91, 38)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.status)
        Me.Panel2.Controls.Add(Me.total)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(30, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 122)
        Me.Panel2.TabIndex = 10
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(68, 79)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(12, 15)
        Me.status.TabIndex = 7
        Me.status.Text = "-"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(88, 32)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(12, 15)
        Me.total.TabIndex = 6
        Me.total.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Status :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Data :"
        '
        'DTGVMT
        '
        Me.DTGVMT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGVMT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DTGVMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTGVMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVMT.Location = New System.Drawing.Point(447, 56)
        Me.DTGVMT.Name = "DTGVMT"
        Me.DTGVMT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGVMT.Size = New System.Drawing.Size(350, 364)
        Me.DTGVMT.TabIndex = 11
        '
        'Produsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Aplikasi_MGK_PT.Meuble_Indo_Pasifik.My.Resources.Resources.Product_Inventory3
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.DTGVMT)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Produsen"
        Me.Text = "Produsen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DTGVMT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbnmmt As TextBox
    Friend WithEvents tbkdmt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents status As Label
    Friend WithEvents total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTGVMT As DataGridView
End Class
