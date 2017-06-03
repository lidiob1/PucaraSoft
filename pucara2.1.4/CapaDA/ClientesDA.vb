Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA


Public Class ClientesDA
    Inherits conexion 'Incluimos la clase conexion 
    Dim cmd As New SqlCommand 'Variable para enviar peticiones a la BD
    Private da As SqlDataAdapter
    Private ds As DataSet

    Public Function mostrar() As DataTable
        Try
            conectado()

            cmd = New SqlCommand("select nro_doc'DNI',id_tipo_dni 'Tipo DNI',nombre'Nombre',Apellido,RazonSocial 'Razon Social', Fantasia 'Nombre Fantasia',fecha_nac'Fecha Nacimiento',Calle,Telefono,Celular,Mail,fecha_alta 'Fecha de Alta',NumeroCalle 'Numero',Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad,habilitado,TipoCliente 'Tipo de Cliente' from Cliente order by nro_doc")
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
    Public Function insertarJuridica(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("insert into cliente(nro_doc,id_tipo_dni,RazonSocial,Fantasia,fecha_nac,fecha_alta,calle,telefono,celular,mail,TipoCliente,NumeroCalle,Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad,habilitado,nombre,apellido)values (@nro_doc,@id_tipo_dni,@RazonSocial,@Fantasia,@fecha_nac,@fecha_alta,@calle,@telefono,@celular,@mail,@tipoCliente,@NumeroCalle,@Edificio,@Piso, @Dpto,@CP,@Barrio,@Pais,@Provincia,@Ciudad,@habilitado,@nombre,@apellido)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_doc", dts.Nro_Doc)
            cmd.Parameters.AddWithValue("@RazonSocial", dts.RazonSocial)
            cmd.Parameters.AddWithValue("@Fantasia", dts.Fantasia)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.fecha_nac)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.fecha_alta)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@tipocliente", dts.TipoCliente)
            cmd.Parameters.AddWithValue("@NumeroCalle", dts.NumCalle)
            cmd.Parameters.AddWithValue("@Edificio", dts.Edificio)
            cmd.Parameters.AddWithValue("@Piso", dts.Piso)
            cmd.Parameters.AddWithValue("@Dpto", dts.Dpto)
            cmd.Parameters.AddWithValue("@CP", dts.CP)
            cmd.Parameters.AddWithValue("@Barrio", dts.Barrio)
            cmd.Parameters.AddWithValue("@Pais", dts.Pais)
            cmd.Parameters.AddWithValue("@Provincia", dts.Provincia)
            cmd.Parameters.AddWithValue("@Ciudad", dts.Ciudad)
            cmd.Parameters.AddWithValue("@habilitado", dts.habilitado)
            cmd.Parameters.AddWithValue("@id_tipo_dni", dts.Tipo_dni)
            cmd.Parameters.AddWithValue("@Nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts.apellido)

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
    Public Function insertar(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("insert into cliente(nro_doc,id_tipo_dni,nombre,apellido,fecha_nac,fecha_alta,calle,telefono,celular,mail,TipoCliente,NumeroCalle,Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad,habilitado,razonsocial,fantasia)values (@nro_doc,@id_tipo_dni,@nombre,@apellido,@fecha_nac,@fecha_alta,@calle,@telefono,@celular,@mail,@tipoCliente,@NumeroCalle,@Edificio,@Piso, @Dpto,@CP,@Barrio,@Pais,@Provincia,@Ciudad,@habilitado,@razonsocial,@fantasia)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nro_doc", dts.Nro_Doc)
            cmd.Parameters.AddWithValue("@id_tipo_dni", dts.Tipo_dni)
            cmd.Parameters.AddWithValue("@nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@apellido", dts.apellido)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.fecha_nac)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.fecha_alta)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@tipocliente", dts.TipoCliente)
            cmd.Parameters.AddWithValue("@NumeroCalle", dts.NumCalle)
            cmd.Parameters.AddWithValue("@Edificio", dts.Edificio)
            cmd.Parameters.AddWithValue("@Piso", dts.Piso)
            cmd.Parameters.AddWithValue("@Dpto", dts.Dpto)
            cmd.Parameters.AddWithValue("@CP", dts.CP)
            cmd.Parameters.AddWithValue("@Barrio", dts.Barrio)
            cmd.Parameters.AddWithValue("@Pais", dts.Pais)
            cmd.Parameters.AddWithValue("@Provincia", dts.Provincia)
            cmd.Parameters.AddWithValue("@Ciudad", dts.Ciudad)
            cmd.Parameters.AddWithValue("@habilitado", dts.habilitado)
            cmd.Parameters.AddWithValue("@RazonSocial", dts.RazonSocial)
            cmd.Parameters.AddWithValue("@Fantasia", dts.Fantasia)

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

    '************************************ Funcion Editar CLiente******************************
    Public Function editarJuridica(ByVal dts As ClientesNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("update cliente set RazonSocial=@RazonSocial,Fantasia=@Fantasia,fecha_nac=@fecha_nac,Calle=@Calle,telefono=@telefono,celular=@celular,mail=@mail,NumeroCalle=@NumeroCalle,Edificio=@Edificio,Piso=@Piso,Dpto=@Dpto,CP=@CP,Barrio=@Barrio,Pais=@Pais,Provincia=@Provincia,Ciudad=@Ciudad where nro_doc=@nro_doc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.Add("@nro_doc", SqlDbType.NVarChar, 50).Value = dts.Nro_Doc

            cmd.Parameters.AddWithValue("@RazonSocial", dts.RazonSocial)
            cmd.Parameters.AddWithValue("@Fantasia", dts.Fantasia)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.fecha_nac)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@NumeroCalle", dts.NumCalle)
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
            cmd = New SqlCommand("update cliente set nombre=@nombre,apellido=@apellido,fecha_nac=@fecha_nac,Calle=@Calle,telefono=@telefono,celular=@celular,mail=@mail,NumeroCalle=@NumeroCalle,Edificio=@Edificio,Piso=@Piso,Dpto=@Dpto,CP=@CP,Barrio=@Barrio,Pais=@Pais,Provincia=@Provincia,Ciudad=@Ciudad where nro_doc=@nro_doc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.Add("@nro_doc", SqlDbType.NVarChar, 50).Value = dts.Nro_Doc

            cmd.Parameters.AddWithValue("@nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@apellido", dts.apellido)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.fecha_nac)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@NumeroCalle", dts.NumCalle)
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
    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente desde su numero de documento
    '--------------------------------------------------------------------------------
    Public Function buscarCliente(ByVal nro_doc As String) As DataRow

        Dim dr As DataRow
        conectado()
        da = New SqlDataAdapter("select Nombre,Apellido,id_tipo_dni,fecha_nac,fecha_alta,calle,telefono,celular,mail,NumeroCalle,Edificio,Piso,Dpto,CP,Barrio,Pais,Provincia,Ciudad from Cliente where nro_doc='" & nro_doc & "'", cnn)
        ds = New DataSet

        Try


            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            'Return Nothing
        End Try
    End Function
    '**********************************BUSCAR CLIENTE JURIDICO******************
    '***************
    Public Function buscarClienteJURIDICO(ByVal nro_doc As String) As DataRow

        Dim dr As DataRow
        conectado()
        da = New SqlDataAdapter("select RazonSocial,Fantasia,fecha_nac,calle,telefono,celular,mail,NumeroCalle,Edificio,Piso,Dpto,CP,Barrio,Pais,Provincia,Ciudad from Cliente where nro_doc='" & nro_doc & "'", cnn)
        ds = New DataSet

        Try


            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            'Return Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente
    '--------------------------------------------------------------------------------
    Private objClienteDA As ClientesDA
    Public Function buscarCliente2(ByVal nro_doc As Long) As DataRow
        Return objClienteDA.buscarCliente(nro_doc)
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