Imports System.Runtime.InteropServices

Public Class Menu
    'Des champs'
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructeur'
    Public Sub New()
        ' Cet appel est requis par le concepteur.'
        InitializeComponent()
        ' Ajoutez toute initialisation après l'appel InitializeComponent().'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button '
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            'currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Bordure gauche'
            currentBtn.BackColor = customColor
            currentBtn.Location = New Point(0, ButtonTableDeBord.Location.Y)
            currentBtn.Visible = True
            currentBtn.BringToFront()
            ' icon Form courante'
            IconCurrentForm.Image = currentBtn.Image
            IconCurrentForm.ForeColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.White
            'currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub ButtonTableDeBord_Click(sender As Object, e As EventArgs) Handles ButtonTableDeBord.Click
        ActivateButton(sender, RGBColor.color1)
        OpenChildForm(New Affiche_note)
    End Sub

    Private Sub ButtonCommand_Click(sender As Object, e As EventArgs) Handles ButtonCommand.Click
        ActivateButton(sender, RGBColor.color2)
        OpenChildForm(New Gestion_des_Etudiant)
    End Sub

    Private Sub ButtonProduit_Click(sender As Object, e As EventArgs) Handles ButtonProduit.Click
        ActivateButton(sender, RGBColor.color3)
        OpenChildForm(New afficher_etudiant)
    End Sub

    Private Sub ButtonClient_Click(sender As Object, e As EventArgs) Handles ButtonClient.Click
        ActivateButton(sender, RGBColor.color4)
        OpenChildForm(New filliere)
    End Sub

    Private Sub ButtonMarket_Click(sender As Object, e As EventArgs) Handles ButtonMarket.Click
        ActivateButton(sender, RGBColor.color5)
        OpenChildForm(New matiere)
    End Sub

    Private Sub ButtonSeting_Click(sender As Object, e As EventArgs) Handles ButtonSeting.Click
        ActivateButton(sender, RGBColor.color6)
        OpenChildForm(New Ajout_note)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Aide)
    End Sub

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
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.Image = PictureBox2.Image
        'IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
    End Sub
    Private Sub ImageHome_Click(sender As Object, e As EventArgs) Handles ImageHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    'Close-Maximize-Minimize'
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        OpenChildForm(New fin)
        btnExit.Enabled = False
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        LabelDate.Text = Date.Now.ToString("dd MMM yyyy  ⏱ HH:mm:ss")
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerHorloge_Tick(Nothing, Nothing)        'Pour l'horloge analogique
        TimerDate.Enabled = True 'Pour la date
        TimerDate.Start()
        LabelUser.Text = "UserName : " & Environment.UserName  'nom d'utilisateur
        LabelPcNom.Text = "MachineName : " & Environment.MachineName 'nom de la machine
    End Sub

    '************************************ Mettre une horloge analogique *****************************************

    'Déclaration des images
    Dim ImageFile As Image = My.Resources.h
    Dim ImageFile1 As Image = My.Resources.m
    Dim ImageFile2 As Image = My.Resources.s
    Dim ImageFile3 As Image = My.Resources._do

    Public TMPIMG As Bitmap = New Bitmap(600, 600)

    Public Graph As Graphics = Graphics.FromImage(TMPIMG)

    Private Sub TimerHorloge_Tick(sender As Object, e As EventArgs) Handles TimerHorloge.Tick
        Dim mc As Color
        mc = Me.BackColor
        Graph.Clear(mc)
        Graph.DrawImage(ImageFile3, 0, 0, 600, 600)

        'Pour la tige heure
        Graph.TranslateTransform(300, 300)
        Graph.RotateTransform(-90 + ((Now.Hour * 30) + (Now.Minute * 0.5)))
        Graph.DrawImage(ImageFile, -5, -13, 130, 30)
        Graph.ResetTransform()

        'Pour la tige minute
        Graph.TranslateTransform(300, 300)
        Graph.RotateTransform(-90 + (((Now.Minute * 60) + Now.Second) * 0.1))
        Graph.DrawImage(ImageFile1, -5, -13, 180, 30)
        Graph.ResetTransform()

        'Pour la tige seconde
        Graph.TranslateTransform(300, 300)
        Graph.RotateTransform(-90 + (Now.Second * 6))
        Graph.DrawImage(ImageFile2, -40, -15, 180, 25)
        Graph.ResetTransform()

        ImageHome.Image = TMPIMG
        PictureBoxHorloge.Image = TMPIMG
    End Sub

End Class