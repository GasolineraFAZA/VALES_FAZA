Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Spire.Barcode
Imports System.Drawing.Imaging
Imports System.IO
Imports EncriptarDesencriptar

Public Class frmMenu

    Public Property Location As Point
    Dim strconexion As String

    Public Event Scroll As ScrollEventHandler
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim EncrDesencr As New EncriptacionDescencriptacion

        Me.Icon = New Icon(AppDomain.CurrentDomain.BaseDirectory & "\Imagenes\ValesFaza.ico")
        strconexion = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        BtnRefrescar.Visible = False
        DgvGeneral.Height = Me.Height - 160
    End Sub
    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        Label2.Text = "Catalogo de clientes"
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        BtnRefrescar.Visible = False
        FrmCatalogoClientes.ShowDialog()

    End Sub

    Private Sub BtnCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCatalogo.Click
        Try
            Label2.Text = "Catalogo de clientes"
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            BtnRefrescar.Visible = False

            cnn.ConnectionString = strconexion
            cnn.Open()

            com2.Connection = cnn
            com2.CommandText = "select IdCliente,Num_cliente,Nombre_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12 from Clientes"
            Dim base As New SqlDataAdapter(com2)
            base.Fill(datos)
            DgvGeneral.DataSource = datos.Tables(0)
            cnn.Close()
            DgvGeneral.Columns(0).Visible = False
            DgvGeneral.Columns(1).HeaderText = "Numero de cliente"
            DgvGeneral.Columns(2).HeaderText = "Nombre del cliente"
            DgvGeneral.Columns(3).HeaderText = "Tipo de cliente"
            DgvGeneral.Columns(4).Visible = False
            DgvGeneral.Columns(5).Visible = False
            DgvGeneral.Columns(6).Visible = False
            DgvGeneral.Columns(7).Visible = False
            DgvGeneral.Columns(8).Visible = False
            DgvGeneral.Columns(9).Visible = False
            DgvGeneral.Columns(10).Visible = False
            DgvGeneral.Columns(11).Visible = False
            DgvGeneral.Columns(12).Visible = False
            DgvGeneral.Columns(13).Visible = False
            DgvGeneral.Columns(14).Visible = False
            DgvGeneral.Columns(15).Visible = False

            VarImprimir = 1
            VarVisualizar = 1
            AbrirRegistro = 1
            Tabla = "Clientes"
            ToolStripSeparator8.Visible = False
            TsbBuscar.Visible = True
            ToolStripSeparator5.Visible = True
            TsmVista.Visible = False



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub BtnValesCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValesCredito.Click
        Try
            Label2.Text = "Vales de credito"
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            BtnRefrescar.Visible = False

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet



            'DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Now())
            'DateTimePicker2.Value = Now()
            ''Dim hasta As DateTime = CDate(ConfigurationManager.AppSettings("hasta").ToString)

            cnn.ConnectionString = strconexion
            cnn.Open()


            com2.Connection = cnn
            'com2.CommandText = "select IdValeCred,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_credito WHERE fecha >= '" & desde.ToString("yyyy-dd-MM") & "'  and  fecha <= '" & hasta.ToString("yyyy-dd-MM") & "'"
            com2.CommandText = "select IdValeCred,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_credito " ' WHERE fecha >= '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and fecha <= '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "'"
            Dim base As New SqlDataAdapter(com2)
            base.Fill(datos)
            DgvGeneral.DataSource = datos.Tables(0)
            cnn.Close()
            VarImprimir = 2
            VarVisualizar = 2
            VarperVista = 2
            Tabla = "Vales Credito"

            DgvGeneral.Columns(0).Visible = False

            DgvGeneral.Columns(1).HeaderText = "Fecha de captura"
            DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
            DgvGeneral.Columns(3).HeaderText = "Nombre de cliente"
            DgvGeneral.Columns(4).HeaderText = "Folio inicial"
            DgvGeneral.Columns(5).HeaderText = "Folio final"
            DgvGeneral.Columns(4).Visible = False
            DgvGeneral.Columns(5).Visible = False

            'DgvGeneral.Columns(0).Visible = False
            ToolStripSeparator8.Visible = False
            TsbBuscar.Visible = False
            ToolStripSeparator5.Visible = False
            TsmVista.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub BtnValesAnexoClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValesAnexoClientes.Click
        Try
            Label2.Text = "Vales anexo clientes"
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            BtnRefrescar.Visible = False

            DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Now())
            DateTimePicker2.Value = Now()
            ' Dim hasta As DateTime = CDate(ConfigurationManager.AppSettings("hasta").ToString)

            cnn.ConnectionString = strconexion
            cnn.Open()


            com2.Connection = cnn
            com2.CommandText = "select IdValeAnexo,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_anexo" ' where fecha >= '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and fecha <= '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "'"
            Dim base As New SqlDataAdapter(com2)
            base.Fill(datos)
            DgvGeneral.DataSource = datos.Tables(0)
            cnn.Close()
            VarImprimir = 3
            VarVisualizar = 3
            VarperVista = 3
            Tabla = "Vales anexo cliente"

            DgvGeneral.Columns(0).Visible = False

            DgvGeneral.Columns(1).HeaderText = "Fecha de captura"
            DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
            DgvGeneral.Columns(3).HeaderText = "Nombre de cliente"
            DgvGeneral.Columns(4).HeaderText = "Folio inicial"
            DgvGeneral.Columns(5).HeaderText = "Folio final"
            DgvGeneral.Columns(4).Visible = False
            DgvGeneral.Columns(5).Visible = False

            'DgvGeneral.Columns(0).Visible = False
            ToolStripSeparator8.Visible = False
            TsbBuscar.Visible = False
            ToolStripSeparator5.Visible = False
            TsmVista.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem1.Click
        Label2.Text = "Catalogo de clientes"
        FrmCatalogoClientes.ShowDialog()

    End Sub

    Private Sub ValeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValeCreditoToolStripMenuItem.Click
        Label2.Text = "Vales de credito"
        FrmValesCredito.ShowDialog()

    End Sub

    Private Sub ValeAnexoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValeAnexoClienteToolStripMenuItem.Click
        Label2.Text = "Vales anexo clientes"
        FrmAnexoVales.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ValesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesToolStripMenuItem.Click
        Label2.Text = "Vales de credito"
        FrmValesCredito.ShowDialog()

    End Sub

    Private Sub ValesAnexoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesAnexoClienteToolStripMenuItem.Click
        Label2.Text = "Vales anexo clientes"
        FrmAnexoVales.ShowDialog()

    End Sub

    Private Sub DgvGeneral_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvGeneral.CellContentDoubleClick

        Try

            If VarImprimir = 1 Then
                VarDato = 1
                NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                FrmCatalogoClientes.ShowDialog()
            End If

            If VarImprimir = 2 Then
                VarDato = 2
                NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                FrmValesCredito.ShowDialog()
            End If

            If VarImprimir = 3 Then
                VarDato = 3
                NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                FrmAnexoVales.ShowDialog()
            End If

            If VarImprimir = 4 Then
                VarDato = 4
                NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                NumIdValeTrans = Me.DgvGeneral.Rows(e.RowIndex).Cells("IdValeTrans").Value

                FrmValesTransferencia.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub BtnValesTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValesTransferencia.Click
        Try
            Label2.Text = "Vales transferencia"
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            DateTimePicker1.Visible = True
            DateTimePicker2.Visible = True
            BtnRefrescar.Visible = True

            DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Now())
            DateTimePicker2.Value = Now()
            'Dim hasta As DateTime = CDate(ConfigurationManager.AppSettings("hasta").ToString)

            cnn.ConnectionString = strconexion
            cnn.Open()


            com2.Connection = cnn
            'com2.CommandText = "select * from Vales_transferencia  where fecha_trans >= '" & desde.ToString("yyyy-dd-MM") & "'  and  fecha_trans <= '" & hasta.ToString("yyyy-dd-MM") & "' order by IdValeref asc"
            com2.CommandText = "select * from Vales_transferencia  where fecha_trans >= '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and fecha_trans <= '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' order by IdValeref asc"
            Dim base As New SqlDataAdapter(com2)
            base.Fill(datos)
            DgvGeneral.DataSource = datos.Tables(0)
            cnn.Close()
            VarImprimir = 4
            VarVisualizar = 4
            VarperVista = 4
            Tabla = "Vales Transferencia"
            DgvGeneral.Columns(0).HeaderText = "Id Vale Transaccion"

            DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
            DgvGeneral.Columns(3).HeaderText = "Nombre del cliente"
            DgvGeneral.Columns(4).HeaderText = "Importe transaccion"
            DgvGeneral.Columns(5).HeaderText = "Numero de movimiento"

            DgvGeneral.Columns(7).HeaderText = "Fecha de transaccion"
            DgvGeneral.Columns(8).HeaderText = "Folio de cobro"
            DgvGeneral.Columns(10).HeaderText = "Numero de carga"
            DgvGeneral.Columns(12).HeaderText = "Descripcion del vehiculo"
            DgvGeneral.Columns(15).HeaderText = "Fecha del Corte"
            DgvGeneral.Columns(19).HeaderText = "Precio unitario"

            Me.DgvGeneral.Columns.Item(1).Visible = False
            Me.DgvGeneral.Columns.Item(6).Visible = False
            Me.DgvGeneral.Columns.Item(8).Visible = False
            Me.DgvGeneral.Columns.Item(9).Visible = False

            Me.DgvGeneral.Columns.Item(11).Visible = False
            Me.DgvGeneral.Columns.Item(12).Visible = False
            Me.DgvGeneral.Columns.Item(13).Visible = False
            Me.DgvGeneral.Columns.Item(14).Visible = False
            Me.DgvGeneral.Columns.Item(15).Visible = False
            Me.DgvGeneral.Columns.Item(16).Visible = False
            Me.DgvGeneral.Columns.Item(17).Visible = False
            Me.DgvGeneral.Columns.Item(18).Visible = False
            Me.DgvGeneral.Columns.Item(19).Visible = False
            Me.DgvGeneral.Columns.Item(23).Visible = False



            TsmVista.Visible = True
            ToolStripSeparator8.Visible = True
            ActualizarVistaToolStripMenuItem.Visible = True
            TsbBuscar.Visible = False
            ToolStripSeparator5.Visible = False
            TsmVista.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbImprimir.Click

        Dim EncrDesencr As New EncriptacionDescencriptacion

        Try
            If VarImprimir = 1 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptClientes
                Cr.SetDataSource(Dt)

                Dim R As New FrmClientes

                R.CrClientes.ReportSource = ConfigurationManager.AppSettings("folderpath") + "RptClientes.rpt"
                R.ShowDialog()

            End If

            If VarImprimir = 2 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptValesCred
                Cr.SetDataSource(Dt)

                Dim R As New FrmCredVales
                R.CrvValesCred.ReportSource = ConfigurationManager.AppSettings("folderpath") + "RptValesCred.rpt"
                R.ShowDialog()

            End If

            If VarImprimir = 3 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptValesAnexo
                Cr.SetDataSource(Dt)

                Dim R As New FrmValesAnexo
                R.CrvValesAnexo.ReportSource = ConfigurationManager.AppSettings("folderpath") + "RptValesAnexo.rpt"
                R.ShowDialog()

            End If

            If VarImprimir = 4 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptValeTrasns
                Cr.SetDataSource(Dt)

                Dim R As New FrmValesTrans
                R.CrvValeTrans.ReportSource = ConfigurationManager.AppSettings("folderpath") + "RptValeTrasns.rpt"
                R.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ValesTransferenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesTransferenciaToolStripMenuItem.Click
        VarCargarDatos = 4

        Label2.Text = "Vales transferencia"
        FrmValesTransferencia.ShowDialog()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Try
            If VarImprimir = 1 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptClientes
                Cr.SetDataSource(Dt)

                Dim R As New FrmClientes
                R.CrClientes.ReportSource = Cr
                R.ShowDialog()

            End If

            If VarImprimir = 2 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptValesCred
                Cr.SetDataSource(Dt)

                Dim R As New FrmCredVales
                R.CrvValesCred.ReportSource = Cr
                R.ShowDialog()

            End If

            If VarImprimir = 3 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptValesAnexo
                Cr.SetDataSource(Dt)

                Dim R As New FrmValesAnexo
                R.CrvValesAnexo.ReportSource = Cr
                R.ShowDialog()

            End If

            If VarImprimir = 4 Then
                Dim Dt As New DataTable
                Dt = Me.DgvGeneral.DataSource

                Dim Cr As New RptValeTrasns
                Cr.SetDataSource(Dt)

                Dim R As New FrmValesTrans
                R.CrvValeTrans.ReportSource = Cr
                R.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PersonalizarVistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalizarVistaToolStripMenuItem.Click
        Try
            If VarVisualizar = 1 Then
                FrmVistaClientes.ShowDialog()

            End If

            If VarVisualizar = 2 Then
                FrmVistaCredito.ShowDialog()
            End If

            If VarVisualizar = 3 Then
                FrmVistaAnexo.ShowDialog()

            End If

            If VarVisualizar = 4 Then
                FrmVistaTransferencia.ShowDialog()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsmVista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmVista.Click

        FrmPeriodoVista.ShowDialog()

    End Sub



    Private Sub ActualizarVistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarVistaToolStripMenuItem.Click
        Try

            If VarVisualizar = 1 Then
                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()

                com2.Connection = cnn
                com2.CommandText = "Select IdCliente,Num_cliente,Nombre_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12 from Clientes"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()
            End If

            If VarVisualizar = 2 Then
                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()


                com2.Connection = cnn
                com2.CommandText = "Select IdValeCred,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_credito"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()
            End If

            If VarVisualizar = 3 Then
                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()


                com2.Connection = cnn
                com2.CommandText = "Select IdValeAnexo,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_anexo"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()
            End If

            If VarVisualizar = 4 Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn

                cmd.CommandText = "Select IdValeTrans,Num_cliente,Nombre_cliente,Importe_trans,Num_movimiento,Fecha_trans,IdCarga,Sucursal,Cantidad,Producto,Importe,Codigo,Fecha_captura from Vales_transferencia"
                Dim base As New SqlDataAdapter(cmd)
                base.Fill(datos)
                DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TsbNuevo_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbNuevo.ButtonClick
        Try
            If VarImprimir = 1 Then
                Label2.Text = "Catalogo de clientes"
                FrmCatalogoClientes.ShowDialog()
            End If
            If VarImprimir = 2 Then
                Label2.Text = "Vales de credito"
                FrmValesCredito.ShowDialog()
            End If
            If VarImprimir = 3 Then
                Label2.Text = "Vales anexo clientes"
                FrmAnexoVales.ShowDialog()
            End If
            If VarImprimir = 4 Then
                VarCargarDatos = 4

                Label2.Text = "Vales transferencia"
                FrmValesTransferencia.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbBuscar.Click
        FrmBuscarCliente.ShowDialog()
    End Sub

    Private Sub DgvGeneral_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvGeneral.CellContentClick

    End Sub

    'Private Sub TxtcurrentIndex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'TxtcurrentIndex.Text = DgvGeneral.CurrentRow.Index()

    'End Sub

    ' Private Sub DgvGeneral_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvGeneral.Click
    ' TxtcurrentIndex.Text = DgvGeneral.CurrentRow.Index()
    ' End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'TextBox1.Text = DgvGeneral.Rows(DgvGeneral.CurrentRow.Index).Cells(4).Value

    'End Sub



    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ValesTransferenciaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesTransferenciaToolStripMenuItem1.Click
        VarCargarDatos = 4

        Label2.Text = "Vales transferencia"
        FrmValesTransferencia.ShowDialog()
    End Sub

    Private Sub DgvGeneral_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgvGeneral.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            With DgvGeneral
                Dim Hitest As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If Hitest.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = .Rows(Hitest.RowIndex).Cells(Hitest.ColumnIndex)
                    NumCliente = .Rows(Hitest.RowIndex).Cells(0).Value
                    TxtCurrentIndex.Text = .Rows(Hitest.RowIndex).Cells(0).Value

                End If
            End With
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Try

            If VarImprimir = 1 Then
                VarDato = 1
                ' NumCliente
                FrmCatalogoClientes.ShowDialog()
            End If

            If VarImprimir = 2 Then
                VarDato = 2
                'NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                FrmValesCredito.ShowDialog()
            End If

            If VarImprimir = 3 Then
                VarDato = 3
                'NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                FrmAnexoVales.ShowDialog()
            End If

            If VarImprimir = 4 Then
                VarDato = 4
                'NumCliente = Me.DgvGeneral.Rows(e.RowIndex).Cells(0).Value
                FrmValesTransferencia.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            If VarImprimir = 1 Then
                Dim RespuestaElim As MsgBoxResult
                RespuestaElim = MsgBox("Desea eliminar el registro de forma permanente?", MsgBoxStyle.YesNo)
                If RespuestaElim = MsgBoxResult.Yes Then
                    Dim cnn As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim com2 As New SqlCommand
                    Dim datos As New DataSet
                    cnn.ConnectionString = strconexion
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandText = "delete clientes where Idcliente = '" & TxtCurrentIndex.Text & "'"
                    cmd.ExecuteNonQuery()
                Else
                    TxtCurrentIndex.Text = ""

                End If

            End If

            If VarImprimir = 2 Then
                Dim RespuestaElim As MsgBoxResult
                RespuestaElim = MsgBox("Desea eliminar el registro de forma permanente?", MsgBoxStyle.YesNo)
                If RespuestaElim = MsgBoxResult.Yes Then
                    Dim cnn As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim com2 As New SqlCommand
                    Dim datos As New DataSet
                    cnn.ConnectionString = strconexion
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandText = "delete Vales_credito where IdValeCred = '" & TxtCurrentIndex.Text & "'"
                    cmd.ExecuteNonQuery()
                Else
                    TxtCurrentIndex.Text = ""
                End If
            End If

            If VarImprimir = 3 Then
                Dim RespuestaElim As MsgBoxResult
                RespuestaElim = MsgBox("Desea eliminar el registro de forma permanente?", MsgBoxStyle.YesNo)
                If RespuestaElim = MsgBoxResult.Yes Then
                    Dim cnn As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim com2 As New SqlCommand
                    Dim datos As New DataSet
                    cnn.ConnectionString = strconexion
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandText = "delete Vales_anexo where IdValeAnexo = '" & TxtCurrentIndex.Text & "'"
                    cmd.ExecuteNonQuery()
                Else
                    TxtCurrentIndex.Text = ""
                End If
            End If

            If VarImprimir = 4 Then
                Dim RespuestaElim As MsgBoxResult
                RespuestaElim = MsgBox("Desea eliminar el registro de forma permanente?", MsgBoxStyle.YesNo)
                If RespuestaElim = MsgBoxResult.Yes Then
                    Dim cnn As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim com2 As New SqlCommand
                    Dim datos As New DataSet
                    cnn.ConnectionString = strconexion
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandText = "delete Vales_transferencia where IdValeTrans = '" & TxtCurrentIndex.Text & "'"
                    cmd.ExecuteNonQuery()
                Else
                    TxtCurrentIndex.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnMesActual_Click(sender As Object, e As EventArgs) Handles BtnRefrescar.Click
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            cnn.ConnectionString = strconexion
            cnn.Open()

            com2.Connection = cnn

            Select Case Label2.Text
                Case "Vales de credito"
                    com2.CommandText = "select IdValeCred,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_credito WHERE fecha >= ''" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and fecha_trans <= '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "''"
                    Dim base As New SqlDataAdapter(com2)
                    base.Fill(datos)
                    DgvGeneral.DataSource = datos.Tables(0)
                    cnn.Close()
                    VarImprimir = 2
                    VarVisualizar = 2
                    VarperVista = 2
                    Tabla = "Vales Credito"

                    DgvGeneral.Columns(0).Visible = False

                    DgvGeneral.Columns(1).HeaderText = "Fecha de captura"
                    DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
                    DgvGeneral.Columns(3).HeaderText = "Nombre de cliente"
                    DgvGeneral.Columns(4).HeaderText = "Folio inicial"
                    DgvGeneral.Columns(5).HeaderText = "Folio final"
                    DgvGeneral.Columns(4).Visible = False
                    DgvGeneral.Columns(5).Visible = False

                    'DgvGeneral.Columns(0).Visible = False
                    ToolStripSeparator8.Visible = False
                    TsbBuscar.Visible = False
                    ToolStripSeparator5.Visible = False
                    TsmVista.Visible = True
                Case "Vales anexo clientes"
                    com2.CommandText = "select IdValeAnexo,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_anexo where fecha >= '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and fecha_trans <= '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "'"
                    Dim base As New SqlDataAdapter(com2)
                    base.Fill(datos)
                    DgvGeneral.DataSource = datos.Tables(0)
                    cnn.Close()
                    VarImprimir = 3
                    VarVisualizar = 3
                    VarperVista = 3
                    Tabla = "Vales anexo cliente"

                    DgvGeneral.Columns(0).Visible = False

                    DgvGeneral.Columns(1).HeaderText = "Fecha de captura"
                    DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
                    DgvGeneral.Columns(3).HeaderText = "Nombre de cliente"
                    DgvGeneral.Columns(4).HeaderText = "Folio inicial"
                    DgvGeneral.Columns(5).HeaderText = "Folio final"
                    DgvGeneral.Columns(4).Visible = False
                    DgvGeneral.Columns(5).Visible = False

                    'DgvGeneral.Columns(0).Visible = False
                    ToolStripSeparator8.Visible = False
                    TsbBuscar.Visible = False
                    ToolStripSeparator5.Visible = False
                    TsmVista.Visible = True
                Case "Vales transferencia"
                    com2.CommandText = "select * from Vales_transferencia  where fecha_trans >= '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and fecha_trans <= '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' order by IdValeref asc"
                    Dim base As New SqlDataAdapter(com2)
                    base.Fill(datos)
                    DgvGeneral.DataSource = datos.Tables(0)
                    cnn.Close()
                    VarImprimir = 4
                    VarVisualizar = 4
                    VarperVista = 4
                    Tabla = "Vales Transferencia"
                    DgvGeneral.Columns(0).HeaderText = "Id Vale Transaccion"

                    DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
                    DgvGeneral.Columns(3).HeaderText = "Nombre del cliente"
                    DgvGeneral.Columns(4).HeaderText = "Importe transaccion"
                    DgvGeneral.Columns(5).HeaderText = "Numero de movimiento"

                    DgvGeneral.Columns(7).HeaderText = "Fecha de transaccion"
                    DgvGeneral.Columns(8).HeaderText = "Folio de cobro"
                    DgvGeneral.Columns(10).HeaderText = "Numero de carga"
                    DgvGeneral.Columns(12).HeaderText = "Descripcion del vehiculo"
                    DgvGeneral.Columns(15).HeaderText = "Fecha del Corte"
                    DgvGeneral.Columns(19).HeaderText = "Precio unitario"

                    Me.DgvGeneral.Columns.Item(1).Visible = False
                    Me.DgvGeneral.Columns.Item(6).Visible = False
                    Me.DgvGeneral.Columns.Item(8).Visible = False
                    Me.DgvGeneral.Columns.Item(9).Visible = False

                    Me.DgvGeneral.Columns.Item(11).Visible = False
                    Me.DgvGeneral.Columns.Item(12).Visible = False
                    Me.DgvGeneral.Columns.Item(13).Visible = False
                    Me.DgvGeneral.Columns.Item(14).Visible = False
                    Me.DgvGeneral.Columns.Item(15).Visible = False
                    Me.DgvGeneral.Columns.Item(16).Visible = False
                    Me.DgvGeneral.Columns.Item(17).Visible = False
                    Me.DgvGeneral.Columns.Item(18).Visible = False
                    Me.DgvGeneral.Columns.Item(19).Visible = False
                    Me.DgvGeneral.Columns.Item(23).Visible = False

                    TsmVista.Visible = True
                    ToolStripSeparator8.Visible = True
                    ActualizarVistaToolStripMenuItem.Visible = True
                    TsbBuscar.Visible = False
                    ToolStripSeparator5.Visible = False
                    TsmVista.Visible = True
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DgvGeneral_Resize(sender As Object, e As EventArgs) Handles DgvGeneral.Resize
        DgvGeneral.Height = Me.Height - 160
    End Sub

End Class
