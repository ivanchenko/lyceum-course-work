Public Class LCaseFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            Dim s1, s2 As String
            s1 = TextBox1.Text
            s2 = TextBox2.Text
            If LCase(s1) = LCase(s2) Then
                Label1.Text = "однакові"
            Else

                Label1.Text = "різні"
            End If
        End If
    End Sub

    Private Sub LCaseFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub LCaseFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "/Example/ExampleLcase.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub
End Class