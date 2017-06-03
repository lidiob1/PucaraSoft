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
End Module
