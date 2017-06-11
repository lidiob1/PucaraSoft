Imports System.Data.SqlClient
Imports CapaNE

Public Class HorarioDA
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
    ' Listado de horarios
    '--------------------------------------------------------------------------------
    Public Function mostrar_horario() As DataTable
        Try
            com = New SqlCommand("select horario_desde 'Horario desde', horario_hasta 'Horario hasta' from horarios")
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
