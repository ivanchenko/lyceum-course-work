Public Class RemoveFrm
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleRemove.rtf")
            Label2.Text = "Видалити у рядку k-ий символ."
            Label3.Visible = True
            TextBox1.Visible = True
            Label5.Text = ""
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleRemove1.rtf")
            Label2.Text = "Видалити в рядку середній символ, якщо він складається з непарної кількості символів, або два середніх символи, якщо - з парного."
            Label3.Visible = False
            TextBox1.Visible = False
            TextBox1.Text = "1"
            Label5.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")

        Else
            If Val(TextBox2.Text) <= 0 Then
                MsgBox("Невірне значення К", 0, "Помилка вводу")
            Else
                If RB1.Checked = True Then
                    Dim k, s As String
                    s = TextBox2.Text

                    k = Val(TextBox1.Text)
                    s = s.Remove(k - 1, 1)
                    Label5.Text = s
                ElseIf RB2.Checked = True Then
                    Dim s As String
                    Dim l As Integer
                    s = TextBox2.Text
                    l = s.Length
                    If l Mod 2 = 0 Then
                        s = s.Remove(l / 2 - 1, 2)

                    Else
                        s = s.Remove((l - 1) / 2, 1)
                    End If
                    Label5.Text = s
                End If
            End If
        End If
    End Sub

    Private Sub RemoveFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub RemoveFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If RB1.Checked = True Then
            RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleRemove.rtf")
            Label2.Text = "Видалити у рядку k-ий символ."
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub
End Class