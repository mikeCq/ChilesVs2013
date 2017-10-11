<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LIQUIDACIONES
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LIQUIDACIONES))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgBotesIngresados = New System.Windows.Forms.DataGridView()
        Me.GbLiquidacion = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtInicial = New System.Windows.Forms.DateTimePicker()
        Me.CbProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxCantidadBotes = New System.Windows.Forms.TextBox()
        Me.NuTotalPagar = New System.Windows.Forms.NumericUpDown()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.DgLiquidaciones = New System.Windows.Forms.DataGridView()
        CType(Me.DgBotesIngresados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbLiquidacion.SuspendLayout()
        CType(Me.NuTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgBotesIngresados
        '
        Me.DgBotesIngresados.AllowUserToAddRows = False
        Me.DgBotesIngresados.AllowUserToDeleteRows = False
        Me.DgBotesIngresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBotesIngresados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgBotesIngresados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgBotesIngresados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgBotesIngresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBotesIngresados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgBotesIngresados.Location = New System.Drawing.Point(3, 250)
        Me.DgBotesIngresados.MultiSelect = False
        Me.DgBotesIngresados.Name = "DgBotesIngresados"
        Me.DgBotesIngresados.ReadOnly = True
        Me.DgBotesIngresados.RowHeadersVisible = False
        Me.DgBotesIngresados.RowHeadersWidth = 40
        Me.DgBotesIngresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBotesIngresados.Size = New System.Drawing.Size(774, 231)
        Me.DgBotesIngresados.TabIndex = 16
        '
        'GbLiquidacion
        '
        Me.GbLiquidacion.Controls.Add(Me.Label7)
        Me.GbLiquidacion.Controls.Add(Me.Label9)
        Me.GbLiquidacion.Controls.Add(Me.DtFinal)
        Me.GbLiquidacion.Controls.Add(Me.DtInicial)
        Me.GbLiquidacion.Controls.Add(Me.CbProducto)
        Me.GbLiquidacion.Controls.Add(Me.Label5)
        Me.GbLiquidacion.Controls.Add(Me.Label6)
        Me.GbLiquidacion.Controls.Add(Me.Label2)
        Me.GbLiquidacion.Controls.Add(Me.Label4)
        Me.GbLiquidacion.Controls.Add(Me.DtFecha)
        Me.GbLiquidacion.Controls.Add(Me.Label3)
        Me.GbLiquidacion.Controls.Add(Me.TxCantidadBotes)
        Me.GbLiquidacion.Controls.Add(Me.NuTotalPagar)
        Me.GbLiquidacion.Controls.Add(Me.CbEstatus)
        Me.GbLiquidacion.Enabled = False
        Me.GbLiquidacion.Location = New System.Drawing.Point(0, 32)
        Me.GbLiquidacion.Name = "GbLiquidacion"
        Me.GbLiquidacion.Size = New System.Drawing.Size(780, 95)
        Me.GbLiquidacion.TabIndex = 15
        Me.GbLiquidacion.TabStop = False
        Me.GbLiquidacion.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(576, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Fecha final :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(576, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Fecha inicial :"
        '
        'DtFinal
        '
        Me.DtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFinal.Location = New System.Drawing.Point(668, 36)
        Me.DtFinal.Name = "DtFinal"
        Me.DtFinal.Size = New System.Drawing.Size(121, 20)
        Me.DtFinal.TabIndex = 20
        Me.DtFinal.Value = New Date(2000, 1, 1, 11, 18, 0, 0)
        '
        'DtInicial
        '
        Me.DtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtInicial.Location = New System.Drawing.Point(668, 10)
        Me.DtInicial.Name = "DtInicial"
        Me.DtInicial.Size = New System.Drawing.Size(121, 20)
        Me.DtInicial.TabIndex = 21
        Me.DtInicial.Value = New Date(2000, 1, 1, 10, 45, 0, 0)
        '
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(85, 13)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbProducto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Producto :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(12, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Estatus :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(211, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Botes :"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(85, 40)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(121, 20)
        Me.DtFecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(211, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total a Pagar :"
        '
        'TxCantidadBotes
        '
        Me.TxCantidadBotes.Location = New System.Drawing.Point(312, 9)
        Me.TxCantidadBotes.Name = "TxCantidadBotes"
        Me.TxCantidadBotes.Size = New System.Drawing.Size(121, 20)
        Me.TxCantidadBotes.TabIndex = 4
        Me.TxCantidadBotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuTotalPagar
        '
        Me.NuTotalPagar.DecimalPlaces = 2
        Me.NuTotalPagar.Location = New System.Drawing.Point(312, 35)
        Me.NuTotalPagar.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NuTotalPagar.Name = "NuTotalPagar"
        Me.NuTotalPagar.Size = New System.Drawing.Size(121, 20)
        Me.NuTotalPagar.TabIndex = 5
        Me.NuTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(85, 66)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 14
        '
        'TxIdProduccion
        '
        Me.TxIdProduccion.Location = New System.Drawing.Point(656, 2)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(121, 20)
        Me.TxIdProduccion.TabIndex = 13
        Me.TxIdProduccion.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2, Me.TsGuardar, Me.ToolStripSeparator2, Me.TsEliminar, Me.ToolStripButton4, Me.TsImprimir, Me.ToolStripSeparator1, Me.TsConsultar, Me.ToolStripSeparator3, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(781, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsNuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(48, 22)
        Me.TsNuevo.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 25)
        '
        'TsGuardar
        '
        Me.TsGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.TsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsGuardar.Name = "TsGuardar"
        Me.TsGuardar.Size = New System.Drawing.Size(56, 22)
        Me.TsGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TsEliminar
        '
        Me.TsEliminar.Enabled = False
        Me.TsEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.TsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsEliminar.Name = "TsEliminar"
        Me.TsEliminar.Size = New System.Drawing.Size(55, 22)
        Me.TsEliminar.Text = "Eliminar"
        Me.TsEliminar.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(6, 25)
        '
        'TsImprimir
        '
        Me.TsImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsImprimir.ForeColor = System.Drawing.SystemColors.Control
        Me.TsImprimir.Image = CType(resources.GetObject("TsImprimir.Image"), System.Drawing.Image)
        Me.TsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsImprimir.Name = "TsImprimir"
        Me.TsImprimir.Size = New System.Drawing.Size(76, 22)
        Me.TsImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'TsConsultar
        '
        Me.TsConsultar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsConsultar.ForeColor = System.Drawing.SystemColors.Control
        Me.TsConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsConsultar.Name = "TsConsultar"
        Me.TsConsultar.Size = New System.Drawing.Size(63, 22)
        Me.TsConsultar.Text = "Consultar"
        Me.TsConsultar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabel1.Text = "Salir"
        '
        'BtAgregar
        '
        Me.BtAgregar.Location = New System.Drawing.Point(3, 221)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtAgregar.TabIndex = 18
        Me.BtAgregar.Text = "Agregar"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'DgLiquidaciones
        '
        Me.DgLiquidaciones.AllowUserToAddRows = False
        Me.DgLiquidaciones.AllowUserToDeleteRows = False
        Me.DgLiquidaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgLiquidaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgLiquidaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgLiquidaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLiquidaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgLiquidaciones.Location = New System.Drawing.Point(3, 29)
        Me.DgLiquidaciones.Name = "DgLiquidaciones"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgLiquidaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgLiquidaciones.RowHeadersVisible = False
        Me.DgLiquidaciones.RowHeadersWidth = 40
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgLiquidaciones.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgLiquidaciones.Size = New System.Drawing.Size(774, 186)
        Me.DgLiquidaciones.TabIndex = 19
        '
        'LIQUIDACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 486)
        Me.Controls.Add(Me.DgLiquidaciones)
        Me.Controls.Add(Me.BtAgregar)
        Me.Controls.Add(Me.DgBotesIngresados)
        Me.Controls.Add(Me.GbLiquidacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxIdProduccion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LIQUIDACIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidaciones"
        CType(Me.DgBotesIngresados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbLiquidacion.ResumeLayout(False)
        Me.GbLiquidacion.PerformLayout()
        CType(Me.NuTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgBotesIngresados As System.Windows.Forms.DataGridView
    Friend WithEvents GbLiquidacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxCantidadBotes As System.Windows.Forms.TextBox
    Friend WithEvents NuTotalPagar As System.Windows.Forms.NumericUpDown
    Friend WithEvents CbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxIdProduccion As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtAgregar As Button
    Friend WithEvents DgLiquidaciones As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DtFinal As DateTimePicker
    Friend WithEvents DtInicial As DateTimePicker
    Friend WithEvents CbProducto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TsEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
