Public Class InsertFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RB1.Checked = True Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Введіть текст у поле", 0, "Помилка вводу")
            Else
                Dim s, s1 As String
                s = TextBox1.Text
                s1 = TextBox2.Text
                s = s.Insert(s.Length / 2, s1)
                Label5.Text = s
            End If
        ElseIf RB2.Checked = True Then
            Dim s As String
            s = "Рівняня"
            s = s.Insert(6, "н")
            Label5.Text = s

        End If
    End Sub

    Private Sub RB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleInsert.rtf")
            Label3.Visible = True
            Label7.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Label5.Text = ""
            Label2.Text = "Вставити у середину рядка введене поєднання символів, в рядку парна кількість символів."
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleInsert1.rtf")
            Label3.Visible = False
            Label7.Visible = False
            TextBox1.Visible = False
            Label5.Text = ""
            TextBox2.Visible = False
            Label2.Text = "У слові «рівняня» виправити помилку."
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub

    Private Sub InsertFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class