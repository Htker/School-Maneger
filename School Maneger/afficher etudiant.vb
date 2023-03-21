Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Printing   'POUR LE RELEVE
Public Class afficher_etudiant
    Dim etu As New ETUDIANTS

    Sub FillGrid(ByVal command As MySqlCommand)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = etu.getAllstudent(command)

        ' Adapter l'image au cellule du DataGridView
        Dim colonPhoto As New DataGridViewImageColumn
        colonPhoto = DataGridView1.Columns(7)
        colonPhoto.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 80
    End Sub

    Private Sub afficher_etudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'afficher les etudiat
        Dim command As New MySqlCommand("SELECT * FROM `etudiant`")
        FillGrid(command)
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles Textbox1.TextChanged
        Dim command As New MySqlCommand("SELECT * FROM `etudiant` WHERE CONCAT(`Matricul`,`Nom`,`Prenoms`) LIKE '%" & Textbox1.Text & "%'")

        FillGrid(command)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim command As New MySqlCommand("SELECT * FROM `etudiant` WHERE CONCAT(`Matricul`,`Nom`,`Prenoms`) LIKE '%" & Textbox1.Text & "%'")

        FillGrid(command)
    End Sub

    Private currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)
        'Open form seulement'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
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
    Private Sub DataGridView1_DoubleClick_1(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim gest As New Gestion_des_Etudiant
        gest.Label7.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        gest.Textbox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        gest.HTtextbox1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString

        If DataGridView1.CurrentRow.Cells(3).Value.ToString = "Féminin" Then
            gest.xx.Checked = True
        End If


        gest.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
        gest.ComboBox1.SelectedValue = DataGridView1.CurrentRow.Cells(5).Value.ToString
        gest.HTtextbox2.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

        Dim tof As Byte()
        tof = DataGridView1.CurrentRow.Cells(7).Value
        Dim photo As New MemoryStream(tof)
        gest.PictureBox1.Image = Image.FromStream(photo)

        OpenChildForm(gest)
    End Sub

    '*****************************************CONCEPTION DU FICHE D'ISCRIPTION**********************************************************

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 300
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
        e.Graphics.DrawString("Fiche d'Inscription", f10, Brushes.DarkSlateBlue, centermargin, 35, center)

        '****************************************************************************************
        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 45)

        'Photo
        Dim tof As Byte()
        tof = DataGridView1.CurrentRow.Cells(7).Value
        Dim photo As New MemoryStream(tof)
        e.Graphics.DrawImage(Image.FromStream(photo), CInt((e.PageBounds.Width - 50) / 3), 60, 100, 100)

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 152)

        e.Graphics.DrawString("Matricul", f8, Brushes.DarkSlateBlue, 15, 170)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 100, 170)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(0).Value.ToString, f10, Brushes.Black, 110, 170)

        e.Graphics.DrawString("Nom et Prenoms", f8, Brushes.DarkSlateBlue, 15, 185)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 100, 185)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(1).Value.ToString & " " & DataGridView1.CurrentRow.Cells(2).Value.ToString, f10, Brushes.Black, 110, 185)

        e.Graphics.DrawString("Date de Naissance", f8, Brushes.DarkSlateBlue, 15, 200)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 100, 200)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(4).Value.ToString, f8, Brushes.Black, 110, 200)

        e.Graphics.DrawString("Téléphone", f8, Brushes.DarkSlateBlue, 15, 215)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 100, 215)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(6).Value.ToString, f8, Brushes.Black, 110, 215)

        e.Graphics.DrawString("Sexe ", f8, Brushes.DarkSlateBlue, 15, 230)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 40, 230)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(3).Value.ToString, f8, Brushes.Black, 50, 230)

        e.Graphics.DrawString("Fillière", f8, Brushes.DarkSlateBlue, 100, 230)
        e.Graphics.DrawString(":", f8, Brushes.DarkSlateBlue, 140, 230)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(5).Value.ToString, f8, Brushes.Black, 150, 230)

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 245)

        '************************************************************************************

        e.Graphics.DrawString("A Lomé le " & Date.Today, f8, Brushes.Black, 110, 260)

        Dim height2 As Integer

        height2 = 270

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, height2)

        e.Graphics.DrawString("~ Cultivons l'excellence ~", f10, Brushes.DarkSlateBlue, centermargin, 20 + height2, center)
        e.Graphics.DrawString("~ HIGH SCHOOL ~", f10b, Brushes.DarkSlateBlue, centermargin, 40 + height2, center)


        'qrcode 
        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Try
            Dim qrcodeimage As Image
            qrcodeimage = New Bitmap(qrcode.Encode(DataGridView1.CurrentRow.Cells(0).Value.ToString))
            e.Graphics.DrawImage(qrcodeimage, CInt((e.PageBounds.Width - 60) / 5), 50 + height2, 20, 20)
            e.Graphics.DrawImage(qrcodeimage, CInt((e.PageBounds.Width - 60) / 1), 50 + height2, 20, 20)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
End Class