Imports System.Data.SqlClient
Imports System.EventArgs
Imports CapaNE
Imports CapaDA

Public Class FrmCancha
    Private dt As New DataTable
    Private dtt As New DataTable
    Dim cmd As New SqlConnection
    Private ds As DataSet

    Private Sub Chancha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar_cancha()

    End Sub
    '*****************************FUNCION MOSTRAR CANCHA*******************
    Public Sub Mostrar_cancha()
        Try
            Dim func As New CanchaDA
            dt = func.Mostrar_cancha
            DataListado_Cancha.Columns.Item("Inhabilitar").Visible = False
            DataListado_Cancha.Columns.Item("Habilitar").Visible = False


            If dt.Rows.Count <> 0 Then
                DataListado_Cancha.DataSource = dt
                'TxtBuscar_Cancha.Enabled = True
                DataListado_Cancha.ColumnHeadersVisible = True
                Inexistente.Visible = False

            Else
                DataListado_Cancha.DataSource = Nothing
                'TxtBuscar_Cancha.Enabled = False
                DataListado_Cancha.ColumnHeadersVisible = False
                Inexistente.Visible = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnGuardar_Cancha.Visible = True
        BtnModificar_cancha.Visible = False
        TxtNumCancha.Enabled = False

        Diferenciar_cancha()
        LimpiarCheckBox_cancha()
        AlineadoDerecha()
        Mostrar_numMax()
        'OcultarFilas()

    End Sub
    Public Sub Mostrar_numMax()
        Try
            Dim func As New CanchaDA
            dtt = func.Mostrar_numMax
            TxtNumCancha.Text = dtt.Rows(0)(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buscar_cancha()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            'dv.RowFilter = TxtBuscar_Cancha.Text

            If dv.Count <> 0 Then
                Inexistente.Visible = False
                DataListado_Cancha.DataSource = dv
                'ocultar_columnas_cli()
            Else
                Inexistente.Visible = True
                DataListado_Cancha.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub Diferenciar_cancha()
        For Each fila As DataGridViewRow In DataListado_Cancha.Rows
            If fila.Cells("Habilitado").Value = 0 Then
                fila.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub


    Public Sub AlineadoDerecha()
        'Me.DataListado_cli.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataListado_Cancha.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataListado_Cancha.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataListado_Cancha.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataListado_Cancha.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataListado_Cancha.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ' Me.DataListado_Cancha.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ' Me.DataListado_Cancha.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.DataListado_Cancha.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    '**********************VALIDACIONES *******************************************
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890,", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function
    Private Sub TxtPreCancha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '  e.Handled = Fg_SoloNumeros(e.KeyChar, TxtPreCancha.Text & CChar(e.KeyChar))
        'e.Handled = Char.IsNumber(e.KeyChar)
    End Sub

    Function Fg_SoloNumeros2(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros2 = False
        Else
            If InStr("1234567890", Digito) = 0 Then
                Fg_SoloNumeros2 = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros2 = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros2 = True
            End If
        End If
        Return Fg_SoloNumeros2
    End Function

    Private Sub TxtNumCancha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' e.Handled = Fg_SoloNumeros2(e.KeyChar, TxtPreCancha.Text & CChar(e.KeyChar))
    End Sub
    Public Sub Nueva_cancha()
        BtnGuardar_Cancha.Visible = True
        BtnModificar_cancha.Visible = False
        TxtNumCancha.Text = ""
        CBTipCancha.Text = "...Seleccione una opcion..."
        Me.DTPFecActPre.ResetText()


        Habilitar_Nueva_Cancha()
    End Sub
    Public Sub Habilitar_Nueva_Cancha()
        TxtNumCancha.Enabled = True
        CBTipCancha.Enabled = True
        DTPFecActPre.Enabled = True

    End Sub
    '***********************************botones***********************************************

    Private Sub BtnGuardar_Cancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar_Cancha.Click
        'If DTPFecActPre.Value.Date <= DTPFecNac_cli.Value.Date Then
        'MessageBox.Show("La fecha no puede mayor a la actual!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Return
        ' End If

        If Me.ValidateChildren = True And CBTipCancha.SelectedIndex <> -1 And TxtNumCancha.Text <> "" Then
            Try
                Dim dts As New CanchaNE
                Dim func As New CanchaDA

                dts._Num_cancha = TxtNumCancha.Text
                dts._TamCancha = CBTipCancha.Text
                'dts._Precio_cancha = TxtPreCancha.Text
                dts._FechaActPrecio = DTPFecActPre.Text
                dts._habilitado = 1

                If func.Insertar_Cancha(dts) Then
                    MessageBox.Show("Cancha cargada correctamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar_cancha()
                    Nueva_cancha()
                Else
                    MessageBox.Show("La cancha no fue registrada, intente nuevamente!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Mostrar_cancha()
                    Nueva_cancha()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos!", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Mostrar_cancha()
    End Sub

    Private Sub BtnModificar_cancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar_cancha.Click
        Dim result As DialogResult

        result = MessageBox.Show("Esta seguro que desea editar los datos de la cancha?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And CBTipCancha.SelectedIndex <> -1 And TxtNumCancha.Text <> "" Then
                Try
                    Dim dts As New CanchaNE
                    Dim func As New CanchaDA

                    dts._Num_cancha = TxtNumCancha.Text
                    dts._TamCancha = CBTipCancha.Text
                    'dts._Precio_cancha = TxtPreCancha.Text
                    dts._FechaActPrecio = DTPFecActPre.Text


                    If func.Editar_Cancha(dts) Then
                        MessageBox.Show("Cancha modificada correctamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Mostrar_cancha()
                        Nueva_cancha()
                    Else
                        MessageBox.Show("La cancha no fue modificada, intente nuevamente!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mostrar_cancha()
                        Nueva_cancha()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta modificar algunos datos!", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Mostrar_cancha()
    End Sub

    Private Sub BtnNuevo_cancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo_cancha.Click
        Nueva_cancha()
        Mostrar_cancha()
        TxtNumCancha.Focus()
    End Sub

    Private Sub BtnCancelar_cancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar_cancha.Click
        Dim result As DialogResult

        result = MessageBox.Show("Esta seguro que desea cancelar el ingreso de registros?", "Cancelando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Me.Close()
        End If
        Mostrar_cancha()
    End Sub

    Private Sub BtnInhabilitar_cancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInhabilitar_cancha.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea inhabilitar la/las canchas seleccionadas?", "Inhabilitando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado_Cancha.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Inhabilitar").Value)

                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("Numero de cancha").Value)
                        Dim cdb As New CanchaNE
                        Dim func As New CanchaDA
                        cdb._Num_cancha = oneKey

                        If func.Inhabilitar_cancha(cdb) Then
                        Else
                            MessageBox.Show("Cancha Inhabilitada!", "Inhabilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Next
                Call Mostrar_cancha()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Cancelando Inhabilitacion de registros!", "Inhabilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Mostrar_cancha()
        End If
        Call Nueva_cancha()
        Mostrar_cancha()
    End Sub

    Private Sub BtnHabilitar_cancha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHabilitar_cancha.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea Habilitar la/las canchas seleccionadas?", "Habilitando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado_Cancha.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Habilitar").Value)

                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("Numero de cancha").Value)
                        Dim vdb As New CanchaNE
                        Dim func As New CanchaDA
                        vdb._Num_cancha = oneKey

                        If func.Habilitar_cancha(vdb) Then
                        Else
                            MessageBox.Show("Cancha Habilitada!", "Habilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Next
                Call Mostrar_cancha()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Cancelando Habilitacion de registros!", "Habilitando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Mostrar_cancha()
        End If
        Call Nueva_cancha()
    End Sub

    Public Sub LimpiarCheckBox_cancha()
        CbHabilitar_Cancha.Checked = False
        CbInhabilitar_Cancha.Checked = False
    End Sub

    Private Sub DataListado_Cancha_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado_Cancha.CellContentClick
        If e.ColumnIndex = Me.DataListado_Cancha.Columns.Item("Inhabilitar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.DataListado_Cancha.Rows(e.RowIndex).Cells("Inhabilitar")
            chkCell.Value = Not chkCell.Value
        End If
        If e.ColumnIndex = Me.DataListado_Cancha.Columns.Item("Habilitar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.DataListado_Cancha.Rows(e.RowIndex).Cells("Habilitar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub


    Private Sub DataListado_Cancha_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado_Cancha.CellClick

        TxtNumCancha.Text = DataListado_Cancha.SelectedCells.Item(2).Value
        CBTipCancha.Text = DataListado_Cancha.SelectedCells.Item(3).Value
        'TxtPreCancha.Text = DataListado_Cancha.SelectedCells.Item(4).Value
        DTPFecActPre.Value = DataListado_Cancha.SelectedCells.Item(4).Value

        If DataListado_Cancha.SelectedCells.Item(5).Value = 0 Then
            TxtNumCancha.Enabled = False
            CBTipCancha.Enabled = False
            'TxtPreCancha.Enabled = False
            DTPFecActPre.Enabled = False

            BtnHabilitar_cancha.Visible = True
            BtnInhabilitar_cancha.Visible = False
        Else
            TxtNumCancha.Enabled = True
            CBTipCancha.Enabled = True
            'TxtPreCancha.Enabled = True
            DTPFecActPre.Enabled = True

            BtnHabilitar_cancha.Visible = False
            BtnInhabilitar_cancha.Visible = True
        End If


        BtnModificar_cancha.Visible = True
        BtnGuardar_Cancha.Visible = False
    End Sub
    '*************************************************HACER INVISIBLE ROWS****************************
    Public Sub OcultarFilas()
        DataListado_Cancha.Columns(4).Visible = False
    End Sub
    Private Sub CbInhabilitar_Cancha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbInhabilitar_Cancha.CheckedChanged
        If CbInhabilitar_Cancha.CheckState = CheckState.Checked Then
            DataListado_Cancha.Columns.Item("Inhabilitar").Visible = True
        Else
            DataListado_Cancha.Columns.Item("Inhabilitar").Visible = False
        End If
    End Sub

    Private Sub CbHabilitar_Cancha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbHabilitar_Cancha.CheckedChanged
        If CbHabilitar_Cancha.CheckState = CheckState.Checked Then
            DataListado_Cancha.Columns.Item("Habilitar").Visible = True
        Else
            DataListado_Cancha.Columns.Item("Habilitar").Visible = False
        End If
    End Sub

    '**********************************ERROR PROVIDER************************

    Private Sub CBTipCancha_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CBTipCancha.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el tipo de cancha, por favor!!")
        End If
    End Sub

End Class