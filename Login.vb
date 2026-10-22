Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = False Then
            txtPass.PasswordChar = "*"
        Else
            txtPass.PasswordChar = ""
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        Try
            Dim str As String
            str = "select * from tbl_pengguna where namaPengguna = '" & txtUser.Text & "' AND kataSandi = '" & txtPass.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MessageBox.Show("Anda Berhasil Masuk!")
                conn.Close()
                dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau Password anda salah!")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Pesan Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Anda Keluar Aplikasi!")
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Username : admin / Password : 1234")
    End Sub
End Class