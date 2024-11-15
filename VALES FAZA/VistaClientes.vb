Public Class FrmVistaClientes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ChkCodigo1.Checked = True Then
                frmMenu.DgvGeneral.Columns(4).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(4).Visible = False
            End If

            If ChkCodigo2.Checked = True Then
                frmMenu.DgvGeneral.Columns(5).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(5).Visible = False
            End If

            If ChkCodigo3.Checked = True Then
                frmMenu.DgvGeneral.Columns(6).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(6).Visible = False
            End If

            If ChkCodigo4.Checked = True Then
                frmMenu.DgvGeneral.Columns(7).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(7).Visible = False
            End If

            If ChkCodigo5.Checked = True Then
                frmMenu.DgvGeneral.Columns(8).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(8).Visible = False
            End If

            If ChkCodigo6.Checked = True Then
                frmMenu.DgvGeneral.Columns(9).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(9).Visible = False
            End If

            If ChkCodigo7.Checked = True Then
                frmMenu.DgvGeneral.Columns(10).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(10).Visible = False
            End If

            If ChkCodigo8.Checked = True Then
                frmMenu.DgvGeneral.Columns(11).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(11).Visible = False
            End If

            If ChkCodigo9.Checked = True Then
                frmMenu.DgvGeneral.Columns(12).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(12).Visible = False
            End If

            If Chkcodigo10.Checked = True Then
                frmMenu.DgvGeneral.Columns(13).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(13).Visible = False
            End If

            If ChkCodigo11.Checked = True Then
                frmMenu.DgvGeneral.Columns(14).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(14).Visible = False
            End If

            If ChkCodigo12.Checked = True Then
                frmMenu.DgvGeneral.Columns(15).Visible = True
            Else
                frmMenu.DgvGeneral.Columns(15).Visible = False
            End If


            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ChkCodigo1.Checked = False
        ChkCodigo2.Checked = False
        ChkCodigo3.Checked = False
        ChkCodigo4.Checked = False
        ChkCodigo5.Checked = False
        ChkCodigo6.Checked = False
        ChkCodigo7.Checked = False
        ChkCodigo8.Checked = False
        ChkCodigo9.Checked = False
        Chkcodigo10.Checked = False
        ChkCodigo11.Checked = False
        ChkCodigo12.Checked = False
      


        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox2.CheckState = CheckState.Indeterminate

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox3.CheckState = CheckState.Indeterminate

    End Sub
End Class