<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValesTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValesTransferencia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdValeTrans = New System.Windows.Forms.TextBox()
        Me.TxtFechaCaptura = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFolioCobro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFechaTrans = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCajero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNumMovimiento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtImporteTrans = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboNombreClienteVT = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtIdCarga = New System.Windows.Forms.TextBox()
        Me.CboTurno = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.CboSucursal = New System.Windows.Forms.ComboBox()
        Me.BtnAgregarCarga = New System.Windows.Forms.Button()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CboProducto = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtFechaCorte = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtConductor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPlacas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDescripcionVeh = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DgvValesTrans = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
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
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmCancelar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmEditar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmEliminar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtNumIdValTrans = New System.Windows.Forms.TextBox()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvValesTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIdValeTrans)
        Me.GroupBox1.Controls.Add(Me.TxtFechaCaptura)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtFactura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtFolioCobro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtFechaTrans)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtCajero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNumMovimiento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtImporteTrans)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNumCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CboNombreClienteVT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 229)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'TxtIdValeTrans
        '
        Me.TxtIdValeTrans.Location = New System.Drawing.Point(526, 59)
        Me.TxtIdValeTrans.Name = "TxtIdValeTrans"
        Me.TxtIdValeTrans.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdValeTrans.TabIndex = 30
        Me.TxtIdValeTrans.Visible = False
        '
        'TxtFechaCaptura
        '
        Me.TxtFechaCaptura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFechaCaptura.Location = New System.Drawing.Point(513, 141)
        Me.TxtFechaCaptura.Name = "TxtFechaCaptura"
        Me.TxtFechaCaptura.Size = New System.Drawing.Size(100, 13)
        Me.TxtFechaCaptura.TabIndex = 29
        Me.TxtFechaCaptura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(276, 150)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(16, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Factura:"
        '
        'TxtFactura
        '
        Me.TxtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFactura.Location = New System.Drawing.Point(177, 202)
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(100, 20)
        Me.TxtFactura.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Folio cobro:"
        '
        'TxtFolioCobro
        '
        Me.TxtFolioCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFolioCobro.Location = New System.Drawing.Point(177, 176)
        Me.TxtFolioCobro.Name = "TxtFolioCobro"
        Me.TxtFolioCobro.Size = New System.Drawing.Size(100, 20)
        Me.TxtFolioCobro.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fecha transferencia:"
        '
        'TxtFechaTrans
        '
        Me.TxtFechaTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaTrans.Location = New System.Drawing.Point(177, 150)
        Me.TxtFechaTrans.Name = "TxtFechaTrans"
        Me.TxtFechaTrans.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaTrans.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cajero (a):"
        '
        'TxtCajero
        '
        Me.TxtCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCajero.Location = New System.Drawing.Point(177, 124)
        Me.TxtCajero.Name = "TxtCajero"
        Me.TxtCajero.Size = New System.Drawing.Size(175, 20)
        Me.TxtCajero.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "N° Movimiento estado de cuenta:"
        '
        'TxtNumMovimiento
        '
        Me.TxtNumMovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumMovimiento.Location = New System.Drawing.Point(177, 98)
        Me.TxtNumMovimiento.Name = "TxtNumMovimiento"
        Me.TxtNumMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumMovimiento.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Importe transferencia:"
        '
        'TxtImporteTrans
        '
        Me.TxtImporteTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtImporteTrans.Location = New System.Drawing.Point(177, 72)
        Me.TxtImporteTrans.Name = "TxtImporteTrans"
        Me.TxtImporteTrans.Size = New System.Drawing.Size(100, 20)
        Me.TxtImporteTrans.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "N° cliente:"
        '
        'TxtNumCliente
        '
        Me.TxtNumCliente.Location = New System.Drawing.Point(177, 46)
        Me.TxtNumCliente.Name = "TxtNumCliente"
        Me.TxtNumCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre cliente:"
        '
        'CboNombreClienteVT
        '
        Me.CboNombreClienteVT.FormattingEnabled = True
        Me.CboNombreClienteVT.Location = New System.Drawing.Point(177, 19)
        Me.CboNombreClienteVT.Name = "CboNombreClienteVT"
        Me.CboNombreClienteVT.Size = New System.Drawing.Size(175, 21)
        Me.CboNombreClienteVT.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtIdCarga)
        Me.GroupBox2.Controls.Add(Me.CboTurno)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.CboSucursal)
        Me.GroupBox2.Controls.Add(Me.BtnAgregarCarga)
        Me.GroupBox2.Controls.Add(Me.TxtImporte)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioUnitario)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.CboProducto)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtFechaCorte)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtConductor)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtPlacas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcionVeh)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 238)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de la carga"
        '
        'TxtIdCarga
        '
        Me.TxtIdCarga.Location = New System.Drawing.Point(622, 55)
        Me.TxtIdCarga.Name = "TxtIdCarga"
        Me.TxtIdCarga.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdCarga.TabIndex = 22
        Me.TxtIdCarga.Visible = False
        '
        'CboTurno
        '
        Me.CboTurno.FormattingEnabled = True
        Me.CboTurno.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CboTurno.Location = New System.Drawing.Point(177, 149)
        Me.CboTurno.Name = "CboTurno"
        Me.CboTurno.Size = New System.Drawing.Size(100, 21)
        Me.CboTurno.TabIndex = 21
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(277, 123)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(15, 20)
        Me.DateTimePicker2.TabIndex = 20
        '
        'CboSucursal
        '
        Me.CboSucursal.FormattingEnabled = True
        Me.CboSucursal.Items.AddRange(New Object() {"SANTA FE", "MIELERAS", "SEIS DE ENERO", "BRAVO", "AZULEJOS"})
        Me.CboSucursal.Location = New System.Drawing.Point(177, 19)
        Me.CboSucursal.Name = "CboSucursal"
        Me.CboSucursal.Size = New System.Drawing.Size(216, 21)
        Me.CboSucursal.TabIndex = 9
        '
        'BtnAgregarCarga
        '
        Me.BtnAgregarCarga.Location = New System.Drawing.Point(603, 209)
        Me.BtnAgregarCarga.Name = "BtnAgregarCarga"
        Me.BtnAgregarCarga.Size = New System.Drawing.Size(100, 23)
        Me.BtnAgregarCarga.TabIndex = 19
        Me.BtnAgregarCarga.Text = "Agregar Carga"
        Me.BtnAgregarCarga.UseVisualStyleBackColor = True
        '
        'TxtImporte
        '
        Me.TxtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtImporte.Location = New System.Drawing.Point(603, 175)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(100, 20)
        Me.TxtImporte.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(552, 178)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Importe:"
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(446, 175)
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecioUnitario.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(363, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Precio unitario:"
        '
        'CboProducto
        '
        Me.CboProducto.FormattingEnabled = True
        Me.CboProducto.Items.AddRange(New Object() {"MAGNA", "PREMIUM", "DIESEL", "OTRO"})
        Me.CboProducto.Location = New System.Drawing.Point(236, 175)
        Me.CboProducto.Name = "CboProducto"
        Me.CboProducto.Size = New System.Drawing.Size(121, 21)
        Me.CboProducto.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(177, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Producto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Cantidad:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidad.Location = New System.Drawing.Point(71, 175)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Turno:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Fecha Corte:"
        '
        'TxtFechaCorte
        '
        Me.TxtFechaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaCorte.Location = New System.Drawing.Point(177, 123)
        Me.TxtFechaCorte.Name = "TxtFechaCorte"
        Me.TxtFechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaCorte.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Conductor:"
        '
        'TxtConductor
        '
        Me.TxtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtConductor.Location = New System.Drawing.Point(177, 97)
        Me.TxtConductor.Name = "TxtConductor"
        Me.TxtConductor.Size = New System.Drawing.Size(216, 20)
        Me.TxtConductor.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Placas:"
        '
        'TxtPlacas
        '
        Me.TxtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlacas.Location = New System.Drawing.Point(177, 71)
        Me.TxtPlacas.Name = "TxtPlacas"
        Me.TxtPlacas.Size = New System.Drawing.Size(100, 20)
        Me.TxtPlacas.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Descripcion de vehiculo:"
        '
        'TxtDescripcionVeh
        '
        Me.TxtDescripcionVeh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcionVeh.Location = New System.Drawing.Point(177, 45)
        Me.TxtDescripcionVeh.Name = "TxtDescripcionVeh"
        Me.TxtDescripcionVeh.Size = New System.Drawing.Size(216, 20)
        Me.TxtDescripcionVeh.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Sucursal:"
        '
        'DgvValesTrans
        '
        Me.DgvValesTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvValesTrans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvValesTrans.BackgroundColor = System.Drawing.Color.White
        Me.DgvValesTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvValesTrans.Location = New System.Drawing.Point(12, 530)
        Me.DgvValesTrans.Name = "DgvValesTrans"
        Me.DgvValesTrans.Size = New System.Drawing.Size(763, 280)
        Me.DgvValesTrans.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 816)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Visible = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(170, 816)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 19
        Me.TxtCodigo.Visible = False
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(305, 815)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdCliente.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarYCerrarToolStripMenuItem, Me.TsmGuardarNueVC, Me.GuardarCambiosToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 21
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
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchioToolStripMenuItem, Me.TsmImprimir, Me.EdicionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip2.TabIndex = 22
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
        'TsmImprimir
        '
        Me.TsmImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmImprimirVale})
        Me.TsmImprimir.Name = "TsmImprimir"
        Me.TsmImprimir.Size = New System.Drawing.Size(65, 20)
        Me.TsmImprimir.Text = "&Imprimir"
        '
        'TsmImprimirVale
        '
        Me.TsmImprimirVale.Image = CType(resources.GetObject("TsmImprimirVale.Image"), System.Drawing.Image)
        Me.TsmImprimirVale.Name = "TsmImprimirVale"
        Me.TsmImprimirVale.Size = New System.Drawing.Size(144, 22)
        Me.TsmImprimirVale.Text = "Imprimir vale"
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
        'TxtNumIdValTrans
        '
        Me.TxtNumIdValTrans.Location = New System.Drawing.Point(421, 815)
        Me.TxtNumIdValTrans.Name = "TxtNumIdValTrans"
        Me.TxtNumIdValTrans.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumIdValTrans.TabIndex = 23
        Me.TxtNumIdValTrans.Visible = False
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'FrmValesTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 749)
        Me.Controls.Add(Me.TxtNumIdValTrans)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.TxtIdCliente)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DgvValesTrans)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmValesTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vales de transferencia"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.DgvValesTrans,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.MenuStrip2.ResumeLayout(false)
        Me.MenuStrip2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCajero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNumMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtImporteTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNumCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboNombreClienteVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFolioCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaTrans As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtConductor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcionVeh As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents DgvValesTrans As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAgregarCarga As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdCliente As System.Windows.Forms.TextBox
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
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmCancelar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmEditar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmEliminar2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFechaCaptura As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdCarga As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdValeTrans As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumIdValTrans As System.Windows.Forms.TextBox
    Friend WithEvents PDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
