Public Class MainMenu
    Dim c, b As Byte
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        c += 1
        If c Mod 2 <> 0 Then
            P1.Visible = True
            Label4.Top = 319
            If b Mod 2 <> 0 Then
                P2.Top = 356
            End If
        Else
            If b Mod 2 <> 0 Then
                P2.Top = 181
            End If
            P1.Visible = False
            Label4.Top = 125
        End If
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        b += 1
        If b Mod 2 <> 0 Then
            If c Mod 2 <> 0 Then
                P2.Visible = True
                P2.Top = 356
            Else
                P2.Visible = True
                P2.Top = 181
            End If
        Else
            If c Mod 2 <> 0 Then
                P2.Top = 356
                P2.Visible = False
            Else
                P2.Visible = False
                P2.Top = 181
            End If
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        AllocationFrm.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        ChangeFrm.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Search.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Task1Frm.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Task2Frm.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        StartFrm.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Zadachi.Show()
        Me.Hide()
    End Sub
End Class