<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemRegistrarClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanchasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarCanchasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.ProveedoresToolStripMenuItem, Me.menuVentas, Me.CobroToolStripMenuItem, Me.AdministracionToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemSalir})
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuArchivo.Text = "Archivo"
        '
        'menuItemSalir
        '
        Me.menuItemSalir.Name = "menuItemSalir"
        Me.menuItemSalir.Size = New System.Drawing.Size(152, 22)
        Me.menuItemSalir.Text = "Salir"
        '
        'menuVentas
        '
        Me.menuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemRegistrarClientes})
        Me.menuVentas.Name = "menuVentas"
        Me.menuVentas.Size = New System.Drawing.Size(54, 20)
        Me.menuVentas.Text = "Ventas"
        '
        'menuItemRegistrarClientes
        '
        Me.menuItemRegistrarClientes.Name = "menuItemRegistrarClientes"
        Me.menuItemRegistrarClientes.Size = New System.Drawing.Size(165, 22)
        Me.menuItemRegistrarClientes.Text = "Registrar Clientes"
        '
        'CobroToolStripMenuItem
        '
        Me.CobroToolStripMenuItem.Name = "CobroToolStripMenuItem"
        Me.CobroToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.CobroToolStripMenuItem.Text = "Cobro"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CanchasToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administración"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'CanchasToolStripMenuItem
        '
        Me.CanchasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarCanchasToolStripMenuItem, Me.RegistrarReservasToolStripMenuItem, Me.ModificarReservaToolStripMenuItem})
        Me.CanchasToolStripMenuItem.Name = "CanchasToolStripMenuItem"
        Me.CanchasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CanchasToolStripMenuItem.Text = "Canchas"
        '
        'RegistrarCanchasToolStripMenuItem
        '
        Me.RegistrarCanchasToolStripMenuItem.Name = "RegistrarCanchasToolStripMenuItem"
        Me.RegistrarCanchasToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RegistrarCanchasToolStripMenuItem.Text = "Registrar Canchas"
        '
        'RegistrarReservasToolStripMenuItem
        '
        Me.RegistrarReservasToolStripMenuItem.Name = "RegistrarReservasToolStripMenuItem"
        Me.RegistrarReservasToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RegistrarReservasToolStripMenuItem.Text = "Registrar Reservas"
        '
        'ModificarReservaToolStripMenuItem
        '
        Me.ModificarReservaToolStripMenuItem.Name = "ModificarReservaToolStripMenuItem"
        Me.ModificarReservaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ModificarReservaToolStripMenuItem.Text = "Modificar Reservas"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Compras"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "FrmMenu"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemRegistrarClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CobroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanchasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarCanchasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarReservaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
