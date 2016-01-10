Public Class AllocationFrm
    Dim Pr As Byte
    Private Sub ButtonPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPr.Click
        If Pr = 1 Then
            MidFrm.Show()
            Me.Hide()
        ElseIf Pr = 2 Then
            LeftFrm.Show()
            Me.Hide()
        ElseIf Pr = 3 Then
            SubStringFrm.Show()
            Me.Hide()

        ElseIf Pr = 4 Then
            SplitFrm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WB1.Navigate(Application.StartupPath & "\site\Mid.html")
        Pr = 1
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WB1.Navigate(Application.StartupPath & "\site\Left.html")
        Pr = 2
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WB1.Navigate(Application.StartupPath & "\site\Substring.html")
        Pr = 3
        ButtonPr.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        WB1.Navigate(Application.StartupPath & "\site\split.html")
        Pr = 4
        ButtonPr.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub AllocationFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub AllocationFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WB1.Navigate(Application.StartupPath & "\site\Allocation.html")
    End Sub
End Class
