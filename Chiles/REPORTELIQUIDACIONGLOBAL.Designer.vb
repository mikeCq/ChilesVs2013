<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTELIQUIDACIONGLOBAL
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
        Me.CRReporteGlobal = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRReporteGlobal
        '
        Me.CRReporteGlobal.ActiveViewIndex = -1
        Me.CRReporteGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRReporteGlobal.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRReporteGlobal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRReporteGlobal.Location = New System.Drawing.Point(0, 0)
        Me.CRReporteGlobal.Name = "CRReporteGlobal"
        Me.CRReporteGlobal.Size = New System.Drawing.Size(1014, 543)
        Me.CRReporteGlobal.TabIndex = 0
        '
        'REPORTELIQUIDACIONGLOBAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 543)
        Me.Controls.Add(Me.CRReporteGlobal)
        Me.Name = "REPORTELIQUIDACIONGLOBAL"
        Me.Text = "REPORTELIQUIDACIONGLOBAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRReporteGlobal As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
