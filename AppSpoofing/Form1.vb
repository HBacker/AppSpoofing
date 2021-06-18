Public Class Form1

    Sub arg()
        Dim location As String = System.Environment.GetCommandLineArgs()(0)
        Dim appName As String = System.IO.Path.GetFileName(location)
        Dim app_path = AppDomain.CurrentDomain.BaseDirectory + appName.ToString
        Dim x = New ProcessStartInfo(app_path + "chrome_origin.exe")
        x.Arguments = "-incognito"
        Try
            Process.Start(x)
        Catch ex As Exception
            Console.WriteLine("Dosya Bulunamadı.")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Close()
        arg()
    End Sub
End Class


