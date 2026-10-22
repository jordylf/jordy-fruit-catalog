Imports MySql.Data.MySqlClient
Public Class DataMember
    Dim getStatus() As String = {"0", "1"}
    Dim idmember As Integer = 0
    Dim varStatus As String


    Sub bersihdata()
        txtKodeMember.Clear()
        txtNama.Clear()
        RichTextAlamat.Clear()
        txtEmail.Clear()
        txtTelp.Clear()
        cbStatus.Text = ""
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
        da = New MySqlDataAdapter("select * from tbl_member", conn)
        ds = New DataSet
        da.Fill(ds, "member")
        DataGridView1.DataSource = ds.Tables("member")
    End Sub
    Private Sub DataMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bersihdata()
        lihatdata()
        mulai()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        bersihdata()
        mulai()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call koneksi()
        Try

            Dim str As String
            str = "insert into tbl_member values (null,'" & txtKodeMember.Text & "','" & Format(dtpTglDaftar.Value, "yyyy-MM-dd") & "','" & txtNama.Text & "','" & RichTextAlamat.Text & "','" & ListBoxLevel.SelectedItem & "','" & txtEmail.Text & "','" & txtTelp.Text & "','" & getStatus(cbStatus.SelectedIndex) & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data member berhasil disimpan!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan karena " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idmember = DataGridView1.Item(0, i).Value
        txtKodeMember.Text = DataGridView1.Item(1, i).Value
        dtpTglDaftar.Value = DataGridView1.Item(2, i).Value

        txtNama.Text = DataGridView1.Item(3, i).Value
        RichTextAlamat.Text = DataGridView1.Item(4, i).Value
        ListBoxLevel.SelectedItem = DataGridView1.Item(5, i).Value
        txtEmail.Text = DataGridView1.Item(6, i).Value
        txtTelp.Text = DataGridView1.Item(7, i).Value
        varStatus = DataGridView1.Item(8, i).Value
        If varStatus = "1" Then
            cbStatus.Text = "Aktif"
        ElseIf varStatus = "0" Then
            cbStatus.Text = "NonAktif"
        End If
        edit()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call koneksi()
        Try

            Dim str As String
            str = "update tbl_member set kodeMember = '" & txtKodeMember.Text & "', tglDaftar = '" & Format(dtpTglDaftar.Value, "yyyy-MM-dd") & "', namaMember = '" & txtNama.Text & "', alamat = '" & RichTextAlamat.Text & "', level = '" & ListBoxLevel.SelectedItem & "', email = '" & txtEmail.Text & "', noTelp = '" & txtTelp.Text & "', status = '" & getStatus(cbStatus.SelectedIndex) & "' where idMember = " & idmember & ""
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data member berhasil diedit!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal diedit karena " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call koneksi()
        Try

            Dim str As String
            str = "delete from tbl_member where idMember = " & idmember & ""
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data member berhasil dihapus!")
            lihatdata()
            bersihdata()
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus karena " & ex.Message)
        End Try
    End Sub
End Class