Public Class frm_Actualizar_Offset

    Dim datacontext As New DataS_Interno

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnGuardar_ReTrabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_ReTrabajo.Click

        'VALIDA QUE EL NUMERO DE ORDEN NO ESTE VACIO
        If txtNumero_Orden_Trabajo.Text.Length = 0 Then
            MsgBox("Complete el campo Número de Orden")
            btnBuscar_Numero_Orden1.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO CANTIDAD DE CHAPAS NO ESTE VACIO
        If txt_cantidad_chapas_retrabajo.Text.Length = 0 Then
            MsgBox("Complete el campo Cantidad de Chapas")
            txt_cantidad_chapas_retrabajo.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL COMBO MOTIVO NO ESTE VACIO
        If cboMotivo.SelectedIndex = -1 Then
            MsgBox("Cargue el Motivo del retrabajo")
            cboMotivo.Focus()
            Exit Sub
        End If

        'GUARDA ORDEN DE TRABAJO
        Try
            Dim rt = New RE_TRABAJO

            rt.RET_fecha_comienzo_retrabajo = dtpFecha_Re_Trabajo.Text
            rt.RET_fecha_entrega_retrabajo = dtp_Nueva_Fecha_Entrega.Text
            rt.cantidad_chapas_retrabajo = txt_cantidad_chapas_retrabajo.Text
            rt.RET_origen_area_motivo = cboMotivo.Text
            rt.impresora_offset_retrabajo = cboImpresora_Offset.Text
            rt.marca_offset_retrabajo = cboMarca_Offset.Text
            rt.RET_procedimiento_observaciones = txt_procedimiento.Text
            rt.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

            datacontext.RE_TRABAJO.InsertOnSubmit(rt)
            datacontext.SubmitChanges()

            MsgBox("La repetición se ha guardado correctamente", vbInformation)
            CargarGrillaRepeticion()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al intentar guardar")
        End Try
    End Sub

    Private Sub btnCancelar_ReTrabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_ReTrabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Actualizar_Offset_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ArmarGrillaRepeticion()
        CargarGrillaRepeticion()
        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                             Where PIE_ubicacion = "D"
                             Order By PIE_nombre_pie Ascending)

        cboPiezas1_Detalle1.DataSource = combopieza1
        cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
        cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"
        cboPiezas1_Detalle1.SelectedIndex = -1

        Try
            'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
            cboPiezas1_Detalle1.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ArmarGrillaRepeticion()
        dgvRepeticion.Enabled = True
        dgvRepeticion.AutoGenerateColumns = False
        dgvRepeticion.Columns.Clear()

        dgvRepeticion.Columns.Add("id_detalle_orden_trabajo", "id_detalle_orden_trabajo")
        dgvRepeticion.Columns.Add("RET_id_retrabajo", "RET_id_retrabajo")
        dgvRepeticion.Columns.Add("ORT_numero_ot", "Número de Orden")
        dgvRepeticion.Columns.Add("cantidad_chapas_retrabajo", "Cantidad de Chapas")
        dgvRepeticion.Columns.Add("impresora_offset_retrabajo", "Impresora")
        dgvRepeticion.Columns.Add("marca_offset_retrabajo", "Marca")
        dgvRepeticion.Columns.Add("RET_origen_area_motivo", "Motivo")
        dgvRepeticion.Columns.Add("RET_procedimiento_observaciones", "Observaciones")
        dgvRepeticion.Columns.Add("RET_fecha_comienzo_retrabajo", "Fecha Comienzo")
        dgvRepeticion.Columns.Add("RET_fecha_entrega_retrabajo", "Fecha Entrega")

        dgvRepeticion.Columns(0).DataPropertyName = "id_detalle_orden_trabajo"
        dgvRepeticion.Columns(0).Visible = False
        dgvRepeticion.Columns(1).DataPropertyName = "RET_id_retrabajo"
        dgvRepeticion.Columns(1).Visible = False
        dgvRepeticion.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvRepeticion.Columns(3).DataPropertyName = "cantidad_chapas_retrabajo"
        dgvRepeticion.Columns(4).DataPropertyName = "impresora_offset_retrabajo"
        dgvRepeticion.Columns(5).DataPropertyName = "marca_offset_retrabajo"
        dgvRepeticion.Columns(6).DataPropertyName = "RET_origen_area_motivo"
        dgvRepeticion.Columns(6).Width = 150
        dgvRepeticion.Columns(7).DataPropertyName = "RET_procedimiento_observaciones"
        dgvRepeticion.Columns(8).DataPropertyName = "RET_fecha_comienzo_retrabajo"
        dgvRepeticion.Columns(9).DataPropertyName = "RET_fecha_entrega_retrabajo"
    End Sub

    Private Sub CargarGrillaRepeticion()
        Dim carga = (From dot In datacontext.DETALLE_ORDEN_TRABAJO
                                    Join ot In datacontext.ORDEN_TRABAJO
                                    On dot.ORT_id_orden_trabajo Equals ot.ORT_id_orden_trabajo
                                    Join ret In datacontext.RE_TRABAJO
                                    On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
                                    Select
                                    dot.id_detalle_orden_trabajo,
                                    ret.RET_id_retrabajo,
                                    ot.ORT_numero_ot,
                                    ret.cantidad_chapas_retrabajo,
                                    ret.impresora_offset_retrabajo,
                                    ret.marca_offset_retrabajo,
                                    ret.RET_origen_area_motivo,
                                    ret.RET_procedimiento_observaciones,
                                    ret.RET_fecha_comienzo_retrabajo,
                                    ret.RET_fecha_entrega_retrabajo
        Order By RET_fecha_comienzo_retrabajo Descending)
        dgvRepeticion.DataSource = carga
    End Sub

    Private Sub txt_Buscar_Orden_Repeticion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_Orden_Repeticion.TextChanged
        'CONTROLAR
        Dim buscar As String
        ArmarGrillaRepeticion()
        buscar = "*" & Me.txt_Buscar_Orden_Repeticion.Text & "*"
        Dim ConsultaRepeticion = (From dot In datacontext.DETALLE_ORDEN_TRABAJO
                                    Join ot In datacontext.ORDEN_TRABAJO
                                    On dot.ORT_id_orden_trabajo Equals ot.ORT_id_orden_trabajo
                                    Join ret In datacontext.RE_TRABAJO
                                    On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
                                    Select
                                    dot.id_detalle_orden_trabajo,
                                    ret.RET_id_retrabajo,
                                    ot.ORT_numero_ot,
                                    ret.cantidad_chapas_retrabajo,
                                    ret.impresora_offset_retrabajo,
                                    ret.marca_offset_retrabajo,
                                    ret.RET_origen_area_motivo,
                                    ret.RET_procedimiento_observaciones,
                                    ret.RET_fecha_comienzo_retrabajo,
                                    ret.RET_fecha_entrega_retrabajo
                                    Where ORT_numero_ot Like buscar.ToString
                                    Order By ORT_numero_ot Ascending)
        dgvRepeticion.DataSource = ConsultaRepeticion
        dgvRepeticion.ClearSelection()
        dgvRepeticion.DataSource = ""
        Label3.Text = dgvRepeticion.Rows.Count
    End Sub

    Private Sub btnEliminar_Repeticion_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar_Repeticion.Click
        If dgvRepeticion.SelectedRows.Count > 0 Then

            Dim eliminar = (From rep In datacontext.RE_TRABAJO Where rep.RET_id_retrabajo = CInt(dgvRepeticion.Item("RET_id_retrabajo", dgvRepeticion.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la Repetición seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Repetición")
                Case MsgBoxResult.Yes
                    datacontext.RE_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La Repetición ha sido eliminada")
                    CargarGrillaRepeticion()
            End Select
        Else
            MsgBox("Debe seleccionar una Repetición")
        End If
    End Sub

    Private Sub txt_cantidad_chapas_retrabajo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad_chapas_retrabajo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
