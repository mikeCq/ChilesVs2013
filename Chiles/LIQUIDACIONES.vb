Imports System.Data
Imports System.Data.SqlClient
Public Class LIQUIDACIONES
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Dim DtBotes As New DataTable
    Dim dt As New DataTable
    Dim concatenado As String = ""
    Private _codigoProduccion As Integer
    Dim IdLiquidacionEncabezado As Integer
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
            If cnn.State <> ConnectionState.Open Then cnn.Open()
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
        TxIdProduccion.Text = "0.00"
        TxCantidadBotes.Text = "0.00"
        DtFecha.Value = Now
        NuTotalPagar.Value = 0.00
        CbEstatus.SelectedValue = -1
        CbProducto.Text = ""
        TsImprimir.Enabled = False
        TsGuardar.Enabled = True
        DgLiquidaciones.DataSource = ""
        DgLiquidaciones.Columns.Clear()
        DgBotesIngresados.DataSource = ""
        DgBotesIngresados.Columns.Clear()
        LlenarLiquidacionesEncabezado()
    End Sub
    Private Sub TsGuardar_Click(sender As Object, e As EventArgs) Handles TsGuardar.Click
        Dim Contador As Integer
        If DgBotesIngresados.RowCount > 0 Then
            Try
                If cnn.State <> ConnectionState.Open Then cnn.Open()
                Dim cmd As New SqlCommand("sp_InsLiqEnc", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@IdLiquidacionEncabezado", 0))
                cmd.Parameters.Add(New SqlParameter("@FechaLiquidacion", DtFecha.Value))
                cmd.Parameters.Add(New SqlParameter("@PagoTotal", NuTotalPagar.Value))
                cmd.Parameters.Add(New SqlParameter("@BotesTotal", TxCantidadBotes.Text))
                cmd.Parameters("@IdLiquidacionEncabezado").Direction = ParameterDirection.InputOutput
                cmd.ExecuteNonQuery()
                IdLiquidacionEncabezado = cmd.Parameters("@IdLiquidacionEncabezado").Value
                cnn.Close()
                For Contador = 0 To DgLiquidaciones.RowCount - 1
                    If DgLiquidaciones.Rows(Contador).Cells("ChCol").Value = True Then
                        TxIdProduccion.Text = DgLiquidaciones.Rows(Contador).Cells("IdProduccion").Value
                        If cnn.State <> ConnectionState.Open Then cnn.Open()
                        cmd = New SqlCommand("sp_InsLiqDet", cnn)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add(New SqlParameter("@IdProduccion", TxIdProduccion.Text))
                        cmd.Parameters.Add(New SqlParameter("@IdLiquidacionEncabezado", IdLiquidacionEncabezado))
                        cmd.ExecuteNonQuery()
                    End If
                Next Contador
                Dim opc As DialogResult = MessageBox.Show("¿Desea imprimir el reporte de liquidacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If opc = DialogResult.Yes Then
                    ImprimirGlobal()
                    TxIdProduccion.Text = ""
                End If
                TsGuardar.Enabled = False
                TsImprimir.Enabled = True
            Catch ex As Exception
                MsgBox("Problemas al conectar con al base de datos ")
                cnn.Close()
            Finally
                cnn.Close()
            End Try
        Else
            MessageBox.Show("No hay botes agregados, agreguelos antes de guardar", "Aviso")
        End If
    End Sub
    'Private Sub ImprimirReporte()
    '    _codigoProduccion = TxIdProduccion.Text
    '    REPORTELIQUIDACIONGLOBAL.ShowDialog()
    'End Sub
    Private Sub TsImprimir_Click(sender As Object, e As EventArgs) Handles TsImprimir.Click
        ImprimirGlobal()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Close()
    End Sub
    Private Sub FormatoGridView()
        DgBotesIngresados.Columns().Item("IdBotes").Visible = False
        DgBotesIngresados.Columns().Item("Empleado").HeaderText = "ID Empleado"
        DgBotesIngresados.Columns().Item("BotesRecibidos").HeaderText = "Botes Recibidos"
        DgBotesIngresados.Columns().Item("IdProduccion").HeaderText = "Id Producción"
        DgBotesIngresados.Columns().Item("PrecioBote").HeaderText = "Precio Bote"
        DgBotesIngresados.Columns().Item("PrecioBote").DefaultCellStyle.Format = "###,##0.00"
        DgBotesIngresados.Columns().Item("FechaLetra").HeaderText = "Dia"
    End Sub
    Private Sub LlenarLiquidacionesEncabezado()
        If cnn.State <> ConnectionState.Open Then cnn.Open()
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
        DgLiquidaciones.Columns().Item("IdProduccion").Visible = True
        DgLiquidaciones.Columns().Item("IdProduccion").HeaderText = "Id Produccion"
        DgLiquidaciones.Columns().Item("Precio").HeaderText = "Precio Bote"
        DgLiquidaciones.Columns().Item("CantidadBotes").HeaderText = "Cantidad Botes"
        DgLiquidaciones.Columns().Item("SumaBotes").HeaderText = "Total"
        DgLiquidaciones.Columns().Item("Producto").HeaderText = "Producto"
        DgLiquidaciones.Columns().Item("IdEstatus").Visible = False
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
                    TxIdProduccion.Text = DgLiquidaciones.Rows(Contador).Cells("Idproduccion").Value
                    TxCantidadBotes.Text = CInt(TxCantidadBotes.Text + DgLiquidaciones.Rows(Contador).Cells("CantidadBotes").Value)
                    NuTotalPagar.Value = CDbl(NuTotalPagar.Value + DgLiquidaciones.Rows(Contador).Cells("SumaBotes").Value)
                    CargaBotes(TxIdProduccion.Text)
                End If
            Next Contador
            DgBotesIngresados.DataSource = dt
            If DgBotesIngresados.Rows.Count = 0 Then
                Exit Sub
            End If
            FormatoGridView()
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