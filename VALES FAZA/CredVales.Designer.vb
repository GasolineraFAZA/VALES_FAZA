<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCredVales
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
        Me.CrvValesCred = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvValesCred
        '
        Me.CrvValesCred.ActiveViewIndex = -1
        Me.CrvValesCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvValesCred.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvValesCred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvValesCred.Location = New System.Drawing.Point(0, 0)
        Me.CrvValesCred.Name = "CrvValesCred"
        Me.CrvValesCred.Size = New System.Drawing.Size(1368, 753)
        Me.CrvValesCred.TabIndex = 0
        '
        'FrmCredVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 753)
        Me.Controls.Add(Me.CrvValesCred)
        Me.Name = "FrmCredVales"
        Me.Text = "CredVales"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvValesCred As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
