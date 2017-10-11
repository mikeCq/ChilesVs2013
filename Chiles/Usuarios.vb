Imports System.Data.SqlClient
Public Class Usuarios
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbID.Text = ""
        TbUser.Text = ""
        TbPassword.Text = ""
    End Sub
    Private Sub Guardar()
        Try
            If cnn.State <> ConnectionState.Open Then cnn.Open()
            Dim cmd As New SqlCommand("sp_InsUsu", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", TbID.Text))
            cmd.Parameters.Add(New SqlParameter("@Usuario", Convert.ToString(TbUser.Text)))
            cmd.Parameters.Add(New SqlParameter("@Password", Convert.ToString(TbPassword.Text)))
            cmd.Parameters("@IdUsuario").Direction = ParameterDirection.InputOutput
            cmd.ExecuteNonQuery()
            If TbID.Text = 0 Then
                TbID.Text = cmd.Parameters("@IdUsuario").Value
            End If
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.ToString)
        Finally
            MessageBox.Show("Usuario registrado con exito!")
        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        TbID.Text = IIf(TbID.Text = "", 0, TbID.Text)
        If TbUser.Text = "" Or TbPassword.Text = "" Then
            MessageBox.Show("Verificar campos vacios!")
            Exit Sub
        End If
        Guardar()
        Consultar()
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        Consultar()
        FormatoGridView()
    End Sub

    Private Sub Consultar()
        If cnn.State <> ConnectionState.Open Then cnn.Open()
        Dim cmd As New SqlCommand("sp_ConUsu", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgvUsuarios.DataSource = dt
        cnn.Close()
    End Sub

    Private Sub FormatoGridView()
        DgvUsuarios.Columns("IdUsuario").HeaderText = "ID"
        DgvUsuarios.Columns("Password").Visible = False
    End Sub

    Private Sub SeleccionPRoducto(sender As Object, e As EventArgs) Handles DgvUsuarios.DoubleClick
        If DgvUsuarios.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgvUsuarios Is Nothing Then
            Try
                If cnn.State <> ConnectionState.Open Then cnn.Open()
                Dim cmd As New SqlCommand("sp_ConUsuId", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlClient.SqlParameter("@IdUsuario", DgvUsuarios.CurrentRow.Cells("IdUsuario").Value))
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim row As DataRow = dt.Rows(0)
                TbID.Text = CStr(row("IdUsuario"))
                TbUser.Text = CStr(row("Usuario"))
                TbPassword.Text = CStr(row("Password"))
            Catch ex As Exception
            Finally
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class