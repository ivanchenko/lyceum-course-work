Public Class IndexOfAnyFrm
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            Dim s As String
            Dim c() As Char = {"1", "2", "3", "4", "5"}
            s = TextBox1.Text
            If -1 = s.IndexOfAny(c) Then
                Label1.Text = "Ні не містить"
            Else
                Label1.Text = "Містить"
            End If
        End If
    End Sub

    Private Sub IndexOfAnyFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub IndexOfAny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleIndexOfAny.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Search.Show()
    End Sub
End Class