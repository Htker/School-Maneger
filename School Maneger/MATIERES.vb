
Imports MySql.Data.MySqlClient

Public Class MATIERES
    Private connect As New CONNECTION

    'créer une fonction pour insérer une matiere
    'Nom Description NombreHeure NombreCredit Filliere Professeur
    Function addMatiere(ByVal Nom As String, ByVal Description As String, ByVal NombreHeure As Integer, ByVal NombreCredit As Integer, ByVal Filliere As Integer, ByVal Professeur As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `matiere`(`Nom`, `Description`, `NombreHeure`, `NombreCredit`, `Filliere`, `Professeur`) VALUES (@nm, @des , @nh ,  @nc,  @fl,  @pr)", connect.getconnection)

        '@nm, @des , @nh ,  @nc,  @fl,  @pr
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@des", MySqlDbType.VarChar).Value = Description
        command.Parameters.Add("@nh", MySqlDbType.Int32).Value = NombreHeure
        command.Parameters.Add("@nc", MySqlDbType.Int32).Value = NombreCredit
        command.Parameters.Add("@fl", MySqlDbType.Int32).Value = Filliere
        command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = Professeur


        connect.openConnection()

        If command.ExecuteNonQuery = 1 Then

            Return True

        Else

            Return False

        End If
    End Function

    Function VerifierNomMatiere(ByVal Nom As String, ByVal Filliere As String, ByVal Optional Id As Integer = 0) As Boolean  'VERIFIER SI LA MATIERE AXISTE pour un filliere precis
        ' `Id` <> @id signifie ==> quand l'identifiant est différent du cours en cours
        Dim command As New MySqlCommand("SELECT * FROM `matiere` WHERE `Nom` = @nm AND `Filliere` = @fil AND `Id` <> @id", connect.getconnection)
        '@nm
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@fil", MySqlDbType.VarChar).Value = Filliere
        command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id

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

    'créer une fonction pour modifier matiere

    Function editMatiere(ByVal Id As Integer, ByVal Nom As String, ByVal Description As String, ByVal NombreHeure As Integer, ByVal NombreCredit As Integer, ByVal Filliere As Integer, ByVal Professeur As String) As Boolean
        Dim command As New MySqlCommand("UPDATE `matiere` SET `Nom`=  @nm, `Description`= @des, `NombreHeure`= @nh , `NombreCredit`=  @nc, `Filliere`=  @fl, `Professeur`= @pr WHERE `Id`= @mat", connect.getconnection())

        '@mat, @nm, @des , @nh ,  @nc,  @fl,  @pr
        command.Parameters.Add("@mat", MySqlDbType.Int32).Value = Id
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@des", MySqlDbType.VarChar).Value = Description
        command.Parameters.Add("@nh", MySqlDbType.Int32).Value = NombreHeure
        command.Parameters.Add("@nc", MySqlDbType.Int32).Value = NombreCredit
        command.Parameters.Add("@fl", MySqlDbType.Int32).Value = Filliere
        command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = Professeur

        connect.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            connect.closeConnection()
            Return True

        Else
            connect.closeConnection()
            Return False

        End If
    End Function



    Function removesMatiere(ByVal Id As Integer) As Boolean  'créer une fonction pour supprimer une matiere


        Dim command As New MySqlCommand("DELETE FROM `matiere` WHERE `Id` = @id", connect.getconnection())

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id

        connect.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False

        End If
    End Function


    Function getAllMatiere() As DataTable  'créer une fonction pour obtenir une liste de tous les matieres

        Dim Command As New MySqlCommand("SELECT * FROM `matiere`", connect.getconnection)

        Dim adapter As New MySqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Function getAllMatiereParId(ByVal Id As Integer) As DataTable  'créer une fonction pour obtenir une liste des info d'une matieres 

        Dim Command As New MySqlCommand("SELECT * FROM `matiere` WHERE `Id`=@id", connect.getconnection)
        Command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id

        Dim adapter As New MySqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Function getallFormatiere(ByVal command As MySqlCommand) As DataTable  'créer une fonction pour obtenir une liste de tous les matieres

        command.Connection = connect.getconnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function
End Class
'Ajouter clee secondaire (foreign key) entre la table metiere et filiere :
'       ====>
'               ALTER TABLE matiere
'               ADD Constraint fk_Filliere
'               FOREIGN KEY(Filliere) REFERENCES filliere(Id)
'               On DELETE CASCADE 
'               On UPDATE CASCADE
