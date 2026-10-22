Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub timerLoading_Tick(sender As Object, e As EventArgs) Handles timerLoading.Tick
        LoadingBar.Value = LoadingBar.Value + 1
        If LoadingBar.Value = 100 Then
            timerLoading.Stop()
            Login.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        timerLoading.Start()
        Call koneksi()
        Try

        Catch ex As Exception
            MessageBox.Show("Pesan Error : " & ex.Message)
            Application.Exit()
        End Try


    End Sub

End Class
