Imports System.Data
Imports System.Data.SqlClient
Public Class LIQUIDACIONES
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Dim DtBotes As New DataTable
    Private _codigoProduccion As Integer
    Public Property codigoProduccion() As Integer
        Get
            Return _codigoProduccion
        End Get
        Set(value As Integer)
            _codigoProduccion = value
        End Set
    End Property
    Private Sub LIQUIDACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        llenaCombos()
    End Sub
    Private Sub TsNuevo_Click(sender As Object, e As EventArgs) Handles TsNuevo.Click
        Nuevo()
    End Sub
    Private Sub llenaCombos()
        cnn.Open()
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        Dim cmdllenaCbProd As SqlCommand

        cmdllenaCbProd = New SqlCommand("sp_LlenaDgProductos")
        cmdllenaCbProd.CommandType = CommandType.StoredProcedure
        cmdllenaCbProd.Connection = cnn

        da = New SqlDataAdapter(cmdllenaCbProd)
        ds = New DataSet()
        da.Fill(ds)
        CbProducto.DataSource = ds.Tables(0)
        CbProducto.DisplayMember = "Nombre"
        CbProducto.ValueMember = "IdProducto"
        CbProducto.SelectedIndex = -1
        cnn.Close()

        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = "CERRADO"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "1"
        dr("Descripcion") = "ABIERTO"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "2"
        dr("Descripcion") = "LIQUIDADO"
        dt.Rows.Add(dr)

        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Codigo"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedIndex = 1
    End Sub
    Private Sub TsConsultar_Click(sender As Object, e As EventArgs) Handles TsConsultar.Click
        Try
            Dim consultaLiquidacion As New ConsultaLiquidaciones
            consultaLiquidacion.ShowDialog()
            Dim codigoSeleccionado As Object = consultaLiquidacion.CodigoProduccion
            If codigoSeleccionado <> Nothing Then
                Dim cmd As New SqlCommand("sp_selProduccion", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@IdProduccion", codigoSeleccionado))

                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)
                Dim row As DataRow = dt.Rows(0)
                TxIdProduccion.Text = row("IdProduccion")
                DtFecha.Value = row("Fecha")
                TxCantidadBotes.Text = row("CantidadBotes")
                NuTotalPagar.Value = row("SumaBotes")
                NuPrecio.Value = row("Precio")
                CbProducto.Text = CStr(row("Producto"))
                CbEstatus.SelectedValue = CStr(row("IdEstatus"))

                CargaBotes(TxIdProduccion.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub CargaBotes(ByVal CodigoProducccion As Integer)
        Dim resultado As Boolean = False
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProduccion", CodigoProducccion))
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DgBotesIngresados.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Nuevo()
        TxIdProduccion.Text = ""
        TxCantidadBotes.Text = ""
        DtFecha.Value = Now
        NuTotalPagar.Value = 0
        CbEstatus.SelectedValue = -1
        CbProducto.Text = ""
        DgBotesIngresados.DataSource = ""
        DgBotesIngresados.Columns.Clear()
    End Sub
    Private Sub TsGuardar_Click(sender As Object, e As EventArgs) Handles TsGuardar.Click
        Try
            cnn.Open()
            cmd = New SqlCommand("sp_InsLiqDet", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProduccion", TxIdProduccion.Text))
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Problemas al conectar con al base de datos ")
        Finally
            cnn.Close()
            Dim opc As DialogResult = MessageBox.Show("¿Desea imprimir el reporte de liquidacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opc = DialogResult.Yes Then

                ImprimirReporte()

            End If
        End Try
    End Sub
    Private Sub ImprimirReporte()
        _codigoProduccion = TxIdProduccion.Text
        REPORTELIQUIDACION.ShowDialog()
    End Sub
    Private Sub TsImprimir_Click(sender As Object, e As EventArgs) Handles TsImprimir.Click
        ImprimirReporte()
    End Sub
End Class