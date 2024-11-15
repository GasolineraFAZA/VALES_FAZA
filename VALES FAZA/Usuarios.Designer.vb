<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
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
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmCancelar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmEditar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmEliminar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarYCerrarToolStripMenuItem, Me.TsmGuardarNueVC, Me.GuardarCambiosToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarYCerrarToolStripMenuItem
        '
        Me.GuardarYCerrarToolStripMenuItem.Image = CType(resources.GetObject("GuardarYCerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarYCerrarToolStripMenuItem.Name = "GuardarYCerrarToolStripMenuItem"
        Me.GuardarYCerrarToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.GuardarYCerrarToolStripMenuItem.Text = "Guardar y Cerrar"
        '
        'TsmGuardarNueVC
        '
        Me.TsmGuardarNueVC.Image = CType(resources.GetObject("TsmGuardarNueVC.Image"), System.Drawing.Image)
        Me.TsmGuardarNueVC.Name = "TsmGuardarNueVC"
        Me.TsmGuardarNueVC.Size = New System.Drawing.Size(122, 20)
        Me.TsmGuardarNueVC.Text = "Guardar y nuevo"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Enabled = False
        Me.GuardarCambiosToolStripMenuItem.Image = CType(resources.GetObject("GuardarCambiosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = CType(resources.GetObject("CancelarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        Me.CancelarToolStripMenuItem.ToolTipText = "Cancelar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchioToolStripMenuItem, Me.EdicionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip2.TabIndex = 6
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
        Me.TsmNuevo.Image = CType(resources.GetObject("TsmNuevo.Image"), System.Drawing.Image)
        Me.TsmNuevo.Name = "TsmNuevo"
        Me.TsmNuevo.Size = New System.Drawing.Size(166, 22)
        Me.TsmNuevo.Text = "&Nuevo"
        '
        'GuardarYCerrarToolStripMenuItem1
        '
        Me.GuardarYCerrarToolStripMenuItem1.Image = CType(resources.GetObject("GuardarYCerrarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.GuardarYCerrarToolStripMenuItem1.Name = "GuardarYCerrarToolStripMenuItem1"
        Me.GuardarYCerrarToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.GuardarYCerrarToolStripMenuItem1.Text = "&Guardar y cerrar"
        '
        'GuardarYNuevoToolStripMenuItem
        '
        Me.GuardarYNuevoToolStripMenuItem.Image = CType(resources.GetObject("GuardarYNuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarYNuevoToolStripMenuItem.Name = "GuardarYNuevoToolStripMenuItem"
        Me.GuardarYNuevoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GuardarYNuevoToolStripMenuItem.Text = "&Guardar y nuevo"
        '
        'GuardarCambiosToolStripMenuItem1
        '
        Me.GuardarCambiosToolStripMenuItem1.Enabled = False
        Me.GuardarCambiosToolStripMenuItem1.Image = CType(resources.GetObject("GuardarCambiosToolStripMenuItem1.Image"), System.Drawing.Image)
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
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmCancelar2, Me.TsmEditar2, Me.TsmEliminar2})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdicionToolStripMenuItem.Text = "&Edicion"
        '
        'TsmCancelar2
        '
        Me.TsmCancelar2.Image = CType(resources.GetObject("TsmCancelar2.Image"), System.Drawing.Image)
        Me.TsmCancelar2.Name = "TsmCancelar2"
        Me.TsmCancelar2.Size = New System.Drawing.Size(120, 22)
        Me.TsmCancelar2.Text = "&Cancelar"
        '
        'TsmEditar2
        '
        Me.TsmEditar2.Image = CType(resources.GetObject("TsmEditar2.Image"), System.Drawing.Image)
        Me.TsmEditar2.Name = "TsmEditar2"
        Me.TsmEditar2.Size = New System.Drawing.Size(120, 22)
        Me.TsmEditar2.Text = "&Editar"
        '
        'TsmEliminar2
        '
        Me.TsmEliminar2.Image = CType(resources.GetObject("TsmEliminar2.Image"), System.Drawing.Image)
        Me.TsmEliminar2.Name = "TsmEliminar2"
        Me.TsmEliminar2.Size = New System.Drawing.Size(120, 22)
        Me.TsmEliminar2.Text = "&Eliminar"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUsuarios"
        Me.Text = "Usuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmCancelar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmEditar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmEliminar2 As System.Windows.Forms.ToolStripMenuItem
End Class
