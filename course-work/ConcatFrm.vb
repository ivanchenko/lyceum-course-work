Public Class ConcatFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim s1(5), s As String
        For i = 1 To 5
            s1(i) = i
        Next
        s = String.Concat(s1)
        Label1.Text = s
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub

    Private Sub ConcatFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class