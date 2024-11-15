Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports EncriptarDesencriptar

Public Class FrmPeriodoVista
    Dim strconexion As String

    Private Sub BtnAceptarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptarPeriodo.Click

        Try

            If VarperVista = 2 Then
                FecIni = Format(DtpFechaInicial.Value, "short date")
                FecFin = Format(DtpFechaFinal.Value, "short date")




                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()


                com2.Connection = cnn
                com2.CommandText = "select IdValeCred,Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_credito where Fecha>= '" & FecIni & "' and Fecha<='" & FecFin & "'"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                frmMenu.DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()

                frmMenu.DgvGeneral.Columns(0).Visible = False
                frmMenu.DgvGeneral.Columns(1).HeaderText = "Fecha de captura"
                frmMenu.DgvGeneral.Columns(2).HeaderText = "Numero de cliente"
                frmMenu.DgvGeneral.Columns(3).HeaderText = "Nombre de cliente"
                frmMenu.DgvGeneral.Columns(4).HeaderText = "Folio inicial"
                frmMenu.DgvGeneral.Columns(5).HeaderText = "Folio final"
                Me.Close()

            End If

            If VarperVista = 3 Then
                FecIni = Format(DtpFechaInicial.Value, "short date")
                FecFin = Format(DtpFechaFinal.Value, "short date")

                Dim cnn As New SqlConnection
                Dim com As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()


                com2.Connection = cnn
                com2.CommandText = "select Fecha,Num_cliente,Nombre_cliente,folio_inicial,folio_final from Vales_anexo where Fecha>='" & FecIni & "' and Fecha<='" & FecFin & "'"
                Dim base As New SqlDataAdapter(com2)
                base.Fill(datos)
                frmMenu.DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()

                frmMenu.DgvGeneral.Columns(0).HeaderText = "Fecha de captura"
                frmMenu.DgvGeneral.Columns(1).HeaderText = "Numero de cliente"
                frmMenu.DgvGeneral.Columns(2).HeaderText = "Nombre de cliente"
                frmMenu.DgvGeneral.Columns(3).HeaderText = "Folio inicial"
                frmMenu.DgvGeneral.Columns(4).HeaderText = "Folio final"
                Me.Close()

            End If

            If VarperVista = 4 Then

                FecIni = Format(DtpFechaInicial.Value, "short date")
                FecFin = Format(DtpFechaFinal.Value, "short date")

                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim datos As New DataSet

                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn

                cmd.CommandText = "Select IdValeTrans,Num_cliente,Nombre_cliente,Importe_trans,Num_movimiento,Fecha_trans,IdCarga,Sucursal,Cantidad,Producto,Importe,Codigo,Fecha_captura from Vales_transferencia where Fecha_captura>= '" & FecIni & "' and Fecha_captura<='" & FecFin & "'"
                Dim base As New SqlDataAdapter(cmd)
                base.Fill(datos)
                frmMenu.DgvGeneral.DataSource = datos.Tables(0)
                cnn.Close()

                Me.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DtpFechaFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFechaFinal.ValueChanged
        BtnAceptarPeriodo.Enabled = True

    End Sub

    Private Sub BtnCancelarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPeriodo.Click
        Me.Close()

    End Sub

    Private Sub FrmPeriodoVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim EncrDesencr As New EncriptacionDescencriptacion

        strconexion = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)
        'Dim desde As DateTime = CDate(ConfigurationManager.AppSettings("desde").ToString)
        'Dim hasta As DateTime = CDate(ConfigurationManager.AppSettings("hasta").ToString)
        'DtpFechaInicial.Value = desde
        'DtpFechaFinal.Value = hasta
    End Sub
End Class