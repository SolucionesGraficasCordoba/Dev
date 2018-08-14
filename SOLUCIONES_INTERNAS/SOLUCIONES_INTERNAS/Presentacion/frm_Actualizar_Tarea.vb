Public Class frm_Actualizar_Tarea
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim vble_colaborador, vble_fecha As String

    Private Sub btn_Actualizar_Tarea_Click(sender As System.Object, e As System.EventArgs) Handles btn_Actualizar_Tarea.Click
        If txt_tarea.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Or txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarTarea = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_id_tarea.Text.ToUpper)).ToList()(0)
            ActualizarTarea.TAR_tiempo_estimado = txt_tiempo_estimado.Text
            ActualizarTarea.TAR_tiempo_real = txt_tiempo_real.Text
            ActualizarTarea.COL_id_colaborador = txt_id_colaborador.Text
            ActualizarTarea.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            ActualizarTarea.TAR_hora_fin = txt_hora_fin.Text
            ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria.Text
            ActualizarTarea.TAR_detalle_tarea = txt_tarea.Text
            ActualizarTarea.TAR_observaciones = txt_observaciones.Text
            ActualizarTarea.TAR_fecha = dtpFecha.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()

            vble_colaborador = frm_Listado_Tareas.dgvColaboradores.Item("COL_nombre_col", frm_Listado_Tareas.dgvColaboradores.SelectedRows(0).Index).Value
            vble_fecha = frm_Listado_Tareas.dtpFecha.Text
            Dim datagridtarea = (From o In datavistas.Vista_Tarea_x_Colaborador
                               Select o.TAR_id_tarea, o.TAR_detalle_tarea, o.TAR_tiempo_estimado, o.TAR_tiempo_real,
                               o.TAR_observaciones, o.ORT_id_orden_trabajo, o.ORT_numero_ot, o.TAR_fecha, o.TAR_carga_horaria, o.TAR_hora_fin, o.Expr1, o.COL_nombre_col
                               Where COL_nombre_col = vble_colaborador And TAR_fecha = vble_fecha)
            frm_Listado_Tareas.mostrargrillaobligaciones(datagridtarea)
            Label1.Text = frm_Listado_Tareas.dgvTarea_x_Colaborador.Rows.Count

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            'Me.limpiarcontroles()
            vble_colaborador = frm_Listado_Tareas.dgvColaboradores.Item("COL_nombre_col", frm_Listado_Tareas.dgvColaboradores.SelectedRows(0).Index).Value
            vble_fecha = frm_Listado_Tareas.dtpFecha.Text
            Dim datagridtarea = (From o In datavistas.Vista_Tarea_x_Colaborador
                               Select o.TAR_id_tarea, o.TAR_detalle_tarea, o.TAR_tiempo_estimado, o.TAR_tiempo_real,
                               o.TAR_observaciones, o.ORT_id_orden_trabajo, o.ORT_numero_ot, o.TAR_fecha, o.TAR_carga_horaria, o.TAR_hora_fin, o.Expr1, o.COL_nombre_col
                               Where COL_nombre_col = vble_colaborador And TAR_fecha = vble_fecha)
            frm_Listado_Tareas.mostrargrillaobligaciones(datagridtarea)
            Label1.Text = frm_Listado_Tareas.dgvTarea_x_Colaborador.Rows.Count
        End Try
    End Sub
End Class