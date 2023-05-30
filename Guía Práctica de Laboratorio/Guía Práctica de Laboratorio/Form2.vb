Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Empresa_ABCDataSet11.VentasFebrero' Puede moverla o quitarla según sea necesario.
        Me.VentasFebreroTableAdapter1.Fill(Me.Empresa_ABCDataSet11.VentasFebrero)
        'TODO: esta línea de código carga datos en la tabla 'Empresa_ABCDataSet1.AgentesVendedores' Puede moverla o quitarla según sea necesario.
        Me.AgentesVendedoresTableAdapter.Fill(Me.Empresa_ABCDataSet1.AgentesVendedores)
        'TODO: esta línea de código carga datos en la tabla 'Empresa_ABCDataSet.VentasFebrero' Puede moverla o quitarla según sea necesario.
        Me.VentasFebreroTableAdapter.Fill(Me.Empresa_ABCDataSet.VentasFebrero)
        'TODO: This line of code loads data into the 'Empresa_ABCDataSet.AgentesVendedor' table. You can move, or remove it, as needed.
        Me.AgentesVendedorTableAdapter.Fill(Me.Empresa_ABCDataSet.AgentesVendedor)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class