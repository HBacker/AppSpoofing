Public Class Form1

    Sub arg()
        Dim x = New ProcessStartInfo("chrome.exe")
        x.Arguments = "-incognito"
        Process.Start(x)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Close()
        arg()
    End Sub
End Class


