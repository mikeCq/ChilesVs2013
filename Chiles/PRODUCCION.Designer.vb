<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produccion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produccion))
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.GbCaptura = New System.Windows.Forms.GroupBox()
        Me.BtEliminarBote = New System.Windows.Forms.Button()
        Me.BtCerrar = New System.Windows.Forms.Button()
        Me.TxCaptura = New System.Windows.Forms.TextBox()
        Me.GbAbrir = New System.Windows.Forms.GroupBox()
        Me.GbBusquedaRapida = New System.Windows.Forms.GroupBox()
        Me.BtBuscarBR = New System.Windows.Forms.Button()
        Me.NuSumaPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbBotesTotalBR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbDiaBR = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbIdBR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbProducto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.NuPrecio = New System.Windows.Forms.NumericUpDown()
        Me.TxNombreDia = New System.Windows.Forms.TextBox()
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.BtIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsModificarPrecio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripButton()
        Me.DgBoteIngresado = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbConteo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GbCaptura.SuspendLayout()
        Me.GbAbrir.SuspendLayout()
        Me.GbBusquedaRapida.SuspendLayout()
        CType(Me.NuSumaPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgBoteIngresado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtFecha
        '
        Me.DtFecha.Enabled = False
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(699, 2)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(114, 20)
        Me.DtFecha.TabIndex = 9
        '
        'GbCaptura
        '
        Me.GbCaptura.BackColor = System.Drawing.Color.Transparent
        Me.GbCaptura.Controls.Add(Me.BtEliminarBote)
        Me.GbCaptura.Controls.Add(Me.BtCerrar)
        Me.GbCaptura.Controls.Add(Me.TxCaptura)
        Me.GbCaptura.Location = New System.Drawing.Point(0, 210)
        Me.GbCaptura.Name = "GbCaptura"
        Me.GbCaptura.Size = New System.Drawing.Size(825, 84)
        Me.GbCaptura.TabIndex = 1
        Me.GbCaptura.TabStop = False
        '
        'BtEliminarBote
        '
        Me.BtEliminarBote.BackColor = System.Drawing.Color.Transparent
        Me.BtEliminarBote.BackgroundImage = CType(resources.GetObject("BtEliminarBote.BackgroundImage"), System.Drawing.Image)
        Me.BtEliminarBote.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtEliminarBote.FlatAppearance.BorderSize = 5
        Me.BtEliminarBote.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEliminarBote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEliminarBote.Location = New System.Drawing.Point(699, 35)
        Me.BtEliminarBote.Name = "BtEliminarBote"
        Me.BtEliminarBote.Size = New System.Drawing.Size(114, 40)
        Me.BtEliminarBote.TabIndex = 2
        Me.BtEliminarBote.Text = "Eliminar Bote"
        Me.BtEliminarBote.UseVisualStyleBackColor = False
        '
        'BtCerrar
        '
        Me.BtCerrar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtCerrar.BackgroundImage = CType(resources.GetObject("BtCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtCerrar.FlatAppearance.BorderSize = 5
        Me.BtCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCerrar.Location = New System.Drawing.Point(483, 35)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(114, 40)
        Me.BtCerrar.TabIndex = 1
        Me.BtCerrar.Text = "Cerrar Produccion"
        Me.BtCerrar.UseVisualStyleBackColor = False
        '
        'TxCaptura
        '
        Me.TxCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCaptura.Location = New System.Drawing.Point(6, 13)
        Me.TxCaptura.Name = "TxCaptura"
        Me.TxCaptura.Size = New System.Drawing.Size(273, 62)
        Me.TxCaptura.TabIndex = 0
        '
        'GbAbrir
        '
        Me.GbAbrir.Controls.Add(Me.GbBusquedaRapida)
        Me.GbAbrir.Controls.Add(Me.CbProducto)
        Me.GbAbrir.Controls.Add(Me.Label2)
        Me.GbAbrir.Controls.Add(Me.CbEstatus)
        Me.GbAbrir.Controls.Add(Me.NuPrecio)
        Me.GbAbrir.Controls.Add(Me.TxNombreDia)
        Me.GbAbrir.Controls.Add(Me.TxIdProduccion)
        Me.GbAbrir.Controls.Add(Me.BtIniciar)
        Me.GbAbrir.Controls.Add(Me.Label1)
        Me.GbAbrir.Controls.Add(Me.Label5)
        Me.GbAbrir.Controls.Add(Me.Label4)
        Me.GbAbrir.Location = New System.Drawing.Point(0, 34)
        Me.GbAbrir.Name = "GbAbrir"
        Me.GbAbrir.Size = New System.Drawing.Size(825, 135)
        Me.GbAbrir.TabIndex = 0
        Me.GbAbrir.TabStop = False
        '
        'GbBusquedaRapida
        '
        Me.GbBusquedaRapida.Controls.Add(Me.BtBuscarBR)
        Me.GbBusquedaRapida.Controls.Add(Me.NuSumaPrecio)
        Me.GbBusquedaRapida.Controls.Add(Me.Label8)
        Me.GbBusquedaRapida.Controls.Add(Me.TbBotesTotalBR)
        Me.GbBusquedaRapida.Controls.Add(Me.Label9)
        Me.GbBusquedaRapida.Controls.Add(Me.CbDiaBR)
        Me.GbBusquedaRapida.Controls.Add(Me.Label7)
        Me.GbBusquedaRapida.Controls.Add(Me.TbIdBR)
        Me.GbBusquedaRapida.Controls.Add(Me.Label6)
        Me.GbBusquedaRapida.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GbBusquedaRapida.Location = New System.Drawing.Point(483, 12)
        Me.GbBusquedaRapida.Name = "GbBusquedaRapida"
        Me.GbBusquedaRapida.Size = New System.Drawing.Size(336, 108)
        Me.GbBusquedaRapida.TabIndex = 5
        Me.GbBusquedaRapida.TabStop = False
        Me.GbBusquedaRapida.Text = "Busqueda Rapida"
        '
        'BtBuscarBR
        '
        Me.BtBuscarBR.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtBuscarBR.BackgroundImage = CType(resources.GetObject("BtBuscarBR.BackgroundImage"), System.Drawing.Image)
        Me.BtBuscarBR.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtBuscarBR.FlatAppearance.BorderSize = 5
        Me.BtBuscarBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtBuscarBR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtBuscarBR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtBuscarBR.Location = New System.Drawing.Point(44, 69)
        Me.BtBuscarBR.Name = "BtBuscarBR"
        Me.BtBuscarBR.Size = New System.Drawing.Size(79, 28)
        Me.BtBuscarBR.TabIndex = 3
        Me.BtBuscarBR.Text = "Buscar"
        Me.BtBuscarBR.UseVisualStyleBackColor = False
        '
        'NuSumaPrecio
        '
        Me.NuSumaPrecio.DecimalPlaces = 2
        Me.NuSumaPrecio.Enabled = False
        Me.NuSumaPrecio.Location = New System.Drawing.Point(244, 42)
        Me.NuSumaPrecio.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuSumaPrecio.Name = "NuSumaPrecio"
        Me.NuSumaPrecio.Size = New System.Drawing.Size(79, 20)
        Me.NuSumaPrecio.TabIndex = 10
        Me.NuSumaPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(178, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "$"
        '
        'TbBotesTotalBR
        '
        Me.TbBotesTotalBR.Enabled = False
        Me.TbBotesTotalBR.Location = New System.Drawing.Point(264, 17)
        Me.TbBotesTotalBR.Name = "TbBotesTotalBR"
        Me.TbBotesTotalBR.Size = New System.Drawing.Size(59, 20)
        Me.TbBotesTotalBR.TabIndex = 7
        Me.TbBotesTotalBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Botes Total"
        '
        'CbDiaBR
        '
        Me.CbDiaBR.FormattingEnabled = True
        Me.CbDiaBR.Location = New System.Drawing.Point(44, 42)
        Me.CbDiaBR.Name = "CbDiaBR"
        Me.CbDiaBR.Size = New System.Drawing.Size(121, 21)
        Me.CbDiaBR.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dia"
        '
        'TbIdBR
        '
        Me.TbIdBR.Location = New System.Drawing.Point(44, 17)
        Me.TbIdBR.Name = "TbIdBR"
        Me.TbIdBR.Size = New System.Drawing.Size(54, 20)
        Me.TbIdBR.TabIndex = 1
        Me.TbIdBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ID"
        '
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(197, 9)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(125, 21)
        Me.CbProducto.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Producto :"
        '
        'CbEstatus
        '
        Me.CbEstatus.Enabled = False
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(197, 62)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(125, 21)
        Me.CbEstatus.TabIndex = 2
        '
        'NuPrecio
        '
        Me.NuPrecio.DecimalPlaces = 2
        Me.NuPrecio.Location = New System.Drawing.Point(197, 36)
        Me.NuPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NuPrecio.Name = "NuPrecio"
        Me.NuPrecio.Size = New System.Drawing.Size(125, 20)
        Me.NuPrecio.TabIndex = 1
        Me.NuPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxNombreDia
        '
        Me.TxNombreDia.Enabled = False
        Me.TxNombreDia.Location = New System.Drawing.Point(361, 12)
        Me.TxNombreDia.Name = "TxNombreDia"
        Me.TxNombreDia.Size = New System.Drawing.Size(114, 20)
        Me.TxNombreDia.TabIndex = 0
        Me.TxNombreDia.Visible = False
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(361, 36)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(114, 20)
        Me.TxIdProduccion.TabIndex = 0
        Me.TxIdProduccion.Visible = False
        '
        'BtIniciar
        '
        Me.BtIniciar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtIniciar.BackgroundImage = CType(resources.GetObject("BtIniciar.BackgroundImage"), System.Drawing.Image)
        Me.BtIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtIniciar.FlatAppearance.BorderSize = 5
        Me.BtIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtIniciar.Location = New System.Drawing.Point(6, 94)
        Me.BtIniciar.Name = "BtIniciar"
        Me.BtIniciar.Size = New System.Drawing.Size(125, 30)
        Me.BtIniciar.TabIndex = 2
        Me.BtIniciar.Text = "Abrir Produccion"
        Me.BtIniciar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(326, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dia :"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estatus :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2, Me.TsGuardar, Me.ToolStripSeparator4, Me.TsModificarPrecio, Me.ToolStripSeparator2, Me.TsEliminar, Me.ToolStripSeparator3, Me.TsConsultar, Me.ToolStripSeparator1, Me.TsSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(821, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TsNuevo.Image = CType(resources.GetObject("TsNuevo.Image"), System.Drawing.Image)
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(64, 22)
        Me.TsNuevo.Text = "Nuevo"
        Me.TsNuevo.ToolTipText = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 25)
        '
        'TsGuardar
        '
        Me.TsGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsGuardar.Name = "TsGuardar"
        Me.TsGuardar.Size = New System.Drawing.Size(116, 22)
        Me.TsGuardar.Text = "Guardar/Actualizar"
        Me.TsGuardar.ToolTipText = "Guardar/Actualizar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TsModificarPrecio
        '
        Me.TsModificarPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TsModificarPrecio.Image = CType(resources.GetObject("TsModificarPrecio.Image"), System.Drawing.Image)
        Me.TsModificarPrecio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsModificarPrecio.Name = "TsModificarPrecio"
        Me.TsModificarPrecio.Size = New System.Drawing.Size(118, 22)
        Me.TsModificarPrecio.Text = "Modificar Precio"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TsEliminar
        '
        Me.TsEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsEliminar.Name = "TsEliminar"
        Me.TsEliminar.Size = New System.Drawing.Size(120, 22)
        Me.TsEliminar.Text = "Eliminar Produccion"
        Me.TsEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TsEliminar.ToolTipText = "Eliminar"
        Me.TsEliminar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TsConsultar
        '
        Me.TsConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TsConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsConsultar.Name = "TsConsultar"
        Me.TsConsultar.Size = New System.Drawing.Size(123, 22)
        Me.TsConsultar.Text = "Consulta Produccion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsSalir
        '
        Me.TsSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TsSalir.Image = CType(resources.GetObject("TsSalir.Image"), System.Drawing.Image)
        Me.TsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(51, 22)
        Me.TsSalir.Text = "Salir"
        '
        'DgBoteIngresado
        '
        Me.DgBoteIngresado.AllowUserToAddRows = False
        Me.DgBoteIngresado.AllowUserToDeleteRows = False
        Me.DgBoteIngresado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBoteIngresado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBoteIngresado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBoteIngresado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBoteIngresado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBoteIngresado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBoteIngresado.Location = New System.Drawing.Point(12, 300)
        Me.DgBoteIngresado.MultiSelect = False
        Me.DgBoteIngresado.Name = "DgBoteIngresado"
        Me.DgBoteIngresado.ReadOnly = True
        Me.DgBoteIngresado.RowHeadersVisible = False
        Me.DgBoteIngresado.RowHeadersWidth = 40
        Me.DgBoteIngresado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBoteIngresado.Size = New System.Drawing.Size(801, 281)
        Me.DgBoteIngresado.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(7, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CAPTURAR BOTES :"
        '
        'TbConteo
        '
        Me.TbConteo.Enabled = False
        Me.TbConteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbConteo.Location = New System.Drawing.Point(645, 175)
        Me.TbConteo.Name = "TbConteo"
        Me.TbConteo.Size = New System.Drawing.Size(168, 38)
        Me.TbConteo.TabIndex = 11
        Me.TbConteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(501, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 29)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "CONTEO :"
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 587)
        Me.Controls.Add(Me.TbConteo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.GbCaptura)
        Me.Controls.Add(Me.GbAbrir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DgBoteIngresado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produccion"
        Me.GbCaptura.ResumeLayout(False)
        Me.GbCaptura.PerformLayout()
        Me.GbAbrir.ResumeLayout(False)
        Me.GbAbrir.PerformLayout()
        Me.GbBusquedaRapida.ResumeLayout(False)
        Me.GbBusquedaRapida.PerformLayout()
        CType(Me.NuSumaPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgBoteIngresado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GbCaptura As System.Windows.Forms.GroupBox
    Friend WithEvents BtCerrar As System.Windows.Forms.Button
    Friend WithEvents TxCaptura As System.Windows.Forms.TextBox
    Friend WithEvents GbAbrir As System.Windows.Forms.GroupBox
    Friend WithEvents CbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents NuPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxNombreDia As System.Windows.Forms.TextBox
    Friend WithEvents TxIdProduccion As System.Windows.Forms.TextBox
    Friend WithEvents BtIniciar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DgBoteIngresado As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents CbProducto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TsNuevo As ToolStripButton
    Friend WithEvents TsModificarPrecio As ToolStripButton
    Friend WithEvents TsSalir As ToolStripButton
    Friend WithEvents BtEliminarBote As Button
    Friend WithEvents GbBusquedaRapida As GroupBox
    Friend WithEvents TbBotesTotalBR As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CbDiaBR As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbIdBR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NuSumaPrecio As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents BtBuscarBR As Button
    Friend WithEvents TbConteo As TextBox
    Friend WithEvents Label10 As Label
End Class
