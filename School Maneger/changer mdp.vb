Imports MySql.Data.MySqlClient
Public Class changer_mdp
    Dim conn As New CONNECTION
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Connexion.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Changer le mot de passe
        If HTtextbox1.Text = Textbox2.Text Then
            Try

                Dim adapter As New MySqlDataAdapter
                Dim table As New DataTable
                Dim comm As New MySqlCommand("UPDATE `connexion` SET `password`= @mdp WHERE `usernam`=@urs OR `Mail`= @urs", conn.getconnection)

                comm.Parameters.Add("@urs", MySqlDbType.VarChar).Value = usernam.Text
                comm.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = HTtextbox1.Text

                adapter.SelectCommand = comm
                adapter.Fill(table)
                conn.openConnection()

                If table.Rows.Count > 0 Then
                Else
                    MsgBox("Le mot de passe changé avec succes !", MsgBoxStyle.Information, "Connexion")
                    Dim men As New Connexion
                    men.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Les mot de passe ne correspondent pas !", MsgBoxStyle.Exclamation, "Connexion")
        End If


    End Sub
    Private currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)
        'Open form seulement'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'End '
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        Panel1.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(fin)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If HTtextbox1.UseSystemPasswordChar Then
            HTtextbox1.UseSystemPasswordChar = False
            Button5.Image = Button7.Image
        Else
            HTtextbox1.UseSystemPasswordChar = True
            Button5.Image = Button6.Image
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Textbox2.UseSystemPasswordChar Then
            Textbox2.UseSystemPasswordChar = False
            Button4.Image = Button7.Image
        Else
            Textbox2.UseSystemPasswordChar = True
            Button4.Image = Button6.Image
        End If
    End Sub

End Class