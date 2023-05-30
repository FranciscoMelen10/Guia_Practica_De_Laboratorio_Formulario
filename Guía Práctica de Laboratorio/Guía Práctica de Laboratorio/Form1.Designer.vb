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
        Me.AgentesVendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa_ABCDataSet1 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1()
        Me.AgentesVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa_ABCDataSet = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet()
        Me.AgentesVendedorTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AgentesVendedoresTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1TableAdapters.AgentesVendedoresTableAdapter()
        Me.Empresa_ABCDataSet11 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1()
        Me.VistaventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vista_ventasTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1TableAdapters.vista_ventasTableAdapter()
        Me.VistaventasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasFebreroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasFebreroTableAdapter = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1TableAdapters.VentasFebreroTableAdapter()
        Me.VentasFebreroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Empresa_ABCDataSet12 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1()
        Me.AgentesVendedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa_ABCDataSet13 = New Guía_Práctica_de_Laboratorio.Empresa_ABCDataSet1()
        Me.AgentesVendedoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AgentesVendedoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigovendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigozonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AgentesVendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaventasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasFebreroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasFebreroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa_ABCDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesVendedoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AgentesVendedoresBindingSource
        '
        Me.AgentesVendedoresBindingSource.DataMember = "AgentesVendedores"
        Me.AgentesVendedoresBindingSource.DataSource = Me.Empresa_ABCDataSet1
        '
        'Empresa_ABCDataSet1
        '
        Me.Empresa_ABCDataSet1.DataSetName = "Empresa_ABCDataSet1"
        Me.Empresa_ABCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Button1.Location = New System.Drawing.Point(665, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reporte de ventas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AgentesVendedoresTableAdapter
        '
        Me.AgentesVendedoresTableAdapter.ClearBeforeFill = True
        '
        'Empresa_ABCDataSet11
        '
        Me.Empresa_ABCDataSet11.DataSetName = "Empresa_ABCDataSet1"
        Me.Empresa_ABCDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaventasBindingSource
        '
        Me.VistaventasBindingSource.DataMember = "vista_ventas"
        Me.VistaventasBindingSource.DataSource = Me.Empresa_ABCDataSet11
        '
        'Vista_ventasTableAdapter
        '
        Me.Vista_ventasTableAdapter.ClearBeforeFill = True
        '
        'VistaventasBindingSource1
        '
        Me.VistaventasBindingSource1.DataMember = "vista_ventas"
        Me.VistaventasBindingSource1.DataSource = Me.Empresa_ABCDataSet11
        '
        'VentasFebreroBindingSource
        '
        Me.VentasFebreroBindingSource.DataMember = "VentasFebrero"
        Me.VentasFebreroBindingSource.DataSource = Me.Empresa_ABCDataSet1
        '
        'VentasFebreroTableAdapter
        '
        Me.VentasFebreroTableAdapter.ClearBeforeFill = True
        '
        'VentasFebreroBindingSource1
        '
        Me.VentasFebreroBindingSource1.DataMember = "VentasFebrero"
        Me.VentasFebreroBindingSource1.DataSource = Me.Empresa_ABCDataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(103, 73)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(527, 20)
        Me.txt_buscar.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(665, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Empresa_ABCDataSet12
        '
        Me.Empresa_ABCDataSet12.DataSetName = "Empresa_ABCDataSet1"
        Me.Empresa_ABCDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesVendedoresBindingSource1
        '
        Me.AgentesVendedoresBindingSource1.DataMember = "AgentesVendedores"
        Me.AgentesVendedoresBindingSource1.DataSource = Me.Empresa_ABCDataSet12
        '
        'Empresa_ABCDataSet13
        '
        Me.Empresa_ABCDataSet13.DataSetName = "Empresa_ABCDataSet1"
        Me.Empresa_ABCDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesVendedoresBindingSource2
        '
        Me.AgentesVendedoresBindingSource2.DataMember = "AgentesVendedores"
        Me.AgentesVendedoresBindingSource2.DataSource = Me.Empresa_ABCDataSet13
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigovendedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.CodigozonaDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn, Me.ComisionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AgentesVendedoresBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(12, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 186)
        Me.DataGridView1.TabIndex = 7
        '
        'AgentesVendedoresBindingSource3
        '
        Me.AgentesVendedoresBindingSource3.DataMember = "AgentesVendedores"
        Me.AgentesVendedoresBindingSource3.DataSource = Me.Empresa_ABCDataSet13
        '
        'CodigovendedorDataGridViewTextBoxColumn
        '
        Me.CodigovendedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigovendedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_vendedor"
        Me.CodigovendedorDataGridViewTextBoxColumn.HeaderText = "codigo_vendedor"
        Me.CodigovendedorDataGridViewTextBoxColumn.Name = "CodigovendedorDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        '
        'CodigozonaDataGridViewTextBoxColumn
        '
        Me.CodigozonaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigozonaDataGridViewTextBoxColumn.DataPropertyName = "codigo_zona"
        Me.CodigozonaDataGridViewTextBoxColumn.HeaderText = "codigo_zona"
        Me.CodigozonaDataGridViewTextBoxColumn.Name = "CodigozonaDataGridViewTextBoxColumn"
        '
        'SalarioDataGridViewTextBoxColumn
        '
        Me.SalarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SalarioDataGridViewTextBoxColumn.DataPropertyName = "salario"
        Me.SalarioDataGridViewTextBoxColumn.HeaderText = "salario"
        Me.SalarioDataGridViewTextBoxColumn.Name = "SalarioDataGridViewTextBoxColumn"
        '
        'ComisionDataGridViewTextBoxColumn
        '
        Me.ComisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ComisionDataGridViewTextBoxColumn.DataPropertyName = "comision"
        Me.ComisionDataGridViewTextBoxColumn.HeaderText = "comision"
        Me.ComisionDataGridViewTextBoxColumn.Name = "ComisionDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 312)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AgentesVendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaventasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasFebreroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasFebreroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa_ABCDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesVendedoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Empresa_ABCDataSet As Empresa_ABCDataSet
    Friend WithEvents AgentesVendedorBindingSource As BindingSource
    Friend WithEvents AgentesVendedorTableAdapter As Empresa_ABCDataSetTableAdapters.AgentesVendedorTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Empresa_ABCDataSet1 As Empresa_ABCDataSet1
    Friend WithEvents AgentesVendedoresBindingSource As BindingSource
    Friend WithEvents AgentesVendedoresTableAdapter As Empresa_ABCDataSet1TableAdapters.AgentesVendedoresTableAdapter
    Friend WithEvents Empresa_ABCDataSet11 As Empresa_ABCDataSet1
    Friend WithEvents VistaventasBindingSource As BindingSource
    Friend WithEvents Vista_ventasTableAdapter As Empresa_ABCDataSet1TableAdapters.vista_ventasTableAdapter
    Friend WithEvents VistaventasBindingSource1 As BindingSource
    Friend WithEvents VentasFebreroBindingSource As BindingSource
    Friend WithEvents VentasFebreroTableAdapter As Empresa_ABCDataSet1TableAdapters.VentasFebreroTableAdapter
    Friend WithEvents VentasFebreroBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Empresa_ABCDataSet12 As Empresa_ABCDataSet1
    Friend WithEvents AgentesVendedoresBindingSource1 As BindingSource
    Friend WithEvents Empresa_ABCDataSet13 As Empresa_ABCDataSet1
    Friend WithEvents AgentesVendedoresBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AgentesVendedoresBindingSource3 As BindingSource
    Friend WithEvents CodigovendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigozonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
