Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Empresa_ABCDataSet1.AgentesVendedores' Puede moverla o quitarla según sea necesario.
        Me.AgentesVendedoresTableAdapter.Fill(Me.Empresa_ABCDataSet1.AgentesVendedores)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
    End Sub
End Class
