Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports EncriptarDesencriptar

Public Class FrmCatalogoClientes
    Dim strconexion As String
    Private Sub limpiar_campos()
        TxtNombreCLiente.Text = ""
        TxtNumCliente.Text = ""
        CboTipoCliente.Text = ""
        TxtCodigo1.Text = ""
        TxtCodigo2.Text = ""
        TxtCodigo3.Text = ""
        TxtCodigo4.Text = ""
        TxtCodigo5.Text = ""
        TxtCodigo6.Text = ""
        TxtCodigo7.Text = ""
        TxtCodigo8.Text = ""
        TxtCodigo9.Text = ""
        TxtCodigo10.Text = ""
        TxtCodigo11.Text = ""
        TxtCodigo12.Text = ""
        tb13.Text = ""
        tb14.Text = ""
        tb15.Text = ""
        tb16.Text = ""

        TxtIdcliente.Text = ""
    End Sub

    Private Sub inhabiltarcampos()
        TxtNumCliente.ReadOnly = True
        TxtNombreCLiente.ReadOnly = True
        CboTipoCliente.Enabled = False

        TxtCodigo1.ReadOnly = True
        TxtCodigo2.ReadOnly = True
        TxtCodigo3.ReadOnly = True
        TxtCodigo4.ReadOnly = True
        TxtCodigo5.ReadOnly = True
        TxtCodigo6.ReadOnly = True
        TxtCodigo7.ReadOnly = True
        TxtCodigo8.ReadOnly = True
        TxtCodigo9.ReadOnly = True
        TxtCodigo10.ReadOnly = True
        TxtCodigo11.ReadOnly = True
        TxtCodigo12.ReadOnly = True
        tb13.ReadOnly = True
        tb14.ReadOnly = True
        tb15.ReadOnly = True
        tb16.ReadOnly = True

    End Sub

    Private Sub habilitarcampos()
        TxtNumCliente.ReadOnly = False
        TxtNombreCLiente.ReadOnly = False
        CboTipoCliente.Enabled = True

        TxtCodigo1.ReadOnly = False
        TxtCodigo2.ReadOnly = False
        TxtCodigo3.ReadOnly = False
        TxtCodigo4.ReadOnly = False
        TxtCodigo5.ReadOnly = False
        TxtCodigo6.ReadOnly = False
        TxtCodigo7.ReadOnly = False
        TxtCodigo8.ReadOnly = False
        TxtCodigo9.ReadOnly = False
        TxtCodigo10.ReadOnly = False
        TxtCodigo11.ReadOnly = False
        TxtCodigo12.ReadOnly = False
        tb13.ReadOnly = False
        tb14.ReadOnly = False
        tb15.ReadOnly = False
        tb16.ReadOnly = False
    End Sub


    Private Sub FrmCatalogoClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim EncrDesencr As New EncriptacionDescencriptacion

            strconexion = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)
            If VarDato = 1 Then
                TxtNumCliente.Text = NumCliente


                Dim cnn As New SqlConnection
                cnn.ConnectionString = strconexion
                Dim sql As String = "select IdCliente,Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12,Codigo13,Codigo14,Codigo15,Codigo16 from clientes where IdCLiente= '" & TxtNumCliente.Text & "'"
                Dim cmd As New SqlCommand(sql, cnn)
                Dim odr As SqlDataReader

                cnn.Open()
                odr = cmd.ExecuteReader()
                If odr.Read() Then
                    TxtNombreCLiente.Text = odr.Item("Nombre_cliente").ToString()
                    TxtNumCliente.Text = odr.Item("Num_cliente").ToString()
                    CboTipoCliente.Text = odr.Item("Tipo_cliente").ToString()
                    TxtCodigo1.Text = odr.Item("Codigo1").ToString()
                    TxtCodigo2.Text = odr.Item("Codigo2").ToString()
                    TxtCodigo3.Text = odr.Item("Codigo3").ToString()
                    TxtCodigo4.Text = odr.Item("Codigo4").ToString()
                    TxtCodigo5.Text = odr.Item("Codigo5").ToString()
                    TxtCodigo6.Text = odr.Item("Codigo6").ToString()
                    TxtCodigo7.Text = odr.Item("Codigo7").ToString()
                    TxtCodigo8.Text = odr.Item("Codigo8").ToString()
                    TxtCodigo9.Text = odr.Item("Codigo9").ToString()
                    TxtCodigo10.Text = odr.Item("Codigo10").ToString()
                    TxtCodigo11.Text = odr.Item("Codigo11").ToString()
                    TxtCodigo12.Text = odr.Item("Codigo12").ToString()
                    tb13.Text = odr.Item("Codigo13").ToString()
                    tb14.Text = odr.Item("Codigo14").ToString()
                    tb15.Text = odr.Item("Codigo15").ToString()
                    tb16.Text = odr.Item("Codigo16").ToString()
                    TxtIdcliente.Text = odr.Item("IdCliente").ToString()
                    TxtCodigo1.Text = Mid(TxtCodigo1.Text, 1, Len(TxtCodigo1.Text) - 1)
                    TxtCodigo2.Text = Mid(TxtCodigo2.Text, 1, Len(TxtCodigo2.Text) - 1)
                    TxtCodigo3.Text = Mid(TxtCodigo3.Text, 1, Len(TxtCodigo3.Text) - 1)
                    TxtCodigo4.Text = Mid(TxtCodigo4.Text, 1, Len(TxtCodigo4.Text) - 1)
                    TxtCodigo5.Text = Mid(TxtCodigo5.Text, 1, Len(TxtCodigo5.Text) - 1)
                    TxtCodigo6.Text = Mid(TxtCodigo6.Text, 1, Len(TxtCodigo6.Text) - 1)
                    TxtCodigo7.Text = Mid(TxtCodigo7.Text, 1, Len(TxtCodigo7.Text) - 1)
                    TxtCodigo8.Text = Mid(TxtCodigo8.Text, 1, Len(TxtCodigo8.Text) - 1)
                    TxtCodigo9.Text = Mid(TxtCodigo9.Text, 1, Len(TxtCodigo9.Text) - 1)
                    TxtCodigo10.Text = Mid(TxtCodigo10.Text, 1, Len(TxtCodigo10.Text) - 1)
                    TxtCodigo11.Text = Mid(TxtCodigo11.Text, 1, Len(TxtCodigo11.Text) - 1)
                    TxtCodigo12.Text = Mid(TxtCodigo12.Text, 1, Len(TxtCodigo12.Text) - 1)
                    tb13.Text = Mid(tb13.Text, 1, Len(tb13.Text) - 1)
                    tb14.Text = Mid(tb14.Text, 1, Len(tb14.Text) - 1)
                    tb15.Text = Mid(tb15.Text, 1, Len(tb15.Text) - 1)
                    tb16.Text = Mid(tb16.Text, 1, Len(tb16.Text) - 1)

                    TxtCodigo1.Text = Mid(TxtCodigo1.Text, 2)
                    TxtCodigo2.Text = Mid(TxtCodigo2.Text, 2)
                    TxtCodigo3.Text = Mid(TxtCodigo3.Text, 2)
                    TxtCodigo4.Text = Mid(TxtCodigo4.Text, 2)
                    TxtCodigo5.Text = Mid(TxtCodigo5.Text, 2)
                    TxtCodigo6.Text = Mid(TxtCodigo6.Text, 2)
                    TxtCodigo7.Text = Mid(TxtCodigo7.Text, 2)
                    TxtCodigo8.Text = Mid(TxtCodigo8.Text, 2)
                    TxtCodigo9.Text = Mid(TxtCodigo9.Text, 2)
                    TxtCodigo10.Text = Mid(TxtCodigo10.Text, 2)
                    TxtCodigo11.Text = Mid(TxtCodigo11.Text, 2)
                    TxtCodigo12.Text = Mid(TxtCodigo12.Text, 2)
                    tb13.Text = Mid(tb13.Text, 2)
                    tb14.Text = Mid(tb14.Text, 2)
                    tb15.Text = Mid(tb15.Text, 2)
                    tb16.Text = Mid(tb16.Text, 2)


                End If
                odr.Close()
                cnn.Close()

                TxtNumCliente.Focus()
                inhabiltarcampos()
                VarDato = 0
                EditarToolStripMenuItem2.Enabled = True
                EliminarToolStripMenuItem2.Enabled = True
                TsmEditar2.Enabled = True
                EliminarToolStripMenuItem3.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = False
                GuardarYCerrarToolStripMenuItem3.Enabled = False
                GuardarYNuevoToolStripMenuItem1.Enabled = False
                GuardarYNuevoToolStripMenuItem2.Enabled = False
                GuardarCambiosToolStripMenuItem4.Enabled = False
                GuardarCambiosToolStripMenuItem3.Enabled = False

            Else
                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False
                limpiar_campos()
                habilitarcampos()

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub GuardarYCerrarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TsmGuardarNueVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet
            Dim sql As String

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            sql = "insert into clientes(Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12) "
            sql &= "values('" & TxtNombreCLiente.Text & "', '" & TxtNumCliente.Text & "', '" & CboTipoCliente.Text & "', '*" & TxtCodigo1.Text & "*','*" & TxtCodigo2.Text & "*','*" & TxtCodigo3.Text & "*"
            sql &= "','*" & TxtCodigo4.Text & "*','*" & TxtCodigo5.Text & "*','*" & TxtCodigo6.Text & "*','*" & TxtCodigo7.Text & "*','*" & TxtCodigo8.Text & "*','*" & TxtCodigo9.Text & "*','*" & TxtCodigo10.Text & "*"
            sql &= "','*" & TxtCodigo11.Text & "*','*" & TxtCodigo12.Text & "*','*" & tb13.Text & "*','*" & tb14.Text & "*','*" & tb15.Text & "*','*" & tb16.Text & "*')"
            com.CommandText = sql
            com.ExecuteNonQuery()


            cnn.Close()
            limpiar_campos()
            TxtNumCliente.Focus()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar_campos()
        TxtNumCliente.Focus()
        EliminarToolStripMenuItem2.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True
        GuardarYNuevoToolStripMenuItem1.Enabled = True
        GuardarCambiosToolStripMenuItem3.Enabled = False
        NuevoToolStripMenuItem.Enabled = True
        EditarToolStripMenuItem2.Enabled = True

        TsmEditar2.Enabled = True
        EliminarToolStripMenuItem3.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True


        GuardarYCerrarToolStripMenuItem3.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem4.Enabled = False
        inhabiltarcampos()

    End Sub


    Private Sub GuardarYCerrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet
            Dim sql As String

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            sql = "insert into clientes(Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12) "
            sql &= "values('" & TxtNombreCLiente.Text & "', '" & TxtNumCliente.Text & "', '" & CboTipoCliente.Text & "', '*" & TxtCodigo1.Text & "*','*" & TxtCodigo2.Text & "*','*" & TxtCodigo3.Text & "*"
            sql &= "','*" & TxtCodigo4.Text & "*','*" & TxtCodigo5.Text & "*','*" & TxtCodigo6.Text & "*','*" & TxtCodigo7.Text & "*','*" & TxtCodigo8.Text & "*','*" & TxtCodigo9.Text & "*','*" & TxtCodigo10.Text & "*"
            sql &= "','*" & TxtCodigo11.Text & "*','*" & TxtCodigo12.Text & "*','*" & tb13.Text & "*','*" & tb14.Text & "*','*" & tb15.Text & "*','*" & tb16.Text & "*')"
            com.CommandText = sql
            com.ExecuteNonQuery()


            cnn.Close()
            limpiar_campos()
            Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TsmNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click, NuevoToolStripMenuItem.Click
        limpiar_campos()
        TxtNumCliente.Focus()
        'EliminarToolStripMenuItem2.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True
        GuardarYNuevoToolStripMenuItem1.Enabled = True
        GuardarCambiosToolStripMenuItem3.Enabled = False

        EditarToolStripMenuItem2.Enabled = False
        EliminarToolStripMenuItem2.Enabled = False
        TsmEditar2.Enabled = False
        EliminarToolStripMenuItem3.Enabled = False

        habilitarcampos()
    End Sub

    Private Sub TsmEditar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmEditar2.Click, EditarToolStripMenuItem3.Click
        EliminarToolStripMenuItem2.Enabled = False
        GuardarYCerrarToolStripMenuItem2.Enabled = False
        GuardarYNuevoToolStripMenuItem1.Enabled = False
        GuardarCambiosToolStripMenuItem3.Enabled = True

        NuevoToolStripMenuItem.Enabled = False
        EditarToolStripMenuItem2.Enabled = False

        TsmEditar2.Enabled = False
        EliminarToolStripMenuItem3.Enabled = False

        habilitarcampos()


        GuardarYCerrarToolStripMenuItem3.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem4.Enabled = True
    End Sub

    Private Sub TsmCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem3.Click, CancelarToolStripMenuItem3.Click
        limpiar_campos()
        TxtNumCliente.Focus()
        EliminarToolStripMenuItem2.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True
        GuardarYNuevoToolStripMenuItem1.Enabled = True
        GuardarCambiosToolStripMenuItem3.Enabled = False
        NuevoToolStripMenuItem.Enabled = True
        EditarToolStripMenuItem2.Enabled = True

        TsmEditar2.Enabled = True
        EliminarToolStripMenuItem3.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True


        GuardarYCerrarToolStripMenuItem3.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem4.Enabled = False

        EditarToolStripMenuItem2.Enabled = False
        EliminarToolStripMenuItem2.Enabled = False
        TsmEditar2.Enabled = False
        EliminarToolStripMenuItem3.Enabled = False

        ' habilitarCampos()
        inhabiltarcampos()
        Close()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub TxtCodigo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo1.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCodigo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo2.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCodigo3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo3.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCodigo4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo4.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCodigo5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo5.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub



    Private Sub TxtCodigo6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo6.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub



    Private Sub TxtCodigo7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo7.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub TxtCodigo8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo8.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub TxtCodigo9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo9.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub TxtCodigo10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo10.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub



    Private Sub TxtCodigo11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo11.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub TxtCodigo12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo12.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub GuardarCambiosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem3.Click
        Try

            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox("Desea guardar los cambios en el registro?", MsgBoxStyle.YesNo)

            If Respuesta = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim com2 As New SqlCommand
                Dim datos As New DataSet
                Dim sql As String

                '*************** Guardar cambios en el registro ************
                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                sql = "update Clientes set Num_cliente='" + TxtNumCliente.Text & "', Nombre_cliente='" + TxtNombreCLiente.Text + "', Tipo_cliente='" + CboTipoCliente.Text + ""
                sql &= "', Codigo1='*" + TxtCodigo1.Text + "*', Codigo2='*" + TxtCodigo2.Text + "*', Codigo3='*" + TxtCodigo3.Text + "*', Codigo4='*" + TxtCodigo4.Text + "*', Codigo5='*" + TxtCodigo5.Text + "*"
                sql &= "', Codigo6='*" + TxtCodigo6.Text + "*', Codigo7='*" + TxtCodigo7.Text + "*', Codigo8='*" + TxtCodigo8.Text + "*',Codigo9='*" + TxtCodigo9.Text + "*',Codigo10='*" + TxtCodigo10.Text + "*"
                sql &= "', Codigo11='*" + TxtCodigo11.Text + "*',Codigo12='*" + TxtCodigo12.Text + "*',Codigo13='*" & tb13.Text & "*',Codigo14='*" & tb14.Text & "*',Codigo15='*" & tb15.Text & "*',Codigo16='*" & tb16.Text & "*' where IdCliente= '" + TxtIdcliente.Text + "' "
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                Operacion = "Modificacion"
                Dim fechaactual As DateTime = Date.Now()

                Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                        fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                         fechaactual.Year.ToString().Trim()

                Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Second.ToString().Trim().PadLeft(2, "0")
                cmd2.Connection = cnn
                cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla, IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "',CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "','" & TxtIdcliente.Text & "')"
                cmd2.ExecuteNonQuery()

                limpiar_campos()
                TxtNumCliente.Focus()


                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False
                NuevoToolStripMenuItem.Enabled = True
                EliminarToolStripMenuItem2.Enabled = False


                inhabiltarcampos()


                cnn.Close()
                Close()

            Else
                limpiar_campos()

                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False

                NuevoToolStripMenuItem.Enabled = True

                TxtNumCliente.Focus()

                inhabiltarcampos()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GuardarYCerrarToolStripMenuItem2.Click
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim datos As New DataSet
            Dim sql As String

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            sql = "insert into clientes(Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12,Codigo13,Codigo14,Codigo15,Codigo16) "
            sql &= "values('" & TxtNombreCLiente.Text & "', '" & TxtNumCliente.Text & "', '" & CboTipoCliente.Text & "', '*" & TxtCodigo1.Text & "*','*" & TxtCodigo2.Text & "*','*" & TxtCodigo3.Text & "*"
            sql &= "','*" & TxtCodigo4.Text & "*','*" & TxtCodigo5.Text & "*','*" & TxtCodigo6.Text & "*','*" & TxtCodigo7.Text & "*','*" & TxtCodigo8.Text & "*','*" & TxtCodigo9.Text & "*','*" & TxtCodigo10.Text & "*"
            sql &= "','*" & TxtCodigo11.Text & "*','*" & TxtCodigo12.Text & "*','*" & tb13.Text & "*','*" & tb14.Text & "*','*" & tb15.Text & "*','*" & tb16.Text & "*')"
            com.CommandText = sql
            com.ExecuteNonQuery()

            Operacion = "Insertar"
            Tabla = "Clientes"
            Dim fechaactual As DateTime = Date.Now()

            Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                    fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                     fechaactual.Year.ToString().Trim()

            Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Second.ToString().Trim().PadLeft(2, "0")
            cmd2.Connection = cnn
            cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla, IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "', CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "','" & TxtIdcliente.Text & "')"
            cmd2.ExecuteNonQuery()

            cnn.Close()
            limpiar_campos()
            Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYNuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarYNuevoToolStripMenuItem1.Click
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim datos As New DataSet
            Dim sql As String
            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            cmd2.Connection = cnn

            sql = "insert into clientes(Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12,Codigo13,Codigo14,Codigo15,Codigo16) "
            sql &= "values('" & TxtNombreCLiente.Text & "', '" & TxtNumCliente.Text & "', '" & CboTipoCliente.Text & "', '*" & TxtCodigo1.Text & "*','*" & TxtCodigo2.Text & "*','*" & TxtCodigo3.Text & "*"
            sql &= "','*" & TxtCodigo4.Text & "*','*" & TxtCodigo5.Text & "*','*" & TxtCodigo6.Text & "*','*" & TxtCodigo7.Text & "*','*" & TxtCodigo8.Text & "*','*" & TxtCodigo9.Text & "*','*" & TxtCodigo10.Text & "*"
            sql &= "','*" & TxtCodigo11.Text & "*','*" & TxtCodigo12.Text & "*','*" & tb13.Text & "*','*" & tb14.Text & "*','*" & tb15.Text & "*','*" & tb16.Text & "*')"
            com.CommandText = sql
            com.ExecuteNonQuery()

            Operacion = "Insertar"
            Tabla = "Clientes"
            Dim fechaactual As DateTime = Date.Now()

            Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                    fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                     fechaactual.Year.ToString().Trim()

            Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Second.ToString().Trim().PadLeft(2, "0")
            cmd2.Connection = cnn
            cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla, IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "', CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "','" & TxtIdcliente.Text & "')"
            cmd2.ExecuteNonQuery()

            limpiar_campos()
            TxtNumCliente.Focus()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CancelarToolStripMenuItem2.Click
        limpiar_campos()
        TxtNumCliente.Focus()
        EliminarToolStripMenuItem2.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True
        GuardarYNuevoToolStripMenuItem1.Enabled = True
        GuardarCambiosToolStripMenuItem3.Enabled = False
        NuevoToolStripMenuItem.Enabled = True
        EditarToolStripMenuItem2.Enabled = True

        TsmEditar2.Enabled = True
        EliminarToolStripMenuItem3.Enabled = True
        GuardarYCerrarToolStripMenuItem2.Enabled = True


        GuardarYCerrarToolStripMenuItem3.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem4.Enabled = False

        EditarToolStripMenuItem2.Enabled = False
        EliminarToolStripMenuItem2.Enabled = False
        TsmEditar2.Enabled = False
        EliminarToolStripMenuItem3.Enabled = False

        ' habilitarCampos()
        inhabiltarcampos()
        Close()

    End Sub

    Private Sub EditarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem2.Click
        EliminarToolStripMenuItem2.Enabled = False
        GuardarYCerrarToolStripMenuItem2.Enabled = False
        GuardarYNuevoToolStripMenuItem1.Enabled = False
        GuardarCambiosToolStripMenuItem3.Enabled = True

        NuevoToolStripMenuItem.Enabled = False
        EditarToolStripMenuItem2.Enabled = False

        TsmEditar2.Enabled = False
        EliminarToolStripMenuItem3.Enabled = False

        habilitarcampos()


        GuardarYCerrarToolStripMenuItem3.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem4.Enabled = True
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem2.Click
        Try
            Dim RespuestaElim As MsgBoxResult
            RespuestaElim = MsgBox("Desea eliminar el registro de forma permanente?", MsgBoxStyle.YesNo)
            If RespuestaElim = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim datos As New DataSet


                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandText = "delete clientes where Idcliente = '" & TxtIdcliente.Text & "'"
                cmd.ExecuteNonQuery()

                Operacion = "Eliminacion"
                Dim fechaactual As DateTime = Date.Now()

                Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                        fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                         fechaactual.Year.ToString().Trim()

                Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Second.ToString().Trim().PadLeft(2, "0")
                cmd2.Connection = cnn
                cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla, IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "',CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "', '" & TxtIdcliente.Text & "')"
                cmd2.ExecuteNonQuery()

                limpiar_campos()
                habilitarcampos()

                TxtNumCliente.Focus()

                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False
                habilitarcampos()



                limpiar_campos()
                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False

                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False
                inhabiltarcampos()

                limpiar_campos()



            Else
                habilitarcampos()
                limpiar_campos()

                TxtNumCliente.Focus()

                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False

                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False

                inhabiltarcampos()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem4.Click
        Try

            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox("Desea guardar los cambios en el registro?", MsgBoxStyle.YesNo)

            If Respuesta = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim datos As New DataSet
                Dim sql As String

                '*************** Guardar cambios en el registro ************
                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                sql = "update Clientes set Num_cliente='" + TxtNumCliente.Text & "', Nombre_cliente='" + TxtNombreCLiente.Text + "', Tipo_cliente='" + CboTipoCliente.Text + ""
                sql &= "', Codigo1='*" + TxtCodigo1.Text + "*', Codigo2='*" + TxtCodigo2.Text + "*', Codigo3='*" + TxtCodigo3.Text + "*', Codigo4='*" + TxtCodigo4.Text + "*', Codigo5='*" + TxtCodigo5.Text + "*"
                sql &= "', Codigo6='*" + TxtCodigo6.Text + "*', Codigo7='*" + TxtCodigo6.Text + "*', Codigo8='*" + TxtCodigo8.Text + "*',Codigo9='*" + TxtCodigo9.Text + "*',Codigo10='*" + TxtCodigo10.Text + "*"
                sql &= "', Codigo11='*" + TxtCodigo11.Text + "*',Codigo12='*" + TxtCodigo12.Text + "*',Codigo13='*" + tb13.Text + "*',Codigo14='*" + tb14.Text + "*',Codigo15='*" + tb15.Text + "*',Codigo16='*" + tb16.Text + "*' where IdCliente= '" + TxtIdcliente.Text + "' "
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                Operacion = "Modificacion"
                Dim fechaactual As DateTime = Date.Now()

                Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                   fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                    fechaactual.Year.ToString().Trim()

                Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Second.ToString().Trim().PadLeft(2, "0")
                cmd2.Connection = cnn
                cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla,IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "', CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "','" & TxtIdcliente.Text & "')"
                cmd2.ExecuteNonQuery()

                limpiar_campos()
                TxtNumCliente.Focus()


                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False
                NuevoToolStripMenuItem.Enabled = True
                EliminarToolStripMenuItem2.Enabled = False


                inhabiltarcampos()


                cnn.Close()
                Close()

            Else
                limpiar_campos()

                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False

                NuevoToolStripMenuItem.Enabled = True

                TxtNumCliente.Focus()

                inhabiltarcampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYNuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GuardarYNuevoToolStripMenuItem2.Click
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim datos As New DataSet

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into clientes(Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12,Codigo13,Codigo14,Codigo15,Codigo16) " &
            "values('" & TxtNombreCLiente.Text & "', '" & TxtNumCliente.Text & "', '" & CboTipoCliente.Text & "', '*" & TxtCodigo1.Text & "*','*" & TxtCodigo2.Text & "*','*" & TxtCodigo3.Text & "*" &
            "','*" & TxtCodigo4.Text & "*','*" & TxtCodigo5.Text & "*','*" & TxtCodigo6.Text & "*','*" & TxtCodigo7.Text & "*','*" & TxtCodigo8.Text & "*','*" & TxtCodigo9.Text & "*','*" & TxtCodigo10.Text & "*" &
            "','*" & TxtCodigo11.Text & "*','*" & TxtCodigo12.Text & "*','*" & tb13.Text & "*','*" & tb14.Text & "*','*" & tb15.Text & "*','*" & tb16.Text & "*')"
            com.ExecuteNonQuery()

            Operacion = "Insertar"
            Tabla = "Clientes"
            Dim fechaactual As DateTime = Date.Now()

            Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                    fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                     fechaactual.Year.ToString().Trim()

            Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Second.ToString().Trim().PadLeft(2, "0")
            cmd2.Connection = cnn
            cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla, IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "',CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "', '" & TxtIdcliente.Text & "')"
            cmd2.ExecuteNonQuery()

            limpiar_campos()
            TxtNumCliente.Focus()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GuardarYCerrarToolStripMenuItem3.Click
        Try
            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim datos As New DataSet
            Dim sql As String

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into clientes(Nombre_cliente,Num_cliente,Tipo_cliente,Codigo1,Codigo2,Codigo3,Codigo4,Codigo5,Codigo6,Codigo7,Codigo8,Codigo9,Codigo10,Codigo11,Codigo12,Codigo13,Codigo14,Codigo15,Codigo16) "
            sql &= "values('" & TxtNombreCLiente.Text & "', '" & TxtNumCliente.Text & "', '" & CboTipoCliente.Text & "', '*" & TxtCodigo1.Text & "*','*" & TxtCodigo2.Text & "*','*" & TxtCodigo3.Text & "*"
            sql &= "','*" & TxtCodigo4.Text & "*','*" & TxtCodigo5.Text & "*','*" & TxtCodigo6.Text & "*','*" & TxtCodigo7.Text & "*','*" & TxtCodigo8.Text & "*','*" & TxtCodigo9.Text & "*','*" & TxtCodigo10.Text & "*"
            sql &= "','*" & TxtCodigo11.Text & "*','*" & TxtCodigo12.Text & "*','*" & tb13.Text & "*','*" & tb14.Text & "*','*" & tb15.Text & "*','*" & tb16.Text & "*')"
            com.CommandText = sql
            com.ExecuteNonQuery()
            Operacion = "Insertar"
            Tabla = "Clientes"
            Dim fechaactual As DateTime = Date.Now()

            Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                    fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                     fechaactual.Year.ToString().Trim()

            Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                    fechaactual.Second.ToString().Trim().PadLeft(2, "0")
            cmd2.Connection = cnn
            cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla, IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "',CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "', '" & TxtIdcliente.Text & "')"
            cmd2.ExecuteNonQuery()

            cnn.Close()
            limpiar_campos()
            Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem3.Click
        Try
            Dim RespuestaElim As MsgBoxResult
            RespuestaElim = MsgBox("Desea eliminar el registro de forma permanente?", MsgBoxStyle.YesNo)
            If RespuestaElim = MsgBoxResult.Yes Then
                Dim cnn As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim datos As New DataSet


                cnn.ConnectionString = strconexion
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandText = "delete clientes where IdCliente = '" & TxtIdcliente.Text & "'"
                cmd.ExecuteNonQuery()

                Operacion = "Eliminacion"
                Dim fechaactual As DateTime = Date.Now()

                Dim fActual As String = fechaactual.Month.ToString().Trim().PadLeft(2, "0") & "/" &
                                   fechaactual.Day.ToString().Trim().PadLeft(2, "0") & "/" &
                                    fechaactual.Year.ToString().Trim()

                Dim hActual As String = fechaactual.Hour.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Minute.ToString().Trim().PadLeft(2, "0") & ":" &
                                        fechaactual.Second.ToString().Trim().PadLeft(2, "0")
                cmd2.Connection = cnn
                cmd2.CommandText = "insert into Bitacora(Operacion, Usuario, FechaModificacion, HoraModificacion, Tabla,IdRegistro) values ('" & Operacion & "', '" & NomUsuario & "', CONVERT(DATETIME,'" & fActual & "',101), '" & hActual & "', '" & Tabla & "', '" & TxtIdcliente.Text & "')"
                cmd2.ExecuteNonQuery()

                limpiar_campos()
                habilitarcampos()

                TxtNumCliente.Focus()

                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False
                habilitarcampos()



                limpiar_campos()
                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False

                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False
                inhabiltarcampos()

                limpiar_campos()
                Close()

            Else
                habilitarcampos()
                limpiar_campos()

                TxtNumCliente.Focus()

                EliminarToolStripMenuItem2.Enabled = True
                GuardarYCerrarToolStripMenuItem2.Enabled = True
                GuardarYNuevoToolStripMenuItem1.Enabled = True
                GuardarCambiosToolStripMenuItem3.Enabled = False

                EditarToolStripMenuItem2.Enabled = False
                EliminarToolStripMenuItem2.Enabled = False
                TsmEditar2.Enabled = False
                EliminarToolStripMenuItem3.Enabled = False

                inhabiltarcampos()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class