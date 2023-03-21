Imports MySql.Data.MySqlClient
Public Class NOTES
    Dim connect As New CONNECTION
    'créer une fonction pour insérer une note
    Function addNote(ByVal Matricul_Etudiant As Integer, ByVal Id_Matiere As Integer, ByVal NoteDevoir As Integer, ByVal NotePartiel As Integer, ByVal Moyenne As Integer, ByVal Observation As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `notes`(`Matricul_Etudiant`, `Id_Matiere`, `NoteDevoir`, `NotePartiel`, `Moyenne`, `Observation`) VALUES (@me, @im , @nd ,  @np,  @my,  @ob)", connect.getconnection)

        '@mme, @im , @nd ,  @np,  @my,  @ob
        command.Parameters.Add("@me", MySqlDbType.Int32).Value = Matricul_Etudiant
        command.Parameters.Add("@im", MySqlDbType.Int32).Value = Id_Matiere
        command.Parameters.Add("@nd", MySqlDbType.Int32).Value = NoteDevoir
        command.Parameters.Add("@np", MySqlDbType.Int32).Value = NotePartiel
        command.Parameters.Add("@my", MySqlDbType.Int32).Value = Moyenne
        command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = Observation


        connect.openConnection()

        If command.ExecuteNonQuery = 1 Then

            Return True

        Else

            Return False

        End If
    End Function

    Function VerifierNomMatiere(ByVal Matricul_Etudiant As Integer, ByVal Id_Matiere As Integer) As Boolean  'VERIFIER SI LA note AXISTE pour cet etudiant ans une matiere precis

        Dim command As New MySqlCommand("SELECT * FROM `notes` WHERE `Matricul_Etudiant` = @me AND `Id_Matiere` = @im", connect.getconnection)
        '@nm
        command.Parameters.Add("@me", MySqlDbType.Int32).Value = Matricul_Etudiant
        command.Parameters.Add("@im", MySqlDbType.Int32).Value = Id_Matiere

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            'la matiere existe
            Return False
        Else
            Return True
        End If
    End Function

    Function removesNote(ByVal Id As Integer, ByVal Idm As Integer) As Boolean  'créer une fonction pour supprimer une note
        Dim command As New MySqlCommand("DELETE FROM `notes` WHERE `Matricul_Etudiant` = @mt AND `Id_Matiere` = @Id", connect.getconnection())
        command.Parameters.Add("@mt", MySqlDbType.Int32).Value = Id
        command.Parameters.Add("@id", MySqlDbType.Int32).Value = Idm
        connect.openConnection()
        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
