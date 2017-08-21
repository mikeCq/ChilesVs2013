Imports System.Data
Imports System.Data.SqlClient
Public Class LIQUIDACIONES
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Dim DtBotes As New DataTable
    Dim dt As New DataTable
    Dim concatenado As String = ""
    Private _codigoProduccion As Integer
    Public Property codigoProduccion() As Integer
        Get
            Return _codigoProduccion
        End Get
        Set(value As Integer)
            _codigoProduccion = value
        End Set
    End Property
    Private _ConcatenacionID As String
    Public Property ConcatenacionID() As String
        Get
            Return _ConcatenacionID
        End Get
        Set(value As String)
            _ConcatenacionID = value
        End Set
    End Property
    Private Sub LIQUIDACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        LlenarLiquidacionesEncabezado()
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
        'Try
        '    Dim consultaLiquidacion As New ConsultaLiquidaciones
        '    consultaLiquidacion.ShowDialog()
        '    Dim codigoSeleccionado As Object = consultaLiquidacion.CodigoProduccion
        '    If codigoSeleccionado <> Nothing Then
        '        Dim cmd As New SqlCommand("sp_selProduccion", cnn)
        '        cmd.CommandType = CommandType.StoredProcedure
        '        cmd.Parameters.Add(New SqlClient.SqlParameter("@IdProduccion", codigoSeleccionado))
        '        Dim da As New SqlClient.SqlDataAdapter(cmd)
        '        Dim dt As New DataTable
        '        da.Fill(dt)
        '        Dim row As DataRow = dt.Rows(0)
        '        TxIdProduccion.Text = row("IdProduccion")
        '        DtFecha.Value = row("Fecha")
        '        TxCantidadBotes.Text = row("CantidadBotes")
        '        NuTotalPagar.Value = row("SumaBotes")
        '        NuPrecio.Value = row("Precio")
        '        CbProducto.Text = CStr(row("Producto"))
        '        CbEstatus.SelectedValue = CStr(row("IdEstatus"))
        '        CargaBotes(TxIdProduccion.Text)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
    Private Sub CargaBotes(ByVal CodigoProducccion As Integer)
        Dim resultado As Boolean = False
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProduccion", CodigoProducccion))
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
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
        DgLiquidaciones.DataSource = ""
        DgLiquidaciones.Columns.Clear()
        DgBotesIngresados.DataSource = ""
        DgBotesIngresados.Columns.Clear()
    End Sub
    Private Sub TsGuardar_Click(sender As Object, e As EventArgs) Handles TsGuardar.Click
        Dim Contador As Integer
        Try
            For Contador = 0 To DgLiquidaciones.RowCount - 1
                If DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = True Then
                    TxIdProduccion.Text = DgLiquidaciones.Rows(Contador).Cells(0).Value
                    If cnn.State <> ConnectionState.Open Then cnn.Open()
                    cmd = New SqlCommand("sp_InsLiqDet", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@IdProduccion", TxIdProduccion.Text))
                    cmd.ExecuteNonQuery()

                End If
            Next Contador
            Dim opc As DialogResult = MessageBox.Show("¿Desea imprimir el reporte de liquidacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opc = DialogResult.Yes Then
                'ImprimirReporte()
                ImprimirGlobal()
                TxIdProduccion.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Problemas al conectar con al base de datos ")
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub ImprimirReporte()
        _codigoProduccion = TxIdProduccion.Text
        REPORTELIQUIDACION.ShowDialog()
    End Sub
    Private Sub TsImprimir_Click(sender As Object, e As EventArgs) Handles TsImprimir.Click
        ImprimirReporte()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Close()
    End Sub
    Private Sub FormatoGridView()
        DgBotesIngresados.Columns(0).Visible = False
        DgBotesIngresados.Columns(1).HeaderText = "ID Empleado"
        DgBotesIngresados.Columns(2).HeaderText = "Botes Recibidos"
        DgBotesIngresados.Columns(4).HeaderText = "Id Producción"
        DgBotesIngresados.Columns(5).HeaderText = "Precio Bote"
        DgBotesIngresados.Columns.Item("PrecioBote").DefaultCellStyle.Format = "###,##0.00"
        DgBotesIngresados.Columns(6).HeaderText = "Dia"
    End Sub
    Private Sub LlenarLiquidacionesEncabezado()
        cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenarLiquidaciones", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@FechaIni", DtInicial.Value))
        cmd.Parameters.Add(New SqlParameter("@FechaFin", DtFinal.Value))
        cmd.Parameters.Add(New SqlParameter("@Producto", CbProducto.Text))
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgLiquidaciones.DataSource = dt
        cnn.Close()
        FormatoGridViewEncabezado()
    End Sub
    Private Sub FormatoGridViewEncabezado()
        DgLiquidaciones.Columns(0).Visible = True
        DgLiquidaciones.Columns(0).HeaderText = "Id Produccion"
        DgLiquidaciones.Columns(2).HeaderText = "Precio Bote"
        DgLiquidaciones.Columns(3).HeaderText = "Cantidad Botes"
        DgLiquidaciones.Columns(4).HeaderText = "Total"
        DgLiquidaciones.Columns(5).HeaderText = "Producto"
        DgLiquidaciones.Columns(6).Visible = False
        If DgLiquidaciones.Columns("ChCol") Is Nothing Then
            Dim chk As New DataGridViewCheckBoxColumn()
            DgLiquidaciones.Columns.Add(chk)
            chk.HeaderText = "Check Data"
            chk.Name = "ChCol"
            ' DgLiquidaciones.Columns.Insert(7, chk)
        End If
    End Sub
    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        Agregar()
    End Sub
    Private Sub DgLiquidaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgLiquidaciones.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DgLiquidaciones.RowCount - 1
            If DgLiquidaciones.Rows(Contador).Selected Then
                If DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = False Then
                    DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = True
                ElseIf DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = True Then
                    DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = False
                End If
            End If
        Next Contador
    End Sub
    Private Sub Agregar()
        dt.Clear()
        Dim Contador As Integer
        Try
            For Contador = 0 To DgLiquidaciones.RowCount - 1
                If DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = True Then
                    'Dim cmd As New SqlCommand("sp_selProduccion", cnn)
                    'cmd.CommandType = CommandType.StoredProcedure
                    'cmd.Parameters.Add(New SqlClient.SqlParameter("@IdProduccion", DgLiquidaciones.CurrentRow.Cells(0).Value))
                    'Dim da As New SqlClient.SqlDataAdapter(cmd)
                    'Dim dt As New DataTable
                    'da.Fill(dt)
                    TxIdProduccion.Text = DgLiquidaciones.Rows(Contador).Cells(0).Value
                    CargaBotes(TxIdProduccion.Text)
                End If
            Next Contador
            DgBotesIngresados.DataSource = dt
            FormatoGridView()
            'Dim row As DataRow = dt.Rows(0)
            'TxIdProduccion.Text = row("IdProduccion")
            'DtFecha.Value = row("Fecha")
            'TxCantidadBotes.Text = row("CantidadBotes")
            'NuTotalPagar.Value = row("SumaBotes")
            'NuPrecio.Value = row("Precio")
            'CbProducto.Text = CStr(row("Producto"))
            'CbEstatus.SelectedValue = CStr(row("IdEstatus"))            
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Function concatenaId(ByVal IdConcatenados As String)
        For Each row As DataGridViewRow In DgLiquidaciones.Rows
            If row.Cells("ChCol").Value = True Then
                concatenado = concatenado & "," & row.Cells("IdProduccion").Value
            End If
        Next
        concatenado = concatenado.TrimStart(",")
        Return IdConcatenados
    End Function
    Private Sub ImprimirGlobal()
        concatenaId(concatenado)
        _ConcatenacionID = concatenado
        concatenado = ""
        REPORTELIQUIDACIONGLOBAL.ShowDialog()
    End Sub
End Class