Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ETUDIANTS
    Private connection As New CONNECTION
    'créer une fonction pour insérer un nouveau ETUDIANTS
    Function addETUDIANTS(ByVal Nom As String, ByVal Prenoms As String, ByVal Sexe As String, ByVal DateNaissance As Date, ByVal Filliere As String, ByVal Telephone As String, ByVal Photo As MemoryStream) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `etudiant`( `Nom`, `Prenoms`, `Sexe`, `DateNaissace`, `Filliere`, `Telephone`, `Photo`) VALUES (@nm, @pren, @sx, @datn, @fill, @tel, @pho)", connection.getconnection())
        Dim cmm As New MySqlCommand(" UPDATE etudiant SET Nom=UPPER(NOM)", connection.getconnection())

        '@nm, @pren, @sx, @datn, @fill, @tel, @pho
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@pren", MySqlDbType.VarChar).Value = Prenoms
        command.Parameters.Add("@sx", MySqlDbType.VarChar).Value = Sexe
        command.Parameters.Add("@datn", MySqlDbType.DateTime).Value = DateNaissance
        command.Parameters.Add("@fill", MySqlDbType.VarChar).Value = Filliere
        command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telephone
        command.Parameters.Add("@pho", MySqlDbType.LongBlob).Value = Photo.ToArray

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 And cmm.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True
        Else
            connection.closeConnection()
            Return False

        End If
    End Function

    Function VerifierNomEtudiant(ByVal Nom As String, ByVal Prenoms As String, ByVal Optional Matricul As Integer = 0) As Boolean  'VERIFIER SI LA Etudiant AXISTE deja
        ' `Matricul` <> @id signifie ==> quand l'identifiant est différent de celui en cours
        Dim command As New MySqlCommand("SELECT * FROM `etudiant` WHERE `Nom`=@nm AND `Prenoms`= @pren AND `Matricul`<> @mat", connection.getconnection)
        '@nm , @pren , @mat
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@pren", MySqlDbType.VarChar).Value = Prenoms
        command.Parameters.Add("@mat", MySqlDbType.Int32).Value = Matricul

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

    'créer une fonction pour modifier un ETUDIANT
    Function editETUDIANTS(ByVal Matricul As Integer, ByVal Nom As String, ByVal Prenoms As String, ByVal Sexe As String, ByVal DateNaissace As Date, ByVal Filliere As String, ByVal Telephone As String, ByVal Photo As MemoryStream) As Boolean
        Dim command As New MySqlCommand("UPDATE `etudiant` SET `Nom`= @nm,`Prenoms`= @pren, `Sexe`= @sx, `DateNaissace`= @datn, `Filliere`= @fill, `Telephone`= @tel, `Photo`= @pho WHERE `Matricul`= @mat", connection.getconnection())
        Dim cmm As New MySqlCommand(" UPDATE etudiant SET Nom=UPPER(NOM)", connection.getconnection())

        '@mat, @nm, @pren, @sx, @datn, @fill, @tel, @pho
        command.Parameters.Add("@mat", MySqlDbType.Int32).Value = Matricul
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Nom
        command.Parameters.Add("@pren", MySqlDbType.VarChar).Value = Prenoms
        command.Parameters.Add("@sx", MySqlDbType.VarChar).Value = Sexe
        command.Parameters.Add("@datn", MySqlDbType.Date).Value = DateNaissace
        command.Parameters.Add("@fill", MySqlDbType.VarChar).Value = Filliere
        command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = Telephone
        command.Parameters.Add("@pho", MySqlDbType.LongBlob).Value = Photo.ToArray

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 And cmm.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True
        Else
            connection.closeConnection()
            Return False

        End If
    End Function

    Function removeETUDIANTS(ByVal Matricul As Integer) As Boolean     'créer une fonction pour supprimer un ETUDIANT

        Dim command As New MySqlCommand("DELETE FROM `etudiant` WHERE `Matricul`= @mat", connection.getconnection())

        command.Parameters.Add("@mat", MySqlDbType.Int32).Value = Matricul

        connection.openConnection()

        If command.ExecuteNonQuery() > 0 Then
            connection.closeConnection()
            Return True
        Else
            connection.closeConnection()
            Return False

        End If
    End Function

    Function getAllETUDIANTS() As DataTable        'créer une fonction pour obtenir une liste de tous les ETUDIANTS

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectQuery As String = "SELECT * FROM `etudiant` "
        command.CommandText = selectQuery
        command.Connection = connection.getconnection()
        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table

    End Function

    Function getAllstudent(ByVal command As MySqlCommand) As DataTable  'créer une fonction pour obtenir une liste de tous les etudiants

        command.Connection = connection.getconnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Function getAllEtudiantParId(ByVal Matricul As Integer) As DataTable  'créer une fonction pour obtenir une liste des info d'une etudiants 

        Dim Command As New MySqlCommand("SELECT * FROM  `etudiant` WHERE `Matricul`= @mat", connection.getconnection)
        Command.Parameters.Add("@mat", MySqlDbType.Int32).Value = Matricul

        Dim adapter As New MySqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

End Class
' Annotation du matricul a partir de 20221 ==>
'ALTER TABLE etudiant MODIFY Matricul INT NOT NULL AUTO_INCREMENT, AUTO_INCREMENT = 20221

'Ajouter clee secondaire (foreign key) entre la table etudiant et filiere :
'       ====>
'               ALTER TABLE etudiant
'               ADD Constraint fk_Filliere
'               FOREIGN KEY(Filliere) REFERENCES filliere(Id)
'               On DELETE CASCADE 
'               On UPDATE CASCADE
