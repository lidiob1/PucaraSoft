Imports CapaNE
Imports CapaDA
Imports System.Text.RegularExpressions
Imports System.EventArgs

Public Class FrmProveedores

    Private dt As New DataTable
    Private Sub FrmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mostrar()

    End Sub

    Public Sub limpiar()

        btnGuardar.Visible = True
        btnEditar.Visible = False

        txtCuit.Text = ""
        txtRazonSocial.Text = ""
        txtDireccion.Text = ""
        txtcod_postal.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtcod_postal.Text = ""
        cbHabilitar.Text = ""
        cbInhabilitar.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New ProveedoresDA
            dt = func.mostrar 'dt llama al procedimiento mostrar
            dgvListado.Columns.Item("Inhabilitar").Visible = False
            dgvListado.Columns.Item("Habilitar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
                txtBuscar.Enabled = True
                dgvListado.ColumnHeadersVisible = True
                lkNoexiste.Visible = False

            Else

                dgvListado.DataSource = Nothing
                txtBuscar.Enabled = False
                dgvListado.ColumnHeadersVisible = False
                lkNoexiste.Visible = True


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        btnNuevo.Visible = True
        btnEditar.Visible = False

        buscar()
        limpiar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = txtBuscar.Text

            If dv.Count <> 0 Then
                lkNoexiste.Visible = False
                dgvListado.DataSource = dv
                'ocultar_columnas_cli()
            Else
                lkNoexiste.Visible = True
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgvListado.Columns(1).Visible = False

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuadar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.ValidateChildren = True And txtCuit.Text <> "" And txtRazonSocial.Text <> "" And txtcod_postal.Text <> "" And txtTelefono.Text <> "" And txtCelular.Text <> "" Then
            Try
                Dim dts As New ProveedoresNE
                Dim func As New ProveedoresDA



                dts.cuit = txtCuit.Text
                dts.razon_social = txtRazonSocial.Text
                dts.direccion = txtDireccion.Text
                dts.telefono = txtcod_postal.Text
                dts.celular = txtTelefono.Text
                dts.mail = txtCelular.Text
                dts.cod_postal = txtcod_postal.Text
                dts.habilitado = 0

                If func.insertar(dts) Then
                    MessageBox.Show("Proveedor cargado correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Proveedor no fue registrado, intente nuevamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellClick

        txtCuit.Text = dgvListado.SelectedCells.Item(2).Value
        CboTipoProv.SelectedItem = dgvListado.SelectedCells.Item(3).Value
        txtRazonSocial.Text = dgvListado.SelectedCells.Item(4).Value
        txtDireccion.Text = dgvListado.SelectedCells.Item(5).Value
        txtcod_postal.Text = dgvListado.SelectedCells.Item(6).Value
        txtTelefono.Text = dgvListado.SelectedCells.Item(7).Value
        txtCelular.Text = dgvListado.SelectedCells.Item(8).Value
        txtMail.Text = dgvListado.SelectedCells.Item(9).Value
        dtpFechaIni.Text = dgvListado.SelectedCells.Item(10).Value
        dtpFechaAlta.Text = dgvListado.SelectedCells.Item(11).Value

        If dgvListado.SelectedCells.Item(12).Value = 0 Then
            CboTipoProv.Enabled = False
            txtCuit.Enabled = False
            txtRazonSocial.Enabled = False
            txtDireccion.Enabled = False
            txtcod_postal.Enabled = False
            txtTelefono.Enabled = False
            txtCelular.Enabled = False
            txtMail.Enabled = False
            dtpFechaIni.Enabled = False
            dtpFechaAlta.Enabled = False

            BtnHabilitar.Visible = True
            BtnInhabilitar.Visible = False
        Else

            CboTipoProv.Enabled = True
            txtCuit.Enabled = True
            txtRazonSocial.Enabled = True
            txtDireccion.Enabled = True
            txtDireccion.Enabled = True
            txtTelefono.Enabled = True
            txtCelular.Enabled = True
            txtMail.Enabled = True
            dtpFechaIni.Enabled = True
            dtpFechaAlta.Enabled = False

            BtnHabilitar.Visible = False
            BtnInhabilitar.Visible = True
        End If


        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim result As DialogResult

        result = MessageBox.Show("Relmente desea editar los datos del Proveedor", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtCuit.Text <> "" And txtRazonSocial.Text <> "" And txtcod_postal.Text <> "" And txtTelefono.Text <> "" And txtCelular.Text <> "" Then
                Try
                    Dim dts As New ProveedoresNE
                    Dim func As New ProveedoresDA

                    dts._Cuit = txtCuit.Text
                    dts._Razon_social = txtRazonSocial.Text
                    dts._Direccion = txtDireccion.Text
                    dts._Telefono = txtcod_postal.Text
                    dts._Celular = txtTelefono.Text
                    dts._Mail = txtCelular.Text
                    dts._Cod_postal = txtcod_postal.Text



                    If func.editar(dts) Then
                        MessageBox.Show("Proveedor modificado correctamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Proveedor no fue modificado, intente nuevamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub


    Private Sub BtnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        mostrar()
    End Sub
    '************************************************BOTONES**********************************************

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If Me.ValidateChildren = True And txtCuit.Text <> "" And txtRazonSocial.Text <> "" And txtTelefono.Text <> "" And txtCelular.Text <> "" And txtMail.Text <> "" Then
            Try
                Dim dts As New ProveedoresNE
                Dim func As New ProveedoresDA

                dts.Tipo_prov = CboTipoProv.SelectedItem
                dts.cuit = txtCuit.Text
                dts.razon_social = txtRazonSocial.Text
                dts.direccion = txtDireccion.Text
                dts.cod_postal = txtcod_postal.Text
                dts.telefono = txtTelefono.Text
                dts.celular = txtCelular.Text
                dts.mail = txtMail.Text
                dts.fecha_ini = dtpFechaIni.Value
                dts.fecha_alta = dtpFechaAlta.Value
                dts.habilitado = 1 'predeterminado a habilitado al crearse 

                If func.insertar(dts) Then
                    MessageBox.Show("Proveedor cargado correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Proveedor no fue registrado, intente nuevamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub BtnEditar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Relmente desea editar los datos del cliente", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtCuit.Text <> "" And txtRazonSocial.Text <> "" And txtTelefono.Text <> "" And txtCelular.Text <> "" And txtMail.Text <> "" Then
                Try
                    Dim dts As New ProveedoresNE
                    Dim func As New ProveedoresDA

                    dts.Tipo_prov = CboTipoProv.SelectedItem
                    dts.cuit = txtCuit.Text
                    dts.razon_social = txtRazonSocial.Text
                    dts.direccion = txtDireccion.Text
                    dts.cod_postal = txtcod_postal.Text
                    dts.telefono = txtTelefono.Text
                    dts.celular = txtCelular.Text
                    dts.mail = txtMail.Text
                    dts.fecha_ini = dtpFechaIni.Value
                    dts.fecha_alta = dtpFechaAlta.Value



                    If func.editar(dts) Then
                        MessageBox.Show("Cliente modificado correctamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Cliente no fue modificado, intente nuevamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub BtnInhabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar.Click
        If cbInhabilitar.CheckState = CheckState.Checked Then
            dgvListado.Columns.Item("Inhabilitar").Visible = True
        Else
            dgvListado.Columns.Item("Inhabilitar").Visible = False
        End If
    End Sub

    Private Sub BtnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHabilitar.Click
        If cbHabilitar.CheckState = CheckState.Checked Then
            dgvListado.Columns.Item("Habilitar").Visible = True
        Else
            dgvListado.Columns.Item("Habilitar").Visible = False
        End If
    End Sub

    '********************************************VALIDACIONES*************************************
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                  "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub txtMail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMail.Leave
        If validar_Mail(LCase(txtMail.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & _
            " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMail.Focus()
            txtMail.SelectAll()
        End If
    End Sub

    '****************************************VALIDADORES SOLO NUMEROS**********************

    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtTelefono.Text & CChar(e.KeyChar))
    End Sub

    Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtTelefono.Text & CChar(e.KeyChar))
    End Sub

    Private Sub txtCuit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuit.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtTelefono.Text & CChar(e.KeyChar))
    End Sub
    
    '************************************VALIDAR SOLO LETRAS**************************
    Private Sub txtRazonSocial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCuit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuit.TextChanged

    End Sub

   
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        limpiar()
        mostrar()
    End Sub

    '************************************BUSCAR PROVEEDOR****************************

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = cmbTipo.Text & " Like '" & txtBuscar.Text & "%'"
            If dv.Count <> 0 Then
                lkNoexiste.Visible = False
                dgvListado.DataSource = dv
            Else
                lkNoexiste.Visible = True
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class