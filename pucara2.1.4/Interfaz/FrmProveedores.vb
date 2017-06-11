Imports CapaNE
Imports CapaDA
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class FrmProveedores

    Private dt As New DataTable

    Private Sub frmproveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    '************************METODO LIMPIAR**********************
    Public Sub limpiar()
        CHkJuridica.Checked = True
        CHkFisica.Checked = False
        btnGuardar.Visible = True
        btnEditar.Visible = False

        txtNroDoc.Text = ""
        cbTipoDoc.Text = "Seleccione una opcion..."
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCalle.Text = ""
        MtxtTel.Text = ""
        MtxtCelular.Text = ""
        txtMail.Text = ""
        DTPFecini.Text = ""
        DTPFecAlta.Text = ""
        TxtNumero.Text = ""
        TxtEdificio.Text = ""
        txtPiso.Text = ""
        TxtDpto.Text = ""
        TxtCP.Text = ""
        TxtBarrio.Text = ""
        CbPais.Text = "Seleccione una opcion..."
        TxtProvincia.Text = ""
        TxtCiudad.Text = ""
        DTPFecAlta.Text = ""

        MtxtCuit.Text = ""
        TxtRazSocial.Text = ""
        TxtFantasia.Text = ""
        TxtCalle2.Text = ""
        TxtNumero2.Text = ""
        TxtEdificio2.Text = ""
        TxtPiso2.Text = ""
        TxtDPto2.Text = ""
        TxtCP2.Text = ""
        TxtBarrio2.Text = ""
        CbPais2.Text = "Seleccione una opcion..."
        TxtProvincia2.Text = ""
        TxtCiudad2.Text = ""
        MtxtTel2.Text = ""
        MtxtCelular2.Text = ""
        TxtMail2.Text = ""
        DTPFecAlta2.Text = ""
        DTPFecini2.Text = ""

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
        CbPais.Enabled = False
        TxtProvincia.Enabled = False
        TxtCiudad.Enabled = False
        MtxtTel.Enabled = False
        MtxtCelular.Enabled = False
        txtMail.Enabled = False
        DTPFecAlta.Enabled = False
        DTPFecini.Enabled = False

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
        CbPais2.Enabled = True
        TxtProvincia2.Enabled = True
        TxtCiudad2.Enabled = True
        MtxtTel2.Enabled = True
        MtxtCelular2.Enabled = True
        TxtMail2.Enabled = True
        DTPFecAlta2.Enabled = True
        DTPFecini2.Enabled = True

        MtxtCuit.Focus()

    End Sub
    '************************METODO MOSTRAR****************
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

        buscar_prov()
        AlineadoDerecha()
        'limpiar()
        LimpiarCheckBox_prov()
        Diferenciar_prov()

    End Sub
    '**************LIMPIAR CHKBOX HAB-INH***************
    Public Sub LimpiarCheckBox_prov()
        CbHabilitar_prov.Checked = False
        CbInhabilitar_prov.Checked = False
    End Sub
    '********************************BUSCAR CLIENTE (SIN FUNCIONAR)*******************
    Private Sub buscar_prov()
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
    '**********************************OCULTAR COLUMNAS*************************
    Private Sub ocultar_columnas()
        dgvListado.Columns(1).Visible = False

    End Sub
    '**************************BOTON CANCELAR************************
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Relmente desea cancelar la carga de registros", "Cancelando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Me.Close()
        Else
            mostrar()
        End If
    End Sub
    '*************************BOTON NUEVO****************************
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub
    '******************************** BOTON GUARDAR *************************************
    Public Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        'If DTPFecAlta.Value.Date <= DTPFecNac.Value.Date Then
        'MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha de alta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Return
        'End If

        If Me.ValidateChildren = True Then
            Try
                Dim dts As New ProveedoresNE
                Dim func As New ProveedoresDA

                If CHkJuridica.Checked = True Then

                    dts.Tipo_prov = 1
                    dts.Cuit = MtxtCuit.Text
                    dts.RazonSocial = TxtRazSocial.Text
                    dts.Fantasia = TxtFantasia.Text
                    dts.fecha_ini = DTPFecini2.Value
                    dts.fecha_alta = DTPFecAlta2.Value
                    dts.Calle = TxtCalle2.Text
                    dts.telefono = MtxtTel2.Text
                    dts.celular = MtxtCelular2.Text
                    dts.mail = TxtMail2.Text
                    dts.NumCalle = TxtNumero2.Text
                    dts.Edificio = TxtEdificio2.Text
                    dts.Piso = TxtPiso2.Text
                    dts.Dpto = TxtDPto2.Text
                    dts.CP = TxtCP2.Text
                    dts.Barrio = TxtBarrio2.Text
                    dts.Pais = CbPais2.Text
                    dts.Provincia = TxtProvincia2.Text
                    dts.Ciudad = TxtCiudad2.Text
                    dts.habilitado = 1 'predeterminado a habilitado al crearse 
                    dts.Tipo_dni = "-"
                    dts.nombre = "-"
                    dts.apellido = "-"



                ElseIf CHkFisica.Checked = True Then

                    dts.RazonSocial = "-"
                    dts.Fantasia = "-"
                    dts.Tipo_prov = 2
                    dts.Cuit = txtNroDoc.Text
                    dts.Tipo_dni = cbTipoDoc.Text
                    dts.nombre = txtNombre.Text
                    dts.apellido = txtApellido.Text
                    dts.fecha_ini = DTPFecini.Value
                    dts.fecha_alta = DTPFecAlta.Value
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
                    dts.Pais = CbPais.Text
                    dts.Provincia = TxtProvincia.Text
                    dts.Ciudad = TxtCiudad.Text
                    dts.habilitado = 1 'predeterminado a habilitado al crearse 

                End If


                If CHkJuridica.Checked = True Then
                    func.insertarJuridica(dts)
                    MessageBox.Show("Proveedor cargado correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                ElseIf CHkFisica.Checked = True Then
                    func.insertar(dts)
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
    '***************************************CONF DE GRILLA*******************************
    Private Sub dgvListado_Leave(sender As Object, e As EventArgs) Handles dgvListado.Leave
        Diferenciar_Prov()
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
    Private Sub dgvListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellClick

        Diferenciar_Prov()

        If dgvListado.SelectedCells.Item(24).Value = 1 Then

            LimpInhFisica()

            MtxtCuit.Text = dgvListado.SelectedCells.Item(2).Value
            'cbTipoDoc.SelectedItem = dgvListado.SelectedCells.Item(3).Value
            'txtNombre.Text = dgvListado.SelectedCells.Item(4).Value
            'txtApellido.Text = dgvListado.SelectedCells.Item(5).Value
            TxtRazSocial.Text = dgvListado.SelectedCells.Item(4).Value
            TxtFantasia.Text = dgvListado.SelectedCells.Item(5).Value
            DTPFecini2.Text = dgvListado.SelectedCells.Item(8).Value
            TxtCalle2.Text = dgvListado.SelectedCells.Item(9).Value
            MtxtTel2.Text = dgvListado.SelectedCells.Item(10).Value
            MtxtCelular2.Text = dgvListado.SelectedCells.Item(11).Value
            TxtMail2.Text = dgvListado.SelectedCells.Item(12).Value
            DTPFecAlta2.Text = dgvListado.SelectedCells.Item(13).Value
            TxtNumero2.Text = dgvListado.SelectedCells.Item(14).Value
            TxtEdificio2.Text = dgvListado.SelectedCells.Item(15).Value
            TxtPiso2.Text = dgvListado.SelectedCells.Item(16).Value
            TxtDPto2.Text = dgvListado.SelectedCells.Item(17).Value
            TxtCP2.Text = dgvListado.SelectedCells.Item(18).Value
            TxtBarrio2.Text = dgvListado.SelectedCells.Item(19).Value
            CbPais2.Text = dgvListado.SelectedCells.Item(20).Value
            TxtProvincia2.Text = dgvListado.SelectedCells.Item(21).Value
            TxtCiudad2.Text = dgvListado.SelectedCells.Item(22).Value

        ElseIf dgvListado.SelectedCells.Item(24).Value = 2 Then

            LimpInhJuridica()


            txtNroDoc.Text = dgvListado.SelectedCells.Item(2).Value
            cbTipoDoc.Text = dgvListado.SelectedCells.Item(3).Value
            txtNombre.Text = dgvListado.SelectedCells.Item(6).Value
            txtApellido.Text = dgvListado.SelectedCells.Item(7).Value
            DTPFecini.Text = dgvListado.SelectedCells.Item(8).Value
            txtCalle.Text = dgvListado.SelectedCells.Item(9).Value
            MtxtTel.Text = dgvListado.SelectedCells.Item(10).Value
            MtxtCelular.Text = dgvListado.SelectedCells.Item(11).Value
            txtMail.Text = dgvListado.SelectedCells.Item(12).Value
            DTPFecAlta.Text = dgvListado.SelectedCells.Item(13).Value
            TxtNumero.Text = dgvListado.SelectedCells.Item(14).Value
            TxtEdificio.Text = dgvListado.SelectedCells.Item(15).Value
            txtPiso.Text = dgvListado.SelectedCells.Item(16).Value
            TxtDpto.Text = dgvListado.SelectedCells.Item(17).Value
            TxtCP.Text = dgvListado.SelectedCells.Item(18).Value
            TxtBarrio.Text = dgvListado.SelectedCells.Item(19).Value
            CbPais.Text = dgvListado.SelectedCells.Item(20).Value
            TxtProvincia.Text = dgvListado.SelectedCells.Item(21).Value
            TxtCiudad.Text = dgvListado.SelectedCells.Item(22).Value

        End If


        If dgvListado.SelectedCells.Item(23).Value = 0 Then

            txtNroDoc.Enabled = False
            cbTipoDoc.Enabled = False
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            DTPFecini.Enabled = False
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
            CbPais.Enabled = False
            TxtProvincia.Enabled = False
            TxtCiudad.Enabled = False

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
            CbPais2.Enabled = False
            TxtProvincia2.Enabled = False
            TxtCiudad2.Enabled = False
            MtxtTel2.Enabled = False
            MtxtCelular2.Enabled = False
            TxtMail2.Enabled = False
            DTPFecAlta2.Enabled = False
            DTPFecini2.Enabled = False

            BtnHabilitar_Prov.Visible = True
            BtnInhabilitar_Prov.Visible = False
        ElseIf dgvListado.SelectedCells.Item(23).Value = 1 And dgvListado.SelectedCells.Item(24).Value = 1 Then

            txtNroDoc.Enabled = False
            cbTipoDoc.Enabled = False
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtCalle.Enabled = False
            MtxtTel.Enabled = False
            MtxtCelular.Enabled = False
            txtMail.Enabled = False
            DTPFecini.Enabled = False
            DTPFecAlta.Enabled = False
            TxtNumero.Enabled = False
            TxtEdificio.Enabled = False
            txtPiso.Enabled = False
            TxtDpto.Enabled = False
            TxtCP.Enabled = False
            TxtBarrio.Enabled = False
            CbPais.Enabled = False
            TxtProvincia.Enabled = False
            TxtCiudad.Enabled = False

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
            CbPais2.Enabled = True
            TxtProvincia2.Enabled = True
            TxtCiudad2.Enabled = True
            MtxtTel2.Enabled = True
            MtxtCelular2.Enabled = True
            TxtMail2.Enabled = True
            DTPFecAlta2.Enabled = True
            DTPFecini2.Enabled = True

            BtnHabilitar_Prov.Visible = False
            BtnInhabilitar_Prov.Visible = True
        Else
            txtNroDoc.Enabled = True
            cbTipoDoc.Enabled = True
            txtNombre.Enabled = True
            txtApellido.Enabled = True
            txtCalle.Enabled = True
            MtxtTel.Enabled = True
            MtxtCelular.Enabled = True
            txtMail.Enabled = True
            DTPFecini.Enabled = True
            DTPFecAlta.Enabled = True
            TxtNumero.Enabled = True
            TxtEdificio.Enabled = True
            txtPiso.Enabled = True
            TxtDpto.Enabled = True
            TxtCP.Enabled = True
            TxtBarrio.Enabled = True
            CbPais.Enabled = True
            TxtProvincia.Enabled = True
            TxtCiudad.Enabled = True

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
            CbPais2.Enabled = False
            TxtProvincia2.Enabled = False
            TxtCiudad2.Enabled = False
            MtxtTel2.Enabled = False
            MtxtCelular2.Enabled = False
            TxtMail2.Enabled = False
            DTPFecAlta2.Enabled = False
            DTPFecini2.Enabled = False

            BtnHabilitar_Prov.Visible = False
            BtnInhabilitar_Prov.Visible = True

        End If

        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub
    Public Sub Diferenciar_Prov()
        For Each fila As DataGridViewRow In dgvListado.Rows
            If fila.Cells("Habilitado").Value = 0 Then
                fila.DefaultCellStyle.BackColor = Color.Aquamarine
            End If
        Next
    End Sub
    '************************************BOTON EDITAR********************
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Relmente desea editar los datos del Proveedor", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'If result = DialogResult.OK Then
        ' If DTPFecAlta.Value.Date <= DTPFecini.Value.Date Then
        'MessageBox.Show("La fecha de inicio de actividad no puede ser mayor a la fecha de alta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Return
        ' End If

        If Me.ValidateChildren = True Then
            Try
                Dim dts As New ProveedoresNE
                Dim func As New ProveedoresDA

                If CHkJuridica.Checked = True Then

                    dts.Cuit = MtxtCuit.Text
                    dts.RazonSocial = TxtRazSocial.Text
                    dts.Fantasia = TxtFantasia.Text
                    dts.fecha_ini = DTPFecini2.Value
                    dts.Calle = TxtCalle2.Text
                    dts.telefono = MtxtTel2.Text
                    dts.celular = MtxtCelular2.Text
                    dts.mail = TxtMail2.Text
                    dts.NumCalle = TxtNumero2.Text
                    dts.Edificio = TxtEdificio2.Text
                    dts.Piso = TxtPiso2.Text
                    dts.Dpto = TxtDPto2.Text
                    dts.CP = TxtCP2.Text
                    dts.Barrio = TxtBarrio2.Text
                    dts.Pais = CbPais2.Text
                    dts.Provincia = TxtProvincia2.Text
                    dts.Ciudad = TxtCiudad2.Text

                ElseIf CHkFisica.Checked = True Then

                    dts.Cuit = txtNroDoc.Text
                    dts.Tipo_dni = cbTipoDoc.Text
                    dts.nombre = txtNombre.Text
                    dts.apellido = txtApellido.Text
                    dts.fecha_ini = DTPFecini.Value
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
                    dts.Pais = CbPais.Text
                    dts.Provincia = TxtProvincia.Text
                    dts.Ciudad = TxtCiudad.Text

                End If

                If CHkJuridica.Checked = True Then
                    func.editarJuridica(dts)
                    MessageBox.Show("Proveedor modificado correctamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                ElseIf CHkFisica.Checked = True Then
                    func.editar(dts)
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

    End Sub

    '*********************CHKBOX HABILITAR E INHABILITAR***********
    Private Sub CbInhabilitar_Prov_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbInhabilitar_Prov.CheckedChanged
        If CbInhabilitar_Prov.CheckState = CheckState.Checked Then
            dgvListado.Columns.Item("Inhabilitar").Visible = True
        Else
            dgvListado.Columns.Item("Inhabilitar").Visible = False
        End If
    End Sub

    Private Sub CbHabilitar_cli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbHabilitar_Prov.CheckedChanged
        If CbHabilitar_Prov.CheckState = CheckState.Checked Then
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
        Me.dgvListado.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvListado.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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

    Private Sub TxtMail2_Leave(sender As Object, e As EventArgs) Handles TxtMail2.Leave
        If validar_Mail(LCase(TxtMail2.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & _
            " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMail2.Focus()
            TxtMail2.SelectAll()
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
    Private Sub MtxtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MtxtTel.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, MtxtTel.Text & CChar(e.KeyChar))
    End Sub
    Private Sub MtxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MtxtCelular.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, MtxtCelular.Text & CChar(e.KeyChar))
    End Sub
    Private Sub txtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtNroDoc.Text & CChar(e.KeyChar))
    End Sub
    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtNroDoc.Text & CChar(e.KeyChar))
    End Sub
    Private Sub TxtNumero2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero2.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtNroDoc.Text & CChar(e.KeyChar))
    End Sub
    Private Sub TxtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCP.KeyPress
        e.Handled = Fg_SoloNumeros(e.KeyChar, txtNroDoc.Text & CChar(e.KeyChar))
    End Sub
    Private Sub TxtCP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCP2.KeyPress
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
        buscarProveedor()
    End Sub

    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente desde su numero de documento
    Private Sub buscarProveedor()
        Dim objProveedor As New ProveedoresNE
        'Dim objPresupuestoDA As New ClientesDA
        Dim objProveedorDA As New ProveedoresDA
        Dim dr As DataRow

        Try
            objProveedor.Cuit = txtNroDoc.Text

            dr = objProveedorDA.buscarProveedor(objProveedor.Cuit)

            txtNombre.Text = CStr(dr("Nombre"))
            txtApellido.Text = CStr(dr("Apellido"))
            cbTipoDoc.Text = dr("Id_Tipo_Dni")
            txtCalle.Text = CStr(dr("Calle"))
            TxtNumero.Text = CStr(dr("NumeroCalle"))
            TxtEdificio.Text = CStr(dr("Edificio"))
            txtPiso.Text = CStr(dr("Piso"))
            TxtDpto.Text = CStr(dr("Dpto"))
            TxtCP.Text = CStr(dr("CP"))
            TxtBarrio.Text = CStr(dr("Barrio"))
            CbPais.Text = CStr(dr("Pais"))
            TxtProvincia.Text = CStr(dr("Provincia"))
            TxtCiudad.Text = CStr(dr("Ciudad"))
            MtxtTel.Text = CStr(dr("Telefono"))
            MtxtCelular.Text = CStr(dr("Celular"))
            txtMail.Text = CStr(dr("Mail"))
            DTPFecAlta.Text = CStr(dr("Fecha_Alta"))
            DTPFecini.Text = CStr(dr("Fecha_ini"))

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("No existe el proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    '*****************************************BUSCAR CLIENTE JURIDICO***************************
    '***************
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscarproveedorJURIDICO()
    End Sub
    Private Sub buscarproveedorJURIDICO()
        Dim objproveedor As New ProveedoresNE
        'Dim objPresupuestoDA As New ClientesDA
        Dim objproveedorDA As New ProveedoresDA
        Dim dr As DataRow

        Try
            objproveedor.Cuit = MtxtCuit.Text

            dr = objproveedorDA.buscarProveedorJURIDICO(objproveedor.Cuit)

            TxtRazSocial.Text = CStr(dr("RazonSocial"))
            TxtFantasia.Text = CStr(dr("Fantasia"))
            'cbTipoDoc.Text = dr("Id_Tipo_Dni")
            TxtCalle2.Text = CStr(dr("Calle"))
            TxtNumero2.Text = CStr(dr("NumeroCalle"))
            TxtEdificio2.Text = CStr(dr("Edificio"))
            TxtPiso2.Text = CStr(dr("Piso"))
            TxtDPto2.Text = CStr(dr("Dpto"))
            TxtCP2.Text = CStr(dr("CP"))
            TxtBarrio2.Text = CStr(dr("Barrio"))
            CbPais2.Text = CStr(dr("Pais"))
            TxtProvincia2.Text = CStr(dr("Provincia"))
            TxtCiudad2.Text = CStr(dr("Ciudad"))
            MtxtTel2.Text = CStr(dr("Telefono"))
            MtxtCelular2.Text = CStr(dr("Celular"))
            TxtMail2.Text = CStr(dr("Mail"))
            'DTPFecAlta2.Text = CStr(dr("Fecha_Alta"))
            DTPFecini2.Text = CStr(dr("Fecha_Ini"))

        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("No existe el proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    '********************************BOTON INHABILITAR****************
    Private Sub BtnInhabilitar_Prov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar_Prov.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea inhabilitar el/los proveedor seleccionados?", "Inhabilitando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Inhabilitar").Value)

                    If marcado Then
                        Dim oneKey As String = Convert.ToString(row.Cells("CUIT").Value)
                        Dim cdb As New ProveedoresNE
                        Dim func As New ProveedoresDA
                        cdb._Cuit = oneKey

                        If func.Inhabilitar_Prov(cdb) Then
                        Else
                            MessageBox.Show("Proveedor Inhabilitado!", "Inhabilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    '********************************BOTON HABILITAR****************
    Private Sub BtnHabilitar_prov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHabilitar_Prov.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea Habilitar el/los proveedor seleccionados?", "Habilitando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Habilitar").Value)

                    If marcado Then
                        Dim oneKey As String = Convert.ToString(row.Cells("CUIT").Value)
                        Dim vdb As New ProveedoresNE
                        Dim func As New ProveedoresDA
                        vdb._Cuit = oneKey

                        If func.Habilitar_Prov(vdb) Then
                        Else
                            MessageBox.Show("Proveedor Habilitado!", "Habilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    '*************************LIMPIAR E INHABILITAR JURIDICA*******************
    Public Sub LimpInhJuridica()
        CHkJuridica.Checked = False
        CHkFisica.Checked = True

        MtxtCuit.Text = ""
        TxtRazSocial.Text = ""
        TxtFantasia.Text = ""
        TxtCalle2.Text = ""
        TxtNumero2.Text = ""
        TxtEdificio2.Text = ""
        TxtPiso2.Text = ""
        TxtDPto2.Text = ""
        TxtCP2.Text = ""
        TxtBarrio2.Text = ""
        CbPais2.Text = "Seleccione una opcion..."
        TxtProvincia2.Text = ""
        TxtCiudad2.Text = ""
        MtxtTel2.Text = ""
        MtxtCelular2.Text = ""
        TxtMail2.Text = ""
        DTPFecAlta2.Text = ""
        DTPFecini2.Text = ""

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
        CbPais.Enabled = True
        TxtProvincia.Enabled = True
        TxtCiudad.Enabled = True
        MtxtTel.Enabled = True
        MtxtCelular.Enabled = True
        txtMail.Enabled = True
        DTPFecAlta.Enabled = True
        DTPFecini.Enabled = True

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
        CbPais2.Enabled = False
        TxtProvincia2.Enabled = False
        TxtCiudad2.Enabled = False
        MtxtTel2.Enabled = False
        MtxtCelular2.Enabled = False
        TxtMail2.Enabled = False
        DTPFecAlta2.Enabled = False
        DTPFecini2.Enabled = False

    End Sub
    '*************************LIMPIAR E INHABILITAR FISICA*********************
    Public Sub LimpInhFisica()
        CHkFisica.Checked = False
        CHkJuridica.Checked = True

        txtNroDoc.Text = ""
        cbTipoDoc.Text = "Seleccione una opcion..."
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCalle.Text = ""
        MtxtTel.Text = ""
        MtxtCelular.Text = ""
        txtMail.Text = ""
        DTPFecini.Text = ""
        DTPFecAlta.Text = ""
        TxtNumero.Text = ""
        TxtEdificio.Text = ""
        txtPiso.Text = ""
        TxtDpto.Text = ""
        TxtCP.Text = ""
        TxtBarrio.Text = ""
        CbPais.Text = "Seleccione una opcion..."
        TxtProvincia.Text = ""
        TxtCiudad.Text = ""
        DTPFecAlta.Text = ""

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
        CbPais2.Enabled = True
        TxtProvincia2.Enabled = True
        TxtCiudad2.Enabled = True
        MtxtTel2.Enabled = True
        MtxtCelular2.Enabled = True
        TxtMail2.Enabled = True
        DTPFecAlta2.Enabled = True
        DTPFecini2.Enabled = True

    End Sub

    '**********************************************CHEcKED PERSONAS***************************************
    Private Sub CHkFisica_CheckedChanged(sender As Object, e As EventArgs) Handles CHkFisica.CheckedChanged
        FisicaChequeado()
    End Sub
    Public Sub FisicaChequeado()
        CHkJuridica.Checked = False
        txtNroDoc.Focus()

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
        CbPais.Enabled = True
        TxtProvincia.Enabled = True
        TxtCiudad.Enabled = True
        MtxtTel.Enabled = True
        MtxtCelular.Enabled = True
        txtMail.Enabled = True
        DTPFecAlta.Enabled = True
        DTPFecini.Enabled = True

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
        CbPais2.Enabled = False
        TxtProvincia2.Enabled = False
        TxtCiudad2.Enabled = False
        MtxtTel2.Enabled = False
        MtxtCelular2.Enabled = False
        TxtMail2.Enabled = False
        DTPFecAlta2.Enabled = False
        DTPFecini2.Enabled = False
    End Sub
    Private Sub CHkJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles CHkJuridica.CheckedChanged
        juridicaChequeado()
    End Sub

    Public Sub juridicaChequeado()
        CHkFisica.Checked = False
        MtxtCuit.Focus()

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
        CbPais.Enabled = False
        TxtProvincia.Enabled = False
        TxtCiudad.Enabled = False
        MtxtTel.Enabled = False
        MtxtCelular.Enabled = False
        txtMail.Enabled = False
        DTPFecAlta.Enabled = False
        DTPFecini.Enabled = False

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
        CbPais2.Enabled = True
        TxtProvincia2.Enabled = True
        TxtCiudad2.Enabled = True
        MtxtTel2.Enabled = True
        MtxtCelular2.Enabled = True
        TxtMail2.Enabled = True
        DTPFecAlta2.Enabled = True
        DTPFecini2.Enabled = True
    End Sub




End Class