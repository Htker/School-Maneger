Imports MySql.Data.MySqlClient
Public Class Ajout_des_note_etudient
    Dim etu As New ETUDIANTS
    Dim note As New NOTES
    Dim mat As New MATIERES
    Dim rs As New Resizer ' Pour Redimensionner

    Sub FillGridNoteEtu(ByVal command As MySqlCommand)
        'afficher les etudiant et leur note
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = etu.getAllstudent(command)
        DataGridView1.ReadOnly = True

    End Sub
    Sub FillGridMatiere(ByVal command As MySqlCommand)

        'aficher les matiere de la filiere
        ListBox1.DataSource = mat.getallFormatiere(command)
        ListBox1.ValueMember = "Id"
        ListBox1.DisplayMember = "Nom"
    End Sub

    Private Sub Ajout_des_note_etudient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'afficher les etudiat et note
        Dim command As New MySqlCommand("SELECT etudiant.Nom, etudiant.Prenoms, matiere.Nom as Matiere, notes.Moyenne, notes.Observation 
                                         FROM notes
                                         INNER JOIN etudiant ON notes.Matricul_Etudiant = etudiant.Matricul
                                         INNER JOIN matiere ON notes.Id_Matiere = matiere.Id 
                                         WHERE CONCAT(`Matricul`) LIKE '%" & Textbox1.Text & "%'")
        FillGridNoteEtu(command)
        'aficher les matiere de la filiere       
        Dim comm As New MySqlCommand("SELECT * FROM `matiere` WHERE CONCAT(`Filliere`) LIKE '%" & lblfiliere.Text & "%'")
        FillGridMatiere(comm)

        rs.FindAllControls(Me) ' Pour Redimensionner
    End Sub

    Function verification() As Boolean
        If Textbox1.Text.Trim = "" Or HTtextbox1.Text.Trim = "" Or
           HTtextbox2.Text.Trim = "" Or HTtextbox3.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Saisie des notes

        If verification() Then 'Verifier les saisies
            Dim Matricul_Etudiant As Integer = Textbox1.Text
            Dim Id_Matiere As Integer = HTtextbox1.Text
            Dim NoteDevoir As Integer = HTtextbox2.Text
            Dim NotePartiel As Integer = HTtextbox3.Text

            Dim Moyenne As Integer  'calculer la moyenne
            Moyenne = (NoteDevoir * 0.4) + (NotePartiel * 0.6)

            Dim Observation As String
            If Moyenne >= 10 Then
                Observation = "V" 'validée
            Else
                Observation = "NV" 'non validée
            End If
            If NoteDevoir <= 20 And NotePartiel <= 20 Then   ' limiter les note
                If note.VerifierNomMatiere(Matricul_Etudiant, Id_Matiere) Then 'si la note n'existe pas encore
                    note.addNote(Matricul_Etudiant, Id_Matiere, NoteDevoir, NotePartiel, Moyenne, Observation)
                    HTtextbox2.Text = ""
                    HTtextbox3.Text = ""
                    MsgBox("Notes Ajouter", MsgBoxStyle.Information, "Ajout de note")
                    'afficher l'etudiat et ses notes
                    Dim command As New MySqlCommand("SELECT etudiant.Nom, etudiant.Prenoms, matiere.Nom as Matiere, notes.Moyenne, notes.Observation 
                                         FROM notes
                                         INNER JOIN etudiant ON notes.Matricul_Etudiant = etudiant.Matricul
                                         INNER JOIN matiere ON notes.Id_Matiere = matiere.Id 
                                         WHERE CONCAT(`Matricul`) LIKE '%" & Textbox1.Text & "%'")
                    FillGridNoteEtu(command)
                Else
                    MsgBox("Cette note existe déja", MsgBoxStyle.Exclamation, "Ajout de note")
                End If
            Else
                MsgBox("Note invalide", MsgBoxStyle.Exclamation, "Ajout de note")
            End If

        Else
            MsgBox("Valeur vite", MsgBoxStyle.Exclamation, "Ajout de note")
        End If

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        HTtextbox1.Text = ListBox1.SelectedValue
    End Sub

    Private Sub Ajout_des_note_etudient_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)  ' Pour Redimensionner
    End Sub

    Dim entier() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Private Sub HTtextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HTtextbox3.KeyPress, HTtextbox2.KeyPress
        'pour interdi la saisie des chaines de caractere
        If Not entier.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'supprimer note
        Try
            Dim Id As Integer = Textbox1.Text
            Dim Idm As Integer = HTtextbox1.Text

            If MsgBox("Etes-vous sur de vouloir supprimer cette note ?", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then
                If note.removesNote(Id, Idm) Then
                    MsgBox("Note supprimer avec succes", MsgBoxStyle.Information, "Suppression")
                    'afficher l'etudiat et ses notes
                    Dim command As New MySqlCommand("SELECT etudiant.Nom, etudiant.Prenoms, matiere.Nom as Matiere, notes.Moyenne, notes.Observation 
                                         FROM notes
                                         INNER JOIN etudiant ON notes.Matricul_Etudiant = etudiant.Matricul
                                         INNER JOIN matiere ON notes.Id_Matiere = matiere.Id 
                                         WHERE CONCAT(`Matricul`) LIKE '%" & Textbox1.Text & "%'")
                    FillGridNoteEtu(command)
                Else
                    MsgBox("Matiere Non supprimer", MsgBoxStyle.Critical, "Suppression")
                End If
            End If

        Catch ex As Exception
            MsgBox("Id matiere invalide", MsgBoxStyle.Critical, "Suppression")
        End Try
    End Sub
End Class