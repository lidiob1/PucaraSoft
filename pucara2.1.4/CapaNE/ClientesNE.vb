Public Class ClientesNE

    Public Nro_Doc As Integer
    Public Property _Nro_Doc() As Integer
        Get
            Return Nro_Doc
        End Get
        Set(ByVal value As Integer)
            Nro_Doc = value
        End Set
    End Property

    Public Tipo_dni As String
    Public Property _Tipo_dni() As String
        Get
            Return Tipo_dni
        End Get
        Set(ByVal value As String)
            Tipo_dni = value
        End Set
    End Property

    Public nombre As String
    Public Property _Nombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public apellido As String
    Public Property _Apellido() As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property

    Public fecha_nac As Date
    Public Property _Fecha_nac() As Date
        Get
            Return fecha_nac
        End Get
        Set(ByVal value As Date)
            fecha_nac = value
        End Set
    End Property

    Public fecha_alta As Date
    Public Property _Fecha_alta() As Date
        Get
            Return fecha_alta
        End Get
        Set(ByVal value As Date)
            fecha_alta = value
        End Set
    End Property

    Public Calle As String
    Public Property _Calle() As String
        Get
            Return Calle
        End Get
        Set(ByVal value As String)
            Calle = value
        End Set
    End Property

    Public telefono As String
    Public Property _Telefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

    Public celular As String
    Public Property _Celular() As String
        Get
            Return celular
        End Get
        Set(ByVal value As String)
            celular = value
        End Set
    End Property

    Public mail As String
    Public Property _Mail() As String
        Get
            Return mail
        End Get
        Set(ByVal value As String)
            mail = value
        End Set
    End Property

    Public habilitado As Integer
    Public Property _Habilitado() As Integer
        Get
            Return habilitado
        End Get
        Set(ByVal value As Integer)
            habilitado = value
        End Set
    End Property
    Public TipoCliente As String
    Public Property _TipoCliente() As String
        Get
            Return TipoCliente
        End Get
        Set(ByVal value As String)
            TipoCliente = value
        End Set
    End Property
    Public NumCalle As Integer
    Public Property _NumCalle() As Integer
        Get
            Return NumCalle
        End Get
        Set(ByVal value As Integer)
            NumCalle = value
        End Set
    End Property
    Public Edificio As String
    Public Property _Edificio() As String
        Get
            Return Edificio
        End Get
        Set(ByVal value As String)
            Edificio = value
        End Set
    End Property

    Public Piso As String
    Public Property _Piso() As String
        Get
            Return Piso
        End Get
        Set(ByVal value As String)
            Piso = value
        End Set
    End Property
    Public Dpto As String
    Public Property _Dpto() As String
        Get
            Return Dpto
        End Get
        Set(ByVal value As String)
            Dpto = value
        End Set
    End Property
    Public CP As String
    Public Property _CP() As String
        Get
            Return CP
        End Get
        Set(ByVal value As String)
            CP = value
        End Set
    End Property

    Public Barrio As String
    Public Property _Barrio() As String
        Get
            Return Barrio
        End Get
        Set(ByVal value As String)
            Barrio = value
        End Set
    End Property

    Public Pais As String
    Public Property _Pais() As String
        Get
            Return Pais
        End Get
        Set(ByVal value As String)
            Pais = value
        End Set
    End Property
    Public Provincia As String
    Public Property _Provincia() As String
        Get
            Return Provincia
        End Get
        Set(ByVal value As String)
            Provincia = value
        End Set
    End Property
    Public Ciudad As String
    Public Property _Ciudad() As String
        Get
            Return Ciudad
        End Get
        Set(ByVal value As String)
            Ciudad = value
        End Set
    End Property
    Public RazonSocial As String
    Public Property _RazonSocial() As String
        Get
            Return RazonSocial
        End Get
        Set(ByVal value As String)
            RazonSocial = value
        End Set
    End Property
    Public Fantasia As String
    Public Property _Fantasia() As String
        Get
            Return Fantasia
        End Get
        Set(ByVal value As String)
            Fantasia = value
        End Set
    End Property
    'constructores 1 en blanco y otro con los datos
    Public Sub New()

    End Sub

    Public Sub New(ByVal Nro_Doc As Integer, ByVal Tipo_dni As String, ByVal Nombre As String, ByVal Apellido As String, ByVal Calle As String, ByVal Telefono As Integer, ByVal Celular As Integer, ByVal mail As String, ByVal fecha_nac As Date, ByVal fecha_alta As Date, ByVal habilitado As Integer, ByVal TipoCliente As String, ByVal NumCalle As Integer, ByVal Edificio As String, ByVal Piso As Integer, ByVal Dpto As String, ByVal CP As Integer, ByVal Barrio As String, ByVal Pais As String, ByVal Provincia As String, ByVal Ciudad As String, ByVal RazonSocial As String, ByVal Fantasia As String)
        _Nro_Doc = Nro_Doc
        _Tipo_dni = Tipo_dni
        _Nombre = Nombre
        _Apellido = Apellido
        _Calle = Calle
        _Telefono = Telefono
        _Celular = Celular
        _Mail = mail
        _Fecha_nac = fecha_nac
        _Fecha_alta = fecha_alta
        _Habilitado = habilitado
        _TipoCliente = TipoCliente
        _NumCalle = NumCalle
        _Edificio = Edificio
        _Piso = Piso
        _Dpto = Dpto
        _CP = CP
        _Barrio = Barrio
        _Pais = Pais
        _Provincia = Provincia
        _Ciudad = Ciudad
        _RazonSocial = RazonSocial
        _Fantasia = fantasia
    End Sub
End Class
