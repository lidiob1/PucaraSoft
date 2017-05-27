Public Class UsuariosNE

    Public id_usuario As String
    Public Property _Id_usuario() As String
        Get
            Return Id_usuario
        End Get
        Set(ByVal value As String)
            id_usuario = value
        End Set
    End Property

    Public nom_usuario As String
    Public Property _Nom_usuario() As String
        Get
            Return Nom_usuario
        End Get
        Set(ByVal value As String)
            nom_usuario = value
        End Set
    End Property

    Public password As String
    Public Property _Password() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public categoria As String
    Public Property _Categoria() As String
        Get
            Return categoria
        End Get
        Set(ByVal value As String)
            categoria = value
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

    Public id_permiso As Integer
    Public Property _Id_permiso() As Integer
        Get
            Return id_permiso
        End Get
        Set(ByVal value As Integer)
            id_permiso = value
        End Set
    End Property

    'constructores 1 en blanco y otro con los datos
    Public Sub New()

    End Sub

    Public Sub New(ByVal Id_usuario As Integer, ByVal Nom_usuario As String, ByVal Password As String, ByVal Categoria As String, ByVal Habilitado As Integer, ByVal id_permiso As String)
        _Id_usuario = Id_usuario
        _Nom_usuario = Nom_usuario
        _Password = Password
        _Categoria = Categoria
        _Habilitado = Habilitado
        _Id_permiso = id_permiso

    End Sub



End Class
