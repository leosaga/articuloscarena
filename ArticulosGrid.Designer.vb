<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosGrid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ArticulosCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nuevo = New System.Windows.Forms.Button
        Me.eleminar = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.salir = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UtilidadDataGridViewTextBoxColumn, Me.VentaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArticulosCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(701, 380)
        Me.DataGridView1.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "iva"
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UtilidadDataGridViewTextBoxColumn
        '
        Me.UtilidadDataGridViewTextBoxColumn.DataPropertyName = "utilidad"
        Me.UtilidadDataGridViewTextBoxColumn.HeaderText = "utilidad"
        Me.UtilidadDataGridViewTextBoxColumn.Name = "UtilidadDataGridViewTextBoxColumn"
        Me.UtilidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentaDataGridViewTextBoxColumn
        '
        Me.VentaDataGridViewTextBoxColumn.DataPropertyName = "venta"
        Me.VentaDataGridViewTextBoxColumn.HeaderText = "venta"
        Me.VentaDataGridViewTextBoxColumn.Name = "VentaDataGridViewTextBoxColumn"
        Me.VentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticulosCollectionBindingSource
        '
        Me.ArticulosCollectionBindingSource.DataSource = GetType(WindowsApplication1.ArticulosCollection)
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(57, 340)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(75, 23)
        Me.nuevo.TabIndex = 1
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'eleminar
        '
        Me.eleminar.Location = New System.Drawing.Point(220, 339)
        Me.eleminar.Name = "eleminar"
        Me.eleminar.Size = New System.Drawing.Size(75, 23)
        Me.eleminar.TabIndex = 2
        Me.eleminar.Text = "Eleminar"
        Me.eleminar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(372, 339)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(75, 23)
        Me.modificar.TabIndex = 3
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(542, 340)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 4
        Me.salir.Text = "Button4"
        Me.salir.UseVisualStyleBackColor = True
        '
        'ArticulosGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 424)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.eleminar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ArticulosGrid"
        Me.Text = "ArticulosGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticulosCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents eleminar As System.Windows.Forms.Button
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
End Class
