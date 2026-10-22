<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKatalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfirmasiPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.DataLainToolStripMenuItem, Me.DataKatalogToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(711, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPenggunaToolStripMenuItem, Me.DataProdukToolStripMenuItem, Me.DataPesananToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataPenggunaToolStripMenuItem
        '
        Me.DataPenggunaToolStripMenuItem.Name = "DataPenggunaToolStripMenuItem"
        Me.DataPenggunaToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.DataPenggunaToolStripMenuItem.Text = "Data Pengguna"
        '
        'DataProdukToolStripMenuItem
        '
        Me.DataProdukToolStripMenuItem.Name = "DataProdukToolStripMenuItem"
        Me.DataProdukToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.DataProdukToolStripMenuItem.Text = "Data Produk"
        '
        'DataPesananToolStripMenuItem
        '
        Me.DataPesananToolStripMenuItem.Name = "DataPesananToolStripMenuItem"
        Me.DataPesananToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.DataPesananToolStripMenuItem.Text = "Data Riwayat Pesanan"
        '
        'DataLainToolStripMenuItem
        '
        Me.DataLainToolStripMenuItem.Name = "DataLainToolStripMenuItem"
        Me.DataLainToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.DataLainToolStripMenuItem.Text = "Data Member"
        '
        'DataKatalogToolStripMenuItem
        '
        Me.DataKatalogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KonfirmasiPesananToolStripMenuItem})
        Me.DataKatalogToolStripMenuItem.Name = "DataKatalogToolStripMenuItem"
        Me.DataKatalogToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.DataKatalogToolStripMenuItem.Text = "Data Katalog"
        '
        'KonfirmasiPesananToolStripMenuItem
        '
        Me.KonfirmasiPesananToolStripMenuItem.Name = "KonfirmasiPesananToolStripMenuItem"
        Me.KonfirmasiPesananToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KonfirmasiPesananToolStripMenuItem.Text = "Konfirmasi Pesanan"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.KeluarToolStripMenuItem.Text = "Exit"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumVioletRed
        Me.ClientSize = New System.Drawing.Size(711, 359)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataLainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKatalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonfirmasiPesananToolStripMenuItem As ToolStripMenuItem
End Class
