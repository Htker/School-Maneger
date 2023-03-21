<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class matiere
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textbox1 = New School_Maneger.HTtextbox()
        Me.HTtextbox2 = New School_Maneger.HTtextbox()
        Me.HTtextbox1 = New School_Maneger.HTtextbox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Textbox1)
        Me.GroupBox1.Controls.Add(Me.HTtextbox2)
        Me.GroupBox1.Controls.Add(Me.HTtextbox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 227)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information sur la matière"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(462, 192)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 29)
        Me.ComboBox1.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(395, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nombre de credits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(402, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nombre d'heures"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.NumericUpDown2.Location = New System.Drawing.Point(567, 142)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 31)
        Me.NumericUpDown2.TabIndex = 23
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(567, 95)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 31)
        Me.NumericUpDown1.TabIndex = 22
        Me.NumericUpDown1.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(227, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nom du professeur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(394, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fillière"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nom Matière"
        '
        'Textbox1
        '
        Me.Textbox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Textbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Textbox1.Location = New System.Drawing.Point(16, 53)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(205, 29)
        Me.Textbox1.TabIndex = 13
        Me.Textbox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Textbox1.WaterMarkText = "Nom Matière"
        '
        'HTtextbox2
        '
        Me.HTtextbox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HTtextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.HTtextbox2.Location = New System.Drawing.Point(15, 109)
        Me.HTtextbox2.Multiline = True
        Me.HTtextbox2.Name = "HTtextbox2"
        Me.HTtextbox2.Size = New System.Drawing.Size(374, 112)
        Me.HTtextbox2.TabIndex = 15
        Me.HTtextbox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.HTtextbox2.WaterMarkText = "Description"
        '
        'HTtextbox1
        '
        Me.HTtextbox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HTtextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.HTtextbox1.Location = New System.Drawing.Point(227, 53)
        Me.HTtextbox1.Name = "HTtextbox1"
        Me.HTtextbox1.Size = New System.Drawing.Size(460, 29)
        Me.HTtextbox1.TabIndex = 14
        Me.HTtextbox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.HTtextbox1.WaterMarkText = "Nom du professeur"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(277, 273)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(205, 40)
        Me.Button8.TabIndex = 28
        Me.Button8.Text = "Modifier"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(513, 273)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(205, 40)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Supprimer"
        Me.Button7.UseVisualStyleBackColor = False
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
        Me.Button5.Location = New System.Drawing.Point(48, 273)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(205, 40)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Ajouter"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.School_Maneger.My.Resources.Resources.yellow_blue_wallpaper
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(774, 478)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 353)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(154, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(774, 125)
        Me.DataGridView1.TabIndex = 33
        '
        'matiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 478)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "matiere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matiere"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Textbox1 As HTtextbox
    Friend WithEvents HTtextbox2 As HTtextbox
    Friend WithEvents HTtextbox1 As HTtextbox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
