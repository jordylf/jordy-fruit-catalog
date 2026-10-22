Imports System.IO
Imports MySql.Data.MySqlClient
Public Class DataProduk
    Dim unikIMG As String
    Dim namaImg As String
    Dim idbuah As Integer = 0

    Sub batal()
        btnBatal.Enabled = False
        btnBersih.Enabled = False
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub bersihdata()
        txtKodeBuah.Clear()
        txtNamaBuah.Clear()
        txtHarga.Clear()
        cmbSatuan.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Sub edit()
        btnBatal.Enabled = True
        btnBersih.Enabled = False
        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Sub mulai()
        btnBatal.Enabled = False
        btnBersih.Enabled = False
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub lihatdata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_produk", conn)
        ds = New DataSet
        da.Fill(ds, "produk")
        DataGridView1.DataSource = ds.Tables("produk")
    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Try
                If namaImg = "" Then
                    namaImg = "img-"
                Else
                    namaImg = txtNamaBuah.Text & "-"
                End If
                unikIMG = DateTime.Now.ToString("ddMMyyyyHHmmss")
                PictureBox1.Image.Save(Path.Combine(System.IO.Path.GetDirectoryName(Application.StartupPath & "\..\..\assets\"), namaImg & unikIMG & ".png"))
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub DataProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersihdata()
        lihatdata()
        mulai()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersihdata()
        batal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call koneksi()
        Try

            Dim str As String
            str = "insert into tbl_produk values (null,'" & txtKodeBuah.Text & "','" & txtNamaBuah.Text & "','" & cmbSatuan.Text & "','" & listBoxKualitas.SelectedItem & "'," & Val(txtHarga.Text) & ",'" & namaImg & unikIMG & ".png','" & txtKeterangan.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data produk berhasil disimpan!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan karena " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idbuah = DataGridView1.Item(0, i).Value
        txtKodeBuah.Text = DataGridView1.Item(1, i).Value
        txtNamaBuah.Text = DataGridView1.Item(2, i).Value

        cmbSatuan.Text = DataGridView1.Item(3, i).Value
        listBoxKualitas.SelectedItem = DataGridView1.Item(4, i).Value
        txtHarga.Text = DataGridView1.Item(5, i).Value.ToString
        PictureBox1.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.StartupPath & "\..\..\assets\") & "\" & DataGridView1.Item(6, i).Value)
        txtKeterangan.Text = DataGridView1.Item(7, i).Value
        edit()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call koneksi()
        Try

            Dim str As String
            If namaImg = "" And unikIMG = "" Then
                str = "update tbl_produk set kodeProduk = '" & txtKodeBuah.Text & "', namaBuah = '" & txtNamaBuah.Text & "', satuan = '" & cmbSatuan.Text & "', kualitas = '" & listBoxKualitas.SelectedItem & "', harga = " & Val(txtHarga.Text) & ", keterangan = '" & txtKeterangan.Text & "' where idProduk = " & idbuah & ""
            Else
                str = "update tbl_produk set kodeProduk = '" & txtKodeBuah.Text & "', namaBuah = '" & txtNamaBuah.Text & "', satuan = '" & cmbSatuan.Text & "', kualitas = '" & listBoxKualitas.SelectedItem & "', harga = " & Val(txtHarga.Text) & ", namaFile = '" & namaImg & unikIMG & ".png', keterangan = '" & txtKeterangan.Text & "' where idProduk = " & idbuah & ""
            End If

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data produk berhasil diubah!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal diubah karena " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call koneksi()
        Try

            Dim str As String

            str = "delete from tbl_produk where idProduk = " & idbuah & ""
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data produk berhasil dihapus!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus karena " & ex.Message)
        End Try
    End Sub

End Class