Public Class MidFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            Dim k, l As Double
            Dim s, s1, s2 As String
            s = TextBox1.Text
            l = Val(TextBox2.Text)
            k = Val(TextBox3.Text)
            s1 = Mid(s, 1, l - 1)
            s2 = Mid(s, k + 1)
            s = s1 & s2
            Label1.Text = s
        End If
    End Sub

    Private Sub MidFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub MidFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\ExampleMid.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AllocationFrm.Show()
    End Sub
End Class