Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Empresa_ABCDataSet.AgentesVendedor' table. You can move, or remove it, as needed.
        Me.AgentesVendedorTableAdapter.Fill(Me.Empresa_ABCDataSet.AgentesVendedor)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
    End Sub
End Class
