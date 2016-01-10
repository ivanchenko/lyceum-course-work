Public Class EqualsFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            Dim s, s1 As String
            s = TextBox1.Text
            s1 = TextBox2.Text
            If s.Equals(s1) = True Then
                Label1.Text = "Рядки однакові"
            Else
                Label1.Text = "Рядки різні"
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub EqualsFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class