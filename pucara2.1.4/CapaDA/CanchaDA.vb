Imports System.Data.SqlClient
Imports CapaNE

Public Class CanchaDA
    Inherits conexion
    Dim cmd As New SqlCommand
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private con As New SqlConnection

    '************************ FUNCION MOSTRAR Cancha*******************
    Public Function Mostrar_cancha() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select num_Cancha 'Numero de Cancha',Descripcion 'Descripcion',FechaActPrecio 'Fecha de Alta', habilitado 'Habilitado' from Cancha")
            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) ''adaptador con bd
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    '****************************FUNCION INSERTAR CANCHA **************************************
    Public Function Insertar_Cancha(ByVal dts As CanchaNE) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("insert into cancha (Num_cancha,habilitado,descripcion,fechaActPrecio) values(@num_cancha,@habilitado,@descripcion,@fechaActPrecio)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Num_cancha", dts.Num_Cancha)
            cmd.Parameters.AddWithValue("@Habilitado", dts.Habilitado)
            ' cmd.Parameters.AddWithValue("@precio_cancha", dts.Precio_cancha)
            cmd.Parameters.AddWithValue("@Descripcion", dts._Descripcion)
            cmd.Parameters.AddWithValue("@FechaActPrecio", dts.FechaActPrecio)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try

    End Function

    '******************************FUNCION EDITAR CANCHA*****************************************
    Public Function Editar_Cancha(ByVal dts As CanchaNE) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("update cancha set num_cancha=@num_cancha,fechaActPrecio=@fechaActPrecio,descripcion=@descripcion where Num_cancha=@Num_cancha")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Num_cancha", dts.Num_Cancha)
            'cmd.Parameters.AddWithValue("precio_cancha", dts.Precio_cancha)
            cmd.Parameters.AddWithValue("@fechaActPrecio", dts.FechaActPrecio)
            cmd.Parameters.AddWithValue("@Descripcion", dts._TamCancha)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

    '************************************FUNCION INHABILITAR CANCHA ***********************
    Public Function Inhabilitar_cancha(ByVal dts As CanchaNE) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("update cancha set habilitado=0 where Num_Cancha=@Num_Cancha")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Num_Cancha", SqlDbType.Int).Value = dts.Num_Cancha
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

    '*************************************FUNCION HABILITAR CANCHA***************************
    Public Function Habilitar_cancha(ByVal dts As CanchaNE) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("update cancha set habilitado=1 where Num_Cancha=@Num_Cancha")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Num_Cancha", SqlDbType.Int).Value = dts.Num_Cancha

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
    '****************************************FUNCION BUSCAR CANCHA*******************************
    Public Function Buscar_cancha(ByVal dts As CanchaNE) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("select * from cancha where Num_Cancha=@num_Cancha")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Num_Cancha", dts.Num_Cancha)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
    '************************************ACUMULADOR NUMERO DE CANCHA****************************

    Public Function Mostrar_NumMax() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("Select MAX(num_cancha)+1 from cancha")
            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dtt As New DataTable
                Dim da As New SqlDataAdapter(cmd) ''adaptador con bd
                da.Fill(dtt)
                Return dtt
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

End Class


