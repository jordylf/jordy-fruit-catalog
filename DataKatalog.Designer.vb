<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataKatalog
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtNamaBuah = New System.Windows.Forms.TextBox()
        Me.txtKodeBuah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.txtKualitas = New System.Windows.Forms.TextBox()
        Me.txtHargaTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.volJumlah = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCart = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.volJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-5, 357)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(939, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(156, 314)
        Me.txtKeterangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(160, 22)
        Me.txtKeterangan.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "KETERANGAN"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(156, 271)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(160, 22)
        Me.txtHarga.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "NAMA BUAH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "FOTO PRODUK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "KUALITAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.btnCart)
        Me.GroupBox1.Location = New System.Drawing.Point(613, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 122)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOMBOL AKSI"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(161, 53)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 33)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(55, 32)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 34)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtNamaBuah
        '
        Me.txtNamaBuah.Location = New System.Drawing.Point(156, 135)
        Me.txtNamaBuah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaBuah.Name = "txtNamaBuah"
        Me.txtNamaBuah.Size = New System.Drawing.Size(160, 22)
        Me.txtNamaBuah.TabIndex = 26
        '
        'txtKodeBuah
        '
        Me.txtKodeBuah.Location = New System.Drawing.Point(156, 91)
        Me.txtKodeBuah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodeBuah.Name = "txtKodeBuah"
        Me.txtKodeBuah.Size = New System.Drawing.Size(160, 22)
        Me.txtKodeBuah.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "SATUAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "HARGA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "KODE BUAH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "DATA KATALOG"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(156, 176)
        Me.txtSatuan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(160, 22)
        Me.txtSatuan.TabIndex = 35
        '
        'txtKualitas
        '
        Me.txtKualitas.Location = New System.Drawing.Point(156, 223)
        Me.txtKualitas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKualitas.Name = "txtKualitas"
        Me.txtKualitas.Size = New System.Drawing.Size(160, 22)
        Me.txtKualitas.TabIndex = 36
        '
        'txtHargaTotal
        '
        Me.txtHargaTotal.Location = New System.Drawing.Point(497, 271)
        Me.txtHargaTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHargaTotal.Name = "txtHargaTotal"
        Me.txtHargaTotal.Size = New System.Drawing.Size(160, 22)
        Me.txtHargaTotal.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "HARGA TOTAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "KUANTITAS"
        '
        'volJumlah
        '
        Me.volJumlah.Location = New System.Drawing.Point(497, 226)
        Me.volJumlah.Margin = New System.Windows.Forms.Padding(4)
        Me.volJumlah.Name = "volJumlah"
        Me.volJumlah.Size = New System.Drawing.Size(160, 22)
        Me.volJumlah.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(465, 79)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(55, 71)
        Me.btnCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(100, 33)
        Me.btnCart.TabIndex = 11
        Me.btnCart.Text = "LIHAT"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'DataKatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(935, 559)
        Me.Controls.Add(Me.volJumlah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtHargaTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtKualitas)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNamaBuah)
        Me.Controls.Add(Me.txtKodeBuah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DataKatalog"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.volJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNamaBuah As TextBox
    Friend WithEvents txtKodeBuah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents txtKualitas As TextBox
    Friend WithEvents txtHargaTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents volJumlah As NumericUpDown
    Friend WithEvents btnCart As Button
End Class
