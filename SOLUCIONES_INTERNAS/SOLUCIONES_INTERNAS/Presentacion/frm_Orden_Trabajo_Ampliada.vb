Public Class frm_Orden_Trabajo_Ampliada

    Dim datacontext As New DataS_Interno
    Public quienllamo_listado_orden As Form
    Dim cargamasprod As String = "NO"

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
        cboTipo_Impresion_Digital.Text = ""
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
        chkGuillotinado.Checked = False
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
        cboTipo_Impresion_Offset.Text = ""
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
    
        'VALIDA QUE EL NUMERO DE ORDEN NO ESTE VACIO
        If txtNumero_Orden_Trabajo.Text.Length = 0 Then
            MsgBox("Complete el campo Número de Orden")
            txtNumero_Orden_Trabajo.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO VENDEDOR NO ESTE VACIO
        If txtNombre_vendedor.Text.Length = 0 Then
            MsgBox("Cargue el nombre Vendedor")
            btnBuscar_Vendedor.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO CLIENTE NO ESTE VACIO
        If txt_nombre_cliente.Text.Length = 0 Then
            MsgBox("Cargue el nombre Cliente")
            btnBuscar_cliente.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DIRECCION DE ENTREGA NO ESTE VACIO
        If cboDireccion_Entrega.Text.Length = 0 Then
            MsgBox("Cargue la Dirección de Entrega")
            cboDireccion_Entrega.Focus()
            Exit Sub
        End If

        'VALIDA QUE LA FECHA DE ENTREGA SEA CORRECTA
        If dtpFecha_Entrega_ODT.Value < Today Then
            MsgBox("Verifique la Fecha de Entrega")
            Exit Sub
        End If

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

        Dim buscaorden = (From odt In datacontext.ORDEN_TRABAJO
                      Select odt.ORT_fecha_ot, odt.ORT_tipo_ot, odt.ORT_numero_ot, odt.ORT_observaciones_ot, odt.VEN_id_vendedor, odt.CLI_id_cliente, odt.ORT_fecha_entrega
                      Where ORT_numero_ot = txtNumero_Orden_Trabajo.Text.ToUpper).Any

        If cargamasprod = "NO" Then
            If buscaorden = True Then
                MsgBox("La Orden ingresada ya existe")
                Exit Sub
            End If
        End If

        Try
            '---------------------------GUARDA ORDEN------------------------------
            Dim ODT = New ORDEN_TRABAJO
            If cargamasprod = "NO" Then

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
            End If

            'GUARDA EL REGISTRO 1 DEL DETALLE DE LA ORDEN DE TRABAJO

            '--------------------------------------------------------------------------------------

            Dim detalle = New DETALLE_ORDEN_TRABAJO

            txt_id_detalle_orden_trabajo1.Text = detalle.id_detalle_orden_trabajo  'id
            detalle.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text

            If txt_cantidad_producto.TextLength <> 0 Then
                detalle.DOT_cantidad_producto = txt_cantidad_producto.Text  'CANTIDAD PRODUCTO 1
            End If
            detalle.DOT_tamaño_producto = StrConv(txtTamaño_Producto.Text, VbStrConv.ProperCase) 'TAMAÑO PRODUCTO 1
            detalle.DOT_tipo_impresion_dot = cboTipo_Orden.SelectedItem 'TIPO IMPRESION PRODUCTO 1
            detalle.PIE_id_pieza = cboPiezas_Producto.SelectedValue 'TIPO PIEZA PRODUCTO 1

            If cargamasprod = "NO" Then
                txt_id_orden_trabajo.Text = ODT.ORT_id_orden_trabajo
            End If
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

            '--------------------------------DIGITAL---------------------------------------------
            detalle.tipo_impresion_digital = cboTipo_Impresion_Digital.Text

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
            '------------------------------------------------------------------------------------

            '---------------------------OFFSET---------------------------------------------------
            detalle.tipo_impresion_offset = cboTipo_Impresion_Offset.Text
            detalle.impresora_offset = cboImpresora_Offset.SelectedItem
            detalle.modo_impresion_offset = cboModo_Impresion_Offset.SelectedItem
            detalle.marca_offset = cboMarca_Offset.SelectedItem
            If txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
                detalle.cantidad_1_PM_offset = txtCantidad_1_Pliego_Maquina_Offset.Text
            End If
            If txtCantidad_2_Pliego_Maquina_Offset.TextLength <> 0 Then
                detalle.cantidad_2_PM_offset = txtCantidad_2_Pliego_Maquina_Offset.Text
            End If
            If txtCantidad_3_Pliego_Maquina_Offset.TextLength <> 0 Then
                detalle.cantidad_3_PM_offset = txtCantidad_3_Pliego_Maquina_Offset.Text
            End If
            detalle.formato_1_PM_offset = cboFormato_1_Pliego_Maquina_Offset.SelectedItem
            detalle.formato_2_PM_offset = cboFormato_2_Pliego_Maquina_Offset.SelectedItem
            detalle.formato_3_PM_offset = cboFormato_3_Pliego_Maquina_Offset.SelectedItem
            If txt_chapa_soporte_1.TextLength <> 0 Then
                detalle.chapas_soporte1_offset = txt_chapa_soporte_1.Text
            End If
            If txt_chapa_soporte_2.TextLength <> 0 Then
                detalle.chapas_soporte2_offset = txt_chapa_soporte_2.Text
            End If
            If txt_chapa_soporte_3.TextLength <> 0 Then
                detalle.chapas_soporte3_offset = txt_chapa_soporte_3.Text
            End If
            '------------------------------------------------------------------------------------

            '-------------------------------GRAN FORMATO----------------------------------------
            If txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
                detalle.cantidad_gran_formato = txt_cantidad_producto_Gran_Formato.Text
            End If
            detalle.PIE_id_pieza_offset = cboPiezas_Producto_Gran_Formato.SelectedValue
            detalle.tamaño_gran_formato = txtTamaño_Producto_Gran_Formato.Text
            detalle.sustrato_gran_formato = txtSustrato_Gran_Formato.Text
            detalle.calidad_gran_formato = cboCalidad_Gran_Formato.SelectedItem
            detalle.sistema_gran_formato = cboSistema_Gran_Formato.SelectedItem
            '------------------------------------------------------------------------------------

            '-------------------------------- TERMINACION----------------------------------------
            Dim temlaca, temposicionado, temdoblado, temtroquelado, temguillotinado, temmediocorte, tembarniz, temmontado, temencuadernacion, temstamping, _
                temadhesivado, temtrazado, temsoldado, temcocido, temruedo, tempolipropileno, temotros, temcuñoseco, temfresado, temLacaUVSect, _
                temOPPBrillante, temOPPMate As String

            If chkAdhesivado.Checked = True Then
                temadhesivado = "AD"
            Else
                temadhesivado = ""
            End If
            If chkBarniz.Checked = True Then
                tembarniz = "BA"
            Else
                tembarniz = ""
            End If
            If chkCocido.Checked = True Then
                temcocido = "CC"
            Else
                temcocido = ""
            End If
            If chkCuñoSeco.Checked = True Then
                temcuñoseco = "CS"
            Else
                temcuñoseco = ""
            End If
            If chkDoblado.Checked = True Then
                temdoblado = "DO"
            Else
                temdoblado = ""
            End If
            If chkEncuadernacion.Checked = True Then
                temencuadernacion = "EN"
            Else
                temencuadernacion = ""
            End If
            If chkFresado.Checked = True Then
                temfresado = "FR"
            Else
                temfresado = ""
            End If
            If chkGuillotinado.Checked = True Then
                temguillotinado = "GI"
            Else
                temguillotinado = ""
            End If
            If chkLaca_UV.Checked = True Then
                temlaca = "LA"
            Else
                temlaca = ""
            End If
            If chkLacaUVSectorizada.Checked = True Then
                temLacaUVSect = "LS"
            Else
                temLacaUVSect = ""
            End If
            If chkMedio_Corte.Checked = True Then
                temmediocorte = "MC"
            Else
                temmediocorte = ""
            End If
            If chkMontado.Checked = True Then
                temmontado = "MO"
            Else
                temmontado = ""
            End If
            If chkOPPBrillante.Checked = True Then
                temOPPBrillante = "OB"
            Else
                temOPPBrillante = ""
            End If
            If chkOPPMate.Checked = True Then
                temOPPMate = "OM"
            Else
                temOPPMate = ""
            End If
            If chkOtros.Checked = True Then
                temotros = "OT"
            Else
                temotros = ""
            End If
            If chkPolipropileno.Checked = True Then
                tempolipropileno = "PL"
            Else
                tempolipropileno = ""
            End If
            If chkPosicionado.Checked = True Then
                temposicionado = "PS"
            Else
                temposicionado = ""
            End If
            If chkRuedo.Checked = True Then
                temruedo = "RU"
            Else
                temruedo = ""
            End If
            If chkSoldado.Checked = True Then
                temsoldado = "SL"
            Else
                temsoldado = ""
            End If
            If chkStamping.Checked = True Then
                temstamping = "ST"
            Else
                temstamping = ""
            End If
            If chkTrazado.Checked = True Then
                temtrazado = "TZ"
            Else
                temtrazado = ""
            End If
            If chkTroquelado.Checked = True Then
                temtroquelado = "TQ"
            Else
                temtroquelado = ""
            End If
      
           
            detalle.tipo_terminacion = temlaca & temposicionado & temdoblado & temtroquelado & temguillotinado & temmediocorte & tembarniz & temmontado _
                & temencuadernacion & temstamping & temadhesivado & temtrazado & temsoldado & temcocido & temruedo & tempolipropileno & temotros _
                & temcuñoseco & temfresado & temLacaUVSect & temOPPBrillante & temOPPMate

            detalle.descripcion_terminacion = txt_descripcion_terminacion.Text

            datacontext.DETALLE_ORDEN_TRABAJO.InsertOnSubmit(detalle)
            datacontext.SubmitChanges()

            Select Case MsgBox("Agregar mas productos?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar orden")
                Case MsgBoxResult.Yes
                    cargamasprod = "SI"
                    chkDigital.Checked = False
                    chkOffset.Checked = False
                    chkTerminacion.Checked = False
                    chkGranFormato.Checked = False
                    'LimpiarDigital()
                    'LimpiarGranFormato()
                    'LimpiarOffset()
                    'LimpiarProducto_Soportes()
                    'LimpiarTerminacion()
                    Exit Sub
                Case Else
                    MsgBox("la Orden se ha creado correctamente", vbInformation)
                    Me.Close()
            End Select
        Catch ex As Exception
            MsgBox("Error al cargar la Orden")
        End Try
    End Sub
End Class

'USE [SOLUCIONES_INTERNAS1]
'GO
'/****** Object:  View [dbo].[Vista_Detalle_Orden_Trabajo_Ampliada]    Script Date: 12/31/2018 21:42:55 ******/
'SET ANSI_NULLS ON
'GO
'SET QUOTED_IDENTIFIER ON
'GO
'CREATE VIEW [dbo].[Vista_Detalle_Orden_Trabajo_Ampliada]
'AS
'SELECT     dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo, dbo.ORDEN_TRABAJO.ORT_tipo_ot, dbo.ORDEN_TRABAJO.ORT_numero_ot, dbo.ORDEN_TRABAJO.ORT_observaciones_ot, 
'                      dbo.ORDEN_TRABAJO.ORT_mejoras_ot, dbo.ORDEN_TRABAJO.VEN_id_vendedor, dbo.VENDEDOR.VEN_nombre_ven, dbo.VENDEDOR.VEN_apellido_ven, dbo.ORDEN_TRABAJO.ORT_fecha_ot, 
'                      dbo.ORDEN_TRABAJO.ORT_fecha_entrega, dbo.ORDEN_TRABAJO.CLI_id_cliente, dbo.CLIENTE.CLI_razon_social, dbo.CLIENTE.CLI_domicilio, dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza, 
'                      dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza_offset, dbo.PIEZA.PIE_nombre_pie, dbo.PIEZA.PIE_ubicacion, dbo.DETALLE_ORDEN_TRABAJO.id_detalle_orden_trabajo, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_producto, dbo.DETALLE_ORDEN_TRABAJO.DOT_tamaño_producto, dbo.DETALLE_ORDEN_TRABAJO.DOT_tipo_impresion_dot, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_3, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_3, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_3, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_3, 
'                      dbo.DETALLE_ORDEN_TRABAJO.cantidad_1_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.cantidad_2_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.cantidad_3_PM_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.formato_1_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.formato_2_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.formato_3_PM_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.modo_impresion_offset, dbo.DETALLE_ORDEN_TRABAJO.tipo_impresion_offset, dbo.DETALLE_ORDEN_TRABAJO.chapas_soporte1_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.chapas_soporte2_offset, dbo.DETALLE_ORDEN_TRABAJO.chapas_soporte3_offset, dbo.DETALLE_ORDEN_TRABAJO.impresora_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.marca_offset, dbo.DETALLE_ORDEN_TRABAJO.cantidad_1_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.cantidad_2_PM_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.cantidad_3_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.formato_1_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.formato_2_PM_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.formato_3_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.modo_impresion_digital, dbo.DETALLE_ORDEN_TRABAJO.tipo_impresion_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.dato_variable, dbo.DETALLE_ORDEN_TRABAJO.cantidad_gran_formato, dbo.DETALLE_ORDEN_TRABAJO.tamaño_gran_formato, 
'                      dbo.DETALLE_ORDEN_TRABAJO.sustrato_gran_formato, dbo.DETALLE_ORDEN_TRABAJO.calidad_gran_formato, dbo.DETALLE_ORDEN_TRABAJO.sistema_gran_formato, 
'                      dbo.DETALLE_ORDEN_TRABAJO.tipo_terminacion, dbo.DETALLE_ORDEN_TRABAJO.descripcion_terminacion
'FROM         dbo.DETALLE_ORDEN_TRABAJO INNER JOIN
'                      dbo.ORDEN_TRABAJO ON dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo INNER JOIN
'                      dbo.PIEZA ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza = dbo.PIEZA.PIE_id_pieza INNER JOIN
'                      dbo.CLIENTE ON dbo.ORDEN_TRABAJO.CLI_id_cliente = dbo.CLIENTE.CLI_id_cliente INNER JOIN
'                      dbo.VENDEDOR ON dbo.ORDEN_TRABAJO.VEN_id_vendedor = dbo.VENDEDOR.VEN_id_vendedor
'GO
'EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
'Begin DesignProperties = 
'   Begin PaneConfigurations = 
'      Begin PaneConfiguration = 0
'         NumPanes = 4
'         Configuration = "(H (1[15] 4[4] 2[75] 3) )"
'      End
'      Begin PaneConfiguration = 1
'         NumPanes = 3
'         Configuration = "(H (1 [50] 4 [25] 3))"
'      End
'      Begin PaneConfiguration = 2
'         NumPanes = 3
'         Configuration = "(H (1 [50] 2 [25] 3))"
'      End
'      Begin PaneConfiguration = 3
'         NumPanes = 3
'         Configuration = "(H (4 [30] 2 [40] 3))"
'      End
'      Begin PaneConfiguration = 4
'         NumPanes = 2
'         Configuration = "(H (1 [56] 3))"
'      End
'      Begin PaneConfiguration = 5
'         NumPanes = 2
'         Configuration = "(H (2 [66] 3))"
'      End
'      Begin PaneConfiguration = 6
'         NumPanes = 2
'         Configuration = "(H (4 [50] 3))"
'      End
'      Begin PaneConfiguration = 7
'         NumPanes = 1
'         Configuration = "(V (3))"
'      End
'      Begin PaneConfiguration = 8
'         NumPanes = 3
'         Configuration = "(H (1[56] 4[18] 2) )"
'      End
'      Begin PaneConfiguration = 9
'         NumPanes = 2
'         Configuration = "(H (1 [75] 4))"
'      End
'      Begin PaneConfiguration = 10
'         NumPanes = 2
'         Configuration = "(H (1[66] 2) )"
'      End
'      Begin PaneConfiguration = 11
'         NumPanes = 2
'         Configuration = "(H (4 [60] 2))"
'      End
'      Begin PaneConfiguration = 12
'         NumPanes = 1
'         Configuration = "(H (1) )"
'      End
'      Begin PaneConfiguration = 13
'         NumPanes = 1
'         Configuration = "(V (4))"
'      End
'      Begin PaneConfiguration = 14
'         NumPanes = 1
'         Configuration = "(V (2))"
'      End
'      ActivePaneConfig = 0
'   End
'   Begin DiagramPane = 
'      Begin Origin = 
'         Top = -384
'         Left = 0
'      End
'      Begin Tables = 
'         Begin Table = "DETALLE_ORDEN_TRABAJO"
'            Begin Extent = 
'               Top = 6
'               Left = 38
'               Bottom = 794
'               Right = 250
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "ORDEN_TRABAJO"
'            Begin Extent = 
'               Top = 6
'               Left = 288
'               Bottom = 204
'               Right = 489
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "PIEZA"
'            Begin Extent = 
'               Top = 6
'               Left = 527
'               Bottom = 111
'               Right = 725
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "CLIENTE"
'            Begin Extent = 
'               Top = 6
'               Left = 763
'               Bottom = 176
'               Right = 961
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "VENDEDOR"
'            Begin Extent = 
'               Top = 164
'               Left = 555
'               Bottom = 300
'               Right = 753
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'      End
'   End
'   Begin SQLPane = 
'   End
'   Begin DataPane = 
'      Begin ParameterDefaults = ""
'      End
'   End
'   Begin CriteriaPane = 
'      Begin ColumnWidths = 11
'         Column = 1440
'         Alias = 900
'         Table = 1170
'         Output = 720
'         Append = 1400
'         NewValue = 1170
'         SortType = 1350
'         SortOrder = 1410
'         GroupBy = 1350
'         Filter = 1350
'         Or = 1350
'         Or = 1350'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_Ampliada'
'GO
'EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
'         Or = 1350
'      End
'   End
'End
'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_Ampliada'
'GO
'EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_Ampliada'
'GO
