<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIQUIDACIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LIQUIDACIONES))
        Me.DgBotesIngresados = New System.Windows.Forms.DataGridView()
        Me.GbLiquidacion = New System.Windows.Forms.GroupBox()
        Me.CbProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxCantidadBotes = New System.Windows.Forms.TextBox()
        Me.NuPrecio = New System.Windows.Forms.NumericUpDown()
        Me.NuTotalPagar = New System.Windows.Forms.NumericUpDown()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxIdProduccion = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsConsultar = New System.Windows.Forms.ToolStripButton()
        CType(Me.DgBotesIngresados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbLiquidacion.SuspendLayout()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.DgBotesIngresados.Location = New System.Drawing.Point(0, 140)
        Me.DgBotesIngresados.MultiSelect = False
        Me.DgBotesIngresados.Name = "DgBotesIngresados"
        Me.DgBotesIngresados.ReadOnly = True
        Me.DgBotesIngresados.RowHeadersVisible = False
        Me.DgBotesIngresados.RowHeadersWidth = 40
        Me.DgBotesIngresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBotesIngresados.Size = New System.Drawing.Size(799, 353)
        Me.DgBotesIngresados.TabIndex = 16
        '
        'GbLiquidacion
        '
        Me.GbLiquidacion.Controls.Add(Me.CbProducto)
        Me.GbLiquidacion.Controls.Add(Me.Label5)
        Me.GbLiquidacion.Controls.Add(Me.Label6)
        Me.GbLiquidacion.Controls.Add(Me.Label2)
        Me.GbLiquidacion.Controls.Add(Me.Label4)
        Me.GbLiquidacion.Controls.Add(Me.DtFecha)
        Me.GbLiquidacion.Controls.Add(Me.Label8)
        Me.GbLiquidacion.Controls.Add(Me.Label3)
        Me.GbLiquidacion.Controls.Add(Me.TxCantidadBotes)
        Me.GbLiquidacion.Controls.Add(Me.NuPrecio)
        Me.GbLiquidacion.Controls.Add(Me.NuTotalPagar)
        Me.GbLiquidacion.Controls.Add(Me.CbEstatus)
        Me.GbLiquidacion.Enabled = False
        Me.GbLiquidacion.Location = New System.Drawing.Point(0, 32)
        Me.GbLiquidacion.Name = "GbLiquidacion"
        Me.GbLiquidacion.Size = New System.Drawing.Size(799, 102)
        Me.GbLiquidacion.TabIndex = 15
        Me.GbLiquidacion.TabStop = False
        '
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(74, 13)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbProducto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Producto :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Estatus :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Botes :"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(74, 40)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(121, 20)
        Me.DtFecha.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(201, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Precio :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total a Pagar :"
        '
        'TxCantidadBotes
        '
        Me.TxCantidadBotes.Location = New System.Drawing.Point(284, 42)
        Me.TxCantidadBotes.Name = "TxCantidadBotes"
        Me.TxCantidadBotes.Size = New System.Drawing.Size(121, 20)
        Me.TxCantidadBotes.TabIndex = 4
        '
        'NuPrecio
        '
        Me.NuPrecio.DecimalPlaces = 2
        Me.NuPrecio.Location = New System.Drawing.Point(284, 16)
        Me.NuPrecio.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NuPrecio.Name = "NuPrecio"
        Me.NuPrecio.Size = New System.Drawing.Size(121, 20)
        Me.NuPrecio.TabIndex = 5
        Me.NuPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuTotalPagar
        '
        Me.NuTotalPagar.DecimalPlaces = 2
        Me.NuTotalPagar.Location = New System.Drawing.Point(284, 68)
        Me.NuTotalPagar.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NuTotalPagar.Name = "NuTotalPagar"
        Me.NuTotalPagar.Size = New System.Drawing.Size(121, 20)
        Me.NuTotalPagar.TabIndex = 5
        Me.NuTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(74, 66)
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
        Me.TxIdProduccion.Location = New System.Drawing.Point(653, 9)
        Me.TxIdProduccion.Name = "TxIdProduccion"
        Me.TxIdProduccion.Size = New System.Drawing.Size(121, 20)
        Me.TxIdProduccion.TabIndex = 13
        Me.TxIdProduccion.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2, Me.TsGuardar, Me.ToolStripButton4, Me.TsImprimir, Me.ToolStripSeparator1, Me.TsConsultar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(801, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(46, 22)
        Me.TsNuevo.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 25)
        '
        'TsGuardar
        '
        Me.TsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsGuardar.Name = "TsGuardar"
        Me.TsGuardar.Size = New System.Drawing.Size(53, 22)
        Me.TsGuardar.Text = "Guardar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(6, 25)
        '
        'TsImprimir
        '
        Me.TsImprimir.Image = CType(resources.GetObject("TsImprimir.Image"), System.Drawing.Image)
        Me.TsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsImprimir.Name = "TsImprimir"
        Me.TsImprimir.Size = New System.Drawing.Size(73, 22)
        Me.TsImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsConsultar
        '
        Me.TsConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsConsultar.Name = "TsConsultar"
        Me.TsConsultar.Size = New System.Drawing.Size(62, 22)
        Me.TsConsultar.Text = "Consultar"
        '
        'LIQUIDACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 496)
        Me.Controls.Add(Me.DgBotesIngresados)
        Me.Controls.Add(Me.GbLiquidacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxIdProduccion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "LIQUIDACIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidaciones"
        CType(Me.DgBotesIngresados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbLiquidacion.ResumeLayout(False)
        Me.GbLiquidacion.PerformLayout()
        CType(Me.NuPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgBotesIngresados As System.Windows.Forms.DataGridView
    Friend WithEvents GbLiquidacion As System.Windows.Forms.GroupBox
    Friend WithEvents CbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxCantidadBotes As System.Windows.Forms.TextBox
    Friend WithEvents NuPrecio As System.Windows.Forms.NumericUpDown
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
End Class
