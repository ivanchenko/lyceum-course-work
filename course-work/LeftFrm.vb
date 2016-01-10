Public Class LeftFrm

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        AllocationFrm.Show()
        Me.Hide()
    End Sub
    Private Sub Rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb1.CheckedChanged
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\Exampleleft.rtf")
        Label7.Text = "Ввести рядок та поміняти у ньмоу місцями підрядки з початку до К-го символу та з кінця до I-го символу."
        Label.Top = 216
        Label1.Top = 216
        TextBox1.Visible = True
        TextBox2.Visible = True
        Label3.Visible = True
        Label2.Visible = True
        Label.Text = ""
    End Sub

    Private Sub Rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb2.CheckedChanged
        RichTextBox1.LoadFile(Application.StartupPath & "\Example\Exampleleft1.rtf")
        Label7.Text = "Визначити, чи закінчується рядок трикрапкою."
        Label.Top = 180
        Label1.Top = 180
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label3.Visible = False
        Label2.Visible = False
        Label.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Rb1.Checked = True Then
            If TextBox3.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Введіть текст у поле", 0, "Помилка вводу")
            Else
                If Val(TextBox1.Text) < 0 Or (TextBox2.Text) < 0 Then
                    MsgBox("Невірне значення параметрів", 0, "Помилка вводу")
                Else
                    Dim s, sL, sR As String
                    Dim k, i As Double
                    s = TextBox3.Text
                    k = Val(TextBox1.Text)
                    i = Val(TextBox2.Text)
                    sL = Strings.Left(s, k)
                    sR = Strings.Right(s, i)
                    s = sR & Mid(s, k + 1, s.Length - i - k) & sL
                    Label.Text = s
                    RichTextBox1.Height = 220
                End If
            End If
        ElseIf Rb2.Checked = True Then
            If TextBox3.Text = "" Then
                MsgBox("Введіть текст у поле", 0, "Помилка вводу")
            Else
                Dim s, s1 As String
                s = TextBox3.Text
                s1 = "..."
                If Strings.Right(s, 3) = s1 Then
                    Label.Text = "Закінчується"
                Else
                    Label.Text = "Не закінчується"
                End If
            End If
        End If
    End Sub

    Private Sub LeftFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub LeftFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class