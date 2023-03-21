Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing   'POUR LE RELEVE
Imports System.IO
Public Class Affiche_note
    Dim etu As New ETUDIANTS
    Dim note As New NOTES
    Dim mat As New MATIERES
    Dim fili As New FILLIERES
    Dim rs As New Resizer ' Pour Redimensionner

    Sub FillGrid_Etu(ByVal command As MySqlCommand)
        ''afficher les etudiant et leur note
        ComboBox3.DataSource = etu.getAllstudent(command)
        ComboBox3.DisplayMember = "matricul"
        ComboBox3.ValueMember = "matricul"
        ComboBox3.SelectedItem = Nothing
    End Sub

    Sub DataGrid_Etu(ByVal command As MySqlCommand)
        'afficher les etudiant et leur note
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = etu.getAllstudent(command)
        DataGridView1.ReadOnly = True
    End Sub
    Sub FillGrid_Matiere(ByVal command As MySqlCommand)
        'afficher les matieres et les note
        ComboBox4.DataSource = mat.getallFormatiere(command)
        ComboBox4.DisplayMember = "Nom"
        ComboBox4.ValueMember = "Id"
        ComboBox4.SelectedItem = Nothing
    End Sub

    Sub FillGrid_Filliere(ByVal command As MySqlCommand)
        'afficher les filliere / etudiant et leur note
        ComboBox1.DataSource = fili.getallForFiliere(command)
        ComboBox1.DisplayMember = "Nom"
        ComboBox1.ValueMember = "Id"
        ComboBox1.SelectedItem = Nothing
    End Sub


    Private Sub Affiche_note_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'liste de filliers
        Dim comman As New MySqlCommand("SELECT * FROM `filliere`")
        FillGrid_Filliere(comman)

        rs.FindAllControls(Me) ' Pour Redimensionner

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        'Afficher info de l'etudiant sélectionner 
        Try
            Dim id As Integer = Convert.ToInt32(ComboBox3.SelectedValue)
            Dim table As New DataTable
            table = etu.getAllEtudiantParId(id)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        'Afficher info de la matiere sélectionner 
        Try

            Dim id As Integer = Convert.ToInt32(ComboBox4.SelectedValue)
            Dim table As New DataTable
            table = mat.getAllMatiereParId(id)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Afficher info de la filliere sélectionner 
        Try
            Dim id As Integer = Convert.ToInt32(ComboBox1.SelectedValue)
            Dim table As New DataTable
            table = fili.getAllFilliereParId(id)

            'liste de etudiant
            Dim commm As New MySqlCommand("SELECT * FROM `etudiant` WHERE CONCAT(Filliere) LIKE '%" & ComboBox1.SelectedValue & "%'")
            FillGrid_Etu(commm)

            'liste de matiere                
            Dim com As New MySqlCommand("SELECT * FROM `matiere` WHERE CONCAT(Filliere) LIKE '%" & ComboBox1.SelectedValue & "%'")
            FillGrid_Matiere(com)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HTtextbox2_TextChanged(sender As Object, e As EventArgs) Handles HTtextbox2.TextChanged
        Dim command As New MySqlCommand("SELECT etudiant.Nom, etudiant.Prenoms, filliere.Nom as Filliere, matiere.Nom as Matiere, notes.NoteDevoir, notes.NotePartiel, notes.Moyenne, notes.Observation 
                                         FROM notes
                                         INNER JOIN etudiant ON notes.Matricul_Etudiant = etudiant.Matricul
                                         INNER JOIN matiere ON notes.Id_Matiere = matiere.Id
                                         INNER JOIN filliere ON matiere.Filliere = filliere.Id
                                         WHERE CONCAT(etudiant.Matricul) LIKE '%" & HTtextbox2.Text & "%'
                                         OR CONCAT(etudiant.Nom) LIKE '%" & HTtextbox2.Text & "%'
                                         OR CONCAT(etudiant.Prenoms) LIKE '%" & HTtextbox2.Text & "%'
                                         OR CONCAT(filliere.Nom) LIKE '%" & HTtextbox2.Text & "%'")
        DataGrid_Etu(command)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("SELECT etudiant.Nom, etudiant.Prenoms, filliere.Nom as Filliere, matiere.Nom as Matiere, notes.NoteDevoir, notes.NotePartiel, notes.Moyenne, notes.Observation 
                                         FROM notes
                                         INNER JOIN etudiant ON notes.Matricul_Etudiant = etudiant.Matricul
                                         INNER JOIN matiere ON notes.Id_Matiere = matiere.Id
                                         INNER JOIN filliere ON matiere.Filliere = filliere.Id
                                         WHERE CONCAT(etudiant.Matricul) LIKE '%" & ComboBox3.SelectedValue & "%'
                                         AND CONCAT(matiere.Id) LIKE '%" & ComboBox4.SelectedValue & "%'
                                         AND CONCAT(filliere.Id) LIKE '%" & ComboBox1.SelectedValue & "%'")
        DataGrid_Etu(command)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'rafraichire
        ComboBox1.SelectedItem = Nothing
        ComboBox3.SelectedItem = Nothing
        ComboBox4.SelectedItem = Nothing
    End Sub

    Private Sub Affiche_note_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)  ' Pour Redimensionner
    End Sub


    '*****************************************CONCEPTION DU RELEVER**********************************************************

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 400
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'alignement des polices
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center


        Dim line As String
        line = "--------------------------------------------------------------------------"

        'allant du haut 
        e.Graphics.DrawString("HIGH SCHOOL", f14, Brushes.DarkSlateBlue, centermargin, 5, center)
        e.Graphics.DrawString("Relevé de Notes", f10, Brushes.DarkSlateBlue, centermargin, 25, center)
        ' e.Graphics.DrawString("Tel +228 70042709", f10, Brushes.DarkSlateBlue, centermargin, 40, center)

        '****************************************************************************************

        e.Graphics.DrawString("Matricul ", f8, Brushes.DarkSlateBlue, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 40, 60)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(0).Value.ToString, f8, Brushes.Black, 50, 60)

        e.Graphics.DrawString("Nom ", f8, Brushes.DarkSlateBlue, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 25, 75)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(1).Value.ToString, f8, Brushes.Black, 30, 75)

        e.Graphics.DrawString("Prenom", f8, Brushes.DarkSlateBlue, 100, 75)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 140, 75)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(2).Value.ToString, f8, Brushes.Black, 150, 75)

        e.Graphics.DrawString("Date de Naissance", f8, Brushes.DarkSlateBlue, 0, 90)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 85, 90)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(3).Value.ToString, f8, Brushes.Black, 100, 90)

        e.Graphics.DrawString("Sexe ", f8, Brushes.DarkSlateBlue, 0, 105)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 25, 105)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(4).Value.ToString, f8, Brushes.Black, 30, 105)

        e.Graphics.DrawString("Fillière ", f8, Brushes.DarkSlateBlue, 100, 105)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 140, 105)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(7).Value.ToString, f8, Brushes.Black, 150, 105)

        e.Graphics.DrawString("Téléphone ", f8, Brushes.DarkSlateBlue, 0, 120)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 50, 120)
        e.Graphics.DrawString(DataGridView2.CurrentRow.Cells(5).Value.ToString, f8, Brushes.Black, 100, 120)

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 135)

        e.Graphics.DrawString("Matières ", f8, Brushes.DarkSlateBlue, 0, 145)
        e.Graphics.DrawString("Devoir", f8, Brushes.DarkSlateBlue, 60, 145)
        e.Graphics.DrawString("Partiel", f8, Brushes.DarkSlateBlue, 105, 145)
        e.Graphics.DrawString("Moyenne", f8, Brushes.DarkSlateBlue, 140, 145)
        e.Graphics.DrawString("Observation", f8, Brushes.DarkSlateBlue, 190, 145)

        'Photo
        Dim tof As Byte()
        tof = DataGridView2.CurrentRow.Cells(6).Value
        Dim photo As New MemoryStream(tof)
        e.Graphics.DrawImage(Image.FromStream(photo), CInt((e.PageBounds.Width - 50) / 1), 60, 50, 50)

        '************************************************************************************

        'e.Graphics.DrawString("08/17/2021 | 15.34", f8, Brushes.Black, 0, 90)

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 150)

        Dim height As Integer 'DGV Position
        DataGridView2.AllowUserToAddRows = False

        For row As Integer = 0 To DataGridView2.RowCount - 1
            height += 35
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(8).Value.ToString, f10, Brushes.Black, 0, 130 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(9).Value.ToString, f10, Brushes.Black, 70, 130 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(10).Value.ToString, f10, Brushes.Black, 120, 130 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(11).Value.ToString, f10, Brushes.Black, 170, 130 + height)

            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(12).Value.ToString, f10, Brushes.Black, rightmargin, 130 + height, right)
        Next


        Dim height2 As Integer
        height2 = 165 + height

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, height2)

        e.Graphics.DrawString("~ Cultivons l'excellence ~", f10, Brushes.DarkSlateBlue, centermargin, 20 + height2, center)
        e.Graphics.DrawString("~ HIGH SCHOOL ~", f10, Brushes.DarkSlateBlue, centermargin, 40 + height2, center)


        'QRCode gauche
        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Try
            Dim qrcodeimage As Image
            qrcodeimage = New Bitmap(qrcode.Encode(ComboBox3.SelectedValue))
            e.Graphics.DrawImage(qrcodeimage, CInt((e.PageBounds.Width - 60) / 5), 50 + height2, 20, 20)
            e.Graphics.DrawImage(qrcodeimage, CInt((e.PageBounds.Width - 60) / 1), 50 + height2, 20, 20)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub DataGrid_RELEVE(ByVal command As MySqlCommand)
        'afficher les etudiant et leur note
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.DataSource = etu.getAllstudent(command)
        DataGridView2.ReadOnly = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'POUR LE RELEVE
        If ComboBox3.Text = "" Then
            MsgBox("Selectionner un Matricul etudiant !!", MsgBoxStyle.Exclamation, "!!!")
        Else
            Dim comm As New MySqlCommand("SELECT etudiant.Matricul, etudiant.Nom, etudiant.Prenoms, etudiant.DateNaissace, etudiant.Sexe, etudiant.Telephone, etudiant.Photo, filliere.Nom as Filliere, matiere.Nom as Matiere, notes.NoteDevoir, notes.NotePartiel, notes.Moyenne, notes.Observation 
                                      FROM notes
                                      INNER JOIN etudiant ON notes.Matricul_Etudiant = etudiant.Matricul
                                      INNER JOIN matiere ON notes.Id_Matiere = matiere.Id
                                      INNER JOIN filliere ON matiere.Filliere = filliere.Id
                                      WHERE  CONCAT(etudiant.Matricul) LIKE '%" & ComboBox3.SelectedValue & "%'")

            DataGrid_RELEVE(comm)

            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
            'PD.Print()  'Direct Print
        End If
    End Sub

End Class