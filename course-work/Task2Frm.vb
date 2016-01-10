Public Class Task2Frm

    Private Sub Task2Frm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Task2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\Task2.rtf")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LCase(Trim(TextBox1.Text)) <> "replace" Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If

        If LCase(Trim(TextBox2.Text)) <> "split" Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If

        If LCase(Trim(TextBox3.Text)) <> "mid" Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If

        If LCase(Trim(TextBox4.Text)) <> "string" Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If
        If PictureBox1.Visible = False And PictureBox2.Visible = False And PictureBox3.Visible = False And PictureBox4.Visible = False Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If
        If PictureBox4.Visible = False And PictureBox3.Visible = False And PictureBox2.Visible = False And PictureBox1.Visible = False Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Task12.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class