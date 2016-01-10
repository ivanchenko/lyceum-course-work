Public Class InStrFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")

        Else
            If RB1.Checked = True Then
                Label1.Text = ""
                Dim s1, s2 As String
                Dim k, n As Integer
                s1 = TextBox1.Text
                s2 = TextBox2.Text
                k = 1
                n = 0
                Do Until InStr(k, s1, s2) = 0
                    If InStr(k, s1, s2) = k Then
                        n = n + 1
                    End If
                    k = k + 1
                Loop
                Label1.Text = n
            ElseIf RB2.Checked = True Then
                Label1.Text = ""
                Dim s1, s2 As String
                s1 = TextBox1.Text
                s2 = TextBox2.Text
                If InStr(s1, s2) = 1 Then
                    Label1.Text = "Починається"
                Else
                    Label1.Text = "Не починається"
                End If
            End If
        End If
    End Sub

    Private Sub RB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            Label2.Text = "Ввести рядок і дізнатися скільки разів в ній зустрічається задана комбінація символів"
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleInstr.rtf")
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            Label2.Text = "Перевірити починається введений рядок заданими символами чи ні"
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleInstr1.rtf")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub InStrFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class