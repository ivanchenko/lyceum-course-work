Public Class Search
    Dim pr As Byte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WB1.Navigate(Application.StartupPath & "\site\InStr.html")
        pr = 1
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WB1.Navigate(Application.StartupPath & "\site\StartWith.html")
        Pr = 2
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WB1.Navigate(Application.StartupPath & "\site\equals.html")
        pr = 3
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        WB1.Navigate(Application.StartupPath & "\site\Contain.html")
        pr = 4
        buttonPr.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WB1.Navigate(Application.StartupPath & "\site\IndexOfAny.html")
        pr = 5
        ButtonPr.Visible = True
    End Sub

    Private Sub buttonPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPr.Click
        If pr = 1 Then
            InStrFrm.Show()
        ElseIf pr = 2 Then
            StartWithFrm.Show()
        ElseIf pr = 3 Then
            EqualsFrm.Show()
        ElseIf pr = 4 Then
            ContainsFrm.Show()
        ElseIf pr = 5 Then
            IndexOfAnyFrm.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub Search_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WB1.Navigate(Application.StartupPath & "\site\Search.html")
    End Sub
End Class