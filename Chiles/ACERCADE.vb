Imports System.Reflection

Public Class ACERCADE
    Private Sub ACERCADE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
    End Sub
End Class