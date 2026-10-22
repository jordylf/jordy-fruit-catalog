<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataProduk
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeBuah = New System.Windows.Forms.TextBox()
        Me.txtNamaBuah = New System.Windows.Forms.TextBox()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.listBoxKualitas = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 356)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(732, 170)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA PRODUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KODE BUAH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HARGA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SATUAN"
        '
        'txtKodeBuah
        '
        Me.txtKodeBuah.Location = New System.Drawing.Point(151, 79)
        Me.txtKodeBuah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodeBuah.Name = "txtKodeBuah"
        Me.txtKodeBuah.Size = New System.Drawing.Size(160, 22)
        Me.txtKodeBuah.TabIndex = 5
        '
        'txtNamaBuah
        '
        Me.txtNamaBuah.Location = New System.Drawing.Point(151, 123)
        Me.txtNamaBuah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaBuah.Name = "txtNamaBuah"
        Me.txtNamaBuah.Size = New System.Drawing.Size(160, 22)
        Me.txtNamaBuah.TabIndex = 6
        '
        'cmbSatuan
        '
        Me.cmbSatuan.FormattingEnabled = True
        Me.cmbSatuan.Items.AddRange(New Object() {"PCS", "GRAM", "IKAT"})
        Me.cmbSatuan.Location = New System.Drawing.Point(151, 160)
        Me.cmbSatuan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(160, 24)
        Me.cmbSatuan.TabIndex = 7
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(13, 30)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 34)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(119, 30)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 34)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(207, 30)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 34)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBersih
        '
        Me.btnBersih.Location = New System.Drawing.Point(55, 71)
        Me.btnBersih.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(100, 33)
        Me.btnBersih.TabIndex = 11
        Me.btnBersih.Text = "BERSIH"
        Me.btnBersih.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnBersih)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Location = New System.Drawing.Point(372, 187)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 122)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOMBOL AKSI"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(161, 71)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 33)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "KUALITAS"
        '
        'listBoxKualitas
        '
        Me.listBoxKualitas.FormattingEnabled = True
        Me.listBoxKualitas.ItemHeight = 16
        Me.listBoxKualitas.Items.AddRange(New Object() {"TERBAIK", "BAIK", "BIASA SAJA"})
        Me.listBoxKualitas.Location = New System.Drawing.Point(151, 199)
        Me.listBoxKualitas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listBoxKualitas.Name = "listBoxKualitas"
        Me.listBoxKualitas.Size = New System.Drawing.Size(160, 52)
        Me.listBoxKualitas.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "FOTO PRODUK"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(607, 103)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(95, 34)
        Me.btnUpload.TabIndex = 13
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(151, 272)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(160, 22)
        Me.txtHarga.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "NAMA BUAH"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(151, 315)
        Me.txtKeterangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(160, 22)
        Me.txtKeterangan.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "KETERANGAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(460, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'DataProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(733, 521)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.listBoxKualitas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSatuan)
        Me.Controls.Add(Me.txtNamaBuah)
        Me.Controls.Add(Me.txtKodeBuah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DataProduk"
        Me.Text = "Data Produk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKodeBuah As TextBox
    Friend WithEvents txtNamaBuah As TextBox
    Friend WithEvents cmbSatuan As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents listBoxKualitas As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label8 As Label
End Class
