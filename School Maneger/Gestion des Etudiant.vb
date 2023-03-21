Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Gestion_des_Etudiant
    Dim fili As New FILLIERES
    Dim etu As New ETUDIANTS
    Dim rs As New Resizer ' Pour Redimensionner


    Sub FillGrid(ByVal command As MySqlCommand)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = etu.getAllstudent(command)
        'Adapter l'image au cellule du DataGridView
        Dim colonPhoto As New DataGridViewImageColumn
        colonPhoto = DataGridView1.Columns(7)
        colonPhoto.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView1.ReadOnly = True
        'DataGridView1.RowTemplate.Height = 80
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'choisir la photo
        Dim tof As New OpenFileDialog
        tof.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If tof.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(tof.FileName)
        End If

        PictureBox1.Shape(100, 0)  'Arondir le picturbox
        Me.Refresh()
    End Sub


    Private Sub Gestion_des_Etudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Afficher les fillieres
        ComboBox1.DataSource = fili.getAllFilliere
        ComboBox1.ValueMember = "Id"
        ComboBox1.DisplayMember = "Nom"
        'ComboBox1.SelectedItem = Nothing

        'afficher les etudiat
        Dim command As New MySqlCommand("SELECT * FROM `etudiant`")
        FillGrid(command)

        rs.FindAllControls(Me) ' Pour Redimensionner
    End Sub


    Function verif() As Boolean  'pour vérifier les saisi 
        If Textbox1.Text.Trim = "" Or HTtextbox1.Text.Trim = "" Or
            HTtextbox2.Text.Trim = "" Or
            PictureBox1.Image Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Ajouter etudiant
        Dim Nom As String = Textbox1.Text
        Dim Prenoms As String = HTtextbox1.Text

        Dim Sexe As String = "Masculin"
        If xx.Checked Then
            Sexe = "Féminin"
        End If

        Dim DateNaissace As String = DateTimePicker1.Value

        Dim filliere As String = ComboBox1.SelectedValue
        Dim Telephone As String = HTtextbox2.Text
        Dim Photo As New MemoryStream

        'Vérifier si la date est trop petite ou trop grande
        Dim annee_naissance As Integer = DateTimePicker1.Value.Year
        Dim cette_annee As Integer = Date.Now.Year

        'age  comprise entre 10 et 100
        If cette_annee - annee_naissance < 10 Or cette_annee - annee_naissance > 100 Then
            MsgBox("Date invalide", MsgBoxStyle.Critical, "Ajout")
        Else
            If verif() Then
                PictureBox1.Image.Save(Photo, PictureBox1.Image.RawFormat)
                If etu.VerifierNomEtudiant(Nom, Prenoms, Nothing) Then 'Verifier si l'etudiant existe deja
                    If etu.addETUDIANTS(Nom, Prenoms, Sexe, DateNaissace, filliere, Telephone, Photo) Then
                        MsgBox("Ajouter avec succes", MsgBoxStyle.Information, "Ajout")
                        Dim command As New MySqlCommand("SELECT * FROM `etudiant`") 'afficher dans le DataGridView
                        FillGrid(command)
                    Else
                        MsgBox("Erreur", MsgBoxStyle.Critical, "Ajout")
                    End If
                Else
                    MsgBox("Cet Etudiant est deja enrégistré", MsgBoxStyle.Critical, "Ajout")
                End If

            Else
                MsgBox("Valeur vide", MsgBoxStyle.Critical, "Ajout")
            End If
        End If
    End Sub
    Sub raffraichir()
        Textbox1.Text = ""
        HTtextbox2.Text = ""
        xy.Checked = True
        DateTimePicker1.Value = Date.Now
        PictureBox1.Image = Nothing
        HTtextbox1.Text = ""
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Suprimer etudiant
        'et si l'utilisateur veut continuer la suppression, nous devons également supprimer ses notes..
        ' Pour le faire , nous ajouterons FOREIGN KEY ON DELETE CASCADE.
        'ON DELETE CASCADE signifie que lorsque nous supprimons l'élément parent,
        'l'enfant sera également supprimé


        ' ==> le code SQL :-->
        '                        ALTER TABLE notes
        '                        ADD Constraint fk_Etudiant
        '                        FOREIGN KEY(Matricul_Etudiant) REFERENCES etudiant(Matricul)
        '                        ON DELETE CASCADE
        Try
            Dim matricul As Integer = Convert.ToInt32(Label7.Text)

            If MsgBox("Etes-vous sur de vouloir supprimer cet Etudiant ??", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then
                If etu.removeETUDIANTS(matricul) Then
                    MsgBox("Etudiant suprimer avec succes", MsgBoxStyle.Information, "suppression")
                    raffraichir()
                    Dim command As New MySqlCommand("SELECT * FROM `etudiant`") 'afficher dans le DataGridView
                    FillGrid(command)
                Else
                    MsgBox("Erreur de suppression ", MsgBoxStyle.Critical, "suppression")
                End If
            End If
        Catch ex As Exception
            MsgBox("Matricul nom valide ", MsgBoxStyle.Critical, "suppression")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Modifier etudiant
        Dim matricul As Integer
        Dim Nom As String = Textbox1.Text
        Dim Prenoms As String = HTtextbox1.Text

        Dim Sexe As String = "Masculin"
        If xx.Checked Then
            Sexe = "Féminin"
        End If

        Dim DateNaissace As String = DateTimePicker1.Value

        Dim filliere As String = ComboBox1.SelectedValue
        Dim Telephone As String = HTtextbox2.Text
        Dim Photo As New MemoryStream

        'Vérifier si la date est trop petite ou trop grande
        Dim annee_naissance As Integer = DateTimePicker1.Value.Year
        Dim cette_annee As Integer = Date.Now.Year

        'age  comprise entre 10 et 100
        If cette_annee - annee_naissance < 10 Or cette_annee - annee_naissance > 100 Then
            MsgBox("Date invalide", MsgBoxStyle.Critical, "Modification")
        Else
            If verif() Or Label7.Text.Trim = "" Then
                Try
                    matricul = Convert.ToInt32(Label7.Text)
                Catch ex As Exception
                    MsgBox("Matricul invalide", MsgBoxStyle.Critical, "Modification")
                End Try
                PictureBox1.Image.Save(Photo, PictureBox1.Image.RawFormat)

                If etu.VerifierNomEtudiant(Nom, Nothing, Nothing) Then 'Verifier si l'etudiant existe deja
                    If etu.editETUDIANTS(matricul, Nom, Prenoms, Sexe, DateNaissace, filliere, Telephone, Photo) Then
                        MsgBox("Modifier avec succes", MsgBoxStyle.Information, "Modification")
                        Dim command As New MySqlCommand("SELECT * FROM `etudiant`") 'afficher dans le DataGridView
                        FillGrid(command)
                    Else
                        MsgBox("Erreur", MsgBoxStyle.Critical, "Modification")
                    End If
                End If

            Else
                MsgBox("Valeur vide", MsgBoxStyle.Critical, "Modification")
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        Label7.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Textbox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        HTtextbox1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString

        If DataGridView1.CurrentRow.Cells(3).Value.ToString = "Féminin" Then
            xx.Checked = True
        End If


        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
        ComboBox1.SelectedValue = DataGridView1.CurrentRow.Cells(5).Value.ToString
        HTtextbox2.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

        Dim tof As Byte()
        tof = DataGridView1.CurrentRow.Cells(7).Value
        Dim photo As New MemoryStream(tof)
        PictureBox1.Image = Image.FromStream(photo)
    End Sub

    Private Sub Gestion_des_Etudiant_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)  ' Pour Redimensionner
    End Sub

    Dim entier() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Private Sub HTtextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HTtextbox2.KeyPress
        'pour interdi la saisie des chaines de caractere
        If Not entier.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub
End Class