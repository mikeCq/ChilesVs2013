Imports System.Data.SqlClient
Public Class Login
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Dim TablaUsuarios As DataTable
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        If TbUsuario.Text = "" Or TbPassword.Text = "" Then
            MessageBox.Show("Verificar campos vacios!")
            Exit Sub
        End If
        For Each fila As DataRow In TablaUsuarios.Rows
            If fila.Item("Usuario") = TbUsuario.Text And fila.Item("Password") = TbPassword.Text Then
                FInicio.ShowDialog()
                Close()
            Else
                MessageBox.Show("Usuario y/o contraseña incorrectos!")
            End If
        Next
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub

    Private Sub Consultar()
        If cnn.State <> ConnectionState.Open Then cnn.Open()
        Dim cmd As New SqlCommand("sp_ConUsu", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        TablaUsuarios = dt
        cnn.Close()
    End Sub
End Class