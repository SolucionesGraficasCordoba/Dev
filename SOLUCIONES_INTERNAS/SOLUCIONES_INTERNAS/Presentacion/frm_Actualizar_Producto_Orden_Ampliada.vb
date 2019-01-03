Public Class frm_Actualizar_Producto_Orden_Ampliada
    Dim datacontext As New DataS_Interno

    Private Sub frm_Actualizar_Producto_Orden_Ampliada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                             Where PIE_ubicacion = "D"
                             Order By PIE_nombre_pie Ascending)

        cboPiezas_Producto.DataSource = combopieza1
        cboPiezas_Producto.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto.ValueMember = "PIE_id_pieza"

        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
        cboPiezas_Producto.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value


        Dim combopieza2 = (From sec In datacontext.PIEZA
                            Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                            Where PIE_ubicacion = "G"
                            Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto_Gran_Formato.DataSource = combopieza2
        cboPiezas_Producto_Gran_Formato.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto_Gran_Formato.ValueMember = "PIE_id_pieza_offset"

        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
        cboPiezas_Producto_Gran_Formato.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza_offset", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value

    End Sub

    Private Sub btnActualizar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar_Orden_Trabajo.Click
        'VALIDA QUE EL NUMERO DE ORDEN NO ESTE VACIO

        If chkOffset.Checked = True Or chkDigital.Checked = True Then
            If txt_cantidad_producto.Text.Length >= 1 Then
                If cboPiezas_Producto.Text.Length = 0 Then
                    MsgBox("Seleccione una pieza")
                    cboPiezas_Producto.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Ingrese Cantidad")
                txt_cantidad_producto.Focus()
                Exit Sub
            End If
        End If

        If chkGranFormato.Checked = True Then
            If txt_cantidad_producto_Gran_Formato.Text.Length >= 1 Then
                If cboPiezas_Producto_Gran_Formato.Text.Length = 0 Then
                    MsgBox("Seleccione una pieza")
                End If
            End If
        End If

        '  Try
        Dim ActualizaDetalle = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                               Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)

        txt_id_detalle_orden_trabajo1.Text = ActualizaDetalle.id_detalle_orden_trabajo
        ActualizaDetalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text


        If txt_cantidad_producto.TextLength <> 0 Then
            ActualizaDetalle.DOT_cantidad_producto = txt_cantidad_producto.Text
        End If
        ActualizaDetalle.DOT_tamaño_producto = txtTamaño_Producto.Text
        ActualizaDetalle.DOT_tipo_impresion_dot = cboTipo_Orden.Text
        ActualizaDetalle.DOT_papel_soporte_1 = txt_Papel_1_Soporte.Text
        ActualizaDetalle.DOT_papel_soporte_2 = txt_Papel_2_Soporte.Text
        ActualizaDetalle.DOT_papel_soporte_3 = txt_Papel_3_Soporte.Text
        ActualizaDetalle.DOT_gramaje_soporte_1 = txt_Gramaje_1_Soporte.Text
        ActualizaDetalle.DOT_gramaje_soporte_2 = txt_Gramaje_2_Soporte.Text
        ActualizaDetalle.DOT_gramaje_soporte_3 = txt_Gramaje_3_Soporte.Text
        If txt_Cantidad_1_Pliego_Entero.TextLength <> 0 Then
            ActualizaDetalle.DOT_cantidad_soporte_1 = txt_Cantidad_1_Pliego_Entero.Text
        End If
        If txt_Cantidad_2_Pliego_Entero.TextLength <> 0 Then
            ActualizaDetalle.DOT_cantidad_soporte_2 = txt_Cantidad_2_Pliego_Entero.Text
        End If
        If txt_Cantidad_3_Pliego_Entero.TextLength <> 0 Then
            ActualizaDetalle.DOT_cantidad_soporte_3 = txt_Cantidad_3_Pliego_Entero.Text
        End If
        ActualizaDetalle.DOT_formato_soporte_1 = cboFormato_1_Pliego_Entero.Text
        ActualizaDetalle.DOT_formato_soporte_2 = cboFormato_2_Pliego_Entero.Text
        ActualizaDetalle.DOT_formato_soporte_3 = cboFormato_3_Pliego_Entero.Text

        cboPiezas_Producto.SelectedValue = ActualizaDetalle.PIE_id_pieza
        ActualizaDetalle.PIE_id_pieza = cboPiezas_Producto.SelectedValue

        ' cboPiezas_Producto_Gran_Formato.SelectedValue = ActualizaDetalle.PIE_id_pieza_offset
        ' ActualizaDetalle.PIE_id_pieza_offset = cboPiezas_Producto_Gran_Formato.SelectedValue

        txt_id_orden_trabajo.Text = ActualizaDetalle.ORT_id_orden_trabajo
        ActualizaDetalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
        If txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
            ActualizaDetalle.cantidad_1_PM_offset = txtCantidad_1_Pliego_Maquina_Offset.Text
        End If
        If txtCantidad_2_Pliego_Maquina_Offset.TextLength <> 0 Then
            ActualizaDetalle.cantidad_2_PM_offset = txtCantidad_2_Pliego_Maquina_Offset.Text
        End If
        If txtCantidad_3_Pliego_Maquina_Offset.TextLength <> 0 Then
            ActualizaDetalle.cantidad_3_PM_offset = txtCantidad_3_Pliego_Maquina_Offset.Text
        End If
        ActualizaDetalle.formato_1_PM_offset = cboFormato_1_Pliego_Maquina_Offset.Text
        ActualizaDetalle.formato_2_PM_offset = cboFormato_2_Pliego_Maquina_Offset.Text
        ActualizaDetalle.formato_3_PM_offset = cboFormato_3_Pliego_Maquina_Offset.Text
        ActualizaDetalle.modo_impresion_offset = cboModo_Impresion_Offset.Text
        ActualizaDetalle.tipo_impresion_offset = cboTipo_Impresion_Offset.Text
        If txt_chapa_soporte_1.TextLength <> 0 Then
            ActualizaDetalle.chapas_soporte1_offset = txt_chapa_soporte_1.Text
        End If
        If txt_chapa_soporte_2.TextLength <> 0 Then
            ActualizaDetalle.chapas_soporte2_offset = txt_chapa_soporte_2.Text
        End If
        If txt_chapa_soporte_3.TextLength <> 0 Then
            ActualizaDetalle.chapas_soporte3_offset = txt_chapa_soporte_3.Text
        End If
        ActualizaDetalle.impresora_offset = cboImpresora_Offset.Text
        ActualizaDetalle.marca_offset = cboMarca_Offset.Text
        If txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
            ActualizaDetalle.cantidad_1_PM_digital = txtCantidad_1_Pliego_Maquina_Digital.Text
        End If
        If txtCantidad_2_Pliego_Maquina_Digital.TextLength <> 0 Then
            ActualizaDetalle.cantidad_2_PM_digital = txtCantidad_2_Pliego_Maquina_Digital.Text
        End If
        If txtCantidad_3_Pliego_Maquina_Digital.TextLength <> 0 Then
            ActualizaDetalle.cantidad_3_PM_digital = txtCantidad_3_Pliego_Maquina_Digital.Text
        End If
        ActualizaDetalle.formato_1_PM_digital = cboFormato_1_Pliego_Maquina_Digital.Text
        ActualizaDetalle.formato_2_PM_digital = cboFormato_2_Pliego_Maquina_Digital.Text
        ActualizaDetalle.formato_3_PM_digital = cboFormato_3_Pliego_Maquina_Digital.Text
        ActualizaDetalle.tipo_impresion_digital = cboTipo_Impresion_Digital.Text
        ActualizaDetalle.dato_variable = txtDato_Variable.Text
        If txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
            ActualizaDetalle.cantidad_gran_formato = txt_cantidad_producto_Gran_Formato.Text
        End If
        ActualizaDetalle.tamaño_gran_formato = txtTamaño_Producto_Gran_Formato.Text
        ActualizaDetalle.sustrato_gran_formato = txtSustrato_Gran_Formato.Text
        ActualizaDetalle.calidad_gran_formato = cboCalidad_Gran_Formato.Text
        ActualizaDetalle.sistema_gran_formato = cboSistema_Gran_Formato.Text
        ' ActualizaDetalle.tipo_terminacion=
        ActualizaDetalle.descripcion_terminacion = txt_descripcion_terminacion.Text

        datacontext.SubmitChanges()
        MsgBox("Los datos se han modificado correctamente")
        Me.Close()
        frm_listado_orden_trabajo_ampliada.Close()
        ' Catch ex As Exception
        '   MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar orden")

        '  End Try
    End Sub
End Class