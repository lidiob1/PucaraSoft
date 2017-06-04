<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCancha
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataListado_Cancha = New System.Windows.Forms.DataGridView()
        Me.Habilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Inhabilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CbHabilitar_Cancha = New System.Windows.Forms.CheckBox()
        Me.CbInhabilitar_Cancha = New System.Windows.Forms.CheckBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groupbox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTipCancha = New System.Windows.Forms.ComboBox()
        Me.TxtNumCancha = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTPFecActPre = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblNumCancha = New System.Windows.Forms.Label()
        Me.LblTipChancha = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar_cancha = New System.Windows.Forms.Button()
        Me.BtnNuevo_cancha = New System.Windows.Forms.Button()
        Me.BtnGuardar_Cancha = New System.Windows.Forms.Button()
        Me.BtnHabilitar_cancha = New System.Windows.Forms.Button()
        Me.BtnInhabilitar_cancha = New System.Windows.Forms.Button()
        Me.BtnModificar_cancha = New System.Windows.Forms.Button()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataListado_Cancha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Red
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(10, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Marcados en color estan inhabilitados"
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(193, 91)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 40
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.DataListado_Cancha)
        Me.GroupBox1.Controls.Add(Me.CbHabilitar_Cancha)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CbInhabilitar_Cancha)
        Me.GroupBox1.Controls.Add(Me.Inexistente)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(20, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 231)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Vendedores"
        '
        'DataListado_Cancha
        '
        Me.DataListado_Cancha.AllowUserToAddRows = False
        Me.DataListado_Cancha.AllowUserToDeleteRows = False
        Me.DataListado_Cancha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado_Cancha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Habilitar, Me.Inhabilitar})
        Me.DataListado_Cancha.Location = New System.Drawing.Point(9, 43)
        Me.DataListado_Cancha.Name = "DataListado_Cancha"
        Me.DataListado_Cancha.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListado_Cancha.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataListado_Cancha.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataListado_Cancha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado_Cancha.Size = New System.Drawing.Size(414, 166)
        Me.DataListado_Cancha.TabIndex = 24
        '
        'Habilitar
        '
        Me.Habilitar.HeaderText = "Habilitar"
        Me.Habilitar.Name = "Habilitar"
        Me.Habilitar.ReadOnly = True
        '
        'Inhabilitar
        '
        Me.Inhabilitar.HeaderText = "Inhabilitar"
        Me.Inhabilitar.Name = "Inhabilitar"
        Me.Inhabilitar.ReadOnly = True
        '
        'CbHabilitar_Cancha
        '
        Me.CbHabilitar_Cancha.AutoSize = True
        Me.CbHabilitar_Cancha.Location = New System.Drawing.Point(146, 19)
        Me.CbHabilitar_Cancha.Name = "CbHabilitar_Cancha"
        Me.CbHabilitar_Cancha.Size = New System.Drawing.Size(64, 17)
        Me.CbHabilitar_Cancha.TabIndex = 23
        Me.CbHabilitar_Cancha.Text = "Habilitar"
        Me.CbHabilitar_Cancha.UseVisualStyleBackColor = True
        '
        'CbInhabilitar_Cancha
        '
        Me.CbInhabilitar_Cancha.AutoSize = True
        Me.CbInhabilitar_Cancha.Location = New System.Drawing.Point(21, 20)
        Me.CbInhabilitar_Cancha.Name = "CbInhabilitar_Cancha"
        Me.CbInhabilitar_Cancha.Size = New System.Drawing.Size(71, 17)
        Me.CbInhabilitar_Cancha.TabIndex = 22
        Me.CbInhabilitar_Cancha.Text = "Inhabilitar"
        Me.CbInhabilitar_Cancha.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'groupbox2
        '
        Me.groupbox2.BackColor = System.Drawing.Color.LightGreen
        Me.groupbox2.Controls.Add(Me.Label2)
        Me.groupbox2.Controls.Add(Me.TxtPrecio)
        Me.groupbox2.Controls.Add(Me.Label1)
        Me.groupbox2.Controls.Add(Me.CBTipCancha)
        Me.groupbox2.Controls.Add(Me.TxtNumCancha)
        Me.groupbox2.Controls.Add(Me.Label10)
        Me.groupbox2.Controls.Add(Me.Label9)
        Me.groupbox2.Controls.Add(Me.DTPFecActPre)
        Me.groupbox2.Controls.Add(Me.Label6)
        Me.groupbox2.Controls.Add(Me.LblNumCancha)
        Me.groupbox2.Controls.Add(Me.LblTipChancha)
        Me.groupbox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupbox2.Location = New System.Drawing.Point(20, 12)
        Me.groupbox2.Name = "groupbox2"
        Me.groupbox2.Size = New System.Drawing.Size(429, 112)
        Me.groupbox2.TabIndex = 44
        Me.groupbox2.TabStop = False
        Me.groupbox2.Text = "Cancha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(362, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "*"
        '
        'CBTipCancha
        '
        Me.CBTipCancha.FormattingEnabled = True
        Me.CBTipCancha.Items.AddRange(New Object() {"5 Vs 5", "7 Vs 7", "9 Vs 9", "11 Vs 11"})
        Me.CBTipCancha.Location = New System.Drawing.Point(166, 54)
        Me.CBTipCancha.Name = "CBTipCancha"
        Me.CBTipCancha.Size = New System.Drawing.Size(191, 21)
        Me.CBTipCancha.TabIndex = 41
        Me.CBTipCancha.Text = "...Seleccione una opcion..."
        '
        'TxtNumCancha
        '
        Me.TxtNumCancha.Enabled = False
        Me.TxtNumCancha.Location = New System.Drawing.Point(166, 25)
        Me.TxtNumCancha.Name = "TxtNumCancha"
        Me.TxtNumCancha.Size = New System.Drawing.Size(191, 20)
        Me.TxtNumCancha.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(363, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(363, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "*"
        '
        'DTPFecActPre
        '
        Me.DTPFecActPre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecActPre.Location = New System.Drawing.Point(150, 118)
        Me.DTPFecActPre.Name = "DTPFecActPre"
        Me.DTPFecActPre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTPFecActPre.Size = New System.Drawing.Size(118, 20)
        Me.DTPFecActPre.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Precio"
        '
        'LblNumCancha
        '
        Me.LblNumCancha.AutoSize = True
        Me.LblNumCancha.Location = New System.Drawing.Point(61, 30)
        Me.LblNumCancha.Name = "LblNumCancha"
        Me.LblNumCancha.Size = New System.Drawing.Size(99, 13)
        Me.LblNumCancha.TabIndex = 31
        Me.LblNumCancha.Text = "Numero de Cancha"
        '
        'LblTipChancha
        '
        Me.LblTipChancha.AutoSize = True
        Me.LblTipChancha.Location = New System.Drawing.Point(77, 56)
        Me.LblTipChancha.Name = "LblTipChancha"
        Me.LblTipChancha.Size = New System.Drawing.Size(83, 13)
        Me.LblTipChancha.TabIndex = 30
        Me.LblTipChancha.Text = "Tipo de Cancha"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox3.Controls.Add(Me.BtnCancelar_cancha)
        Me.GroupBox3.Controls.Add(Me.BtnNuevo_cancha)
        Me.GroupBox3.Controls.Add(Me.BtnGuardar_Cancha)
        Me.GroupBox3.Controls.Add(Me.BtnHabilitar_cancha)
        Me.GroupBox3.Controls.Add(Me.BtnInhabilitar_cancha)
        Me.GroupBox3.Controls.Add(Me.BtnModificar_cancha)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 65)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        '
        'BtnCancelar_cancha
        '
        Me.BtnCancelar_cancha.Location = New System.Drawing.Point(231, 19)
        Me.BtnCancelar_cancha.Name = "BtnCancelar_cancha"
        Me.BtnCancelar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancelar_cancha.TabIndex = 23
        Me.BtnCancelar_cancha.Text = "Cancelar"
        Me.BtnCancelar_cancha.UseVisualStyleBackColor = True
        '
        'BtnNuevo_cancha
        '
        Me.BtnNuevo_cancha.Location = New System.Drawing.Point(69, 19)
        Me.BtnNuevo_cancha.Name = "BtnNuevo_cancha"
        Me.BtnNuevo_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnNuevo_cancha.TabIndex = 20
        Me.BtnNuevo_cancha.Text = "Nuevo"
        Me.BtnNuevo_cancha.UseVisualStyleBackColor = True
        '
        'BtnGuardar_Cancha
        '
        Me.BtnGuardar_Cancha.Location = New System.Drawing.Point(150, 19)
        Me.BtnGuardar_Cancha.Name = "BtnGuardar_Cancha"
        Me.BtnGuardar_Cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnGuardar_Cancha.TabIndex = 22
        Me.BtnGuardar_Cancha.Text = "Guardar"
        Me.BtnGuardar_Cancha.UseVisualStyleBackColor = True
        '
        'BtnHabilitar_cancha
        '
        Me.BtnHabilitar_cancha.Location = New System.Drawing.Point(312, 19)
        Me.BtnHabilitar_cancha.Name = "BtnHabilitar_cancha"
        Me.BtnHabilitar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnHabilitar_cancha.TabIndex = 25
        Me.BtnHabilitar_cancha.Text = "Habilitar"
        Me.BtnHabilitar_cancha.UseVisualStyleBackColor = True
        '
        'BtnInhabilitar_cancha
        '
        Me.BtnInhabilitar_cancha.Location = New System.Drawing.Point(312, 19)
        Me.BtnInhabilitar_cancha.Name = "BtnInhabilitar_cancha"
        Me.BtnInhabilitar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnInhabilitar_cancha.TabIndex = 24
        Me.BtnInhabilitar_cancha.Text = "Inhabilitar"
        Me.BtnInhabilitar_cancha.UseVisualStyleBackColor = True
        '
        'BtnModificar_cancha
        '
        Me.BtnModificar_cancha.Location = New System.Drawing.Point(150, 19)
        Me.BtnModificar_cancha.Name = "BtnModificar_cancha"
        Me.BtnModificar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnModificar_cancha.TabIndex = 21
        Me.BtnModificar_cancha.Text = "Modificar"
        Me.BtnModificar_cancha.UseVisualStyleBackColor = True
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(166, 82)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(110, 20)
        Me.TxtPrecio.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "$"
        '
        'FrmCancha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(470, 448)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupbox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCancha"
        Me.Text = "Cancha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataListado_Cancha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox2.ResumeLayout(False)
        Me.groupbox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbHabilitar_Cancha As System.Windows.Forms.CheckBox
    Friend WithEvents CbInhabilitar_Cancha As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInhabilitar_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnModificar_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar_Cancha As System.Windows.Forms.Button
    Friend WithEvents BtnHabilitar_cancha As System.Windows.Forms.Button
    Friend WithEvents groupbox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBTipCancha As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNumCancha As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DTPFecActPre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblNumCancha As System.Windows.Forms.Label
    Friend WithEvents LblTipChancha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataListado_Cancha As System.Windows.Forms.DataGridView
    Friend WithEvents Habilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Inhabilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
End Class
