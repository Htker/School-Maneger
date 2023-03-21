Public Class connetion
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Menu.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub
End Class