<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTELIQUIDACION
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
        Me.CrLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrLiquidacion
        '
        Me.CrLiquidacion.ActiveViewIndex = -1
        Me.CrLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrLiquidacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrLiquidacion.Location = New System.Drawing.Point(0, 0)
        Me.CrLiquidacion.Name = "CrLiquidacion"
        Me.CrLiquidacion.ShowCloseButton = False
        Me.CrLiquidacion.ShowCopyButton = False
        Me.CrLiquidacion.ShowGotoPageButton = False
        Me.CrLiquidacion.ShowGroupTreeButton = False
        Me.CrLiquidacion.ShowLogo = False
        Me.CrLiquidacion.ShowPageNavigateButtons = False
        Me.CrLiquidacion.ShowParameterPanelButton = False
        Me.CrLiquidacion.ShowRefreshButton = False
        Me.CrLiquidacion.ShowTextSearchButton = False
        Me.CrLiquidacion.Size = New System.Drawing.Size(1042, 733)
        Me.CrLiquidacion.TabIndex = 2
        Me.CrLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'REPORTELIQUIDACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 733)
        Me.Controls.Add(Me.CrLiquidacion)
        Me.Name = "REPORTELIQUIDACION"
        Me.Text = "REPORTELIQUIDACION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
