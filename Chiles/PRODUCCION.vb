Imports System.Data
Imports System.Data.SqlClient
Public Class Produccion
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombos()
        cargarData()
        nuevo()
    End Sub
    Private Sub Nuevo()
        TxIdProduccion.Text = ""
        NuPrecio.Value = 0
        CbProducto.Text = ""
        CbEstatus.SelectedIndex = 1
        TxCaptura.Text = ""
        DgBoteIngresado.DataSource = ""
        DgBoteIngresado.Columns.Clear()
        GbAbrir.Enabled = True
        GbCaptura.Enabled = False
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

    Private Sub BtIniciar_Click(sender As Object, e As EventArgs) Handles BtIniciar.Click
        If NuPrecio.Value = 0 Or CbProducto.SelectedValue = Nothing Or CbProducto.Text = "" Then
            MessageBox.Show("No puedes iniciar la produccion con campos vacios.", "Aviso")
        Else
            Try
                TxNombreDia.Text = UCase(WeekdayName(Weekday(DtFecha.Value)))
                cnn.Open()
                cmd = New SqlCommand("sp_InsProduccion", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@IdProduccion", 0))
                cmd.Parameters.Add(New SqlParameter("@Fecha", DtFecha.Value))
                cmd.Parameters.Add(New SqlParameter("@FechaLetra", TxNombreDia.Text))
                cmd.Parameters.Add(New SqlParameter("@Precio", NuPrecio.Value))
                cmd.Parameters.Add(New SqlParameter("@CantidadBotes", 0))
                cmd.Parameters.Add(New SqlParameter("@SumaBotes", 0))
                cmd.Parameters.Add(New SqlParameter("@Producto", CbProducto.Text))
                cmd.Parameters.Add(New SqlParameter("@IdEstatus", CbEstatus.SelectedValue))
                cmd.Parameters("@IdProduccion").Direction = ParameterDirection.InputOutput
                cmd.Parameters("@IdEstatus").Direction = ParameterDirection.InputOutput
                cmd.ExecuteNonQuery()
                TxIdProduccion.Text = cmd.Parameters("@IdProduccion").Value
                CbEstatus.SelectedValue = cmd.Parameters("@IdEstatus").Value
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cnn.Close()
                cargarData()
                GbAbrir.Enabled = False
                GbCaptura.Enabled = True
            End Try
        End If
    End Sub
    Private Sub cargarData()
        cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenaDgBotes", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@IdProduccion", IIf(TxIdProduccion.Text = "", 0, TxIdProduccion.Text)))
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgBoteIngresado.DataSource = dt
        cnn.Close()
    End Sub
    Private Sub CapturaBotes(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxCaptura.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
            e.KeyChar = CChar("")
            e.KeyChar = ChrW(Keys.Enter)
            CambioControlPesoBruto(sender, e)
        End If
    End Sub
    Private Sub CambioControlPesoBruto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TxCaptura.Text = "" Then
                MessageBox.Show("Campo de captura vacio.")
            Else
                Try
                    cnn.Open()
                    cmd = New SqlCommand("sp_InsBotes", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@IdBotes", 0))
                    cmd.Parameters.Add(New SqlParameter("@BotesRecibidos", 1))
                    cmd.Parameters.Add(New SqlParameter("@Empleado", TxCaptura.Text))
                    cmd.Parameters.Add(New SqlParameter("@Fecha", Now))
                    cmd.Parameters.Add(New SqlParameter("@FechaLetra", UCase(WeekdayName(Weekday(Now)))))
                    cmd.Parameters.Add(New SqlParameter("@PrecioBote", NuPrecio.Value))
                    cmd.Parameters.Add(New SqlParameter("@IdProduccion", TxIdProduccion.Text))
                    'cmd.Parameters("@IdProduccion").Direction = ParameterDirection.InputOutput
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    cnn.Close()
                    cargarData()
                    TxCaptura.Text = ""
                    TxCaptura.Select()
                End Try
            End If
        End If
    End Sub
    Private Sub TsNuevo_Click(sender As Object, e As EventArgs) Handles TsNuevo.Click
        nuevo()
    End Sub
    Private Sub TsConsultar_Click(sender As Object, e As EventArgs) Handles TsConsultar.Click
        Try
            Dim ConsultaProduccion As New CONSULTAPRODUCCION
            ConsultaProduccion.ShowDialog()
            ' limpiarcampos()
            Dim codigoSeleccionado As Object = ConsultaProduccion.CodigoProduccion
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
                NuPrecio.Value = row("Precio")
                CbProducto.Text = CStr(row("Producto"))
                CbEstatus.SelectedValue = row("IdEstatus")
                CargaBotes(TxIdProduccion.Text)
                GbAbrir.Enabled = False
                GbCaptura.Enabled = True
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
            DgBoteIngresado.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles BtCerrar.Click
        Dim opc As DialogResult = MessageBox.Show("¿Esta seguro de cerrar esta produccion? al hacerlo ya no podra agregar mas botes.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            If NuPrecio.Value = 0 Or CbProducto.SelectedValue = Nothing Or CbProducto.Text = "" Then
                MessageBox.Show("No puedes iniciar la produccion con campos vacios.", "Aviso")
            Else
                Dim TotalPrecio As Decimal
                TotalPrecio = DgBoteIngresado.RowCount * NuPrecio.Value
                Try
                    cnn.Open()
                    cmd = New SqlCommand("sp_InsProduccion", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@IdProduccion", TxIdProduccion.Text))
                    cmd.Parameters.Add(New SqlParameter("@Fecha", DtFecha.Value))
                    cmd.Parameters.Add(New SqlParameter("@FechaLetra", TxNombreDia.Text))
                    cmd.Parameters.Add(New SqlParameter("@Precio", NuPrecio.Value))
                    cmd.Parameters.Add(New SqlParameter("@CantidadBotes", DgBoteIngresado.RowCount))
                    cmd.Parameters.Add(New SqlParameter("@SumaBotes", TotalPrecio))
                    cmd.Parameters.Add(New SqlParameter("@Producto", CbProducto.Text))
                    cmd.Parameters.Add(New SqlParameter("@IdEstatus", 0))
                    cmd.Parameters("@IdProduccion").Direction = ParameterDirection.InputOutput
                    cmd.Parameters("@IdEstatus").Direction = ParameterDirection.InputOutput
                    cmd.ExecuteNonQuery()
                    CbEstatus.SelectedValue = cmd.Parameters("@IdEstatus").Value
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    cnn.Close()
                    cargarData()
                    GbAbrir.Enabled = False
                    GbCaptura.Enabled = False
                End Try
            End If
        End If
    End Sub
    Private Sub TsEliminar_Click(sender As Object, e As EventArgs) Handles TsEliminar.Click
        Dim opc As DialogResult = MessageBox.Show("¿Eliminar Bote?.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Dim index As Integer
            index = DgBoteIngresado.CurrentCell.RowIndex
            Dim id As Integer
            id = DgBoteIngresado.Rows(index).Cells("idbotes").Value
            Try
                cnn.Open()
                Dim cmd As New SqlCommand("sp_EliBotes", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@IdBotes", id))
                cmd.ExecuteNonQuery()
                cnn.Close()
                cargarData()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles TsSalir.Click
        Close()
    End Sub
End Class