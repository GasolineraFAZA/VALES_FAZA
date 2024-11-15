Imports CrystalDecisions.Shared
Imports Microsoft.Reporting.WebForms
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports Spire.Barcode
Imports System.IO
Imports EncriptarDesencriptar

Public Class Valetransferencia
    Dim Parametros As New ParameterFields()
    Dim PrimerParametro As New ParameterField()
    Dim SegundoParametro As New ParameterField()
    Dim myDiscreteValue As New ParameterDiscreteValue()
    Dim myDiscreteValue2 As New ParameterDiscreteValue()
    Dim codigo As New ParameterDiscreteValue()
    Public saveFileDialog As SaveFileDialog
    Public ImprimirPDF As Boolean = False

    Public Sub ValeTransferencia(saveFileDialog As SaveFileDialog)
        Me.saveFileDialog = saveFileDialog
    End Sub

    Private Sub Valetransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim info As New PruebaValeTrans
            '.Tables(1).ConnectionProperties("Data Source") = "Server"
            'Report.Database.Tables(1).ConnectionProperties("Initial Catalog") = "Database"
            'Report.Database.Tables(1).ConnectionProperties("User ID") = "userID"
            'Report.Database.Tables(1).ConnectionProperties("Password") = "password"

            'CrystalReportViewer1.ReportSource = ConfigurationManager.appSettings("folderpath") +"ValesTransferencia.rpt"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function PrepararInfo() As ReportDocument
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        MessageBox.Show("antes encriptar")
        Dim EncrDesencr As New EncriptacionDescencriptacion
        Dim Cadena As String = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)

        cryRpt.Load(ConfigurationManager.AppSettings("folderpath") + "ValesTransferencia.rpt")
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

        TxtNumClienteVT.Text = VarIdCliente
        TxtNumIdVT.Text = VarIdValeTrans

        PrimerParametro.ParameterValueType = ParameterValueKind.NumberParameter
        PrimerParametro.ParameterFieldName = "@IdCliente"

        SegundoParametro.ParameterValueType = ParameterValueKind.NumberParameter
        SegundoParametro.ParameterFieldName = "@IdValeTrans"

        myDiscreteValue.Value = Convert.ToInt32(VarIdCliente)
        myDiscreteValue2.Value = Convert.ToInt32(VarIdValeTrans)

        PrimerParametro.CurrentValues.Add(myDiscreteValue)
        SegundoParametro.CurrentValues.Add(myDiscreteValue2)
        Parametros.Add(PrimerParametro)
        Parametros.Add(SegundoParametro)
        CrystalReportViewer1.ParameterFieldInfo = Parametros

        CrystalReportViewer1.ReportSource = cryRpt
        PrepararInfo = cryRpt

        If ImprimirPDF = True Then
            Dim dlgResult As DialogResult = saveFileDialog.ShowDialog()

            If dlgResult = DialogResult.OK Then

                cryRpt.SetParameterValue("@IdCliente", VarIdCliente.ToString)
                cryRpt.SetParameterValue("@IdValeTrans", VarIdValeTrans.ToString)

                Dim Codigo As String = cryRpt.Rows(0)(0).ToString

                GenerarCodigoBarra(Codigo, "ValeTransferencia")

                cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName)
            Else
                If dlgResult <> DialogResult.OK And dlgResult <> DialogResult.Cancel Then
                    MessageBox.Show("Necesita seleccionar la ubicación del archivo")
                End If
            End If

            End
        Else
            cryRpt.SetParameterValue("@IdCliente", VarIdCliente.ToString)
            cryRpt.SetParameterValue("@IdValeTrans", VarIdValeTrans.ToString)

            Dim Codigo As String = cryRpt.Rows(0)(0).ToString

            GenerarCodigoBarra(Codigo, "ValeTransferencia")
        End If

    End Function

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        MessageBox.Show(ConfigurationManager.AppSettings("folderpath"))
        Dim cryRpt As ReportDocument = PrepararInfo()
        'CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub GenerarCodigoBarra(Codigo As String, Archivo As String)

        Dim ImagenesPath = "C:\ImagenesVales\" & Archivo + ".bmp"
        Dim bs As BarcodeSettings = New BarcodeSettings()

        bs.Type = BarCodeType.Code128
        bs.Data = Codigo.Replace("*", "")

        Dim imagen As Bitmap = DirectCast(New BarCodeGenerator(bs).GenerateImage(), Bitmap)
        imagen = New Bitmap(imagen, New Size(350, 50))

        Using memory As New MemoryStream()
            Using fs As New FileStream(ImagenesPath, FileMode.Create, FileAccess.ReadWrite)

                imagen.Save(memory, System.Drawing.Imaging.ImageFormat.Png)
                Dim bytes As Byte() = memory.ToArray()
                fs.Write(bytes, 0, bytes.Length)
                fs.Close()
                fs.Dispose()

            End Using
        End Using

    End Sub

End Class