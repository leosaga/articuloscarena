Public Class ArticuloClass
    Dim codigo_, iva_ As Integer
    Dim descripcion_, unidad_ As String
    Dim contiva As Decimal

    Dim stock_, costo_, utilidad_, venta_ As Decimal




    Public Property codigo() As Integer
        Get
            Return codigo_
        End Get
        Set(ByVal value As Integer)
            codigo_ = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property
    Public Property costo() As Decimal
        Get
            Return costo_
        End Get
        Set(ByVal value As Decimal)
            costo_ = value
        End Set
    End Property
    Public Property iva() As Integer
        Get
            Return iva_
        End Get
        Set(ByVal value As Integer)
            iva_ = value
        End Set
    End Property

    Public Property utilidad() As Decimal
        Get
            Return utilidad_
        End Get
        Set(ByVal value As Decimal)
            utilidad_ = value
        End Set
    End Property
    Public Property unidad() As String
        Get
            Return unidad_
        End Get
        Set(ByVal value As String)
            unidad_ = value
        End Set
    End Property
    Public Property stock() As Decimal
        Get
            Return stock_
        End Get
        Set(ByVal value As Decimal)
            stock_ = value
        End Set
    End Property



    Public ReadOnly Property venta() As Decimal
        Get
            If iva_ = 0 Then
                contiva = 21.0
            Else
                contiva = 10.5
            End If
            venta_ = costo_ * (1 + contiva / 100) * (1 + utilidad_ / 100)

            Return venta_

        End Get
    End Property


    Public ReadOnly Property detalleiva() As String
        Get
            Return listaiva_(iva_)
        End Get

    End Property


End Class
