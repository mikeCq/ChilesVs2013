Imports System.Data
Imports System.Data.SqlClient
Public Class PRODUCTOS
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarData()
        Nuevo()
    End Sub
    Private Sub Nuevo()
        TxIdProducto.Text = ""
        TxProducto.Text = ""
    End Sub
    Private Sub TsNuevo_Click(sender As Object, e As EventArgs) Handles TsNuevo.Click
        Nuevo()
    End Sub
    Private Sub TsGuardar_Click(sender As Object, e As EventArgs) Handles TsGuardar.Click
        Try
            cnn.Open()
            cmd = New SqlCommand("sp_InsProducto", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProducto", 0))
            cmd.Parameters.Add(New SqlParameter("@Nombre", TxProducto.Text))

            cmd.Parameters("@IdProducto").Direction = ParameterDirection.InputOutput

            cmd.ExecuteNonQuery()

            TxIdProducto.Text = cmd.Parameters("@IdProducto").Value

        Catch ex As Exception
        Finally
            cnn.Close()
            CargarData()
        End Try
    End Sub
    Private Sub CargarData()
        cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenaDgProductos", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgProductos.DataSource = dt
        cnn.Close()
    End Sub

    Private Sub TsEliminar_Click(sender As Object, e As EventArgs) Handles TsEliminar.Click
        Try
            cnn.Open()
            cmd = New SqlCommand("sp_EliProducto", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdProducto", TxIdProducto.Text))

            cmd.ExecuteNonQuery()

        Catch ex As Exception
        Finally
            cnn.Close()
            CargarData()
        End Try
    End Sub

    Private Sub SeleccionPRoducto(sender As Object, e As EventArgs) Handles DgProductos.DoubleClick
        If DgProductos.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgProductos Is Nothing Then
            Try
                cnn.Open()
                Dim cmd As New SqlCommand("sp_SelProducto", cnn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@idproducto", DgProductos.CurrentRow.Cells(0).Value))

                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)
                Dim row As DataRow = dt.Rows(0)
                TxIdProducto.Text = CStr(row("idproducto"))
                TxProducto.Text = CStr(row("nombre"))

            Catch ex As Exception
            Finally
                cnn.Close()
            End Try
        End If

    End Sub
End Class