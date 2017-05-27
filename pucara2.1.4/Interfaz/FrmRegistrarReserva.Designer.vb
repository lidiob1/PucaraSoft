<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarReserva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarReserva))
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConsultarReservas = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvReserva = New System.Windows.Forms.DataGridView()
        Me.co_nro_cancha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coTipoCancha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.co_tipo_reserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNroCancha = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtHoraFin = New System.Windows.Forms.MaskedTextBox()
        Me.txtHoraInicio = New System.Windows.Forms.MaskedTextBox()
        Me.btnDisponibilidad = New System.Windows.Forms.Button()
        Me.cboTipoReserva = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaReserva = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoCancha = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaSolicitud = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtNroReserva = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(253, 377)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 20
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(172, 377)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.btnConsultarReservas)
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Location = New System.Drawing.Point(15, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(463, 49)
        Me.Panel2.TabIndex = 18
        '
        'btnConsultarReservas
        '
        Me.btnConsultarReservas.Location = New System.Drawing.Point(44, 9)
        Me.btnConsultarReservas.Name = "btnConsultarReservas"
        Me.btnConsultarReservas.Size = New System.Drawing.Size(118, 32)
        Me.btnConsultarReservas.TabIndex = 15
        Me.btnConsultarReservas.Text = "Consultar Reservas"
        Me.btnConsultarReservas.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(330, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 32)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(249, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 32)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(168, 9)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 32)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.dgvReserva)
        Me.Panel1.Location = New System.Drawing.Point(15, 403)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 89)
        Me.Panel1.TabIndex = 17
        '
        'dgvReserva
        '
        Me.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.co_nro_cancha, Me.coTipoCancha, Me.co_tipo_reserva})
        Me.dgvReserva.Location = New System.Drawing.Point(11, 3)
        Me.dgvReserva.Name = "dgvReserva"
        Me.dgvReserva.Size = New System.Drawing.Size(439, 79)
        Me.dgvReserva.TabIndex = 0
        '
        'co_nro_cancha
        '
        Me.co_nro_cancha.HeaderText = "Nª Cancha"
        Me.co_nro_cancha.Name = "co_nro_cancha"
        '
        'coTipoCancha
        '
        Me.coTipoCancha.HeaderText = "Tipo de Cancha"
        Me.coTipoCancha.Name = "coTipoCancha"
        '
        'co_tipo_reserva
        '
        Me.co_tipo_reserva.HeaderText = "Tipo de reserva"
        Me.co_tipo_reserva.Name = "co_tipo_reserva"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtNroDoc)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(466, 109)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(154, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(251, 73)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(196, 20)
        Me.txtApellido.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(248, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(251, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(196, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nombre"
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(27, 35)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(121, 20)
        Me.txtNroDoc.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nro. Documento"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox1.Controls.Add(Me.txtNroCancha)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Controls.Add(Me.txtHoraFin)
        Me.GroupBox1.Controls.Add(Me.txtHoraInicio)
        Me.GroupBox1.Controls.Add(Me.btnDisponibilidad)
        Me.GroupBox1.Controls.Add(Me.cboTipoReserva)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaReserva)
        Me.GroupBox1.Controls.Add(Me.cboTipoCancha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFechaSolicitud)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboEstado)
        Me.GroupBox1.Controls.Add(Me.txtNroReserva)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 246)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Reserva"
        '
        'txtNroCancha
        '
        Me.txtNroCancha.Location = New System.Drawing.Point(347, 80)
        Me.txtNroCancha.Name = "txtNroCancha"
        Me.txtNroCancha.Size = New System.Drawing.Size(98, 20)
        Me.txtNroCancha.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(274, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Nro. Cancha"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(103, 196)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(342, 44)
        Me.txtObservacion.TabIndex = 13
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(347, 138)
        Me.txtHoraFin.Mask = "00:00"
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraFin.TabIndex = 10
        Me.txtHoraFin.ValidatingType = GetType(Date)
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(103, 138)
        Me.txtHoraInicio.Mask = "00:00"
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraInicio.TabIndex = 9
        Me.txtHoraInicio.ValidatingType = GetType(Date)
        '
        'btnDisponibilidad
        '
        Me.btnDisponibilidad.Location = New System.Drawing.Point(347, 51)
        Me.btnDisponibilidad.Name = "btnDisponibilidad"
        Me.btnDisponibilidad.Size = New System.Drawing.Size(100, 23)
        Me.btnDisponibilidad.TabIndex = 12
        Me.btnDisponibilidad.Text = "Ver disponibilidad"
        Me.btnDisponibilidad.UseVisualStyleBackColor = True
        '
        'cboTipoReserva
        '
        Me.cboTipoReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoReserva.FormattingEnabled = True
        Me.cboTipoReserva.Location = New System.Drawing.Point(103, 169)
        Me.cboTipoReserva.Name = "cboTipoReserva"
        Me.cboTipoReserva.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoReserva.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(296, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Hora fin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tipo de reserva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Hora inicio"
        '
        'dtpFechaReserva
        '
        Me.dtpFechaReserva.Location = New System.Drawing.Point(103, 107)
        Me.dtpFechaReserva.Name = "dtpFechaReserva"
        Me.dtpFechaReserva.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaReserva.TabIndex = 8
        '
        'cboTipoCancha
        '
        Me.cboTipoCancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCancha.FormattingEnabled = True
        Me.cboTipoCancha.Location = New System.Drawing.Point(103, 80)
        Me.cboTipoCancha.Name = "cboTipoCancha"
        Me.cboTipoCancha.Size = New System.Drawing.Size(165, 21)
        Me.cboTipoCancha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha reserva"
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(347, 22)
        Me.txtFechaSolicitud.Mask = "00/00/0000"
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaSolicitud.TabIndex = 5
        Me.txtFechaSolicitud.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de solicitud"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(103, 53)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(165, 21)
        Me.cboEstado.TabIndex = 6
        '
        'txtNroReserva
        '
        Me.txtNroReserva.Enabled = False
        Me.txtNroReserva.Location = New System.Drawing.Point(103, 26)
        Me.txtNroReserva.Name = "txtNroReserva"
        Me.txtNroReserva.Size = New System.Drawing.Size(100, 20)
        Me.txtNroReserva.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo de Cancha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nª Reserva"
        '
        'FrmRegistrarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(492, 556)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRegistrarReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Reserva"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnConsultarReservas As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvReserva As System.Windows.Forms.DataGridView
    Friend WithEvents co_nro_cancha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coTipoCancha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents co_tipo_reserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroCancha As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHoraInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnDisponibilidad As System.Windows.Forms.Button
    Friend WithEvents cboTipoReserva As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaReserva As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoCancha As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroReserva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
