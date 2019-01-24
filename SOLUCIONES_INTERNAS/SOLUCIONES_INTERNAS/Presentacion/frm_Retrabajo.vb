Public Class frm_retrabajo
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
        '  Try
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

        MsgBox("El re_trabajo se ha creado correctamente", vbInformation)
        Me.Close()
        'Catch ex As Exception
        '    MsgBox("Error al cargar el Re-Trabajo")
        'End Try
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

End Class