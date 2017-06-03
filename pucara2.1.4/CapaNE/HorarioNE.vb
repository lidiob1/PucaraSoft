Public Class HorarioNE
    
    Private _fecha_desde As Date
    Public Property feha_desde() As Date
        Get
            Return _fecha_desde
        End Get
        Set(ByVal value As Date)
            _fecha_desde = value
        End Set
    End Property

    Private _fecha_hasta As Date
    Public Property fecha_hasta() As Date
        Get
            Return _fecha_hasta
        End Get
        Set(ByVal value As Date)
            _fecha_hasta = value
        End Set
    End Property


End Class
