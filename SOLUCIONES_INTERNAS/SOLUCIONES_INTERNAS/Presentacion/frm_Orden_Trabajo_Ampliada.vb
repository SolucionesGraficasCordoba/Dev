Public Class frm_Orden_Trabajo_Ampliada

    Dim datacontext As New DataS_Interno
    Public quienllamo_listado_orden As Form

    Private Sub frm_Orden_Trabajo_Ampliada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' If quienllamo_listado_orden.Name <> frm_Listado_Orden_Trabajo.Name Then
        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                           Where PIE_ubicacion = "D"
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto.DataSource = combopieza1
        cboPiezas_Producto.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto.ValueMember = "PIE_id_pieza"
        cboPiezas_Producto.SelectedIndex = -1

        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                           Where PIE_ubicacion = "G"
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto_Gran_Formato.DataSource = combopieza2
        cboPiezas_Producto_Gran_Formato.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto_Gran_Formato.ValueMember = "PIE_id_pieza"
        cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
        '  Else
        '    cboPiezas1_Detalle1.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.Rows(0).Index).Value
        '    cboPiezas2_Detalle2.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.Rows(1).Index).Value
        '    cboPiezas3_Detalle3.SelectedValue = frm_Listado_Orden_Trabajo.dgv_detalle_orden.Item("PIE_id_pieza", frm_Listado_Orden_Trabajo.dgv_detalle_orden.Rows(2).Index).Value
        '   End If
    End Sub

    Private Sub btnBuscar_cliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.GroupNuevoCliente.Enabled = False
        frm_Cliente.Show()
    End Sub

    Private Sub btnBuscar_Vendedor_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Vendedor.Click
        frm_Vendedor.quienllamovendedor = Me
        frm_Vendedor.Text = "Seleccionar Vendedor"
        frm_Vendedor.btnEliminar_vendedor.Enabled = False
        frm_Vendedor.GroupNuevoVendedor.Enabled = False
        frm_Vendedor.Show()
    End Sub

    Private Sub chkOffset_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOffset.CheckedChanged
        If chkOffset.Checked = True Then
            GroupProducto_Soportes.Enabled = True
            groupOffset.Enabled = True
        Else
            groupOffset.Enabled = False
            GroupProducto_Soportes.Enabled = False
            LimpiarProducto_Soportes()
            LimpiarOffset()
        End If
    End Sub

    Private Sub chkDigital_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDigital.CheckedChanged
        If chkDigital.Checked = True Then
            GroupDigital.Enabled = True
            GroupProducto_Soportes.Enabled = True
        Else
            GroupDigital.Enabled = False
            GroupProducto_Soportes.Enabled = False
            LimpiarProducto_Soportes()
            LimpiarDigital()
        End If
    End Sub

    Private Sub chkGranFormato_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGranFormato.CheckedChanged
        If chkGranFormato.Checked = True Then
            GroupGranFormato.Enabled = True
        Else
            GroupGranFormato.Enabled = False
            LimpiarGranFormato()
        End If
    End Sub

    Private Sub chkTerminacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTerminacion.CheckedChanged
        If chkTerminacion.Checked = True Then
            GroupTerminacion.Enabled = True
        Else
            GroupTerminacion.Enabled = False
            LimpiarTerminacion()
        End If
    End Sub

    Sub LimpiarDigital()
        cboTipo_Impresion_Digital.SelectedIndex = -1
        txtCantidad_1_Pliego_Maquina_Digital.Clear()
        cboFormato_1_Pliego_Maquina_Digital.SelectedIndex = -1
        txtCantidad_2_Pliego_Maquina_Digital.Clear()
        cboFormato_2_Pliego_Maquina_Digital.SelectedIndex = -1
        txtCantidad_3_Pliego_Maquina_Digital.Clear()
        cboFormato_3_Pliego_Maquina_Digital.SelectedIndex = -1
        txtDato_Variable.Clear()
    End Sub

    Sub LimpiarTerminacion()
        chkLaca_UV.Checked = False
        chkPosicionado.Checked = False
        chkDoblado.Checked = False
        chkTroquelado.Checked = False
        chkCorte.Checked = False
        chkMedio_Corte.Checked = False
        chkBarniz.Checked = False
        chkMontado.Checked = False
        chkEncuadernacion.Checked = False
        chkStamping.Checked = False
        chkAdhesivado.Checked = False
        chkTrazado.Checked = False
        chkSoldado.Checked = False
        chkCocido.Checked = False
        chkRuedo.Checked = False
        chkPolipropileno.Checked = False
        chkOtros.Checked = False
        txt_descripcion_terminacion.Clear()
    End Sub

    Sub LimpiarProducto_Soportes()
        txt_cantidad_producto.Clear()
        cboPiezas_Producto.SelectedIndex = -1
        txtTamaño_Producto.Clear()
        txt_Papel_1_Soporte.Clear()
        txt_Gramaje_1_Soporte.Clear()
        txt_Cantidad_1_Pliego_Entero.Clear()
        cboFormato_1_Pliego_Entero.SelectedIndex = -1
        txt_Papel_2_Soporte.Clear()
        txt_Cantidad_2_Pliego_Entero.Clear()
        txt_Gramaje_2_Soporte.Clear()
        txt_Cantidad_2_Pliego_Entero.Clear()
        cboFormato_2_Pliego_Entero.SelectedIndex = -1
        txt_Papel_3_Soporte.Clear()
        txt_Gramaje_3_Soporte.Clear()
        txt_Cantidad_3_Pliego_Entero.Clear()
        cboFormato_3_Pliego_Entero.SelectedIndex = -1
    End Sub

    Sub LimpiarOffset()
        cboTipo_Impresion_Offset.SelectedIndex = -1
        cboModo_Impresion_Offset.SelectedIndex = -1
        cboImpresora_Offset.SelectedIndex = -1
        cboMarca_Offset.SelectedIndex = -1
        txtCantidad_1_Pliego_Maquina_Offset.Clear()
        cboFormato_1_Pliego_Maquina_Offset.SelectedIndex = -1
        txt_chapa_soporte_1.Clear()
        txtCantidad_2_Pliego_Maquina_Offset.Clear()
        cboFormato_2_Pliego_Maquina_Offset.SelectedIndex = -1
        txt_chapa_soporte_2.Clear()
        txtCantidad_3_Pliego_Maquina_Offset.Clear()
        cboFormato_3_Pliego_Maquina_Offset.SelectedIndex = -1
        txt_chapa_soporte_3.Clear()
    End Sub

    Sub LimpiarGranFormato()
        txt_cantidad_producto_Gran_Formato.Clear()
        cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
        txtTamaño_Producto_Gran_Formato.Clear()
        txtSustrato_Gran_Formato.Clear()
        cboCalidad_Gran_Formato.SelectedIndex = -1
        cboSistema_Gran_Formato.SelectedIndex = -1
    End Sub

    Private Sub btnGuardar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_Orden_Trabajo.Click
        '  Try
        Dim ODT = New ORDEN_TRABAJO
        '  If cargamasprod = "NO" Then


        ODT.ORT_numero_ot = StrConv(txtNumero_Orden_Trabajo.Text, VbStrConv.ProperCase)
        ODT.ORT_fecha_ot = dtpFecha_Ingreso_ODT.Text
        ODT.ORT_fecha_entrega = dtpFecha_Entrega_ODT.Text
        ODT.ORT_tipo_ot = cboTipo_Orden.Text

        ODT.ORT_observaciones_ot = StrConv(txt_observaciones.Text, VbStrConv.ProperCase)
        ODT.ORT_mejoras_ot = StrConv(cboDireccion_Entrega.Text, VbStrConv.ProperCase)
        ODT.VEN_id_vendedor = txtid_vendedor.Text
        ODT.CLI_id_cliente = txt_id_cliente.Text


        datacontext.ORDEN_TRABAJO.InsertOnSubmit(ODT)
        datacontext.SubmitChanges()
        '   End If

        'GUARDA EL REGISTRO 1 DEL DETALLE DE LA ORDEN DE TRABAJO
        'If txt_cantidad1_detalle1.Text.Length >= 1 Then
        '    If cboPiezas1_Detalle1.Text.Length = 0 Then
        '        MsgBox("Seleccione una pieza")
        '    End If

        Dim detalle = New DETALLE_ORDEN_TRABAJO
        'id
        txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo
        detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

        If txt_cantidad_producto.TextLength <> 0 Then
            detalle.DOT_cantidad_producto = txt_cantidad_producto.Text  'CANTIDAD PRODUCTO 1
        End If
        detalle.DOT_tamaño_producto = StrConv(txtTamaño_Producto.Text, VbStrConv.ProperCase) 'TAMAÑO PRODUCTO 1
        detalle.DOT_tipo_impresion_dot = cboTipo_Orden.SelectedItem 'TIPO IMPRESION PRODUCTO 1
        detalle.PIE_id_pieza = cboPiezas_Producto.SelectedValue 'TIPO PIEZA PRODUCTO 1

        'If cargamasprod = "NO" Then
        txt_id_orden_trabajo.Text = ODT.ORT_id_orden_trabajo
        'End If
        detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text 'ID ORDEN TRABAJO

        'PAPEL PRODUCTO 1
        detalle.DOT_papel_soporte_1 = StrConv(txt_Papel_1_Soporte.Text, VbStrConv.ProperCase)
        detalle.DOT_papel_soporte_2 = StrConv(txt_Papel_2_Soporte.Text, VbStrConv.ProperCase)
        detalle.DOT_papel_soporte_3 = StrConv(txt_Papel_3_Soporte.Text, VbStrConv.ProperCase)

        'GRAMAJE PRODUCTO 1
        detalle.DOT_gramaje_soporte_1 = txt_Gramaje_1_Soporte.Text
        detalle.DOT_gramaje_soporte_2 = txt_Gramaje_2_Soporte.Text
        detalle.DOT_gramaje_soporte_3 = txt_Gramaje_3_Soporte.Text

        'CANTIDAD PRODUCTO 1
        If txt_Cantidad_1_Pliego_Entero.TextLength <> 0 Then
            detalle.DOT_cantidad_soporte_1 = txt_Cantidad_1_Pliego_Entero.Text
        End If
        If txt_Cantidad_2_Pliego_Entero.TextLength <> 0 Then
            detalle.DOT_cantidad_soporte_2 = txt_Cantidad_2_Pliego_Entero.Text
        End If
        If txt_Cantidad_3_Pliego_Entero.TextLength <> 0 Then
            detalle.DOT_cantidad_soporte_3 = txt_Cantidad_3_Pliego_Entero.Text
        End If
        'FORMATO PRODUCTO 1
        detalle.DOT_formato_soporte_1 = cboFormato_1_Pliego_Entero.SelectedItem
        detalle.DOT_formato_soporte_2 = cboFormato_2_Pliego_Entero.SelectedItem
        detalle.DOT_formato_soporte_3 = cboFormato_3_Pliego_Entero.SelectedItem

        detalle.tipo_impresion_digital = cboTipo_Impresion_Digital.SelectedItem

        If txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
            detalle.cantidad_1_PM_digital = txtCantidad_1_Pliego_Maquina_Digital.Text
        End If
        If txtCantidad_2_Pliego_Maquina_Digital.TextLength <> 0 Then
            detalle.cantidad_2_PM_digital = txtCantidad_2_Pliego_Maquina_Digital.Text
        End If
        If txtCantidad_3_Pliego_Maquina_Digital.TextLength <> 0 Then
            detalle.cantidad_3_PM_digital = txtCantidad_3_Pliego_Maquina_Digital.Text
        End If

        detalle.formato_1_PM_digital = cboFormato_1_Pliego_Maquina_Digital.SelectedItem
        detalle.formato_2_PM_digital = cboFormato_2_Pliego_Maquina_Digital.SelectedItem
        detalle.formato_3_PM_digital = cboFormato_3_Pliego_Maquina_Digital.SelectedItem

        detalle.dato_variable = txtDato_Variable.Text

        datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
        datacontext.SubmitChanges()

        MsgBox("La orden se ha guardado correctamente")
        ' Catch ex As Exception
        '   MsgBox("Error al cargar la Orden")
        '  End Try
    End Sub
End Class