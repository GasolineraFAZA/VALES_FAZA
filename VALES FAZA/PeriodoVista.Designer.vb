<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeriodoVista
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
        Me.BtnCancelarPeriodo = New System.Windows.Forms.Button()
        Me.BtnAceptarPeriodo = New System.Windows.Forms.Button()
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'BtnCancelarPeriodo
        '
        Me.BtnCancelarPeriodo.Location = New System.Drawing.Point(214, 48)
        Me.BtnCancelarPeriodo.Name = "BtnCancelarPeriodo"
        Me.BtnCancelarPeriodo.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelarPeriodo.TabIndex = 13
        Me.BtnCancelarPeriodo.Text = "Cancelar"
        Me.BtnCancelarPeriodo.UseVisualStyleBackColor = true
        '
        'BtnAceptarPeriodo
        '
        Me.BtnAceptarPeriodo.Enabled = false
        Me.BtnAceptarPeriodo.Location = New System.Drawing.Point(214, 19)
        Me.BtnAceptarPeriodo.Name = "BtnAceptarPeriodo"
        Me.BtnAceptarPeriodo.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptarPeriodo.TabIndex = 12
        Me.BtnAceptarPeriodo.Text = "Aceptar"
        Me.BtnAceptarPeriodo.UseVisualStyleBackColor = true
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(80, 48)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(111, 20)
        Me.DtpFechaFinal.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(4, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha Final:"
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(80, 22)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(111, 20)
        Me.DtpFechaInicial.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(4, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(4, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seleccione el periodo de visualizacion"
        '
        'FrmPeriodoVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(297, 80)
        Me.Controls.Add(Me.BtnCancelarPeriodo)
        Me.Controls.Add(Me.BtnAceptarPeriodo)
        Me.Controls.Add(Me.DtpFechaFinal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DtpFechaInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmPeriodoVista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodo de vista"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BtnCancelarPeriodo As System.Windows.Forms.Button
    Friend WithEvents BtnAceptarPeriodo As System.Windows.Forms.Button
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
