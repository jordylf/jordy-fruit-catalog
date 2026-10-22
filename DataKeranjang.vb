Imports MySql.Data.MySqlClient
Public Class DataKeranjang
    Dim idpesanan As Integer = 0
    Public kodePesanan As String
    Sub lihatdata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_pesanan where status = 'Proses'", conn)
        ds = New DataSet
        da.Fill(ds, "pesanan")
        DataGridView1.DataSource = ds.Tables("pesanan")
    End Sub

    Sub bersihdata()
        txtHarga.Text = "0"
        txtHargaTotal.Text = "0"
        txtHarga.Text = "0"
        txtKodeBuah.Clear()
        txtJumlah.Text = "0"
        txtKodepesan.Clear()

    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Hide()

    End Sub

    Private Sub DataKeranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lihatdata()

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idpesanan = DataGridView1.Item(0, i).Value
        dtpTglPesan.Value = DataGridView1.Item(1, i).Value
        txtKodeBuah.Text = DataGridView1.Item(2, i).Value
        txtNamaBuah.Text = DataGridView1.Item(3, i).Value
        txtHarga.Text = DataGridView1.Item(4, i).Value
        txtJumlah.Text = DataGridView1.Item(7, i).Value
        txtHargaTotal.Text = DataGridView1.Item(8, i).Value.ToString
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call koneksi()
        Try

            Dim str As String

            str = "delete from tbl_pesanan where idpesanan = " & idpesanan & ""
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pesanan berhasil dihapus!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus karena " & ex.Message)
        End Try

    End Sub

    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        Call koneksi()
        Try

            Dim str As String
            kodePesanan = txtKodepesan.Text
            str = "update tbl_pesanan set kodePesanan = '" & txtKodepesan.Text & "', status = 'Konfirmasi' where status = 'Proses'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sukses, sekarang memasuki konfirmasi pesanan!")

            conn.Close()
            KonfirmasiPesanan.Show()


        Catch ex As Exception
            MessageBox.Show("Data gagal diupdate karena " & ex.Message)
            conn.Close()
        End Try
    End Sub
End Class