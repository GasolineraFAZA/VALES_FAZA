Public Class FrmVistaTransferencia

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ChkCajera.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(6).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(6).Visible = False
            End If

            If ChkFolio.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(8).Visible = True
                frmMenu.DgvGeneral.Columns(8).HeaderText = "Folio cobro"
            Else
                frmMenu.DgvGeneral.Columns(8).Visible = False
            End If

            If ChkFactura.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(9).Visible = False
            Else
                frmMenu.DgvGeneral.Columns(9).Visible = False
            End If

            If ChkDescripcionVeh.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(12).Visible = True
                frmMenu.DgvGeneral.Columns(12).HeaderText = "Descripcion del vehiculo"
            Else
                frmMenu.DgvGeneral.Columns(12).Visible = False
            End If

            If ChkPlacas.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(13).Visible = True
            Else
                frmMenu.DgvGeneral.Columns.Item(13).Visible = False
            End If

            If ChkConductor.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(14).Visible = True
            Else
                frmMenu.DgvGeneral.Columns.Item(14).Visible = False
            End If

            If ChkFechaCorte.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(15).Visible = True
                frmMenu.DgvGeneral.Columns(15).HeaderText = "Fecha corte"
            Else
                frmMenu.DgvGeneral.Columns.Item(15).Visible = False
            End If

            If ChkTurno.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(16).Visible = True
            Else
                frmMenu.DgvGeneral.Columns.Item(16).Visible = False
            End If

            If ChkPrecioUni.Checked = True Then
                frmMenu.DgvGeneral.Columns.Item(19).Visible = True
                frmMenu.DgvGeneral.Columns(19).HeaderText = "Precio unitario"
            Else
                frmMenu.DgvGeneral.Columns.Item(19).Visible = False
            End If

            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox22.CheckedChanged
        CheckBox22.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox21.CheckedChanged
        CheckBox21.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox20.CheckedChanged
        CheckBox20.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox19.CheckedChanged
        CheckBox19.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        CheckBox18.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        CheckBox17.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        CheckBox16.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        CheckBox15.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        CheckBox14.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        CheckBox13.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ChkCajera.Checked = False
        ChkFolio.Checked = False
        ChkFactura.Checked = False
        ChkDescripcionVeh.Checked = False
        ChkPlacas.Checked = False
        ChkConductor.Checked = False
        ChkFechaCorte.Checked = False
        ChkTurno.Checked = False
        ChkPrecioUni.Checked = False
        Me.Close()

    End Sub
End Class