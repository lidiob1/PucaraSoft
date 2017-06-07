Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration
Public Class conexion
    Protected cnn As New SqlConnection
    Public id_usuario As Integer

    'Funcion para conectarme a la BD
    Protected Function conectado()

        Try
            'cnn = New SqlConnection("data source=DESKTOP-RA5UK2L\SQLSERVER;initial catalog= Pucara; integrated security = true")
            'con = New SqlConnection("Server=(local);Database=Proyecto;Trusted_Connection=True")
            ' conn = New SqlConnection("Data Source=LJBLANCO\SQLSERVER2008;Initial Catalog=LocalCuadros;Integrated Security=True")            'Lidio
            'conn = New SqlConnection("Data source=DESKTOP-RA5UK2L\SQLSERVER;initial catalog=LocalCuadros;integrated security=true")       'Cristian
            cnn = New SqlConnection("Data source=(local);initial catalog=Pucara;integrated security=true") 'Sancho
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    'Funcion para desconectarme de la BD
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    'Lidio
    Public Function abrir() As SqlConnection
        Dim con As String
        Dim scon As SqlConnection
        'con = "Data Source=LIDIO-PC;Initial Catalog=Pucara;Integrated Security=True"
        con = "Data source=(local);initial catalog=Pucara;integrated security=true"
        scon = New SqlConnection(con)
        scon.Open()
        Return scon
    End Function

End Class
