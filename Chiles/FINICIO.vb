Imports System.Data
Imports System.Data.SqlClient
Public Class FInicio
    Dim connection As SqlConnection = Nothing
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        PRODUCTOS.ShowDialog()
    End Sub
    Private Sub EstablecerPrecioDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecerPrecioDiarioToolStripMenuItem.Click
        Produccion.ShowDialog()
    End Sub

    Private Sub LiquidacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionesToolStripMenuItem.Click
        CatalogosToolStripMenuItem.BackColor = Color.Red
        LIQUIDACIONES.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        CatalogosToolStripMenuItem.BackColor = Color.Red
        Close()
    End Sub

    Private Sub ReporteDeLiquidacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeLiquidacionesToolStripMenuItem.Click

    End Sub

    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class