
Imports Microsoft.Deployment.WindowsInstaller
Imports System
Imports System.Diagnostics

Namespace CustomActions
    Public Class CustomActions
        <CustomAction>
        Public Shared Function LaunchMySQLInstaller(session As Session) As ActionResult
            Try
                Dim installerPath As String = session("INSTALLDIR") & "Resources\mysql-installer-community.msi"
                Process.Start(installerPath)
            Catch ex As Exception
                ' Handle any exceptions or log the error
                Return ActionResult.FailureS
            End Try

            Return ActionResult.Success
        End Function
    End Class
End Namespace