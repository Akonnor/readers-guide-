Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ColorDialog1.ShowDialog()
            txtColour.Text = ColorDialog1.Color.ToString
            Form1.Panel1.BackColor = ColorDialog1.Color
            Form1.Panel3.BackColor = ColorDialog1.Color
        Catch ex As Exception
            MsgBox("Invalid Details Check settings Details ", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TrackBar1.SetRange(0, 100)
        Dim ans As String = TrackBar1.Value / 100
        Form1.Opacity = ans
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Form1.Panel1.Height = txtGuideSize.Text
            Form1.Panel3.Height = txtGuideSize.Text
        Catch ex As Exception
            MsgBox("Invalid Details Check settings Details ", MsgBoxStyle.Exclamation)
        End Try

    End Sub
End Class