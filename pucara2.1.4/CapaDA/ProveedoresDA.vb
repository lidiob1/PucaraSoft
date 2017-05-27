Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports CapaNE

Public Class ProveedoresDA
    Inherits conexion 'Incluimos la clase conexion 
    Dim cmd As New SqlCommand 'Variable para enviar peticiones a la BD

    Public Function mostrar() As DataTable
        Try
            conectado()

            cmd = New SqlCommand("select CUIT,tipo_prov,razon_social 'Razon Social',Direccion,cod_postal 'Cod. Postal',Telefono,Celular,Mail,Fec_Ini 'Fecha Inicio Actividad',Fec_Alta 'Fecha de Alta',Habilitado from Proveedor order by cuit")
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

    Public Function insertar(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insert into Proveedor(tipo_prov,cuit ,razon_social,direccion,telefono,celular,mail,cod_postal,habilitado,fec_ini,fec_alta)values (@tipo_prov,@cuit ,@razon_social,@direccion,@telefono,@celular,@mail,@cod_postal,@habilitado,@fec_ini,@fec_alta)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@tipo_prov", dts.Tipo_prov)
            cmd.Parameters.AddWithValue("@cuit", dts.Cuit)
            cmd.Parameters.AddWithValue("@razon_social", dts.Razon_social)
            cmd.Parameters.AddWithValue("@direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@celular", dts.Celular)
            cmd.Parameters.AddWithValue("@mail", dts.Mail)
            cmd.Parameters.AddWithValue("@cod_postal", dts.Cod_postal)
            cmd.Parameters.AddWithValue("@habilitado", dts.habilitado)
            cmd.Parameters.AddWithValue("@fec_ini", dts.fecha_ini)
            cmd.Parameters.AddWithValue("@fec_alta", dts.fecha_alta)

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
            cmd = New SqlCommand("update Proveedor set tipo_prov=@tipo_prov,cuit=@cuit,razon_social=@razon_social,direccion=@direccion,telefono@telefono,celular@celular,mail=@mail,cod_postal=@cod_postal,fec_ini=@fec_ini where cuit=@cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@tipo_prov", dts.Tipo_prov)
            cmd.Parameters.AddWithValue("@cuit", dts.Cuit)
            cmd.Parameters.AddWithValue("@razon_social", dts.Razon_social)
            cmd.Parameters.AddWithValue("@direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@celular", dts.Celular)
            cmd.Parameters.AddWithValue("@mail", dts.Mail)
            cmd.Parameters.AddWithValue("@cod_postal", dts.Cod_postal)
            cmd.Parameters.AddWithValue("@fec_ini", dts.fecha_ini)

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

    Public Function buscar(ByVal texto As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select * from proveedor where cuit=@cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cuit", CChar(texto))
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

    Public Function Inhabilitar(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Update proveedor set Habilitado='0' where cuit=@cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@cuit", SqlDbType.NVarChar, 50).Value = dts.cuit
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


    Public Function Habilitar(ByVal dts As ProveedoresNE) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Update proveedor set Habilitado='1' where cuit=@cuit")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.Add("@cuit", SqlDbType.NVarChar, 50).Value = dts.cuit
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


