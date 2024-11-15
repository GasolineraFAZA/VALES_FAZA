<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValesAnexo
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
        Me.CrvValesAnexo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrvValesAnexo
        '
        Me.CrvValesAnexo.ActiveViewIndex = -1
        Me.CrvValesAnexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvValesAnexo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrvValesAnexo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvValesAnexo.Location = New System.Drawing.Point(0, 0)
        Me.CrvValesAnexo.Name = "CrvValesAnexo"
        Me.CrvValesAnexo.Size = New System.Drawing.Size(1908, 1045)
        Me.CrvValesAnexo.TabIndex = 0
        '
        'FrmValesAnexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1908, 1045)
        Me.Controls.Add(Me.CrvValesAnexo)
        Me.Name = "FrmValesAnexo"
        Me.Text = "ValesAnexo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvValesAnexo As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
