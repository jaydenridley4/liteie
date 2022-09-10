Public Class Form1
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate("https://google.com/search?q=" & TextBox1.Text)
    End Sub

    Private Sub AboutLiteIEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutLiteIEToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
