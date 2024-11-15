Imports CrystalDecisions.Shared
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports EncriptarDesencriptar

Public Class FrmRecepcionValesCredito
    Dim Parametros As New ParameterFields()
    Dim PrimerParametro As New ParameterField()
    Dim myDiscreteValue As New ParameterDiscreteValue()
    Dim codigo As New ParameterDiscreteValue()


    Private Sub FrmRecepcionValesCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Dim info As New RecepcionValeCredito


        ' CrystalReportViewer1.ReportSource = ConfigurationManager.appSettings("folderpath") +"RecepcionValeCredito.rpt"
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        Dim EncrDesencr As New EncriptacionDescencriptacion
        Dim Cadena As String = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)

        cryRpt.Load(ConfigurationManager.AppSettings("folderpath") + "RecepcionValeCredito.rpt")
        With crConnectionInfo
            .ServerName = Split(Split(Cadena, ";")(0), "=")(1)
            .DatabaseName = ConfigurationManager.AppSettings("databasename")
            .UserID = ConfigurationManager.AppSettings("userid")
            .Password = Split(Split(Cadena, ";")(3), "=")(1)
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        TxtNumClienteRVC.Text = CodigoCliente

        PrimerParametro.ParameterValueType = ParameterValueKind.NumberParameter
        PrimerParametro.ParameterFieldName = "@Num_cliente"

        myDiscreteValue.Value = Convert.ToInt32(TxtNumClienteRVC.Text)
        PrimerParametro.CurrentValues.Add(myDiscreteValue)
        Parametros.Add(PrimerParametro)
        CrystalReportViewer1.ParameterFieldInfo = Parametros
        CrystalReportViewer1.ReportSource = cryRpt

    End Sub
End Class