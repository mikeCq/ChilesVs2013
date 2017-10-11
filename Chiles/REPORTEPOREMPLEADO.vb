Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class REPORTEPOREMPLEADO
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

    Private Sub REPORTEPOREMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
    Private Sub Nuevo()
        cargarData()
        TxIDLiquidacion.Text = ""
        TxInicio.Text = ""
        TxFinal.Text = ""
        CRReporteLiquidacion.ReportSource = Nothing
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
    Private Function obtenerProducciones(ByVal concatenado As String)
        Dim ds As New DsLiquidacionGlobal
        Dim StrSql As String = "execute sp_ObtProduccionesLiquidadas '" & TxIDLiquidacion.Text & "'"
        Dim dtInforme As New DataTable
        If cnn.State <> ConnectionState.Open Then cnn.Open()

        Using dad As New SqlDataAdapter(StrSql, cnn)
            dad.Fill(dtInforme)
        End Using

        For Each row As DataRow In dtInforme.Rows
            concatenado = concatenado & "," & row("idproduccion")
        Next

        concatenado = concatenado.TrimStart(",")
        Return concatenado
    End Function
    Private Sub BtImprimir_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        If TxInicio.Text = "" Or TxFinal.Text = "" Or TxIDLiquidacion.Text = "" Then
            MessageBox.Show("Verifica campos vacios!", "Aviso")
        ElseIf CInt(TxInicio.Text) > CInt(TxFinal.Text) Then
            MessageBox.Show("El campo de empleado inicial no puede ser mayor al final.", "Aviso")
        ElseIf CInt(TxFinal.Text) < CInt(TxInicio.Text) Then
            MessageBox.Show("El campo de empleado final no puede ser menor al inicial", "Aviso")
        Else
            Try
                Dim ds As New DsLiquidacionGlobal
                Dim Concatenado As String = Nothing
                Dim cadena As String = obtenerProducciones(Concatenado)
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
                CRReporteLiquidacion.Refresh()

                If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "Reportes Piscas") Then
                    Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "Reportes Piscas")
                End If

                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions
                Dim CrFormatType As New PdfRtfWordFormatOptions
                Dim RutaPDF As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "Reportes Piscas" & "\" & "Ch" & CStr(FormatDateTime(Now, DateFormat.ShortDate)).ToString.Replace("/", "") & ".pdf"
                CrDiskFileDestinationOptions.DiskFileName = RutaPDF
                CrExportOptions = CrReport.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .ExportDestinationOptions = CrDiskFileDestinationOptions
                    .ExportFormatOptions = CrFormatType
                End With
                CrReport.Export()

                'ShellExecute(1, "open", RutaPDF, "", "", 4)

                Dim Ventana As Long     'variable necesaria para la API
                Dim sError As String    'cadena de error
                'llama a la API que abre cualquier documento que tenga un programa asociado
                ' el valor 5 del último parámetro equivale a la constante SW_SHOW que hace que se muestre el documento
                'If ShellExecute(Ventana, "open", RutaPDF, vbNullString, vbNullString, 5) <= 32 Then
                '    sError = MsgBox("No puede abrir o no se encuentra el documento" & vbCrLf & RutaPDF, vbExclamation + vbOKOnly, "Error")
                'Else
                '    ShellExecute(Ventana, "open", RutaPDF, vbNullString, vbNullString, 5)
                'End If

                Dim AcroExchApp As Object
                Dim AcroExchAVDoc As Object
                Dim strFileName As String
                AcroExchApp = CreateObject("AcroExch.App")
                AcroExchAVDoc = CreateObject("AcroExch.AVDoc")
                'Abre el acrobat reader
                AcroExchApp.Show
                'El archivo que queremos abrir
                strFileName = RutaPDF
                'Abre el archivo anterior
                AcroExchAVDoc.Open(RutaPDF, vbNull)

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

    Private Sub BtPdf_Click(sender As Object, e As EventArgs) Handles BtPdf.Click


    End Sub
End Class