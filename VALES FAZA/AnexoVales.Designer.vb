<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnexoVales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnexoVales))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdValeAnexo = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtFolioFinal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFolioInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumclienteAnexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboClienteAnexo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarYCerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmGuardarNueVC = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ArchioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarYCerrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarYNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmImprimirVale = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmImprimirRecibo = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmCancelar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmEditar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmEliminar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.MenuStrip2.SuspendLayout
        Me.SuspendLayout
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(246, 313)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Visible = false
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(131, 313)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.DtpFecha.TabIndex = 15
        Me.DtpFecha.Value = New Date(2014, 8, 22, 0, 0, 0, 0)
        Me.DtpFecha.Visible = false
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 313)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Visible = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIdValeAnexo)
        Me.GroupBox1.Controls.Add(Me.TxtFecha)
        Me.GroupBox1.Controls.Add(Me.TxtFolioFinal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtFolioInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNumclienteAnexo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CboClienteAnexo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 107)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Vales de credito"
        '
        'TxtIdValeAnexo
        '
        Me.TxtIdValeAnexo.Location = New System.Drawing.Point(486, 70)
        Me.TxtIdValeAnexo.Name = "TxtIdValeAnexo"
        Me.TxtIdValeAnexo.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdValeAnexo.TabIndex = 9
        Me.TxtIdValeAnexo.Visible = false
        '
        'TxtFecha
        '
        Me.TxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFecha.Location = New System.Drawing.Point(528, 19)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 13)
        Me.TxtFecha.TabIndex = 8
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFolioFinal
        '
        Me.TxtFolioFinal.Location = New System.Drawing.Point(205, 72)
        Me.TxtFolioFinal.Name = "TxtFolioFinal"
        Me.TxtFolioFinal.Size = New System.Drawing.Size(54, 20)
        Me.TxtFolioFinal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(145, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Folio final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Folio inicial:"
        '
        'TxtFolioInicial
        '
        Me.TxtFolioInicial.Location = New System.Drawing.Point(85, 72)
        Me.TxtFolioInicial.Name = "TxtFolioInicial"
        Me.TxtFolioInicial.Size = New System.Drawing.Size(54, 20)
        Me.TxtFolioInicial.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N° Cliente:"
        '
        'TxtNumclienteAnexo
        '
        Me.TxtNumclienteAnexo.Location = New System.Drawing.Point(85, 46)
        Me.TxtNumclienteAnexo.Name = "TxtNumclienteAnexo"
        Me.TxtNumclienteAnexo.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumclienteAnexo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'CboClienteAnexo
        '
        Me.CboClienteAnexo.FormattingEnabled = true
        Me.CboClienteAnexo.Location = New System.Drawing.Point(85, 19)
        Me.CboClienteAnexo.Name = "CboClienteAnexo"
        Me.CboClienteAnexo.Size = New System.Drawing.Size(316, 21)
        Me.CboClienteAnexo.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarYCerrarToolStripMenuItem, Me.TsmGuardarNueVC, Me.GuardarCambiosToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarYCerrarToolStripMenuItem
        '
        Me.GuardarYCerrarToolStripMenuItem.Image = CType(resources.GetObject("GuardarYCerrarToolStripMenuItem.Image"),System.Drawing.Image)
        Me.GuardarYCerrarToolStripMenuItem.Name = "GuardarYCerrarToolStripMenuItem"
        Me.GuardarYCerrarToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.GuardarYCerrarToolStripMenuItem.Text = "Guardar y Cerrar"
        '
        'TsmGuardarNueVC
        '
        Me.TsmGuardarNueVC.Image = CType(resources.GetObject("TsmGuardarNueVC.Image"),System.Drawing.Image)
        Me.TsmGuardarNueVC.Name = "TsmGuardarNueVC"
        Me.TsmGuardarNueVC.Size = New System.Drawing.Size(122, 20)
        Me.TsmGuardarNueVC.Text = "Guardar y nuevo"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Enabled = false
        Me.GuardarCambiosToolStripMenuItem.Image = CType(resources.GetObject("GuardarCambiosToolStripMenuItem.Image"),System.Drawing.Image)
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = CType(resources.GetObject("CancelarToolStripMenuItem.Image"),System.Drawing.Image)
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        Me.CancelarToolStripMenuItem.ToolTipText = "Cancelar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"),System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"),System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchioToolStripMenuItem, Me.TsmImprimir, Me.EdicionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip2.TabIndex = 12
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ArchioToolStripMenuItem
        '
        Me.ArchioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmNuevo, Me.GuardarYCerrarToolStripMenuItem1, Me.GuardarYNuevoToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem1, Me.ToolStripSeparator1, Me.CerrarToolStripMenuItem})
        Me.ArchioToolStripMenuItem.Name = "ArchioToolStripMenuItem"
        Me.ArchioToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchioToolStripMenuItem.Text = "&Archivo"
        '
        'TsmNuevo
        '
        Me.TsmNuevo.Image = CType(resources.GetObject("TsmNuevo.Image"),System.Drawing.Image)
        Me.TsmNuevo.Name = "TsmNuevo"
        Me.TsmNuevo.Size = New System.Drawing.Size(166, 22)
        Me.TsmNuevo.Text = "&Nuevo"
        '
        'GuardarYCerrarToolStripMenuItem1
        '
        Me.GuardarYCerrarToolStripMenuItem1.Image = CType(resources.GetObject("GuardarYCerrarToolStripMenuItem1.Image"),System.Drawing.Image)
        Me.GuardarYCerrarToolStripMenuItem1.Name = "GuardarYCerrarToolStripMenuItem1"
        Me.GuardarYCerrarToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.GuardarYCerrarToolStripMenuItem1.Text = "&Guardar y cerrar"
        '
        'GuardarYNuevoToolStripMenuItem
        '
        Me.GuardarYNuevoToolStripMenuItem.Image = CType(resources.GetObject("GuardarYNuevoToolStripMenuItem.Image"),System.Drawing.Image)
        Me.GuardarYNuevoToolStripMenuItem.Name = "GuardarYNuevoToolStripMenuItem"
        Me.GuardarYNuevoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GuardarYNuevoToolStripMenuItem.Text = "&Guardar y nuevo"
        '
        'GuardarCambiosToolStripMenuItem1
        '
        Me.GuardarCambiosToolStripMenuItem1.Enabled = false
        Me.GuardarCambiosToolStripMenuItem1.Image = CType(resources.GetObject("GuardarCambiosToolStripMenuItem1.Image"),System.Drawing.Image)
        Me.GuardarCambiosToolStripMenuItem1.Name = "GuardarCambiosToolStripMenuItem1"
        Me.GuardarCambiosToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.GuardarCambiosToolStripMenuItem1.Text = "&Guardar Cambios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CerrarToolStripMenuItem.Text = "&Cerrar"
        '
        'TsmImprimir
        '
        Me.TsmImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmImprimirVale, Me.TsmImprimirRecibo})
        Me.TsmImprimir.Name = "TsmImprimir"
        Me.TsmImprimir.Size = New System.Drawing.Size(65, 20)
        Me.TsmImprimir.Text = "&Imprimir"
        '
        'TsmImprimirVale
        '
        Me.TsmImprimirVale.Image = CType(resources.GetObject("TsmImprimirVale.Image"),System.Drawing.Image)
        Me.TsmImprimirVale.Name = "TsmImprimirVale"
        Me.TsmImprimirVale.Size = New System.Drawing.Size(156, 22)
        Me.TsmImprimirVale.Text = "Imprimir vale"
        '
        'TsmImprimirRecibo
        '
        Me.TsmImprimirRecibo.Image = CType(resources.GetObject("TsmImprimirRecibo.Image"),System.Drawing.Image)
        Me.TsmImprimirRecibo.Name = "TsmImprimirRecibo"
        Me.TsmImprimirRecibo.Size = New System.Drawing.Size(156, 22)
        Me.TsmImprimirRecibo.Text = "Imprimir recibo"
        '
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmCancelar2, Me.TsmEditar2, Me.TsmEliminar2})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdicionToolStripMenuItem.Text = "&Edicion"
        '
        'TsmCancelar2
        '
        Me.TsmCancelar2.Image = CType(resources.GetObject("TsmCancelar2.Image"),System.Drawing.Image)
        Me.TsmCancelar2.Name = "TsmCancelar2"
        Me.TsmCancelar2.Size = New System.Drawing.Size(120, 22)
        Me.TsmCancelar2.Text = "&Cancelar"
        '
        'TsmEditar2
        '
        Me.TsmEditar2.Image = CType(resources.GetObject("TsmEditar2.Image"),System.Drawing.Image)
        Me.TsmEditar2.Name = "TsmEditar2"
        Me.TsmEditar2.Size = New System.Drawing.Size(120, 22)
        Me.TsmEditar2.Text = "&Editar"
        '
        'TsmEliminar2
        '
        Me.TsmEliminar2.Image = CType(resources.GetObject("TsmEliminar2.Image"),System.Drawing.Image)
        Me.TsmEliminar2.Name = "TsmEliminar2"
        Me.TsmEliminar2.Size = New System.Drawing.Size(120, 22)
        Me.TsmEliminar2.Text = "&Eliminar"
        '
        'FrmAnexoVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 162)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "FrmAnexoVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnexoVales"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.MenuStrip2.ResumeLayout(false)
        Me.MenuStrip2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFolioFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFolioInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNumclienteAnexo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboClienteAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarYCerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmGuardarNueVC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarYCerrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarYNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmImprimirVale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmImprimirRecibo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmCancelar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmEditar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmEliminar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdValeAnexo As System.Windows.Forms.TextBox
End Class
