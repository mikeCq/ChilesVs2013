Imports System.Data
Imports System.Data.SqlClient
Public Class REPORTEPOREMPLEADO
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub REPORTEPOREMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
    Private Sub Nuevo()
        cargarData()
        TxIDLiquidacion.Text = ""
        TxInicio.Text = ""
        TxFinal.Text = ""
        CRReporteLiquidacion.Refresh()
    End Sub
    Private Sub cargarData()
        If cnn.State <> ConnectionState.Open Then cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenarDgLiquidacionPorEmpleado", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgLiquidaciones.DataSource = dt
        cnn.Close()
        FormatoGridView()
    End Sub
    Private Sub FormatoGridView()
        DgLiquidaciones.Columns("IdLiquidacionEncabezado").HeaderText = "ID Liquidacion"
        DgLiquidaciones.Columns("FechaLiquidacion").HeaderText = "Fecha Liquidado"
        DgLiquidaciones.Columns("PagoTotal").HeaderText = "Total Pagado"
        DgLiquidaciones.Columns("BotesTotal").HeaderText = "Total de Botes"
    End Sub
    Private Sub BtImprimir_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If TxInicio.Text = "" Or TxFinal.Text = "" Then
            MessageBox.Show("Campos de rango de empleados no puede estar vacio!", "Aviso")
        ElseIf CInt(TxInicio.Text) > CInt(TxFinal.Text) Then
            MessageBox.Show("El campo de empleado inicial no puede ser mayor al final.", "Aviso")
        ElseIf CInt(TxFinal.Text) < CInt(TxInicio.Text) Then
            MessageBox.Show("El campo de empleado final no puede ser menor al inicial", "Aviso")
        Else
            Try
                Dim ds As New DsLiquidacionGlobal

                Dim cadena As String = TxIDLiquidacion.Text
                Dim StrSql As String = "execute sp_ReporteLiquidacionEmpleado '" & cadena & "','" & TxInicio.Text & "','" & TxFinal.Text & "'"
                Dim dtInforme As New DataTable
                Dim Ruta As String = Application.StartupPath & "\RPT\RptLiquidacionGlobal.rpt"
                If cnn.State <> ConnectionState.Open Then cnn.Open()

                Using dad As New SqlDataAdapter(StrSql, cnn)
                    dad.Fill(dtInforme)
                End Using
                For Each row As DataRow In dtInforme.Rows
                    ds.Tables(0).Rows.Add(CInt(row("IdProduccion")), CStr(row("Producto")), CDec(row("Precio")), CInt(row("Empleado")), CInt(row("NoBotes")), CDec(row("Lunes")), CDec(row("Martes")), CDec(row("Miercoles")), CDec(row("Jueves")), CDec(row("Viernes")), CDec(row("Sabado")))
                Next
                'Dim daSubinforme As New SqlCommand("sp_ReporteLiquidacionGlobal", cnn)
                'daSubinforme.CommandType = CommandType.StoredProcedure
                'Dim IdProduccion As New SqlClient.SqlParameter()
                'IdProduccion.ParameterName = "@IdProduccion"
                'IdProduccion.SqlDbType = SqlDbType.NVarChar
                'IdProduccion.Value = cadena
                'daSubinforme.Parameters.Add(IdProduccion)
                'Dim dasp_Subinforme As New SqlClient.SqlDataAdapter()
                'dasp_Subinforme.SelectCommand = daSubinforme
                'Dim dsSubinforme As New DataTable
                'dasp_Subinforme.Fill(dsSubinforme)

                Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                ' Asigno el reporte 
                CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                CrReport.Load(Ruta)
                CrReport.SetDataSource(ds)
                CrReport.Subreports("DetallePorEmpleado").SetDataSource(ds)
                CRReporteLiquidacion.ReportSource = CrReport
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
                cnn.Close()
            End Try
        End If

    End Sub
    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        Nuevo()
    End Sub
    Private Sub DgLiquidacionSelecciona() Handles DgLiquidaciones.DoubleClick
        'For Each row As DataGridViewRow In Me.DgLiquidaciones.Rows
        TxIDLiquidacion.Text = DgLiquidaciones.CurrentRow.Cells("IdLiquidacionEncabezado").Value
        ' Next
    End Sub

End Class