Public Class Task11

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox("Все вирішено вірно", 0, "Відповідь")
            Me.Hide()
            MainMenu.Show()
        Else
            MsgBox("Нажаль відповідь невірна", 0, "Відповідь")
        End If
    End Sub

    Private Sub Task11_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "/Example/11.rtf")
        RichTextBox2.LoadFile(Application.StartupPath & "/Example/12.rtf")
        RichTextBox3.LoadFile(Application.StartupPath & "/Example/13.rtf")
        RichTextBox4.LoadFile(Application.StartupPath & "/Example/14.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class