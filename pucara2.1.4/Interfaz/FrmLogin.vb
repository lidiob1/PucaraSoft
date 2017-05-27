Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA

Public Class FrmLogin

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Public Sub verificarAdminEmpleado()

        Dim dr As DataRow
        Dim objLoginNE As New LoginNE
        Dim objLoginDA As New LoginDA

        objLoginNE.nomusuario = txtUsuario.Text
        objLoginNE.passusuario = txtContraseña.Text
        dr = objLoginDA.verificarAdminEmpleado(objLoginNE)
        If dr Is Nothing Then
            If txtUsuario.Text.Length = 0 And txtContraseña.Text.Length = 0 Then
                MessageBox.Show("Todos los campos estan vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
            ElseIf txtUsuario.Text.Length = 0 Or txtContraseña.Text.Length = 0 Then
                MessageBox.Show("Debes completar todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
            Else
                MessageBox.Show("Error verifique su Username y Password", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
            End If
        Else
            'Obtenemos campo categoria
            objLoginNE._categoria = CStr(dr("categoria"))
            'Verificamos si es un usuario Administrador
            If objLoginNE._categoria = "Administrador" Then
                'Si es un administrador dejamos visible el menu Administracion
                ''FrmMenu.menuRegistrarProducto.Enabled = True
                ''FrmMenu.menuCrearUsuario.Enabled = True
                ''FrmMenu.menuCopiaSeguridad.Enabled = True
                ''FrmMenu.menuListadoUsuarios.Enabled = True
            Else
                'Si no es administrador desactivamos el menu Administracion
                ''FrmMenu.menuRegistrarProducto.Enabled = False
                ''FrmMenu.menuCrearUsuario.Enabled = False
                ''FrmMenu.menuCopiaSeguridad.Enabled = False
                ''FrmMenu.menuListadoUsuarios.Enabled = False

            End If

            Me.Hide()
            ' ''FrmMenu.Show()
            FrmSplash.Show()
        End If
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        verificarAdminEmpleado()
    End Sub
End Class