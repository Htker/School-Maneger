<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Connexion))
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Textbox2 = New School_Maneger.HTtextbox()
        Me.Textbox1 = New School_Maneger.HTtextbox()
        Me.KryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel.Controls.Add(Me.Panel1)
        Me.Panel.Controls.Add(Me.Button3)
        Me.Panel.Controls.Add(Me.Panel2)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(486, 188)
        Me.Panel.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(451, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 29)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Textbox2)
        Me.Panel2.Controls.Add(Me.Textbox1)
        Me.Panel2.Location = New System.Drawing.Point(72, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 254)
        Me.Panel2.TabIndex = 1
        '
        'Textbox2
        '
        Me.Textbox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Textbox2.ForeColor = System.Drawing.Color.Navy
        Me.Textbox2.Location = New System.Drawing.Point(69, 90)
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(205, 25)
        Me.Textbox2.TabIndex = 1
        Me.Textbox2.Text = "Admin"
        Me.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Textbox2.UseSystemPasswordChar = True
        Me.Textbox2.WaterMarkColor = System.Drawing.Color.Navy
        Me.Textbox2.WaterMarkText = "Mot de passe"
        '
        'Textbox1
        '
        Me.Textbox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Textbox1.ForeColor = System.Drawing.Color.Navy
        Me.Textbox1.Location = New System.Drawing.Point(69, 43)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(205, 25)
        Me.Textbox1.TabIndex = 0
        Me.Textbox1.Text = "Admin"
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Textbox1.WaterMarkColor = System.Drawing.Color.Navy
        Me.Textbox1.WaterMarkText = "Nom d'Utilisateur"
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(141, 194)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(155, 20)
        Me.KryptonCheckBox1.TabIndex = 0
        Me.KryptonCheckBox1.Values.Text = "Afficher le mot de passe"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(141, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Connecter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(216, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de passe oublier ??"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 320)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 323)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KryptonCheckBox1)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.Panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents Textbox2 As HTtextbox
    Friend WithEvents Textbox1 As HTtextbox
    Friend WithEvents DatagridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
End Class
