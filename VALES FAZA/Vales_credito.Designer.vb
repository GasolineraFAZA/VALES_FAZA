<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vales_credito
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
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Valescred1 = New VALES_FAZA.Valescred()
        Me.TxtNumCliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PruebaValeTrans1 = New VALES_FAZA.PruebaValeTrans()
        Me.Valescred2 = New VALES_FAZA.Valescred()
        Me.RecepcionValeCredito1 = New VALES_FAZA.RecepcionValeCredito()
        Me.RptClientes1 = New VALES_FAZA.RptClientes()
        Me.PruebaValeTrans2 = New VALES_FAZA.PruebaValeTrans()
        Me.ValesTransferencia1 = New VALES_FAZA.ValesTransferencia()
        Me.SuspendLayout
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1368, 749)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'TxtNumCliente
        '
        Me.TxtNumCliente.Location = New System.Drawing.Point(44, 135)
        Me.TxtNumCliente.Name = "TxtNumCliente"
        Me.TxtNumCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumCliente.TabIndex = 3
        Me.TxtNumCliente.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Vales_credito
        '
        Me.ClientSize = New System.Drawing.Size(1368, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtNumCliente)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Name = "Vales_credito"
        Me.Text = "Vales"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
 
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TxtNumCliente As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Valescred1 As Valescred
    Friend WithEvents PruebaValeTrans1 As PruebaValeTrans
    Friend WithEvents Valescred2 As Valescred
    Friend WithEvents RecepcionValeCredito1 As RecepcionValeCredito
    Friend WithEvents RptClientes1 As RptClientes
    Friend WithEvents PruebaValeTrans2 As PruebaValeTrans
    Friend WithEvents ValesTransferencia1 As ValesTransferencia
End Class
