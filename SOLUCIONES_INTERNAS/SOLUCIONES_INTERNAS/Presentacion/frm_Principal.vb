Imports System.Windows.Forms

Public Class frm_Principal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public formularios As New List(Of Form)

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        'LISTA DE FORMULARIOS ABIERTOS
        Dim fr As Form
        For Each fr In Application.OpenForms
            formularios.Add(fr)
        Next
        'ABRE FORMULARIO DE INICIO DE SESION
        Dim frinicio As New FRM_INGRESO
        frinicio.Show()
        'CIERRA TODOS LOS FORMS ABIERTOS
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub

    Private Sub frm_Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AltaUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaUsuariosToolStripMenuItem.Click
        frm_Usuario.Show()
        frm_Usuario.Text = "Nuevo Usuario"
        frm_Usuario.GroupListadoUsuarios.Enabled = False
        frm_Usuario.btnActualizar_Usuario.Enabled = False
    End Sub

    Private Sub CambiarContraeñaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarContraeñaToolStripMenuItem.Click
        frm_Usuario.Show()
        frm_Usuario.Text = "Modificar Usuario"
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.btnNuevo_Usuario.Enabled = False
    End Sub

    Private Sub AltaTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaTareaToolStripMenuItem.Click
        frm_Tarea.Show()
        frm_Tarea.Text = "Nueva Tarea"
        frm_Tarea.btnImprimir.Enabled = False
    End Sub

    Private Sub ListaTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaTareaToolStripMenuItem.Click
        frm_Listado_Tareas.Show()
        frm_Listado_Tareas.Text = "Modificar Tarea"
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False
        frm_Tarea.btnImprimir.Enabled = False
        frm_Listado_Tareas.btnVer.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        frm_Cliente.Show()
        frm_Cliente.Text = "Nuevo Cliente"
        frm_Cliente.GroupListadoClientes.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = False
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        frm_Cliente.Show()
        frm_Cliente.Text = "Modificar Cliente"
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.btnNuevo_Cliente.Enabled = False
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        frm_Cliente.Show()
        frm_Cliente.Text = "Eliminar Cliente"
        frm_Cliente.GroupNuevoCliente.Enabled = False
    End Sub

    Private Sub ConsultarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarClienteToolStripMenuItem.Click
        frm_Cliente.Show()
        frm_Cliente.Text = "Consultar Cliente"
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnNuevo_Cliente.Enabled = False
        frm_Cliente.txt_razonsocial_cliente.Enabled = False
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = False
        frm_Cliente.txt_mail_cliente.Enabled = False
    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        frm_Usuario.Show()
        frm_Usuario.Text = "Eliminar Usuario"
        frm_Usuario.GroupNuevoUsuario.Enabled = False
    End Sub

    Private Sub ConsultarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarUsuarioToolStripMenuItem.Click
        frm_Usuario.Show()
        frm_Usuario.Text = "Consultar Usuario"
        frm_Usuario.btnActualizar_Usuario.Enabled = False
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnNuevo_Usuario.Enabled = False
        frm_Usuario.txt_usuario.Enabled = False
        frm_Usuario.txt_contraseña.Enabled = False
        frm_Usuario.cbo_perfil.Enabled = False
        frm_Usuario.txt_nombre_colaborador.Enabled = False
        frm_Usuario.btnBuscar_Colaborador.Enabled = False
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_gestion_usuarios.Show()
    End Sub

    Private Sub NuevoColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoColaboradorToolStripMenuItem.Click
        frm_Colaborador.Show()
        frm_Colaborador.Text = "Nuevo Colaborador"
        frm_Colaborador.GroupListadoColaboradores.Enabled = False
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
    End Sub

    Private Sub ModificarColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Show()
        frm_Colaborador.Text = "Modificar Colaborador"
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        frm_Colaborador.btnNuevo_Colaborador.Enabled = False
    End Sub

    Private Sub EliminarColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Show()
        frm_Colaborador.Text = "Eliminar Colaborador"
        frm_Colaborador.GroupNuevoColaborador.Enabled = False
    End Sub

    Private Sub ConsultarColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Show()
        frm_Colaborador.Text = "Consultar Colaborador"
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnNuevo_Colaborador.Enabled = False
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.txt_apellido_colaborador.Enabled = False
        frm_Colaborador.cbo_sector.Enabled = False
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
    End Sub

    Private Sub NuevoVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoVendedorToolStripMenuItem.Click
        frm_Vendedor.Show()
        frm_Vendedor.Text = "Nuevo Vendedor"
        frm_Vendedor.GroupListadoClientes.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
    End Sub

    Private Sub ModificarVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarVendedorToolStripMenuItem.Click
        frm_Vendedor.Show()
        frm_Vendedor.Text = "Modificar Vendedor"
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.btnNuevo_Vendedor.Enabled = False
    End Sub

    Private Sub EliminarVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarVendedorToolStripMenuItem.Click
        frm_Vendedor.Show()
        frm_Vendedor.Text = "Eliminar Vendedor"
        frm_Vendedor.GroupNuevoVendedor.Enabled = False
    End Sub

    Private Sub ConsultarVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarVendedorToolStripMenuItem.Click
        frm_Vendedor.Show()
        frm_Vendedor.Text = "Consultar Vendedor"
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnNuevo_Vendedor.Enabled = False
        frm_Vendedor.txt_nombre_vendedor.Enabled = False
        frm_Vendedor.txt_apellido_vendedor.Enabled = False
        frm_Vendedor.txt_mail_vendedor.Enabled = False
        frm_Vendedor.txt_telefono_vendedor.Enabled = False
    End Sub

    Private Sub NuevaPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaPiezaToolStripMenuItem.Click
        frm_Pieza.Show()
        frm_Pieza.Text = "Nueva Pieza"
        frm_Pieza.GroupListadoPiezas.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = False
    End Sub

    Private Sub ModificarPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarPiezaToolStripMenuItem.Click
        frm_Pieza.Show()
        frm_Pieza.Text = "Modificar Pieza"
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnEliminar_Pieza.Enabled = False
        frm_Pieza.btnNuevo_Pieza.Enabled = False
    End Sub

    Private Sub EliminarPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarPiezaToolStripMenuItem.Click
        frm_Pieza.Show()
        frm_Pieza.Text = "Eliminar Pieza"
        frm_Pieza.GroupNuevaPieza.Enabled = False
    End Sub

    Private Sub ConsultarPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarPiezaToolStripMenuItem.Click
        frm_Pieza.Show()
        frm_Pieza.Text = "Consultar Pieza"
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnEliminar_Pieza.Enabled = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnNuevo_Pieza.Enabled = False
        frm_Pieza.txt_nombre_pieza.Enabled = False
    End Sub

    Private Sub NuevoSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoSectorToolStripMenuItem.Click
        frm_Sector.Show()
        frm_Sector.Text = "Nuevo Sector"
        frm_Sector.GroupListadoSectores.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = False
    End Sub

    Private Sub ModificarSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarSectorToolStripMenuItem.Click
        frm_Sector.Show()
        frm_Sector.Text = "Modificar Sector"
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnEliminar_Sector.Enabled = False
        frm_Sector.btnNuevo_Sector.Enabled = False
    End Sub

    Private Sub EliminarSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarSectorToolStripMenuItem.Click
        frm_Sector.Show()
        frm_Sector.Text = "Eliminar Sector"
        frm_Sector.GroupNuevoSector.Enabled = False
    End Sub

    Private Sub ConsultarSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarSectorToolStripMenuItem.Click
        frm_Sector.Show()
        frm_Sector.Text = "Consultar Sector"
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnEliminar_Sector.Enabled = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnNuevo_Sector.Enabled = False
        frm_Sector.txt_nombre_sector.Enabled = False
    End Sub

    Private Sub EliminarTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarTareaToolStripMenuItem.Click
        frm_Listado_Tareas.Show()
        frm_Listado_Tareas.Text = "Eliminar Tarea"
        frm_Listado_Tareas.btnModificar_Tarea.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
        frm_Listado_Tareas.btnVer.Enabled = False
        frm_Tarea.btnImprimir.Enabled = False
    End Sub

    Private Sub TareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_Listado_Tareas.Show()
        frm_Listado_Tareas.Text = "Modificar Tarea"
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False

    End Sub

    Private Sub ConsultarTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarTareaToolStripMenuItem.Click
        frm_Listado_Tareas.Show()
        frm_Listado_Tareas.Text = "Consultar Tarea"
        frm_Listado_Tareas.btnModificar_Tarea.Enabled = False
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
    End Sub

    Private Sub NuevaOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaOrdenToolStripMenuItem.Click
        frm_Orden_Trabajo.quienllamo_listado_orden = Me
        frm_Orden_Trabajo.Show()
        frm_Orden_Trabajo.Text = "Nueva Orden"
        frm_Orden_Trabajo.btnActualizar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnImprimir.Enabled = False
    End Sub

    Private Sub OrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_Listado_Orden_Trabajo.Show()
    End Sub

    Private Sub DetalleDeOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_Listado_Orden_Trabajo.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Detalle.Enabled = False
    End Sub

    Private Sub ModificarOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarOrdenToolStripMenuItem.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Detalle.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = False
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()

    End Sub

    Private Sub EliminarOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarOrdenToolStripMenuItem.Click
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = False
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    Private Sub TareasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TareasToolStripMenuItem1.Click
        frm_Generar_Informe.Show()
    End Sub

    Private Sub NuevoRetrabajoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoRetrabajoToolStripMenuItem.Click
        frm_retrabajo.Text = "Nuevo Re-Trabajo"
        frm_retrabajo.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        frm_Listado_Retrabajo.Text = "Eliminar Re-Trabajo"
        frm_Listado_Retrabajo.btnGenerarInforme.Enabled = False
        frm_Listado_Retrabajo.btnVer.Enabled = False
        frm_Listado_Retrabajo.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        frm_Listado_Retrabajo.Text = "Consultar Re-Trabajo"
        frm_Listado_Retrabajo.btnGenerarInforme.Enabled = True
        frm_Listado_Retrabajo.btnEliminar_ReTrabajo.Enabled = False
        frm_Listado_Retrabajo.Show()
    End Sub

    Private Sub EtiquetasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EtiquetasToolStripMenuItem.Click
        frm_Etiqueta_Modelo_1.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        frm_Productos.Show()
    End Sub
End Class
