<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKeranjang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnLanjut = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHargaTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaBuah = New System.Windows.Forms.TextBox()
        Me.txtKodeBuah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpTglPesan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtKodepesan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 372)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1064, 183)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "DATA CART"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Beige
        Me.GroupBox1.Controls.Add(Me.btnTutup)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnLanjut)
        Me.GroupBox1.Location = New System.Drawing.Point(745, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 122)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOMBOL AKSI"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(107, 71)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(100, 33)
        Me.btnTutup.TabIndex = 12
        Me.btnTutup.Text = "TUTUP"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(160, 32)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 33)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnLanjut
        '
        Me.btnLanjut.Location = New System.Drawing.Point(55, 32)
        Me.btnLanjut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLanjut.Name = "btnLanjut"
        Me.btnLanjut.Size = New System.Drawing.Size(100, 34)
        Me.btnLanjut.TabIndex = 9
        Me.btnLanjut.Text = "LANJUT"
        Me.btnLanjut.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "JUMLAH"
        '
        'txtHargaTotal
        '
        Me.txtHargaTotal.Location = New System.Drawing.Point(141, 182)
        Me.txtHargaTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHargaTotal.Name = "txtHargaTotal"
        Me.txtHargaTotal.Size = New System.Drawing.Size(160, 22)
        Me.txtHargaTotal.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "HARGA TOTAL"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(141, 100)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(160, 22)
        Me.txtHarga.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "NAMA BUAH"
        '
        'txtNamaBuah
        '
        Me.txtNamaBuah.Location = New System.Drawing.Point(141, 57)
        Me.txtNamaBuah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaBuah.Name = "txtNamaBuah"
        Me.txtNamaBuah.Size = New System.Drawing.Size(160, 22)
        Me.txtNamaBuah.TabIndex = 45
        '
        'txtKodeBuah
        '
        Me.txtKodeBuah.Location = New System.Drawing.Point(141, 12)
        Me.txtKodeBuah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodeBuah.Name = "txtKodeBuah"
        Me.txtKodeBuah.Size = New System.Drawing.Size(160, 22)
        Me.txtKodeBuah.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "HARGA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "KODE BUAH"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpTglPesan)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.txtJumlah)
        Me.Panel1.Controls.Add(Me.txtKodeBuah)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtHargaTotal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNamaBuah)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtHarga)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(31, 84)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 229)
        Me.Panel1.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "TGL PESAN"
        '
        'dtpTglPesan
        '
        Me.dtpTglPesan.Location = New System.Drawing.Point(460, 14)
        Me.dtpTglPesan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTglPesan.Name = "dtpTglPesan"
        Me.dtpTglPesan.Size = New System.Drawing.Size(187, 22)
        Me.dtpTglPesan.TabIndex = 56
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Linen
        Me.GroupBox2.Controls.Add(Me.txtKodepesan)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 100)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(304, 101)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUAT PESANAN"
        '
        'txtKodepesan
        '
        Me.txtKodepesan.Location = New System.Drawing.Point(153, 43)
        Me.txtKodepesan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodepesan.Name = "txtKodepesan"
        Me.txtKodepesan.Size = New System.Drawing.Size(132, 22)
        Me.txtKodepesan.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "KODE PESANAN"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(141, 144)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(160, 22)
        Me.txtJumlah.TabIndex = 54
        '
        'DataKeranjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DataKeranjang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Keranjang / Pesanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnLanjut As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHargaTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNamaBuah As TextBox
    Friend WithEvents txtKodeBuah As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtKodepesan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpTglPesan As DateTimePicker
End Class
