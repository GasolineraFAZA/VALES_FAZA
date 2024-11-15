Public Class FrmVistaAnexo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ChkFolioInicialAnexo.Checked = True Then
                frmMenu.DgvGeneral.Columns(4).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(4).Visible = False
            End If

            If ChkFolioFinalAnexo.Checked = True Then
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

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        CheckBox9.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        CheckBox8.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ChkFolioFinalAnexo.Checked = False
        ChkFolioInicialAnexo.Checked = False
        Me.Close()

    End Sub
End Class