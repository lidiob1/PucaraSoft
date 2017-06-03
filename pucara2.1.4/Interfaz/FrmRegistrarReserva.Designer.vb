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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.btnBuscarDni = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnBuscarCuit = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNomFantasia = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConsultarReservas = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvReserva = New System.Windows.Forms.DataGridView()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.co_nro_cancha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coTipoCancha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.co_tipo_reserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtNroCancha = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
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
        Me.txtNroReserva = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuil = New System.Windows.Forms.MaskedTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(26, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(549, 115)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage1.Controls.Add(Me.txtNroDoc)
        Me.TabPage1.Controls.Add(Me.btnBuscarDni)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtApellido)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(541, 89)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Persona Física"
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(18, 25)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(121, 20)
        Me.txtNroDoc.TabIndex = 1
        '
        'btnBuscarDni
        '
        Me.btnBuscarDni.Location = New System.Drawing.Point(145, 23)
        Me.btnBuscarDni.Name = "btnBuscarDni"
        Me.btnBuscarDni.Size = New System.Drawing.Size(49, 23)
        Me.btnBuscarDni.TabIndex = 2
        Me.btnBuscarDni.Text = "Buscar"
        Me.btnBuscarDni.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nro. Documento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(239, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nombre"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(242, 63)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(235, 20)
        Me.txtApellido.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(242, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Apellido"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage2.Controls.Add(Me.txtCuil)
        Me.TabPage2.Controls.Add(Me.btnBuscarCuit)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtNomFantasia)
        Me.TabPage2.Controls.Add(Me.txtRazonSocial)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(541, 89)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Persona Jurídica"
        '
        'btnBuscarCuit
        '
        Me.btnBuscarCuit.Location = New System.Drawing.Point(150, 22)
        Me.btnBuscarCuit.Name = "btnBuscarCuit"
        Me.btnBuscarCuit.Size = New System.Drawing.Size(49, 23)
        Me.btnBuscarCuit.TabIndex = 9
        Me.btnBuscarCuit.Text = "Buscar"
        Me.btnBuscarCuit.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "CUIT:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(244, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Razon Social"
        '
        'txtNomFantasia
        '
        Me.txtNomFantasia.Location = New System.Drawing.Point(247, 62)
        Me.txtNomFantasia.Name = "txtNomFantasia"
        Me.txtNomFantasia.Size = New System.Drawing.Size(235, 20)
        Me.txtNomFantasia.TabIndex = 11
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(247, 22)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(235, 20)
        Me.txtRazonSocial.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(244, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Nombre de Fantasia"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(312, 360)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 36)
        Me.btnQuitar.TabIndex = 26
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(231, 360)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 36)
        Me.btnAgregar.TabIndex = 25
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
        Me.Panel2.Location = New System.Drawing.Point(29, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 49)
        Me.Panel2.TabIndex = 24
        '
        'btnConsultarReservas
        '
        Me.btnConsultarReservas.Location = New System.Drawing.Point(78, 8)
        Me.btnConsultarReservas.Name = "btnConsultarReservas"
        Me.btnConsultarReservas.Size = New System.Drawing.Size(118, 32)
        Me.btnConsultarReservas.TabIndex = 15
        Me.btnConsultarReservas.Text = "Consultar Reservas"
        Me.btnConsultarReservas.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(364, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 32)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(283, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 32)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(202, 8)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 32)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.dgvReserva)
        Me.Panel1.Location = New System.Drawing.Point(29, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 113)
        Me.Panel1.TabIndex = 23
        '
        'dgvReserva
        '
        Me.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.co_nro_cancha, Me.coTipoCancha, Me.co_tipo_reserva, Me.colHoraInicio, Me.colHoraFin})
        Me.dgvReserva.Location = New System.Drawing.Point(11, 3)
        Me.dgvReserva.Name = "dgvReserva"
        Me.dgvReserva.Size = New System.Drawing.Size(531, 107)
        Me.dgvReserva.TabIndex = 0
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
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
        'colHoraInicio
        '
        Me.colHoraInicio.HeaderText = "Hora Inicio"
        Me.colHoraInicio.Name = "colHoraInicio"
        '
        'colHoraFin
        '
        Me.colHoraFin.HeaderText = "Hora Fin"
        Me.colHoraFin.Name = "colHoraFin"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpHoraFin)
        Me.GroupBox1.Controls.Add(Me.dtpHoraInicio)
        Me.GroupBox1.Controls.Add(Me.txtNroCancha)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
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
        Me.GroupBox1.Controls.Add(Me.txtNroReserva)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 222)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Reserva"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(501, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "hs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "hs"
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.CustomFormat = "HH:00"
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(399, 49)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(102, 20)
        Me.dtpHoraFin.TabIndex = 18
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.CustomFormat = "HH:00"
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(119, 49)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(109, 20)
        Me.dtpHoraInicio.TabIndex = 17
        '
        'txtNroCancha
        '
        Me.txtNroCancha.Location = New System.Drawing.Point(399, 105)
        Me.txtNroCancha.Name = "txtNroCancha"
        Me.txtNroCancha.Size = New System.Drawing.Size(98, 20)
        Me.txtNroCancha.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(326, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Nro. Cancha"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(119, 165)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(382, 44)
        Me.txtObservacion.TabIndex = 13
        '
        'btnDisponibilidad
        '
        Me.btnDisponibilidad.Location = New System.Drawing.Point(401, 76)
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
        Me.cboTipoReserva.Location = New System.Drawing.Point(119, 135)
        Me.cboTipoReserva.Name = "cboTipoReserva"
        Me.cboTipoReserva.Size = New System.Drawing.Size(143, 21)
        Me.cboTipoReserva.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Hora fin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tipo de reserva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Hora inicio"
        '
        'dtpFechaReserva
        '
        Me.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReserva.Location = New System.Drawing.Point(399, 21)
        Me.dtpFechaReserva.Name = "dtpFechaReserva"
        Me.dtpFechaReserva.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaReserva.TabIndex = 8
        '
        'cboTipoCancha
        '
        Me.cboTipoCancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCancha.FormattingEnabled = True
        Me.cboTipoCancha.Location = New System.Drawing.Point(119, 21)
        Me.cboTipoCancha.Name = "cboTipoCancha"
        Me.cboTipoCancha.Size = New System.Drawing.Size(143, 21)
        Me.cboTipoCancha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha reserva"
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(399, 134)
        Me.txtFechaSolicitud.Mask = "00/00/0000"
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaSolicitud.TabIndex = 5
        Me.txtFechaSolicitud.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de solicitud"
        '
        'txtNroReserva
        '
        Me.txtNroReserva.Enabled = False
        Me.txtNroReserva.Location = New System.Drawing.Point(119, 108)
        Me.txtNroReserva.Name = "txtNroReserva"
        Me.txtNroReserva.Size = New System.Drawing.Size(109, 20)
        Me.txtNroReserva.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo de Cancha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nª Reserva"
        '
        'txtCuil
        '
        Me.txtCuil.Location = New System.Drawing.Point(23, 24)
        Me.txtCuil.Mask = "00-00000000-0"
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(121, 20)
        Me.txtCuil.TabIndex = 12
        '
        'FrmRegistrarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 576)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRegistrarReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Reserva"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarDni As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnBuscarCuit As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNomFantasia As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnConsultarReservas As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvReserva As System.Windows.Forms.DataGridView
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents co_nro_cancha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coTipoCancha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents co_tipo_reserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroCancha As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
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
    Friend WithEvents txtNroReserva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuil As System.Windows.Forms.MaskedTextBox
End Class
