<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaLiquidaciones
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
        Me.DgProducciones = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CbProducto = New System.Windows.Forms.ComboBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtInicial = New System.Windows.Forms.DateTimePicker()
        CType(Me.DgProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgProducciones
        '
        Me.DgProducciones.AllowUserToAddRows = False
        Me.DgProducciones.AllowUserToDeleteRows = False
        Me.DgProducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgProducciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgProducciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgProducciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProducciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgProducciones.Location = New System.Drawing.Point(2, 149)
        Me.DgProducciones.MultiSelect = False
        Me.DgProducciones.Name = "DgProducciones"
        Me.DgProducciones.ReadOnly = True
        Me.DgProducciones.RowHeadersVisible = False
        Me.DgProducciones.RowHeadersWidth = 40
        Me.DgProducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProducciones.Size = New System.Drawing.Size(844, 386)
        Me.DgProducciones.TabIndex = 23
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(846, 25)
        Me.ToolStrip1.TabIndex = 22
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
        'CbProducto
        '
        Me.CbProducto.FormattingEnabled = True
        Me.CbProducto.Location = New System.Drawing.Point(431, 67)
        Me.CbProducto.Name = "CbProducto"
        Me.CbProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbProducto.TabIndex = 21
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(749, 57)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(92, 38)
        Me.BtBuscar.TabIndex = 20
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Producto :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha final :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha inicial :"
        '
        'DtFinal
        '
        Me.DtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFinal.Location = New System.Drawing.Point(265, 68)
        Me.DtFinal.Name = "DtFinal"
        Me.DtFinal.Size = New System.Drawing.Size(98, 20)
        Me.DtFinal.TabIndex = 15
        Me.DtFinal.Value = New Date(2000, 1, 1, 11, 18, 0, 0)
        '
        'DtInicial
        '
        Me.DtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtInicial.Location = New System.Drawing.Point(90, 68)
        Me.DtInicial.Name = "DtInicial"
        Me.DtInicial.Size = New System.Drawing.Size(98, 20)
        Me.DtInicial.TabIndex = 16
        Me.DtInicial.Value = New Date(2000, 1, 1, 10, 45, 0, 0)
        '
        'ConsultaLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 537)
        Me.Controls.Add(Me.DgProducciones)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CbProducto)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtFinal)
        Me.Controls.Add(Me.DtInicial)
        Me.Name = "ConsultaLiquidaciones"
        Me.Text = "ConsultaLiquidaciones"
        CType(Me.DgProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgProducciones As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents BtBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtInicial As System.Windows.Forms.DateTimePicker
End Class
