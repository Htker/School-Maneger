<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aide))
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.HTtextbox1 = New School_Maneger.HTtextbox()
        Me.HTtextbox2 = New School_Maneger.HTtextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(155, 454)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(141, 21)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "© Tout droit reservé"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Version 3.2 2022"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(585, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contact : +228 70 04 27 09" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(400, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Auteur : Htker Robert" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(205, 40)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "&<<"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'HTtextbox1
        '
        Me.HTtextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.HTtextbox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HTtextbox1.ForeColor = System.Drawing.Color.White
        Me.HTtextbox1.Location = New System.Drawing.Point(223, 12)
        Me.HTtextbox1.Multiline = True
        Me.HTtextbox1.Name = "HTtextbox1"
        Me.HTtextbox1.ReadOnly = True
        Me.HTtextbox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HTtextbox1.Size = New System.Drawing.Size(539, 430)
        Me.HTtextbox1.TabIndex = 29
        Me.HTtextbox1.Text = resources.GetString("HTtextbox1.Text")
        Me.HTtextbox1.Visible = False
        Me.HTtextbox1.WaterMarkColor = System.Drawing.Color.Gray
        Me.HTtextbox1.WaterMarkText = "Water Mark"
        '
        'HTtextbox2
        '
        Me.HTtextbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.HTtextbox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HTtextbox2.ForeColor = System.Drawing.Color.White
        Me.HTtextbox2.Location = New System.Drawing.Point(223, 12)
        Me.HTtextbox2.Multiline = True
        Me.HTtextbox2.Name = "HTtextbox2"
        Me.HTtextbox2.ReadOnly = True
        Me.HTtextbox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HTtextbox2.Size = New System.Drawing.Size(539, 430)
        Me.HTtextbox2.TabIndex = 30
        Me.HTtextbox2.WaterMarkColor = System.Drawing.Color.Gray
        Me.HTtextbox2.WaterMarkText = "Aide"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(524, 438)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Aide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 478)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.HTtextbox1)
        Me.Controls.Add(Me.HTtextbox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Aide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aide"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents HTtextbox1 As HTtextbox
    Friend WithEvents HTtextbox2 As HTtextbox
    Friend WithEvents PictureBox1 As PictureBox
End Class
