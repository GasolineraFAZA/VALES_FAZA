Public Class FrmVistaCredito

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ChkFolioInicial.Checked = True Then
                frmMenu.DgvGeneral.Columns(4).Visible = True

            Else
                frmMenu.DgvGeneral.Columns(4).Visible = False
            End If

            If ChkFolioFinal.Checked = True Then
                frmMenu.DgvGeneral.Columns(5).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(5).Visible = False
            End If

            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        CheckBox4.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        CheckBox5.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ChkFolioFinal.Checked = False
        ChkFolioInicial.Checked = False

        Me.Close()

    End Sub
End Class