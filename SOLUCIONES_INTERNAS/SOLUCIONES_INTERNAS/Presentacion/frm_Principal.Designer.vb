﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.NuevoColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarColaboradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarTareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReTrabajoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoRetrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LBL_MENU_PERFIL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_MENU_USU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.ColaboradorToolStripMenuItem, Me.VendedorToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.PiezaToolStripMenuItem, Me.SectorToolStripMenuItem, Me.TareasToolStripMenuItem, Me.OrdenTrabajoToolStripMenuItem, Me.ReTrabajoToolStripMenuItem1, Me.GenerarInformesToolStripMenuItem})
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
        Me.AltaUsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaUsuariosToolStripMenuItem.Text = "Nuevo"
        '
        'CambiarContraeñaToolStripMenuItem
        '
        Me.CambiarContraeñaToolStripMenuItem.Name = "CambiarContraeñaToolStripMenuItem"
        Me.CambiarContraeñaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CambiarContraeñaToolStripMenuItem.Text = "Modificar"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarUsuarioToolStripMenuItem
        '
        Me.ConsultarUsuarioToolStripMenuItem.Name = "ConsultarUsuarioToolStripMenuItem"
        Me.ConsultarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarUsuarioToolStripMenuItem.Text = "Consultar"
        '
        'ColaboradorToolStripMenuItem
        '
        Me.ColaboradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoColaboradorToolStripMenuItem, Me.ModificarColaboradorToolStripMenuItem, Me.EliminarColaboradorToolStripMenuItem, Me.ConsultarColaboradorToolStripMenuItem})
        Me.ColaboradorToolStripMenuItem.Name = "ColaboradorToolStripMenuItem"
        Me.ColaboradorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ColaboradorToolStripMenuItem.Text = "Colaborador"
        '
        'NuevoColaboradorToolStripMenuItem
        '
        Me.NuevoColaboradorToolStripMenuItem.Name = "NuevoColaboradorToolStripMenuItem"
        Me.NuevoColaboradorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoColaboradorToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarColaboradorToolStripMenuItem
        '
        Me.ModificarColaboradorToolStripMenuItem.Name = "ModificarColaboradorToolStripMenuItem"
        Me.ModificarColaboradorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarColaboradorToolStripMenuItem.Text = "Modificar"
        '
        'EliminarColaboradorToolStripMenuItem
        '
        Me.EliminarColaboradorToolStripMenuItem.Name = "EliminarColaboradorToolStripMenuItem"
        Me.EliminarColaboradorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarColaboradorToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarColaboradorToolStripMenuItem
        '
        Me.ConsultarColaboradorToolStripMenuItem.Name = "ConsultarColaboradorToolStripMenuItem"
        Me.ConsultarColaboradorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarColaboradorToolStripMenuItem.Text = "Consultar"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoVendedorToolStripMenuItem, Me.ModificarVendedorToolStripMenuItem, Me.EliminarVendedorToolStripMenuItem, Me.ConsultarVendedorToolStripMenuItem})
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'NuevoVendedorToolStripMenuItem
        '
        Me.NuevoVendedorToolStripMenuItem.Name = "NuevoVendedorToolStripMenuItem"
        Me.NuevoVendedorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoVendedorToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarVendedorToolStripMenuItem
        '
        Me.ModificarVendedorToolStripMenuItem.Name = "ModificarVendedorToolStripMenuItem"
        Me.ModificarVendedorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarVendedorToolStripMenuItem.Text = "Modificar"
        '
        'EliminarVendedorToolStripMenuItem
        '
        Me.EliminarVendedorToolStripMenuItem.Name = "EliminarVendedorToolStripMenuItem"
        Me.EliminarVendedorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarVendedorToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarVendedorToolStripMenuItem
        '
        Me.ConsultarVendedorToolStripMenuItem.Name = "ConsultarVendedorToolStripMenuItem"
        Me.ConsultarVendedorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarVendedorToolStripMenuItem.Text = "Consultar"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem, Me.ConsultarClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarClienteToolStripMenuItem
        '
        Me.ConsultarClienteToolStripMenuItem.Name = "ConsultarClienteToolStripMenuItem"
        Me.ConsultarClienteToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarClienteToolStripMenuItem.Text = "Consultar"
        '
        'PiezaToolStripMenuItem
        '
        Me.PiezaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPiezaToolStripMenuItem, Me.ModificarPiezaToolStripMenuItem, Me.EliminarPiezaToolStripMenuItem, Me.ConsultarPiezaToolStripMenuItem})
        Me.PiezaToolStripMenuItem.Name = "PiezaToolStripMenuItem"
        Me.PiezaToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.PiezaToolStripMenuItem.Text = "Pieza"
        '
        'NuevaPiezaToolStripMenuItem
        '
        Me.NuevaPiezaToolStripMenuItem.Name = "NuevaPiezaToolStripMenuItem"
        Me.NuevaPiezaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevaPiezaToolStripMenuItem.Text = "Nueva"
        '
        'ModificarPiezaToolStripMenuItem
        '
        Me.ModificarPiezaToolStripMenuItem.Name = "ModificarPiezaToolStripMenuItem"
        Me.ModificarPiezaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarPiezaToolStripMenuItem.Text = "Modificar"
        '
        'EliminarPiezaToolStripMenuItem
        '
        Me.EliminarPiezaToolStripMenuItem.Name = "EliminarPiezaToolStripMenuItem"
        Me.EliminarPiezaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarPiezaToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarPiezaToolStripMenuItem
        '
        Me.ConsultarPiezaToolStripMenuItem.Name = "ConsultarPiezaToolStripMenuItem"
        Me.ConsultarPiezaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarPiezaToolStripMenuItem.Text = "Consultar"
        '
        'SectorToolStripMenuItem
        '
        Me.SectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoSectorToolStripMenuItem, Me.ModificarSectorToolStripMenuItem, Me.EliminarSectorToolStripMenuItem, Me.ConsultarSectorToolStripMenuItem})
        Me.SectorToolStripMenuItem.Name = "SectorToolStripMenuItem"
        Me.SectorToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SectorToolStripMenuItem.Text = "Sector"
        '
        'NuevoSectorToolStripMenuItem
        '
        Me.NuevoSectorToolStripMenuItem.Name = "NuevoSectorToolStripMenuItem"
        Me.NuevoSectorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoSectorToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarSectorToolStripMenuItem
        '
        Me.ModificarSectorToolStripMenuItem.Name = "ModificarSectorToolStripMenuItem"
        Me.ModificarSectorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarSectorToolStripMenuItem.Text = "Modificar"
        '
        'EliminarSectorToolStripMenuItem
        '
        Me.EliminarSectorToolStripMenuItem.Name = "EliminarSectorToolStripMenuItem"
        Me.EliminarSectorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarSectorToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarSectorToolStripMenuItem
        '
        Me.ConsultarSectorToolStripMenuItem.Name = "ConsultarSectorToolStripMenuItem"
        Me.ConsultarSectorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarSectorToolStripMenuItem.Text = "Consultar"
        '
        'TareasToolStripMenuItem
        '
        Me.TareasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaTareaToolStripMenuItem, Me.ListaTareaToolStripMenuItem, Me.EliminarTareaToolStripMenuItem, Me.ConsultarTareaToolStripMenuItem})
        Me.TareasToolStripMenuItem.Name = "TareasToolStripMenuItem"
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.TareasToolStripMenuItem.Text = "Tarea"
        '
        'AltaTareaToolStripMenuItem
        '
        Me.AltaTareaToolStripMenuItem.Name = "AltaTareaToolStripMenuItem"
        Me.AltaTareaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AltaTareaToolStripMenuItem.Text = "Nueva"
        '
        'ListaTareaToolStripMenuItem
        '
        Me.ListaTareaToolStripMenuItem.Name = "ListaTareaToolStripMenuItem"
        Me.ListaTareaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ListaTareaToolStripMenuItem.Text = "Modificar"
        '
        'EliminarTareaToolStripMenuItem
        '
        Me.EliminarTareaToolStripMenuItem.Name = "EliminarTareaToolStripMenuItem"
        Me.EliminarTareaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarTareaToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarTareaToolStripMenuItem
        '
        Me.ConsultarTareaToolStripMenuItem.Name = "ConsultarTareaToolStripMenuItem"
        Me.ConsultarTareaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarTareaToolStripMenuItem.Text = "Consultar"
        '
        'OrdenTrabajoToolStripMenuItem
        '
        Me.OrdenTrabajoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaOrdenToolStripMenuItem, Me.ModificarOrdenToolStripMenuItem, Me.EliminarOrdenToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.OrdenTrabajoToolStripMenuItem.Name = "OrdenTrabajoToolStripMenuItem"
        Me.OrdenTrabajoToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.OrdenTrabajoToolStripMenuItem.Text = "Orden Trabajo"
        '
        'NuevaOrdenToolStripMenuItem
        '
        Me.NuevaOrdenToolStripMenuItem.Name = "NuevaOrdenToolStripMenuItem"
        Me.NuevaOrdenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevaOrdenToolStripMenuItem.Text = "Nueva"
        '
        'ModificarOrdenToolStripMenuItem
        '
        Me.ModificarOrdenToolStripMenuItem.Name = "ModificarOrdenToolStripMenuItem"
        Me.ModificarOrdenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarOrdenToolStripMenuItem.Text = "Modificar"
        '
        'EliminarOrdenToolStripMenuItem
        '
        Me.EliminarOrdenToolStripMenuItem.Name = "EliminarOrdenToolStripMenuItem"
        Me.EliminarOrdenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarOrdenToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ReTrabajoToolStripMenuItem1
        '
        Me.ReTrabajoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoRetrabajoToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ConsultarToolStripMenuItem1})
        Me.ReTrabajoToolStripMenuItem1.Name = "ReTrabajoToolStripMenuItem1"
        Me.ReTrabajoToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.ReTrabajoToolStripMenuItem1.Text = "Re-Trabajo"
        '
        'NuevoRetrabajoToolStripMenuItem
        '
        Me.NuevoRetrabajoToolStripMenuItem.Name = "NuevoRetrabajoToolStripMenuItem"
        Me.NuevoRetrabajoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoRetrabajoToolStripMenuItem.Text = "Nuevo"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar"
        '
        'GenerarInformesToolStripMenuItem
        '
        Me.GenerarInformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TareasToolStripMenuItem1, Me.OrdenDeTrabajoToolStripMenuItem, Me.ReTrabajoToolStripMenuItem})
        Me.GenerarInformesToolStripMenuItem.Name = "GenerarInformesToolStripMenuItem"
        Me.GenerarInformesToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.GenerarInformesToolStripMenuItem.Text = "Generar Informes"
        '
        'TareasToolStripMenuItem1
        '
        Me.TareasToolStripMenuItem1.Name = "TareasToolStripMenuItem1"
        Me.TareasToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.TareasToolStripMenuItem1.Text = "Tareas"
        '
        'OrdenDeTrabajoToolStripMenuItem
        '
        Me.OrdenDeTrabajoToolStripMenuItem.Name = "OrdenDeTrabajoToolStripMenuItem"
        Me.OrdenDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OrdenDeTrabajoToolStripMenuItem.Text = "Orden de Trabajo"
        '
        'ReTrabajoToolStripMenuItem
        '
        Me.ReTrabajoToolStripMenuItem.Name = "ReTrabajoToolStripMenuItem"
        Me.ReTrabajoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ReTrabajoToolStripMenuItem.Text = "Re-Trabajo"
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 724)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1360, 38)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
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
        Me.Text = "Menú Principal"
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
    Friend WithEvents AltaTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarTareaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarColaboradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarPiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaOrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarOrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarOrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarInformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReTrabajoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoRetrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
