Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA


Public Class ProveedoresDA
    Inherits conexion 'Incluimos la clase conexion 
    Dim cmd As New SqlCommand 'Variable para enviar peticiones a la BD
    Private da As SqlDataAdapter
    Private ds As DataSet

    Public Function mostrar() As DataTable
        Try
            conectado()

            cmd = New SqlCommand("select Cuit 'Cuit',id_tipo_dni 'Tipo DNI',RazonSocial 'Razon Social',Fantasia 'Nombre Fantasia',nombre'Nombre',Apellido,fecha_ini'Inicio de Actividad',Calle,Telefono,Celular,Mail, fecha_alta 'Fecha de Alta', NumeroCalle 'Numero',Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad,habilitado, Tipo_Prov 'Tipo de Proveedor' from Proveedor order by Fecha_Alta")
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
    Public Function insertarJuridica(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("insert into Proveedor(Cuit,id_tipo_dni,RazonSocial,Fantasia,fecha_ini,fecha_alta,calle,telefono,celular,mail,Tipo_Prov,NumeroCalle,Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad,habilitado,nombre,apellido) values (@Cuit,@id_tipo_dni,@RazonSocial,@Fantasia,@fecha_ini,@fecha_alta,@calle,@telefono,@celular,@mail,@tipo_prov, @NumeroCalle, @Edificio,@Piso, @Dpto,@CP,@Barrio,@Pais,@Provincia,@Ciudad,@habilitado,@nombre,@apellido)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cuit", dts.Cuit)
            'cmd.Parameters.AddWithValue("@nro_doc", dts.Nro_Doc)
            cmd.Parameters.AddWithValue("@RazonSocial", dts.RazonSocial)
            cmd.Parameters.AddWithValue("@Fantasia", dts.Fantasia)
            cmd.Parameters.AddWithValue("@fecha_Ini", dts.fecha_ini)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.fecha_alta)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@tipo_prov", dts.Tipo_prov)
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
    Public Function insertar(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("insert into Proveedor(Cuit,id_tipo_dni,nombre,apellido,fecha_ini,fecha_alta,calle,telefono,celular,mail,Tipo_prov,NumeroCalle,Edificio,Piso, Dpto,CP,Barrio,Pais,Provincia,Ciudad,habilitado,razonsocial,fantasia)values (@Cuit,@id_tipo_dni,@nombre,@apellido,@fecha_ini,@fecha_alta,@calle,@telefono,@celular,@mail,@tipo_Prov,@NumeroCalle,@Edificio,@Piso, @Dpto,@CP,@Barrio,@Pais,@Provincia,@Ciudad,@habilitado,@razonsocial,@fantasia)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cuit", dts.Cuit)
            'cmd.Parameters.AddWithValue("@nro_doc", dts.Nro_Doc)
            cmd.Parameters.AddWithValue("@id_tipo_dni", dts.Tipo_dni)
            cmd.Parameters.AddWithValue("@nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@apellido", dts.apellido)
            cmd.Parameters.AddWithValue("@fecha_ini", dts.fecha_ini)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.fecha_alta)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@tipo_prov", dts.Tipo_prov)
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
    Public Function editarJuridica(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("update Proveedor set RazonSocial=@RazonSocial,Fantasia=@Fantasia,fecha_ini=@fecha_ini,Calle=@Calle,telefono=@telefono,celular=@celular,mail=@mail,NumeroCalle=@NumeroCalle,Edificio=@Edificio,Piso=@Piso,Dpto=@Dpto,CP=@CP,Barrio=@Barrio,Pais=@Pais,Provincia=@Provincia,Ciudad=@Ciudad where Cuit=@Cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.Add("@Cuit", SqlDbType.NVarChar, 50).Value = dts.Cuit

            cmd.Parameters.AddWithValue("@RazonSocial", dts.RazonSocial)
            cmd.Parameters.AddWithValue("@Fantasia", dts.Fantasia)
            cmd.Parameters.AddWithValue("@fecha_ini", dts.fecha_ini)
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
    Public Function editar(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("update Proveedor set nombre=@nombre,apellido=@apellido,id_tipo_Dni=@id_tipo_Dni,fecha_ini=@fecha_ini,Calle=@Calle,telefono=@telefono,celular=@celular,mail=@mail,NumeroCalle=@NumeroCalle,Edificio=@Edificio,Piso=@Piso,Dpto=@Dpto,CP=@CP,Barrio=@Barrio,Pais=@Pais,Provincia=@Provincia,Ciudad=@Ciudad where Cuit=@Cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.Add("@Cuit", SqlDbType.NVarChar, 50).Value = dts.Cuit

            cmd.Parameters.AddWithValue("@nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@apellido", dts.apellido)
            cmd.Parameters.AddWithValue("@id_tipo_Dni", dts.Tipo_dni)
            cmd.Parameters.AddWithValue("@fecha_ini", dts.fecha_ini)
            cmd.Parameters.AddWithValue("@telefono", dts.telefono)
            cmd.Parameters.AddWithValue("@celular", dts.celular)
            cmd.Parameters.AddWithValue("@mail", dts.mail)
            cmd.Parameters.AddWithValue("@Calle", dts.Calle)
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
    Private objProveedorFiDA As ProveedoresDA
    Public Function buscarProveedor(ByVal Cuit As String) As DataRow
        Return objProveedorFiDA.buscarProveedorFisica(Cuit)
    End Function

    Public Function buscarProveedorFisica(ByVal Cuit As String) As DataRow

        Dim dr As DataRow
        conectado()
        da = New SqlDataAdapter("select Nombre,Apellido,id_tipo_dni,fecha_ini,fecha_alta,calle,telefono,celular,mail,NumeroCalle,Edificio,Piso,Dpto,CP,Barrio,Pais,Provincia,Ciudad from Proveedor where Cuit='" & Cuit & "'", cnn)
        ds = New DataSet

        Try


            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente
    '--------------------------------------------------------------------------------
    Private objProveedorDA As ProveedoresDA
    Public Function buscarProveedor2(ByVal Cuit As String) As DataRow
        Return objProveedorDA.buscarProveedorJURIDICO(Cuit)
    End Function
    '**********************************BUSCAR CLIENTE JURIDICO******************
    '***************
    Public Function buscarProveedorJURIDICO(ByVal Cuit As String) As DataRow

        Dim dr As DataRow
        conectado()
        da = New SqlDataAdapter("select RazonSocial,Fantasia,fecha_ini,calle,telefono,celular,mail,NumeroCalle,Edificio,Piso,Dpto,CP,Barrio,Pais,Provincia,Ciudad from Proveedor where Cuit='" & Cuit & "'", cnn)
        ds = New DataSet

        Try
            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
   

    Public Function buscar_Proveedor(ByVal texto As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select * from Proveedor where Cuit=@Cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Cuit", CChar(texto))
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

    Public Function Inhabilitar_Prov(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Update Proveedor set Habilitado='0' where Cuit=@Cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@Cuit", SqlDbType.NVarChar, 50).Value = dts.Cuit
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


    Public Function Habilitar_Prov(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Update Proveedor set Habilitado='1' where Cuit=@Cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@Cuit", SqlDbType.NVarChar, 50).Value = dts.Cuit
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