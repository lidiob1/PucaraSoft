Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA

Public Class FrmConsultaReservaxCliente
    Dim dt As New DataTable
    Private ds As DataSet

    Private Sub FrmConsultaReservaxCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos combo tipo de cancha
        CargarTipoCancha()
    End Sub

    '=======================================================================================================
    ' Cargar el combobox de Tipo de Cancha
    '=======================================================================================================
    Private Sub CargarTipoCancha()
        Dim objComboTipoCancha As New CanchaDA
        ds = New DataSet()
        ds = objComboTipoCancha.cargarTipoCancha
        cb_tipoCancha.DataSource = ds.Tables("tabTipoCancha")
        cb_tipoCancha.DisplayMember = "descripcion"
        cb_tipoCancha.ValueMember = "id_tipo_cancha"
    End Sub

    '=======================================================================================================
    ' Cargar el combobox de Tipo de Cancha
    '=======================================================================================================
    Public Sub buscarReservas()
        Dim objReservaDA As New ReservaDA
        Dim id_tipo_cancha As Integer

        'Obtenemos id_tipo_cancha
        id_tipo_cancha = getIdTipoCancha(cb_tipoCancha.Text)
        dt = objReservaDA.buscarReservas(id_tipo_cancha, CDate(dtpDesde.Text), CDate(dtpHasta.Text))
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = dt

    End Sub

    '=======================================================================================================
    ' Obtenemos id_tipo_cancha
    '=======================================================================================================
    Public Function getIdTipoCancha(ByVal descripcion As String)
        Dim dr As DataRow
        Dim objCanchaDA As New CanchaDA
        Dim id_tipo_cancha As Integer

        dr = objCanchaDA.getIdTipoCancha(descripcion)
        If dr Is Nothing Then
            id_tipo_cancha = 0
        Else
            id_tipo_cancha = dr("id_tipo_cancha")
        End If
        Return id_tipo_cancha
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarReservas()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class