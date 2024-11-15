

Imports CrystalDecisions.Shared
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Web
Imports PrintMode = CrystalDecisions.Windows.Forms.PrintMode
Imports System.Data.SqlClient
Imports Spire.Barcode
Imports System.IO
Imports EncriptarDesencriptar

Public Class Vales_credito

    Dim Parametros As New ParameterFields()
    Dim PrimerParametro As New ParameterField()
    Dim myDiscreteValue As New ParameterDiscreteValue()
    Dim codigo As New ParameterDiscreteValue()
    Shared LstCods As New List(Of String)

    Private Sub Vales_credito_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Vales_credito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'TxtNumCliente.Text = CodigoCliente

            'PrimerParametro.ParameterValueType = ParameterValueKind.NumberParameter
            'PrimerParametro.ParameterFieldName = "@Num_cliente"

            'myDiscreteValue.Value = Convert.ToInt32(TxtNumCliente.Text)
            'PrimerParametro.CurrentValues.Add(myDiscreteValue)
            'Parametros.Add(PrimerParametro)
            'CrystalReportViewer2.ParameterFieldInfo = Parametros

            Dim info As New Valescred
            'Report.Database.Tables(1).ConnectionProperties("Data Source") = "Server"
            'Report.Database.Tables(1).ConnectionProperties("Initial Catalog") = "Database"
            'Report.Database.Tables(1).ConnectionProperties("User ID") = "userID"
            'Report.Database.Tables(1).ConnectionProperties("Password") = "password"
            'MsgBox(ConfigurationManager.appSettings("folderpath") + "Valescred.rpt")


            'CrystalReportViewer2.ReportSource =info

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub CrystalReportViewer2_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer2.Load
        'Dim cryRpt As New ReportDocument
        'Dim crtableLogoninfos As New TableLogOnInfos
        'Dim crtableLogoninfo As New TableLogOnInfo
        'Dim crConnectionInfo As New ConnectionInfo
        'Dim CrTables As Tables
        'Dim CrTable As Table
        'Dim defprinter As New System.Drawing.Printing.PrinterSettings
        'cryRpt.Load(ConfigurationManager.appSettings("folderpath") + "Valescred.rpt")
        ''MsgBox(ConfigurationManager.appSettings("folderpath") + "Valescred.rpt")
        'With crConnectionInfo
        '    .ServerName = ConfigurationManager.AppSettings("servername")
        '    .DatabaseName = "vales_faza"
        '    .UserID = ConfigurationManager.AppSettings("userid")
        '    .Password = ConfigurationManager.AppSettings("pwd")
        '    .IntegratedSecurity = False
        '    .Type = ConnectionInfoType.SQL
        'End With

        'CrTables = cryRpt.Database.Tables
        'For Each CrTable In CrTables
        '    crtableLogoninfo = CrTable.LogOnInfo
        '    crtableLogoninfo.ConnectionInfo = crConnectionInfo
        '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
        'Next

        'TxtNumCliente.Text = CodigoCliente

        'PrimerParametro.ParameterValueType = ParameterValueKind.NumberParameter
        'PrimerParametro.ParameterFieldName = "@Num_cliente"

        'myDiscreteValue.Value = Convert.ToInt32(TxtNumCliente.Text)
        'PrimerParametro.CurrentValues.Add(myDiscreteValue)
        'Parametros.Add(PrimerParametro)
        'CrystalReportViewer2.ParameterFieldInfo = Parametros
        ''cryRpt.PrintOptions.PaperSize = paperSize.PaperLetter



        'Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        'doctoprint.PrinterSettings.PrinterName = defprinter.PrinterName
        ''MsgBox(defprinter.PrinterName)
        'For i = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
        '    Dim kindpaper As Integer
        '    If doctoprint.PrinterSettings.PaperSizes(i).PaperName = "Carta" Then
        '        kindpaper = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
        '        cryRpt.PrintOptions.PaperSize = kindpaper

        '        Exit For
        '    End If
        'Next
        'CrystalReportViewer2.ReportSource = cryRpt

        ExisteOCrearDirectImagenes()
        CrystalReportViewer2.ReportSource = ObtenerReporteCliente()

        'CrystalReportViewer2.RefreshReport()
    End Sub

    Private Sub ExisteOCrearDirectImagenes()
        Dim ImagenesPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ImagenesVales\"

        If Not System.IO.Directory.Exists(ImagenesPath) Then
            System.IO.Directory.CreateDirectory(ImagenesPath)
        End If

    End Sub

    Shared Function Obtenerclientes() As ClientesCodigos
        Dim _DsClientes As New ClientesCodigos()

        Dim EncrDesencr As New EncriptacionDescencriptacion

        Using con As SqlConnection = New SqlConnection(EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString))
            con.Open()

            Using cmd As SqlCommand = con.CreateCommand()
                cmd.CommandText = "SELECT * FROM Clientes where Num_cliente=" + CodigoCliente
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(_DsClientes, "Clientes")

                Dim ii As Integer = 0
                Dim dt As DataTable = _DsClientes.Tables(0)

                For Each Item As Object In dt.Rows(0).ItemArray

                    If ii >= 4 Then
                        GenerarCodigoBarra(Item.ToString, "Image" + (ii - 3).ToString)
                    End If

                    ii = ii + 1
                Next
            End Using

        End Using
        Return _DsClientes
    End Function

    Public Shared Function ObtenerReporteCliente() As Valescred
        Dim reporte As New Valescred

        Dim cliente As ClientesCodigos = Obtenerclientes()
        reporte.SetDataSource(cliente)
        Return reporte
    End Function

    Private Shared Sub GenerarCodigoBarra(Codigo As String, Archivo As String)

        Dim ImagenesPath = "C:\ImagenesVales\" & Archivo + ".bmp"
        Dim bs As BarcodeSettings = New BarcodeSettings()

        'Quitar asteriscos de los códigos
        bs.Type = BarCodeType.Code128
        bs.Data = Codigo.Replace("*", "")

        'Generar imagen
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

    Public Sub ImprimirValesCred(saveFileDialog As SaveFileDialog)
        Dim reporte As New Valescred

        Dim dlgResult As DialogResult = saveFileDialog.ShowDialog()

        If dlgResult = DialogResult.OK Then
            saveFileDialog.DefaultExt = "pdf"
            ExisteOCrearDirectImagenes()
            reporte = ObtenerReporteCliente()
            reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName)
        End If

    End Sub

End Class
