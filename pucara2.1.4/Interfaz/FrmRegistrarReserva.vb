Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA

Public Class FrmRegistrarReserva
    Dim nroRes As Integer
    Private ds As DataSet

    Private Sub frmReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ponemos por defecto la fecha del dia de hoy
        txtFechaSolicitud.Text = Date.Now.Date
        'No habilitamos el boton quitar
        btnQuitar.Enabled = False
        'Obtenemos numero de reserva
        nroRes = CInt(nroReserva())
        'Completamos numero de reserva
        txtNroReserva.Text = CStr(nroRes)

        'Cargamos combo tipo cancha
        CargarTipoCancha()
        'Cargamos combo tipo de reserva
        CargarTipoReserva()
        txtNroDoc.Focus()

    End Sub

    '--------------------------------------------------------------------------------
    ' Buscar nombre y apellido de cliente desde su numero de documento
    '--------------------------------------------------------------------------------
    Private Sub buscarCliente()
        Dim objCliente As New ClientesNE
        'Dim objPresupuestoDA As New PresupuestoDA
        Dim objReservaDA As New ReservaDA
        Dim dr As DataRow

        Try
            objCliente.Nro_Doc = txtNroDoc.Text
            dr = objReservaDA.buscarCliente(objCliente.Nro_Doc)
            txtNombre.Text = CStr(dr("nombre"))
            txtApellido.Text = CStr(dr("apellido"))
        Catch ex As Exception
            MessageBox.Show("No existe el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtApellido.Clear()
            txtNombre.Clear()
            txtNroDoc.Focus()
        End Try
    End Sub

    '--------------------------------------------------------------------------------
    ' Devuelve el ultimo numero de Reserva + 1
    '--------------------------------------------------------------------------------
    Public Function nroReserva()
        Dim dr As DataRow
        Dim objReservaDA As New ReservaDA
        Dim nro As String

        dr = objReservaDA.ultima_reserva
        If dr Is Nothing Then
            nro = "1"
        Else
            nro = CStr(dr("Nro"))
        End If
        Return nro
    End Function

    '=======================================================================================================
    ' Cargar el combobox de Estado
    '=======================================================================================================
    'Private Sub cargarestadocancha()
    '    Dim objcomboestado As New reservada
    '    ds = New dataset()
    '    ds = objcomboestado.cargarestado
    '    cboestado.datasource = ds.tables("tabestado")
    '    cboestado.displaymember = "descripcion"
    '    cboestado.valuemember = "id_estado_cancha"
    'End Sub

    '=======================================================================================================
    ' Cargar el combobox de Tipo de Cancha
    '=======================================================================================================
    Private Sub CargarTipoCancha()
        Dim objComboTipoCancha As New ReservaDA
        ds = New DataSet()
        ds = objComboTipoCancha.cargarTipoCancha
        cboTipoCancha.DataSource = ds.Tables("tabTipoCancha")
        cboTipoCancha.DisplayMember = "descripcion"
        cboTipoCancha.ValueMember = "id_tipo_cancha"
    End Sub

    '=======================================================================================================
    ' Cargar el combobox de Tipo de Reserva
    '=======================================================================================================
    Private Sub CargarTipoReserva()
        Dim objComboTipoReserva As New ReservaDA
        ds = New DataSet()
        ds = objComboTipoReserva.cargarTipoReserva
        cboTipoReserva.DataSource = ds.Tables("tabTipoReserva")
        cboTipoReserva.DisplayMember = "descripcion"
        cboTipoReserva.ValueMember = "id_tipo_reserva"
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDni.Click
        buscarCliente()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'Verificamos si se ingreso un numero de documento
        If txtNroDoc.Text = "" And txtNombre.Text = "" Then
            MsgBox("Debe ingresar un cliente", MsgBoxStyle.Critical, "ERROR")
            Return
        End If

        'Verificamos si se ingreso hora de inicio
        If dtpHoraInicio.Text = "" Then
            MsgBox("Debe ingresar una hora de inicio de juego", MsgBoxStyle.Critical, "ERROR")
            Return
        End If

        'Verificamos si se ingreso hora de fin
        If dtpHoraFin.Text = "" Then
            MsgBox("Debe ingresar una hora de fin de juego", MsgBoxStyle.Critical, "ERROR")
            Return
        End If

        ''Verificamos si se ingreso el numero de cancha
        'If txtNroCancha.Text = "" Then
        '    MsgBox("Debe ingresar un numero de cancha.", MsgBoxStyle.Critical, "ERROR")
        '    Return
        'End If
        '*********************************************************************************************************
        '* Verificamos si ya esta reservado para esa cancha y para esa hora
        '*********************************************************************************************************

        '*********************************************************************************************************
        '*********************************************************************************************************

        'Agregamos detalle a la grilla
        dgvReserva.Rows.Add(txtNroCancha.Text, cboTipoCancha.Text, cboTipoReserva.Text)
        btnQuitar.Enabled = True

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnDisponibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisponibilidad.Click
        Dim objDisponibilidad As New FrmDisponibilidad
        'objCanchasLibres.MdiParent = Me
        objDisponibilidad.Show()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        If Not dgvReserva.Rows.Count = 0 Then
            'Eliminamos lo seleccionado
            dgvReserva.Rows.Remove(dgvReserva.CurrentRow)
        End If
        'Si no hay nada en la grilla, no se habilita el boton Quitar
        If dgvReserva.Rows.Count = 0 Then
            btnQuitar.Enabled = False
        End If
    End Sub

    Private Sub btnConsultarReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarReservas.Click
        FrmConsultarReservas.ShowDialog()
    End Sub


    '===================> VALIDACIONES PARA LOS CAMPOS DE ENTRADA <========================================

    '=======================================================================================================
    ' En el numero de documento solo se deben ingresar numeros
    '=======================================================================================================
    Private Sub txtNroDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDoc.KeyPress

        e.Handled = Validaciones.validarSoloNumero(e)
        If Validaciones.validarSoloNumero(e) Then
            MsgBox("Debe Ingresar solo caracteres numéricos", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
