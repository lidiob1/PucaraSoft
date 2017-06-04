Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CapaNE


Public Class LoginDA
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
    ' Nos servira para verificar si el que ingresa al sistema es un Administrador o 
    ' empleado normal (para el tema de permisos)
    '--------------------------------------------------------------------------------
    Public Function verificarAdminEmpleado(ByVal usuario As LoginNE) As DataRow
        Dim dr As DataRow
        da = New SqlDataAdapter("select * from login where usuario='" & usuario.nomusuario & "'and contraseña='" & usuario.passusuario & "'", con)
        ds = New DataSet
        Try
            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            Return dr
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return Nothing
        End Try
    End Function
End Class
