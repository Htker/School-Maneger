Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New CONNECTION
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Connexion.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        creer_compte.Show()
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
        'Receuillir le usernam ou Mail
        Try

            Dim adapter As New MySqlDataAdapter
            Dim table As New DataTable
            Dim comm As New MySqlCommand("SELECT * FROM `connexion` WHERE `Usernam` = @usr OR `Mail` = @usr", conn.getconnection)

            comm.Parameters.Add("@usr", MySqlDbType.VarChar).Value = Textbox1.Text

            adapter.SelectCommand = comm
            adapter.Fill(table)
            conn.openConnection()

            If table.Rows.Count > 0 Then
                Dim men As New changer_mdp
                men.usernam.Text = Textbox1.Text
                men.Show()
                Me.Hide()
                Textbox1.Text = ""
            Else
                MsgBox("Cet compte n'existe pas !", MsgBoxStyle.Exclamation, "Recupération")
                Textbox1.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
