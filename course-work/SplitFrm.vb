Public Class SplitFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Введіть текст у поле", 0, "Помилка вводу")
        Else
            ListBox1.Items.Clear()
            Dim s, Arr() As String
            Dim c() As Char = {" ", ","}
            s = TextBox1.Text
            Arr = s.Split(c, 5)
            For i = 0 To Arr.Length - 1
                ListBox1.Items.Add(Arr(i))
            Next
        End If
    End Sub

    Private Sub SplitFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub SplitFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(Application.StartupPath & "/Example/ExampleSplit.rtf")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AllocationFrm.Show()
    End Sub
End Class