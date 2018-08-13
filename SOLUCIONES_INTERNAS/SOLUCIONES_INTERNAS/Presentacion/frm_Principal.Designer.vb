<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraeñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LBL_MENU_PERFIL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_MENU_USU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AltaColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.ColaboradorToolStripMenuItem, Me.VendedorToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.PiezaToolStripMenuItem, Me.SectorToolStripMenuItem, Me.TareasToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.ClienteToolStripMenuItem
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1360, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaUsuariosToolStripMenuItem, Me.CambiarContraeñaToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem, Me.ConsultarUsuarioToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'AltaUsuariosToolStripMenuItem
        '
        Me.AltaUsuariosToolStripMenuItem.Name = "AltaUsuariosToolStripMenuItem"
        Me.AltaUsuariosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AltaUsuariosToolStripMenuItem.Text = "Alta Usuarios"
        '
        'CambiarContraeñaToolStripMenuItem
        '
        Me.CambiarContraeñaToolStripMenuItem.Name = "CambiarContraeñaToolStripMenuItem"
        Me.CambiarContraeñaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CambiarContraeñaToolStripMenuItem.Text = "Cambiar Contraeña"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario"
        '
        'ConsultarUsuarioToolStripMenuItem
        '
        Me.ConsultarUsuarioToolStripMenuItem.Name = "ConsultarUsuarioToolStripMenuItem"
        Me.ConsultarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConsultarUsuarioToolStripMenuItem.Text = "Consultar Usuario"
        '
        'ColaboradorToolStripMenuItem
        '
        Me.ColaboradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaColaboradorToolStripMenuItem, Me.ListaColaboradorToolStripMenuItem})
        Me.ColaboradorToolStripMenuItem.Name = "ColaboradorToolStripMenuItem"
        Me.ColaboradorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ColaboradorToolStripMenuItem.Text = "Colaborador"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaVendedorToolStripMenuItem, Me.ListaVendedorToolStripMenuItem})
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaClienteToolStripMenuItem, Me.ListaClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'PiezaToolStripMenuItem
        '
        Me.PiezaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPiezaToolStripMenuItem, Me.ListaPiezaToolStripMenuItem})
        Me.PiezaToolStripMenuItem.Name = "PiezaToolStripMenuItem"
        Me.PiezaToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.PiezaToolStripMenuItem.Text = "Pieza"
        '
        'SectorToolStripMenuItem
        '
        Me.SectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaSectorToolStripMenuItem, Me.ListaSectorToolStripMenuItem})
        Me.SectorToolStripMenuItem.Name = "SectorToolStripMenuItem"
        Me.SectorToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SectorToolStripMenuItem.Text = "Sector"
        '
        'TareasToolStripMenuItem
        '
        Me.TareasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaTareaToolStripMenuItem, Me.ListaTareaToolStripMenuItem})
        Me.TareasToolStripMenuItem.Name = "TareasToolStripMenuItem"
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.TareasToolStripMenuItem.Text = "Tareas"
        '
        'LBL_MENU_PERFIL
        '
        Me.LBL_MENU_PERFIL.AutoSize = True
        Me.LBL_MENU_PERFIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU_PERFIL.Location = New System.Drawing.Point(38, 23)
        Me.LBL_MENU_PERFIL.Name = "LBL_MENU_PERFIL"
        Me.LBL_MENU_PERFIL.Size = New System.Drawing.Size(27, 9)
        Me.LBL_MENU_PERFIL.TabIndex = 12
        Me.LBL_MENU_PERFIL.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 9)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Perfil:"
        '
        'LBL_MENU_USU
        '
        Me.LBL_MENU_USU.AutoSize = True
        Me.LBL_MENU_USU.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU_USU.Location = New System.Drawing.Point(38, 12)
        Me.LBL_MENU_USU.Name = "LBL_MENU_USU"
        Me.LBL_MENU_USU.Size = New System.Drawing.Size(27, 9)
        Me.LBL_MENU_USU.TabIndex = 11
        Me.LBL_MENU_USU.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 9)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_MENU_PERFIL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LBL_MENU_USU)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 723)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1360, 38)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'AltaColaboradorToolStripMenuItem
        '
        Me.AltaColaboradorToolStripMenuItem.Name = "AltaColaboradorToolStripMenuItem"
        Me.AltaColaboradorToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AltaColaboradorToolStripMenuItem.Text = "Alta Colaborador"
        '
        'ListaColaboradorToolStripMenuItem
        '
        Me.ListaColaboradorToolStripMenuItem.Name = "ListaColaboradorToolStripMenuItem"
        Me.ListaColaboradorToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ListaColaboradorToolStripMenuItem.Text = "Lista Colaborador"
        '
        'AltaVendedorToolStripMenuItem
        '
        Me.AltaVendedorToolStripMenuItem.Name = "AltaVendedorToolStripMenuItem"
        Me.AltaVendedorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaVendedorToolStripMenuItem.Text = "Alta Vendedor"
        '
        'ListaVendedorToolStripMenuItem
        '
        Me.ListaVendedorToolStripMenuItem.Name = "ListaVendedorToolStripMenuItem"
        Me.ListaVendedorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListaVendedorToolStripMenuItem.Text = "Lista Vendedor"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        '
        'ListaClienteToolStripMenuItem
        '
        Me.ListaClienteToolStripMenuItem.Name = "ListaClienteToolStripMenuItem"
        Me.ListaClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListaClienteToolStripMenuItem.Text = "Lista Cliente"
        '
        'AltaPiezaToolStripMenuItem
        '
        Me.AltaPiezaToolStripMenuItem.Name = "AltaPiezaToolStripMenuItem"
        Me.AltaPiezaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaPiezaToolStripMenuItem.Text = "Alta Pieza"
        '
        'ListaPiezaToolStripMenuItem
        '
        Me.ListaPiezaToolStripMenuItem.Name = "ListaPiezaToolStripMenuItem"
        Me.ListaPiezaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListaPiezaToolStripMenuItem.Text = "Lista Pieza"
        '
        'AltaSectorToolStripMenuItem
        '
        Me.AltaSectorToolStripMenuItem.Name = "AltaSectorToolStripMenuItem"
        Me.AltaSectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaSectorToolStripMenuItem.Text = "Alta Sector"
        '
        'ListaSectorToolStripMenuItem
        '
        Me.ListaSectorToolStripMenuItem.Name = "ListaSectorToolStripMenuItem"
        Me.ListaSectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListaSectorToolStripMenuItem.Text = "Lista Sector"
        '
        'AltaTareaToolStripMenuItem
        '
        Me.AltaTareaToolStripMenuItem.Name = "AltaTareaToolStripMenuItem"
        Me.AltaTareaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaTareaToolStripMenuItem.Text = "Alta Tarea"
        '
        'ListaTareaToolStripMenuItem
        '
        Me.ListaTareaToolStripMenuItem.Name = "ListaTareaToolStripMenuItem"
        Me.ListaTareaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListaTareaToolStripMenuItem.Text = "Lista Tarea"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 762)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frm_Principal"
        Me.Text = "frm_Principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBL_MENU_PERFIL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBL_MENU_USU As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AltaUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraeñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
