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
        cboPiezas1_Detalle1.Enabled = False
        txtTamaño1_Detalle1.Enabled = False
        cboTipoImpresion.Enabled = False
        'txt_id_detalle_orden_trabajo1.Visible = False
        txt_cantidad_original.Enabled = False
        dtp_Fecha_Ingreso_Original.Enabled = False
        dtpFecha_Entrega_Original.Enabled = False
        Label45.Visible = False
        Label1.Visible = False
        'txt_id_re_trabajo.Visible = False
        'btnImprimir.Enabled = False
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar_ReTrabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_cantidad_retrabajo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad_retrabajo.KeyPress
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

    Private Sub txt_Gramaje1_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Gramaje1_Soporte1.KeyPress
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

    Private Sub txt_Gramaje2_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Gramaje2_Soporte1.KeyPress
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

    Private Sub txt_Gramaje3_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Gramaje3_Soporte1.KeyPress
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

    Private Sub txt_Cantidad1_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad1_Soporte1.KeyPress
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

    Private Sub txt_Cantidad2_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad2_Soporte1.KeyPress
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

    Private Sub txt_Cantidad3_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad3_Soporte1.KeyPress
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

        If txt_cantidad_retrabajo.Text.Length = 0 Then
            MsgBox("Ingrese la nueva Cantidad")
            txt_cantidad_retrabajo.Focus()
            Exit Sub
        End If

        'GUARDA RETRABAJO
        Dim ret = New RE_TRABAJO

        ret.RET_origen_area_motivo = StrConv(txt_origen.Text, VbStrConv.ProperCase)
        ret.RET_procedimiento_observaciones = StrConv(txt_procedimiento.Text, VbStrConv.ProperCase)
        ret.RET_fecha_comienzo_retrabajo = StrConv(dtpFecha_Re_Trabajo.Text, VbStrConv.ProperCase)
        ret.RET_fecha_entrega_retrabajo = StrConv(dtp_Nueva_Fecha_Entrega.Text, VbStrConv.ProperCase)

        ret.id_detalle_orden_trabajo = txt_id_detalle.Text

        ret.RET_cantidad_producto_retrabajo = txt_cantidad_retrabajo.Text
        ret.RET_tamaño_producto_retrabajo = txtTamaño1_Detalle1.Text

        ret.RET_tipo_impresion_retrabajo = cboTipoImpresion.Text
        ret.RET_papel_soporte_1_retrabajo = StrConv(txt_Papel1_Soporte1.Text, VbStrConv.ProperCase)
        ret.RET_papel_soporte_2_retrabajo = StrConv(txt_Papel2_Soporte1.Text, VbStrConv.ProperCase)
        ret.RET_papel_soporte_3_retrabajo = StrConv(txt_Papel3_Soporte1.Text, VbStrConv.ProperCase)

        ret.RET_gramaje_soporte_1_retrabajo = StrConv(txt_Gramaje1_Soporte1.Text, VbStrConv.ProperCase)
        ret.RET_gramaje_soporte_2_retrabajo = StrConv(txt_Gramaje2_Soporte1.Text, VbStrConv.ProperCase)
        ret.RET_gramaje_soporte_3_retrabajo = StrConv(txt_Gramaje3_Soporte1.Text, VbStrConv.ProperCase)

        If txt_Cantidad1_Soporte1.TextLength <> 0 Then
            ret.RET_cantidad_soporte_1_retrabajo = txt_Cantidad1_Soporte1.Text
        End If

        If txt_Cantidad2_Soporte1.TextLength <> 0 Then
            ret.RET_cantidad_soporte_2_retrabajo = txt_Cantidad2_Soporte1.Text
        End If
        If txt_Cantidad3_Soporte1.TextLength <> 0 Then
            ret.RET_cantidad_soporte_3_retrabajo = txt_Cantidad3_Soporte1.Text
        End If

        ret.RET_formato_soporte_1_retrabajo = cboFormato1_Soporte1.Text
        ret.RET_formato_soporte_2_retrabajo = cboFormato2_Soporte1.Text
        ret.RET_formato_soporte_3_retrabajo = cboFormato3_Soporte1.Text

        datacontext.RE_TRABAJO.InsertOnSubmit(ret)
        datacontext.SubmitChanges()

        MsgBox("El re_trabajo se ha creado correctamente", vbInformation)
        Me.Close()
        'Catch ex As Exception
        '    MsgBox("Error al cargar el Re-Trabajo")
        'End Try
    End Sub
End Class