Public Class Task1Frm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LCase(Trim(TB1.Text)) <> "instrrev" Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If

        If LCase(Trim(TB2.Text)) <> "mid" Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If

        If LCase(Trim(TB3.Text)) <> "string" Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If

        If LCase(Trim(TB4.Text)) <> "replace" Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If

        If LCase(Trim(TB5.Text)) <> "replace" Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If
        If PictureBox4.Visible = False And PictureBox3.Visible = False And PictureBox2.Visible = False And PictureBox1.Visible = False And PictureBox5.Visible = False Then
            Button2.Visible = True
        Else
            Button2.Visible = False

        End If
    End Sub

    Private Sub Task1Frm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub TaskFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\task.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Task11.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class