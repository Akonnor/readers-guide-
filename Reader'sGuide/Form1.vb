Public Class Form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        x.Text = e.X
        y.Text = e.Y
        Dim tween As String = Form2.txtTween.Text


        Panel1.Location = New Point(e.X, e.Y)
        Panel3.Location = New Point(e.X, e.Y + tween)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Panel1.Width = Me.Width
        Panel3.Width = Me.Width
    End Sub
End Class
