Imports MySql.Data.MySqlClient
Public Class Ajout_note
    Dim etu As New ETUDIANTS

    Sub FillGrid(ByVal command As MySqlCommand)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = etu.getAllstudent(command)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Ajout_des_note_etudient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'afficher les etudiat
        Dim command As New MySqlCommand("SELECT `Matricul`, `Nom`, `Prenoms`, `Filliere` FROM `etudiant` ")
        FillGrid(command)

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
        Panel2.Visible = False
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim ajout As New Ajout_des_note_etudient
        ajout.Textbox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ajout.lblfiliere.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        OpenChildForm(ajout)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Textbox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'afficher le resultat du recherche
        Dim command As New MySqlCommand("SELECT `Matricul`, `Nom`, `Prenoms`, `Filliere` 
                                         FROM `etudiant` 
                                         WHERE CONCAT(`Matricul`,`Nom`,`Prenoms`) LIKE '%" & Textbox1.Text & "%'")
        FillGrid(command)
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles Textbox1.TextChanged

    End Sub
End Class