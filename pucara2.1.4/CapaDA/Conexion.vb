Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration
Public Class conexion
    Protected cnn As New SqlConnection
    Public id_usuario As Integer

    'Funcion para conectarme a la BD
    Protected Function conectado()

        Try
            cnn = New SqlConnection("Data Source=LIDIO-PC\SQLEXPRESS;Initial Catalog=Pucara;Integrated Security=True")            'Lidio
            'cnn = New SqlConnection("Data Source=NI528176\SQLEXPRESS;Initial Catalog=Pucara;Integrated Security=True")                               'Lidio
            'cnn = New SqlConnection("Data source=(local);initial catalog=Pucara;integrated security=true")                       'Sancho
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
        con = "Data Source=LIDIO-PC\SQLEXPRESS;Initial Catalog=Pucara;Integrated Security=True"     'Lidio
        'con = "Data Source=NI528176\SQLEXPRESS;Initial Catalog=Pucara;Integrated Security=True"     'Lidio
        'con = "Data source=(local);initial catalog=Pucara;integrated security=true"                'Sancho
        scon = New SqlConnection(con)
        scon.Open()
        Return scon
    End Function

End Class
