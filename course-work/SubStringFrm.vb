Public Class SubStringFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")

        Else
            If RB1.Checked = True Then
                Label5.Text = ""
                Dim name, sname, n, sn As String
                name = TextBox1.Text
                sname = TextBox2.Text
                n = name.Substring(0, 1)
                sn = sname.Substring(0, 1)
                Label5.Text = n & ". " & sn & "."
            ElseIf RB2.Checked = True Then
                Label5.Text = ""
                Dim s, s1 As String
                Dim c As Integer
                s = TextBox1.Text
                s1 = TextBox2.Text
                For i = 0 To Len(s) - Len(s1)
                    If s1 = s.Substring(i, Len(s1)) Then
                        c = c + 1
                    End If
                Next
                Label5.Text = c & " разів"
            End If
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then

            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleSub1.rtf")
            Label2.Text = "Ввести один рядок та визначити скільки разів в ньому зустрічається інший підрядок"
            Label3.Text = "Рядок №1:"
            Label7.Text = "Рядок №2"
        End If
    End Sub

    Private Sub RB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged

        If RB1.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleSub.rtf")
            Label2.Text = "Ввести ім’я та по-батькові та визначити ініціали"
            Label3.Text = "Ім'я:"
            Label7.Text = "По-батькові:"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AllocationFrm.Show()
    End Sub

    Private Sub SubStringFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class