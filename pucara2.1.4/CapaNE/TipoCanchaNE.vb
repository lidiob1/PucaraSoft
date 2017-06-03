Public Class TipoCanchaNE

    Private id_cancha As Integer
    Public Property _id_cancha() As Integer
        Get
            Return id_cancha
        End Get
        Set(ByVal value As Integer)
            id_cancha = value
        End Set
    End Property

    Private id_tipo_cancha As Integer
    Public Property _id_tipo_cancha() As Integer
        Get
            Return id_tipo_cancha
        End Get
        Set(ByVal value As Integer)
            id_tipo_cancha = value
        End Set
    End Property

    Private descripcion As String
    Public Property _descripcion() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property


End Class
