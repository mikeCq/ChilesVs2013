Imports System.Data
Imports System.Data.SqlClient
Public Class FInicio
    Dim connection As SqlConnection = Nothing
    Private Sub txtnumarticulo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyData
            'Case Keys.Enter
            '    SumaBotesTextBox.Text = CantidadBotesTextBox.Text * PrecioTextBox.Text
            'Case Keys.Tab
            '    SumaBotesTextBox.Text = CantidadBotesTextBox.Text * PrecioTextBox.Text
        End Select

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs)

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
End Class