Imports MySql.Data.MySqlClient
Public Class FILLIERES
    Dim conn As New CONNECTION
    'créer une fonction pour insérer un nouveau filliere
    Function addFilieres(ByVal Nom As String, ByVal Description As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `filliere`( `Nom`, `Description`) VALUES (@nm, @des)", conn.getconnection())

        '@nm, @des
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@des", MySqlDbType.VarChar).Value = Description

        conn.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            conn.closeConnection()
            Return True
        Else
            conn.closeConnection()
            Return False

        End If
    End Function

    Function getAllFilliere() As DataTable        'créer une fonction pour obtenir une liste de tous les fillieres

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectQuery As String = "SELECT * FROM `filliere` "
        command.CommandText = selectQuery
        command.Connection = conn.getconnection()
        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table

    End Function

    Function getallForFiliere(ByVal command As MySqlCommand) As DataTable  'créer une fonction pour obtenir une liste de tous les filieres

        command.Connection = conn.getconnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function
    Function getAllFilliereParId(ByVal Id As Integer) As DataTable  'créer une fonction pour obtenir une liste des info d'une filliere 

        Dim Command As New MySqlCommand("SELECT * FROM  `filliere` WHERE `Id`= @id", conn.getconnection)
        Command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id

        Dim adapter As New MySqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Function VerifierNomFilliere(ByVal Nom As String) As Boolean  'VERIFIER SI LA filliere AXISTE
        Dim command As New MySqlCommand("SELECT * FROM `filliere` WHERE `Nom` = @nm", conn.getconnection)
        '@nm
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            'la filliere existe
            Return False
        Else
            Return True
        End If
    End Function
End Class
