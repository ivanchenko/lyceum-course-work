Public Class TrimFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")

        Else
            If RB1.Checked = True Then
                Dim s, s1 As String
                s = TextBox1.Text
                s1 = TextBox2.Text
                s = Trim(s)
                s1 = Trim(s1)
                If s = s1 Then
                    Label1.Text = "Однакові"
                Else
                    Label1.Text = "Різні"
                End If
            ElseIf RB2.Checked = True Then
                Dim s As String
                s = TextBox1.Text
                s = Trim(s)
                Label1.Text = s
            End If
        End If
    End Sub

    Private Sub RB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleTrim.rtf")
            Label7.Text = "Рядок №1"
            Label3.Visible = True
            TextBox2.Visible = True
            TextBox2.Text = " "
            Label1.Text = ""
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleTrim1.rtf")
            Label7.Text = "Рядок"
            Label3.Visible = False
            TextBox2.Visible = False
            TextBox2.Text = " "
            Label1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        ChangeFrm.Show()
    End Sub

    Private Sub TrimFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class