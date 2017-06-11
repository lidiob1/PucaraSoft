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
            Return Nothing
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

    '--------------------------------------------------------------------------------
    ' Cargar combo Tipo Cancha
    '--------------------------------------------------------------------------------
    Public Function buscarReservas(ByVal id_tipo_cancha As Integer, ByVal fecha_desde As Date, ByVal fechas_hasta As Date) As DataTable
        Try
            com = New SqlCommand("select r.fecha_reserva 'Fecha de reserva', r.hora_inicio 'Hora de inicio', r.hora_fin 'Hora de fin', r.nro_doc_cliente 'Nro. doc.', c.nombre 'Nombre', c.apellido 'Apellido', tr.descripcion 'Tipo de reserva', tc.descripcion 'Tipo de cancha'" & _
                                 " from Reserva r, Cliente c, Tipo_Reserva tr, TipoCancha tc " & _
                                 "where c.nro_doc = r.nro_doc_cliente and " & _
                                 "r.tipo_reserva = tr.id_tipo_reserva and " & _
                                 "r.id_tipo_cancha = tc.id_tipo_cancha and " & _
                                 "r.id_tipo_cancha ='" & id_tipo_cancha & "'" & _
            " and r.fecha_reserva BETWEEN '" & fecha_desde & "' and '" & fechas_hasta & "' order by r.fecha_reserva asc")
            com.CommandType = CommandType.Text
            com.Connection = con

            If com.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(com)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    '--------------------------------------------------------------------------------
    ' Cargar reservas interfaz DISPONIBILIDAD
    '--------------------------------------------------------------------------------
    Public Function buscarDisponibilidad(ByVal fechaReserva As Date, ByVal id_tipo_cancha As Integer, ByVal nro_cancha As Integer)
        Try
            com = New SqlCommand("select r.nro_doc_cliente, c.nombre, c.apellido, r.hora_inicio, r.hora_fin" & _
                                 " from Reserva r, Cliente c " & _
                                 "where r.nro_doc_cliente = c.nro_doc") ' & _
            '"r.fecha_reserva ='" & fechaReserva & "'" & _
            '" and r.id_tipo_cancha ='" & id_tipo_cancha & "'" & _
            '" and r.id_cancha ='" & nro_cancha & "' order by r.hora_inicio asc")

            com.CommandType = CommandType.Text
            com.Connection = con

            If com.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(com)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function


End Class
