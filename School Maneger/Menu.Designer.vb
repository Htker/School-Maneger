<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Panelfooter = New System.Windows.Forms.Panel()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.LabelPcNom = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.ButtonSeting = New System.Windows.Forms.Button()
        Me.ButtonMarket = New System.Windows.Forms.Button()
        Me.ButtonClient = New System.Windows.Forms.Button()
        Me.ButtonProduit = New System.Windows.Forms.Button()
        Me.ButtonCommand = New System.Windows.Forms.Button()
        Me.ButtonTableDeBord = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImageHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.IconCurrentForm = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBoxHorloge = New System.Windows.Forms.PictureBox()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerHorloge = New System.Windows.Forms.Timer(Me.components)
        Me.Panelfooter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBoxHorloge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelfooter
        '
        Me.Panelfooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panelfooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelfooter.Controls.Add(Me.LabelUser)
        Me.Panelfooter.Controls.Add(Me.LabelPcNom)
        Me.Panelfooter.Controls.Add(Me.LabelDate)
        Me.Panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelfooter.Location = New System.Drawing.Point(0, 549)
        Me.Panelfooter.Name = "Panelfooter"
        Me.Panelfooter.Size = New System.Drawing.Size(994, 30)
        Me.Panelfooter.TabIndex = 1
        '
        'LabelUser
        '
        Me.LabelUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUser.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LabelUser.Location = New System.Drawing.Point(257, 0)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(478, 28)
        Me.LabelUser.TabIndex = 4
        Me.LabelUser.Text = "Usernam"
        Me.LabelUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelPcNom
        '
        Me.LabelPcNom.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelPcNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPcNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LabelPcNom.Location = New System.Drawing.Point(0, 0)
        Me.LabelPcNom.Name = "LabelPcNom"
        Me.LabelPcNom.Size = New System.Drawing.Size(257, 28)
        Me.LabelPcNom.TabIndex = 3
        Me.LabelPcNom.Text = "NomMachine"
        Me.LabelPcNom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelDate
        '
        Me.LabelDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LabelDate.Location = New System.Drawing.Point(735, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(257, 28)
        Me.LabelDate.TabIndex = 2
        Me.LabelDate.Text = "Date"
        Me.LabelDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(774, 478)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(57, 27)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(45, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'ButtonSeting
        '
        Me.ButtonSeting.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonSeting.FlatAppearance.BorderSize = 0
        Me.ButtonSeting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonSeting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ButtonSeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSeting.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSeting.ForeColor = System.Drawing.Color.White
        Me.ButtonSeting.Image = CType(resources.GetObject("ButtonSeting.Image"), System.Drawing.Image)
        Me.ButtonSeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSeting.Location = New System.Drawing.Point(0, 440)
        Me.ButtonSeting.Name = "ButtonSeting"
        Me.ButtonSeting.Size = New System.Drawing.Size(220, 60)
        Me.ButtonSeting.TabIndex = 7
        Me.ButtonSeting.Text = "              Note"
        Me.ButtonSeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSeting.UseVisualStyleBackColor = True
        '
        'ButtonMarket
        '
        Me.ButtonMarket.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMarket.FlatAppearance.BorderSize = 0
        Me.ButtonMarket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonMarket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ButtonMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMarket.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonMarket.ForeColor = System.Drawing.Color.White
        Me.ButtonMarket.Image = Global.School_Maneger.My.Resources.Resources.magazine_26px1
        Me.ButtonMarket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMarket.Location = New System.Drawing.Point(0, 380)
        Me.ButtonMarket.Name = "ButtonMarket"
        Me.ButtonMarket.Size = New System.Drawing.Size(220, 60)
        Me.ButtonMarket.TabIndex = 6
        Me.ButtonMarket.Text = "              Matières"
        Me.ButtonMarket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMarket.UseVisualStyleBackColor = True
        '
        'ButtonClient
        '
        Me.ButtonClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonClient.FlatAppearance.BorderSize = 0
        Me.ButtonClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ButtonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClient.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonClient.ForeColor = System.Drawing.Color.White
        Me.ButtonClient.Image = Global.School_Maneger.My.Resources.Resources.journey_24px
        Me.ButtonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClient.Location = New System.Drawing.Point(0, 320)
        Me.ButtonClient.Name = "ButtonClient"
        Me.ButtonClient.Size = New System.Drawing.Size(220, 60)
        Me.ButtonClient.TabIndex = 5
        Me.ButtonClient.Text = "              Fillieres"
        Me.ButtonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClient.UseVisualStyleBackColor = True
        '
        'ButtonProduit
        '
        Me.ButtonProduit.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonProduit.FlatAppearance.BorderSize = 0
        Me.ButtonProduit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonProduit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ButtonProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProduit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonProduit.ForeColor = System.Drawing.Color.White
        Me.ButtonProduit.Image = Global.School_Maneger.My.Resources.Resources.student_male_26px
        Me.ButtonProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProduit.Location = New System.Drawing.Point(0, 260)
        Me.ButtonProduit.Name = "ButtonProduit"
        Me.ButtonProduit.Size = New System.Drawing.Size(220, 60)
        Me.ButtonProduit.TabIndex = 4
        Me.ButtonProduit.Text = "              Afficher Etudiants"
        Me.ButtonProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProduit.UseVisualStyleBackColor = True
        '
        'ButtonCommand
        '
        Me.ButtonCommand.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonCommand.FlatAppearance.BorderSize = 0
        Me.ButtonCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ButtonCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCommand.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCommand.ForeColor = System.Drawing.Color.White
        Me.ButtonCommand.Image = Global.School_Maneger.My.Resources.Resources.identification_documents_32px
        Me.ButtonCommand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCommand.Location = New System.Drawing.Point(0, 200)
        Me.ButtonCommand.Name = "ButtonCommand"
        Me.ButtonCommand.Size = New System.Drawing.Size(220, 60)
        Me.ButtonCommand.TabIndex = 3
        Me.ButtonCommand.Text = "              Gestion Etudiants"
        Me.ButtonCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCommand.UseVisualStyleBackColor = True
        '
        'ButtonTableDeBord
        '
        Me.ButtonTableDeBord.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonTableDeBord.FlatAppearance.BorderSize = 0
        Me.ButtonTableDeBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ButtonTableDeBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ButtonTableDeBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTableDeBord.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTableDeBord.ForeColor = System.Drawing.Color.White
        Me.ButtonTableDeBord.Image = Global.School_Maneger.My.Resources.Resources.preschool_24px
        Me.ButtonTableDeBord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTableDeBord.Location = New System.Drawing.Point(0, 140)
        Me.ButtonTableDeBord.Name = "ButtonTableDeBord"
        Me.ButtonTableDeBord.Size = New System.Drawing.Size(220, 60)
        Me.ButtonTableDeBord.TabIndex = 2
        Me.ButtonTableDeBord.Text = "              Affichage de note"
        Me.ButtonTableDeBord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTableDeBord.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.School_Maneger.My.Resources.Resources.maximize_window_16px1
        Me.btnMaximize.Location = New System.Drawing.Point(702, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(33, 30)
        Me.btnMaximize.TabIndex = 4
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.School_Maneger.My.Resources.Resources.minimize_window_16px
        Me.btnMinimize.Location = New System.Drawing.Point(663, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 30)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.School_Maneger.My.Resources.Resources.shutdown_24px
        Me.btnExit.Location = New System.Drawing.Point(741, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 1
        '
        'ImageHome
        '
        Me.ImageHome.Location = New System.Drawing.Point(12, 12)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(189, 112)
        Me.ImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageHome.TabIndex = 0
        Me.ImageHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.PictureBox2)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(774, 71)
        Me.PanelTitleBar.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.School_Maneger.My.Resources.Resources.classroom_24px
        Me.PictureBox2.Location = New System.Drawing.Point(6, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.Image = Global.School_Maneger.My.Resources.Resources.classroom_24px
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 15)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(45, 39)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.ButtonSeting)
        Me.PanelMenu.Controls.Add(Me.ButtonMarket)
        Me.PanelMenu.Controls.Add(Me.ButtonClient)
        Me.PanelMenu.Controls.Add(Me.ButtonProduit)
        Me.PanelMenu.Controls.Add(Me.ButtonCommand)
        Me.PanelMenu.Controls.Add(Me.ButtonTableDeBord)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 549)
        Me.PanelMenu.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aide"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.MonthCalendar1)
        Me.PanelDesktop.Controls.Add(Me.PictureBoxHorloge)
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 71)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(774, 478)
        Me.PanelDesktop.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.MonthCalendar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.White
        Me.MonthCalendar1.Location = New System.Drawing.Point(250, 107)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        '
        'PictureBoxHorloge
        '
        Me.PictureBoxHorloge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxHorloge.Location = New System.Drawing.Point(611, 321)
        Me.PictureBoxHorloge.Name = "PictureBoxHorloge"
        Me.PictureBoxHorloge.Size = New System.Drawing.Size(160, 154)
        Me.PictureBoxHorloge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHorloge.TabIndex = 2
        Me.PictureBoxHorloge.TabStop = False
        '
        'TimerDate
        '
        Me.TimerDate.Enabled = True
        '
        'TimerHorloge
        '
        Me.TimerHorloge.Enabled = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 579)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panelfooter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panelfooter.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBoxHorloge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelfooter As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents ButtonSeting As Button
    Friend WithEvents ButtonMarket As Button
    Friend WithEvents ButtonClient As Button
    Friend WithEvents ButtonProduit As Button
    Friend WithEvents ButtonCommand As Button
    Friend WithEvents ButtonTableDeBord As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImageHome As PictureBox
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconCurrentForm As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents TimerDate As Timer
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelPcNom As Label
    Friend WithEvents TimerHorloge As Timer
    Friend WithEvents PictureBoxHorloge As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button1 As Button
End Class
