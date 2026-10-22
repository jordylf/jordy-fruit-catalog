Imports MySql.Data.MySqlClient

Public Class DataRiwayat
    Dim getTanggal As String
    Sub lihatdata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_pesanan where status = 'Selesai'", conn)
        ds = New DataSet
        da.Fill(ds, "pesanan")
        DataGridView1.DataSource = ds.Tables("pesanan")
    End Sub
    Private Sub DataRiwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lihatdata()

        Dim refreshToolStripMenuItem As New ToolStripMenuItem("Refresh")
        AddHandler refreshToolStripMenuItem.Click, AddressOf btnRefresh_Click
        ContextMenuStrip1.Items.Add(refreshToolStripMenuItem)

        ' Hubungkan ContextMenuStrip dengan DataGridView
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        lihatdata()
    End Sub

End Class