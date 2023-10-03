Public Class Form1
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            WebBrowser1.ScriptErrorsSuppressed = True
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate("https://google.com/search?q=" & TextBox1.Text)
    End Sub

    Private Sub AboutLiteIEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutLiteIEToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.ScriptErrorsSuppressed = True
        Dim currentUrl As String = WebBrowser1.Url.ToString()
        TextBox1.Text = currentUrl
        My.Forms.Form1.Text = WebBrowser1.DocumentTitle + " - liteIE"
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles BtnForward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        WebBrowser1.Refresh()
    End Sub
End Class
