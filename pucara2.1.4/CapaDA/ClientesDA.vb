Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA


Public Class ClientesDA
    Inherits conexion 'Incluimos la clase conexion 
    Dim cmd As New SqlCommand 'Variable para enviar peticiones a la BD

    Public Function mostrar() As DataTable
        Try
            conectado()

            cmd = New SqlCommand("select nro_doc'DNI',nombre'Nombre',Apellido,fecha_nac'Fecha Nacimiento',fecha_alta 'Fecha de Alta' ,Calle,Telefono,Celular,Mail,TipoCliente,NumCalle 'Numero',Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad from Cliente order by nro_doc")
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

    Public Function insertar(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insert into cliente(nro_doc,nombre,apellido,fecha_nac,fecha_alta,calle,telefono,celular,mail,TipoCliente,NumCalle,Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad)values (@nro_doc,@nombre,@apellido,@fecha_nac,@fecha_alta,@calle,@telefono,@celular,@mail,@tipoCliente,@NumCalle,@Edificio,@Piso, @Dpto,@CP,@Barrio,@Pais,@Provincia,@Ciudad)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_doc", dts.Nro_Doc)
            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@apellido", dts.apellido)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.Fecha_nac)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.fecha_alta)
            cmd.Parameters.AddWithValue("@direccion", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@celular", dts.Celular)
            cmd.Parameters.AddWithValue("@mail", dts.Mail)
            cmd.Parameters.AddWithValue("@tipocliente", dts.TipoCliente)
            cmd.Parameters.AddWithValue("@NumCalle", dts.NumCalle)
            cmd.Parameters.AddWithValue("@Edificio", dts.Edificio)
            cmd.Parameters.AddWithValue("@Piso", dts.Piso)
            cmd.Parameters.AddWithValue("@Dpto", dts.Dpto)
            cmd.Parameters.AddWithValue("@CP", dts.CP)
            cmd.Parameters.AddWithValue("@Barrio", dts.Barrio)
            cmd.Parameters.AddWithValue("@Pais", dts.Pais)
            cmd.Parameters.AddWithValue("@Provincia", dts.Provincia)
            cmd.Parameters.AddWithValue("@Ciudad", dts.Ciudad)

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

    Public Function editar(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("update cliente set nro_doc=@nro_doc,nombre=@nombre,apellido=@apellido,fecha_nac=@fecha_nac,direccion=@direccion,telefono=@telefono,celular=@celular,mail=@mail,NumCalle=@NumCalle,Edificio=@Edificio,Piso=@Piso,Dpto=@Dpto,CP=@CP,Barrio=@Barrio,Pais=@Pais,Provincia=@Provincia,Ciudad=@Ciudad where nro_doc=@nro_doc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_doc", dts.Nro_Doc)
            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@apellido", dts.apellido)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.Fecha_nac)
            cmd.Parameters.AddWithValue("@calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@celular", dts.Celular)
            cmd.Parameters.AddWithValue("@mail", dts.Mail)
            cmd.Parameters.AddWithValue("@NumCalle", dts.NumCalle)
            cmd.Parameters.AddWithValue("@Edificio", dts.Edificio)
            cmd.Parameters.AddWithValue("@Piso", dts.Piso)
            cmd.Parameters.AddWithValue("@Dpto", dts.Dpto)
            cmd.Parameters.AddWithValue("@CP", dts.CP)
            cmd.Parameters.AddWithValue("@Barrio", dts.Barrio)
            cmd.Parameters.AddWithValue("@Pais", dts.Pais)
            cmd.Parameters.AddWithValue("@Provincia", dts.Provincia)
            cmd.Parameters.AddWithValue("@Ciudad", dts.Ciudad)


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

    Public Function buscar_cliente(ByVal texto As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select * from cliente where nro_doc=@nro_doc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_doc", CChar(texto))
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
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

    Public Function Inhabilitar_cli(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Update Cliente set Habilitado='0' where nro_doc=@nro_doc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@nro_doc", SqlDbType.NVarChar, 50).Value = dts.Nro_Doc
            If cmd.ExecuteNonQuery = True Then
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


    Public Function Habilitar_cli(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Update cliente set Habilitado='1' where nro_doc=@nro_doc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@nro_doc", SqlDbType.NVarChar, 50).Value = dts.Nro_Doc
            If cmd.ExecuteNonQuery = True Then
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
End Class