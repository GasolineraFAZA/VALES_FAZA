Imports CrystalDecisions.Shared
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports EncriptarDesencriptar

Public Class FrmRecepcionValesAnexo
    Dim Parametros As New ParameterFields()
    Dim PrimerParametro As New ParameterField()
    Dim myDiscreteValue As New ParameterDiscreteValue()
    Dim codigo As New ParameterDiscreteValue()

    Private Sub FrmRecepcionValesAnexo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim info As New RecepcionValeAnexo

        'CrystalReportViewer1.ReportSource = ConfigurationManager.appSettings("folderpath") +"RecepcionValeAnexo.rpt"
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        Dim EncrDesencr As New EncriptacionDescencriptacion

        cryRpt.Load(ConfigurationManager.AppSettings("folderpath") + "RecepcionValeAnexo.rpt")
        With crConnectionInfo
            .ServerName = Split(Split(EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString), ";")(0), "=")(1)
            .DatabaseName = ConfigurationManager.AppSettings("databasename")
            .UserID = ConfigurationManager.AppSettings("userid")
            .Password = Split(Split(EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString), ";")(3), "=")(1)
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        TxtNumClienteRVA.Text = CodigoCliente

        PrimerParametro.ParameterValueType = ParameterValueKind.NumberParameter
        PrimerParametro.ParameterFieldName = "@Num_cliente"

        myDiscreteValue.Value = Convert.ToInt32(TxtNumClienteRVA.Text)
        PrimerParametro.CurrentValues.Add(myDiscreteValue)
        Parametros.Add(PrimerParametro)
        CrystalReportViewer1.ParameterFieldInfo = Parametros
        CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.RefreshReport()
    End Sub
End Class