Public Class RevFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            Dim s1, s2 As String
            s1 = TextBox1.Text
            s2 = TextBox2.Text
            If s1 = StrReverse(s2) Then
                Label1.Text = "Так"
            Else
                Label1.Text = "Ні"
            End If

        End If
    End Sub

    Private Sub RevFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub RevFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleRev.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub
End Class