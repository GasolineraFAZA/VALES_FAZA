Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports EncriptarDesencriptar

Public Class FrmAnexoVales
    Dim strconexion As String
    Private Sub llenacombo()
        Dim cnn As New SqlConnection
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter

        cnn.ConnectionString = strconexion
        cnn.Open()

        With cmd
            .CommandType = CommandType.Text
            .CommandText = "select Nombre_cliente from clientes where Tipo_cliente='Vales anexo cliente'"
            .Connection = cnn
        End With

        da.SelectCommand = cmd
        dt = New DataTable
        da.Fill(dt)
        With CboClienteAnexo
            .DataSource = dt
            .DisplayMember = "Nombre_cliente"
            .Text = ""
        End With
        cnn.Close()


    End Sub
    Private Sub limpiarCampos()
        CboClienteAnexo.Text = ""
        TxtNumclienteAnexo.Text = ""
        TxtFolioInicial.Text = ""
        TxtFolioFinal.Text = ""


    End Sub
    Private Sub habilitarCampos()
        CboClienteAnexo.Enabled = True
        TxtNumclienteAnexo.ReadOnly = False

        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False

    End Sub
    Private Sub inhabilitarcampos()
        CboClienteAnexo.Enabled = False
        TxtNumclienteAnexo.ReadOnly = True

        TxtFolioFinal.ReadOnly = True
        TxtFolioInicial.ReadOnly = True
    End Sub
    Private Sub FrmAnexoVales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim EncrDesencr As New EncriptacionDescencriptacion

            strconexion = EncrDesencr.Decrypt(ConfigurationManager.ConnectionStrings("VALES_FAZA").ConnectionString)
            If VarDato = 3 Then
                TxtNumclienteAnexo.Text = NumCliente


                Dim cnn As New SqlConnection
                cnn.ConnectionString = strconexion
                Dim sql As String = "select IdValeAnexo,Nombre_cliente,Num_cliente,Folio_inicial,Folio_final from Vales_anexo where IdValeAnexo= '" & TxtNumclienteAnexo.Text & "'"
                Dim cmd As New SqlCommand(sql, cnn)
                Dim odr As SqlDataReader

                cnn.Open()
                odr = cmd.ExecuteReader()
                If odr.Read() Then
                    CboClienteAnexo.Text = odr.Item("Nombre_cliente").ToString()
                    TxtNumclienteAnexo.Text = odr.Item("Num_cliente").ToString()
                    TxtFolioInicial.Text = odr.Item("Folio_inicial").ToString()
                    TxtFolioFinal.Text = odr.Item("Folio_final").ToString()
                    TxtIdValeAnexo.Text = odr.Item("IdValeAnexo").ToString()
                End If
                odr.Close()
                cnn.Close()

                CboClienteAnexo.Focus()
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
                limpiarCampos()
                llenacombo()
                limpiarCampos()

                habilitarCampos()
            End If

            'EliminarToolStripMenuItem.Enabled = True
            'GuardarYCerrarToolStripMenuItem.Enabled = True
            'TsmGuardarNueVC.Enabled = True
            'GuardarCambiosToolStripMenuItem.Enabled = False
            'TsmNuevo.Enabled = True
            'EditarToolStripMenuItem.Enabled = True
            'TsmImprimir.Enabled = True
            TxtFecha.Text = Format(Now(), "short date")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CboClienteAnexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboClienteAnexo.SelectedIndexChanged
        Try
            TextBox1.Text = CboClienteAnexo.Text

            Dim cnn As New SqlConnection
            cnn.ConnectionString = strconexion
            Dim sql As String = "select Num_cliente from clientes where Nombre_cliente= '" & TextBox1.Text & "'"
            Dim cmd As New SqlCommand(sql, cnn)
            Dim odr As SqlDataReader

            cnn.Open()
            odr = cmd.ExecuteReader()
            If odr.Read() Then
                TxtNumclienteAnexo.Text() = odr.Item("Num_cliente").ToString()


            End If
            odr.Close()
            cnn.Close()
            TxtFolioInicial.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtFolioInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolioInicial.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TxtFolioInicial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFolioInicial.TextChanged
        TxtFolioFinal.Text = Val(TxtFolioInicial.Text) + 79

    End Sub


    Private Sub TsmGuardarNueVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmGuardarNueVC.Click
        Try

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into Vales_anexo(Nombre_cliente,Num_cliente,folio_inicial,folio_final,Fecha) " &
            "values('" & CboClienteAnexo.Text & "', '" & TxtNumclienteAnexo.Text & "', '" & TxtFolioInicial.Text & "', '" & TxtFolioFinal.Text & "',CONVERT(DATETIME,'" & Format(CDate(TxtFecha.Text), "MM/dd/yyyy") & "',101))"
            com.ExecuteNonQuery()


            limpiarCampos()
            CboClienteAnexo.Focus()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TsmImprimirVale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmImprimirVale.Click
        CodigoCliente = TxtNumclienteAnexo.Text
        Vales_credito.ShowDialog()

    End Sub

    Private Sub DgvValesCredito_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ' CodigoCliente = Me.DgvValesCredito.Rows(e.RowIndex).Cells(2).Value
        'CboClienteCredito.Text() = Me.DgvValesCredito.Rows(e.RowIndex).Cells(1).Value
        'T() 'xtRazonSocial.Text() = Me.DgvValesCredito.Rows(e.RowIndex).Cells(3).Value
        'TxtNumclienteCredito.Text() = Me.DgvValesCredito.Rows(e.RowIndex).Cells(2).Value
        'TxtFolioInicial.Text() = Me.DgvValesCredito.Rows(e.RowIndex).Cells(4).Value
        'TxtFolioFinal.Text() = Me.DgvValesCredito.Rows(e.RowIndex).Cells(5).Value
        CboClienteAnexo.Enabled = False

        TxtNumclienteAnexo.ReadOnly = True
        TxtFolioInicial.ReadOnly = True
        TxtFolioFinal.ReadOnly = True




    End Sub

    Private Sub GuardarYNuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYNuevoToolStripMenuItem.Click
        Try

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into Vales_anexo(Nombre_cliente,Num_cliente,folio_inicial,folio_final,Fecha) " &
            "values('" & CboClienteAnexo.Text.Trim() & "', '" & TxtNumclienteAnexo.Text & "', '" & TxtFolioInicial.Text & "', '" & TxtFolioFinal.Text & "',CONVERT(DATETIME,'" & Format(CDate(TxtFecha.Text), "MM/dd/yyyy") & "',101))"
            com.ExecuteNonQuery()


            cnn.Close()
            limpiarCampos()
            CboClienteAnexo.Focus()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYCerrarToolStripMenuItem.Click
        Try

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into Vales_anexo(Nombre_cliente,Num_cliente,folio_inicial,folio_final,Fecha) " &
            "values('" & CboClienteAnexo.Text.Trim() & "', '" & TxtNumclienteAnexo.Text & "', '" & TxtFolioInicial.Text & "', '" & TxtFolioFinal.Text & "',CONVERT(DATETIME,'" & Format(CDate(TxtFecha.Text), "MM/dd/yyyy") & "',101))"
            com.ExecuteNonQuery()


            cnn.Close()
            limpiarCampos()
            Close()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GuardarYCerrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYCerrarToolStripMenuItem1.Click
        Try

            Dim cnn As New SqlConnection
            Dim com As New SqlCommand
            Dim com2 As New SqlCommand
            Dim datos As New DataSet

            cnn.ConnectionString = strconexion
            cnn.Open()
            com.Connection = cnn
            com.CommandText = "insert into Vales_anexo(Nombre_cliente,Num_cliente,folio_inicial,folio_final,Fecha) " &
            "values('" & CboClienteAnexo.Text.Trim() & "', '" & TxtNumclienteAnexo.Text & "', '" & TxtFolioInicial.Text & "', '" & TxtFolioFinal.Text & "',CONVERT(DATETIME,'" & Format(CDate(TxtFecha.Text), "MM/dd/yyyy") & "',101))"
            com.ExecuteNonQuery()


            cnn.Close()
            limpiarCampos()
            Close()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImprimirReciboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmImprimirRecibo.Click
        CodigoCliente = TxtNumclienteAnexo.Text
        FrmRecepcionValesAnexo.ShowDialog()

    End Sub


    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        'llenacombo()

        limpiarCampos()
        'CboClienteAnexo.Focus()
        EliminarToolStripMenuItem.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True
        TsmGuardarNueVC.Enabled = True
        GuardarCambiosToolStripMenuItem.Enabled = False
        TsmNuevo.Enabled = True
        EditarToolStripMenuItem.Enabled = True
        TsmImprimir.Enabled = True
        TsmEditar2.Enabled = True
        TsmEliminar2.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True


        GuardarYCerrarToolStripMenuItem1.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem1.Enabled = False
        'habilitarCampos()
        inhabilitarcampos()
        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False
        CboClienteAnexo.Focus()

    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        EliminarToolStripMenuItem.Enabled = False
        GuardarYCerrarToolStripMenuItem.Enabled = False
        TsmGuardarNueVC.Enabled = False
        GuardarCambiosToolStripMenuItem.Enabled = True
        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False
        TsmNuevo.Enabled = False
        EditarToolStripMenuItem.Enabled = False
        TsmImprimir.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False



        GuardarYCerrarToolStripMenuItem1.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem1.Enabled = True
        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False
        TxtFolioInicial.Focus()
        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False
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
                cmd.CommandText = "update Vales_anexo set Nombre_cliente='" + CboClienteAnexo.Text.Trim() & "', Num_cliente='" + TxtNumclienteAnexo.Text + "" &
                "', folio_inicial='" + TxtFolioInicial.Text + "', folio_final='" + TxtFolioFinal.Text + "' where IdValeAnexo= '" + TxtIdValeAnexo.Text + "' "
                cmd.ExecuteNonQuery()
                limpiarCampos()
                CboClienteAnexo.Focus()


                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                TsmNuevo.Enabled = True

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False

                GuardarYCerrarToolStripMenuItem1.Enabled = True
                GuardarYNuevoToolStripMenuItem.Enabled = True
                GuardarCambiosToolStripMenuItem1.Enabled = False
                habilitarCampos()
                CboClienteAnexo.Focus()
                inhabilitarcampos()

                cnn.Close()
            Else
                limpiarCampos()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                TsmNuevo.Enabled = True


                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                GuardarYCerrarToolStripMenuItem1.Enabled = True
                GuardarYNuevoToolStripMenuItem.Enabled = True
                GuardarCambiosToolStripMenuItem1.Enabled = False
                habilitarCampos()
                inhabilitarcampos()

                CboClienteAnexo.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                cmd.CommandText = "delete Vales_anexo where IdValeAnexo = '" & TxtIdValeAnexo.Text.Trim() & "'"
                cmd.ExecuteNonQuery()



                limpiarCampos()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarCampos()

                CboClienteAnexo.Focus()
                llenacombo()
                limpiarCampos()

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                inhabilitarcampos()
            Else
                limpiarCampos()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarCampos()


                llenacombo()
                limpiarCampos()
                CboClienteAnexo.Focus()

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
                cmd.CommandText = "update Vales_anexo set Nombre_cliente='" + CboClienteAnexo.Text.Trim() & "', Num_cliente='" + TxtNumclienteAnexo.Text + "" & _
                "', folio_inicial='" + TxtFolioInicial.Text + "', folio_final='" + TxtFolioFinal.Text + "' where IdValeAnexo= '" + TxtIdValeAnexo.Text + "' "
                cmd.ExecuteNonQuery()
                limpiarCampos()
                CboClienteAnexo.Focus()


                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                TsmNuevo.Enabled = True

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False

                GuardarYCerrarToolStripMenuItem1.Enabled = True
                GuardarYNuevoToolStripMenuItem.Enabled = True
                GuardarCambiosToolStripMenuItem1.Enabled = False
                habilitarCampos()
                CboClienteAnexo.Focus()
                inhabilitarcampos()

                cnn.Close()
            Else
                limpiarCampos()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                TsmNuevo.Enabled = True


                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                GuardarYCerrarToolStripMenuItem1.Enabled = True
                GuardarYNuevoToolStripMenuItem.Enabled = True
                GuardarCambiosToolStripMenuItem1.Enabled = False
                habilitarCampos()
                inhabilitarcampos()

                CboClienteAnexo.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        GuardarYCerrarToolStripMenuItem1.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem1.Enabled = True
        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False

        EliminarToolStripMenuItem.Enabled = False
        GuardarYCerrarToolStripMenuItem.Enabled = False
        TsmGuardarNueVC.Enabled = False
        GuardarCambiosToolStripMenuItem.Enabled = True
        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmNuevo.Click
        llenacombo()

        limpiarCampos()
        CboClienteAnexo.Focus()
        EliminarToolStripMenuItem.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True
        TsmGuardarNueVC.Enabled = True
        GuardarCambiosToolStripMenuItem.Enabled = False
        habilitarCampos()
        CboClienteAnexo.Focus()
    End Sub

    Private Sub TsmCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmCancelar2.Click
        'llenacombo()

        limpiarCampos()
        'CboClienteAnexo.Focus()
        EliminarToolStripMenuItem.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True
        TsmGuardarNueVC.Enabled = True
        GuardarCambiosToolStripMenuItem.Enabled = False
        TsmNuevo.Enabled = True
        EditarToolStripMenuItem.Enabled = True
        TsmImprimir.Enabled = True
        TsmEditar2.Enabled = True
        TsmEliminar2.Enabled = True
        GuardarYCerrarToolStripMenuItem.Enabled = True


        GuardarYCerrarToolStripMenuItem1.Enabled = True
        GuardarYNuevoToolStripMenuItem.Enabled = True
        GuardarCambiosToolStripMenuItem1.Enabled = False
        'habilitarCampos()
        inhabilitarcampos()
        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False
        CboClienteAnexo.Focus()
    End Sub

    Private Sub TsmEditar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsmEditar2.Click
        EliminarToolStripMenuItem.Enabled = False
        GuardarYCerrarToolStripMenuItem.Enabled = False
        TsmGuardarNueVC.Enabled = False
        GuardarCambiosToolStripMenuItem.Enabled = True
        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False
        TsmNuevo.Enabled = False
        EditarToolStripMenuItem.Enabled = False
        TsmImprimir.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False



        GuardarYCerrarToolStripMenuItem1.Enabled = False
        GuardarYNuevoToolStripMenuItem.Enabled = False
        GuardarCambiosToolStripMenuItem1.Enabled = True
        TxtFolioFinal.ReadOnly = False
        TxtFolioInicial.ReadOnly = False
        TxtFolioInicial.Focus()
        EditarToolStripMenuItem.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        TsmEditar2.Enabled = False
        TsmEliminar2.Enabled = False
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
                cmd.CommandText = "delete Vales_anexo where IdValeAnexo = '" & TxtIdValeAnexo.Text.Trim() & "'"
                cmd.ExecuteNonQuery()



                limpiarCampos()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarCampos()

                CboClienteAnexo.Focus()
                llenacombo()
                limpiarCampos()

                EditarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
                TsmEditar2.Enabled = False
                TsmEliminar2.Enabled = False
                inhabilitarcampos()
            Else
                limpiarCampos()
                EliminarToolStripMenuItem.Enabled = True
                GuardarYCerrarToolStripMenuItem.Enabled = True
                TsmGuardarNueVC.Enabled = True
                GuardarCambiosToolStripMenuItem.Enabled = False
                habilitarCampos()


                llenacombo()
                limpiarCampos()
                CboClienteAnexo.Focus()

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

End Class