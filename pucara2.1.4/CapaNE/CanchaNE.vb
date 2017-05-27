

Public Class CanchaNE
    Public Id_Cancha As Integer
    Public Property _Id_Cancha() As Integer
        Get
            Return Id_Cancha
        End Get
        Set(ByVal value As Integer)
            Id_Cancha = value
        End Set
    End Property
    Public Habilitado As Integer
    Public Property _habilitado() As Integer
        Get
            Return Habilitado
        End Get
        Set(ByVal value As Integer)
            Habilitado = value
        End Set
    End Property
    Public Precio_cancha As Double
    Public Property _Precio_cancha() As Double
        Get
            Return Precio_cancha
        End Get
        Set(ByVal value As Double)
            Precio_cancha = value
        End Set
    End Property
    Public FechaActPrecio As DateTime
    Public Property _FechaActPrecio() As DateTime
        Get
            Return FechaActPrecio
        End Get
        Set(ByVal value As DateTime)
            FechaActPrecio = value
        End Set
    End Property
    Public Descripcion As String
    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property
    Public Num_Cancha As Integer
    Public Property _Num_cancha() As Integer
        Get
            Return Num_Cancha
        End Get
        Set(ByVal value As Integer)
            Num_Cancha = value
        End Set
    End Property
    Public TamCancha As String
    Public Property _TamCancha() As String
        Get
            Return TamCancha
        End Get
        Set(ByVal value As String)
            TamCancha = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal id_cancha As Integer, ByVal habilitado As Integer, ByVal precio_cancha As Double, ByVal fechaActPrecio As DateTime, ByVal descripcion As String, ByVal num_cancha As Integer, ByVal TamCancha As String)

        _Id_Cancha = id_cancha
        _habilitado = habilitado
        _Precio_cancha = precio_cancha
        _FechaActPrecio = fechaActPrecio
        _Descripcion = descripcion
        _Num_cancha = num_cancha
        _TamCancha = TamCancha
    End Sub

End Class