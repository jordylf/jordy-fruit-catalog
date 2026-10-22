<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataPengguna
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.rbLakiLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.dtpTglLhr = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.chkNonAktif = New System.Windows.Forms.CheckBox()
        Me.maskedTxtNOHP = New System.Windows.Forms.MaskedTextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DATA PENGGUNA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 309)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(816, 167)
        Me.DataGridView1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nama Pengguna"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Kata Sandi"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(144, 81)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(197, 22)
        Me.txtNama.TabIndex = 21
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(144, 213)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(197, 22)
        Me.txtUser.TabIndex = 24
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(144, 257)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(197, 22)
        Me.txtPass.TabIndex = 25
        '
        'rbLakiLaki
        '
        Me.rbLakiLaki.AutoSize = True
        Me.rbLakiLaki.Location = New System.Drawing.Point(144, 119)
        Me.rbLakiLaki.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbLakiLaki.Name = "rbLakiLaki"
        Me.rbLakiLaki.Size = New System.Drawing.Size(82, 20)
        Me.rbLakiLaki.TabIndex = 26
        Me.rbLakiLaki.TabStop = True
        Me.rbLakiLaki.Text = "Laki-Laki"
        Me.rbLakiLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(236, 119)
        Me.rbPerempuan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(98, 20)
        Me.rbPerempuan.TabIndex = 27
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'dtpTglLhr
        '
        Me.dtpTglLhr.Location = New System.Drawing.Point(144, 156)
        Me.dtpTglLhr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTglLhr.Name = "dtpTglLhr"
        Me.dtpTglLhr.Size = New System.Drawing.Size(197, 22)
        Me.dtpTglLhr.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(369, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "No. HP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(369, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Status"
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Location = New System.Drawing.Point(443, 262)
        Me.chkAktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(54, 20)
        Me.chkAktif.TabIndex = 31
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'chkNonAktif
        '
        Me.chkNonAktif.AutoSize = True
        Me.chkNonAktif.Location = New System.Drawing.Point(520, 262)
        Me.chkNonAktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNonAktif.Name = "chkNonAktif"
        Me.chkNonAktif.Size = New System.Drawing.Size(79, 20)
        Me.chkNonAktif.TabIndex = 32
        Me.chkNonAktif.Text = "NonAktif"
        Me.chkNonAktif.UseVisualStyleBackColor = True
        '
        'maskedTxtNOHP
        '
        Me.maskedTxtNOHP.Location = New System.Drawing.Point(443, 226)
        Me.maskedTxtNOHP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maskedTxtNOHP.Mask = "0000-0000-0000"
        Me.maskedTxtNOHP.Name = "maskedTxtNOHP"
        Me.maskedTxtNOHP.Size = New System.Drawing.Size(176, 22)
        Me.maskedTxtNOHP.TabIndex = 33
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(118, 59)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(95, 39)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 59)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 39)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnBersih
        '
        Me.btnBersih.Location = New System.Drawing.Point(117, 10)
        Me.btnBersih.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(96, 39)
        Me.btnBersih.TabIndex = 11
        Me.btnBersih.Text = "BERSIH"
        Me.btnBersih.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(12, 10)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 39)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(219, 42)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 33)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnBersih)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Location = New System.Drawing.Point(408, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 111)
        Me.Panel1.TabIndex = 34
        '
        'DataPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(813, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.maskedTxtNOHP)
        Me.Controls.Add(Me.chkNonAktif)
        Me.Controls.Add(Me.chkAktif)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpTglLhr)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLakiLaki)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DataPengguna"
        Me.Text = "Data Pengguna"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents dtpTglLhr As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkAktif As CheckBox
    Friend WithEvents chkNonAktif As CheckBox
    Friend WithEvents maskedTxtNOHP As MaskedTextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Panel1 As Panel
End Class
