<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTEPOREMPLEADO
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.CRReporteLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgLiquidaciones = New System.Windows.Forms.DataGridView()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxFinal = New System.Windows.Forms.TextBox()
        Me.TxIDLiquidacion = New System.Windows.Forms.TextBox()
        Me.TxInicio = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(450, 637)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'CRReporteLiquidacion
        '
        Me.CRReporteLiquidacion.ActiveViewIndex = -1
        Me.CRReporteLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRReporteLiquidacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRReporteLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRReporteLiquidacion.Location = New System.Drawing.Point(450, 0)
        Me.CRReporteLiquidacion.Name = "CRReporteLiquidacion"
        Me.CRReporteLiquidacion.ShowCopyButton = False
        Me.CRReporteLiquidacion.ShowGroupTreeButton = False
        Me.CRReporteLiquidacion.ShowLogo = False
        Me.CRReporteLiquidacion.ShowParameterPanelButton = False
        Me.CRReporteLiquidacion.ShowRefreshButton = False
        Me.CRReporteLiquidacion.Size = New System.Drawing.Size(619, 637)
        Me.CRReporteLiquidacion.TabIndex = 1
        Me.CRReporteLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgLiquidaciones)
        Me.GroupBox1.Controls.Add(Me.BtImprimir)
        Me.GroupBox1.Controls.Add(Me.BtLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxFinal)
        Me.GroupBox1.Controls.Add(Me.TxIDLiquidacion)
        Me.GroupBox1.Controls.Add(Me.TxInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 448)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liquidaciones"
        '
        'DgLiquidaciones
        '
        Me.DgLiquidaciones.AllowUserToAddRows = False
        Me.DgLiquidaciones.AllowUserToDeleteRows = False
        Me.DgLiquidaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgLiquidaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgLiquidaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgLiquidaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLiquidaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgLiquidaciones.Location = New System.Drawing.Point(6, 19)
        Me.DgLiquidaciones.MultiSelect = False
        Me.DgLiquidaciones.Name = "DgLiquidaciones"
        Me.DgLiquidaciones.ReadOnly = True
        Me.DgLiquidaciones.RowHeadersVisible = False
        Me.DgLiquidaciones.RowHeadersWidth = 40
        Me.DgLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgLiquidaciones.Size = New System.Drawing.Size(420, 228)
        Me.DgLiquidaciones.TabIndex = 24
        '
        'BtImprimir
        '
        Me.BtImprimir.Location = New System.Drawing.Point(254, 397)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(103, 23)
        Me.BtImprimir.TabIndex = 2
        Me.BtImprimir.Text = "Imprimir Reporte"
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'BtLimpiar
        '
        Me.BtLimpiar.Location = New System.Drawing.Point(95, 397)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtLimpiar.TabIndex = 3
        Me.BtLimpiar.Text = "Limpiar"
        Me.BtLimpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "al"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID Liquidacion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Empleado de:"
        '
        'TxFinal
        '
        Me.TxFinal.Location = New System.Drawing.Point(254, 318)
        Me.TxFinal.Name = "TxFinal"
        Me.TxFinal.Size = New System.Drawing.Size(68, 20)
        Me.TxFinal.TabIndex = 1
        '
        'TxIDLiquidacion
        '
        Me.TxIDLiquidacion.Enabled = False
        Me.TxIDLiquidacion.Location = New System.Drawing.Point(95, 292)
        Me.TxIDLiquidacion.Name = "TxIDLiquidacion"
        Me.TxIDLiquidacion.Size = New System.Drawing.Size(121, 20)
        Me.TxIDLiquidacion.TabIndex = 7
        Me.TxIDLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxInicio
        '
        Me.TxInicio.Location = New System.Drawing.Point(95, 318)
        Me.TxInicio.Name = "TxInicio"
        Me.TxInicio.Size = New System.Drawing.Size(68, 20)
        Me.TxInicio.TabIndex = 0
        '
        'REPORTEPOREMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 637)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CRReporteLiquidacion)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "REPORTEPOREMPLEADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte Por Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents CRReporteLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtImprimir As Button
    Friend WithEvents BtLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxFinal As TextBox
    Friend WithEvents TxIDLiquidacion As TextBox
    Friend WithEvents TxInicio As TextBox
    Friend WithEvents DgLiquidaciones As DataGridView
End Class
