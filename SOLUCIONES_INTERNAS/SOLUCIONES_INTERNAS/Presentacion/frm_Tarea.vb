Public Class frm_Tarea
    Dim datacontext As New DataS_Interno

    Private Sub frm_Tarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_tarea.Visible = False
        Label1.Visible = False
        'armargrilla()
        'cargargrilla()
        dgvLista_Tareas.ClearSelection()
        txt_detalle_tarea.Focus()
        Label6.Text = dgvLista_Tareas.Rows.Count
    End Sub

    Private Sub btnGuardar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Tarea.Click
        Try
            Dim buscacliente = (From cli In datacontext.TAREA Select cli.TAR_id_tarea, cli.TAR_tiempo_estimado, cli.TAR_tiempo_real, cli.COL_id_colaborador, cli.ORT_id_orden_trabajo, cli.TAR_hora_fin, cli.TAR_carga_horaria, cli.TAR_detalle_tarea, cli.TAR_observaciones Where TAR_detalle_tarea = txt_detalle_tarea.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("La tarea ingresada ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_detalle_tarea.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub

            End If
            Dim clie = New TAREA
            clie.TAR_tiempo_estimado = txtTiempo_Estimado.Text
            clie.TAR_tiempo_real = txtTiempo_Real.Text
            clie.COL_id_colaborador = txt_id_colaborador.Text
            clie.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            clie.TAR_hora_fin = txtHora_Finalizacion.Text
            clie.TAR_carga_horaria = txt_Carga_Horaria.Text
            clie.TAR_detalle_tarea = txt_detalle_tarea.Text
            clie.TAR_observaciones = txtObservaciones.Text

            datacontext.TAREA.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("La tarea se ha creado correctamente", vbInformation)
            ' cargargrilla()
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("La tarea NO fue creada")
            limpiarcontroles()
            ' cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_tarea.Clear()
        txt_detalle_tarea.Clear()
        txtTiempo_Estimado.Clear()
        txtTiempo_Real.Clear()
        txt_id_colaborador.Clear()
        txt_id_orden_trabajo.Clear()
        txtHora_Finalizacion.Clear()
        txt_Carga_Horaria.Clear()
        txtObservaciones.Clear()
    End Sub

    Private Sub btnActualizar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Tarea.Click
        If txt_detalle_tarea.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_id_tarea.Text.ToUpper)).ToList()(0)
            ActualizarCliente.TAR_tiempo_estimado = txtTiempo_Estimado.Text
            ActualizarCliente.TAR_tiempo_real = txtTiempo_Real.Text
            ActualizarCliente.COL_id_colaborador = txt_id_colaborador.Text
            ActualizarCliente.ORT_id_orden_trabajo = txt_id_colaborador.Text
            ActualizarCliente.TAR_hora_fin = txtHora_Finalizacion.Text
            ActualizarCliente.TAR_carga_horaria = txt_Carga_Horaria.Text
            ActualizarCliente.TAR_detalle_tarea = txt_detalle_tarea.Text
            ActualizarCliente.TAR_observaciones = txtObservaciones.Text


            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            '   cargargrilla()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            Me.limpiarcontroles()
            '   Me.cargargrilla()
        End Try
    End Sub

    'Public Sub cargargrilla()

    '    Dim consultaCliente = From U In datacontext.CLIENTE
    '                          Select U.CLI_id_cliente, U.CLI_razon_social, U.CLI_mail_cli, U.CLI_telefono_cli
    '                          Order By CLI_razon_social Ascending
    '    dgvLista_Tareas.DataSource = consultaCliente
    'End Sub

    'Private Sub armargrilla()
    '    dgvLista_Tareas.Enabled = True
    '    dgvLista_Tareas.AutoGenerateColumns = False
    '    dgvLista_Tareas.Columns.Clear()

    '    dgvLista_Tareas.Columns.Add("CLI_id_cliente", "id_cliente")
    '    dgvLista_Tareas.Columns.Add("CLI_razon_social", " Razón Social")
    '    dgvLista_Tareas.Columns.Add("CLI_mail_cli", "Mail")
    '    dgvLista_Tareas.Columns.Add("CLI_telefono_cli", "Teléfono")

    '    dgvLista_Tareas.Columns(0).DataPropertyName = "CLI_id_cliente"
    '    dgvLista_Tareas.Columns(0).Visible = False
    '    dgvLista_Tareas.Columns(1).DataPropertyName = "CLI_razon_social"
    '    dgvLista_Tareas.Columns(1).Width = 150
    '    dgvLista_Tareas.Columns(2).DataPropertyName = "CLI_mail_cli"
    '    dgvLista_Tareas.Columns(2).Width = 150
    '    dgvLista_Tareas.Columns(3).DataPropertyName = "CLI_telefono_cli"


    'End Sub

    'Private Sub dgvLista_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_Tareas.Click
    '    If dgvLista_Tareas.SelectedRows.Count > 0 Then
    '        txt_id_cliente.Text = dgvLista_Clientes.Item("CLI_id_cliente", dgvLista_Clientes.SelectedRows(0).Index).Value
    '        txt_razonsocial_cliente.Text = dgvLista_Clientes.Item("CLI_razon_social", dgvLista_Clientes.SelectedRows(0).Index).Value
    '        txt_id_colaborador.Text = dgvLista_Tareas.Item("CLI_mail_cli", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txt_telefono_cliente.Text = dgvLista_Clientes.Item("CLI_telefono_cli", dgvLista_Clientes.SelectedRows(0).Index).Value

    '        'Frm_NuevoCliente.btn_guardar.Visible = False
    '        'Frm_NuevoCliente.Show()
    '        'Frm_NuevoCliente.txt_Ruc_Cliente.Focus()
    '    Else
    '        MsgBox("Debe seleccionar un cliente")
    '    End If
    'End Sub

    Private Sub btnEliminar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Tarea.Click
        If dgvLista_Tareas.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.TAREA Where C.TAR_id_tarea = CInt(dgvLista_Tareas.Item("TAR_id_tarea", dgvLista_Tareas.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la tares seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar tarea")
                Case MsgBoxResult.Yes
                    datacontext.TAREA.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La tarea ha sido eliminada")
                    'cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub

    Private Sub btnNuevo_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva_Tarea.Click
        limpiarcontroles()
    End Sub

    Private Sub btnCancelar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Tarea.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_detalle_tarea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_detalle_tarea.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar_Colaborador.Focus()
        End If
    End Sub


End Class