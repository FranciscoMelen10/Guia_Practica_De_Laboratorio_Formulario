<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigovendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigozonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentesVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa_ABCDataSet = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet()
        Me.AgentesVendedorTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigovendedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.CodigozonaDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn, Me.ComisionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AgentesVendedorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 238)
        Me.DataGridView1.TabIndex = 0
        '
        'CodigovendedorDataGridViewTextBoxColumn
        '
        Me.CodigovendedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_vendedor"
        Me.CodigovendedorDataGridViewTextBoxColumn.HeaderText = "codigo_vendedor"
        Me.CodigovendedorDataGridViewTextBoxColumn.Name = "CodigovendedorDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        '
        'CodigozonaDataGridViewTextBoxColumn
        '
        Me.CodigozonaDataGridViewTextBoxColumn.DataPropertyName = "codigo_zona"
        Me.CodigozonaDataGridViewTextBoxColumn.HeaderText = "codigo_zona"
        Me.CodigozonaDataGridViewTextBoxColumn.Name = "CodigozonaDataGridViewTextBoxColumn"
        '
        'SalarioDataGridViewTextBoxColumn
        '
        Me.SalarioDataGridViewTextBoxColumn.DataPropertyName = "salario"
        Me.SalarioDataGridViewTextBoxColumn.HeaderText = "salario"
        Me.SalarioDataGridViewTextBoxColumn.Name = "SalarioDataGridViewTextBoxColumn"
        '
        'ComisionDataGridViewTextBoxColumn
        '
        Me.ComisionDataGridViewTextBoxColumn.DataPropertyName = "comision"
        Me.ComisionDataGridViewTextBoxColumn.HeaderText = "comision"
        Me.ComisionDataGridViewTextBoxColumn.Name = "ComisionDataGridViewTextBoxColumn"
        '
        'AgentesVendedorBindingSource
        '
        Me.AgentesVendedorBindingSource.DataMember = "AgentesVendedor"
        Me.AgentesVendedorBindingSource.DataSource = Me.Empresa_ABCDataSet
        '
        'Empresa_ABCDataSet
        '
        Me.Empresa_ABCDataSet.DataSetName = "Empresa_ABCDataSet"
        Me.Empresa_ABCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesVendedorTableAdapter
        '
        Me.AgentesVendedorTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reporte de vendedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Empresa_ABCDataSet As Empresa_ABCDataSet
    Friend WithEvents AgentesVendedorBindingSource As BindingSource
    Friend WithEvents AgentesVendedorTableAdapter As Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter
    Friend WithEvents CodigovendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigozonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
