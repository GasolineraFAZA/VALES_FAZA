<CompilerServices.DesignerGenerated()> _
Partial Class FrmValesTrans
    Inherits Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <DebuggerNonUserCode()> _
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
        Me.CrvValeTrans = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvValeTrans
        '
        Me.CrvValeTrans.ActiveViewIndex = -1
        Me.CrvValeTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvValeTrans.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvValeTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvValeTrans.Location = New System.Drawing.Point(0, 0)
        Me.CrvValeTrans.Name = "CrvValeTrans"
        Me.CrvValeTrans.Size = New System.Drawing.Size(1368, 753)
        Me.CrvValeTrans.TabIndex = 0
        '
        'FrmValesTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 753)
        Me.Controls.Add(Me.CrvValeTrans)
        Me.Name = "FrmValesTrans"
        Me.Text = "ValesTrans"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvValeTrans As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
