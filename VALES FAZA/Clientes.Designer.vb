<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrClientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrClientes
        '
        Me.CrClientes.ActiveViewIndex = -1
        Me.CrClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrClientes.Location = New System.Drawing.Point(0, 0)
        Me.CrClientes.Name = "CrClientes"
        Me.CrClientes.Size = New System.Drawing.Size(1368, 753)
        Me.CrClientes.TabIndex = 0
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 753)
        Me.Controls.Add(Me.CrClientes)
        Me.Name = "FrmClientes"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrClientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
