Imports CapaNE
Imports CapaDA
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class frmCliente

    Private dt As New DataTable

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtNroDoc.Text = ""
        cbTipoDoc.SelectedIndex = -1
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCalle.Text = ""
        MtxtTel.Text = ""
        MtxtCelular.Text = ""
        txtMail.Text = ""
        DTPFecNac.Text = ""
        DTPFecAlta.Text = ""

        DTPFecAlta.Enabled = True

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New ClientesDA
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

        buscar_cli()
        AlineadoDerecha()
        limpiar()
        LimpiarCheckBox_cli()

    End Sub

    Public Sub LimpiarCheckBox_cli()
        CbHabilitar_cli.Checked = False
        CbInhabilitar_cli.Checked = False
    End Sub

    Private Sub buscar_cli()
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


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If DTPFecAlta.Value.Date <= DTPFecNac.Value.Date Then
            MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha de alta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Me.ValidateChildren = True And txtNroDoc.Text <> "" And txtNombre.Text <> "" And txtApellido.Text <> "" And MtxtTel.Text <> "" And MtxtCelular.Text <> "" And txtMail.Text <> "" Then
            Try
                Dim dts As New ClientesNE
                Dim func As New ClientesDA

                dts.Nro_Doc = txtNroDoc.Text
                dts.Tipo_dni = cbTipoDoc.SelectedItem
                dts.nombre = txtNombre.Text
                dts.apellido = txtApellido.Text
                dts.Calle = txtCalle.Text
                dts.telefono = MtxtTel.Text
                dts.celular = MtxtCelular.Text
                dts.mail = txtMail.Text
                dts.fecha_nac = DTPFecNac.Value
                dts.fecha_alta = DTPFecAlta.Value
                dts.habilitado = 1 'predeterminado a habilitado al crearse 

                If func.insertar(dts) Then
                    MessageBox.Show("Cliente cargado correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no fue registrado, intente nuevamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtNroDoc.Text = dgvListado.SelectedCells.Item(2).Value
        cbTipoDoc.SelectedItem = dgvListado.SelectedCells.Item(3).Value
        txtNombre.Text = dgvListado.SelectedCells.Item(4).Value
        txtApellido.Text = dgvListado.SelectedCells.Item(5).Value
        DTPFecNac.Text = dgvListado.SelectedCells.Item(6).Value
        txtCalle.Text = dgvListado.SelectedCells.Item(7).Value
        MtxtTel.Text = dgvListado.SelectedCells.Item(8).Value
        MtxtCelular.Text = dgvListado.SelectedCells.Item(9).Value
        txtMail.Text = dgvListado.SelectedCells.Item(10).Value
        DTPFecAlta.Text = dgvListado.SelectedCells.Item(11).Value
        TxtNumero.Text = dgvListado.SelectedCells.Item(12).Value
        TxtEdificio.Text = dgvListado.SelectedCells.Item(13).Value
        txtPiso.Text = dgvListado.SelectedCells.Item(14).Value
        TxtDpto.Text = dgvListado.SelectedCells.Item(15).Value
        TxtCP.Text = dgvListado.SelectedCells.Item(16).Value
        TxtBarrio.Text = dgvListado.SelectedCells.Item(17).Value
        TxtPais.Text = dgvListado.SelectedCells.Item(18).Value
        TxtProvincia.Text = dgvListado.SelectedCells.Item(19).Value
        TxtCiudad.Text = dgvListado.SelectedCells.Item(20).Value

        If dgvListado.SelectedCells.Item(21).Value = 0 Then
            txtNroDoc.Enabled = False
            cbTipoDoc.Enabled = False
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            DTPFecNac.Enabled = False
            txtCalle.Enabled = False
            MtxtTel.Enabled = False
            MtxtCelular.Enabled = False
            txtMail.Enabled = False
            DTPFecAlta.Enabled = False
            TxtNumero.Enabled = False
            TxtEdificio.Enabled = False
            txtPiso.Enabled = False
            TxtDpto.Enabled = False
            TxtCP.Enabled = False
            TxtBarrio.Enabled = False
            TxtPais.Enabled = False
            TxtProvincia.Enabled = False
            TxtCiudad.Enabled = False

            BtnHabilitar_cli.Visible = True
            BtnInhabilitar_cli.Visible = False
        Else
            txtNroDoc.Enabled = True
            cbTipoDoc.Enabled = True
            txtNombre.Enabled = True
            txtApellido.Enabled = True
            txtCalle.Enabled = True
            MtxtTel.Enabled = True
            MtxtCelular.Enabled = True
            txtMail.Enabled = True
            DTPFecNac.Enabled = True
            DTPFecAlta.Enabled = True
            TxtNumero.Enabled = True
            TxtEdificio.Enabled = True
            txtPiso.Enabled = True
            TxtDpto.Enabled = True
            TxtCP.Enabled = True
            TxtBarrio.Enabled = True
            TxtPais.Enabled = True
            TxtProvincia.Enabled = True
            TxtCiudad.Enabled = True

            BtnHabilitar_cli.Visible = False
            BtnInhabilitar_cli.Visible = True
        End If

        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Relmente desea editar los datos del cliente", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If DTPFecAlta.Value.Date <= DTPFecNac.Value.Date Then
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha de alta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And MtxtTel.Text <> "" And MtxtCelular.Text <> "" And txtMail.Text <> "" Then
                Try
                    Dim dts As New ClientesNE
                    Dim func As New ClientesDA

                    dts.Nro_Doc = txtNroDoc.Text
                    dts.nombre = txtNombre.Text
                    dts.apellido = txtApellido.Text
                    dts.fecha_nac = DTPFecNac.Value
                    dts.Calle = txtCalle.Text
                    dts.telefono = MtxtTel.Text
                    dts.celular = MtxtCelular.Text
                    dts.mail = txtMail.Text
                    dts.NumCalle = TxtNumero.Text
                    dts.Edificio = TxtEdificio.Text
                    dts.Piso = txtPiso.Text
                    dts.Dpto = TxtDpto.Text
                    dts.CP = TxtCP.Text
                    dts.Barrio = TxtBarrio.Text
                    dts.Pais = TxtPais.Text
                    dts.Provincia = TxtProvincia.Text
                    dts.Ciudad = TxtCiudad.Text


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

    Private Sub dgvListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        If e.ColumnIndex = Me.dgvListado.Columns.Item("Inhabilitar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgvListado.Rows(e.RowIndex).Cells("Inhabilitar")
            chkCell.Value = Not chkCell.Value
        End If
        If e.ColumnIndex = Me.dgvListado.Columns.Item("Habilitar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgvListado.Rows(e.RowIndex).Cells("Habilitar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub CbInhabilitar_cli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbInhabilitar_cli.CheckedChanged
        If CbInhabilitar_cli.CheckState = CheckState.Checked Then
            dgvListado.Columns.Item("Inhabilitar").Visible = True
        Else
            dgvListado.Columns.Item("Inhabilitar").Visible = False
        End If
    End Sub


    Private Sub CbHabilitar_cli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbHabilitar_cli.CheckedChanged
        If CbHabilitar_cli.CheckState = CheckState.Checked Then
            dgvListado.Columns.Item("Habilitar").Visible = True
        Else
            dgvListado.Columns.Item("Habilitar").Visible = False
        End If
    End Sub

    '**************************ALINEADO A LA DERECHA********************************************
    Public Sub AlineadoDerecha()
        'Me.DataListado_cli.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    '***********************VALIDACION DE MAIL**************************************************
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
    '******************************************VALIDAR NOMBRE SOLO LETRAS***********************************
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
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
    '*************************************VALIDAR TELEFONO, CELULAR, DNI (SOLO NUMEROS)******************************
    Private Sub MtxtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MtxtTel.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, MtxtTel.Text & CChar(e.KeyChar))
    End Sub

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

    Private Sub MtxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MtxtCelular.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, MtxtCelular.Text & CChar(e.KeyChar))
    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtNroDoc.Text & CChar(e.KeyChar))
    End Sub

    '*******************************BUSCAR CLIENTES****************************

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = CboCampo.Text & " Like '" & txtBuscar.Text & "%'"
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

    '********************************************BUSCAR CLIENTE *************************************
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        buscarCliente()
    End Sub

    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente desde su numero de documento
    '--------------------------------------------------------------------------------
    Private Sub buscarCliente()
        Dim objCliente As New ClientesNE
        'Dim objPresupuestoDA As New ClientesDA
        Dim objClienteDA As New ClientesDA
        Dim dr As DataRow

        Try
            objCliente.Nro_Doc = txtNroDoc.Text
            dr = objClienteDA.buscarCliente(objCliente.Nro_Doc)

            txtNombre.Text = CStr(dr("Nombre"))
            txtApellido.Text = CStr(dr("Apellido"))
            cbTipoDoc.Text = CStr(dr("Id_Tipo_Dni"))
            txtCalle.Text = CStr(dr("Calle"))
            TxtNumero.Text = CStr(dr("Calle"))
            TxtEdificio.Text = CStr(dr("Edificio"))
            txtPiso.Text = CStr(dr("Piso"))
            TxtDpto.Text = CStr(dr("Dpto"))
            TxtCP.Text = CStr(dr("CP"))
            TxtBarrio.Text = CStr(dr("Barrio"))
            TxtPais.Text = CStr(dr("Pais"))
            TxtProvincia.Text = CStr(dr("Provincia"))
            TxtCiudad.Text = CStr(dr("Ciudad"))
            MtxtTel.Text = CStr(dr("Telefono"))
            MtxtCelular.Text = CStr(dr("Celular"))
            txtMail.Text = CStr(dr("Mail"))
            DTPFecAlta.Text = CStr(dr("Fecha_Alta"))
            DTPFecNac.Text = CStr(dr("Fecha_Nac"))

        Catch ex As Exception
            MessageBox.Show("No existe el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnInhabilitar_cli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar_cli.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea inhabilitar el/los Cliente seleccionados?", "Inhabilitando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Inhabilitar").Value)

                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("Nro_DNI").Value)
                        Dim cdb As New ClientesNE
                        Dim func As New ClientesDA
                        cdb._Nro_Doc = oneKey

                        If func.Inhabilitar_cli(cdb) Then
                        Else
                            MessageBox.Show("Cliente Inhabilitado!", "Inhabilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Cancelando Inhabilitacion de registros!", "Inhabilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()

    End Sub

    Private Sub BtnHabilitar_cli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHabilitar_cli.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea Habilitar el/los Clientes seleccionados?", "Habilitando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Habilitar").Value)

                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("Nro_DNI").Value)
                        Dim vdb As New ClientesNE
                        Dim func As New ClientesDA
                        vdb._Nro_Doc = oneKey

                        If func.Habilitar_cli(vdb) Then
                        Else
                            MessageBox.Show("Cliente Habilitado!", "Habilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Cancelando Habilitacion de registros!", "Habilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub
    '**********************************************CHEKED PERSONAS***************************************

    Private Sub CHkFisica_CheckedChanged(sender As Object, e As EventArgs) Handles CHkFisica.CheckedChanged

        CHkJuridica.Checked = False

        txtNroDoc.Enabled = True
        cbTipoDoc.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtCalle.Enabled = True
        TxtNumero.Enabled = True
        TxtEdificio.Enabled = True
        txtPiso.Enabled = True
        TxtDpto.Enabled = True
        TxtCP.Enabled = True
        TxtBarrio.Enabled = True
        TxtPais.Enabled = True
        TxtProvincia.Enabled = True
        TxtCiudad.Enabled = True
        MtxtTel.Enabled = True
        MtxtCelular.Enabled = True
        txtMail.Enabled = True
        DTPFecAlta.Enabled = True
        DTPFecNac.Enabled = True

        MtxtCuit.Enabled = False
        TxtRazSocial.Enabled = False
        TxtFantasia.Enabled = False
        TxtCalle2.Enabled = False
        TxtNumero2.Enabled = False
        TxtEdificio2.Enabled = False
        TxtPiso2.Enabled = False
        TxtDPto2.Enabled = False
        TxtCP2.Enabled = False
        TxtBarrio2.Enabled = False
        TxtPais2.Enabled = False
        TxtProvincia2.Enabled = False
        TxtCiudad2.Enabled = False
        MtxtTel2.Enabled = False
        MtxtCelular2.Enabled = False
        TxtMail2.Enabled = False
        DTPFecAlta2.Enabled = False
        DTPFecNac2.Enabled = False
    End Sub

    Private Sub CHkJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles CHkJuridica.CheckedChanged

        CHkFisica.Checked = False

        txtNroDoc.Enabled = False
        cbTipoDoc.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtCalle.Enabled = False
        TxtNumero.Enabled = False
        TxtEdificio.Enabled = False
        txtPiso.Enabled = False
        TxtDpto.Enabled = False
        TxtCP.Enabled = False
        TxtBarrio.Enabled = False
        TxtPais.Enabled = False
        TxtProvincia.Enabled = False
        TxtCiudad.Enabled = False
        MtxtTel.Enabled = False
        MtxtCelular.Enabled = False
        txtMail.Enabled = False
        DTPFecAlta.Enabled = False
        DTPFecNac.Enabled = False

        MtxtCuit.Enabled = True
        TxtRazSocial.Enabled = True
        TxtFantasia.Enabled = True
        TxtCalle2.Enabled = True
        TxtNumero2.Enabled = True
        TxtEdificio2.Enabled = True
        TxtPiso2.Enabled = True
        TxtDPto2.Enabled = True
        TxtCP2.Enabled = True
        TxtBarrio2.Enabled = True
        TxtPais2.Enabled = True
        TxtProvincia2.Enabled = True
        TxtCiudad2.Enabled = True
        MtxtTel2.Enabled = True
        MtxtCelular2.Enabled = True
        TxtMail2.Enabled = True
        DTPFecAlta2.Enabled = True
        DTPFecNac2.Enabled = True

    End Sub
    
End Class