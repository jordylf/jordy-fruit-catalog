Imports MySql.Data.MySqlClient
Public Class DataPengguna
    Dim varJenisKelamin, varStatus As String
    Dim idpengguna As Integer = 0

    Sub bersihdata()
        txtNama.Clear()
        txtPass.Clear()
        txtUser.Clear()
        maskedTxtNOHP.Text = "____-____-____"
        rbLakiLaki.Checked = False
        rbPerempuan.Checked = False
        chkAktif.Checked = False
        chkNonAktif.Checked = False
        varStatus = ""
        varJenisKelamin = ""
        idpengguna = 0
    End Sub

    Sub batal()
        bersihdata()
        btnBatal.Enabled = False
        btnBersih.Enabled = False
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        idpengguna = 0
    End Sub

    Sub mulai()
        btnBatal.Enabled = False
        btnBersih.Enabled = True
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Sub lihatdata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_pengguna", conn)
        ds = New DataSet
        da.Fill(ds, "pengguna")
        DataGridView1.DataSource = ds.Tables("pengguna")
    End Sub

    Sub edit()
        btnBatal.Enabled = True
        btnBersih.Enabled = False
        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub rbLakiLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbLakiLaki.CheckedChanged
        varJenisKelamin = rbLakiLaki.Text
    End Sub

    Private Sub rbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerempuan.CheckedChanged
        varJenisKelamin = rbPerempuan.Text
    End Sub

    Private Sub chkAktif_CheckedChanged(sender As Object, e As EventArgs) Handles chkAktif.CheckedChanged
        varStatus = "1"
        chkNonAktif.Checked = False

    End Sub

    Private Sub chkNonAktif_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonAktif.CheckedChanged
        varStatus = "0"
        chkAktif.Checked = False
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call koneksi()
        Try

            Dim str As String
            str = "insert into tbl_pengguna values (null,'" & txtNama.Text & "','" & varJenisKelamin & "','" & Format(dtpTglLhr.Value, "yyyy-MM-dd") & "','" & maskedTxtNOHP.Text & "','" & txtUser.Text & "','" & txtPass.Text & "','admin','" & varStatus & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pengguna berhasil disimpan!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan karena " & ex.Message)
        End Try
    End Sub

    Private Sub DataPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mulai()
        lihatdata()

    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        bersihdata()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call koneksi()
        Try
            Dim str As String
            str = "update tbl_pengguna set namaLengkap = '" & txtNama.Text & "', jenisKelamin = '" & varJenisKelamin & "', tglLahir = '" & Format(dtpTglLhr.Value, "yyyy-MM-dd") & "', noTelp = '" & maskedTxtNOHP.Text & "', namaPengguna = '" & txtUser.Text & "', kataSandi = '" & txtPass.Text & "', role = 'admin', status = '" & varStatus & "' where idpengguna = " & idpengguna & ""
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pengguna berhasil diedit!")
            lihatdata()
            bersihdata()
            mulai()

        Catch ex As Exception
            MessageBox.Show("Data gagal diedit karena " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from tbl_pengguna where idpengguna = " & idpengguna & ""
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pengguna berhasil dihapus!")
            lihatdata()
            bersihdata()
            mulai()

        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus karena " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idpengguna = DataGridView1.Item(0, i).Value
        txtNama.Text = DataGridView1.Item(1, i).Value
        varJenisKelamin = DataGridView1.Item(2, i).Value
        If varJenisKelamin = "Laki-Laki" Then
            rbLakiLaki.Checked = True
        ElseIf varJenisKelamin = "Perempuan" Then
            rbPerempuan.Checked = True
        End If
        dtpTglLhr.Value = DataGridView1.Item(3, i).Value
        maskedTxtNOHP.Text = DataGridView1.Item(4, i).Value
        txtUser.Text = DataGridView1.Item(5, i).Value
        txtPass.Text = DataGridView1.Item(6, i).Value
        varStatus = DataGridView1.Item(8, i).Value
        If varStatus = "1" Then
            chkAktif.Checked = True
            chkNonAktif.Checked = False
        ElseIf varStatus = "0" Then
            chkNonAktif.Checked = True
            chkAktif.Checked = False
        End If
        edit()



    End Sub
End Class