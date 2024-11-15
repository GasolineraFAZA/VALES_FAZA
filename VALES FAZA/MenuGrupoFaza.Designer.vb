<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGrupoFaza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGrupoFaza))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdrmintradorDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GasolineraFazaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValesPuntoGasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CierreDeCajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComercialLagunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoFazaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CajaChicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradoresGafzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdrmintradorDeUsuariosToolStripMenuItem, Me.GasolineraFazaToolStripMenuItem, Me.ComercialLagunaToolStripMenuItem, Me.GrupoFazaToolStripMenuItem, Me.AdministradoresGafzaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(692, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdrmintradorDeUsuariosToolStripMenuItem
        '
        Me.AdrmintradorDeUsuariosToolStripMenuItem.Image = CType(resources.GetObject("AdrmintradorDeUsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdrmintradorDeUsuariosToolStripMenuItem.Name = "AdrmintradorDeUsuariosToolStripMenuItem"
        Me.AdrmintradorDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(170, 20)
        Me.AdrmintradorDeUsuariosToolStripMenuItem.Text = "&Adrmintrador de usuarios"
        '
        'GasolineraFazaToolStripMenuItem
        '
        Me.GasolineraFazaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValesPuntoGasToolStripMenuItem, Me.ToolStripSeparator1, Me.CierreDeCajaToolStripMenuItem1})
        Me.GasolineraFazaToolStripMenuItem.Image = CType(resources.GetObject("GasolineraFazaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GasolineraFazaToolStripMenuItem.Name = "GasolineraFazaToolStripMenuItem"
        Me.GasolineraFazaToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.GasolineraFazaToolStripMenuItem.Text = "&Gasolinera Faza"
        '
        'ValesPuntoGasToolStripMenuItem
        '
        Me.ValesPuntoGasToolStripMenuItem.Image = CType(resources.GetObject("ValesPuntoGasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ValesPuntoGasToolStripMenuItem.Name = "ValesPuntoGasToolStripMenuItem"
        Me.ValesPuntoGasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ValesPuntoGasToolStripMenuItem.Text = "&Vales punto gas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'CierreDeCajaToolStripMenuItem1
        '
        Me.CierreDeCajaToolStripMenuItem1.Image = CType(resources.GetObject("CierreDeCajaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CierreDeCajaToolStripMenuItem1.Name = "CierreDeCajaToolStripMenuItem1"
        Me.CierreDeCajaToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.CierreDeCajaToolStripMenuItem1.Text = "&Cierre de caja"
        '
        'ComercialLagunaToolStripMenuItem
        '
        Me.ComercialLagunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CierreDeCajaToolStripMenuItem})
        Me.ComercialLagunaToolStripMenuItem.Name = "ComercialLagunaToolStripMenuItem"
        Me.ComercialLagunaToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ComercialLagunaToolStripMenuItem.Text = "&Comercial Laguna"
        '
        'CierreDeCajaToolStripMenuItem
        '
        Me.CierreDeCajaToolStripMenuItem.Image = CType(resources.GetObject("CierreDeCajaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CierreDeCajaToolStripMenuItem.Name = "CierreDeCajaToolStripMenuItem"
        Me.CierreDeCajaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CierreDeCajaToolStripMenuItem.Text = "&Cierre de caja"
        '
        'GrupoFazaToolStripMenuItem
        '
        Me.GrupoFazaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.ToolStripSeparator2, Me.CajaChicaToolStripMenuItem})
        Me.GrupoFazaToolStripMenuItem.Image = CType(resources.GetObject("GrupoFazaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrupoFazaToolStripMenuItem.Name = "GrupoFazaToolStripMenuItem"
        Me.GrupoFazaToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.GrupoFazaToolStripMenuItem.Text = "&Grupo Faza"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Image = CType(resources.GetObject("MantenimientoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimiento"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'CajaChicaToolStripMenuItem
        '
        Me.CajaChicaToolStripMenuItem.Image = CType(resources.GetObject("CajaChicaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CajaChicaToolStripMenuItem.Name = "CajaChicaToolStripMenuItem"
        Me.CajaChicaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CajaChicaToolStripMenuItem.Text = "&Caja chica"
        '
        'AdministradoresGafzaToolStripMenuItem
        '
        Me.AdministradoresGafzaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncidenciasToolStripMenuItem})
        Me.AdministradoresGafzaToolStripMenuItem.Name = "AdministradoresGafzaToolStripMenuItem"
        Me.AdministradoresGafzaToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.AdministradoresGafzaToolStripMenuItem.Text = "&Administradores Gafza"
        '
        'IncidenciasToolStripMenuItem
        '
        Me.IncidenciasToolStripMenuItem.Image = CType(resources.GetObject("IncidenciasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IncidenciasToolStripMenuItem.Name = "IncidenciasToolStripMenuItem"
        Me.IncidenciasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IncidenciasToolStripMenuItem.Text = "&Incidencias"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'MenuGrupoFaza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(692, 42)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuGrupoFaza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupo Faza"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdrmintradorDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GasolineraFazaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValesPuntoGasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CierreDeCajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComercialLagunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoFazaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CajaChicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministradoresGafzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncidenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
