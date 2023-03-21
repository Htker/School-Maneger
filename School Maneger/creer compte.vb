Imports MySql.Data.MySqlClient
Public Class creer_compte
    Dim conn As New CONNECTION
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creer un new compte
        If Textbox1.Text.Trim = "" Or HTtextbox1.Text.Trim = "" Or HTtextbox2.Text.Trim = "" Or HTtextbox3.Text.Trim = "" Then
            MsgBox("veillez saisir tous les informations", MsgBoxStyle.Critical, "Creation de compte")
        Else
            If HTtextbox1.Text = HTtextbox2.Text Then
                Try

                    Dim adapter As New MySqlDataAdapter
                    Dim table As New DataTable
                    Dim comm As New MySqlCommand("INSERT INTO `connexion`( `usernam`, `Mail`, `password`) VALUES (@urs, @ma, @pass)", conn.getconnection)

                    comm.Parameters.Add("@urs", MySqlDbType.VarChar).Value = Textbox1.Text
                    comm.Parameters.Add("@ma", MySqlDbType.VarChar).Value = HTtextbox3.Text
                    comm.Parameters.Add("@pass", MySqlDbType.VarChar).Value = HTtextbox1.Text

                    adapter.SelectCommand = comm
                    adapter.Fill(table)
                    conn.openConnection()

                    If table.Rows.Count > 0 Then
                    Else
                        Dim men As New Connexion
                        MsgBox("Compte creer avec succes", MsgBoxStyle.Information, "Creation de compte")
                        men.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Mot de passe incorrect", MsgBoxStyle.Exclamation, "Creation de compte")
            End If

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If HTtextbox2.UseSystemPasswordChar Then
            HTtextbox2.UseSystemPasswordChar = False
            Button5.Image = Button7.Image
        Else
            HTtextbox2.UseSystemPasswordChar = True
            Button5.Image = Button6.Image
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If HTtextbox1.UseSystemPasswordChar Then
            HTtextbox1.UseSystemPasswordChar = False
            Button4.Image = Button7.Image
        Else
            HTtextbox1.UseSystemPasswordChar = True
            Button4.Image = Button6.Image
        End If
    End Sub
End Class