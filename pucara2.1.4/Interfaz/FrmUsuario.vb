Imports CapaNE
Imports CapaDA
Public Class FrmUsuario

    Private dt As New DataTable

    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtContrasena.Text <> "" And cmbCategoria.SelectedItem <> "" Then

            Try
                Dim dts As New UsuariosNE
                Dim func As New UsuariosDA

                dts.Id_usuario = txtIdusuario.Text
                dts.Nom_usuario = txtNombre.Text
                dts.Password = txtContrasena.Text
                dts.Categoria = cmbCategoria.SelectedItem
                dts.Habilitado = 1

                If func.insertar(dts) Then
                    MessageBox.Show("Usuario cargado correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Usuario no fue registrado, intente nuevamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub


    Public Sub limpiar()

        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtNombre.Text = ""
        txtContrasena.Text = ""
        txtIdusuario.Text = ""


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New UsuariosDA
            dt = func.mostrar 'dt llama al procedimiento mostrar
            dgvUsuarios.Columns.Item("Eliminar").Visible = False 'desabilito la columna listado, la ocultamos

            If dt.Rows.Count <> 0 Then
                dgvUsuarios.DataSource = dt
                txtBuscar.Enabled = True
                dgvUsuarios.ColumnHeadersVisible = True
                lkInexistente.Visible = False

            Else

                dgvUsuarios.DataSource = Nothing
                txtBuscar.Enabled = False
                dgvUsuarios.ColumnHeadersVisible = False
                lkInexistente.Visible = True


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        btnNuevo.Visible = True
        btnEditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet 'variable dataset copia el datatable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cmbTipo.Text & txtBuscar.Text



            If dv.Count <> 0 Then
                lkInexistente.Visible = False
                dgvUsuarios.DataSource = dv
                ocultar_columnas()

            Else

                lkInexistente.Visible = True
                dgvUsuarios.DataSource = Nothing

            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgvUsuarios.Columns(1).Visible = False

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del Usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtContrasena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.TextChanged

    End Sub

    Private Sub txtContrasena_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese una contrasena, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtIdusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdusuario.TextChanged

    End Sub

    Private Sub txtIdusuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el Id del Usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        mostrar()
        limpiar()

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Dim result As DialogResult

        result = MessageBox.Show("Relmente desea editar los datos del usuario", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtContrasena.Text <> "" And cmbCategoria.Text <> "" And txtIdusuario.Text <> "" Then

                Try
                    Dim dts As New UsuariosNE
                    Dim func As New UsuariosDA

                    dts.Id_usuario = txtIdusuario.Text
                    dts.Nom_usuario = txtNombre.Text
                    dts.Password = txtContrasena.Text
                    dts.Categoria = cmbCategoria.Text
                    dts._habilitado = 0

                    If func.editar(dts) Then
                        MessageBox.Show("Usuario modificado correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Usuario no fue modificado, intente nuevamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos!", "Modifiando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub dgvUsuarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick

        txtNombre.Text = dgvUsuarios.SelectedCells.Item(1).Value
        txtContrasena.Text = dgvUsuarios.SelectedCells.Item(2).Value
        cmbCategoria.Text = dgvUsuarios.SelectedCells.Item(3).Value
        txtIdusuario.Text = dgvUsuarios.SelectedCells.Item(4).Value


        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub


    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            dgvUsuarios.Columns.Item("Eliminar").Visible = True
        Else
            dgvUsuarios.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgvUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        If e.ColumnIndex = Me.dgvUsuarios.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dgvUsuarios.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los usuarios seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvUsuarios.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_usuario").Value)
                        Dim vdb As New UsuariosNE
                        Dim func As New UsuariosDA
                        vdb.Id_usuario = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Usuario no fue eliminado", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        End If
                    End If
                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registros", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If
        Call limpiar()
    End Sub
End Class