Imports System.Data.SqlClient
Imports CapaNE
Imports CapaDA

Public Class FrmDisponibilidad
    Dim dt As New DataTable
    Private ds As DataSet

    Private Sub FrmDisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrar_horario()
        CargarTipoCancha()

        cargar_grilla()

    End Sub

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
    ' Cargar grilla
    '=======================================================================================================
    Private Sub cargar_grilla()

        With dgv_canchas
            '.Columns(0).Name = "colHoraInicio"
            'Agregamos una fila con los siguientes datos
            .Rows.Add("08:00", "09:00", "5 vs 5")
            'Alineamos a la derecha
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With



        ''elimino primera columna de selección de la grilla
        'dgv_canchas.RowHeadersVisible = False

        ''Creo mi datatable y columnas
        'Dim miDataTable As New DataTable
        'miDataTable.Columns.Add("Nombre")
        'miDataTable.Columns.Add("Sexo")

        ''Renglon es la variable que adicionara renglones a mi datatable
        'Dim Renglon As DataRow = miDataTable.NewRow()
        'Renglon("Nombre") = "Luis"
        'Renglon("Sexo") = "Masculino"
        'miDataTable.Rows.Add(Renglon)

        'Renglon = miDataTable.NewRow()
        'Renglon("Nombre") = "Carmen"
        'Renglon("Sexo") = "Femenino"
        'miDataTable.Rows.Add(Renglon)

        ''por último envió mi datatable a un gridview para visualizarlo en pantalla
        'Me.dgv_canchas.DataSource = miDataTable
        ''Me.dgv_canchas.DataBind()
    End Sub

    '=======================================================================================================
    ' Alineamos los campos a la derecha en la grilla
    '=======================================================================================================
    Private Sub alinear_derecha()
        With dgv_canchas
            'Alineamos a la derecha
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

End Class