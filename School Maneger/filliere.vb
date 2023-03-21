Public Class filliere
    Dim fili As New FILLIERES
    Dim rs As New Resizer ' Pour Redimensionner

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Nom As String = Textbox1.Text
            Dim desc As String = HTtextbox1.Text

            If fili.VerifierNomFilliere(Nom) Then
                If Nom.Trim = "" Then
                    MsgBox("Saisir le nom de la fillière", MsgBoxStyle.Exclamation, "Enrégistrement")
                Else
                    If fili.addFilieres(Nom, desc) Then
                        MsgBox("Enrégistrer", MsgBoxStyle.Information, "Enrégistrement")
                        ListBox1.DataSource = fili.getAllFilliere()
                    Else
                        MsgBox("erreur", MsgBoxStyle.Critical, "Enrégistrement")
                    End If
                End If
            Else
                MsgBox("Cette fillière exist", MsgBoxStyle.Critical, "Enrégistrement")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub filliere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = fili.getAllFilliere
        ListBox1.ValueMember = "Id"
        ListBox1.DisplayMember = "Nom"

        rs.FindAllControls(Me) ' Pour Redimensionner
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim valeur As DataRowView = ListBox1.SelectedItem
        Textbox1.Text = valeur.Item(1).ToString
        HTtextbox1.Text = valeur.Item(2).ToString
    End Sub

    Private Sub filliere_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)  ' Pour Redimensionner
    End Sub
End Class