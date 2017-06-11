Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA

Public Class FrmDisponibilidad
    Dim dt As New DataTable
    Private ds As DataSet

    Dim lv_contador As Integer

    '===================================================================================================================================
    ' Grilla:
    ' Horario desde     Horario hasta   Tipo de cancha      Nro. cancha     Tipo de reserva     Cliente     Nombre del cliente
    '===================================================================================================================================
    Private Sub FrmDisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoCancha()
        mostrar_horario()

    End Sub

    '=======================================================================================================
    ' Cargar horarios
    '=======================================================================================================
    Public Sub mostrar_horario()
        Dim objHorarioDA As New HorarioDA
        dt = objHorarioDA.mostrar_horario
        dgv_canchas.DataSource = Nothing
        dgv_canchas.DataSource = dt
    End Sub

    '=======================================================================================================
    ' Cargar el combobox de Tipo de Cancha
    '=======================================================================================================
    Private Sub CargarTipoCancha()
        Dim objComboTipoCancha As New CanchaDA
        ds = New DataSet()
        ds = objComboTipoCancha.cargarTipoCancha
        cb_tipo_cancha.DataSource = ds.Tables("tabTipoCancha")
        cb_tipo_cancha.DisplayMember = "descripcion"
        cb_tipo_cancha.ValueMember = "id_tipo_cancha"
    End Sub

    '=======================================================================================================
    ' Completamos combo canchas
    '=======================================================================================================
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
    ' Cuando elijo del combobox tipo de cancha
    '=======================================================================================================
    Private Sub cb_tipo_cancha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo_cancha.SelectedIndexChanged
        completar_cb_cancha()
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

    '=======================================================================================================
    ' Obtenemos nro_cancha
    '=======================================================================================================
    Public Function getNroCancha(ByVal descripcion As String)
        Dim dr As DataRow
        Dim objCanchaDA As New CanchaDA
        Dim id_tipo_cancha As Integer

        dr = objCanchaDA.getNroCancha(descripcion)
        If dr Is Nothing Then
            id_tipo_cancha = 0
        Else
            id_tipo_cancha = dr("Num_cancha")
        End If
        Return id_tipo_cancha
    End Function

    '=======================================================================================================
    ' Cargar grilla
    '=======================================================================================================
    Private Sub cargar_grilla()

        Dim dtReservas As New DataTable
        Dim objReservaDA As New ReservaDA

        Dim id_tipo_cancha As Integer
        Dim nro_cancha As Integer
        Dim m As Integer

        Dim colNroDoc As New DataGridViewTextBoxColumn
        Dim colNombre As New DataGridViewTextBoxColumn
        Dim colApellido As New DataGridViewTextBoxColumn

        Dim lv_fechaDesde As String
        Dim lv_grillaInicio As String
        Dim i As Integer

        'Obtenemos id_tipo_cancha
        id_tipo_cancha = getIdTipoCancha(cb_tipo_cancha.Text)
        'Obtenemos nro_cancha
        nro_cancha = getNroCancha(cb_nro_cancha.Text)

        'Obtenemos las reservas que ya estan
        dtReservas = objReservaDA.buscarDisponibilidad(CDate(mc_calendario.SelectionStart.Date), id_tipo_cancha, nro_cancha)

        'Asignamos el nombre a la columna Nro de documento
        colNroDoc.Name = "Nro. doc."
        'Asignamos el nombre a la columna Nombre
        colNombre.Name = "Nombre"
        'Asignamos el nombre a la columna Apellido
        colApellido.Name = "Apellido"

        'Creamos las columnas Nro de documento, Nombre, Apellido
        dgv_canchas.Columns.Add(colNroDoc)
        dgv_canchas.Columns.Add(colNombre)
        dgv_canchas.Columns.Add(colApellido)

        'Comenzamos por completar la columna Nro de documento ya que las 2 primeras son de horarios desde y hasta
        m = 0
        'Completamos la grilla con las reservas que ya estan
        For Each row As DataRow In dtReservas.Rows      'Recorremos el Datatable con el resultado de SQL

            'Obtenemos HORA DE INICIO consulta SQL
            lv_fechaDesde = row("hora_inicio").ToString

            'RECORREMOS GRILLA
            For i = 0 To dgv_canchas.RowCount - 1

                'Pasamos hora de inicio de la grilla, primera columna
                lv_grillaInicio = dgv_canchas.Rows(i).Cells(0).Value.ToString

                'Comparamos las reservas contra el horario de inicio que tenemos en la DB contra el horario de la grilla por defecto
                If lv_fechaDesde = lv_grillaInicio Then
                    'Completamos la columna Nro. doc. con el valor sql
                    dgv_canchas.Rows(i).Cells("Nro. doc.").Value = row("nro_doc_cliente")
                    'Completamos la columna Nombre con el valor sql
                    dgv_canchas.Rows(i).Cells("Nombre").Value = row("nombre")
                    'Completamos la columna Apellido con el valor sql
                    dgv_canchas.Rows(i).Cells("Apellido").Value = row("apellido")

                    'Pintamos en naranja el horario que ya esta reservado
                    dgv_canchas.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                    Exit For
                End If
            Next

            'Completamos la columna siguiente
            m = m + 1
        Next

        alinear_derecha()           'Alineamos a la derecha las columnas Nro documento, Nombre y Apellido
        centrar_horarios()          'Centramos primera y segunda columna Horario desde y Horario hasta de la grilla
        autoajustarTexto()          'Auto ajustar texto de columna de acuerdo al contenido

    End Sub

    '=======================================================================================================
    ' Alineamos los campos a la derecha en la grilla
    '=======================================================================================================
    Private Sub alinear_derecha()
        'Alineamos contenido de las columnas a la derecha
        dgv_canchas.Columns("Nro. doc.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_canchas.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_canchas.Columns("Apellido").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    '=======================================================================================================
    ' Centra contenido de las columnas Horario desde y Horario hasta de la grilla
    '=======================================================================================================
    Private Sub centrar_horarios()
        dgv_canchas.Columns("Horario desde").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_canchas.Columns("Horario hasta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    '=======================================================================================================
    ' Auto ajustar tamaño de las columnas de acuerdo al contenido de la grilla
    '=======================================================================================================
    Private Sub autoajustarTexto()
        'ancho de las columnas autoajustado al tamaño del texto
        dgv_canchas.AutoResizeColumn(0)         'Horario desde
        dgv_canchas.AutoResizeColumn(1)         'Horario hasta
        dgv_canchas.AutoResizeColumn(2)         'Nro. doc.
        dgv_canchas.AutoResizeColumn(3)         'Nombre
        dgv_canchas.AutoResizeColumn(4)         'Apellido
    End Sub

    '=======================================================================================================
    ' Boton Buscar
    '=======================================================================================================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargar_grilla()
    End Sub
End Class