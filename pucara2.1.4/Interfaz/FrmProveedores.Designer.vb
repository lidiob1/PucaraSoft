<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbInhabilitar = New System.Windows.Forms.CheckBox()
        Me.cbHabilitar = New System.Windows.Forms.CheckBox()
        Me.lkNoexiste = New System.Windows.Forms.LinkLabel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Inhabilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Habilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CboTipoProv = New System.Windows.Forms.ComboBox()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtcod_postal = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnInhabilitar = New System.Windows.Forms.Button()
        Me.BtnHabilitar = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox3.Controls.Add(Me.cbInhabilitar)
        Me.GroupBox3.Controls.Add(Me.cbHabilitar)
        Me.GroupBox3.Controls.Add(Me.lkNoexiste)
        Me.GroupBox3.Controls.Add(Me.dgvListado)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        Me.GroupBox3.Controls.Add(Me.cmbTipo)
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(349, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(639, 337)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado"
        '
        'cbInhabilitar
        '
        Me.cbInhabilitar.AutoSize = True
        Me.cbInhabilitar.Location = New System.Drawing.Point(154, 61)
        Me.cbInhabilitar.Name = "cbInhabilitar"
        Me.cbInhabilitar.Size = New System.Drawing.Size(103, 18)
        Me.cbInhabilitar.TabIndex = 5
        Me.cbInhabilitar.Text = "Inhabilitar"
        Me.cbInhabilitar.UseVisualStyleBackColor = True
        '
        'cbHabilitar
        '
        Me.cbHabilitar.AutoSize = True
        Me.cbHabilitar.Location = New System.Drawing.Point(16, 60)
        Me.cbHabilitar.Name = "cbHabilitar"
        Me.cbHabilitar.Size = New System.Drawing.Size(89, 18)
        Me.cbHabilitar.TabIndex = 4
        Me.cbHabilitar.Text = "Habilitar"
        Me.cbHabilitar.UseVisualStyleBackColor = True
        '
        'lkNoexiste
        '
        Me.lkNoexiste.AutoSize = True
        Me.lkNoexiste.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkNoexiste.Location = New System.Drawing.Point(89, 194)
        Me.lkNoexiste.Name = "lkNoexiste"
        Me.lkNoexiste.Size = New System.Drawing.Size(147, 15)
        Me.lkNoexiste.TabIndex = 3
        Me.lkNoexiste.TabStop = True
        Me.lkNoexiste.Text = "El cliente no existe"
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Inhabilitar, Me.Habilitar})
        Me.dgvListado.Location = New System.Drawing.Point(6, 84)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(627, 248)
        Me.dgvListado.TabIndex = 2
        '
        'Inhabilitar
        '
        Me.Inhabilitar.HeaderText = "Inhabilitar"
        Me.Inhabilitar.Name = "Inhabilitar"
        Me.Inhabilitar.ReadOnly = True
        '
        'Habilitar
        '
        Me.Habilitar.HeaderText = "Habilitar"
        Me.Habilitar.Name = "Habilitar"
        Me.Habilitar.ReadOnly = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(154, 26)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(153, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"CUIT", "Razon_Social"})
        Me.cmbTipo.Location = New System.Drawing.Point(16, 27)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(93, 22)
        Me.cmbTipo.TabIndex = 0
        Me.cmbTipo.Text = "CUIT"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CboTipoProv)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAlta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtcod_postal)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtCuit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 337)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(306, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 20)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(306, 254)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(306, 227)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 20)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(306, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 20)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(306, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(306, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(306, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(306, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(306, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "*"
        '
        'CboTipoProv
        '
        Me.CboTipoProv.FormattingEnabled = True
        Me.CboTipoProv.Items.AddRange(New Object() {"Persona Juridica", "Persona Natural"})
        Me.CboTipoProv.Location = New System.Drawing.Point(117, 36)
        Me.CboTipoProv.Name = "CboTipoProv"
        Me.CboTipoProv.Size = New System.Drawing.Size(183, 22)
        Me.CboTipoProv.TabIndex = 16
        Me.CboTipoProv.Text = "Seleccione una opcion..."
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAlta.Location = New System.Drawing.Point(117, 279)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(183, 22)
        Me.dtpFechaAlta.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Tipo de Prov."
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(117, 252)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(183, 22)
        Me.dtpFechaIni.TabIndex = 50
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(117, 225)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(183, 22)
        Me.txtMail.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Fecha Alta"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(117, 198)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(183, 22)
        Me.txtCelular.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 14)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Fecha Ini Act"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(117, 171)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(183, 22)
        Me.txtTelefono.TabIndex = 13
        '
        'txtcod_postal
        '
        Me.txtcod_postal.Location = New System.Drawing.Point(117, 144)
        Me.txtcod_postal.MaxLength = 9
        Me.txtcod_postal.Name = "txtcod_postal"
        Me.txtcod_postal.Size = New System.Drawing.Size(183, 22)
        Me.txtcod_postal.TabIndex = 12
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(117, 117)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(183, 22)
        Me.txtDireccion.TabIndex = 11
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(117, 90)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(183, 22)
        Me.txtRazonSocial.TabIndex = 10
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(117, 63)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(183, 22)
        Me.txtCuit.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(76, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(55, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Celular"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(48, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(34, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cod Postal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(41, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(20, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Razon Social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(76, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuit"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox4.Controls.Add(Me.BtnCancelar)
        Me.GroupBox4.Controls.Add(Me.BtnNuevo)
        Me.GroupBox4.Controls.Add(Me.BtnEditar)
        Me.GroupBox4.Controls.Add(Me.BtnHabilitar)
        Me.GroupBox4.Controls.Add(Me.BtnGuardar)
        Me.GroupBox4.Controls.Add(Me.BtnInhabilitar)
        Me.GroupBox4.Location = New System.Drawing.Point(573, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 59)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(211, 21)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 23)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(7, 21)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(96, 23)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Location = New System.Drawing.Point(109, 21)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(96, 23)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(109, 21)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(96, 23)
        Me.BtnEditar.TabIndex = 1
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnInhabilitar
        '
        Me.BtnInhabilitar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInhabilitar.Location = New System.Drawing.Point(313, 21)
        Me.BtnInhabilitar.Name = "BtnInhabilitar"
        Me.BtnInhabilitar.Size = New System.Drawing.Size(96, 23)
        Me.BtnInhabilitar.TabIndex = 5
        Me.BtnInhabilitar.Text = "Inhabilitar"
        Me.BtnInhabilitar.UseVisualStyleBackColor = True
        '
        'BtnHabilitar
        '
        Me.BtnHabilitar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHabilitar.Location = New System.Drawing.Point(313, 21)
        Me.BtnHabilitar.Name = "BtnHabilitar"
        Me.BtnHabilitar.Size = New System.Drawing.Size(96, 23)
        Me.BtnHabilitar.TabIndex = 4
        Me.BtnHabilitar.Text = "Habilitar"
        Me.BtnHabilitar.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 431)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProveedores"
        Me.Text = "Proveedores"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lkNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents dgvListado As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_postal As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents cbInhabilitar As System.Windows.Forms.CheckBox
    Friend WithEvents cbHabilitar As System.Windows.Forms.CheckBox
    Friend WithEvents Inhabilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Habilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CboTipoProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnHabilitar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnInhabilitar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
End Class
