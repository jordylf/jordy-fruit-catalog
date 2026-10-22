Imports MySql.Data.MySqlClient
Public Class DataKatalog
    Dim idbuah As Integer = 0

    Sub bersihdata()
        txtHarga.Text = "0"
        txtKeterangan.Clear()
        txtHarga.Text = "0"
        txtKodeBuah.Clear()
        PictureBox1.Image = Nothing
        txtSatuan.Clear()
        txtKualitas.Clear()
        volJumlah.Value = 0
    End Sub
    Sub lihatdata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_produk", conn)
        ds = New DataSet
        da.Fill(ds, "produk")
        DataGridView1.DataSource = ds.Tables("produk")
    End Sub
    Private Sub volJumlah_ValueChanged(sender As Object, e As EventArgs) Handles volJumlah.ValueChanged
        txtHargaTotal.Text = Val(txtHarga.Text) * volJumlah.Value
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idbuah = DataGridView1.Item(0, i).Value
        txtKodeBuah.Text = DataGridView1.Item(1, i).Value
        txtNamaBuah.Text = DataGridView1.Item(2, i).Value
        txtSatuan.Text = DataGridView1.Item(3, i).Value
        txtKualitas.Text = DataGridView1.Item(4, i).Value
        txtHarga.Text = DataGridView1.Item(5, i).Value.ToString
        PictureBox1.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.StartupPath & "\..\..\assets\") & "\" & DataGridView1.Item(6, i).Value)
        txtKeterangan.Text = DataGridView1.Item(7, i).Value
    End Sub

    Private Sub DataKatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersihdata()

        lihatdata()

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        DataKeranjang.Show()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call koneksi()
        Try

            Dim str As String
            str = "insert into tbl_pesanan values (null,now(),'" & txtKodeBuah.Text & "','" & txtNamaBuah.Text & "'," & Val(txtHarga.Text) & ",0,0," & Val(volJumlah.Value) & ", " & Val(txtHargaTotal.Text) & ", 'Proses')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pesanan berhasil disimpan!")

            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan karena " & ex.Message)
        End Try
    End Sub

End Class