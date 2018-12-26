Public Class frm_Orden_Trabajo_Ampliada

    Dim datacontext As New DataS_Interno
    Public quienllamo_listado_orden As Form

    Private Sub frm_Orden_Trabajo_Ampliada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' If quienllamo_listado_orden.Name <> frm_Listado_Orden_Trabajo.Name Then
        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto.DataSource = combopieza1
        cboPiezas_Producto.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto.ValueMember = "PIE_id_pieza"
        cboPiezas_Producto.SelectedIndex = -1

        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
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
End Class