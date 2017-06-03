Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA

Public Class FrmDisponibilidad
    Dim dt As New DataTable
    Private ds As DataSet

    Private Sub FrmDisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrar_horario()
        CargarTipoCancha()

    End Sub

    Public Sub mostrar_horario()
        Dim objHorarioDA As New HorarioDA
        dt = objHorarioDA.mostrar_horario
        dgv_canchas.DataSource = Nothing
        dgv_canchas.DataSource = dt
    End Sub
    '--------------------------------------------------------------------------------
    ' Completamos combo canchas
    '--------------------------------------------------------------------------------
    Public Sub completar_cb_cancha()
        Dim objComboCanchas As New CanchaDA
        Dim objTipoCancha As New TipoCanchaNE

        objTipoCancha._descripcion = cb_tipo_cancha.Text

        ds = New DataSet()
        ds = objComboCanchas.cargar_cb_canchas(objTipoCancha)
        cb_nro_cancha.DataSource = ds.Tables("tabCanchas")
        cb_nro_cancha.DisplayMember = "Descripcion"
        cb_nro_cancha.ValueMember = "Num_cancha"
    End Sub

    '=======================================================================================================
    ' Cargar el combobox de Tipo de Cancha
    '=======================================================================================================
    Private Sub CargarTipoCancha()
        Dim objComboTipoCancha As New ReservaDA
        ds = New DataSet()
        ds = objComboTipoCancha.cargarTipoCancha
        cb_tipo_cancha.DataSource = ds.Tables("tabTipoCancha")
        cb_tipo_cancha.DisplayMember = "descripcion"
        cb_tipo_cancha.ValueMember = "id_tipo_cancha"
    End Sub

    '=======================================================================================================
    ' Cuando elijo del combobox tipo de cancha
    '=======================================================================================================
    Private Sub cb_tipo_cancha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo_cancha.SelectedIndexChanged
        completar_cb_cancha()
    End Sub
End Class