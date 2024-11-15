Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class MenuGrupoFaza

    Private Sub ValesPuntoGasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesPuntoGasToolStripMenuItem.Click
        frmMenu.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class