
Imports System.ComponentModel
Imports System.Configuration
Imports System.Configuration.Install

<RunInstaller(True)>
Partial Public Class ConnectionStringProtector
    Inherits Installer

    Public Sub New()

    End Sub

    Public Overrides Sub Install(ByVal stateSaver As IDictionary)
        MyBase.Install(stateSaver)
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Context.Parameters("assemblypath"))
        Dim section As ConfigurationSection = config.GetSection("connectionStrings")

        If Not section.SectionInformation.IsProtected Then
            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
            config.Save()
        End If
    End Sub
End Class
