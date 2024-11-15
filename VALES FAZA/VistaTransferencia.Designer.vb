<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaTransferencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ChkTurno = New System.Windows.Forms.CheckBox()
        Me.ChkPrecioUni = New System.Windows.Forms.CheckBox()
        Me.ChkFechaCorte = New System.Windows.Forms.CheckBox()
        Me.ChkConductor = New System.Windows.Forms.CheckBox()
        Me.ChkPlacas = New System.Windows.Forms.CheckBox()
        Me.ChkDescripcionVeh = New System.Windows.Forms.CheckBox()
        Me.ChkFactura = New System.Windows.Forms.CheckBox()
        Me.ChkFolio = New System.Windows.Forms.CheckBox()
        Me.ChkCajera = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciones los campos a mostrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ChkTurno)
        Me.GroupBox1.Controls.Add(Me.ChkPrecioUni)
        Me.GroupBox1.Controls.Add(Me.ChkFechaCorte)
        Me.GroupBox1.Controls.Add(Me.ChkConductor)
        Me.GroupBox1.Controls.Add(Me.ChkPlacas)
        Me.GroupBox1.Controls.Add(Me.ChkDescripcionVeh)
        Me.GroupBox1.Controls.Add(Me.ChkFactura)
        Me.GroupBox1.Controls.Add(Me.ChkFolio)
        Me.GroupBox1.Controls.Add(Me.ChkCajera)
        Me.GroupBox1.Controls.Add(Me.CheckBox13)
        Me.GroupBox1.Controls.Add(Me.CheckBox14)
        Me.GroupBox1.Controls.Add(Me.CheckBox15)
        Me.GroupBox1.Controls.Add(Me.CheckBox16)
        Me.GroupBox1.Controls.Add(Me.CheckBox17)
        Me.GroupBox1.Controls.Add(Me.CheckBox18)
        Me.GroupBox1.Controls.Add(Me.CheckBox19)
        Me.GroupBox1.Controls.Add(Me.CheckBox20)
        Me.GroupBox1.Controls.Add(Me.CheckBox21)
        Me.GroupBox1.Controls.Add(Me.CheckBox22)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 296)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox1.Location = New System.Drawing.Point(6, 7)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Fecha"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ChkTurno
        '
        Me.ChkTurno.AutoSize = True
        Me.ChkTurno.Location = New System.Drawing.Point(6, 261)
        Me.ChkTurno.Name = "ChkTurno"
        Me.ChkTurno.Size = New System.Drawing.Size(54, 17)
        Me.ChkTurno.TabIndex = 38
        Me.ChkTurno.Text = "Turno"
        Me.ChkTurno.UseVisualStyleBackColor = True
        '
        'ChkPrecioUni
        '
        Me.ChkPrecioUni.AutoSize = True
        Me.ChkPrecioUni.Location = New System.Drawing.Point(6, 277)
        Me.ChkPrecioUni.Name = "ChkPrecioUni"
        Me.ChkPrecioUni.Size = New System.Drawing.Size(95, 17)
        Me.ChkPrecioUni.TabIndex = 37
        Me.ChkPrecioUni.Text = "Precio Unitario"
        Me.ChkPrecioUni.UseVisualStyleBackColor = True
        '
        'ChkFechaCorte
        '
        Me.ChkFechaCorte.AutoSize = True
        Me.ChkFechaCorte.Location = New System.Drawing.Point(6, 247)
        Me.ChkFechaCorte.Name = "ChkFechaCorte"
        Me.ChkFechaCorte.Size = New System.Drawing.Size(84, 17)
        Me.ChkFechaCorte.TabIndex = 36
        Me.ChkFechaCorte.Text = "Fecha Corte"
        Me.ChkFechaCorte.UseVisualStyleBackColor = True
        '
        'ChkConductor
        '
        Me.ChkConductor.AutoSize = True
        Me.ChkConductor.Location = New System.Drawing.Point(6, 233)
        Me.ChkConductor.Name = "ChkConductor"
        Me.ChkConductor.Size = New System.Drawing.Size(75, 17)
        Me.ChkConductor.TabIndex = 35
        Me.ChkConductor.Text = "Conductor"
        Me.ChkConductor.UseVisualStyleBackColor = True
        '
        'ChkPlacas
        '
        Me.ChkPlacas.AutoSize = True
        Me.ChkPlacas.Location = New System.Drawing.Point(6, 219)
        Me.ChkPlacas.Name = "ChkPlacas"
        Me.ChkPlacas.Size = New System.Drawing.Size(58, 17)
        Me.ChkPlacas.TabIndex = 34
        Me.ChkPlacas.Text = "Placas"
        Me.ChkPlacas.UseVisualStyleBackColor = True
        '
        'ChkDescripcionVeh
        '
        Me.ChkDescripcionVeh.AutoSize = True
        Me.ChkDescripcionVeh.Location = New System.Drawing.Point(6, 205)
        Me.ChkDescripcionVeh.Name = "ChkDescripcionVeh"
        Me.ChkDescripcionVeh.Size = New System.Drawing.Size(142, 17)
        Me.ChkDescripcionVeh.TabIndex = 33
        Me.ChkDescripcionVeh.Text = "Descripcion del vehiculo"
        Me.ChkDescripcionVeh.UseVisualStyleBackColor = True
        '
        'ChkFactura
        '
        Me.ChkFactura.AutoSize = True
        Me.ChkFactura.Location = New System.Drawing.Point(6, 191)
        Me.ChkFactura.Name = "ChkFactura"
        Me.ChkFactura.Size = New System.Drawing.Size(62, 17)
        Me.ChkFactura.TabIndex = 32
        Me.ChkFactura.Text = "Factura"
        Me.ChkFactura.UseVisualStyleBackColor = True
        '
        'ChkFolio
        '
        Me.ChkFolio.AutoSize = True
        Me.ChkFolio.Location = New System.Drawing.Point(6, 177)
        Me.ChkFolio.Name = "ChkFolio"
        Me.ChkFolio.Size = New System.Drawing.Size(78, 17)
        Me.ChkFolio.TabIndex = 31
        Me.ChkFolio.Text = "Folio cobro"
        Me.ChkFolio.UseVisualStyleBackColor = True
        '
        'ChkCajera
        '
        Me.ChkCajera.AutoSize = True
        Me.ChkCajera.Location = New System.Drawing.Point(6, 163)
        Me.ChkCajera.Name = "ChkCajera"
        Me.ChkCajera.Size = New System.Drawing.Size(71, 17)
        Me.ChkCajera.TabIndex = 30
        Me.ChkCajera.Text = "Cajero (a)"
        Me.ChkCajera.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = True
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox13.Location = New System.Drawing.Point(6, 149)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox13.TabIndex = 29
        Me.CheckBox13.Text = "Importe"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox14.Location = New System.Drawing.Point(6, 135)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox14.TabIndex = 28
        Me.CheckBox14.Text = "Producto "
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Checked = True
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox15.Location = New System.Drawing.Point(6, 121)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox15.TabIndex = 27
        Me.CheckBox15.Text = "Cantidad"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Checked = True
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox16.Location = New System.Drawing.Point(6, 107)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox16.TabIndex = 26
        Me.CheckBox16.Text = "Sucursal"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Checked = True
        Me.CheckBox17.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox17.Location = New System.Drawing.Point(6, 93)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox17.TabIndex = 25
        Me.CheckBox17.Text = "Numero de carga"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Checked = True
        Me.CheckBox18.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox18.Location = New System.Drawing.Point(6, 79)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox18.TabIndex = 24
        Me.CheckBox18.Text = "Fecha transferencia"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Checked = True
        Me.CheckBox19.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox19.Enabled = False
        Me.CheckBox19.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(134, 17)
        Me.CheckBox19.TabIndex = 23
        Me.CheckBox19.Text = "Numero de movimiento"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Checked = True
        Me.CheckBox20.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox20.Location = New System.Drawing.Point(6, 51)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox20.TabIndex = 22
        Me.CheckBox20.Text = "Importe transferencia"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Checked = True
        Me.CheckBox21.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox21.Location = New System.Drawing.Point(6, 37)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox21.TabIndex = 21
        Me.CheckBox21.Text = "Nombre del cliente"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Checked = True
        Me.CheckBox22.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox22.Location = New System.Drawing.Point(6, 23)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox22.TabIndex = 20
        Me.CheckBox22.Text = "Numero de cliente"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmVistaTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(227, 362)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVistaTransferencia"
        Me.Text = "Personalizar vista"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTurno As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPrecioUni As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFechaCorte As System.Windows.Forms.CheckBox
    Friend WithEvents ChkConductor As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPlacas As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDescripcionVeh As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFactura As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFolio As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCajera As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
