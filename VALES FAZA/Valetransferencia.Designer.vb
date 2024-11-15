<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Valetransferencia
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtNumClienteVT = New System.Windows.Forms.TextBox()
        Me.TxtNumIdVT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1368, 749)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TxtNumClienteVT
        '
        Me.TxtNumClienteVT.Location = New System.Drawing.Point(41, 96)
        Me.TxtNumClienteVT.Name = "TxtNumClienteVT"
        Me.TxtNumClienteVT.Size = New System.Drawing.Size(72, 20)
        Me.TxtNumClienteVT.TabIndex = 2
        Me.TxtNumClienteVT.Visible = False
        '
        'TxtNumIdVT
        '
        Me.TxtNumIdVT.Location = New System.Drawing.Point(41, 70)
        Me.TxtNumIdVT.Name = "TxtNumIdVT"
        Me.TxtNumIdVT.Size = New System.Drawing.Size(72, 20)
        Me.TxtNumIdVT.TabIndex = 3
        '
        'Valetransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 749)
        Me.Controls.Add(Me.TxtNumIdVT)
        Me.Controls.Add(Me.TxtNumClienteVT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Valetransferencia"
        Me.Text = "Valetransferencia"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtNumClienteVT As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumIdVT As System.Windows.Forms.TextBox
End Class
