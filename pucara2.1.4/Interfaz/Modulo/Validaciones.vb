Module Validaciones

    '=======================================================================================================
    ' Validamos que se ingrese solamente numeros
    '=======================================================================================================
    Public Function validarSoloNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        If (Asc(e.KeyChar)) >= 65 And (Asc(e.KeyChar)) <= 90 Or (Asc(e.KeyChar)) >= 97 And (Asc(e.KeyChar)) <= 122 Then
            Return True
        Else
            Return False
        End If
    End Function

    '=======================================================================================================
    ' Validamos que se ingrese solamente letras
    '=======================================================================================================
    Public Function validarSoloTexto(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        If (Asc(e.KeyChar)) >= 0 And (Asc(e.KeyChar)) <= 7 Or (Asc(e.KeyChar)) >= 9 And (Asc(e.KeyChar)) <= 31 Or (Asc(e.KeyChar)) >= 33 And (Asc(e.KeyChar)) <= 64 Or (Asc(e.KeyChar)) >= 91 And (Asc(e.KeyChar)) <= 96 Or (Asc(e.KeyChar)) >= 123 And (Asc(e.KeyChar)) <= 126 Then
            Return True
        Else
            Return False
        End If
    End Function

    '=======================================================================================================
    ' Validamos fecha
    '=======================================================================================================
    Public Function validar_fecha(ByVal txt_fecha As String, ByVal campo As String) As String
        Try
            Dim fecha As Date = txt_fecha
            If IsDate(fecha) Then
                Dim fechaActual As Date = Date.Today
                Return String.Empty
            Else
                'fecha en mal formato
                Return campo & "no Valida" & vbCrLf
            End If
        Catch ex As Exception
            'fecha vacia
            Return "Debe completar correctamente el campo " & campo & vbCrLf
        End Try
    End Function

    '=======================================================================================================
    ' Validamos que un campo obligatorio no este vacio
    ' Ejemplo:
    ' Dim res As String 'para una validacion
    ' res = validar_un_campo("Nombre", txt_nombre.Text)
    '=======================================================================================================
    Public Function validar_un_campo(ByVal campo As String, ByVal dato As String) As String
        If dato = String.Empty Then
            Return "El campo " & campo & " no puede estar vacío" & vbCrLf
        End If
        Return String.Empty
    End Function

    '=======================================================================================================
    ' Validamos que un combobox se cargue con algun valor
    '=======================================================================================================
    Public Function validar_combo(ByRef combo As ComboBox, ByVal campo As String, ByVal genero As Integer) As String
        If combo.SelectedIndex = -1 Then
            If genero = 1 Then
                Return "Debe seleccionar un " & campo & vbCrLf
            Else
                Return "Debe seleccionar una " & campo & vbCrLf
            End If
        Else
            Return String.Empty
        End If
    End Function
End Module
