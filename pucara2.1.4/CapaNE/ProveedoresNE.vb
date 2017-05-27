Public Class ProveedoresNE

    Public Tipo_prov As String
    Public Property _Tipo_prov() As String
        Get
            Return Tipo_prov
        End Get
        Set(ByVal value As String)
            Tipo_prov = value
        End Set
    End Property

    Public cuit As String
    Public Property _Cuit() As String
        Get
            Return cuit
        End Get
        Set(ByVal value As String)
            cuit = value
        End Set
    End Property

    Public razon_social As String
    Public Property _Razon_social() As String
        Get
            Return razon_social
        End Get
        Set(ByVal value As String)
            razon_social = value
        End Set
    End Property

    Public direccion As String
    Public Property _Direccion() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public telefono As Integer
    Public Property _Telefono() As Integer
        Get
            Return telefono
        End Get
        Set(ByVal value As Integer)
            telefono = value
        End Set
    End Property

    Public celular As Integer
    Public Property _Celular() As Integer
        Get
            Return celular
        End Get
        Set(ByVal value As Integer)
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

    Public cod_postal As Integer
    Public Property _Cod_postal() As Integer
        Get
            Return cod_postal
        End Get
        Set(ByVal value As Integer)
            cod_postal = value
        End Set
    End Property

    Public habilitado As String
    Public Property _Habilitado() As String
        Get
            Return habilitado
        End Get
        Set(ByVal value As String)
            habilitado = value
        End Set
    End Property

    Public fecha_ini As Date
    Public Property _fecha_ini() As Date
        Get
            Return fecha_ini
        End Get
        Set(ByVal value As Date)
            fecha_ini = value
        End Set
    End Property

    Public fecha_alta As Date
    Public Property _fecha_alta() As Date
        Get
            Return fecha_alta
        End Get
        Set(ByVal value As Date)
            fecha_alta = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal Tipo_prov As String, ByVal cuit As Integer, ByVal razon_social As String, ByVal direccion As String, ByVal telefono As Integer, ByVal Celular As Integer, ByVal cod_postal As Integer, ByVal Mail As String, ByVal habilitado As Integer, ByVal fecha_ini As Date, ByVal fecha_alta As Date)

        _Tipo_prov = Tipo_prov
        _Cuit = cuit
        _Razon_social = razon_social
        _Direccion = direccion
        _Telefono = telefono
        _Celular = Celular
        _Cod_postal = cod_postal
        _Mail = Mail
        _Habilitado = habilitado
        _fecha_ini = fecha_ini
        _fecha_alta = fecha_alta

    End Sub

End Class
