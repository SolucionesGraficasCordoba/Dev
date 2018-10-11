Public Class frm_Orden_Trabajo

    Dim datacontext As New DataS_Interno
    Public quienllamo_listado_orden As Form


    Private Sub frm_Orden_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If quienllamo_listado_orden.Name <> frm_Listado_Orden_Trabajo.Name Then

            'CARGA COMBOBOX PIEZA DETALLE 1
            Dim combopieza1 = (From sec In datacontext.PIEZA
                               Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                               Order By PIE_nombre_pie Ascending)
            cboPiezas1_Detalle1.DataSource = combopieza1
            cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
            cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"
            cboPiezas1_Detalle1.SelectedIndex = -1

            'CARGA COMBOBOX PIEZA DETALLE 2
            Dim combopieza2 = (From sec In datacontext.PIEZA
                               Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                               Order By PIE_nombre_pie Ascending)
            cboPiezas2_Detalle2.DataSource = combopieza2
            cboPiezas2_Detalle2.DisplayMember = "PIE_nombre_pie"
            cboPiezas2_Detalle2.ValueMember = "PIE_id_pieza"
            cboPiezas2_Detalle2.SelectedIndex = -1

            'CARGA COMBOBOX PIEZA DETALLE 3
            Dim combopieza3 = (From sec In datacontext.PIEZA
                               Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                               Order By PIE_nombre_pie Ascending)
            cboPiezas3_Detalle3.DataSource = combopieza3
            cboPiezas3_Detalle3.DisplayMember = "PIE_nombre_pie"
            cboPiezas3_Detalle3.ValueMember = "PIE_id_pieza"
            cboPiezas3_Detalle3.SelectedIndex = -1
        Else

        End If
    End Sub

    Sub limpiarcontroles()
        'LIMPIA ORDEN TRABAJO
        dtpFecha_Orden_Trabajo.Text = Now
        cboTipo_Orden.SelectedIndex = -1
        txtNumero_Orden_Trabajo.Clear()
        txt_observaciones.Clear()
        txt_mejoras.Clear()
        txtid_vendedor.Clear()
        txtNombre_vendedor.Clear()
        txt_id_cliente.Clear()
        txt_nombre_cliente.Clear()

        'LIMPIA DETALLE DE LA ORDEN
        txt_cantidad1_detalle1.Clear()
        txt_cantidad2_detalle2.Clear()
        txt_cantidad3_detalle3.Clear()
        cboPiezas1_Detalle1.SelectedIndex = -1
        cboPiezas2_Detalle2.SelectedIndex = -1
        cboPiezas3_Detalle3.SelectedIndex = -1
        txtTamaño1_Detalle1.Clear()
        txtTamaño2_Detalle2.Clear()
        txtTamaño3_Detalle3.Clear()
        cboTipoImpresion1_Detalle1.SelectedIndex = -1
        cboTipoImpresion2_Detalle2.SelectedIndex = -1
        cboTipoImpresion3_Detalle3.SelectedIndex = -1
        txt_Papel1_Soporte1.Clear()
        txt_Papel2_Soporte1.Clear()
        txt_Papel3_Soporte1.Clear()
        txt_Papel1_Soporte2.Clear()
        txt_Papel2_Soporte2.Clear()
        txt_Papel3_Soporte2.Clear()
        txt_Papel1_Soporte3.Clear()
        txt_Papel2_Soporte3.Clear()
        txt_Papel3_Soporte3.Clear()
        txt_Gramaje1_Soporte1.Clear()
        txt_Gramaje2_Soporte1.Clear()
        txt_Gramaje3_Soporte1.Clear()
        txt_Gramaje1_Soporte2.Clear()
        txt_Gramaje2_Soporte2.Clear()
        txt_Gramaje3_Soporte2.Clear()
        txt_Gramaje1_Soporte3.Clear()
        txt_Gramaje2_Soporte3.Clear()
        txt_Gramaje3_Soporte3.Clear()
        txt_Cantidad1_Soporte1.Clear()
        txt_Cantidad2_Soporte1.Clear()
        txt_Cantidad3_Soporte1.Clear()
        txt_Cantidad1_Soporte2.Clear()
        txt_Cantidad2_Soporte2.Clear()
        txt_Cantidad3_Soporte2.Clear()
        txt_Cantidad1_Soporte3.Clear()
        txt_Cantidad2_Soporte3.Clear()
        txt_Cantidad3_Soporte3.Clear()
        cboFormato1_Soporte1.SelectedIndex = -1
        cboFormato2_Soporte1.SelectedIndex = -1
        cboFormato3_Soporte1.SelectedIndex = -1
        cboFormato1_Soporte2.SelectedIndex = -1
        cboFormato2_Soporte2.SelectedIndex = -1
        cboFormato3_Soporte2.SelectedIndex = -1
        cboFormato1_Soporte3.SelectedIndex = -1
        cboFormato2_Soporte3.SelectedIndex = -1
        cboFormato3_Soporte3.SelectedIndex = -1
    End Sub

    Private Sub btnBuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Vendedor"
        frm_Cliente.Show()
        frm_Cliente.GroupNuevoCliente.Enabled = False
    End Sub

    Private Sub btnBuscar_Vendedor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Vendedor.Click
        frm_Vendedor.Text = "Seleccionar Vendedor"
        frm_Vendedor.Show()
        frm_Vendedor.GroupNuevoVendedor.Enabled = False

    End Sub

    Private Sub txt_cantidad1_detalle1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_cantidad2_detalle2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_cantidad3_detalle3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad1_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad2_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad3_Soporte1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad1_Soporte2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad2_Soporte2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad3_Soporte2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad1_Soporte3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad2_Soporte3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_Cantidad3_Soporte3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub btnCancelar_Orden_Trabajo_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnProceso_Click(sender As System.Object, e As System.EventArgs) Handles btnProceso1.Click
        frm_Proceso1.Text = "Proceso Primer Producto"
        frm_Proceso1.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnProceso2.Click
        frm_Proceso2.Text = "Proceso Segundo Producto"
        frm_Proceso2.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnProceso3.Click
        frm_proceso3.Text = "Proceso Tercer Producto"
        frm_proceso3.Show()
    End Sub

    Private Sub btnNueva_Orden_Trabajo_Click_2(sender As System.Object, e As System.EventArgs) Handles btnNueva_Orden_Trabajo.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Orden_Trabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnImprimir_Click_1(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        ' PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 65
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 60
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0

        btnNueva_Orden_Trabajo.Visible = False
        btnImprimir.Visible = False
        btnGuardar_Orden_Trabajo.Visible = False
        btnActualizar_Orden_Trabajo.Visible = False
        btnCancelar_Orden_Trabajo.Visible = False
        Label17.Visible = False
        PrintForm1.Print()
    End Sub

    Private Sub btnGuardar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_Orden_Trabajo.Click

        'VALIDA LOS CAMPOS OBLIGATORIOS
        Try
            If txtNumero_Orden_Trabajo.Text.Length = 0 _
              Or cboTipo_Orden.Text.Length = 0 _
              Or txtid_vendedor.Text.Length = 0 _
              Or txt_id_cliente.Text.Length = 0 _
              Or txt_cantidad1_detalle1.Text.Length = 0 _
              Or cboPiezas1_Detalle1.Text.Length = 0 _
              Or txtTamaño1_Detalle1.Text.Length = 0 _
              Or cboTipoImpresion1_Detalle1.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            'GUARDA ORDEN DE TRABAJO
            Dim clie = New ORDEN_TRABAJO
            clie.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
            clie.ORT_tipo_ot = cboTipo_Orden.Text
            clie.ORT_numero_ot = txtNumero_Orden_Trabajo.Text
            clie.ORT_observaciones_ot = txt_observaciones.Text
            clie.ORT_mejoras_ot = txt_mejoras.Text
            clie.VEN_id_vendedor = txtid_vendedor.Text
            clie.CLI_id_cliente = txt_id_cliente.Text

            datacontext.ORDEN_TRABAJO.InsertOnSubmit(clie)
            datacontext.SubmitChanges()

            'GUARDA EL REGISTRO 1 DEL DETALLE DE LA ORDEN DE TRABAJO
            If txt_cantidad1_detalle1.Text.Length >= 1 Then
                If cboPiezas1_Detalle1.Text.Length = 0 Then
                    MsgBox("Seleccione una pieza")
                End If

                Dim detalle = New DETALLE_ORDEN_TRABAJO
                'id
                txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo
                detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
                detalle.DOT_cantidad_dot = txt_cantidad1_detalle1.Text  'CANTIDAD PRODUCTO 1
                detalle.DOT_tamaño_dot = txtTamaño1_Detalle1.Text 'TAMAÑO PRODUCTO 1
                detalle.DOT_tipo_impresion_dot = cboTipoImpresion1_Detalle1.SelectedItem 'TIPO IMPRESION PRODUCTO 1
                detalle.PIE_id_pieza = cboPiezas1_Detalle1.SelectedValue 'TIPO PIEZA PRODUCTO 1

                txt_id_orden_trabajo.Text = clie.ORT_id_orden_trabajo
                detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text 'ID ORDEN TRABAJO

                'PAPEL PRODUCTO 1
                detalle.DOT_papel_soporte_1 = txt_Papel1_Soporte1.Text
                detalle.DOT_papel_soporte_2 = txt_Papel2_Soporte1.Text
                detalle.DOT_papel_soporte_3 = txt_Papel3_Soporte1.Text

                'GRAMAJE PRODUCTO 1
                detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte1.Text
                detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte1.Text
                detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte1.Text

                'CANTIDAD PRODUCTO 1
                If txt_Cantidad1_Soporte1.TextLength = 0 Then
                    txt_Cantidad1_Soporte1.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte1.Text
                End If
                If txt_Cantidad2_Soporte1.TextLength = 0 Then
                    txt_Cantidad2_Soporte1.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte1.Text
                End If
                If txt_Cantidad3_Soporte1.TextLength = 0 Then
                    txt_Cantidad3_Soporte1.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte1.Text
                End If
                'FORMATO PRODUCTO 1
                detalle.DOT_formato_soporte_1 = cboFormato1_Soporte1.SelectedItem
                detalle.DOT_formato_soporte_2 = cboFormato2_Soporte1.SelectedItem
                detalle.DOT_formato_soporte_3 = cboFormato3_Soporte1.SelectedItem

                datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                datacontext.SubmitChanges()

                '-----------------------------------------------------------------------
                'GUARDA TABLA PROCESO PRODUCTO 1
                Dim proceso = New PROCESO
                txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo
                proceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

                If frm_Proceso1.txt_descripc_offset.TextLength = 0 Then
                    frm_Proceso1.groupOffSet.Text = ""
                Else
                    proceso.PROC_offset = frm_Proceso1.groupOffSet.Text
                    proceso.PROC_descrip_offset = frm_Proceso1.txt_descripc_offset.Text
                End If
                If frm_Proceso1.txt_descripc_digital.TextLength = 0 Then
                    frm_Proceso1.groupDigital.Text = ""
                Else
                    proceso.PROC_digital = frm_Proceso1.groupDigital.Text
                    proceso.PROC_descrip_digital = frm_Proceso1.txt_descripc_digital.Text
                End If
                If frm_Proceso1.txt_descripc_gran_formato.TextLength = 0 Then
                    frm_Proceso1.groupGranFormato.Text = ""
                Else
                    proceso.PROC_gran_formato = frm_Proceso1.groupGranFormato.Text
                    proceso.PROC_descrip_gran_formato = frm_Proceso1.txt_descripc_gran_formato.Text
                End If
                If frm_Proceso1.txt_descripc_terminacion.TextLength = 0 Then
                    frm_Proceso1.groupTerminacion.Text = ""
                Else
                    proceso.PROC_terminacion = frm_Proceso1.groupTerminacion.Text
                    proceso.PROC_descrip_terminacion = frm_Proceso1.txt_descripc_terminacion.Text
                End If
                If frm_Proceso1.txt_descripc_logistica.TextLength = 0 Then
                    frm_Proceso1.groupLogistica.Text = ""
                Else
                    proceso.PROC_logistica = frm_Proceso1.groupLogistica.Text
                    proceso.PROC_descrip_logistica = frm_Proceso1.txt_descripc_logistica.Text
                End If
                datacontext.PROCESO.InsertOnSubmit(proceso)
                datacontext.SubmitChanges()

            End If

            'GUARDA EL REGISTRO 2 DEL DETALLE DE LA ORDEN DE TRABAJO
            If txt_cantidad2_detalle2.Text.Length >= 1 Then
                If cboPiezas2_Detalle2.Text.Length = 0 Then
                    MsgBox("Seleccione una Pieza")
                End If

                Dim detalle = New DETALLE_ORDEN_TRABAJO
                'id
                txt_id_detalle_orden_trabajo2.Text = detalle.id_detalle_orden_trabajo
                detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                'CANTIDAD REGISTRO 2
                detalle.DOT_cantidad_dot = txt_cantidad2_detalle2.Text
                'TAMAÑO REGISTRO 1
                detalle.DOT_tamaño_dot = txtTamaño2_Detalle2.Text
                'TIPO IMPRESION REGISTRO 2
                detalle.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.SelectedItem
                'TIPO PIEZA REGISTRO 2
                detalle.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue
                'ID ORDEN TRABAJO
                txt_id_orden_trabajo.Text = clie.ORT_id_orden_trabajo
                detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text

                'PAPEL REGISTRO 2
                detalle.DOT_papel_soporte_1 = txt_Papel1_Soporte2.Text
                detalle.DOT_papel_soporte_2 = txt_Papel2_Soporte2.Text
                detalle.DOT_papel_soporte_3 = txt_Papel3_Soporte2.Text

                'GRAMAJE REGISTRO 2
                detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte2.Text
                detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte2.Text
                detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte2.Text

                'CANTIDAD REGISTRO 2
                If txt_Cantidad1_Soporte2.TextLength = 0 Then
                    txt_Cantidad1_Soporte2.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte2.Text
                End If

                If txt_Cantidad2_Soporte2.TextLength = 0 Then
                    txt_Cantidad2_Soporte2.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte2.Text
                End If

                If txt_Cantidad3_Soporte2.TextLength = 0 Then
                    txt_Cantidad3_Soporte2.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte2.Text
                End If

                'FORMATO REGISTRO 2
                detalle.DOT_formato_soporte_1 = cboFormato1_Soporte2.SelectedItem
                detalle.DOT_formato_soporte_2 = cboFormato2_Soporte2.SelectedItem
                detalle.DOT_formato_soporte_3 = cboFormato3_Soporte2.SelectedItem

                datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                datacontext.SubmitChanges()

                'GUARDA TABLA PROCESO PRODUCTO 2
                Dim proceso = New PROCESO
                txt_id_detalle_orden_trabajo2.Text = detalle.id_detalle_orden_trabajo
                proceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                If frm_Proceso2.txt_descripc_offset.TextLength = 0 Then
                    frm_Proceso2.groupOffSet.Text = ""
                Else
                    proceso.PROC_offset = frm_Proceso2.groupOffSet.Text
                    proceso.PROC_descrip_offset = frm_Proceso2.txt_descripc_offset.Text
                End If
                If frm_Proceso2.txt_descripc_digital.TextLength = 0 Then
                    frm_Proceso2.groupDigital.Text = ""
                Else
                    proceso.PROC_digital = frm_Proceso2.groupDigital.Text
                    proceso.PROC_descrip_digital = frm_Proceso2.txt_descripc_digital.Text
                End If
                If frm_Proceso2.txt_descripc_gran_formato.TextLength = 0 Then
                    frm_Proceso2.groupGranFormato.Text = ""
                Else
                    proceso.PROC_gran_formato = frm_Proceso2.groupGranFormato.Text
                    proceso.PROC_descrip_gran_formato = frm_Proceso2.txt_descripc_gran_formato.Text
                End If
                If frm_Proceso2.txt_descripc_terminacion.TextLength = 0 Then
                    frm_Proceso2.groupTerminacion.Text = ""
                Else
                    proceso.PROC_terminacion = frm_Proceso2.groupTerminacion.Text
                    proceso.PROC_descrip_terminacion = frm_Proceso2.txt_descripc_terminacion.Text
                End If
                If frm_Proceso2.txt_descripc_logistica.TextLength = 0 Then
                    frm_Proceso2.groupLogistica.Text = ""
                Else
                    proceso.PROC_logistica = frm_Proceso2.groupLogistica.Text
                    proceso.PROC_descrip_logistica = frm_Proceso2.txt_descripc_logistica.Text
                End If
                datacontext.PROCESO.InsertOnSubmit(proceso)
                datacontext.SubmitChanges()
            End If

            'GUARDA EL REGISTRO 3 DEL DETALLE DE LA ORDEN DE TRABAJO
            If txt_cantidad3_detalle3.Text.Length >= 1 Then
                If cboPiezas3_Detalle3.Text.Length = 0 Then
                    MsgBox("Seleccione una Pieza")
                End If
                Dim detalle = New DETALLE_ORDEN_TRABAJO
                'id
                txt_id_detalle_orden_trabajo3.Text = detalle.id_detalle_orden_trabajo
                detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                'CANTIDAD REGISTRO 3
                detalle.DOT_cantidad_dot = txt_cantidad3_detalle3.Text
                'TAMAÑO REGISTRO 3
                detalle.DOT_tamaño_dot = txtTamaño3_Detalle3.Text
                'TIPO IMPRESION REGISTRO 3
                detalle.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.SelectedItem
                'TIPO PIEZA REGISTRO 3
                detalle.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue
                'ID ORDEN TRABAJO
                txt_id_orden_trabajo.Text = clie.ORT_id_orden_trabajo
                detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
                'PAPEL REGISTRO 3
                detalle.DOT_papel_soporte_1 = txt_Papel1_Soporte3.Text
                detalle.DOT_papel_soporte_2 = txt_Papel2_Soporte3.Text
                detalle.DOT_papel_soporte_3 = txt_Papel3_Soporte3.Text
                'GRAMAJE REGISTRO 3
                detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte3.Text
                detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte3.Text
                detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte3.Text
                'CANTIDAD REGISTRO 3
                If txt_Cantidad1_Soporte3.TextLength = 0 Then
                    txt_Cantidad1_Soporte3.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte3.Text
                End If
                If txt_Cantidad2_Soporte3.TextLength = 0 Then
                    txt_Cantidad2_Soporte3.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte3.Text
                End If
                If txt_Cantidad3_Soporte3.TextLength = 0 Then
                    txt_Cantidad3_Soporte3.Text = 0
                Else
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte3.Text
                End If
                'FORMATO REGISTRO 3
                detalle.DOT_formato_soporte_1 = cboFormato1_Soporte3.SelectedItem
                detalle.DOT_formato_soporte_2 = cboFormato2_Soporte3.SelectedItem
                detalle.DOT_formato_soporte_3 = cboFormato3_Soporte3.SelectedItem

                datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                datacontext.SubmitChanges()

                'GUARDA TABLA PROCESO PRODUCTO 3
                Dim proceso = New PROCESO
                txt_id_detalle_orden_trabajo3.Text = detalle.id_detalle_orden_trabajo
                proceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text

                If frm_proceso3.txt_descripc_offset.TextLength = 0 Then
                    frm_proceso3.groupOffSet.Text = ""
                Else
                    proceso.PROC_offset = frm_proceso3.groupOffSet.Text
                    proceso.PROC_descrip_offset = frm_proceso3.txt_descripc_offset.Text
                End If
                If frm_proceso3.txt_descripc_digital.TextLength = 0 Then
                    frm_proceso3.groupDigital.Text = ""
                Else
                    proceso.PROC_digital = frm_proceso3.groupDigital.Text
                    proceso.PROC_descrip_digital = frm_proceso3.txt_descripc_digital.Text
                End If
                If frm_proceso3.txt_descripc_gran_formato.TextLength = 0 Then
                    frm_proceso3.groupGranFormato.Text = ""
                Else
                    proceso.PROC_gran_formato = frm_proceso3.groupGranFormato.Text
                    proceso.PROC_descrip_gran_formato = frm_proceso3.txt_descripc_gran_formato.Text
                End If
                If frm_proceso3.txt_descripc_terminacion.TextLength = 0 Then
                    frm_proceso3.groupTerminacion.Text = ""
                Else
                    proceso.PROC_terminacion = frm_proceso3.groupTerminacion.Text
                    proceso.PROC_descrip_terminacion = frm_proceso3.txt_descripc_terminacion.Text
                End If
                If frm_proceso3.txt_descripc_logistica.TextLength = 0 Then
                    frm_proceso3.groupLogistica.Text = ""
                Else
                    proceso.PROC_logistica = frm_proceso3.groupLogistica.Text
                    proceso.PROC_descrip_logistica = frm_proceso3.txt_descripc_logistica.Text
                End If
                datacontext.PROCESO.InsertOnSubmit(proceso)
                datacontext.SubmitChanges()
            End If

            MsgBox("la Orden se ha creado correctamente", vbInformation)
            limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la Orden")
            limpiarcontroles()
            ' cargargrilla()
        End Try
    End Sub

    Private Sub btnActualizar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar_Orden_Trabajo.Click
        'VALIDA CAMPOS OBLIGATORIOS
        If txtNumero_Orden_Trabajo.Text.Length = 0 _
                Or cboTipo_Orden.Text.Length = 0 _
                Or txtid_vendedor.Text.Length = 0 _
                Or txt_id_cliente.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            'ACTUALIZA LA ORDEN DE TRABAJO
            Dim ActualizarOrden = (From P In datacontext.ORDEN_TRABAJO Where P.ORT_id_orden_trabajo = (txt_id_orden_trabajo.Text.ToUpper)).ToList()(0)
            ActualizarOrden.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
            ActualizarOrden.ORT_tipo_ot = cboTipo_Orden.SelectedItem
            ActualizarOrden.ORT_numero_ot = txtNumero_Orden_Trabajo.Text
            ActualizarOrden.ORT_observaciones_ot = txt_observaciones.Text
            ActualizarOrden.ORT_mejoras_ot = txt_mejoras.Text
            ActualizarOrden.VEN_id_vendedor = txtid_vendedor.Text
            ActualizarOrden.CLI_id_cliente = txt_id_cliente.Text

            datacontext.SubmitChanges()

            Dim ActualizarDetalle1 = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                                     Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo1.Text)).ToList()(0)

            'ACTUALIZA EL PRIMER REGISTRO
            If txt_cantidad1_detalle1.Text.Length >= 1 Then

                If cboPiezas1_Detalle1.Text.Length = 0 Then
                    MsgBox("Seleccione una pieza")
                End If
                txt_id_detalle_orden_trabajo1.Text = ActualizarDetalle1.id_detalle_orden_trabajo
                ActualizarDetalle1.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
                ActualizarDetalle1.DOT_cantidad_dot = txt_cantidad1_detalle1.Text
                ActualizarDetalle1.PIE_id_pieza = cboPiezas1_Detalle1.SelectedValue
                ActualizarDetalle1.DOT_tamaño_dot = txtTamaño1_Detalle1.Text
                ActualizarDetalle1.DOT_tipo_impresion_dot = cboTipoImpresion1_Detalle1.SelectedItem

                ActualizarDetalle1.DOT_papel_soporte_1 = txt_Papel1_Soporte1.Text
                ActualizarDetalle1.DOT_papel_soporte_2 = txt_Papel2_Soporte1.Text
                ActualizarDetalle1.DOT_papel_soporte_3 = txt_Papel3_Soporte1.Text

                ActualizarDetalle1.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte1.Text
                ActualizarDetalle1.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte1.Text
                ActualizarDetalle1.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte1.Text

                ActualizarDetalle1.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte1.Text
                ActualizarDetalle1.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte1.Text
                ActualizarDetalle1.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte1.Text

                ActualizarDetalle1.DOT_formato_soporte_1 = cboFormato1_Soporte1.SelectedItem
                ActualizarDetalle1.DOT_formato_soporte_2 = cboFormato2_Soporte1.SelectedItem
                ActualizarDetalle1.DOT_formato_soporte_3 = cboFormato3_Soporte1.SelectedItem

                datacontext.SubmitChanges()
            End If
            If txt_id_detalle_orden_trabajo2.Text.Length <> 0 Then

                'ACTUALIZA EL SEGUNDO REGISTRO
                Dim ActualizarDetalle2 = (From D In datacontext.DETALLE_ORDEN_TRABAJO
                                          Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo2.Text)).ToList()(0)

                If txt_cantidad2_detalle2.Text.Length >= 1 Then

                    If cboPiezas2_Detalle2.Text.Length = 0 Then
                        MsgBox("Seleccione una pieza")
                    End If

                    txt_id_detalle_orden_trabajo2.Text = ActualizarDetalle2.id_detalle_orden_trabajo
                    ActualizarDetalle2.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                    ActualizarDetalle2.DOT_cantidad_dot = txt_cantidad2_detalle2.Text
                    ActualizarDetalle2.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue
                    ActualizarDetalle2.DOT_tamaño_dot = txtTamaño2_Detalle2.Text
                    ActualizarDetalle2.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.SelectedItem

                    ActualizarDetalle2.DOT_papel_soporte_1 = txt_Papel1_Soporte2.Text
                    ActualizarDetalle2.DOT_papel_soporte_2 = txt_Papel2_Soporte2.Text
                    ActualizarDetalle2.DOT_papel_soporte_3 = txt_Papel3_Soporte2.Text

                    ActualizarDetalle2.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte2.Text
                    ActualizarDetalle2.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte2.Text
                    ActualizarDetalle2.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte2.Text

                    ActualizarDetalle2.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte2.Text
                    ActualizarDetalle2.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte2.Text
                    ActualizarDetalle2.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte2.Text

                    ActualizarDetalle2.DOT_formato_soporte_1 = cboFormato1_Soporte2.SelectedItem
                    ActualizarDetalle2.DOT_formato_soporte_2 = cboFormato2_Soporte2.SelectedItem
                    ActualizarDetalle2.DOT_formato_soporte_3 = cboFormato3_Soporte2.SelectedItem

                    datacontext.SubmitChanges()
                End If
            Else
                'GUARDA EL REGISTRO 2 DEL DETALLE DE LA ORDEN DE TRABAJO
                If txt_cantidad2_detalle2.Text.Length >= 1 Then

                    If cboPiezas2_Detalle2.Text.Length = 0 Then
                        MsgBox("Seleccione una pieza")
                    End If
                    Dim detalle = New DETALLE_ORDEN_TRABAJO
                    'id
                    txt_id_detalle_orden_trabajo2.Text = detalle.id_detalle_orden_trabajo
                    detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo2.Text
                    detalle.DOT_cantidad_dot = txt_cantidad2_detalle2.Text
                    detalle.DOT_tamaño_dot = txtTamaño2_Detalle2.Text
                    detalle.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.SelectedItem
                    detalle.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue
                    detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text

                    detalle.DOT_papel_soporte_1 = txt_Papel1_Soporte2.Text
                    detalle.DOT_papel_soporte_2 = txt_Papel2_Soporte2.Text
                    detalle.DOT_papel_soporte_3 = txt_Papel3_Soporte2.Text

                    detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte2.Text
                    detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte2.Text
                    detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte2.Text

                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte2.Text
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte2.Text
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte2.Text

                    detalle.DOT_formato_soporte_1 = cboFormato1_Soporte2.SelectedItem
                    detalle.DOT_formato_soporte_2 = cboFormato2_Soporte2.SelectedItem
                    detalle.DOT_formato_soporte_3 = cboFormato3_Soporte2.SelectedItem

                    datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                    datacontext.SubmitChanges()
                End If
            End If
            ''ACTUALIZA EL TERCER REGISTRO
            If txt_id_detalle_orden_trabajo3.Text.Length <> 0 Then

                If txt_cantidad3_detalle3.Text.Length >= 1 Then

                    Dim ActualizarDetalle3 = (From D In datacontext.DETALLE_ORDEN_TRABAJO Where D.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden_trabajo3.Text)).ToList()(0)

                    If cboPiezas3_Detalle3.Text.Length = 0 Then
                        MsgBox("Seleccione una pieza")
                    End If

                    txt_id_detalle_orden_trabajo3.Text = ActualizarDetalle3.id_detalle_orden_trabajo
                    ActualizarDetalle3.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                    ActualizarDetalle3.DOT_cantidad_dot = txt_cantidad3_detalle3.Text
                    ActualizarDetalle3.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue
                    ActualizarDetalle3.DOT_tamaño_dot = txtTamaño3_Detalle3.Text
                    ActualizarDetalle3.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.SelectedItem

                    ActualizarDetalle3.DOT_papel_soporte_1 = txt_Papel1_Soporte3.Text
                    ActualizarDetalle3.DOT_papel_soporte_2 = txt_Papel2_Soporte3.Text
                    ActualizarDetalle3.DOT_papel_soporte_3 = txt_Papel3_Soporte3.Text

                    ActualizarDetalle3.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte3.Text
                    ActualizarDetalle3.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte3.Text
                    ActualizarDetalle3.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte3.Text

                    ActualizarDetalle3.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte3.Text
                    ActualizarDetalle3.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte3.Text
                    ActualizarDetalle3.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte3.Text

                    ActualizarDetalle3.DOT_formato_soporte_1 = cboFormato1_Soporte3.SelectedItem
                    ActualizarDetalle3.DOT_formato_soporte_2 = cboFormato2_Soporte3.SelectedItem
                    ActualizarDetalle3.DOT_formato_soporte_3 = cboFormato3_Soporte3.SelectedItem

                    datacontext.SubmitChanges()
                End If
            Else
                'GUARDA EL REGISTRO 3 DEL DETALLE DE LA ORDEN DE TRABAJO
                If txt_cantidad3_detalle3.Text.Length >= 1 Then

                    If cboPiezas3_Detalle3.Text.Length = 0 Then
                        MsgBox("Seleccione una pieza")
                    End If
                    Dim detalle = New DETALLE_ORDEN_TRABAJO
                    txt_id_detalle_orden_trabajo3.Text = detalle.id_detalle_orden_trabajo
                    detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo3.Text
                    detalle.DOT_cantidad_dot = txt_cantidad3_detalle3.Text
                    detalle.DOT_tamaño_dot = txtTamaño3_Detalle3.Text
                    detalle.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.SelectedItem
                    detalle.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue
                    detalle.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
                    detalle.DOT_papel_soporte_1 = txt_Papel1_Soporte3.Text
                    detalle.DOT_papel_soporte_2 = txt_Papel2_Soporte3.Text
                    detalle.DOT_papel_soporte_3 = txt_Papel3_Soporte3.Text
                    detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte3.Text
                    detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte3.Text
                    detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte3.Text
                    detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte3.Text
                    detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte3.Text
                    detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte3.Text
                    detalle.DOT_formato_soporte_1 = cboFormato1_Soporte3.SelectedItem
                    detalle.DOT_formato_soporte_2 = cboFormato2_Soporte3.SelectedItem
                    detalle.DOT_formato_soporte_3 = cboFormato3_Soporte3.SelectedItem

                    datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
                    datacontext.SubmitChanges()
                End If
            End If
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar orden")
            Me.limpiarcontroles()
        End Try
    End Sub

    Private Sub frm_Orden_Trabajo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class