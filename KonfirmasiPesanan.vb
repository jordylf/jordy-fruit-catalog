Imports MySql.Data.MySqlClient

Public Class KonfirmasiPesanan
    Dim jenisEwallet() As String = {"TUNAI", "DANA", "GOPAY", "SHOPEEPAY", "OVO"}
    Dim diskon As Double
    Dim getDiskon As Double
    Dim getLevel As String
    Dim sum As Double = 0
    Dim idpelanggan As Integer = 0
    Sub lihatdata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_pesanan where status = 'Konfirmasi'", conn)
        ds = New DataSet
        da.Fill(ds, "pesanan")
        DataGridView1.DataSource = ds.Tables("pesanan")
    End Sub

    Function cariData(kodeMember As String) As String

        Call koneksi()
        Try
            Dim str As String
            str = "select * from tbl_member where kodeMember = '" & kodeMember & "' AND status = '1'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtNamaPelanggan.Text = rd.Item(3)
                txtLevel.Text = rd.Item(5)
                getLevel = rd.Item(5)
                Select Case getLevel
                    Case "BASIC"
                        diskon = 0.05

                    Case "PRO"
                        diskon = 0.1

                    Case "ULTIMA"
                        diskon = 0.2

                    Case Else
                        diskon = 0
                End Select
                txtTelp.Text = rd.Item(7)
                txtTelpPelanggan.Text = rd.Item(7)
                getDiskon = sum * diskon
                txtDiskon.Text = getDiskon
                txtHargaBayar.Text = Val(txtHargaTotal.Text) - getDiskon
                conn.Close()



            Else
                MessageBox.Show("Kode Member yang dicari tidak ada.")
                conn.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Pesan Error : " & ex.Message)
        End Try
    End Function
    Private Sub KonfirmasiPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lihatdata()

        txtKodePesan.Text = DataKeranjang.kodePesanan


        For i = 0 To DataGridView1.Rows.Count - 1
            sum += DataGridView1.Rows(i).Cells(8).Value
        Next

        txtHargaTotal.Text = sum.ToString

        cmbPembayaran.MaxDropDownItems = jenisEwallet.Length
        For stepper = 0 To (jenisEwallet.Length - 1)
            cmbPembayaran.Items.Add(jenisEwallet(stepper))
        Next

        Call koneksi()
        Try
            Dim str2 As String
            str2 = "select * from tbl_pesanan order by idpesanan desc limit 1"
            cmd2 = New MySqlCommand(str2, conn)
            rd = cmd2.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtKodePesan.Text = rd.Item(6)
                conn.Close()
            Else
                MessageBox.Show("Tidak Bisa diproses.")
                conn.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Pesan Error : " & ex.Message)
            conn.Close()

        End Try


    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        cariData(txtKodeMember.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub txtNominal_TextChanged(sender As Object, e As EventArgs) Handles txtNominal.TextChanged
        txtKembalian.Text = Val(txtNominal.Text) - Val(txtHargaBayar.Text)
    End Sub

    Private Sub btnKonfimasi_Click(sender As Object, e As EventArgs) Handles btnKonfimasi.Click
        Call koneksi()
        Try

            Dim str As String
            str = "insert into tbl_pelanggan values (null,'" & txtKodePelanggan.Text & "',now(),'" & txtNamaPelanggan.Text & "','" & txtTelpPelanggan.Text & "','" & txtKodeMember.Text & "'," & Val(txtHargaBayar.Text) & ",'" & cmbPembayaran.Text & "','" & txtNoHPPayment.Text & "'," & Val(txtKembalian.Text) & ",'1')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pelanggan berhasil disimpan!")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan karena " & ex.Message)
            conn.Close()
        End Try

        Call koneksi()
        Try
            Dim str2 As String
            str2 = "select * from tbl_pelanggan order by idpelanggan desc limit 1"
            cmd2 = New MySqlCommand(str2, conn)
            rd = cmd2.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                idpelanggan = rd.Item(0)
                conn.Close()

                Call koneksi()
                Try

                    Dim str3 As String

                    str3 = "update tbl_pesanan set kodePesanan = '" & txtKodePesan.Text & "', status = 'Selesai', idpelanggan = " & idpelanggan & " where status = 'Konfirmasi'"
                    cmd3 = New MySqlCommand(str3, conn)
                    cmd3.ExecuteNonQuery()
                    MessageBox.Show("Sukses, telah melakukan transaksi pembayaran pesanan dari pelanggan dengan baik!")
                    Me.Close()
                    DataKeranjang.Close()
                    DataKatalog.Close()

                Catch ex As Exception
                    MessageBox.Show("Data gagal diupdate karena " & ex.Message)
                End Try

            Else
                MessageBox.Show("Tidak Bisa diproses.")
                conn.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Pesan Error : " & ex.Message)
            conn.Close()

        End Try

    End Sub

    Private Sub cmbPembayaran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPembayaran.SelectedIndexChanged
        If cmbPembayaran.SelectedItem = "TUNAI" Then
            txtNoHPPayment.ReadOnly = True
        Else
            txtNoHPPayment.ReadOnly = False
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Hide()
    End Sub
End Class