Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Empresa_ABCDataSet1.vista_ventas' Puede moverla o quitarla según sea necesario.
        Me.vista_ventasTableAdapter.Fill(Me.Empresa_ABCDataSet1.vista_ventas)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class