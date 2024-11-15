Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Spire.Barcode
Imports System.IO
Imports System.Drawing.Imaging
Imports EncriptarDesencriptar

Public Class FrmValesTransferencia
    Dim contador As String = 0
    Dim contadorcarga As String = 0
    Dim strconexion As String
    Private Sub IdVale()
        Dim cnn As New SqlConnection
        Dim cmd As String
        Dim datos As New DataSet
        Dim da As SqlDataAdapter
        Dim valor As Double

        cnn.ConnectionString = strconexion
        cnn.Open()

        '*******BUSCAR EL ULTIMO ID DE LA CARGA Y HACER EL INCREMENTO********

        cmd = "select top 1 * from Vales_transferencia order by idvaleref desc"
        da = New SqlDataAdapter(cmd, cnn)
        da.Fill(datos, "Vales_transferencia")

        If datos.Tables(0).Rows.Count() = 0 Then
            TxtIdCarga.Text = 0
            valor = Val(TxtIdValeTrans.Text)
            valor = valor + 1
            TxtIdValeTrans.Text = valor
        Else
            Dim dr As DataRow
            dr = datos.Tables(0).Rows(0)
            TxtIdValeTrans.Text = dr("IdValeTrans").ToString
            valor = Val(TxtIdValeTrans.Text)
            valor = valor + 1
            TxtIdValeTrans.Text = valor

        End If
        cnn.Close()
    End Sub
    Private Sub UltimoCodigo()
        Dim cnn As New SqlConnection
        Dim cmd As String
        Dim datos As New DataSet
        Dim da As SqlDataAdapter
        Dim valor As Double

        cnn.ConnectionString = strconexion
        cnn.Open()

        '*******BUSCAR EL ULTIMO ID DE LA CARGA Y HACER EL INCREMENTO********

        cmd = "select top 1 * from Vales_transferencia where IdValeTrans='" & TxtIdValeTrans.Text & "' order by IdCarga desc"

        da = New SqlDataAdapter(cmd, cnn)
        da.Fill(datos, "Vales_transferencia")

        If datos.Tables(0).Rows.Count() = 0 Then
            TxtIdCarga.Text = 0
            valor = Val(TxtIdCarga.Text)
            valor = valor + 1
            TxtIdCarga.Text = valor
        Else
            Dim dr As DataRow
            dr = datos.Tables(0).Rows(0)
            TxtIdCarga.Text = dr("IdCarga").ToString
            valor = Val(TxtIdCarga.Text)
            valor = valor + 1
            TxtIdCarga.Text = valor

        End If
        cnn.Close()


    End Sub
    Private Sub limpiarTodo()
        CboNombreClienteVT.Text = ""
        TxtNumCliente.Text = ""
        TxtImporteTrans.Text = ""
        TxtNumMovimiento.Text = ""
        TxtCajero.Text = ""
        TxtFechaTrans.Text = ""
        TxtFolioCobro.Text = ""
        TxtFactura.Text = ""

        CboSucursal.Text = ""
        TxtDescripcionVeh.Text = ""
        TxtPlacas.Text = ""
        TxtConductor.Text = ""
        TxtFechaCorte.Text = ""
        CboTurno.Text = ""
        TxtCantidad.Text = ""
        CboProducto.Text = ""
        TxtPrecioUnitario.Text = ""
        TxtImporte.Text = ""
        DgvValesTrans.DataSource = Nothing

    End Sub

    Private Sub limpiarCarga()
        CboSucursal.Text = ""
        TxtDescripcionVeh.Text = ""
        TxtPlacas.Text = ""
        TxtConductor.Text = ""
        TxtFechaCorte.Text = ""
        CboTurno.Text = ""
        TxtCantidad.Text = ""
        CboProducto.Text = ""
        TxtPrecioUnitario.Text = ""
        TxtImporte.Text = ""
    End Sub
    Private Sub inhabilitarcampos()
        CboNombreClienteVT.Enabled = False
        TxtNumCliente.ReadOnly = True
        TxtImporteTrans.ReadOnly = True
        TxtNumMovimiento.ReadOnly = True
        TxtCajero.ReadOnly = True
        TxtFechaTrans.ReadOnly = True
        TxtFolioCobro.ReadOnly = True
        TxtFactura.ReadOnly = True

        CboSucursal.Enabled = False
        TxtDescripcionVeh.ReadOnly = True
        TxtPlacas.ReadOnly = True
        TxtConductor.ReadOnly = True
        TxtFechaCorte.ReadOnly = True
        CboTurno.Enabled = False
        TxtCantidad.ReadOnly = True
        CboProducto.Enabled = False
        TxtPrecioUnitario.ReadOnly = True
        TxtImporte.ReadOnly = True
        BtnAgregarCarga.Enabled = False




    End Sub
    Private Sub habilitarcampos()
        CboNombreClienteVT.Enabled = True
        TxtNumCliente.ReadOnly = False
        TxtImporteTrans.ReadOnly = False
        TxtNumMovimiento.ReadOnly = False
        TxtCajero.ReadOnly = False
        TxtFechaTrans.ReadOnly = False
        TxtFolioCobro.ReadOnly = False
        TxtFactura.ReadOnly = False

        CboSucursal.Enabled = True
        TxtDescripcionVeh.ReadOnly = False
        TxtPlacas.ReadOnly = False
        TxtConductor.ReadOnly = False
        TxtFechaCorte.ReadOnly = False
        CboTurno.Enabled = True
        TxtCantidad.ReadOnly = False
        CboProducto.Enabled = True
        TxtPrecioUnitario.ReadOnly = False
        TxtImporte.ReadOnly = False
        BtnAgregarCarga.Enabled = True
    End Sub
    Private Sub llenacombo()
        Dim cnn As New SqlConnection
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        cnn.ConnectionString = strconexion
        cnn.Open()

        With cmd
            .CommandType = CommandType.Text
            .CommandText = "select Nombre_cliente from clientes where Tipo_cliente='Vales transferencia'"
            .Connection = cnn
        End With

        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)
        With CboNombreClienteVT
            .DataSource = dt
            .DisplayMember = "Nombre_cliente"
            .Text = ""
        End With

        cnn.Close()
    End Sub
    Private Sub BtnAgregarCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarCarga.Click
        Try
            If totalcarga > totalimporte Then
                MsgBox("El importe de la carga ya revaso el importe de la transferencia", MsgBoxStyle.Information)
                limpiarTodo()
                CboNombreClienteVT.Focus()

            Else
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandText = "insert into Vales_transferencia(IdValeTrans,IdCliente,Num_cliente,Nombre_cliente,Importe_trans,Num_movimiento,Cajera,Fecha_trans,Folio_cobro,Factura,IdCarga,Sucursal,Descripcion_veh,Placas,Conductor,Fecha_corte,Turno,Cantidad,Producto,Precio_uni,Importe,Codigo,Fecha_captura) " &
                "values('" & TxtIdValeTrans.Text & "','" & TxtIdCliente.Text & "','" & TxtNumCliente.Text & "','" & CboNombreClienteVT.Text & "', '" & TxtImporteTrans.Text & "', '" & TxtNumMovimiento.Text & "', '" & TxtCajero.Text & "',CONVERT(DATETIME,'" & Format(CDate(TxtFechaTrans.Text), "MM/dd/yyyy") & "',101), '" & TxtFolioCobro.Text & "', '" & TxtFactura.Text & "','" & TxtIdCarga.Text & "', '" & CboSucursal.Text & "', '" & TxtDescripcionVeh.Text & "', '" & TxtPlacas.Text & "', '" & TxtConductor.Text & "" &
                "','" & TxtFechaCorte.Text & "', '" & CboTurno.Text & "', '" & TxtCantidad.Text & "', '" & CboProducto.Text & "', '" & TxtPrecioUnitario.Text & "', '" & TxtImporte.Text & "','" & TxtCodigo.Text & "',CONVERT(DATETIME,'" & Format(CDate(TxtFechaCaptura.Text), "MM/dd/yyyy") & "',101))"
                cmd.ExecuteNonQuery()
                contadorcarga = contadorcarga + 1
                UltimoCodigo()

                cmd2.Connection = cnn
                cmd2.CommandText = "select IdCarga,Sucursal,Descripcion_veh,Placas,Conductor,Fecha_corte,Turno,Cantidad,Producto,Precio_uni,Importe from Vales_transferencia where IdValeTrans = '" & TxtIdValeTrans.Text & "'"
                Dim base As New SqlDataAdapter(cmd2)
                base.Fill(datos)
                DgvValesTrans.DataSource = datos.Tables(0)
                cnn.Close()
                limpiarCarga()
                CboSucursal.Focus()
                TxtCodigo.Text = ""


                If contadorcarga = 2 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo2 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo2").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If

                If contadorcarga = 3 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo3 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo3").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 4 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo4 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo4").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 5 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo5 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo5").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 6 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo6 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo6").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 7 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo7 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo7").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 8 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo8 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo8").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 9 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo9 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo9").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 10 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo10 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo10").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 11 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo11 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo11").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
                If contadorcarga = 12 Then

                    cnn.ConnectionString = strconexion
                    Dim sql As String = "select Codigo12 from clientes where IdCliente= '" & TxtIdCliente.Text & "'"
                    Dim cmd3 As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader

                    cnn.Open()
                    odr = cmd3.ExecuteReader()
                    If odr.Read() Then

                        TxtCodigo.Text() = odr.Item("Codigo12").ToString()
                    End If

                    odr.Close()
                    cnn.Close()

                End If
            End If

            IniciarFechas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmValesTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SaveFileDialog1.DefaultExt = "pdf"

            Dim EncrDesencr As New EncriptacionDescencriptacion
            Dim Cadena As String = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)

            strconexion = Cadena
            contador = 1
            contadorcarga = 1
            If VarDato = 4 Then
                TxtNumCliente.Text = NumCliente
                TxtNumIdValTrans.Text = NumIdValeTrans

                Dim cnn As New SqlConnection
                cnn.ConnectionString = strconexion
                Dim sql As String = "select * from Vales_transferencia where IdValeTrans= '" & TxtNumCliente.Text & "'"
                Dim cmd As New SqlCommand(sql, cnn)
                Dim odr As SqlDataReader
                Dim cmd2 As New SqlCommand
                Dim datos As New DataSet

                cnn.Open()
                odr = cmd.ExecuteReader()
                If odr.Read() Then
                    CboNombreClienteVT.Text = odr.Item("Nombre_cliente").ToString()
                    TxtNumCliente.Text = odr.Item("Num_cliente").ToString()
                    TxtImporteTrans.Text() = odr.Item("Importe_trans").ToString()
                    TxtNumMovimiento.Text() = odr.Item("Num_movimiento").ToString()
                    TxtCajero.Text() = odr.Item("Cajera").ToString()
                    TxtFechaTrans.Text() = Format(odr.Item("fecha_trans").ToString(), "short date")
                    TxtFolioCobro.Text() = odr.Item("Folio_cobro").ToString()
                    TxtFactura.Text() = odr.Item("Factura").ToString()
                    TxtIdCliente.Text() = odr.Item("IdCliente").ToString()
                    TxtIdValeTrans.Text() = odr.Item("IdValeTrans").ToString()
                End If
                odr.Close()
                cmd2.Connection = cnn
                cmd2.CommandText = "select IdCarga,Sucursal,Descripcion_veh,Placas,Conductor,Fecha_corte,Turno,Cantidad,Producto,Precio_uni,Importe from Vales_transferencia where IdValeTrans = '" & TxtIdValeTrans.Text & "'"
                Dim base As New SqlDataAdapter(cmd2)
                base.Fill(datos)
                DgvValesTrans.DataSource = datos.Tables(0)

                DgvValesTrans.Columns(0).HeaderText = "Numero de carga"
                DgvValesTrans.Columns(2).HeaderText = "Descripcion vehiculo"
                DgvValesTrans.Columns(5).HeaderText = "Fecha corte"
                DgvValesTrans.Columns(9).HeaderText = "Precio unitario"

                cnn.Close()

                UltimoCodigo()
                inhabilitarcampos()
                VarDato = 0

                EditarToolStripMenuItem.Enabled = True
                EliminarToolStripMenuItem.Enabled = True
                TsmEditar2.Enabled = True
                TsmEliminar2.Enabled = True
                TsmImprimir.Enabled = True
            Else
                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                llenacombo()
                limpiarTodo()

                habilitarcampos()
                IdVale()
                UltimoCodigo()

                DgvValesTrans.DataSource = Nothing
                limpiarTodo()

                IniciarFechas()
                CboNombreClienteVT.SelectedIndex = -1
            End If

            EliminarToolStripMenuItem.Enabled = True
            GuardarYCerrarToolStripMenuItem.Enabled = True
            TsmGuardarNueVC.Enabled = True
            GuardarCambiosToolStripMenuItem.Enabled = False
            TsmNuevo.Enabled = True
            EditarToolStripMenuItem.Enabled = True
            TsmImprimir.Enabled = True

            TxtFechaCaptura.Text = Format(Now(), "short date")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub CboNombreClienteVT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboNombreClienteVT.SelectedIndexChanged
        Try

            TextBox1.Text = CboNombreClienteVT.Text


            Dim cnn As New SqlConnection
            cnn.ConnectionString = strconexion
            Dim sql As String = "select Num_cliente,IdCliente,Codigo1 from clientes where Nombre_cliente= '" & TextBox1.Text & "'"
            Dim cmd As New SqlCommand(sql, cnn)
            Dim odr As SqlDataReader

            cnn.Open()
            odr = cmd.ExecuteReader()
            If odr.Read() Then
                TxtNumCliente.Text() = odr.Item("Num_cliente").ToString()
                TxtIdCliente.Text() = odr.Item("IdCliente").ToString()
                TxtCodigo.Text() = odr.Item("Codigo1").ToString()
            End If

            odr.Close()
            cnn.Close()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsmGuardarNueVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
    End Sub


    Private Sub TsmNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmNuevo.Click
        llenacombo()

        limpiarTodo()
        DgvValesTrans.DataSource = Nothing

        CboNombreClienteVT.Focus()
        EliminarToolStripMenuItem.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True
        TsmGuardarNueVC.Enabled = True
        GuardarCambiosToolStripMenuItem.Enabled = False
        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False
        habilitarcampos()
        CboNombreClienteVT.Focus()

        IdVale()
        UltimoCodigo()

        habilitarcampos()
        limpiarTodo()
        IniciarFechas()
        CboNombreClienteVT.SelectedIndex = -1

    End Sub

    Private Sub IniciarFechas()
        TxtFechaTrans.Text = DateTimePicker1.Value.ToShortDateString()
        TxtFechaCorte.Text = DateTimePicker2.Value.ToShortDateString()
    End Sub


    Private Sub TsmImprimirVale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VarIdCliente = TxtIdCliente.Text
        Valetransferencia.ShowDialog()

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        inhabilitarcampos()

    End Sub

    Private Sub TsmCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        inhabilitarcampos()
    End Sub

    Private Sub TsmGuardarNueVC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        CboNombreClienteVT.Focus()

    End Sub

    Private Sub GuardarYNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        CboNombreClienteVT.Focus()

    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        Me.Close()

    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        Me.Close()
    End Sub
    Private Sub TsmImprimirVale_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmImprimirVale.Click
        VarIdCliente = TxtIdCliente.Text.Trim()
        VarIdValeTrans = TxtNumIdValTrans.Text.Trim()

        Valetransferencia.ShowDialog()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        limpiarTodo()

        TxtNumCliente.Focus()
        EliminarToolStripMenuItem.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True
        TsmGuardarNueVC.Enabled = True
        GuardarCambiosToolStripMenuItem.Enabled = False
        TsmNuevo.Enabled = True
        EditarToolStripMenuItem.Enabled = True

        TsmEditar2.Enabled = True
        TsmEliminar2.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True


        GuardarYCerrarToolStripMenuItem1.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem1.Enabled = False

        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False

        ' habilitarCampos()

        inhabilitarcampos()
        DgvValesTrans.DataSource = Nothing

    End Sub

    Private Sub TsmCancelar2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmCancelar2.Click
        limpiarTodo()

        TxtNumCliente.Focus()
        EliminarToolStripMenuItem.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True
        TsmGuardarNueVC.Enabled = True
        GuardarCambiosToolStripMenuItem.Enabled = False
        TsmNuevo.Enabled = True
        EditarToolStripMenuItem.Enabled = True

        TsmEditar2.Enabled = True
        TsmEliminar2.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True


        GuardarYCerrarToolStripMenuItem1.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem1.Enabled = False

        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False

        ' habilitarCampos()

        inhabilitarcampos()
        DgvValesTrans.DataSource = Nothing
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub GuardarYNuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYNuevoToolStripMenuItem.Click
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        CboNombreClienteVT.Focus()
        contadorcarga = 0
        contador = 0

    End Sub

    Private Sub TsmGuardarNueVC_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmGuardarNueVC.Click
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        CboNombreClienteVT.Focus()
        contadorcarga = 0
        contador = 0
        IdVale()
        UltimoCodigo()
    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYCerrarToolStripMenuItem.Click
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        contadorcarga = 0
        contador = 0

        Me.Close()

    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYCerrarToolStripMenuItem1.Click
        limpiarTodo()
        DgvValesTrans.DataSource = Nothing
        contadorcarga = 0
        contador = 0
        limpiarTodo()

        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TxtFechaTrans.Text = DateTimePicker1.Value
        TxtFechaTrans.Text = Format(DateTimePicker1.Value, "short date")

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        TxtFechaCorte.Text = DateTimePicker2.Value
        TxtFechaCorte.Text = Format(DateTimePicker2.Value, "short date")
    End Sub

    Private Sub TxtImporteTrans_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImporteTrans.LostFocus
        Dim importeTrans As Double

        If String.IsNullOrEmpty(TxtImporteTrans.Text) Then
            importeTrans = 0
        Else
            importeTrans = TxtImporteTrans.Text
        End If

        totalimporte = Val(importeTrans)
        TxtImporteTrans.Text = importeTrans.ToString("C2")
    End Sub

    Private Sub TxtImporte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImporte.GotFocus
        TxtImporte.Text = Val(TxtCantidad.Text) * Val(TxtPrecioUnitario.Text)

        TxtPrecioUnitario.Text = Double.Parse(TxtPrecioUnitario.Text).ToString("C2")
        TxtImporte.Text = Double.Parse(TxtImporte.Text).ToString("C2")
    End Sub

    Private Sub TxtImporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImporte.LostFocus

        Dim PrecioUni As Double

        If String.IsNullOrEmpty(TxtPrecioUnitario.Text) Then
            PrecioUni = 0
        Else
            PrecioUni = TxtPrecioUnitario.Text
        End If

        TxtPrecioUnitario.Text = PrecioUni.ToString("C")

        Dim importe As Double

        If String.IsNullOrEmpty(TxtImporte.Text) Then
            importe = 0
        Else
            importe = TxtImporte.Text
        End If

        totalcarga = Val(TxtImporte.Text) + totalcarga
        TxtImporte.Text = importe.ToString("C2")
    End Sub


    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
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
                cmd.CommandText = "delete Vales_transferencia where IdValeTrans = '" & TxtIdValeTrans.Text & "'"
                cmd.ExecuteNonQuery()



                limpiarTodo()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarcampos()

                CboNombreClienteVT.Focus()
                llenacombo()
                limpiarTodo()

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                inhabilitarcampos()
            Else
                limpiarTodo()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarcampos()


                llenacombo()
                limpiarTodo()
                CboNombreClienteVT.Focus()

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                inhabilitarcampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        EliminarToolStripMenuItem.Enabled = False
        GuardarYCerrarToolStripMenuItem.Enabled = False
        TsmGuardarNueVC.Enabled = False
        GuardarCambiosToolStripMenuItem.Enabled = True

        TsmNuevo.Enabled = False
        EditarToolStripMenuItem.Enabled = False

        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False

        habilitarcampos()


        GuardarYCerrarToolStripMenuItem1.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem1.Enabled = True
        BtnAgregarCarga.Enabled = False

    End Sub

    Private Sub DgvValesTrans_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvValesTrans.DoubleClick
        Try

            Dim cnn As New SqlConnection
            cnn.ConnectionString = strconexion
            Dim sql As String = "select * from Vales_transferencia where IdValeTrans= '" & TxtIdValeTrans.Text & "' and IdCarga='" & NumCarga & "'"
            Dim cmd As New SqlCommand(sql, cnn)
            Dim odr As SqlDataReader
            Dim cmd2 As New SqlCommand
            Dim datos As New DataSet

            cnn.Open()
            odr = cmd.ExecuteReader()
            If odr.Read() Then
                CboSucursal.Text = odr.Item("Nombre_cliente").ToString()
                TxtImporte.Text = odr.Item("Importe").ToString()
                TxtDescripcionVeh.Text = odr.Item("Descripcion_veh").ToString()
                TxtPlacas.Text = odr.Item("Placas").ToString()
                TxtFechaCorte.Text = odr.Item("Fecha_corte").ToString()
                CboTurno.Text = odr.Item("Turno").ToString()
                TxtCantidad.Text = odr.Item("Cantidad").ToString()
                CboProducto.Text = odr.Item("Producto").ToString()
                TxtPrecioUnitario.Text = odr.Item("Precio_uni").ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvValesTrans_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvValesTrans.CellContentClick
        NumCarga = Me.DgvValesTrans.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try

            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox("Desea guardar los cambios en el registro?", MsgBoxStyle.YesNo)

            If Respuesta = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet


                '*************** Guardar cambios en el registro ************
                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandText = "update Vales_transferencia set Num_cliente='" + TxtNumCliente.Text & "', Nombre_cliente='" + CboNombreClienteVT.Text + "', Importe_trans='" + TxtImporteTrans.Text + "" &
                "', Num_movimiento='" + TxtNumMovimiento.Text + "', Cajera='" + TxtCajero.Text + "', Fecha_trans=CONVERT(DATETIME,'" + TxtFechaTrans.Text + "',101), Folio_cobro='" + TxtFolioCobro.Text + "', Factura='" + TxtFactura.Text + "" &
                "', Sucursal='" + CboSucursal.Text + "', Descripcion_veh='" + TxtDescripcionVeh.Text + "', placas='" + TxtPlacas.Text + "',Conductor='" + TxtConductor.Text + "',Fecha_corte='" + TxtFechaCorte.Text + "" &
                "', Turno='" + CboTurno.Text + "',Cantidad='" + TxtCantidad.Text + "',Producto='" + CboProducto.Text + "',Precio_uni='" + TxtPrecioUnitario.Text + "',Importe='" + TxtImporte.Text + "' where IdValeTrans= '" + TxtIdValeTrans.Text + "' and IdCarga= '" + NumCarga + "'"
                cmd.ExecuteNonQuery()

                com2.Connection = cnn
                com2.CommandText = "update Vales_transferencia set Num_cliente='" + TxtNumCliente.Text & "', Nombre_cliente='" + CboNombreClienteVT.Text + "', Importe_trans='" + TxtImporteTrans.Text + "" &
               "', Num_movimiento='" + TxtNumMovimiento.Text + "', Cajera='" + TxtCajero.Text + "', Fecha_trans=CONVERT(DATETIME,'" + TxtFechaTrans.Text + "',101), Folio_cobro='" + TxtFolioCobro.Text + "', Factura='" + TxtFactura.Text + "' where IdValeTrans= '" + TxtIdValeTrans.Text + "'"
                com2.ExecuteNonQuery()

                limpiarTodo()
                TxtNumCliente.Focus()


                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                TsmNuevo.Enabled = True
                EliminarToolStripMenuItem.Enabled = False


                inhabilitarcampos()


                cnn.Close()
                'BtnAgregarCarga.Enabled = True
            Else
                limpiarTodo()

                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False

                TsmNuevo.Enabled = True

                TxtNumCliente.Focus()

                inhabilitarcampos()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsmEliminar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmEliminar2.Click
        Try
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
                cmd.CommandText = "delete Vales_transferencia where IdValeTrans = '" & TxtIdValeTrans.Text & "'"
                cmd.ExecuteNonQuery()



                limpiarTodo()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarcampos()

                CboNombreClienteVT.Focus()
                llenacombo()
                limpiarTodo()

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                inhabilitarcampos()
            Else
                limpiarTodo()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarcampos()


                llenacombo()
                limpiarTodo()
                CboNombreClienteVT.Focus()

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                inhabilitarcampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsmEditar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmEditar2.Click
        EliminarToolStripMenuItem.Enabled = False
        GuardarYCerrarToolStripMenuItem.Enabled = False
        TsmGuardarNueVC.Enabled = False
        GuardarCambiosToolStripMenuItem.Enabled = True

        TsmNuevo.Enabled = False
        EditarToolStripMenuItem.Enabled = False

        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False

        habilitarcampos()


        GuardarYCerrarToolStripMenuItem1.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem1.Enabled = True
        BtnAgregarCarga.Enabled = False
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem1.Click
        Try

            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox("Desea guardar los cambios en el registro?", MsgBoxStyle.YesNo)

            If Respuesta = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet


                '*************** Guardar cambios en el registro ************
                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandText = "update Vales_transferencia set Num_cliente='" + TxtNumCliente.Text & "', Nombre_cliente='" + CboNombreClienteVT.Text + "', Importe_trans='" + TxtImporteTrans.Text + "" & _
                "', Num_movimiento='" + TxtNumMovimiento.Text + "', Cajera='" + TxtCajero.Text + "', Fecha_trans='" + TxtFechaTrans.Text + "', Folio_cobro='" + TxtFolioCobro.Text + "', Factura='" + TxtFactura.Text + "" & _
                "', Sucursal='" + CboSucursal.Text + "', Descripcion_veh='" + TxtDescripcionVeh.Text + "', placas='" + TxtPlacas.Text + "',Conductor='" + TxtConductor.Text + "',Fecha_corte='" + TxtFechaCorte.Text + "" & _
                "', Turno='" + CboTurno.Text + "',Cantidad='" + TxtCantidad.Text + "',Producto='" + CboProducto.Text + "',Precio_uni='" + TxtPrecioUnitario.Text + "',Importe='" + TxtImporte.Text + "' where IdValeTrans= '" + TxtIdValeTrans.Text + "' and IdCarga= '" + NumCarga + "'"
                cmd.ExecuteNonQuery()

                com2.Connection = cnn
                com2.CommandText = "update Vales_transferencia set Num_cliente='" + TxtNumCliente.Text & "', Nombre_cliente='" + CboNombreClienteVT.Text + "', Importe_trans='" + TxtImporteTrans.Text + "" & _
               "', Num_movimiento='" + TxtNumMovimiento.Text + "', Cajera='" + TxtCajero.Text + "', Fecha_trans=CONVERT(DATETIME,'" + TxtFechaTrans.Text + "',101), Folio_cobro='" + TxtFolioCobro.Text + "', Factura='" + TxtFactura.Text + "' where IdValeTrans= '" + TxtIdValeTrans.Text + "'"
                com2.ExecuteNonQuery()

                limpiarTodo()
                TxtNumCliente.Focus()


                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                TsmNuevo.Enabled = True
                EliminarToolStripMenuItem.Enabled = False


                inhabilitarcampos()


                cnn.Close()
                'BtnAgregarCarga.Enabled = True
            Else
                limpiarTodo()

                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False

                TsmNuevo.Enabled = True

                TxtNumCliente.Focus()

                inhabilitarcampos()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtImporteTrans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImporteTrans.TextChanged

    End Sub

    Private Sub TsmImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmImprimir.Click

    End Sub

    Private Sub TxtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImporte.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDFToolStripMenuItem.Click
        Dim vale = New Valetransferencia()

        VarIdCliente = TxtIdCliente.Text.Trim()
        VarIdValeTrans = TxtNumIdValTrans.Text.Trim()

        vale.saveFileDialog = SaveFileDialog1
        vale.ImprimirPDF = True
        vale.PrepararInfo()

    End Sub

End Class
