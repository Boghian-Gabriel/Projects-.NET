Public Class Chose
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl1.ForeColor = Color.White
    End Sub

    Private Sub Button1_ForeColorChanged(sender As Object, e As EventArgs) Handles Button1.ForeColorChanged
        Button1.ForeColor = Color.Black
    End Sub
End Class
