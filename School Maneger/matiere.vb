Public Class matiere
    Dim mat As New MATIERES
    Dim fili As New FILLIERES
    Dim rs As New Resizer ' Pour Redimensionner

    Private Sub matiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Afficher les fillieres
        ComboBox1.DataSource = fili.getAllFilliere
        ComboBox1.ValueMember = "Id"
        ComboBox1.DisplayMember = "Nom"
        'ComboBox1.SelectedItem = Nothing

        'afficher les matieres ajouter
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = mat.getAllMatiere

        rs.FindAllControls(Me) ' Pour Redimensionner
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Ajout matiere
        Dim Nom As String = Textbox1.Text
        Dim Description As String = HTtextbox2.Text
        Dim NombreHeure As Integer = NumericUpDown1.Value
        Dim NombreCredit As Integer = NumericUpDown2.Value

        Dim Professeur As String = HTtextbox1.Text

        'NombreHeure > 20 dans les proprietés du NumericUpDown ou par condition <if>
        'la description est facultatif
        'verifier si la matiere existe deja

        If Nom.Trim = "" Then  'Verifier le nom (si vide pour remplir)
            MsgBox("Valeur vide", MsgBoxStyle.Critical, "Ajout")
        Else
            Dim Filliere As Integer = Convert.ToInt32(ComboBox1.SelectedValue)
            If mat.VerifierNomMatiere(Nom, Filliere, Nothing) Then    'verifier si la matiere existe deja
                If mat.addMatiere(Nom, Description, NombreHeure, NombreCredit, Filliere, Professeur) Then
                    MsgBox("matiere ajouter avec succes", MsgBoxStyle.Information, "ajout")
                    DataGridView1.DataSource = mat.getAllMatiere
                Else
                    MsgBox("erreur", MsgBoxStyle.Critical, "Ajout")
                End If
            Else
                MsgBox("Cette matiere existe déja", MsgBoxStyle.Critical, "Ajout")
            End If

        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Modifier matiere
        Try
            Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value.ToString
            Dim Nom As String = Textbox1.Text
            Dim Description As String = HTtextbox2.Text
            Dim NombreHeure As Integer = NumericUpDown1.Value
            Dim NombreCredit As Integer = NumericUpDown2.Value
            Dim Filliere As Integer = Convert.ToInt32(ComboBox1.SelectedValue)
            Dim Professeur As String = HTtextbox1.Text

            If Not mat.VerifierNomMatiere(Nom, Filliere, Id) Then
                MsgBox("Nom Matiere dejat enrégistrer", MsgBoxStyle.Critical, "Modification")
            Else
                If mat.editMatiere(id, Nom, Description, NombreHeure, NombreCredit, Filliere, Professeur) Then
                    MsgBox("Matiere modifier avec succes", MsgBoxStyle.Information, "Modification")
                    DataGridView1.DataSource = mat.getAllMatiere
                Else
                    MsgBox("Matiere non modifier", MsgBoxStyle.Critical, "Modification")
                End If
            End If
        Catch ex As Exception
            MsgBox("Id non spécifier", MsgBoxStyle.Critical, "Modification")
        End Try

    End Sub
    Sub raffraichir()
        Textbox1.Text = ""
        HTtextbox2.Text = ""
        NumericUpDown1.Value = 20
        NumericUpDown2.Value = 1
        HTtextbox1.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'suppimer la matiere
        'et si l'utilisateur veut continuer la suppression, nous devons également supprimer ses notes..
        ' Pour le faire , nous ajouterons FOREIGN KEY ON DELETE CASCADE.
        'ON DELETE CASCADE signifie que lorsque nous supprimons l'élément parent,
        'l'enfant sera également supprimé


        ' ==> le code SQL :-->
        '                        ALTER TABLE notes
        '                        ADD Constraint fk_Matiere 
        '                        FOREIGN KEY(Id_Matiere) REFERENCES matiere(Id)
        '                        ON DELETE CASCADE

        Try
            Dim Id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString)

            If MsgBox("Etes-vous sur de vouloir supprimer cette matiere ?", MsgBoxStyle.YesNo, "Suppression") = MsgBoxResult.Yes Then
                If mat.removesMatiere(Id) Then
                    MsgBox("Matiere supprimer avec succes", MsgBoxStyle.Information, "Suppression")

                    raffraichir()
                    DataGridView1.DataSource = mat.getAllMatiere
                Else
                    MsgBox("Matiere Non supprimer", MsgBoxStyle.Critical, "Suppression")
                End If
            End If

        Catch ex As Exception
            MsgBox("Id matiere invalide", MsgBoxStyle.Critical, "Suppression")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        Textbox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        HTtextbox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        NumericUpDown1.Value = DataGridView1.CurrentRow.Cells(3).Value
        NumericUpDown2.Value = DataGridView1.CurrentRow.Cells(4).Value
        ComboBox1.SelectedValue = DataGridView1.CurrentRow.Cells(5).Value.ToString
        HTtextbox1.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
    End Sub


    Private Sub matiere_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)  ' Pour Redimensionner
    End Sub
End Class