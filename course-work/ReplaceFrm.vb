Public Class ReplaceFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            If RB1.Checked = True Then
                Dim s, s1 As String
                s = TextBox1.Text
                s1 = TextBox2.Text
                s = s.Replace(s1, "")
                Label1.Text = s
            ElseIf RB2.Checked = True Then
                Label1.Text = ""
                Dim s As String
                s = TextBox1.Text
                s = s.Replace(",", ", ")
                Label1.Text = s
            End If
        End If
    End Sub

    Private Sub RB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            Zadacha.Text = "Видалити в рядку всі зазначені поєднання символів."
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleReplace.rtf")
            TextBox2.Text = ""
            Label3.Visible = True
            TextBox2.Visible = True
            Label5.Top = 220
            Label1.Top = 220
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            Zadacha.Text = "Після всіх ком в рядку додати пробіли."
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleReplace1.rtf")
            TextBox2.Text = "1"
            Label3.Visible = False
            TextBox2.Visible = False
            Label5.Top = 180
            Label1.Top = 180
        End If
    End Sub

    Private Sub ReplaceFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub ReplaceFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleReplace.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub
End Class