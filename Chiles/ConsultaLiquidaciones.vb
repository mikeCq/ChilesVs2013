Imports System.Data
Imports System.Data.SqlClient
Public Class ConsultaLiquidaciones
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private _codigoLiquidacionEncabezado As String
    Public Property CodigoLiquidacionEncabezado() As String
        Get
            Return _codigoLiquidacionEncabezado
        End Get
        Set(ByVal value As String)
            _codigoLiquidacionEncabezado = value
        End Set
    End Property
    Private Sub ConsultaLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarData()
    End Sub
    Private Sub cargarData()
        If cnn.State <> ConnectionState.Open Then cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenaDgBusquedaLiquidacion", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@FechaIni", DtInicial.Value))
        cmd.Parameters.Add(New SqlParameter("@FechaFin", DtFinal.Value))
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgProducciones.DataSource = dt
        cnn.Close()
        FormatoGridView()
    End Sub
    Private Sub SeleccionaLiquidacion() Handles DgProducciones.DoubleClick
        Dim Cadena As String = ""
        If DgProducciones.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgProducciones Is Nothing Then
            _codigoLiquidacionEncabezado = obtenerProducciones(Cadena)
            REPORTELIQUIDACIONGLOBAL.ShowDialog()
        End If
    End Sub
    Private Function obtenerProducciones(ByVal concatenado As String)
        Dim ds As New DsLiquidacionGlobal
        Dim StrSql As String = "execute sp_ObtProduccionesLiquidadas '" & DgProducciones.CurrentRow.Cells("IdLiquidacionEncabezado").Value & "'"
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
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        cargarData()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Close()
    End Sub

    Private Sub FormatoGridView()
        'DgProducciones.Columns(0).Visible = False
        'DgProducciones.Columns(2).HeaderText = "Precio Bote"
        'DgProducciones.Columns(3).HeaderText = "Cantidad Botes"
        'DgProducciones.Columns(4).HeaderText = "Total"
        'DgProducciones.Columns(6).Visible = False
    End Sub

    Private Sub BtFiltrar_Click(sender As Object, e As EventArgs) Handles BtFiltrar.Click
        cargarData()
    End Sub
End Class