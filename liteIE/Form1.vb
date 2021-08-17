Public Class Form1
    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("http://www.google.com/search?q=" & TextBox1.Text)
    End Sub
End Class
