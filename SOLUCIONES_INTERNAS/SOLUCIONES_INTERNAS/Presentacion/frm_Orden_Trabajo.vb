Public Class frm_Orden_Trabajo
    Dim datacontext As New DataS_Interno

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frm_Detalle_orden_trabajo()
    End Sub

    Private Sub frm_Orden_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_orden_trabajo.Visible = False
        Label1.Visible = False
        Label45.Visible = False
        txt_id_detalle_orden_trabajo.Visible = False
        txtNumero_Orden_Trabajo.Focus()

        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie)
        cboPiezas1_Detalle1.DataSource = combopieza1
        cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
        cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"
        cboPiezas1_Detalle1.SelectedIndex = 0

        'CARGA COMBOBOX PIEZA DETALLE 2
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie)
        cboPiezas2_Detalle2.DataSource = combopieza2
        cboPiezas2_Detalle2.DisplayMember = "PIE_nombre_pie"
        cboPiezas2_Detalle2.ValueMember = "PIE_id_pieza"
        cboPiezas2_Detalle2.SelectedIndex = 0

        'CARGA COMBOBOX PIEZA DETALLE 3
        Dim combopieza3 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie)
        cboPiezas3_Detalle3.DataSource = combopieza3
        cboPiezas3_Detalle3.DisplayMember = "PIE_nombre_pie"
        cboPiezas3_Detalle3.ValueMember = "PIE_id_pieza"
        cboPiezas3_Detalle3.SelectedIndex = 0

    End Sub

    Sub limpiarcontroles()
        dtpFecha_Orden_Trabajo.Text = Now
        cboTipo_Orden.SelectedIndex = -1
        txtNumero_Orden_Trabajo.Clear()
        txt_observaciones.Clear()
        txt_mejoras.Clear()
        txtid_vendedor.Clear()
        txtNombre_vendedor.Clear()
        txt_id_cliente.Clear()
        txt_nombre_cliente.Clear()
    End Sub


    Private Sub btnActualizar_Orden_Trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtNumero_Orden_Trabajo.Text.Length = 0 _
              Or cboTipo_Orden.Text.Length = 0 _
              Or txtid_vendedor.Text.Length = 0 _
              Or txt_id_cliente.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If

        If Not dtpFecha_Orden_Trabajo.Text < Now Then
            MsgBox("La fecha no puede ser anterior al día de hoy")
            Exit Sub
        End If
        Try
            Dim ActualizarOrden = (From P In datacontext.ORDEN_TRABAJO Where P.ORT_id_orden_trabajo = (txt_id_orden_trabajo.Text.ToUpper)).ToList()(0)
            ActualizarOrden.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
            ActualizarOrden.ORT_tipo_ot = cboTipo_Orden.SelectedValue
            ActualizarOrden.ORT_numero_ot = txtNumero_Orden_Trabajo.Text
            ActualizarOrden.ORT_observaciones_ot = txt_observaciones.Text
            ActualizarOrden.ORT_mejoras_ot = txt_mejoras.Text
            ActualizarOrden.VEN_id_vendedor = txtid_vendedor.Text
            ActualizarOrden.CLI_id_cliente = txt_id_cliente.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            '  cargargrilla()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            Me.limpiarcontroles()
            ' Me.cargargrilla()
        End Try
    End Sub

    Private Sub btnNueva_Orden_Trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarcontroles()
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.Text = "Seleccionar Vendedor"
        frm_Cliente.Show()
    End Sub

    Private Sub btnBuscar_Vendedor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Vendedor.Click
        frm_Vendedor.Text = "Seleccionar Vendedor"
        frm_Vendedor.Show()
    End Sub

    Private Sub btnGuardar_Orden_Trabajo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Orden_Trabajo.Click

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

            'VALIDA FECHA
            If dtpFecha_Orden_Trabajo.Text < Now Then
                MsgBox("La fecha no puede ser anterior al día de hoy")
                Exit Sub
            End If

            'GUARDA EL DETALLE DE LA ORDEN DE TRABAJO
            Dim detalle = New DETALLE_ORDEN_TRABAJO

            'id
            detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo.Text

            'cantidad detalles
            detalle.DOT_cantidad_dot = txt_cantidad1_detalle1.Text
            detalle.DOT_cantidad_dot = txt_cantidad2_detalle2.Text
            detalle.DOT_cantidad_dot = txt_cantidad3_detalle3.Text

            'piezas detalle
            detalle.PIE_id_pieza = cboPiezas1_Detalle1.SelectedValue
            detalle.PIE_id_pieza = cboPiezas2_Detalle2.SelectedValue
            detalle.PIE_id_pieza = cboPiezas3_Detalle3.SelectedValue

            'tamaño detalle
            detalle.DOT_tamaño_dot = txtTamaño1_Detalle1.Text
            detalle.DOT_tamaño_dot = txtTamaño2_Detalle2.Text
            detalle.DOT_tamaño_dot = txtTamaño3_Detalle3.Text

            'tipo impresion impresion detalle
            detalle.DOT_tipo_impresion_dot = cboTipoImpresion1_Detalle1.SelectedValue
            detalle.DOT_tipo_impresion_dot = cboTipoImpresion2_Detalle2.SelectedValue
            detalle.DOT_tipo_impresion_dot = cboTipoImpresion3_Detalle3.SelectedValue

            'papel
            detalle.DOT_papel_soporte_1 = txt_Papel1_Soporte1.Text
            detalle.DOT_papel_soporte_2 = txt_Papel2_Soporte1.Text
            detalle.DOT_papel_soporte_3 = txt_Papel3_Soporte1.Text

            'gramaje
            detalle.DOT_gramaje_soporte_1 = txt_Gramaje1_Soporte1.Text
            detalle.DOT_gramaje_soporte_2 = txt_Gramaje2_Soporte1.Text
            detalle.DOT_gramaje_soporte_3 = txt_Gramaje3_Soporte1.Text

            'cantidad
            detalle.DOT_cantidad_soporte_1 = txt_Cantidad1_Soporte1.Text
            detalle.DOT_cantidad_soporte_2 = txt_Cantidad2_Soporte1.Text
            detalle.DOT_cantidad_soporte_3 = txt_Cantidad3_Soporte1.Text

            'formato
            detalle.DOT_formato_soporte_1 = cboFormato1_Soporte1.SelectedValue
            detalle.DOT_formato_soporte_2 = cboFormato1_Soporte2.SelectedValue
            detalle.DOT_formato_soporte_3 = cboFormato1_Soporte3.SelectedValue

          
            'guardado de cada registro
            'datacontext.ORDEN_TRABAJO.InsertOnSubmit(clie)
            'datacontext.SubmitChanges()


          
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
            MsgBox("la orden se ha creado correctamente", vbInformation)
            ' cargargrilla()
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("La orden NO fue creada")
            limpiarcontroles()
            'cargargrilla()
        End Try



    End Sub
End Class