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
        Me.AgentesVendedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa_ABCDataSet = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet()
        Me.AgentesVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaABCDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasFebreroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AgentesVendedorTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter()
        Me.VentasFebreroTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSetTableAdapters.VentasFebreroTableAdapter()
        Me.VentasFebreroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa_ABCDataSet11 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1()
        Me.Empresa_ABCDataSet1 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1()
        Me.AgentesVendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentesVendedoresTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1TableAdapters.AgentesVendedoresTableAdapter()
        Me.VentasFebreroTableAdapter1 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1TableAdapters.VentasFebreroTableAdapter()
        Me.vista_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vista_ventasTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1TableAdapters.vista_ventasTableAdapter()
        CType(Me.AgentesVendedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaABCDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasFebreroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasFebreroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vista_ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AgentesVendedorBindingSource1
        '
        Me.AgentesVendedorBindingSource1.DataMember = "AgentesVendedor"
        Me.AgentesVendedorBindingSource1.DataSource = Me.Empresa_ABCDataSet
        '
        'Empresa_ABCDataSet
        '
        Me.Empresa_ABCDataSet.DataSetName = "Empresa_ABCDataSet"
        Me.Empresa_ABCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesVendedorBindingSource
        '
        Me.AgentesVendedorBindingSource.DataMember = "AgentesVendedor"
        Me.AgentesVendedorBindingSource.DataSource = Me.EmpresaABCDataSetBindingSource
        '
        'EmpresaABCDataSetBindingSource
        '
        Me.EmpresaABCDataSetBindingSource.DataSource = Me.Empresa_ABCDataSet
        Me.EmpresaABCDataSetBindingSource.Position = 0
        '
        'VentasFebreroBindingSource
        '
        Me.VentasFebreroBindingSource.DataMember = "VentasFebrero"
        Me.VentasFebreroBindingSource.DataSource = Me.Empresa_ABCDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vista_ventasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Guía_Práctica_de_Laboratorio.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'AgentesVendedorTableAdapter
        '
        Me.AgentesVendedorTableAdapter.ClearBeforeFill = True
        '
        'VentasFebreroTableAdapter
        '
        Me.VentasFebreroTableAdapter.ClearBeforeFill = True
        '
        'VentasFebreroBindingSource1
        '
        Me.VentasFebreroBindingSource1.DataMember = "VentasFebrero"
        Me.VentasFebreroBindingSource1.DataSource = Me.Empresa_ABCDataSet11
        '
        'Empresa_ABCDataSet11
        '
        Me.Empresa_ABCDataSet11.DataSetName = "Empresa_ABCDataSet1"
        Me.Empresa_ABCDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Empresa_ABCDataSet1
        '
        Me.Empresa_ABCDataSet1.DataSetName = "Empresa_ABCDataSet1"
        Me.Empresa_ABCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesVendedoresBindingSource
        '
        Me.AgentesVendedoresBindingSource.DataMember = "AgentesVendedores"
        Me.AgentesVendedoresBindingSource.DataSource = Me.Empresa_ABCDataSet1
        '
        'AgentesVendedoresTableAdapter
        '
        Me.AgentesVendedoresTableAdapter.ClearBeforeFill = True
        '
        'VentasFebreroTableAdapter1
        '
        Me.VentasFebreroTableAdapter1.ClearBeforeFill = True
        '
        'vista_ventasBindingSource
        '
        Me.vista_ventasBindingSource.DataMember = "vista_ventas"
        Me.vista_ventasBindingSource.DataSource = Me.Empresa_ABCDataSet1
        '
        'vista_ventasTableAdapter
        '
        Me.vista_ventasTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.AgentesVendedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaABCDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasFebreroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasFebreroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vista_ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EmpresaABCDataSetBindingSource As BindingSource
    Friend WithEvents Empresa_ABCDataSet As Empresa_ABCDataSet
    Friend WithEvents AgentesVendedorBindingSource As BindingSource
    Friend WithEvents AgentesVendedorTableAdapter As Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter
    Friend WithEvents VentasFebreroBindingSource As BindingSource
    Friend WithEvents VentasFebreroTableAdapter As Empresa_ABCDataSetTableAdapters.VentasFebreroTableAdapter
    Friend WithEvents Empresa_ABCDataSet1 As Empresa_ABCDataSet1
    Friend WithEvents AgentesVendedoresBindingSource As BindingSource
    Friend WithEvents AgentesVendedoresTableAdapter As Empresa_ABCDataSet1TableAdapters.AgentesVendedoresTableAdapter
    Friend WithEvents Empresa_ABCDataSet11 As Empresa_ABCDataSet1
    Friend WithEvents VentasFebreroBindingSource1 As BindingSource
    Friend WithEvents VentasFebreroTableAdapter1 As Empresa_ABCDataSet1TableAdapters.VentasFebreroTableAdapter
    Friend WithEvents AgentesVendedorBindingSource1 As BindingSource
    Friend WithEvents vista_ventasBindingSource As BindingSource
    Friend WithEvents vista_ventasTableAdapter As Empresa_ABCDataSet1TableAdapters.vista_ventasTableAdapter
End Class
