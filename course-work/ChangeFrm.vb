Public Class ChangeFrm
    Dim pr As Byte
    Private Sub ButtonPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPr.Click
        If pr = 1 Then
            LCaseFrm.Show()
            Me.Hide()
        ElseIf pr = 2 Then
            JoinFrm.Show()
            Me.Hide()
        ElseIf pr = 3 Then
            RevFrm.Show()
            Me.Hide()
        ElseIf pr = 4 Then
            RemoveFrm.Show()
            Me.Hide()
        ElseIf pr = 5 Then
            ReplaceFrm.Show()
            Me.Hide()
        ElseIf pr = 6 Then
            JoinFrm.Show()
            Me.Hide()
        ElseIf pr = 7 Then
            JoinFrm.Show()
            Me.Hide()
        ElseIf pr = 8 Then
            JoinFrm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WB1.Navigate(Application.StartupPath & "\site\Lcase.html")
        pr = 1
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WB1.Navigate(Application.StartupPath & "\site\Trim.html")
        pr = 2
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WB1.Navigate(Application.StartupPath & "\site\StrReverse.html")
        pr = 3
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        WB1.Navigate(Application.StartupPath & "\site\remove.html")
        pr = 4
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WB1.Navigate(Application.StartupPath & "\site\Replace.html")
        pr = 5
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        WB1.Navigate(Application.StartupPath & "\site\Join.html")
        pr = 6
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        WB1.Navigate(Application.StartupPath & "\site\Concat.html")
        pr = 7
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        WB1.Navigate(Application.StartupPath & "\site\Insert.html")
        pr = 8
        ButtonPr.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub ChangeFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub ChangeFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WB1.Navigate(Application.StartupPath & "\site\Change.html")
    End Sub
End Class