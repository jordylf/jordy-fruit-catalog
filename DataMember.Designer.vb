<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMember
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeMember = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglDaftar = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxLevel = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Pink
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnBersih)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Location = New System.Drawing.Point(483, 247)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 122)
        Me.GroupBox1.TabIndex = 13
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DATA MEMBER"
        '
        'txtKodeMember
        '
        Me.txtKodeMember.Location = New System.Drawing.Point(188, 100)
        Me.txtKodeMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKodeMember.Name = "txtKodeMember"
        Me.txtKodeMember.Size = New System.Drawing.Size(160, 22)
        Me.txtKodeMember.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "KODE MEMBER"
        '
        'dtpTglDaftar
        '
        Me.dtpTglDaftar.Location = New System.Drawing.Point(188, 138)
        Me.dtpTglDaftar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTglDaftar.Name = "dtpTglDaftar"
        Me.dtpTglDaftar.Size = New System.Drawing.Size(197, 22)
        Me.dtpTglDaftar.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "TANGGAL DAFTAR"
        '
        'ListBoxLevel
        '
        Me.ListBoxLevel.FormattingEnabled = True
        Me.ListBoxLevel.ItemHeight = 16
        Me.ListBoxLevel.Items.AddRange(New Object() {"BASIC", "PRO", "ULTIMA"})
        Me.ListBoxLevel.Location = New System.Drawing.Point(188, 286)
        Me.ListBoxLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxLevel.Name = "ListBoxLevel"
        Me.ListBoxLevel.Size = New System.Drawing.Size(159, 52)
        Me.ListBoxLevel.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "LEVEL"
        '
        'RichTextAlamat
        '
        Me.RichTextAlamat.Location = New System.Drawing.Point(188, 225)
        Me.RichTextAlamat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextAlamat.Name = "RichTextAlamat"
        Me.RichTextAlamat.Size = New System.Drawing.Size(197, 50)
        Me.RichTextAlamat.TabIndex = 33
        Me.RichTextAlamat.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "ALAMAT"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(189, 180)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(160, 22)
        Me.txtNama.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "NAMA MEMBER"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(637, 100)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 22)
        Me.txtEmail.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(479, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "EMAIL"
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(637, 144)
        Me.txtTelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(160, 22)
        Me.txtTelp.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(479, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "NO. TELP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(479, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "STATUS"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"NonAktif", "Aktif"})
        Me.cbStatus.Location = New System.Drawing.Point(637, 191)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cbStatus.TabIndex = 42
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 409)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(931, 185)
        Me.DataGridView1.TabIndex = 43
        '
        'DataMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(925, 582)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextAlamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxLevel)
        Me.Controls.Add(Me.dtpTglDaftar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeMember)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DataMember"
        Me.Text = "Data Member"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeMember As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTglDaftar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxLevel As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextAlamat As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
