Imports System.Data
Imports System.Data.SqlClient
Public Class REPORTELIQUIDACIONGLOBAL
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub REPORTELIQUIDACIONGLOBAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DsLiquidacionGlobal

            Dim cadena As String = IIf(ConsultaLiquidaciones.CodigoLiquidacionEncabezado Is Nothing, LIQUIDACIONES.ConcatenacionID, ConsultaLiquidaciones.CodigoLiquidacionEncabezado)
            Dim StrSql As String = "execute sp_ReporteLiquidacionGlobal '" & cadena & "'"
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
            CRReporteGlobal.ReportSource = CrReport
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
            cnn.Close()
        End Try
    End Sub
End Class