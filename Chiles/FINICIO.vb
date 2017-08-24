Imports System.Data
Imports System.Data.SqlClient
Public Class FInicio
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cnn.State <> ConnectionState.Open Then
            cnn.Open()
            MessageBox.Show("Conexión establecida con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cnn.Close()
        End If
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        PRODUCTOS.ShowDialog()
    End Sub
    Private Sub EstablecerPrecioDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecerPrecioDiarioToolStripMenuItem.Click
        Produccion.ShowDialog()
    End Sub

    Private Sub LiquidacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionesToolStripMenuItem.Click
        LIQUIDACIONES.ShowDialog()
    End Sub
    Private Sub ReporteDeLiquidacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeLiquidacionesToolStripMenuItem.Click
        ConsultaLiquidaciones.ShowDialog()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class