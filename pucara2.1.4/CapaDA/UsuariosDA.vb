Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA


Public Class UsuariosDA
    Inherits conexion 'Incluimos la clase conexion 
    Dim cmd As New SqlCommand 'Variable para enviar peticiones a la BD

    Private com As New SqlCommand

    ' Private objLoginDA As UsuariosDatos

    'Constructor sin parametros, instanciamos un objeto del tipo VendedorDA
    ' Public Sub New()
    '    objLoginDA = New UsuariosDatos
    'End Sub

    Public Function mostrar() As DataTable

        Try
            conectado()

            cmd = New SqlCommand("select usuario,contrasena,categoria,habilitado,Id_permiso from Usuario")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable 'Crea una tabla en memoria 
                Dim da As New SqlDataAdapter(cmd) 'Nexo para conectar BD y mostrar en la App 
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As UsuariosNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insert into usuario(usuario,contrasena,categoria,habilitado)values (@usuario,@contrasena,@categoria,@habilitado)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@usuario", dts.Nom_usuario)
            cmd.Parameters.AddWithValue("@contrasena", dts.Password)
            cmd.Parameters.AddWithValue("@categoria", dts.Categoria)
            cmd.Parameters.AddWithValue("@habilitado", dts.Habilitado)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As UsuariosNE) As Boolean
        Dim sel As String

        Try
            conectado()

            sel = "UPDATE Usuario set usuario='" & _
                dts.nom_usuario & "', contraseña = '" & _
                dts.password & "', categoria = '" & _
                dts.categoria & "', Habilitado = '" & _
                dts.habilitado & "' WHERE usuario like'%" & dts.nom_usuario & "%'"

            com.CommandText = sel
            com.ExecuteNonQuery()

            If com.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cnn.Close()
        End Try
    End Function

    Public Function eliminar(ByVal dts As UsuariosNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("delete usuario(usuario,contrasena,categoria,habilitado,id_permiso)values (@usuario,@contrasena,@categoria,@habilitado,@id_permiso)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = dts.Id_usuario
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    Public Function habilitado(ByVal dts As UsuariosNE) As Boolean

        Dim sel As String
        Try
            If dts.habilitado = 0 Then
                sel = "UPDATE Usuario set habilitado='" & _
                    1 & _
                    "' WHERE usuario like'%" & dts.nom_usuario & "%'"
            Else
                sel = "UPDATE Usuario set habilitado='" & _
                    0 & _
                    "' WHERE usuario like'%" & dts.nom_usuario & "%'"
            End If


            com.CommandText = sel
            com.ExecuteNonQuery()

            If com.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cnn.Close()
        End Try
    End Function
    Public Function Validar(ByVal dat As UsuariosNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usuario", dat.nom_usuario)
            cmd.Parameters.AddWithValue("@contrasena", dat.password)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    ' Public Function verificarAdminEmpleado(ByVal usuario As UsuariosLogica)
    '   Return objLoginDA.verificarAdminEmpleado(usuario)
    'End Function


End Class
