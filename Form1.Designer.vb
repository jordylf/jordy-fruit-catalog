<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.timerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(159, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELAMAT DATANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(159, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Katalog Toko Buah Jordy"
        '
        'btnMasuk
        '
        Me.btnMasuk.Location = New System.Drawing.Point(258, 336)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(155, 44)
        Me.btnMasuk.TabIndex = 2
        Me.btnMasuk.Text = "MASUK"
        Me.btnMasuk.UseVisualStyleBackColor = True
        '
        'LoadingBar
        '
        Me.LoadingBar.Location = New System.Drawing.Point(184, 407)
        Me.LoadingBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(308, 39)
        Me.LoadingBar.TabIndex = 3
        '
        'timerLoading
        '
        Me.timerLoading.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.JordyKatalogBuahApp.My.Resources.Resources.unicorn
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(225, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 181)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumVioletRed
        Me.ClientSize = New System.Drawing.Size(683, 475)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Toko Buah Jordy"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents timerLoading As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
