<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Empresa_ABCDataSet = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet()
        Me.EmpresaABCDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentesVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentesVendedorTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaABCDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AgentesVendedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Guía_Práctica_de_Laboratorio.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 387)
        Me.ReportViewer1.TabIndex = 0
        '
        'Empresa_ABCDataSet
        '
        Me.Empresa_ABCDataSet.DataSetName = "Empresa_ABCDataSet"
        Me.Empresa_ABCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaABCDataSetBindingSource
        '
        Me.EmpresaABCDataSetBindingSource.DataSource = Me.Empresa_ABCDataSet
        Me.EmpresaABCDataSetBindingSource.Position = 0
        '
        'AgentesVendedorBindingSource
        '
        Me.AgentesVendedorBindingSource.DataMember = "AgentesVendedor"
        Me.AgentesVendedorBindingSource.DataSource = Me.EmpresaABCDataSetBindingSource
        '
        'AgentesVendedorTableAdapter
        '
        Me.AgentesVendedorTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaABCDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EmpresaABCDataSetBindingSource As BindingSource
    Friend WithEvents Empresa_ABCDataSet As Empresa_ABCDataSet
    Friend WithEvents AgentesVendedorBindingSource As BindingSource
    Friend WithEvents AgentesVendedorTableAdapter As Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter
End Class
