Imports MySql.Data.MySqlClient
Module ModKoneksi
    Public conn As MySqlConnection
    Public cmd, cmd2, cmd3 As MySqlCommand

    Public rd, rd2, rd3 As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public str As String


    Sub koneksi()

        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=db_tokojordy26624;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then

                conn.Open()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Application.Exit()

        End Try

    End Sub
End Module
