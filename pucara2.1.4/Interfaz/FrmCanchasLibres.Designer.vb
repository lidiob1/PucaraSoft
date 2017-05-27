<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCanchasLibres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCanchasLibres))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnTomar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvCanchasLibres = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFechaReserva = New System.Windows.Forms.TextBox()
        Me.txtTipoCancha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHoraFin = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoraInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCanchasLibres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.btnTomar)
        Me.Panel2.Location = New System.Drawing.Point(15, 291)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 47)
        Me.Panel2.TabIndex = 5
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(170, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnTomar
        '
        Me.btnTomar.Location = New System.Drawing.Point(86, 12)
        Me.btnTomar.Name = "btnTomar"
        Me.btnTomar.Size = New System.Drawing.Size(75, 23)
        Me.btnTomar.TabIndex = 0
        Me.btnTomar.Text = "Tomar"
        Me.btnTomar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.dgvCanchasLibres)
        Me.Panel1.Location = New System.Drawing.Point(14, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 146)
        Me.Panel1.TabIndex = 4
        '
        'dgvCanchasLibres
        '
        Me.dgvCanchasLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCanchasLibres.Location = New System.Drawing.Point(3, 3)
        Me.dgvCanchasLibres.Name = "dgvCanchasLibres"
        Me.dgvCanchasLibres.Size = New System.Drawing.Size(353, 140)
        Me.dgvCanchasLibres.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox1.Controls.Add(Me.txtFechaReserva)
        Me.GroupBox1.Controls.Add(Me.txtTipoCancha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHoraFin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHoraInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 111)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'txtFechaReserva
        '
        Me.txtFechaReserva.Location = New System.Drawing.Point(18, 37)
        Me.txtFechaReserva.Name = "txtFechaReserva"
        Me.txtFechaReserva.Size = New System.Drawing.Size(175, 20)
        Me.txtFechaReserva.TabIndex = 8
        '
        'txtTipoCancha
        '
        Me.txtTipoCancha.Location = New System.Drawing.Point(18, 76)
        Me.txtTipoCancha.Name = "txtTipoCancha"
        Me.txtTipoCancha.Size = New System.Drawing.Size(175, 20)
        Me.txtTipoCancha.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de cancha"
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(278, 37)
        Me.txtHoraFin.Mask = "00:00"
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(61, 20)
        Me.txtHoraFin.TabIndex = 5
        Me.txtHoraFin.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora fin"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(211, 37)
        Me.txtHoraInicio.Mask = "00:00"
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.Size = New System.Drawing.Size(61, 20)
        Me.txtHoraInicio.TabIndex = 3
        Me.txtHoraInicio.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de reserva"
        '
        'FrmCanchasLibres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(387, 353)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCanchasLibres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canchas Libres"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvCanchasLibres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnTomar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvCanchasLibres As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaReserva As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCancha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHoraFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHoraInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
