Public Class frm_Actualizar_Producto_Orden_Ampliada
    Dim datacontext As New DataS_Interno

    Public Sub LimpiarDigital()
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
        chkOtros.Checked = False
        chkArmadoRevistas.Checked = False
        chkCuño.Checked = False
        chkEstampado.Checked = False
        chkFresado.Checked = False
        chkLacaUVSectorizada.Checked = False
        chkOPPBrillante.Checked = False
        chkOPPMate.Checked = False
        chkPegadoManual.Checked = False
        chkPlastificado.Checked = False
        chkPosicionado.Checked = False
        chkTermosellado.Checked = False
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
        txtCantidad_2_Pliego_Maquina_Offset.Clear()
        txtCantidad_3_Pliego_Maquina_Offset.Clear()
        txt_chapa_soporte_1.Clear()
        txt_chapa_soporte_2.Clear()
        txt_chapa_soporte_3.Clear()
        cboFormato_1_Pliego_Maquina_Offset.SelectedIndex = -1
        cboFormato_2_Pliego_Maquina_Offset.SelectedIndex = -1
        cboFormato_3_Pliego_Maquina_Offset.SelectedIndex = -1
    End Sub

    Sub LimpiarGranFormato()
        txt_cantidad_producto_Gran_Formato.Clear()
        cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
        txtTamaño_Producto_Gran_Formato.Clear()
        txtSustrato_Gran_Formato.Clear()
        cboCalidad_Gran_Formato.SelectedIndex = -1
        cboSistema_Gran_Formato.SelectedIndex = -1
    End Sub

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
        cboPiezas_Producto_Gran_Formato.ValueMember = "PIE_id_pieza"

        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID

        ' If cboPiezas_Producto_Gran_Formato.Text.Length <> 0 Then
        ' cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
        ' Else
        cboPiezas_Producto_Gran_Formato.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza_offset", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value
        '   End If
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
        Try
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
        
            If cboPiezas_Producto.Text.Length <> 0 Then
                ActualizaDetalle.PIE_id_pieza = cboPiezas_Producto.SelectedValue
            Else
                ActualizaDetalle.PIE_id_pieza = 54
            End If

            If cboPiezas_Producto_Gran_Formato.Text.Length <> 0 Then
                ActualizaDetalle.PIE_id_pieza_offset = cboPiezas_Producto_Gran_Formato.SelectedValue
            Else
                ActualizaDetalle.PIE_id_pieza_offset = 54
            End If

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


            Dim temtermosellado, tempegadomanual, temestampado, temarmadorevistas, temlaca, temposicionado, temdoblado, temtroquelado, temguillotinado, temmediocorte, tembarniz, temmontado, temencuadernacion, temstamping, _
              temadhesivado, temtrazado, temsoldado, temcocido, temruedo, templastificado, temotros, temcuño, temfresado, temLacaUVSect, _
              temOPPBrillante, temOPPMate As String
            'ADHESIVADO
            If chkAdhesivado.Checked = True Then
                temadhesivado = "T01"
            Else
                temadhesivado = ""
            End If
            'ARMADO REVISTAS
            If chkArmadoRevistas.Checked = True Then
                temarmadorevistas = "T02"
            Else
                temarmadorevistas = ""
            End If
            'BARNIZ
            If chkBarniz.Checked = True Then
                tembarniz = "T03"
            Else
                tembarniz = ""
            End If
            'COCIDO
            If chkCocido.Checked = True Then
                temcocido = "T04"
            Else
                temcocido = ""
            End If
            'CUÑO
            If chkCuño.Checked = True Then
                temcuño = "T05"
            Else
                temcuño = ""
            End If
            'DOBLADO
            If chkDoblado.Checked = True Then
                temdoblado = "T06"
            Else
                temdoblado = ""
            End If
            'ENCUADERNACION
            If chkEncuadernacion.Checked = True Then
                temencuadernacion = "T07"
            Else
                temencuadernacion = ""
            End If
            'ESTAMPADO
            If chkEstampado.Checked = True Then
                temestampado = "T08"
            Else
                temestampado = ""
            End If
            'FRESADO
            If chkFresado.Checked = True Then
                temfresado = "T09"
            Else
                temfresado = ""
            End If
            'GUILLOTINADO
            If chkGuillotinado.Checked = True Then
                temguillotinado = "T10"
            Else
                temguillotinado = ""
            End If
            'LACA UV
            If chkLaca_UV.Checked = True Then
                temlaca = "T11"
            Else
                temlaca = ""
            End If
            'LACA UV SECTORIZADA
            If chkLacaUVSectorizada.Checked = True Then
                temLacaUVSect = "T12"
            Else
                temLacaUVSect = ""
            End If
            'MEDIO CORTE
            If chkMedio_Corte.Checked = True Then
                temmediocorte = "T13"
            Else
                temmediocorte = ""
            End If
            'MONTADO
            If chkMontado.Checked = True Then
                temmontado = "T14"
            Else
                temmontado = ""
            End If
            'OPP BRILLANTE
            If chkOPPBrillante.Checked = True Then
                temOPPBrillante = "T15"
            Else
                temOPPBrillante = ""
            End If
            'OPP MATE
            If chkOPPMate.Checked = True Then
                temOPPMate = "T16"
            Else
                temOPPMate = ""
            End If
            'OTROS
            If chkOtros.Checked = True Then
                temotros = "T17"
            Else
                temotros = ""
            End If
            'PEGADO MANUAL
            If chkPegadoManual.Checked = True Then
                tempegadomanual = "T18"
            Else
                tempegadomanual = ""
            End If
            'PLASTIFICADO
            If chkPlastificado.Checked = True Then
                templastificado = "T19"
            Else
                templastificado = ""
            End If
            'POSICIONADO
            If chkPosicionado.Checked = True Then
                temposicionado = "T20"
            Else
                temposicionado = ""
            End If
            'RUEDO
            If chkRuedo.Checked = True Then
                temruedo = "T21"
            Else
                temruedo = ""
            End If
            'SOLDADO
            If chkSoldado.Checked = True Then
                temsoldado = "T22"
            Else
                temsoldado = ""
            End If
            'STAMPING
            If chkStamping.Checked = True Then
                temstamping = "T23"
            Else
                temstamping = ""
            End If
            'TERMOSELLADO
            If chkTermosellado.Checked = True Then
                temtermosellado = "T24"
            Else
                temtermosellado = ""
            End If
            'TRAZADO
            If chkTrazado.Checked = True Then
                temtrazado = "T25"
            Else
                temtrazado = ""
            End If
            'TROQUELADO
            If chkTroquelado.Checked = True Then
                temtroquelado = "T26"
            Else
                temtroquelado = ""
            End If

            ActualizaDetalle.tipo_terminacion = temlaca & temposicionado & temdoblado & temtroquelado & temguillotinado & temmediocorte & tembarniz & temmontado _
                & temencuadernacion & temstamping & temadhesivado & temtrazado & temsoldado & temcocido & temruedo & temotros & temcuño & temfresado & _
                temLacaUVSect & temOPPBrillante & temOPPMate & temarmadorevistas & temestampado & tempegadomanual & templastificado & temtermosellado

            ActualizaDetalle.descripcion_terminacion = txt_descripcion_terminacion.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()
            frm_listado_orden_trabajo_ampliada.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar orden")
        End Try
    End Sub

    Private Sub btnCancelar_Orden_Trabajo_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Orden_Trabajo.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub chkOffset_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOffset.CheckedChanged
        If chkOffset.Checked = True Then
            GroupProducto_Soportes.Enabled = True
            groupOffset.Enabled = True
        Else
            GroupProducto_Soportes.Enabled = False
            groupOffset.Enabled = False
            'LimpiarProducto_Soportes()
            ' LimpiarOffset()
        End If
    End Sub

    Private Sub chkDigital_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDigital.CheckedChanged
        If chkDigital.Checked = True Then
            GroupDigital.Enabled = True
            GroupProducto_Soportes.Enabled = True
        Else
            GroupDigital.Enabled = False
            GroupProducto_Soportes.Enabled = False
            ' LimpiarProducto_Soportes()
            '  LimpiarDigital()
        End If
    End Sub

    Private Sub chkGranFormato_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGranFormato.CheckedChanged
        If chkGranFormato.Checked = True Then
            GroupGranFormato.Enabled = True
        Else
            GroupGranFormato.Enabled = False
            ' LimpiarGranFormato()
        End If
    End Sub

    Private Sub chkTerminacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTerminacion.CheckedChanged
        If chkTerminacion.Checked = True Then
            GroupTerminacion.Enabled = True
        Else
            GroupTerminacion.Enabled = False
            '   LimpiarTerminacion()
        End If
    End Sub
End Class