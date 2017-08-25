Imports System.Data
Imports System.Data.SqlClient
Public Class REPORTELIQUIDACIONGLOBAL
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub REPORTELIQUIDACIONGLOBAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DsLiquidacionGlobal

            cnn.Open()
            Dim daInforme As New SqlCommand("sp_ReporteLiquidacionGlobal", cnn)

            Dim Ruta As String = "C:\RPTCH\RPT\RptLiquidacionGlobal.rpt"
            daInforme.CommandType = CommandType.StoredProcedure
            Dim NombreCampo As New SqlClient.SqlParameter()
            NombreCampo.ParameterName = "@IdProduccion"
            NombreCampo.SqlDbType = SqlDbType.NVarChar
            NombreCampo.Value = LIQUIDACIONES.ConcatenacionID 'LIQUIDACIONES.codigoProduccion
            daInforme.Parameters.Add(NombreCampo)
            Dim dasp_Informe As New SqlClient.SqlDataAdapter()
            dasp_Informe.SelectCommand = daInforme
            Dim dtInforme As New DataTable
            dasp_Informe.Fill(dtInforme)

            For Each row As DataRow In dtInforme.Rows
                ds.Tables(0).Rows.Add(CInt(row("IdProduccion")), CStr(row("Producto")), CDec(row("Precio")), CInt(row("Empleado")), CInt(row("NoBotes")), CDec(row("Lunes")), CDec(row("Martes")), CDec(row("Miercoles")), CDec(row("Jueves")), CDec(row("Viernes")), CDec(row("Sabado")))
            Next

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' Asigno el reporte 
            CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds)
            'CrReport.Subreports("LiquidacionDetallada").SetDataSource(dsSubinforme)
            CRReporteGlobal.ReportSource = CrReport
            cnn.Close()

        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
            cnn.Close()
        End Try
    End Sub
End Class