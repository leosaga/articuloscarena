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
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        miarticulo.codigo = codigo.Text
        'cint comvierta a entero
        miarticulo.descripcion = (descripcion.Text)
        'cdate comvierta a fecha
        miarticulo.stock = CInt(stock.Text)
        miarticulo.costo = costo.Text

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
End Class
