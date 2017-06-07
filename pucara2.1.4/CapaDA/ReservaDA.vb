Imports System.Data.SqlClient
Imports CapaNE

Public Class ReservaDA
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private con As New SqlConnection
    Private com As New SqlCommand

    '-------------------------------------------------
    'Constructor sin parametros
    '-------------------------------------------------
    Public Sub New()
        'Abrimos conexion
        Dim objcon As New Conexion
        con = objcon.abrir
        com.Connection = con
    End Sub

    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente desde su numero de documento
    '--------------------------------------------------------------------------------
    Public Function buscarCliente(ByVal dni As Long) As DataRow
        Dim dr As DataRow
        da = New SqlDataAdapter("select nombre,apellido from Cliente where nro_doc='" & dni & "'", con)
        ds = New DataSet
        Try
            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------
    ' Devuelve el ultimo numero de Reserva + 1
    '--------------------------------------------------------------------------------
    Public Function ultima_reserva() As DataRow
        Dim dr As DataRow
        da = New SqlDataAdapter("select MAX (nro_reserva) + 1 as Nro from Reserva", con)
        ds = New DataSet

        Try
            da.Fill(ds, "Nro")
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    '--------------------------------------------------------------------------------
    ' Cargar combo Estado Cancha
    '--------------------------------------------------------------------------------
    Public Function cargarEstado() As DataSet
        da = New SqlDataAdapter("Select id_estado_cancha, descripcion from Estado_Cancha order by descripcion asc", con)
        ds = New DataSet

        Try
            da.Fill(ds, "tabEstado")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    '--------------------------------------------------------------------------------
    ' Cargar combo Tipo Cancha
    '--------------------------------------------------------------------------------
    Public Function cargarTipoCancha() As DataSet
        da = New SqlDataAdapter("Select id_tipo_cancha, descripcion from Tipo_Cancha", con)
        ds = New DataSet

        Try
            da.Fill(ds, "tabTipoCancha")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    '--------------------------------------------------------------------------------
    ' Cargar combo Tipo Cancha
    '--------------------------------------------------------------------------------
    Public Function cargarTipoReserva() As DataSet
        da = New SqlDataAdapter("Select id_tipo_reserva, descripcion from Tipo_Reserva", con)
        ds = New DataSet

        Try
            da.Fill(ds, "tabTipoReserva")
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
