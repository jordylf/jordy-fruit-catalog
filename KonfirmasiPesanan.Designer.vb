<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KonfirmasiPesanan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeMember = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodePesan = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTelpPelanggan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodePelanggan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNominal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbPembayaran = New System.Windows.Forms.ComboBox()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoHPPayment = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtHargaBayar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHargaTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnKonfimasi = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 513)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1068, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KONFIRMASI PESANAN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.txtKodePesan)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(19, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 279)
        Me.Panel1.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "KODE PESANAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Controls.Add(Me.txtTelp)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtLevel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtKodeMember)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(373, 244)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CARI DATA MEMBER"
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(165, 169)
        Me.txtTelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(179, 22)
        Me.txtTelp.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "NO. TELP"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(165, 106)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(179, 22)
        Me.txtLevel.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "LEVEL"
        '
        'txtKodeMember
        '
        Me.txtKodeMember.Location = New System.Drawing.Point(165, 31)
        Me.txtKodeMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodeMember.Name = "txtKodeMember"
        Me.txtKodeMember.Size = New System.Drawing.Size(112, 22)
        Me.txtKodeMember.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "KODE MEMBER"
        '
        'txtKodePesan
        '
        Me.txtKodePesan.Location = New System.Drawing.Point(179, 15)
        Me.txtKodePesan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodePesan.Name = "txtKodePesan"
        Me.txtKodePesan.ReadOnly = True
        Me.txtKodePesan.Size = New System.Drawing.Size(179, 22)
        Me.txtKodePesan.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelpPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNamaPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKodePelanggan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(373, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUAT PESANAN PELANGGAN"
        '
        'txtTelpPelanggan
        '
        Me.txtTelpPelanggan.Location = New System.Drawing.Point(160, 140)
        Me.txtTelpPelanggan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelpPelanggan.Name = "txtTelpPelanggan"
        Me.txtTelpPelanggan.Size = New System.Drawing.Size(179, 22)
        Me.txtTelpPelanggan.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "NO. TELP"
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(160, 87)
        Me.txtNamaPelanggan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(179, 22)
        Me.txtNamaPelanggan.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "KODE PELANGGAN"
        '
        'txtKodePelanggan
        '
        Me.txtKodePelanggan.Location = New System.Drawing.Point(160, 36)
        Me.txtKodePelanggan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodePelanggan.Name = "txtKodePelanggan"
        Me.txtKodePelanggan.Size = New System.Drawing.Size(179, 22)
        Me.txtKodePelanggan.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "NAMA PELANGGAN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Location = New System.Drawing.Point(19, 359)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 146)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNominal)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.cmbPembayaran)
        Me.GroupBox4.Controls.Add(Me.txtKembalian)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtNoHPPayment)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(464, 7)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(564, 139)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OPSI PEMBAYARAN"
        '
        'txtNominal
        '
        Me.txtNominal.Location = New System.Drawing.Point(419, 23)
        Me.txtNominal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.Size = New System.Drawing.Size(128, 22)
        Me.txtNominal.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(316, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 16)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "NOMINAL"
        '
        'cmbPembayaran
        '
        Me.cmbPembayaran.FormattingEnabled = True
        Me.cmbPembayaran.Location = New System.Drawing.Point(192, 22)
        Me.cmbPembayaran.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPembayaran.Name = "cmbPembayaran"
        Me.cmbPembayaran.Size = New System.Drawing.Size(116, 24)
        Me.cmbPembayaran.TabIndex = 56
        '
        'txtKembalian
        '
        Me.txtKembalian.Location = New System.Drawing.Point(196, 108)
        Me.txtKembalian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(148, 22)
        Me.txtKembalian.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "KEMBALIAN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "METODE PEMBAYARAN"
        '
        'txtNoHPPayment
        '
        Me.txtNoHPPayment.Location = New System.Drawing.Point(196, 66)
        Me.txtNoHPPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoHPPayment.Name = "txtNoHPPayment"
        Me.txtNoHPPayment.Size = New System.Drawing.Size(148, 22)
        Me.txtNoHPPayment.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "NO. HP"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtHargaBayar)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtHargaTotal)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtDiskon)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(361, 139)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TAMBAHAN"
        '
        'txtHargaBayar
        '
        Me.txtHargaBayar.Location = New System.Drawing.Point(196, 108)
        Me.txtHargaBayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHargaBayar.Name = "txtHargaBayar"
        Me.txtHargaBayar.Size = New System.Drawing.Size(148, 22)
        Me.txtHargaBayar.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "HARGA DIBAYARKAN"
        '
        'txtHargaTotal
        '
        Me.txtHargaTotal.Location = New System.Drawing.Point(196, 22)
        Me.txtHargaTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHargaTotal.Name = "txtHargaTotal"
        Me.txtHargaTotal.Size = New System.Drawing.Size(148, 22)
        Me.txtHargaTotal.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "HARGA TOTAL"
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(196, 66)
        Me.txtDiskon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(148, 22)
        Me.txtDiskon.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "DISKON"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Beige
        Me.GroupBox5.Controls.Add(Me.btnTutup)
        Me.GroupBox5.Controls.Add(Me.btnKonfimasi)
        Me.GroupBox5.Location = New System.Drawing.Point(843, 73)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(188, 140)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TOMBOL AKSI"
        '
        'btnTutup
        '
        Me.btnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Location = New System.Drawing.Point(19, 89)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(151, 42)
        Me.btnTutup.TabIndex = 12
        Me.btnTutup.Text = "TUTUP"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnKonfimasi
        '
        Me.btnKonfimasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfimasi.Location = New System.Drawing.Point(19, 30)
        Me.btnKonfimasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKonfimasi.Name = "btnKonfimasi"
        Me.btnKonfimasi.Size = New System.Drawing.Size(152, 53)
        Me.btnKonfimasi.TabIndex = 9
        Me.btnKonfimasi.Text = "KONFIRMASI"
        Me.btnKonfimasi.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Image = Global.JordyKatalogBuahApp.My.Resources.Resources.caridata32
        Me.btnCari.Location = New System.Drawing.Point(289, 16)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(64, 53)
        Me.btnCari.TabIndex = 45
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'KonfirmasiPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 700)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "KonfirmasiPesanan"
        Me.Text = "Konfirmasi Pesanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeMember As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelpPelanggan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKodePelanggan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtHargaBayar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtHargaTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbPembayaran As ComboBox
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNoHPPayment As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtKodePesan As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnKonfimasi As Button
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label16 As Label
End Class
