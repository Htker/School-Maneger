Public Class debu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Connexion.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub

End Class