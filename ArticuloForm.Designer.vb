<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.descripcion = New System.Windows.Forms.Label
        Me.unidad = New System.Windows.Forms.Label
        Me.stock = New System.Windows.Forms.Label
        Me.costo = New System.Windows.Forms.Label
        Me.iva = New System.Windows.Forms.Label
        Me.utilidad = New System.Windows.Forms.Label
        Me.venta = New System.Windows.Forms.Label
        Me.codigo = New System.Windows.Forms.TextBox
        Me.descripcion1 = New System.Windows.Forms.TextBox
        Me.costo1 = New System.Windows.Forms.TextBox
        Me.utilidad1 = New System.Windows.Forms.TextBox
        Me.venta1 = New System.Windows.Forms.TextBox
        Me.stock1 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.aceptar = New System.Windows.Forms.Button
        Me.cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "codigo"
        '
        'descripcion
        '
        Me.descripcion.AutoSize = True
        Me.descripcion.Location = New System.Drawing.Point(47, 53)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(63, 13)
        Me.descripcion.TabIndex = 1
        Me.descripcion.Text = "Descripcion"
        '
        'unidad
        '
        Me.unidad.AutoSize = True
        Me.unidad.Location = New System.Drawing.Point(47, 79)
        Me.unidad.Name = "unidad"
        Me.unidad.Size = New System.Drawing.Size(39, 13)
        Me.unidad.TabIndex = 2
        Me.unidad.Text = "unidad"
        '
        'stock
        '
        Me.stock.AutoSize = True
        Me.stock.Location = New System.Drawing.Point(47, 116)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(35, 13)
        Me.stock.TabIndex = 3
        Me.stock.Text = "Stock"
        '
        'costo
        '
        Me.costo.AutoSize = True
        Me.costo.Location = New System.Drawing.Point(47, 153)
        Me.costo.Name = "costo"
        Me.costo.Size = New System.Drawing.Size(34, 13)
        Me.costo.TabIndex = 4
        Me.costo.Text = "Costo"
        '
        'iva
        '
        Me.iva.AutoSize = True
        Me.iva.Location = New System.Drawing.Point(47, 186)
        Me.iva.Name = "iva"
        Me.iva.Size = New System.Drawing.Size(22, 13)
        Me.iva.TabIndex = 5
        Me.iva.Text = "Iva"
        '
        'utilidad
        '
        Me.utilidad.AutoSize = True
        Me.utilidad.Location = New System.Drawing.Point(47, 220)
        Me.utilidad.Name = "utilidad"
        Me.utilidad.Size = New System.Drawing.Size(42, 13)
        Me.utilidad.TabIndex = 6
        Me.utilidad.Text = "Utilidad"
        '
        'venta
        '
        Me.venta.AutoSize = True
        Me.venta.Location = New System.Drawing.Point(47, 247)
        Me.venta.Name = "venta"
        Me.venta.Size = New System.Drawing.Size(35, 13)
        Me.venta.TabIndex = 7
        Me.venta.Text = "Venta"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(167, 25)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 20)
        Me.codigo.TabIndex = 8
        '
        'descripcion1
        '
        Me.descripcion1.Location = New System.Drawing.Point(167, 53)
        Me.descripcion1.Name = "descripcion1"
        Me.descripcion1.Size = New System.Drawing.Size(364, 20)
        Me.descripcion1.TabIndex = 9
        '
        'costo1
        '
        Me.costo1.Location = New System.Drawing.Point(167, 146)
        Me.costo1.Name = "costo1"
        Me.costo1.Size = New System.Drawing.Size(100, 20)
        Me.costo1.TabIndex = 11
        '
        'utilidad1
        '
        Me.utilidad1.Location = New System.Drawing.Point(167, 213)
        Me.utilidad1.Name = "utilidad1"
        Me.utilidad1.Size = New System.Drawing.Size(100, 20)
        Me.utilidad1.TabIndex = 12
        '
        'venta1
        '
        Me.venta1.AutoCompleteCustomSource.AddRange(New String() {"10.50", "21.00"})
        Me.venta1.Location = New System.Drawing.Point(167, 240)
        Me.venta1.Name = "venta1"
        Me.venta1.Size = New System.Drawing.Size(100, 20)
        Me.venta1.TabIndex = 13
        '
        'stock1
        '
        Me.stock1.AutoCompleteCustomSource.AddRange(New String() {"Litros", "Kilogramos", "Metros"})
        Me.stock1.Location = New System.Drawing.Point(167, 109)
        Me.stock1.Name = "stock1"
        Me.stock1.Size = New System.Drawing.Size(100, 20)
        Me.stock1.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kilos", "Litros", "Metros"})
        Me.ComboBox1.Location = New System.Drawing.Point(167, 82)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"10.50", "21.00"})
        Me.ComboBox2.Location = New System.Drawing.Point(167, 177)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(167, 312)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 16
        Me.aceptar.Text = "aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(347, 311)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 17
        Me.cancelar.Text = "cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'ArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 365)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.venta1)
        Me.Controls.Add(Me.utilidad1)
        Me.Controls.Add(Me.costo1)
        Me.Controls.Add(Me.stock1)
        Me.Controls.Add(Me.descripcion1)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.venta)
        Me.Controls.Add(Me.utilidad)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.costo)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.unidad)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArticuloForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents unidad As System.Windows.Forms.Label
    Friend WithEvents stock As System.Windows.Forms.Label
    Friend WithEvents costo As System.Windows.Forms.Label
    Friend WithEvents iva As System.Windows.Forms.Label
    Friend WithEvents utilidad As System.Windows.Forms.Label
    Friend WithEvents venta As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents descripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents costo1 As System.Windows.Forms.TextBox
    Friend WithEvents utilidad1 As System.Windows.Forms.TextBox
    Friend WithEvents venta1 As System.Windows.Forms.TextBox
    Friend WithEvents stock1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button

End Class
