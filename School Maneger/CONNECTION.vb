Imports MySql.Data.MySqlClient
Public Class CONNECTION

    Private connect As New MySqlConnection("server=localhost;database=projet_de_classe;userid=root")
    Function getconnection() As MySqlConnection
        Return connect
    End Function
    Sub openConnection()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
        Catch ex As Exception
            MsgBox("Erreur de connection")
        End Try

    End Sub
    Sub closeConnection()
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
    End Sub

End Class
