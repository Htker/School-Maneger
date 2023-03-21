Public Class Aide
    Dim rs As New Resizer ' Pour Redimensionner
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "&<<" Then
            Button5.Text = "&>>"
            HTtextbox1.Visible = True
        Else
            Button5.Text = "&<<"
            HTtextbox1.Visible = False
        End If
    End Sub

    Private Sub Aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me) ' Pour Redimensionner
    End Sub

    Private Sub Aide_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)  ' Pour Redimensionner
    End Sub
End Class