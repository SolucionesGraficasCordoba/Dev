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
        frinicio.ShowDialog()
        'CIERRA TODOS LOS FORMS ABIERTOS
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub

    Private Sub AltaUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaUsuariosToolStripMenuItem.Click

        frm_Usuario.Text = "Nuevo Usuario"
        frm_Usuario.txt_usuario.Clear()
        frm_Usuario.txt_contraseña.Clear()
        frm_Usuario.cbo_perfil.SelectedIndex = -1
        frm_Usuario.btnActualizar_Usuario.Enabled = False
        frm_Usuario.btnGuardar_Usuario.Enabled = True
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.txt_usuario.Enabled = True
        frm_Usuario.txt_contraseña.Enabled = True
        frm_Usuario.cbo_perfil.Enabled = True
        frm_Usuario.btnBuscar_Colaborador.Enabled = True
        frm_Usuario.GroupListadoUsuarios.Enabled = False

        frm_Usuario.dgvLista_Usuarios.ClearSelection()
        frm_Usuario.ShowDialog()
    End Sub

    Private Sub CambiarContraeñaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarContraeñaToolStripMenuItem.Click

        frm_Usuario.Text = "Modificar Usuario"
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnActualizar_Usuario.Enabled = True
        frm_Usuario.btnEliminar_Usuario.Enabled = False
        frm_Usuario.btnNuevo_Usuario.Enabled = False
        frm_Usuario.txt_usuario.Enabled = True
        frm_Usuario.txt_contraseña.Enabled = True
        frm_Usuario.cbo_perfil.Enabled = True
        frm_Usuario.btnBuscar_Colaborador.Enabled = True
        frm_Usuario.dgvLista_Usuarios.ClearSelection()
        frm_Usuario.ShowDialog()
    End Sub

    Private Sub AltaTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaTareaToolStripMenuItem.Click
        frm_Tarea.ShowDialog()
        frm_Tarea.Text = "Nueva Tarea"
        frm_Tarea.btnImprimir.Enabled = False
    End Sub

    Private Sub ListaTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaTareaToolStripMenuItem.Click
        frm_Listado_Tareas.ShowDialog()
        frm_Listado_Tareas.Text = "Modificar Tarea"
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False
        frm_Tarea.btnImprimir.Enabled = False
        frm_Listado_Tareas.btnVer.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        
        frm_Cliente.Text = "Nuevo Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = True
        frm_Cliente.txt_mail_cliente.Enabled = True
        frm_Cliente.txt_Domicilio_Cliente.Enabled = True
        frm_Cliente.txt_Localidad_Cliente.Enabled = True
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = True
        frm_Cliente.txtTelefono_Cliente.Enabled = True

        frm_Cliente.txt_Buscar_Cliente.Enabled = False

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = True
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = False

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Modificar Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = True
        frm_Cliente.txt_mail_cliente.Enabled = True
        frm_Cliente.txt_Domicilio_Cliente.Enabled = True
        frm_Cliente.txt_Localidad_Cliente.Enabled = True
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = True
        frm_Cliente.txtTelefono_Cliente.Enabled = True

        frm_Cliente.txt_Buscar_Cliente.Enabled = True

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = True
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = False

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Eliminar Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = False
        frm_Cliente.txt_mail_cliente.Enabled = False
        frm_Cliente.txt_Domicilio_Cliente.Enabled = False
        frm_Cliente.txt_Localidad_Cliente.Enabled = False
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = False
        frm_Cliente.txtTelefono_Cliente.Enabled = False

        frm_Cliente.txt_Buscar_Cliente.Enabled = True

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = True

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()
    End Sub

    Private Sub ConsultarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarClienteToolStripMenuItem.Click

        frm_Cliente.Text = "Consultar Cliente"
        frm_Cliente.txt_razonsocial_cliente.Clear()
        frm_Cliente.txt_mail_cliente.Clear()
        frm_Cliente.txt_Domicilio_Cliente.Clear()
        frm_Cliente.txt_Localidad_Cliente.Clear()
        frm_Cliente.txt_Codigo_Postal_Cliente.Clear()
        frm_Cliente.txtTelefono_Cliente.Clear()

        frm_Cliente.txt_razonsocial_cliente.Enabled = False
        frm_Cliente.txt_mail_cliente.Enabled = False
        frm_Cliente.txt_Domicilio_Cliente.Enabled = False
        frm_Cliente.txt_Localidad_Cliente.Enabled = False
        frm_Cliente.txt_Codigo_Postal_Cliente.Enabled = False
        frm_Cliente.txtTelefono_Cliente.Enabled = False

        frm_Cliente.txt_Buscar_Cliente.Enabled = True

        frm_Cliente.btnNuevo_Cliente.Visible = False
        frm_Cliente.btnGuardar_Cliente.Enabled = False
        frm_Cliente.btnActualizar_Cliente.Enabled = False
        frm_Cliente.btnCancelar_Cliente.Enabled = True
        frm_Cliente.btnEliminar_Cliente.Enabled = False

        frm_Cliente.dgvLista_Clientes.ClearSelection()
        frm_Cliente.dgvLista_Clientes.Enabled = False

        frm_Cliente.ShowDialog()

    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        frm_Usuario.Text = "Eliminar Usuario"
        frm_Usuario.GroupListadoUsuarios.Enabled = True
        frm_Usuario.btnActualizar_Usuario.Enabled = False
        frm_Usuario.btnGuardar_Usuario.Enabled = False
        frm_Usuario.btnCancelar_Usuario.Enabled = True
        frm_Usuario.txt_usuario.Enabled = False
        frm_Usuario.txt_contraseña.Enabled = False
        frm_Usuario.cbo_perfil.Enabled = False
        frm_Usuario.btnBuscar_Colaborador.Enabled = False
        frm_Usuario.ShowDialog()
    End Sub

    Private Sub ConsultarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarUsuarioToolStripMenuItem.Click

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
        frm_Usuario.dgvLista_Usuarios.ClearSelection()
        frm_Usuario.ShowDialog()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_gestion_usuarios.ShowDialog()
    End Sub

    Private Sub NuevoColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoColaboradorToolStripMenuItem.Click
        frm_Colaborador.Text = "Nuevo Colaborador"
        frm_Colaborador.txt_nombre_colaborador.Focus()
        frm_Colaborador.txt_nombre_colaborador.Clear()
        frm_Colaborador.txt_apellido_colaborador.Clear()
        frm_Colaborador.cbo_sector.SelectedIndex = -1
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = True
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
        frm_Colaborador.btnCancelar_Colaborador.Enabled = True
        frm_Colaborador.Button1.Visible = False
        frm_Colaborador.txt_Buscar_Colaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False

        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()
        frm_Colaborador.dgvLista_Colaboradores.Enabled = False
        frm_Colaborador.GroupListadoColaboradores.Enabled = False
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub ModificarColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Text = "Modificar Colaborador"
        frm_Colaborador.txt_nombre_colaborador.Focus()
        frm_Colaborador.txt_nombre_colaborador.Clear()
        frm_Colaborador.txt_apellido_colaborador.Clear()
        frm_Colaborador.cbo_sector.SelectedIndex = -1
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnActualizar_Colaborador.Enabled = True
        frm_Colaborador.btnCancelar_Colaborador.Enabled = True
        frm_Colaborador.txt_Buscar_Colaborador.Enabled = True
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        frm_Colaborador.Button1.Visible = False
        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()
        frm_Colaborador.dgvLista_Colaboradores.Enabled = False

        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub EliminarColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Text = "Eliminar Colaborador"
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.txt_apellido_colaborador.Enabled = False
        frm_Colaborador.cbo_sector.Enabled = False
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
        frm_Colaborador.btnCancelar_Colaborador.Enabled = True
        frm_Colaborador.txt_Buscar_Colaborador.Enabled = True
        frm_Colaborador.btnEliminar_Colaborador.Enabled = True
        frm_Colaborador.dgvLista_Colaboradores.Enabled = True
        frm_Colaborador.dgvLista_Colaboradores.ClearSelection()
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub ConsultarColaboradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarColaboradorToolStripMenuItem.Click
        frm_Colaborador.Text = "Consultar Colaborador"
        frm_Colaborador.txt_nombre_colaborador.Clear()
        frm_Colaborador.txt_apellido_colaborador.Clear()
        frm_Colaborador.cbo_sector.SelectedIndex = -1
        frm_Colaborador.btnActualizar_Colaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
        frm_Colaborador.btnGuardar_Colaborador.Enabled = False
        frm_Colaborador.btnNuevo_Colaborador.Visible = False
        frm_Colaborador.Button1.Visible = False
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.txt_apellido_colaborador.Enabled = False
        frm_Colaborador.cbo_sector.Enabled = False
        frm_Colaborador.txt_nombre_colaborador.Enabled = False
        frm_Colaborador.ShowDialog()
    End Sub

    Private Sub NuevoVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Nuevo Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Focus()
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = True
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = False
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.dgvLista_vendedores.Enabled = True


        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub ModificarVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Modificar Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = True
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = True
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.dgvLista_vendedores.Enabled = True
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub EliminarVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Eliminar Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_nombre_vendedor.Enabled = False
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Enabled = False
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Enabled = False
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Enabled = False
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = True
        frm_Vendedor.btnEliminar_vendedor.Enabled = True
        frm_Vendedor.dgvLista_vendedores.Enabled = True
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub ConsultarVendedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarVendedorToolStripMenuItem.Click
        frm_Vendedor.Text = "Consultar Vendedor"
        frm_Vendedor.txt_nombre_vendedor.Clear()
        frm_Vendedor.txt_nombre_vendedor.Enabled = False
        frm_Vendedor.txt_apellido_vendedor.Clear()
        frm_Vendedor.txt_apellido_vendedor.Enabled = False
        frm_Vendedor.txt_mail_vendedor.Clear()
        frm_Vendedor.txt_mail_vendedor.Enabled = False
        frm_Vendedor.txt_telefono_vendedor.Clear()
        frm_Vendedor.txt_telefono_vendedor.Enabled = False
        frm_Vendedor.btnNuevo_Vendedor.Visible = False
        frm_Vendedor.btnGuardar_Vendedor.Enabled = False
        frm_Vendedor.btnActualizar_Vendedor.Enabled = False
        frm_Vendedor.btnCancelar_Vendedor.Enabled = True

        frm_Vendedor.txt_Buscar_vendedor.Enabled = True
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.dgvLista_vendedores.Enabled = True
        frm_Vendedor.dgvLista_vendedores.ClearSelection()
        frm_Vendedor.ShowDialog()
    End Sub

    Private Sub NuevaPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaPiezaToolStripMenuItem.Click
        frm_Pieza.Text = "Nueva Pieza"
        frm_Pieza.txt_nombre_pieza.Focus()
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = True
        frm_Pieza.txt_Buscar_Pieza.Enabled = False

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = True
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = False

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False
        frm_Pieza.ShowDialog()
    End Sub

    Private Sub ModificarPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarPiezaToolStripMenuItem.Click
        frm_Pieza.Text = "Modificar Pieza"
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = True
        frm_Pieza.txt_Buscar_Pieza.Enabled = False

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = True
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = False

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False

        frm_Pieza.ShowDialog()
    End Sub

    Private Sub EliminarPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarPiezaToolStripMenuItem.Click

        frm_Pieza.Text = "Eliminar Pieza"
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = False
        frm_Pieza.txt_Buscar_Pieza.Enabled = True

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = True

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False

        frm_Pieza.ShowDialog()
    End Sub

    Private Sub ConsultarPiezaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarPiezaToolStripMenuItem.Click

        frm_Pieza.Text = "Consultar Pieza"
        frm_Pieza.txt_nombre_pieza.Clear()

        frm_Pieza.txt_nombre_pieza.Enabled = False
        frm_Pieza.txt_Buscar_Pieza.Enabled = True

        frm_Pieza.btnNuevo_Pieza.Visible = False
        frm_Pieza.btnGuardar_Pieza.Enabled = False
        frm_Pieza.btnActualizar_Pieza.Enabled = False
        frm_Pieza.btnCancelar_Pieza.Enabled = True
        frm_Pieza.btnEliminar_Pieza.Enabled = False

        frm_Pieza.dgvLista_Piezas.ClearSelection()
        frm_Pieza.dgvLista_Piezas.Enabled = False

        frm_Pieza.ShowDialog()
    End Sub

    Private Sub NuevoSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoSectorToolStripMenuItem.Click
        frm_Sector.Text = "Nuevo Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = True
        frm_Sector.txt_Buscar_Sector.Enabled = False

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = True
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = False

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.dgvLista_Sector.Enabled = False

        frm_Sector.ShowDialog()
    End Sub

    Private Sub ModificarSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarSectorToolStripMenuItem.Click

        frm_Sector.Text = "Modificar Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = True
        frm_Sector.txt_Buscar_Sector.Enabled = True

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = True
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = False

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.dgvLista_Sector.Enabled = False

        frm_Sector.ShowDialog()
    End Sub

    Private Sub EliminarSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarSectorToolStripMenuItem.Click

        frm_Sector.Text = "Eliminar Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = False
        frm_Sector.txt_Buscar_Sector.Enabled = True

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = True

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.dgvLista_Sector.Enabled = True

        frm_Sector.ShowDialog()
    End Sub

    Private Sub ConsultarSectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarSectorToolStripMenuItem.Click

        frm_Sector.Text = "Consultar Sector"
        frm_Sector.txt_nombre_sector.Clear()
        frm_Sector.txt_nombre_sector.Focus()

        frm_Sector.txt_nombre_sector.Enabled = False
        frm_Sector.txt_Buscar_Sector.Enabled = True

        frm_Sector.btnNuevo_Sector.Visible = False
        frm_Sector.btnGuardar_Sector.Enabled = False
        frm_Sector.btnActualizar_Sector.Enabled = False
        frm_Sector.btnCancelar_Sector.Enabled = True
        frm_Sector.btnEliminar_Sector.Enabled = False

        frm_Sector.dgvLista_Sector.ClearSelection()
        frm_Sector.Enabled = True

        frm_Sector.ShowDialog()
    End Sub

    Private Sub EliminarTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarTareaToolStripMenuItem.Click
        frm_Listado_Tareas.ShowDialog()
        frm_Listado_Tareas.Text = "Eliminar Tarea"
        frm_Listado_Tareas.btnModificar_Tarea.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
        frm_Listado_Tareas.btnVer.Enabled = False
        frm_Tarea.btnImprimir.Enabled = False
    End Sub

    Private Sub TareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_Listado_Tareas.ShowDialog()
        frm_Listado_Tareas.Text = "Modificar Tarea"
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False

    End Sub

    Private Sub ConsultarTareaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarTareaToolStripMenuItem.Click
        frm_Listado_Tareas.ShowDialog()
        frm_Listado_Tareas.Text = "Consultar Tarea"
        frm_Listado_Tareas.btnModificar_Tarea.Enabled = False
        frm_Listado_Tareas.btnEliminar_Tarea.Enabled = False
        frm_Listado_Tareas.btnAgregar.Enabled = False
    End Sub

    Private Sub NuevaOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaOrdenToolStripMenuItem.Click
        frm_Orden_Trabajo.quienllamo_listado_orden = Me
        frm_Orden_Trabajo.ShowDialog()
        frm_Orden_Trabajo.Text = "Nueva Orden"
        frm_Orden_Trabajo.btnActualizar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnImprimir.Enabled = False
    End Sub

    Private Sub OrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_Listado_Orden_Trabajo.ShowDialog()
    End Sub

    Private Sub DetalleDeOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frm_Listado_Orden_Trabajo.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        frm_Listado_Orden_Trabajo.ShowDialog()
        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Detalle.Enabled = False
    End Sub

    Private Sub ModificarOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarOrdenToolStripMenuItem.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.ShowDialog()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnEliminar_Detalle.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = False
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()

    End Sub

    Private Sub EliminarOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarOrdenToolStripMenuItem.Click
        frm_Listado_Orden_Trabajo.ShowDialog()
        frm_Listado_Orden_Trabajo.btnModificar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.btnVer.Enabled = False
        frm_Listado_Orden_Trabajo.dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    Private Sub TareasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TareasToolStripMenuItem1.Click
        frm_Generar_Informe.ShowDialog()
    End Sub

    Private Sub NuevoRetrabajoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoRetrabajoToolStripMenuItem.Click
        frm_retrabajo.Text = "Nuevo Re-Trabajo"
        frm_retrabajo.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        frm_Listado_Retrabajo.Text = "Eliminar Re-Trabajo"
        frm_Listado_Retrabajo.btnGenerarInforme.Enabled = False
        frm_Listado_Retrabajo.btnVer.Enabled = False
        frm_Listado_Retrabajo.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        frm_Listado_Retrabajo.Text = "Consultar Re-Trabajo"
        frm_Listado_Retrabajo.btnGenerarInforme.Enabled = True
        frm_Listado_Retrabajo.btnEliminar_ReTrabajo.Enabled = False
        frm_Listado_Retrabajo.ShowDialog()
    End Sub

    Private Sub EtiquetasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EtiquetasToolStripMenuItem.Click
        frm_Etiqueta_Modelo_1.ShowDialog()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click

        frm_Productos.Text = "Nuevo Producto"
        frm_Productos.GroupBox2.Enabled = False
        frm_Productos.btn_prod_actualizar.Enabled = False
        frm_Productos.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem.Click

        frm_Productos.Text = "Modificar Producto"
        frm_Productos.btn_prod_guardar.Enabled = False
        frm_Productos.btn_prod_eliminar.Enabled = False
        frm_Productos.GroupBox2.Enabled = True

        frm_Productos.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click
        frm_Productos.Text = "Eliminar Producto"
        frm_Productos.GroupBox1.Enabled = False
        frm_Productos.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem2.Click
        frm_Productos.ShowDialog()
        frm_Productos.Text = "Consultar Producto"
        frm_Productos.btn_prod_actualizar.Enabled = False
        frm_Productos.btn_prod_eliminar.Enabled = False
        frm_Productos.btn_prod_guardar.Enabled = False
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaToolStripMenuItem.Click

        frm_Movimiento_Producto.Text = "Alta de Productos"
        frm_Movimiento_Producto.cbo_Tipo_Producto.SelectedIndex = 0
        frm_Movimiento_Producto.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BajaToolStripMenuItem.Click

        frm_Movimiento_Producto.Text = "Baja de Productos"
        frm_Movimiento_Producto.cbo_Tipo_Producto.SelectedIndex = 1
        frm_Movimiento_Producto.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem3.Click
        frm_Listado_Movimientos.ShowDialog()
    End Sub

    Private Sub frm_Principal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class
