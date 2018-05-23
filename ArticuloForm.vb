Public Class ArticuloForm
    Dim operacion_ As String



    Dim miarticulo As New ArticuloClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        miarticulo.codigo = CInt(codigo.Text)
        'cint comvierta a entero
        miarticulo.descripcion = descripcion1.Text
        'saca el texto
        miarticulo.unidad = ComboBox1.SelectedItem
        miarticulo.stock = CDec(stock1.Text)
        'saca la fila o numero
        miarticulo.iva = ComboBox2.SelectedIndex
        miarticulo.costo = CDec(costo1.Text)
        miarticulo.utilidad = CDec(utilidad1.Text)
        Select Case operacion_
            Case "alta"
                lst.Add(miarticulo)
            Case "elimina"
                lst.RemoveAt(indice_)
            Case "modifica"
                lst.Item(indice_) = miarticulo

                ArticulosGrid.DataGridView1.Refresh()

        End Select
        Me.Close()
    End Sub


    
   
    Private Sub codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" Then
            ' no lo deja pasar
            e.Handled = True
            'sale sin procesar
            Exit Sub

        End If




    End Sub


    Private Sub stock1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles stock1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            ' no lo deja pasar
            e.Handled = True
            'sale sin procesar
            Exit Sub

        End If


    End Sub

    Private Sub costo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles costo1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "," Then
            ' no lo deja pasar
            e.Handled = True
            'sale sin procesar
            Exit Sub

        End If
    End Sub

    Private Sub utilidad1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles utilidad1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "," Then
            ' no lo deja pasar
            e.Handled = True
            'sale sin procesar
            Exit Sub

        End If

    End Sub

    Private Sub ArticuloForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox2.DataSource = listaiva

    End Sub
End Class
