<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchiviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValeCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValeAnexoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValesTransferenciaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarVistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActualizarVistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnValesTransferencia = New System.Windows.Forms.Button()
        Me.BtnValesAnexoClientes = New System.Windows.Forms.Button()
        Me.BtnValesCredito = New System.Windows.Forms.Button()
        Me.BtnCatalogo = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbNuevo = New System.Windows.Forms.ToolStripSplitButton()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValesAnexoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValesTransferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsmVista = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnRefrescar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvGeneral = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtCurrentIndex = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiviToolStripMenuItem, Me.VerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchiviToolStripMenuItem
        '
        Me.ArchiviToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ToolStripSeparator1, Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator6, Me.SalirToolStripMenuItem})
        Me.ArchiviToolStripMenuItem.Name = "ArchiviToolStripMenuItem"
        Me.ArchiviToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchiviToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem1, Me.ValeCreditoToolStripMenuItem, Me.ValeAnexoClienteToolStripMenuItem, Me.ValesTransferenciaToolStripMenuItem1})
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.ClienteToolStripMenuItem1.Text = "Catalogo liente"
        '
        'ValeCreditoToolStripMenuItem
        '
        Me.ValeCreditoToolStripMenuItem.Name = "ValeCreditoToolStripMenuItem"
        Me.ValeCreditoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ValeCreditoToolStripMenuItem.Text = "&Vale credito"
        '
        'ValeAnexoClienteToolStripMenuItem
        '
        Me.ValeAnexoClienteToolStripMenuItem.Name = "ValeAnexoClienteToolStripMenuItem"
        Me.ValeAnexoClienteToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ValeAnexoClienteToolStripMenuItem.Text = "&Vale anexo cliente"
        '
        'ValesTransferenciaToolStripMenuItem1
        '
        Me.ValesTransferenciaToolStripMenuItem1.Name = "ValesTransferenciaToolStripMenuItem1"
        Me.ValesTransferenciaToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.ValesTransferenciaToolStripMenuItem1.Text = "Vales transferencia"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(135, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarVistaToolStripMenuItem, Me.ToolStripSeparator8, Me.ActualizarVistaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "&Ver"
        '
        'PersonalizarVistaToolStripMenuItem
        '
        Me.PersonalizarVistaToolStripMenuItem.Name = "PersonalizarVistaToolStripMenuItem"
        Me.PersonalizarVistaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PersonalizarVistaToolStripMenuItem.Text = "&Personalizar Vista"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(162, 6)
        Me.ToolStripSeparator8.Visible = False
        '
        'ActualizarVistaToolStripMenuItem
        '
        Me.ActualizarVistaToolStripMenuItem.Image = CType(resources.GetObject("ActualizarVistaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActualizarVistaToolStripMenuItem.Name = "ActualizarVistaToolStripMenuItem"
        Me.ActualizarVistaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ActualizarVistaToolStripMenuItem.Text = "Actualizar vista"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnValesTransferencia)
        Me.Panel1.Controls.Add(Me.BtnValesAnexoClientes)
        Me.Panel1.Controls.Add(Me.BtnValesCredito)
        Me.Panel1.Controls.Add(Me.BtnCatalogo)
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 1013)
        Me.Panel1.TabIndex = 1
        '
        'BtnValesTransferencia
        '
        Me.BtnValesTransferencia.Location = New System.Drawing.Point(10, 67)
        Me.BtnValesTransferencia.Name = "BtnValesTransferencia"
        Me.BtnValesTransferencia.Size = New System.Drawing.Size(114, 23)
        Me.BtnValesTransferencia.TabIndex = 3
        Me.BtnValesTransferencia.Text = "Vales Transferencia"
        Me.BtnValesTransferencia.UseVisualStyleBackColor = True
        '
        'BtnValesAnexoClientes
        '
        Me.BtnValesAnexoClientes.Location = New System.Drawing.Point(10, 45)
        Me.BtnValesAnexoClientes.Name = "BtnValesAnexoClientes"
        Me.BtnValesAnexoClientes.Size = New System.Drawing.Size(114, 23)
        Me.BtnValesAnexoClientes.TabIndex = 2
        Me.BtnValesAnexoClientes.Text = "Vales Anexo Cliente"
        Me.BtnValesAnexoClientes.UseVisualStyleBackColor = True
        '
        'BtnValesCredito
        '
        Me.BtnValesCredito.Location = New System.Drawing.Point(10, 23)
        Me.BtnValesCredito.Name = "BtnValesCredito"
        Me.BtnValesCredito.Size = New System.Drawing.Size(114, 23)
        Me.BtnValesCredito.TabIndex = 1
        Me.BtnValesCredito.Text = "Vales Credito"
        Me.BtnValesCredito.UseVisualStyleBackColor = True
        '
        'BtnCatalogo
        '
        Me.BtnCatalogo.Location = New System.Drawing.Point(10, 1)
        Me.BtnCatalogo.Name = "BtnCatalogo"
        Me.BtnCatalogo.Size = New System.Drawing.Size(114, 23)
        Me.BtnCatalogo.TabIndex = 0
        Me.BtnCatalogo.Text = "Catalogo Clientes"
        Me.BtnCatalogo.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbNuevo, Me.ToolStripSeparator4, Me.TsbImprimir, Me.ToolStripSeparator5, Me.TsbBuscar, Me.ToolStripSeparator7, Me.TsmVista})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsbNuevo
        '
        Me.TsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbNuevo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ValesToolStripMenuItem, Me.ValesAnexoClienteToolStripMenuItem, Me.ValesTransferenciaToolStripMenuItem})
        Me.TsbNuevo.Image = CType(resources.GetObject("TsbNuevo.Image"), System.Drawing.Image)
        Me.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbNuevo.Name = "TsbNuevo"
        Me.TsbNuevo.Size = New System.Drawing.Size(32, 22)
        Me.TsbNuevo.Text = "ToolStripSplitButton1"
        Me.TsbNuevo.ToolTipText = "Nuevo"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClienteToolStripMenuItem.Text = "Catalogo clientes"
        '
        'ValesToolStripMenuItem
        '
        Me.ValesToolStripMenuItem.Name = "ValesToolStripMenuItem"
        Me.ValesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ValesToolStripMenuItem.Text = "Vales credito"
        '
        'ValesAnexoClienteToolStripMenuItem
        '
        Me.ValesAnexoClienteToolStripMenuItem.Name = "ValesAnexoClienteToolStripMenuItem"
        Me.ValesAnexoClienteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ValesAnexoClienteToolStripMenuItem.Text = "Vales anexo cliente"
        '
        'ValesTransferenciaToolStripMenuItem
        '
        Me.ValesTransferenciaToolStripMenuItem.Name = "ValesTransferenciaToolStripMenuItem"
        Me.ValesTransferenciaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ValesTransferenciaToolStripMenuItem.Text = "Vales transferencia"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TsbImprimir
        '
        Me.TsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbImprimir.Image = CType(resources.GetObject("TsbImprimir.Image"), System.Drawing.Image)
        Me.TsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbImprimir.Name = "TsbImprimir"
        Me.TsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.TsbImprimir.Text = "ToolStripButton1"
        Me.TsbImprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator5.Visible = False
        '
        'TsbBuscar
        '
        Me.TsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbBuscar.Image = CType(resources.GetObject("TsbBuscar.Image"), System.Drawing.Image)
        Me.TsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbBuscar.Name = "TsbBuscar"
        Me.TsbBuscar.Size = New System.Drawing.Size(23, 22)
        Me.TsbBuscar.Text = "ToolStripButton2"
        Me.TsbBuscar.ToolTipText = "Buscar"
        Me.TsbBuscar.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'TsmVista
        '
        Me.TsmVista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsmVista.Image = CType(resources.GetObject("TsmVista.Image"), System.Drawing.Image)
        Me.TsmVista.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsmVista.Name = "TsmVista"
        Me.TsmVista.Size = New System.Drawing.Size(23, 22)
        Me.TsmVista.Text = "ToolStripButton1"
        Me.TsmVista.ToolTipText = "Periodo de vista"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.BtnRefrescar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(140, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1784, 50)
        Me.Panel2.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(565, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 5
        Me.DateTimePicker2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(359, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Visible = False
        '
        'BtnRefrescar
        '
        Me.BtnRefrescar.BackColor = System.Drawing.Color.White
        Me.BtnRefrescar.Location = New System.Drawing.Point(771, 17)
        Me.BtnRefrescar.Name = "BtnRefrescar"
        Me.BtnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefrescar.TabIndex = 2
        Me.BtnRefrescar.Text = "Refrescar"
        Me.BtnRefrescar.UseVisualStyleBackColor = False
        Me.BtnRefrescar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 33)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 0
        '
        'DgvGeneral
        '
        Me.DgvGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvGeneral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvGeneral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGeneral.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgvGeneral.Location = New System.Drawing.Point(140, 104)
        Me.DgvGeneral.Name = "DgvGeneral"
        Me.DgvGeneral.ReadOnly = True
        Me.DgvGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvGeneral.Size = New System.Drawing.Size(1250, 600)
        Me.DgvGeneral.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarToolStripMenuItem, Me.ToolStripSeparator2, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 54)
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Image = CType(resources.GetObject("MostrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(114, 6)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'TxtCurrentIndex
        '
        Me.TxtCurrentIndex.Location = New System.Drawing.Point(398, 4)
        Me.TxtCurrentIndex.Name = "TxtCurrentIndex"
        Me.TxtCurrentIndex.Size = New System.Drawing.Size(100, 20)
        Me.TxtCurrentIndex.TabIndex = 5
        Me.TxtCurrentIndex.Visible = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TxtCurrentIndex)
        Me.Controls.Add(Me.DgvGeneral)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Vales Faza"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.DgvGeneral,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchiviToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnValesTransferencia As System.Windows.Forms.Button
    Friend WithEvents BtnValesAnexoClientes As System.Windows.Forms.Button
    Friend WithEvents BtnValesCredito As System.Windows.Forms.Button
    Friend WithEvents BtnCatalogo As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TsbNuevo As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValesAnexoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValesTransferenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValeCreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValeAnexoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DgvGeneral As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalizarVistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsmVista As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActualizarVistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValesTransferenciaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtCurrentIndex As System.Windows.Forms.TextBox
    Friend WithEvents BtnRefrescar As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
