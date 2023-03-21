Imports MySql.Data.MySqlClient
Public Class Connexion
    Dim b As New CONNECTION

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim adapter As New MySqlDataAdapter
            Dim table As New DataTable
            Dim comm As New MySqlCommand("SELECT * FROM `connexion` WHERE `Usernam` = @usr AND `password` = @mdp", b.getconnection)

            comm.Parameters.Add("@usr", MySqlDbType.VarChar).Value = Textbox1.Text
            comm.Parameters.Add("@mdp", MySqlDbType.VarChar).Value = Textbox2.Text

            adapter.SelectCommand = comm
            adapter.Fill(table)
            b.openConnection()

            If table.Rows.Count > 0 Then
                Dim men As New connetion
                men.Show()
                Me.Hide()
            Else
                MsgBox("Erreur de saisi", MsgBoxStyle.Critical, "Connexion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Dim conn As New MySqlConnection
        'Dim read As MySqlDataReader
        'Dim cmd As New MySqlCommand
        'conn = New MySqlConnection
        'conn.ConnectionString = "Datasource=localhost;port=3308;username=root;password=;database=school_maneger" '"server=localhost;database=school_maneger;userid=root"
        ''Try
        'conn.Open()
        'Dim query = " Select * from connection where Usernam ='" & Textbox1.Text & "' And password = '" & Textbox2.Text & "' "
        'cmd = New MySqlCommand(query, conn)
        '    read = cmd.ExecuteReader

        '    Dim count As Integer = 0
        '    While read.Read
        '        count = count + 1
        '    End While
        '    If count = 1 Then
        '        Menu.Show()
        '        Me.Hide()
        '    Else
        '        MsgBox("Identifiants incorrects", MessageBoxIcon.Error)
        '        Textbox1.Text = ""
        '        Textbox2.Text = ""
        '    End If
        ''Catch ex As Exception
        ''    MessageBox.Show(ex.Message)
        ''End Try

    End Sub

    Private Sub KryptonCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles KryptonCheckBox1.CheckedChanged
        If Textbox2.UseSystemPasswordChar Then
            Textbox2.UseSystemPasswordChar = False
        Else
            Textbox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
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
End Class