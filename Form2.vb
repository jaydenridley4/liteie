Public Class Form2
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.WebBrowser1.Navigate("https://github.com/jaydenridley4/liteIE")
        ActiveForm.Hide()
    End Sub
End Class