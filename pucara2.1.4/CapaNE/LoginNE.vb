Public Class LoginNE
    Dim usuario As String
    Dim password As String
    Dim categoria As String
    Dim habilitado As Integer

    Public Property nomusuario()
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property

    Public Property passusuario()
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property

    Public Property _categoria()
        Get
            Return categoria
        End Get
        Set(ByVal value)
            categoria = value
        End Set
    End Property

    Public Property _habilitado()
        Get
            Return habilitado
        End Get
        Set(ByVal value)
            habilitado = value
        End Set
    End Property

    Public Sub New(ByVal usuario As String, ByVal password As String)
        nomusuario = usuario
        passusuario = password
    End Sub

    Public Sub New(ByVal usuario As String, ByVal password As String, ByVal categoria As String)
        nomusuario = usuario
        passusuario = password
        categoria = categoria
    End Sub

    Public Sub New()
    End Sub
End Class
