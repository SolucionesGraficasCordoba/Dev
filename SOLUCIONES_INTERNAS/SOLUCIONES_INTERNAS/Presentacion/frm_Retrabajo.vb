﻿Public Class frm_retrabajo
    Dim datacontext As New DataS_Interno

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden y Detalle"
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Producto.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub frm_retrabajo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnBuscar_Numero_Orden1.Focus()
        txtNumero_Orden_Trabajo.Enabled = False
        'txt_id_orden_trabajo.Visible = False
        cboPieza_Original.Enabled = False
        txtTamaño_Original.Enabled = False
        ' cboTipoImpresion.Enabled = False
        'txt_id_detalle_orden_trabajo1.Visible = False
        txt_Cantidad_Original.Enabled = False
        dtp_Fecha_Ingreso_Original.Enabled = False
        dtpFecha_Entrega_Original.Enabled = False
        Label45.Visible = False
        Label1.Visible = False
        'txt_id_re_trabajo.Visible = False
        'btnImprimir.Enabled = False

        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                             Where PIE_ubicacion = "D"
                             Order By PIE_nombre_pie Ascending)

        cboPieza_Original.DataSource = combopieza1
        cboPieza_Original.DisplayMember = "PIE_nombre_pie"
        cboPieza_Original.ValueMember = "PIE_id_pieza"
        cboPieza_Original.SelectedIndex = -1

        Try
            'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
            cboPieza_Original.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar_ReTrabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_cantidad_retrabajo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_Retrabajo.KeyPress
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

    Private Sub txt_Gramaje1_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Gramaje2_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Gramaje3_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad1_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad2_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad3_Soporte1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirFormulario.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True

        'PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 30

        btnImprimirFormulario.Visible = False
        btnGuardar_ReTrabajo.Visible = False
        btnCancelar_ReTrabajo.Visible = False
        Label17.Visible = False
        PrintForm1.Print() 'imprimir
    End Sub

    Private Sub frm_retrabajo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_ReTrabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_ReTrabajo.Click

        If txtNumero_Orden_Trabajo.Text.Length = 0 Then
            MsgBox("Debe seleccionar una Orden")
            btnBuscar_Numero_Orden1.Focus()
            Exit Sub
        End If

        If txt_Cantidad_Retrabajo.Text.Length = 0 Then
            MsgBox("Ingrese la nueva Cantidad")
            txt_Cantidad_Retrabajo.Focus()
            Exit Sub
        End If
        Try
            'GUARDA RETRABAJO
            Dim ret = New RE_TRABAJO

            ' GUARDA GroupReTrabajo
            If txt_Cantidad_Retrabajo.TextLength <> 0 Then
                ret.RET_cantidad_producto_retrabajo = txt_Cantidad_Retrabajo.Text
            End If
            ret.RET_origen_area_motivo = StrConv(txt_Origen_Causa.Text, VbStrConv.ProperCase)
            ret.RET_procedimiento_observaciones = StrConv(txt_Procedimiento.Text, VbStrConv.ProperCase)
            ret.RET_fecha_comienzo_retrabajo = StrConv(dtpFecha_Re_Trabajo.Text, VbStrConv.ProperCase)
            ret.RET_fecha_entrega_retrabajo = StrConv(dtp_Nueva_Fecha_Entrega.Text, VbStrConv.ProperCase)
            '-----------------------------------------------------------------------------------------------------------
            ret.id_detalle_orden_trabajo = txt_id_detalle.Text
            '-----------------------------------------------------------------------------------------------------------
            'PRODUCTO
            ret.RET_papel_soporte_1_retrabajo = txt_Papel_1_Soporte.Text
            ret.RET_papel_soporte_2_retrabajo = txt_Papel_2_Soporte.Text
            ret.RET_papel_soporte_3_retrabajo = txt_Papel_3_Soporte.Text

            ret.RET_gramaje_soporte_1_retrabajo = txt_Gramaje_1_Soporte.Text
            ret.RET_gramaje_soporte_2_retrabajo = txt_Gramaje_2_Soporte.Text
            ret.RET_gramaje_soporte_3_retrabajo = txt_Gramaje_3_Soporte.Text
            '-----------------------------------------------------------------------
            'PLIEGO ENTERO DIGITAL/OFFSET

            If txt_Cantidad_1_PE_DigitalOffset.TextLength <> 0 Then
                ret.RET_cantidad_soporte_1_retrabajo = txt_Cantidad_1_PE_DigitalOffset.Text
            End If
            If txt_Cantidad_2_PE_DigitalOffset.TextLength <> 0 Then
                ret.RET_cantidad_soporte_2_retrabajo = txt_Cantidad_2_PE_DigitalOffset.Text
            End If
            If txt_Cantidad_3_PE_DigitalOffset.TextLength <> 0 Then
                ret.RET_cantidad_soporte_3_retrabajo = txt_Cantidad_3_PE_DigitalOffset.Text
            End If

            ret.RET_formato_soporte_1_retrabajo = cboFormato_1_PE_DigitalOffset.Text
            ret.RET_formato_soporte_2_retrabajo = cboFormato_2_PE_DigitalOffset.Text
            ret.RET_formato_soporte_3_retrabajo = cboFormato_3_PE_DigitalOffset.Text
            '----------------------------------------------------------------------------

            'PLIEGO MAQUINA OFFSET
            If txtCantidad_1_PM_Offset.TextLength <> 0 Then
                ret.cantidad_1_PM_offset_retrabajo = txtCantidad_1_PM_Offset.Text
            End If
            If txtCantidad_2_PM_Offset.TextLength <> 0 Then
                ret.cantidad_2_PM_offset_retrabajo = txtCantidad_2_PM_Offset.Text
            End If
            If txtCantidad_3_PM_Offset.TextLength <> 0 Then
                ret.cantidad_3_PM_offset_retrabajo = txtCantidad_3_PM_Offset.Text
            End If
            ret.formato_1_PM_offset_retrabajo = cboFormato_1_PM_Offset.Text
            ret.formato_2_PM_offset_retrabajo = cboFormato_2_PM_Offset.Text
            ret.formato_3_PM_offset_retrabajo = cboFormato_3_PM_Offset.Text

            ret.tipo_impresion_offset_retrabajo = cboTipo_Impresion_Offset.Text
            ret.impresora_offset_retrabajo = cboImpresora_Offset.Text
            ret.modo_impresion_offset_retrabajo = cboModo_Impresion_Offset.Text
            '--------------------------------------------------------------------------------
            'PLIEGO MAQUINA DIGITAL
            If txtCantidad_1_PM_Digital.TextLength <> 0 Then
                ret.cantidad_1_PM_digital_retrabajo = txtCantidad_1_PM_Digital.Text
            End If
            If txtCantidad_2_PM_Digital.TextLength <> 0 Then
                ret.cantidad_2_PM_digital_retrabajo = txtCantidad_2_PM_Digital.Text
            End If
            If txtCantidad_3_PM_Digital.TextLength <> 0 Then
                ret.cantidad_3_PM_digital_retrabajo = txtCantidad_3_PM_Digital.Text
            End If

            ret.formato_1_PM_digital_retrabajo = cboFormato_1_PM_Digital.Text
            ret.formato_2_PM_digital_retrabajo = cboFormato_2_PM_Digital.Text
            ret.formato_3_PM_digital_retrabajo = cboFormato_3_PM_Digital.Text

            ret.tipo_impresion_digital_retrabajo = cboTipo_Impresion_Digital.Text

            ret.dato_variable_retrabajo = txtDato_Variable.Text

            datacontext.RE_TRABAJO.InsertOnSubmit(ret)
            datacontext.SubmitChanges()

            MsgBox("El re_trabajo se ha guardado correctamente", vbInformation)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al cargar el Re-Trabajo")
        End Try
    End Sub

    Private Sub chkOffset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOffset.CheckedChanged
        If chkOffset.Checked = True Then
            GroupProducto1.Enabled = True
            groupOffset.Enabled = True
        Else
            groupOffset.Enabled = False
            GroupProducto1.Enabled = False
            'LimpiarProducto_Soportes()
            'LimpiarOffset()
        End If
    End Sub

    Private Sub chkDigital_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDigital.CheckedChanged
        If chkDigital.Checked = True Then
            GroupDigital.Enabled = True
            GroupProducto1.Enabled = True
        Else
            GroupDigital.Enabled = False
            GroupProducto1.Enabled = False
            'LimpiarProducto_Soportes()
            'LimpiarDigital()
        End If
    End Sub

    Private Sub txt_Cantidad_1_PE_DigitalOffset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_1_PE_DigitalOffset.KeyPress
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

    Private Sub txt_Cantidad_2_PE_DigitalOffset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_2_PE_DigitalOffset.KeyPress
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

    Private Sub txt_Cantidad_3_PE_DigitalOffset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_3_PE_DigitalOffset.KeyPress
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

    Private Sub txtCantidad_1_PM_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_1_PM_Offset.KeyPress
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

    Private Sub txtCantidad_2_PM_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_2_PM_Offset.KeyPress
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

    Private Sub txtCantidad_3_PM_Offset_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_3_PM_Offset.KeyPress
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

    Private Sub txtCantidad_1_PM_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_1_PM_Digital.KeyPress
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

    Private Sub txtCantidad_2_PM_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_2_PM_Digital.KeyPress
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

    Private Sub txtCantidad_3_PM_Digital_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad_3_PM_Digital.KeyPress
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

    Private Sub rbtNumeroOrden_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNumeroOrden.CheckedChanged
        cboBuscar_Mes.Enabled = False
        cboBuscar_Mes.SelectedIndex = -1
        txt_Buscar_ReTrabajo.Enabled = True
    End Sub

    Private Sub rbtMes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMes.CheckedChanged
        cboBuscar_Mes.Enabled = True
        txt_Buscar_ReTrabajo.Enabled = False
        txt_Buscar_ReTrabajo.Clear()
    End Sub


    Private Sub ArmaGrillaRetrabajo()
        dgvListado_ReTrabajo.Enabled = True
        dgvListado_ReTrabajo.AutoGenerateColumns = False
        dgvListado_ReTrabajo.Columns.Clear()

        'DATOS RETRABAJOS
        dgvListado_ReTrabajo.Columns.Add("RET_id_retrabajo", "RET_id_retrabajo") '0
        dgvListado_ReTrabajo.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo") '1
        dgvListado_ReTrabajo.Columns.Add("ORT_numero_ot", "Número de Orden") '2
        dgvListado_ReTrabajo.Columns.Add("ORT_fecha_ot", "Fecha Original") '25
        dgvListado_ReTrabajo.Columns.Add("ORT_fecha_entrega", "Fecha Entrega Original") '26
        dgvListado_ReTrabajo.Columns.Add("DOT_cantidad_dot", "DOT_cantidad_dot") '8
        dgvListado_ReTrabajo.Columns.Add("PIE_id_pieza", "id_pieza") '4
        dgvListado_ReTrabajo.Columns.Add("PIE_nombre_pie", "Pieza") '5
        dgvListado_ReTrabajo.Columns.Add("DOT_tamaño_dot", "Tamaño") '9
        '---------------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_producto_retrabajo", "RET_cantidad_producto_retrabajo") '3
        dgvListado_ReTrabajo.Columns.Add("RET_fecha_comienzo_retrabajo", "RET_fecha_comienzo_retrabajo") '6
        dgvListado_ReTrabajo.Columns.Add("RET_fecha_entrega_retrabajo", "RET_fecha_entrega_retrabajo") '7
        dgvListado_ReTrabajo.Columns.Add("RET_origen_area_motivo", "RET_origen_area_motivo") '23
        dgvListado_ReTrabajo.Columns.Add("RET_procedimiento_observaciones", "RET_procedimiento_observaciones") '24
        '--------------------------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("RET_papel_soporte_1_retrabajo", "RET_papel_soporte_1_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("RET_papel_soporte_2_retrabajo", "RET_papel_soporte_2_retrabajo") '15
        dgvListado_ReTrabajo.Columns.Add("RET_papel_soporte_2_retrabajo", "RET_papel_soporte_3_retrabajo")

        dgvListado_ReTrabajo.Columns.Add("RET_gramaje_soporte_1_retrabajo", "RET_gramaje_soporte_1_retrabajo") '12
        dgvListado_ReTrabajo.Columns.Add("RET_gramaje_soporte_2_retrabajo", "RET_gramaje_soporte_2_retrabajo") '16
        dgvListado_ReTrabajo.Columns.Add("RET_gramaje_soporte_3_retrabajo", "RET_gramaje_soporte_3_retrabajo") '16
        '----------------------------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_soporte_1_retrabajo", "RET_cantidad_soporte_1_retrabajo") '13
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_soporte_2_retrabajo", "RET_cantidad_soporte_2_retrabajo") '13
        dgvListado_ReTrabajo.Columns.Add("RET_cantidad_soporte_3_retrabajo", "RET_cantidad_soporte_3_retrabajo") '13
        dgvListado_ReTrabajo.Columns.Add("RET_formato_soporte_1_retrabajo", "RET_formato_soporte_1_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("RET_formato_soporte_2_retrabajo", "RET_formato_soporte_2_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("RET_formato_soporte_3_retrabajo", "RET_formato_soporte_3_retrabajo") '14
        '------------------------------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("cantidad_1_PM_offset_retrabajo", "cantidad_1_PM_offset_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("cantidad_2_PM_offset_retrabajo", "cantidad_2_PM_offset_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("cantidad_3_PM_offset_retrabajo", "cantidad_3_PM_offset_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("formato_1_PM_offset_retrabajo", "formato_1_PM_offset_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("formato_2_PM_offset_retrabajo", "formato_2_PM_offset_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("formato_3_PM_offset_retrabajo", "formato_3_PM_offset_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("tipo_impresion_offset_retrabajo", "tipo_impresion_offset_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("impresora_offset_retrabajo", "impresora_offset_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("modo_impresion_offset_retrabajo", "modo_impresion_offset_retrabajo")
        '-------------------------------------------------------------------------------------------------------------
        dgvListado_ReTrabajo.Columns.Add("cantidad_1_PM_digital_retrabajo", "cantidad_1_PM_digital_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("cantidad_2_PM_digital_retrabajo", "cantidad_2_PM_digital_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("cantidad_3_PM_digital_retrabajo", "cantidad_3_PM_digital_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("formato_1_PM_digital_retrabajo", "formato_1_PM_digital_retrabajo") '14
        dgvListado_ReTrabajo.Columns.Add("formato_2_PM_digital_retrabajo", "formato_2_PM_digital_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("formato_3_PM_digital_retrabajo", "formato_3_PM_digital_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("tipo_impresion_digital_retrabajo", "tipo_impresion_digital_retrabajo")
        dgvListado_ReTrabajo.Columns.Add("dato_variable_retrabajo", "dato_variable_retrabajo")


        dgvListado_ReTrabajo.Columns(0).DataPropertyName = "RET_id_retrabajo"
        dgvListado_ReTrabajo.Columns(0).Visible = False
        dgvListado_ReTrabajo.Columns(1).DataPropertyName = "ORT_id_orden_trabajo"
        dgvListado_ReTrabajo.Columns(1).Visible = False
        dgvListado_ReTrabajo.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvListado_ReTrabajo.Columns(3).DataPropertyName = "RET_cantidad_dort"
        dgvListado_ReTrabajo.Columns(4).DataPropertyName = "PIE_id_pieza"
        dgvListado_ReTrabajo.Columns(4).Visible = False
        dgvListado_ReTrabajo.Columns(5).DataPropertyName = "PIE_nombre_pie"
        dgvListado_ReTrabajo.Columns(6).DataPropertyName = "RET_fecha"
        dgvListado_ReTrabajo.Columns(7).DataPropertyName = "RET_fecha_entrega"
        dgvListado_ReTrabajo.Columns(8).DataPropertyName = "DOT_cantidad_dot"
        dgvListado_ReTrabajo.Columns(8).Visible = False
        dgvListado_ReTrabajo.Columns(9).DataPropertyName = "DOT_tamaño_dot"
        dgvListado_ReTrabajo.Columns(9).Visible = False
        dgvListado_ReTrabajo.Columns(10).DataPropertyName = "RET_tipo_impresion_dort"
        dgvListado_ReTrabajo.Columns(10).Visible = False
        dgvListado_ReTrabajo.Columns(11).DataPropertyName = "RET_papel_soporte_1"
        dgvListado_ReTrabajo.Columns(12).DataPropertyName = "RET_gramaje_soporte_1"
        dgvListado_ReTrabajo.Columns(13).DataPropertyName = "RET_cantidad_soporte_1"
        dgvListado_ReTrabajo.Columns(14).DataPropertyName = "RET_formato_soporte_1"
        dgvListado_ReTrabajo.Columns(15).DataPropertyName = "RET_papel_soporte_2"
        dgvListado_ReTrabajo.Columns(15).Visible = False
        dgvListado_ReTrabajo.Columns(16).DataPropertyName = "RET_gramaje_soporte_2"
        dgvListado_ReTrabajo.Columns(16).Visible = False
        dgvListado_ReTrabajo.Columns(17).DataPropertyName = "RET_cantidad_soporte_2"
        dgvListado_ReTrabajo.Columns(17).Visible = False
        dgvListado_ReTrabajo.Columns(18).DataPropertyName = "RET_formato_soporte_2"
        dgvListado_ReTrabajo.Columns(18).Visible = False
        dgvListado_ReTrabajo.Columns(19).DataPropertyName = "RET_papel_soporte_3"
        dgvListado_ReTrabajo.Columns(19).Visible = False
        dgvListado_ReTrabajo.Columns(20).DataPropertyName = "RET_gramaje_soporte_3"
        dgvListado_ReTrabajo.Columns(20).Visible = False
        dgvListado_ReTrabajo.Columns(21).DataPropertyName = "RET_cantidad_soporte_3"
        dgvListado_ReTrabajo.Columns(21).Visible = False
        dgvListado_ReTrabajo.Columns(22).DataPropertyName = "RET_formato_soporte_3"
        dgvListado_ReTrabajo.Columns(22).Visible = False
        dgvListado_ReTrabajo.Columns(23).DataPropertyName = "RET_origen_area"
        dgvListado_ReTrabajo.Columns(24).DataPropertyName = "RET_procedimiento"
        dgvListado_ReTrabajo.Columns(25).DataPropertyName = "ORT_fecha_ot"
        dgvListado_ReTrabajo.Columns(25).Visible = False
        dgvListado_ReTrabajo.Columns(26).DataPropertyName = "ORT_fecha_entrega"
        dgvListado_ReTrabajo.Columns(26).Visible = False
    End Sub
End Class