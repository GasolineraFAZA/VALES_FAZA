Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports EncriptarDesencriptar

Public Class FrmNuevoArt
    Public Property location As Point
    Public Property size As Size

    Dim strconexion As String

    Dim Contenido As PrintPageEventArgs
    Dim WithEvents Documento As New PrintDocument
    Dim impresora As New PrintDialog

    Private Sub codigo()
        Dim cnn As New SqlConnection
        Dim com As String
        Dim datos As New DataSet
        Dim da As SqlDataAdapter
        Dim valor As Double



        cnn.ConnectionString = "Server=FAZASERVER\SQLEXPRESS;DataBase=GRUPO_FAZA_PRUEBA;user id= sa; password= faza.2014"
        cnn.Open()

        'BUSCAR EL ULTIMO CODIGO DE LA TABLA Y HACER EL AUTO INCREMENTO DEL CODIGO

        com = "select TOP 1 * from ARTICULOS order by codigo desc"
        da = New SqlDataAdapter(com, cnn)
        da.Fill(datos, "ARTICULOS")

        If datos.Tables(0).Rows.Count() = 0 Then
            TxtCodigo.Text = 0
            valor = CDbl(TxtCodigo.Text)
            valor = valor + 1
            TxtCodigo.Text = Format(valor, "000##")
            TxtNombreArt.Focus()
        Else
            Dim dr As DataRow
            dr = datos.Tables(0).Rows(0)
            TxtCodigo.Text = dr("codigo").ToString
            valor = CDbl(TxtCodigo.Text)
            valor = valor + 1
            TxtCodigo.Text = Format(valor, "000##")
            TxtCodigo.Enabled = False
            TxtNombreArt.Focus()
        End If

        cnn.Close()
    End Sub
    Private Sub limpiar_controles()

        TxtCapacidad.Text = ""
        TxtCausaSuspension.Text = ""
        TxtComponente1.Text = ""
        TxtComponente2.Text = ""
        TxtComponente3.Text = ""
        TxtComponente4.Text = ""
        TxtComponente5.Text = ""
        TxtComponenteOdo1.Text = ""
        TxtComponenteOdo2.Text = ""
        TxtComponenteOdo3.Text = ""
        TxtComponenteOdo4.Text = ""
        TxtComponenteOdo5.Text = ""
        TxtCosto.Text = ""
        TxtIva.Text = ""
        TxtMedidas.Text = ""
        TxtNombreArt.Text = ""
        TxtNumSerie.Text = ""
        TxtTiempoVidaUtilGral.Text = ""
        TxtTotal.Text = ""
        TxtTvuComp1.Text = ""
        TxtTvuComp2.Text = ""
        TxtTvuComp3.Text = ""
        TxtTvuComp4.Text = ""
        TxtTvuComp5.Text = ""
        TxtTvuCompOdo1.Text = ""
        TxtTvuCompOdo2.Text = ""
        TxtTvuCompOdo3.Text = ""
        TxtTvuCompOdo4.Text = ""
        TxtTvuCompOdo5.Text = ""
        CboAlmacen.Text = ""
        CboEstatusArt.Text = ""
        CboLineaArt.Text = ""
        CboProveedor.Text = ""
        DtpFechaAdq.Value = Now
        DtpFechaIniOps.Value = Now
        DtpFechaSuspension.Value = Now
        TxtNombreArt.Focus()
    End Sub
    Private Sub Configurar()
        impresora.Document = Documento
        impresora.ShowDialog()
        Documento.PrinterSettings = impresora.PrinterSettings
    End Sub
    Private Sub LlenarCombos()
        Try
            Dim cnn As New SqlConnection
            Dim com As String
            Dim datos As New DataSet
            Dim da As SqlDataAdapter
            Dim valor As Double



            cnn.ConnectionString = "Server=FAZASERVER\SQLEXPRESS;DataBase=GRUPO_FAZA_PRUEBA;user id= sa; password= faza.2014"
            cnn.Open()



            cnn.Close()

            'CARGAR DATOS DE LINEAS DE ARTICULOS
            Dim dt As New DataTable
            Dim da2 As New SqlDataAdapter
            Dim cmd As New SqlCommand
            cnn.Open()

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select nombre from lineas_articulos"
                .Connection = cnn
            End With

            da2.SelectCommand = cmd
            dt = New DataTable
            da2.Fill(dt)
            With CboLineaArt
                .DataSource = dt
                .DisplayMember = "nombre"
                .Text = ""
            End With
            cnn.Close()

            'CARGAR DATOS DE PROVEEDOR
            Dim dt2 As New DataTable
            Dim da3 As New SqlDataAdapter
            Dim cmd2 As New SqlCommand
            cnn.Open()

            With cmd2
                .CommandType = CommandType.Text
                .CommandText = "select nombre from proveedores"
                .Connection = cnn
            End With

            da3.SelectCommand = cmd2
            dt2 = New DataTable
            da3.Fill(dt2)
            With CboProveedor
                .DataSource = dt2
                .DisplayMember = "nombre"
                .Text = ""
            End With
            cnn.Close()

            'CARGAR DATOS DE ALMACEN
            Dim dt3 As New DataTable
            Dim da4 As New SqlDataAdapter
            Dim cmd3 As New SqlCommand
            cnn.Open()

            With cmd3
                .CommandType = CommandType.Text
                .CommandText = "select nombre from almacenes"
                .Connection = cnn
            End With

            da4.SelectCommand = cmd3
            dt3 = New DataTable
            da4.Fill(dt3)
            With CboAlmacen
                .DataSource = dt3
                .DisplayMember = "nombre"
                .Text = ""
            End With
            cnn.Close()

            'LIMPIAMOS CAJAS DE TEXTO
            'limpiar_controles()



            cnn.Close()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Documento_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Documento.PrintPage
        Contenido = e
        Contenido.Graphics.DrawString("*" & Me.TxtCodigo.Text & "*", New Font("3 of 9 Barcode", 14), Brushes.Black, 50, 300)
        Contenido.Graphics.DrawString(Me.TxtCodigo.Text, New Font("Arial", 7), Brushes.Black, 90, 315)
        TextBox1.Text = TxtCodigo.Text

        Contenido.HasMorePages = False
    End Sub

    Private Sub BarraDeHerramientasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeHerramientasToolStripMenuItem.Click
        If BarraDeHerramientasToolStripMenuItem.Checked = True Then
            BarraDeHerramientasToolStripMenuItem.Checked = False
            MenuStrip1.Visible = False
            GroupBox1.Location = New Point(2, 24)
            Dim sz As New System.Drawing.Size(GroupBox1.Width + 0, GroupBox1.Height + 28)
            GroupBox1.Size = sz

        Else

            BarraDeHerramientasToolStripMenuItem.Checked = True
            MenuStrip1.Visible = True
            GroupBox1.Location = New Point(2, 52)
            Dim sz As New System.Drawing.Size(GroupBox1.Width + 0, GroupBox1.Height - 28)
            GroupBox1.Size = sz

        End If
    End Sub
    Private Sub BtnGenCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenCodigo.Click
        Configurar()
        Documento.Print()
    End Sub
    Private Sub FrmNuevoArt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim EncrDesencr As New EncriptacionDescencriptacion

            strconexion = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)
            Dim cnn As New SqlConnection
            Dim com As String
            Dim datos As New DataSet
            Dim da As SqlDataAdapter
            Dim valor As Double

            If Bandera = 1 Then
                limpiar_controles()
                codigo()
                Bandera = 0

            Else
                If NombreArti = "" Then
                    cnn.ConnectionString = strconexion
                    cnn.Open()

                    'BUSCAR EL ULTIMO CODIGO DE LA TABLA Y HACER EL AUTO INCREMENTO DEL CODIGO

                    com = "select TOP 1 * from ARTICULOS order by codigo desc"
                    da = New SqlDataAdapter(com, cnn)
                    da.Fill(datos, "ARTICULOS")

                    If datos.Tables(0).Rows.Count() = 0 Then
                        TxtCodigo.Text = 0
                        valor = CDbl(TxtCodigo.Text)
                        valor = valor + 1
                        TxtCodigo.Text = Format(valor, "000##")
                        TxtNombreArt.Focus()
                    Else
                        Dim dr As DataRow
                        dr = datos.Tables(0).Rows(0)
                        TxtCodigo.Text = dr("codigo").ToString
                        valor = CDbl(TxtCodigo.Text)
                        valor = valor + 1
                        TxtCodigo.Text = Format(valor, "000##")
                        TxtCodigo.Enabled = False
                        TxtNombreArt.Focus()
                    End If

                    cnn.Close()

                    'CARGAR DATOS DE LINEAS DE ARTICULOS
                    Dim dt As New DataTable
                    Dim da2 As New SqlDataAdapter
                    Dim cmd As New SqlCommand
                    cnn.Open()

                    With cmd
                        .CommandType = CommandType.Text
                        .CommandText = "select nombre from lineas_articulos"
                        .Connection = cnn
                    End With

                    da2.SelectCommand = cmd
                    dt = New DataTable
                    da2.Fill(dt)
                    With CboLineaArt
                        .DataSource = dt
                        .DisplayMember = "nombre"
                        .Text = ""
                    End With
                    cnn.Close()

                    'CARGAR DATOS DE PROVEEDOR
                    Dim dt2 As New DataTable
                    Dim da3 As New SqlDataAdapter
                    Dim cmd2 As New SqlCommand
                    cnn.Open()

                    With cmd2
                        .CommandType = CommandType.Text
                        .CommandText = "select nombre from proveedores"
                        .Connection = cnn
                    End With

                    da3.SelectCommand = cmd2
                    dt2 = New DataTable
                    da3.Fill(dt2)
                    With CboProveedor
                        .DataSource = dt2
                        .DisplayMember = "nombre"
                        .Text = ""
                    End With
                    cnn.Close()

                    'CARGAR DATOS DE ALMACEN
                    Dim dt3 As New DataTable
                    Dim da4 As New SqlDataAdapter
                    Dim cmd3 As New SqlCommand
                    cnn.Open()

                    With cmd3
                        .CommandType = CommandType.Text
                        .CommandText = "select nombre from almacenes"
                        .Connection = cnn
                    End With

                    da4.SelectCommand = cmd3
                    dt3 = New DataTable
                    da4.Fill(dt3)
                    With CboAlmacen
                        .DataSource = dt3
                        .DisplayMember = "nombre"
                        .Text = ""
                    End With
                    cnn.Close()

                    'LIMPIAMOS CAJAS DE TEXTO
                    limpiar_controles()
                Else


                    TxtNombreArt.Text = NombreArti
                    cnn.ConnectionString = strconexion

                    'PASAN LOS DATOS DEL ARTICULO
                    Dim sql As String = "select * from articulos where nombre='" & TxtNombreArt.Text & "'"
                    Dim cmd As New SqlCommand(sql, cnn)
                    Dim odr As SqlDataReader
                    cnn.Open()

                    odr = cmd.ExecuteReader()
                    If odr.Read() Then
                        TxtCodigo.Text = odr.Item("codigo").ToString()
                        CboLineaArt.Text = odr.Item("linea_articulo").ToString()
                        TxtNumSerie.Text = odr.Item("num_serie").ToString()
                        TxtCapacidad.Text = odr.Item("capacidad").ToString()
                        TxtMedidas.Text = odr.Item("medidas").ToString()
                        CboProveedor.Text = odr.Item("proveedor").ToString()
                        DtpFechaAdq.Value = odr.Item("fecha_adquisicion").ToString()
                        DtpFechaIniOps.Value = odr.Item("fecha_inicio_operaciones").ToString()
                        TxtCosto.Text = odr.Item("costo").ToString()
                        TxtIva.Text = odr.Item("iva").ToString()
                        TxtTotal.Text = odr.Item("total").ToString()
                        CboAlmacen.Text = odr.Item("almacen").ToString()
                        TxtTiempoVidaUtilGral.Text = odr.Item("tiempo_vida_gral").ToString()
                        CboEstatusArt.Text = odr.Item("estatus_articulo").ToString()
                        DtpFechaSuspension.Value = odr.Item("fecha_suspencion").ToString()
                        TxtCausaSuspension.Text = odr.Item("causa_suspencion").ToString()
                    End If

                    TsmGuardarCerrar.Enabled = False
                    TsmGuardarNuevo.Enabled = False

                    odr.Close()
                    cnn.Close()

                End If

                Dim sql_2 As String = "select * from tiempo_vida where codigo_articulo='" & TxtCodigo.Text & "'"
                Dim cmd_2 As New SqlCommand(sql_2, cnn)
                Dim odr_2 As SqlDataReader
                cnn.Open()

                odr_2 = cmd_2.ExecuteReader()
                If odr_2.Read() Then
                    TxtComponente1.Text = odr_2.Item("componente1_tiempo").ToString()
                    TxtComponente2.Text = odr_2.Item("componente2_tiempo").ToString()
                    TxtComponente3.Text = odr_2.Item("componente3_tiempo").ToString()
                    TxtComponente4.Text = odr_2.Item("componente4_tiempo").ToString()
                    TxtComponente5.Text = odr_2.Item("componente5_tiempo").ToString()
                    TxtTvuComp1.Text = odr_2.Item("tiempo_componente1").ToString()
                    TxtTvuComp2.Text = odr_2.Item("tiempo_componente2").ToString()
                    TxtTvuComp3.Text = odr_2.Item("tiempo_componente3").ToString()
                    TxtTvuComp4.Text = odr_2.Item("tiempo_componente4").ToString()
                    TxtTvuComp5.Text = odr_2.Item("tiempo_componente5").ToString()
                    TxtComponenteOdo1.Text = odr_2.Item("componente1_odometro").ToString()
                    TxtComponenteOdo2.Text = odr_2.Item("componente2_odometro").ToString()
                    TxtComponenteOdo3.Text = odr_2.Item("componente3_odometro").ToString()
                    TxtComponenteOdo4.Text = odr_2.Item("componente4_odometro").ToString()
                    TxtComponenteOdo5.Text = odr_2.Item("componente5_odometro").ToString()
                    TxtTvuCompOdo1.Text = odr_2.Item("odometro1").ToString()
                    TxtTvuCompOdo2.Text = odr_2.Item("odometro2").ToString()
                    TxtTvuCompOdo3.Text = odr_2.Item("odometro3").ToString()
                    TxtTvuCompOdo4.Text = odr_2.Item("odometro4").ToString()
                    TxtTvuCompOdo5.Text = odr_2.Item("odometro5").ToString()
                    odr_2.Close()
                    cnn.Close()
                End If
                BtnGenCodigo.Enabled = False
            End If

            'TsmEliminar.Select()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub
    Private Sub CboAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboAlmacen.SelectedValueChanged
        TxtNombreArt.Focus()
    End Sub
    Private Sub TsmGuardarCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmGuardarCerrar.Click
        Try

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim data As New DataSet

            'DAMOS DE ALTA UN NUEVO ARTICULO
            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into articulos(codigo,nombre,linea_articulo,num_serie,capacidad,medidas,proveedor,fecha_adquisicion,fecha_inicio_operaciones,costo,iva,total,almacen,tiempo_vida_gral,estatus_articulo,fecha_suspencion,causa_suspencion) " &
            "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "', '" & CboLineaArt.Text & "', '" & TxtNumSerie.Text & "" &
            "', '" & TxtCapacidad.Text & "', '" & TxtMedidas.Text & "', '" & CboProveedor.Text & "', '" & DtpFechaAdq.Value & "', '" & DtpFechaIniOps.Value & "', '" & TxtCosto.Text & "" &
            "', '" & TxtIva.Text & "', '" & TxtTotal.Text & "', '" & CboAlmacen.Text & "', '" & TxtTiempoVidaUtilGral.Text & "', '" & CboEstatusArt.Text & "', '" & DtpFechaSuspension.Value & "', '" & TxtCausaSuspension.Text & "')"
            com.ExecuteNonQuery()

            'DAMOS DE ALTA LOS COMPONENTE DEL ARTICULO
            com2.Connection = cnn
            com2.CommandText = "insert into tiempo_vida(codigo_articulo,nombre_articulo,componente1_tiempo,componente2_tiempo,componente3_tiempo,componente4_tiempo,componente5_tiempo,tiempo_componente1,tiempo_componente2,tiempo_componente3,tiempo_componente4,tiempo_componente5,componente1_odometro,componente2_odometro,componente3_odometro,componente4_odometro,componente5_odometro,odometro1,odometro2,odometro3,odometro4,odometro5)" &
            "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "','" & TxtComponente1.Text & "" &
            "', '" & TxtComponente2.Text & "', '" & TxtComponente3.Text & "', '" & TxtComponente4.Text & "', '" & TxtComponente5.Text & "', '" & TxtTvuComp1.Text & "" &
            "', '" & TxtTvuComp2.Text & "', '" & TxtTvuComp3.Text & "', '" & TxtTvuComp4.Text & "', '" & TxtTvuComp5.Text & "','" & TxtComponenteOdo1.Text & "', '" & TxtComponenteOdo2.Text & "" &
            "', '" & TxtComponenteOdo3.Text & "', '" & TxtComponenteOdo4.Text & "', '" & TxtComponenteOdo5.Text & "', '" & TxtTvuCompOdo1.Text & "', '" & TxtTvuCompOdo2.Text & "" &
            "', '" & TxtTvuCompOdo3.Text & "', '" & TxtTvuCompOdo4.Text & "', '" & TxtTvuCompOdo5.Text & "')"
            com2.ExecuteNonQuery()

            cnn.Close()

            'LIMPIAMOS LAS CAJAS DE TEXTO
            limpiar_controles()

            Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CboLineaArt_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboLineaArt.SelectedValueChanged
        TxtNumSerie.Focus()

    End Sub

    Private Sub TsmGuardarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmGuardarNuevo.Click
        Try
            If banderaedit = 1 Then
                Dim resp_edit As MsgBoxResult
                resp_edit = MsgBox("Desea guardar los cambios en el registro?", MsgBoxStyle.YesNo)

                If resp_edit = MsgBoxResult.Yes Then
                    Dim cnn_edit As New SqlConnection
                    Dim com_edit As New SqlCommand
                    Dim com_edit2 As New SqlCommand

                    'CODIGO PARA MODIFICAR LOS DATOS DEL ARTIUCLO
                    cnn_edit.ConnectionString = strconexion
                    cnn_edit.Open()
                    com_edit.Connection = cnn_edit
                    com_edit.CommandText = "update articulos set codigo='" + TxtCodigo.Text + "',nombre='" + TxtNombreArt.Text + "',linea_articulo='" + CboLineaArt.Text + "',num_serie='" + TxtNumSerie.Text + "',capacidad='" + TxtCapacidad.Text + "" &
                    "',medidas='" + TxtMedidas.Text + "',proveedor='" + CboProveedor.Text + "',fecha_adquisicion='" + DtpFechaAdq.Value + "',fecha_inicio_operaciones='" + DtpFechaIniOps.Value + "',costo='" + TxtCosto.Text + "',iva='" + TxtIva.Text + "" &
                    "',total='" + TxtTotal.Text + "',almacen='" + CboAlmacen.Text + "',tiempo_vida_gral='" + TxtTiempoVidaUtilGral.Text + "',estatus_articulo ='" + CboEstatusArt.Text + "',fecha_suspencion='" + DtpFechaSuspension.Value + "', causa_suspencion='" + TxtCausaSuspension.Text + "'"
                    com_edit.ExecuteNonQuery()


                    'CODIGO PARA MODIFICAR LOS DATOS DE LOS COMPONENTES DEL ARTICULO
                    com_edit2.Connection = cnn_edit
                    com_edit2.CommandText = "update tiempo_vida set codigo_articulo= '" + TxtCodigo.Text + "', nombre_articulo='" + TxtNombreArt.Text + "', componente1_tiempo='" + TxtComponente1.Text + "" &
                    "', componente2_tiempo='" + TxtComponente2.Text + "', componente3_tiempo='" + TxtComponente3.Text + "',componente4_tiempo='" + TxtComponente4.Text + "', componente5_tiempo='" + TxtComponente5.Text + "" &
                    "', tiempo_componente1='" + TxtTvuComp1.Text + "', tiempo_componente2='" + TxtTvuComp2.Text + "', tiempo_componente3='" + TxtTvuComp3.Text + "',tiempo_componente4='" + TxtTvuComp4.Text + "" &
                    "', tiempo_componente5='" + TxtTvuComp5.Text + "', componente1_odometro='" + TxtComponenteOdo1.Text + "', componente2_odometro='" + TxtComponenteOdo2.Text + "',componente3_odometro='" + TxtComponenteOdo3.Text + "" &
                    "', componente4_odometro='" + TxtComponenteOdo4.Text + "', componente5_odometro='" + TxtComponenteOdo5.Text + "',odometro1='" + TxtTvuCompOdo1.Text + "', odometro2='" + TxtTvuCompOdo2.Text + "" &
                    "', odometro3='" + TxtTvuCompOdo3.Text + "', odometro4='" + TxtTvuCompOdo4.Text + "', odometro5='" + TxtTvuCompOdo5.Text + "'"
                    com_edit2.ExecuteNonQuery()
                    cnn_edit.Close()
                    Bandera = 0
                    limpiar_controles()


                Else
                    limpiar_controles()
                    Bandera = 0
                    Close()

                End If
            Else

            End If

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim data As New DataSet

            If banderaedit = 0 Then

            Else
                'DAMOS DE ALTA UN NUEVO ARTICULO
                cnn.ConnectionString = strconexion
                cnn.Open()
                com.Connection = cnn
                com.CommandText = "insert into articulos(codigo,nombre,linea_articulo,num_serie,capacidad,medidas,proveedor,fecha_adquisicion,fecha_inicio_operaciones,costo,iva,total,almacen,tiempo_vida_gral,estatus_articulo,fecha_suspencion,causa_suspencion) " &
                "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "', '" & CboLineaArt.Text & "', '" & TxtNumSerie.Text & "" &
                "', '" & TxtCapacidad.Text & "', '" & TxtMedidas.Text & "', '" & CboProveedor.Text & "', '" & DtpFechaAdq.Value & "', '" & DtpFechaIniOps.Value & "', '" & TxtCosto.Text & "" &
                "', '" & TxtIva.Text & "', '" & TxtTotal.Text & "', '" & CboAlmacen.Text & "', '" & TxtTiempoVidaUtilGral.Text & "', '" & CboEstatusArt.Text & "', '" & DtpFechaSuspension.Value & "', '" & TxtCausaSuspension.Text & "')"
                com.ExecuteNonQuery()

                'DAMOS DE ALTA LOS COMPONENTE DEL ARTICULO
                com2.Connection = cnn
                com2.CommandText = "insert into tiempo_vida(codigo_articulo,nombre_articulo,componente1_tiempo,componente2_tiempo,componente3_tiempo,componente4_tiempo,componente5_tiempo,tiempo_componente1,tiempo_componente2,tiempo_componente3,tiempo_componente4,tiempo_componente5,componente1_odometro,componente2_odometro,componente3_odometro,componente4_odometro,componente5_odometro,odometro1,odometro2,odometro3,odometro4,odometro5)" &
                "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "','" & TxtComponente1.Text & "" &
                "', '" & TxtComponente2.Text & "', '" & TxtComponente3.Text & "', '" & TxtComponente4.Text & "', '" & TxtComponente5.Text & "', '" & TxtTvuComp1.Text & "" &
                "', '" & TxtTvuComp2.Text & "', '" & TxtTvuComp3.Text & "', '" & TxtTvuComp4.Text & "', '" & TxtTvuComp5.Text & "','" & TxtComponenteOdo1.Text & "', '" & TxtComponenteOdo2.Text & "" &
                "', '" & TxtComponenteOdo3.Text & "', '" & TxtComponenteOdo4.Text & "', '" & TxtComponenteOdo5.Text & "', '" & TxtTvuCompOdo1.Text & "', '" & TxtTvuCompOdo2.Text & "" &
                "', '" & TxtTvuCompOdo3.Text & "', '" & TxtTvuCompOdo4.Text & "', '" & TxtTvuCompOdo5.Text & "')"
                com2.ExecuteNonQuery()

                cnn.Close()

                'LIMPIAMOS LAS CAJAS DE TEXTO
                limpiar_controles()
                'BUSCA EL ULTIMO CODIGO REGISTRADO
                codigo()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmCancelar.Click
        limpiar_controles()
        codigo()
        LlenarCombos()

        TsmGuardarCerrar.Enabled = True
        TsmGuardarNuevo.Enabled = True

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYCerrarToolStripMenuItem.Click
        Try

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim data As New DataSet

            'DAMOS DE ALTA UN NUEVO ARTICULO
            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into articulos(codigo,nombre,linea_articulo,num_serie,capacidad,medidas,proveedor,fecha_adquisicion,fecha_inicio_operaciones,costo,iva,total,almacen,tiempo_vida_gral,estatus_articulo,fecha_suspencion,causa_suspencion) " &
            "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "', '" & CboLineaArt.Text & "', '" & TxtNumSerie.Text & "" &
            "', '" & TxtCapacidad.Text & "', '" & TxtMedidas.Text & "', '" & CboProveedor.Text & "', '" & DtpFechaAdq.Value & "', '" & DtpFechaIniOps.Value & "', '" & TxtCosto.Text & "" &
            "', '" & TxtIva.Text & "', '" & TxtTotal.Text & "', '" & CboAlmacen.Text & "', '" & TxtTiempoVidaUtilGral.Text & "', '" & CboEstatusArt.Text & "', '" & DtpFechaSuspension.Value & "', '" & TxtCausaSuspension.Text & "')"
            com.ExecuteNonQuery()

            'DAMOS DE ALTA LOS COMPONENTE DEL ARTICULO
            com2.Connection = cnn
            com2.CommandText = "insert into tiempo_vida(codigo_articulo,nombre_articulo,componente1_tiempo,componente2_tiempo,componente3_tiempo,componente4_tiempo,componente5_tiempo,tiempo_componente1,tiempo_componente2,tiempo_componente3,tiempo_componente4,tiempo_componente5,componente1_odometro,componente2_odometro,componente3_odometro,componente4_odometro,componente5_odometro,odometro1,odometro2,odometro3,odometro4,odometro5)" &
            "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "','" & TxtComponente1.Text & "" &
            "', '" & TxtComponente2.Text & "', '" & TxtComponente3.Text & "', '" & TxtComponente4.Text & "', '" & TxtComponente5.Text & "', '" & TxtTvuComp1.Text & "" &
            "', '" & TxtTvuComp2.Text & "', '" & TxtTvuComp3.Text & "', '" & TxtTvuComp4.Text & "', '" & TxtTvuComp5.Text & "','" & TxtComponenteOdo1.Text & "', '" & TxtComponenteOdo2.Text & "" &
            "', '" & TxtComponenteOdo3.Text & "', '" & TxtComponenteOdo4.Text & "', '" & TxtComponenteOdo5.Text & "', '" & TxtTvuCompOdo1.Text & "', '" & TxtTvuCompOdo2.Text & "" &
            "', '" & TxtTvuCompOdo3.Text & "', '" & TxtTvuCompOdo4.Text & "', '" & TxtTvuCompOdo5.Text & "')"
            com2.ExecuteNonQuery()

            cnn.Close()

            'LIMPIAMOS LAS CAJAS DE TEXTO
            limpiar_controles()

            Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYNuevoToolStripMenuItem.Click
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim data As New DataSet

            'DAMOS DE ALTA UN NUEVO ARTICULO
            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into articulos(codigo,nombre,linea_articulo,num_serie,capacidad,medidas,proveedor,fecha_adquisicion,fecha_inicio_operaciones,costo,iva,total,almacen,tiempo_vida_gral,estatus_articulo,fecha_suspencion,causa_suspencion) " &
            "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "', '" & CboLineaArt.Text & "', '" & TxtNumSerie.Text & "" &
            "', '" & TxtCapacidad.Text & "', '" & TxtMedidas.Text & "', '" & CboProveedor.Text & "', '" & DtpFechaAdq.Value & "', '" & DtpFechaIniOps.Value & "', '" & TxtCosto.Text & "" &
            "', '" & TxtIva.Text & "', '" & TxtTotal.Text & "', '" & CboAlmacen.Text & "', '" & TxtTiempoVidaUtilGral.Text & "', '" & CboEstatusArt.Text & "', '" & DtpFechaSuspension.Value & "', '" & TxtCausaSuspension.Text & "')"
            com.ExecuteNonQuery()

            'DAMOS DE ALTA LOS COMPONENTE DEL ARTICULO
            com2.Connection = cnn
            com2.CommandText = "insert into tiempo_vida(codigo_articulo,nombre_articulo,componente1_tiempo,componente2_tiempo,componente3_tiempo,componente4_tiempo,componente5_tiempo,tiempo_componente1,tiempo_componente2,tiempo_componente3,tiempo_componente4,tiempo_componente5,componente1_odometro,componente2_odometro,componente3_odometro,componente4_odometro,componente5_odometro,odometro1,odometro2,odometro3,odometro4,odometro5)" &
            "values ('" & TxtCodigo.Text & "', '" & TxtNombreArt.Text & "','" & TxtComponente1.Text & "" &
            "', '" & TxtComponente2.Text & "', '" & TxtComponente3.Text & "', '" & TxtComponente4.Text & "', '" & TxtComponente5.Text & "', '" & TxtTvuComp1.Text & "" &
            "', '" & TxtTvuComp2.Text & "', '" & TxtTvuComp3.Text & "', '" & TxtTvuComp4.Text & "', '" & TxtTvuComp5.Text & "','" & TxtComponenteOdo1.Text & "', '" & TxtComponenteOdo2.Text & "" &
            "', '" & TxtComponenteOdo3.Text & "', '" & TxtComponenteOdo4.Text & "', '" & TxtComponenteOdo5.Text & "', '" & TxtTvuCompOdo1.Text & "', '" & TxtTvuCompOdo2.Text & "" &
            "', '" & TxtTvuCompOdo3.Text & "', '" & TxtTvuCompOdo4.Text & "', '" & TxtTvuCompOdo5.Text & "')"
            com2.ExecuteNonQuery()

            cnn.Close()

            'LIMPIAMOS LAS CAJAS DE TEXTO
            limpiar_controles()
            'BUSCA EL ULTIMO CODIGO REGISTRADO
            codigo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        limpiar_controles()
        codigo()
    End Sub


    Private Sub TsmEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmEliminar.Click
        Try
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Desea eliminar el registro de forma permante?", MsgBoxStyle.YesNo)
            If respuesta = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand


                cnn.ConnectionString = strconexion
                cnn.Open()
                com.Connection = cnn
                com2.Connection = cnn
                com.CommandText = "delete articulos where codigo= '" & TxtCodigo.Text & "'"
                com2.CommandText = "delete tiempo_vida where codigo= '" & TxtCodigo.Text & "'"
                com.ExecuteNonQuery()
                com2.ExecuteNonQuery()
                cnn.Close()
                limpiar_controles()
                codigo()



            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub


    Private Sub TsmEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmEditar.Click
        Try
            TxtNombreArt.ReadOnly = False
            TxtNumSerie.ReadOnly = False
            TxtCapacidad.ReadOnly = False
            TxtMedidas.ReadOnly = False
            TxtCosto.ReadOnly = False
            TxtIva.ReadOnly = False
            TxtTotal.ReadOnly = False
            TxtTiempoVidaUtilGral.ReadOnly = False
            TxtCausaSuspension.ReadOnly = False
            TxtComponente1.ReadOnly = False
            TxtComponente2.ReadOnly = False
            TxtComponente3.ReadOnly = False
            TxtComponente4.ReadOnly = False
            TxtComponente5.ReadOnly = False
            TxtTvuComp1.ReadOnly = False
            TxtTvuComp2.ReadOnly = False
            TxtTvuComp3.ReadOnly = False
            TxtTvuComp4.ReadOnly = False
            TxtTvuComp5.ReadOnly = False
            TxtComponenteOdo1.ReadOnly = False
            TxtComponenteOdo2.ReadOnly = False
            TxtComponenteOdo3.ReadOnly = False
            TxtComponenteOdo4.ReadOnly = False
            TxtComponenteOdo5.ReadOnly = False
            TxtTvuCompOdo1.ReadOnly = False
            TxtTvuCompOdo2.ReadOnly = False
            TxtTvuCompOdo3.ReadOnly = False
            TxtTvuCompOdo4.ReadOnly = False
            TxtTvuCompOdo5.ReadOnly = False
            TsmGuardarNuevo.Enabled = True


            TxtNombreArt.Focus()
            banderaedit = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Class
