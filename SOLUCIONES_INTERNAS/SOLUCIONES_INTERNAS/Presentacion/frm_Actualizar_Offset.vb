﻿Public Class frm_Actualizar_Offset

    Dim datacontext As New DataS_Interno

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click
        '  frm_listado_orden_trabajo_ampliada.quien_llamo_listado_orden_ampliada = Me

        frm_listado_orden_trabajo_ampliada.Show()

    End Sub

    Private Sub btnGuardar_ReTrabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_ReTrabajo.Click

        'VALIDA QUE EL TIPO DE ORDEN NO ESTE VACIO
        If txt_cantidad_chapas_retrabajo.Text.Length = 0 Then
            MsgBox("Complete el campo Tipo de Orden")
            txt_cantidad_chapas_retrabajo.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL NUMERO DE ORDEN NO ESTE VACIO
        If txtNumero_Orden_Trabajo.Text.Length = 0 Then
            MsgBox("Complete el campo Cantidad de Chapas")
            txtNumero_Orden_Trabajo.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO VENDEDOR NO ESTE VACIO
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

            datacontext.RE_TRABAJO.InsertOnSubmit(rt)
            datacontext.SubmitChanges()

            MsgBox("La repetición se ha guardado correctamente", vbInformation)
            '  limpiarcontroles()
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
        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                             Where PIE_ubicacion = "D"
                             Order By PIE_nombre_pie Ascending)

        cboPiezas1_Detalle1.DataSource = combopieza1
        cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
        cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"
        cboPiezas1_Detalle1.SelectedIndex = -1

        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
        cboPiezas1_Detalle1.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value

    End Sub
End Class