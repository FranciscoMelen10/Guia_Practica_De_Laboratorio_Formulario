Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Empresa_ABCDataSet.AgentesVendedor' table. You can move, or remove it, as needed.
        Me.AgentesVendedorTableAdapter.Fill(Me.Empresa_ABCDataSet.AgentesVendedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class