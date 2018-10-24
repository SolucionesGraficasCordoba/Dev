Public Class frm_Actualizar_Producto_Orden
    Dim datacontext As New DataS_Interno

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click

        Dim ActualizarDetalle = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                                  Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)

        If cboPiezas.Text.Length = 0 Then
            MsgBox("Seleccione una pieza")
            Exit Sub
        End If
        txt_id_detalle_orden_trabajo1.Text = ActualizarDetalle.id_detalle_orden_trabajo
        ActualizarDetalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
        ActualizarDetalle.DOT_cantidad_dot = txt_cantidad.Text
        ActualizarDetalle.PIE_id_pieza = cboPiezas.SelectedValue
        ActualizarDetalle.DOT_tamaño_dot = txtTamaño.Text
        ActualizarDetalle.DOT_tipo_impresion_dot = cboTipoImpresion.SelectedItem

        ActualizarDetalle.DOT_papel_soporte_1 = StrConv(txt_Papel1_Soporte.Text, VbStrConv.ProperCase)
        ActualizarDetalle.DOT_papel_soporte_2 = StrConv(txt_Papel2_Soporte.Text, VbStrConv.ProperCase)
        ActualizarDetalle.DOT_papel_soporte_3 = StrConv(txt_Papel3_Soporte.Text, VbStrConv.ProperCase)

        ActualizarDetalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte.Text
        ActualizarDetalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte.Text
        ActualizarDetalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte.Text

        If txt_Cantidad1_Soporte.TextLength <> 0 Then
            ActualizarDetalle.DOT_cantidad_soporte_1 = CInt(txt_Cantidad1_Soporte.Text)
        End If
        If txt_Cantidad2_Soporte.TextLength <> 0 Then
            ActualizarDetalle.DOT_cantidad_soporte_2 = CInt(txt_Cantidad2_Soporte.Text)
        End If
        If txt_Cantidad3_Soporte.TextLength <> 0 Then
            ActualizarDetalle.DOT_cantidad_soporte_3 = CInt(txt_Cantidad3_Soporte.Text)
        End If

        ActualizarDetalle.DOT_formato_soporte_1 = cboFormato1_Soporte.SelectedItem
        ActualizarDetalle.DOT_formato_soporte_2 = cboFormato2_Soporte.SelectedItem
        ActualizarDetalle.DOT_formato_soporte_3 = cboFormato3_Soporte.SelectedItem

        datacontext.SubmitChanges()
    End Sub

    Private Sub frm_Actualizar_Producto_Orden_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                             Order By PIE_nombre_pie Ascending)
        cboPiezas.DataSource = combopieza1
        cboPiezas.DisplayMember = "PIE_nombre_pie"
        cboPiezas.ValueMember = "PIE_id_pieza"
    End Sub
End Class