Public Class frm_GuardarActualizar_tarea

    Dim datacontext As New DataS_Interno
    Dim quienllamoboton As Button
    Public quienllamoatarea As Integer
    Dim buscartarea

    Private Sub btnBuscar_Colaborador_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Colaborador.Click
        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.Text = "Seleccionar colaborador"
        frm_Colaborador.Show()
        frm_Colaborador.GroupNuevoColaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False

        frm_Colaborador.txt_Buscar_Colaborador.Enabled = False

        frm_Colaborador.btn_enviar_mensaje.Visible = False
        frm_Colaborador.btn_Respuesta_Fecha.Visible = False
        frm_Colaborador.btn_Ver_Respuesta.Visible = False
        quienllamoatarea = 0
    End Sub

    Private Sub btnLimpiarTarea1_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiarTarea1.Click
        txt_detalle_tarea1.Clear()
        txtTiempo_Estimado1.Clear()
        txtTiempo_Real1.Clear()
        txt_id_orden_trabajo1.Clear()
        txtHora_Finalizacion1.Clear()
        txtObservaciones1.Clear()
        txtNumero_Orden_Trabajo1.Clear()
    End Sub

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click

        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden1
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnGuardar_Tarea_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar_Tarea.Click

        'VALIDA CAMPO COLABORADOR
        If txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Seleccione al colaborador")
            btnBuscar_Colaborador.Focus()
            Exit Sub
        End If
        'VALIDA CAMPO ENTRADA
        If txtEntrada.Text.Length = 0 Then
            MsgBox("Debe ingresar horario de entrada")
            txtEntrada.Focus()
            Exit Sub
        End If

        'VALIDA CAMPO SALIDA
        If txtSalida.Text.Length = 0 Then
            MsgBox("Debe ingresar horario de salida")
            txtSalida.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------
        'VALIDA QUE SE INGRESE AL MENOS UNA TAREA
        If txtNumero_Orden_Trabajo1.Text.Length = 0 And txt_detalle_tarea1.Text.Length = 0 Then
            MsgBox("Debe cargar al menos una tarea")
            txt_detalle_tarea1.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA PRIMERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo1.Text.Length = 0 And txt_detalle_tarea1.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 1")
            btnBuscar_Numero_Orden1.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA PRIMERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo1.Text.Length <> 0 And txt_detalle_tarea1.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 1")
            txt_detalle_tarea1.Focus()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA SEGUNDA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo2.Text.Length = 0 And txt_detalle_tarea2.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 2")
            btnBuscar_Numero_Orden2.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA SEGUNDA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo2.Text.Length <> 0 And txt_detalle_tarea2.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 2")
            txt_detalle_tarea2.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA TERCER TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo3.Text.Length = 0 And txt_detalle_tarea3.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 3")
            btnBuscar_Numero_Orden3.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA TERCER TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo3.Text.Length <> 0 And txt_detalle_tarea3.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 3")
            txt_detalle_tarea3.Focus()
            Exit Sub
        End If

        '------------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA CUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo4.Text.Length = 0 And txt_detalle_tarea4.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 4")
            btnBuscar_Numero_Orden4.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA CUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo4.Text.Length <> 0 And txt_detalle_tarea4.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 4")
            txt_detalle_tarea4.Focus()
            Exit Sub
        End If

        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA QUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo5.Text.Length = 0 And txt_detalle_tarea5.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 5")
            btnBuscar_Numero_Orden5.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA QUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo5.Text.Length <> 0 And txt_detalle_tarea5.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 5")
            txt_detalle_tarea5.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA SEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo6.Text.Length = 0 And txt_detalle_tarea6.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 6")
            btnBuscar_Numero_Orden6.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA SEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo6.Text.Length <> 0 And txt_detalle_tarea6.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 6")
            txt_detalle_tarea6.Focus()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA SEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo7.Text.Length = 0 And txt_detalle_tarea7.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 7")
            btnBuscar_Numero_Orden7.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA SEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo7.Text.Length <> 0 And txt_detalle_tarea7.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 7")
            txt_detalle_tarea7.Focus()
            Exit Sub
        End If

        '---------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA OCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo8.Text.Length = 0 And txt_detalle_tarea8.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 8")
            btnBuscar_Numero_Orden8.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA OCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo8.Text.Length <> 0 And txt_detalle_tarea8.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 8")
            txt_detalle_tarea8.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA NOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo9.Text.Length = 0 And txt_detalle_tarea9.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 9")
            btnBuscar_Numero_Orden9.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA NOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo9.Text.Length <> 0 And txt_detalle_tarea9.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 9")
            txt_detalle_tarea9.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo10.Text.Length = 0 And txt_detalle_tarea10.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 10")
            btnBuscar_Numero_Orden10.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo10.Text.Length <> 0 And txt_detalle_tarea10.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 10")
            txt_detalle_tarea10.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA UNDECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo11.Text.Length = 0 And txt_detalle_tarea11.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 11")
            btnBuscar_Numero_Orden11.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA UNDECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo11.Text.Length <> 0 And txt_detalle_tarea11.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 11")
            txt_detalle_tarea11.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DUODECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo12.Text.Length = 0 And txt_detalle_tarea12.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 12")
            btnBuscar_Numero_Orden12.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DUODECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo12.Text.Length <> 0 And txt_detalle_tarea12.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 12")
            txt_detalle_tarea12.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOTERCERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo13.Text.Length = 0 And txt_detalle_tarea13.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 13")
            btnBuscar_Numero_Orden13.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOTERCERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo13.Text.Length <> 0 And txt_detalle_tarea13.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 13")
            txt_detalle_tarea13.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOCUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo14.Text.Length = 0 And txt_detalle_tarea14.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 14")
            btnBuscar_Numero_Orden14.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOCUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo14.Text.Length <> 0 And txt_detalle_tarea14.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 14")
            txt_detalle_tarea14.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOQUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo15.Text.Length = 0 And txt_detalle_tarea15.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 15")
            btnBuscar_Numero_Orden15.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOQUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo15.Text.Length <> 0 And txt_detalle_tarea15.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 15")
            txt_detalle_tarea15.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOSEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo16.Text.Length = 0 And txt_detalle_tarea16.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 16")
            btnBuscar_Numero_Orden16.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOSEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo16.Text.Length <> 0 And txt_detalle_tarea16.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 16")
            txt_detalle_tarea16.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOSEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo17.Text.Length = 0 And txt_detalle_tarea17.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 17")
            btnBuscar_Numero_Orden17.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOSEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo17.Text.Length <> 0 And txt_detalle_tarea17.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 17")
            txt_detalle_tarea17.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOOCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo18.Text.Length = 0 And txt_detalle_tarea18.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 18")
            btnBuscar_Numero_Orden18.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOOCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo18.Text.Length <> 0 And txt_detalle_tarea18.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 18")
            txt_detalle_tarea18.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMONOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo19.Text.Length = 0 And txt_detalle_tarea19.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 19")
            btnBuscar_Numero_Orden19.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMONOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo19.Text.Length <> 0 And txt_detalle_tarea19.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 19")
            txt_detalle_tarea19.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA BIGESIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo20.Text.Length = 0 And txt_detalle_tarea20.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 20")
            btnBuscar_Numero_Orden20.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA BIGESIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo20.Text.Length <> 0 And txt_detalle_tarea20.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 20")
            txt_detalle_tarea20.Focus()
            Exit Sub
        End If

        Try
            If txt_detalle_tarea1.Text.Length <> 0 Or txtNumero_Orden_Trabajo1.Text.Length <> 0 Then
                'REGISTRO 1 DE TAREA
                ' Dim temphorario = Trim(txtEntrada.Text) + Trim(txtSalida.Text)
                Dim tar1 = New TAREA

                If txtTiempo_Estimado1.Text.Length <> 0 Then
                    tar1.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado1.Text, VbStrConv.ProperCase)
                Else
                    tar1.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real1.Text.Length <> 0 Then
                    tar1.TAR_tiempo_real = StrConv(txtTiempo_Real1.Text, VbStrConv.ProperCase)
                Else
                    tar1.TAR_tiempo_real = 0
                End If
                tar1.COL_id_colaborador = txt_id_colaborador.Text
                tar1.ORT_id_orden_trabajo = txt_id_orden_trabajo1.Text
                tar1.TAR_hora_fin = StrConv(txtHora_Finalizacion1.Text, VbStrConv.ProperCase)

                tar1.TAR_detalle_tarea = StrConv(txt_detalle_tarea1.Text, VbStrConv.ProperCase)
                tar1.TAR_observaciones = StrConv(txtObservaciones1.Text, VbStrConv.ProperCase)
                tar1.TAR_fecha = dtpFecha.Text

                If buscartarea = False Then
                    tar1.TAR_carga_horaria = StrConv(txt_Carga_Horaria1.Text, VbStrConv.ProperCase)
                    tar1.TAR_entrada = txtEntrada.Text
                    tar1.TAR_salida = txtSalida.Text
                End If
                datacontext.TAREA.InsertOnSubmit(tar1)
                datacontext.SubmitChanges()
            Else
            End If
            '------------------------------------------------------------------------------------------
            If txt_detalle_tarea2.Text.Length <> 0 Then
                'REGISTRO 2 DE TAREA
                Dim tar2 = New TAREA
                If txtTiempo_Estimado2.Text.Length <> 0 Then
                    tar2.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado2.Text, VbStrConv.ProperCase)
                Else
                    tar2.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real2.Text.Length <> 0 Then
                    tar2.TAR_tiempo_real = StrConv(txtTiempo_Real2.Text, VbStrConv.ProperCase)
                Else
                    tar2.TAR_tiempo_real = 0
                End If
                tar2.COL_id_colaborador = txt_id_colaborador.Text
                tar2.ORT_id_orden_trabajo = txt_id_orden_trabajo2.Text
                tar2.TAR_hora_fin = StrConv(txtHora_Finalizacion2.Text, VbStrConv.ProperCase)
                '   tar2.TAR_carga_horaria = "0"
                tar2.TAR_detalle_tarea = StrConv(txt_detalle_tarea2.Text, VbStrConv.ProperCase)
                tar2.TAR_observaciones = StrConv(txtObservaciones2.Text, VbStrConv.ProperCase)
                tar2.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar2)
                datacontext.SubmitChanges()
            Else
            End If
            '-----------------------------------------------------------------------------------------
            If txt_detalle_tarea3.Text.Length <> 0 Then
                'REGISTRO 3 DE TAREA
                Dim tar3 = New TAREA
                If txtTiempo_Estimado3.Text.Length <> 0 Then
                    tar3.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado3.Text, VbStrConv.ProperCase)
                Else
                    tar3.TAR_tiempo_estimado = 0
                End If

                If txtTiempo_Real3.Text.Length <> 0 Then
                    tar3.TAR_tiempo_real = StrConv(txtTiempo_Real3.Text, VbStrConv.ProperCase)
                Else
                    tar3.TAR_tiempo_real = 0
                End If
                tar3.COL_id_colaborador = txt_id_colaborador.Text
                tar3.ORT_id_orden_trabajo = txt_id_orden_trabajo3.Text
                tar3.TAR_hora_fin = StrConv(txtHora_Finalizacion3.Text, VbStrConv.ProperCase)
                'tar3.TAR_carga_horaria = "0"
                tar3.TAR_detalle_tarea = StrConv(txt_detalle_tarea3.Text, VbStrConv.ProperCase)
                tar3.TAR_observaciones = StrConv(txtObservaciones3.Text, VbStrConv.ProperCase)
                tar3.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar3)
                datacontext.SubmitChanges()
            Else
            End If
            '-----------------------------------------------------------------------------------------
            If txt_detalle_tarea4.Text.Length <> 0 Then
                'REGISTRO 4 DE TAREA
                Dim tar4 = New TAREA
                If txtTiempo_Estimado4.Text.Length <> 0 Then
                    tar4.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado4.Text, VbStrConv.ProperCase)
                Else
                    tar4.TAR_tiempo_estimado = 0
                End If

                If txtTiempo_Real4.Text.Length <> 0 Then
                    tar4.TAR_tiempo_real = StrConv(txtTiempo_Real4.Text, VbStrConv.ProperCase)
                Else
                    tar4.TAR_tiempo_real = 0
                End If
                tar4.COL_id_colaborador = txt_id_colaborador.Text
                tar4.ORT_id_orden_trabajo = txt_id_orden_trabajo4.Text
                tar4.TAR_hora_fin = StrConv(txtHora_Finalizacion4.Text, VbStrConv.ProperCase)
                '    tar4.TAR_carga_horaria = "0"
                tar4.TAR_detalle_tarea = StrConv(txt_detalle_tarea4.Text, VbStrConv.ProperCase)
                tar4.TAR_observaciones = StrConv(txtObservaciones4.Text, VbStrConv.ProperCase)
                tar4.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar4)
                datacontext.SubmitChanges()
            Else
            End If
            '--------------------------------------------------------------------------------------------
            If txt_detalle_tarea5.Text.Length <> 0 Then
                'REGISTRO 5 DE TAREA
                Dim tar5 = New TAREA
                If txtTiempo_Estimado5.Text.Length <> 0 Then
                    tar5.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado5.Text, VbStrConv.ProperCase)
                Else
                    tar5.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real5.Text.Length <> 0 Then
                    tar5.TAR_tiempo_real = StrConv(txtTiempo_Real5.Text, VbStrConv.ProperCase)
                Else
                    tar5.TAR_tiempo_real = 0
                End If
                tar5.COL_id_colaborador = txt_id_colaborador.Text
                tar5.ORT_id_orden_trabajo = txt_id_orden_trabajo5.Text
                tar5.TAR_hora_fin = StrConv(txtHora_Finalizacion5.Text, VbStrConv.ProperCase)
                '  tar5.TAR_carga_horaria = "0"
                tar5.TAR_detalle_tarea = StrConv(txt_detalle_tarea5.Text, VbStrConv.ProperCase)
                tar5.TAR_observaciones = StrConv(txtObservaciones5.Text, VbStrConv.ProperCase)
                tar5.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar5)
                datacontext.SubmitChanges()
            Else
            End If
            '----------------------------------------------------------------------------------------------
            If txt_detalle_tarea6.Text.Length <> 0 Then
                'REGISTRO 6 DE TAREA
                Dim tar6 = New TAREA
                If txtTiempo_Estimado6.Text.Length <> 0 Then
                    tar6.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado6.Text, VbStrConv.ProperCase)
                Else
                    tar6.TAR_tiempo_estimado = 0
                End If

                If txtTiempo_Real6.Text.Length <> 0 Then
                    tar6.TAR_tiempo_real = StrConv(txtTiempo_Real6.Text, VbStrConv.ProperCase)
                Else
                    tar6.TAR_tiempo_real = 0
                End If
                tar6.COL_id_colaborador = txt_id_colaborador.Text
                tar6.ORT_id_orden_trabajo = txt_id_orden_trabajo6.Text
                tar6.TAR_hora_fin = StrConv(txtHora_Finalizacion6.Text, VbStrConv.ProperCase)
                '  tar6.TAR_carga_horaria = "0"
                tar6.TAR_detalle_tarea = StrConv(txt_detalle_tarea6.Text, VbStrConv.ProperCase)
                tar6.TAR_observaciones = StrConv(txtObservaciones6.Text, VbStrConv.ProperCase)
                tar6.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar6)
                datacontext.SubmitChanges()
            Else
            End If
            '------------------------------------------------------------------------------------------------
            If txt_detalle_tarea7.Text.Length <> 0 Then
                'REGISTRO 7 DE TAREA
                Dim tar7 = New TAREA
                If txtTiempo_Estimado7.Text.Length <> 0 Then
                    tar7.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado7.Text, VbStrConv.ProperCase)
                Else
                    tar7.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real7.Text.Length <> 0 Then
                    tar7.TAR_tiempo_real = StrConv(txtTiempo_Real7.Text, VbStrConv.ProperCase)
                Else
                    tar7.TAR_tiempo_real = 0
                End If
                tar7.COL_id_colaborador = txt_id_colaborador.Text
                tar7.ORT_id_orden_trabajo = txt_id_orden_trabajo7.Text
                tar7.TAR_hora_fin = StrConv(txtHora_Finalizacion7.Text, VbStrConv.ProperCase)
                '   tar7.TAR_carga_horaria = "0"
                tar7.TAR_detalle_tarea = StrConv(txt_detalle_tarea7.Text, VbStrConv.ProperCase)
                tar7.TAR_observaciones = StrConv(txtObservaciones5.Text, VbStrConv.ProperCase)
                tar7.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar7)
                datacontext.SubmitChanges()
            Else
            End If
            '----------------------------------------------------------------------------------------------
            If txt_detalle_tarea8.Text.Length <> 0 Then
                'REGISTRO 8 DE TAREA
                Dim tar8 = New TAREA
                If txtTiempo_Estimado8.Text.Length <> 0 Then
                    tar8.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado8.Text, VbStrConv.ProperCase)
                Else
                    tar8.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real8.Text.Length <> 0 Then
                    tar8.TAR_tiempo_real = StrConv(txtTiempo_Real8.Text, VbStrConv.ProperCase)
                Else
                    tar8.TAR_tiempo_real = 0
                End If
                tar8.COL_id_colaborador = txt_id_colaborador.Text
                tar8.ORT_id_orden_trabajo = txt_id_orden_trabajo8.Text
                tar8.TAR_hora_fin = StrConv(txtHora_Finalizacion8.Text, VbStrConv.ProperCase)
                '  tar8.TAR_carga_horaria = "0"
                tar8.TAR_detalle_tarea = StrConv(txt_detalle_tarea8.Text, VbStrConv.ProperCase)
                tar8.TAR_observaciones = StrConv(txtObservaciones8.Text, VbStrConv.ProperCase)
                tar8.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar8)
                datacontext.SubmitChanges()
            Else
            End If
            '---------------------------------------------------------------------------------------------
            If txt_detalle_tarea9.Text.Length <> 0 Then
                'REGISTRO 9 DE TAREA
                Dim tar9 = New TAREA
                If txtTiempo_Estimado9.Text.Length <> 0 Then
                    tar9.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado9.Text, VbStrConv.ProperCase)
                Else
                    tar9.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real9.Text.Length <> 0 Then
                    tar9.TAR_tiempo_real = StrConv(txtTiempo_Real9.Text, VbStrConv.ProperCase)
                Else
                    tar9.TAR_tiempo_real = 0
                End If
                tar9.COL_id_colaborador = txt_id_colaborador.Text
                tar9.ORT_id_orden_trabajo = txt_id_orden_trabajo9.Text
                tar9.TAR_hora_fin = StrConv(txtHora_Finalizacion9.Text, VbStrConv.ProperCase)
                '  tar9.TAR_carga_horaria = "0"
                tar9.TAR_detalle_tarea = StrConv(txt_detalle_tarea9.Text, VbStrConv.ProperCase)
                tar9.TAR_observaciones = StrConv(txtObservaciones9.Text, VbStrConv.ProperCase)
                tar9.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar9)
                datacontext.SubmitChanges()
            Else
            End If
            '--------------------------------------------------------------------------------------------
            If txt_detalle_tarea10.Text.Length <> 0 Then
                'REGISTRO 10 DE TAREA
                Dim tar10 = New TAREA
                If txtTiempo_Estimado10.Text.Length <> 0 Then
                    tar10.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado10.Text, VbStrConv.ProperCase)
                Else
                    tar10.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real10.Text.Length <> 0 Then
                    tar10.TAR_tiempo_real = StrConv(txtTiempo_Real10.Text, VbStrConv.ProperCase)
                Else
                    tar10.TAR_tiempo_real = 0
                End If
                tar10.COL_id_colaborador = txt_id_colaborador.Text
                tar10.ORT_id_orden_trabajo = txt_id_orden_trabajo10.Text
                tar10.TAR_hora_fin = StrConv(txtHora_Finalizacion10.Text, VbStrConv.ProperCase)
                '  tar10.TAR_carga_horaria = "0"
                tar10.TAR_detalle_tarea = StrConv(txt_detalle_tarea10.Text, VbStrConv.ProperCase)
                tar10.TAR_observaciones = StrConv(txtObservaciones10.Text, VbStrConv.ProperCase)
                tar10.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar10)
                datacontext.SubmitChanges()
            Else
            End If
            '-----------------------------------------------------------------------------------------------
            If txt_detalle_tarea11.Text.Length <> 0 Then
                'REGISTRO 11 DE TAREA
                Dim tar11 = New TAREA
                If txtTiempo_Estimado11.Text.Length <> 0 Then
                    tar11.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado11.Text, VbStrConv.ProperCase)
                Else
                    tar11.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real11.Text.Length <> 0 Then
                    tar11.TAR_tiempo_real = StrConv(txtTiempo_Real11.Text, VbStrConv.ProperCase)
                Else
                    tar11.TAR_tiempo_real = 0
                End If
                tar11.COL_id_colaborador = txt_id_colaborador.Text
                tar11.ORT_id_orden_trabajo = txt_id_orden_trabajo11.Text
                tar11.TAR_hora_fin = StrConv(txtHora_Finalizacion11.Text, VbStrConv.ProperCase)
                '    tar11.TAR_carga_horaria = "0"
                tar11.TAR_detalle_tarea = StrConv(txt_detalle_tarea11.Text, VbStrConv.ProperCase)
                tar11.TAR_observaciones = StrConv(txtObservaciones11.Text, VbStrConv.ProperCase)
                tar11.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar11)
                datacontext.SubmitChanges()
            Else
            End If
            '---------------------------------------------------------------------------------------------
            If txt_detalle_tarea12.Text.Length <> 0 Then
                'REGISTRO 12 DE TAREA
                Dim tar12 = New TAREA
                If txtTiempo_Estimado12.Text.Length <> 0 Then
                    tar12.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado12.Text, VbStrConv.ProperCase)
                Else
                    tar12.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real12.Text.Length <> 0 Then
                    tar12.TAR_tiempo_real = StrConv(txtTiempo_Real12.Text, VbStrConv.ProperCase)
                Else
                    tar12.TAR_tiempo_real = 0
                End If
                tar12.COL_id_colaborador = txt_id_colaborador.Text
                tar12.ORT_id_orden_trabajo = txt_id_orden_trabajo12.Text
                tar12.TAR_hora_fin = StrConv(txtHora_Finalizacion12.Text, VbStrConv.ProperCase)
                '   tar12.TAR_carga_horaria = "0"
                tar12.TAR_detalle_tarea = StrConv(txt_detalle_tarea12.Text, VbStrConv.ProperCase)
                tar12.TAR_observaciones = StrConv(txtObservaciones12.Text, VbStrConv.ProperCase)
                tar12.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar12)
                datacontext.SubmitChanges()
            Else
            End If
            '---------------------------------------------------------------------------------------------
            If txt_detalle_tarea13.Text.Length <> 0 Then
                'REGISTRO 13 DE TAREA
                Dim tar13 = New TAREA
                If txtTiempo_Estimado13.Text.Length <> 0 Then
                    tar13.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado13.Text, VbStrConv.ProperCase)
                Else
                    tar13.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real13.Text.Length <> 0 Then
                    tar13.TAR_tiempo_real = StrConv(txtTiempo_Real13.Text, VbStrConv.ProperCase)
                Else
                    tar13.TAR_tiempo_real = 0
                End If
                tar13.COL_id_colaborador = txt_id_colaborador.Text
                tar13.ORT_id_orden_trabajo = txt_id_orden_trabajo13.Text
                tar13.TAR_hora_fin = StrConv(txtHora_Finalizacion13.Text, VbStrConv.ProperCase)
                '  tar13.TAR_carga_horaria = "0"
                tar13.TAR_detalle_tarea = StrConv(txt_detalle_tarea13.Text, VbStrConv.ProperCase)
                tar13.TAR_observaciones = StrConv(txtObservaciones13.Text, VbStrConv.ProperCase)
                tar13.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar13)
                datacontext.SubmitChanges()
            Else
            End If
            '----------------------------------------------------------------------------------------------
            If txt_detalle_tarea14.Text.Length <> 0 Then
                'REGISTRO 14 DE TAREA
                Dim tar14 = New TAREA
                If txtTiempo_Estimado14.Text.Length <> 0 Then
                    tar14.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado14.Text, VbStrConv.ProperCase)
                Else
                    tar14.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real14.Text.Length <> 0 Then
                    tar14.TAR_tiempo_real = StrConv(txtTiempo_Real14.Text, VbStrConv.ProperCase)
                Else
                    tar14.TAR_tiempo_real = 0
                End If
                tar14.COL_id_colaborador = txt_id_colaborador.Text
                tar14.ORT_id_orden_trabajo = txt_id_orden_trabajo14.Text
                tar14.TAR_hora_fin = StrConv(txtHora_Finalizacion14.Text, VbStrConv.ProperCase)
                '  tar14.TAR_carga_horaria = "0"
                tar14.TAR_detalle_tarea = StrConv(txt_detalle_tarea14.Text, VbStrConv.ProperCase)
                tar14.TAR_observaciones = StrConv(txtObservaciones14.Text, VbStrConv.ProperCase)
                tar14.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar14)
                datacontext.SubmitChanges()
            Else
            End If
            '------------------------------------------------------------------------------------------------
            If txt_detalle_tarea15.Text.Length <> 0 Then
                'REGISTRO 15 DE TAREA
                Dim tar15 = New TAREA
                If txtTiempo_Estimado15.Text.Length <> 0 Then
                    tar15.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado15.Text, VbStrConv.ProperCase)
                Else
                    tar15.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real15.Text.Length <> 0 Then
                    tar15.TAR_tiempo_real = StrConv(txtTiempo_Real15.Text, VbStrConv.ProperCase)
                Else
                    tar15.TAR_tiempo_real = 0
                End If
                tar15.COL_id_colaborador = txt_id_colaborador.Text
                tar15.ORT_id_orden_trabajo = txt_id_orden_trabajo15.Text
                tar15.TAR_hora_fin = StrConv(txtHora_Finalizacion15.Text, VbStrConv.ProperCase)
                '   tar15.TAR_carga_horaria = "0"
                tar15.TAR_detalle_tarea = StrConv(txt_detalle_tarea15.Text, VbStrConv.ProperCase)
                tar15.TAR_observaciones = StrConv(txtObservaciones15.Text, VbStrConv.ProperCase)
                tar15.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar15)
                datacontext.SubmitChanges()
            Else
            End If
            '-----------------------------------------------------------------------------------------------
            If txt_detalle_tarea16.Text.Length <> 0 Then
                'REGISTRO 16 DE TAREA
                Dim tar16 = New TAREA
                If txtTiempo_Estimado16.Text.Length <> 0 Then
                    tar16.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado16.Text, VbStrConv.ProperCase)
                Else
                    tar16.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real16.Text.Length <> 0 Then
                    tar16.TAR_tiempo_real = StrConv(txtTiempo_Real16.Text, VbStrConv.ProperCase)
                Else
                    tar16.TAR_tiempo_real = 0
                End If
                tar16.COL_id_colaborador = txt_id_colaborador.Text
                tar16.ORT_id_orden_trabajo = txt_id_orden_trabajo16.Text
                tar16.TAR_hora_fin = StrConv(txtHora_Finalizacion16.Text, VbStrConv.ProperCase)
                '    tar16.TAR_carga_horaria = "0"
                tar16.TAR_detalle_tarea = StrConv(txt_detalle_tarea16.Text, VbStrConv.ProperCase)
                tar16.TAR_observaciones = StrConv(txtObservaciones16.Text, VbStrConv.ProperCase)
                tar16.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar16)
                datacontext.SubmitChanges()
            Else
            End If
            '-----------------------------------------------------------------------------------------------
            If txt_detalle_tarea17.Text.Length <> 0 Then
                'REGISTRO 17 DE TAREA
                Dim tar17 = New TAREA
                If txtTiempo_Estimado17.Text.Length <> 0 Then
                    tar17.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado17.Text, VbStrConv.ProperCase)
                Else
                    tar17.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real17.Text.Length <> 0 Then
                    tar17.TAR_tiempo_real = StrConv(txtTiempo_Real17.Text, VbStrConv.ProperCase)
                Else
                    tar17.TAR_tiempo_real = 0
                End If
                tar17.COL_id_colaborador = txt_id_colaborador.Text
                tar17.ORT_id_orden_trabajo = txt_id_orden_trabajo17.Text
                tar17.TAR_hora_fin = StrConv(txtHora_Finalizacion17.Text, VbStrConv.ProperCase)
                '  tar17.TAR_carga_horaria = "0"
                tar17.TAR_detalle_tarea = StrConv(txt_detalle_tarea17.Text, VbStrConv.ProperCase)
                tar17.TAR_observaciones = StrConv(txtObservaciones17.Text, VbStrConv.ProperCase)
                tar17.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar17)
                datacontext.SubmitChanges()
            Else
            End If
            '----------------------------------------------------------------------------------------------
            If txt_detalle_tarea18.Text.Length <> 0 Then
                'REGISTRO 18 DE TAREA
                Dim tar18 = New TAREA
                If txtTiempo_Estimado18.Text.Length <> 0 Then
                    tar18.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado18.Text, VbStrConv.ProperCase)
                Else
                    tar18.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real18.Text.Length <> 0 Then
                    tar18.TAR_tiempo_real = StrConv(txtTiempo_Real18.Text, VbStrConv.ProperCase)
                Else
                    tar18.TAR_tiempo_real = 0
                End If
                tar18.COL_id_colaborador = txt_id_colaborador.Text
                tar18.ORT_id_orden_trabajo = txt_id_orden_trabajo18.Text
                tar18.TAR_hora_fin = StrConv(txtHora_Finalizacion18.Text, VbStrConv.ProperCase)
                '  tar18.TAR_carga_horaria = "0"
                tar18.TAR_detalle_tarea = StrConv(txt_detalle_tarea18.Text, VbStrConv.ProperCase)
                tar18.TAR_observaciones = StrConv(txtObservaciones18.Text, VbStrConv.ProperCase)
                tar18.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar18)
                datacontext.SubmitChanges()
            Else
            End If
            '-------------------------------------------------------------------------------------------------
            If txt_detalle_tarea19.Text.Length <> 0 Then
                'REGISTRO 19 DE TAREA
                Dim tar19 = New TAREA
                tar19.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado19.Text, VbStrConv.ProperCase)
                If txtTiempo_Real19.Text.Length <> 0 Then
                    tar19.TAR_tiempo_real = StrConv(txtTiempo_Real19.Text, VbStrConv.ProperCase)
                Else
                    tar19.TAR_tiempo_real = 0
                End If
                tar19.COL_id_colaborador = txt_id_colaborador.Text
                tar19.ORT_id_orden_trabajo = txt_id_orden_trabajo19.Text
                tar19.TAR_hora_fin = StrConv(txtHora_Finalizacion19.Text, VbStrConv.ProperCase)
                '  tar19.TAR_carga_horaria = "0"
                tar19.TAR_detalle_tarea = StrConv(txt_detalle_tarea19.Text, VbStrConv.ProperCase)
                tar19.TAR_observaciones = StrConv(txtObservaciones19.Text, VbStrConv.ProperCase)
                tar19.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar19)
                datacontext.SubmitChanges()
            Else
            End If
            '---------------------------------------------------------------------------------------------
            If txt_detalle_tarea20.Text.Length <> 0 Then
                'REGISTRO 20 DE TAREA
                Dim tar20 = New TAREA
                If txtTiempo_Estimado20.Text.Length <> 0 Then
                    tar20.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado20.Text, VbStrConv.ProperCase)
                Else
                    tar20.TAR_tiempo_estimado = 0
                End If
                If txtTiempo_Real20.Text.Length <> 0 Then
                    tar20.TAR_tiempo_real = StrConv(txtTiempo_Real20.Text, VbStrConv.ProperCase)
                Else
                    tar20.TAR_tiempo_real = 0
                End If
                tar20.COL_id_colaborador = txt_id_colaborador.Text
                tar20.ORT_id_orden_trabajo = txt_id_orden_trabajo20.Text
                tar20.TAR_hora_fin = StrConv(txtHora_Finalizacion20.Text, VbStrConv.ProperCase)
                ' tar20.TAR_carga_horaria = "0"
                tar20.TAR_detalle_tarea = StrConv(txt_detalle_tarea20.Text, VbStrConv.ProperCase)
                tar20.TAR_observaciones = StrConv(txtObservaciones20.Text, VbStrConv.ProperCase)
                tar20.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar20)
                datacontext.SubmitChanges()
            Else
            End If

            'Select Case MsgBox("La tarea se ha creado correctamente, desea imprimir??", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Imprimir Tareas")
            '    Case MsgBoxResult.Yes
            '        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
            '        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
            '        '  PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

            '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 30
            '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 30
            '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 30
            '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 30
            '        PrintForm1.Print() 'imprimir
            'End Select

            MsgBox("Las tareas se han guardado correctamente")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al intentar guardar las Tareas")
            limpiarcontroles()
        End Try
    End Sub

    Private Sub frm_GuardarActualizar_tarea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'actualiza_y_guarda()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click

        'VALIDA CAMPO COLABORADOR
        If txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Seleccione al colaborador")
            btnBuscar_Colaborador.Focus()
            Exit Sub
        End If
        'VALIDA CAMPO ENTRADA
        If txtEntrada.Text.Length = 0 Then
            MsgBox("Debe ingresar horario de entrada")
            txtEntrada.Focus()
            Exit Sub
        End If
        'VALIDA CAMPO SALIDA
        If txtSalida.Text.Length = 0 Then
            MsgBox("Debe ingresar horario de salida")
            txtSalida.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------
        'VALIDA QUE SE INGRESE AL MENOS UNA TAREA
        If txtNumero_Orden_Trabajo1.Text.Length = 0 And txt_detalle_tarea1.Text.Length = 0 Then
            MsgBox("Debe cargar al menos una tarea")
            txt_detalle_tarea1.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA PRIMERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo1.Text.Length = 0 And txt_detalle_tarea1.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 1")
            btnBuscar_Numero_Orden1.Focus()
            Exit Sub
        End If
        'VALIDA QUE EL CAMPO DE LA PRIMERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo1.Text.Length <> 0 And txt_detalle_tarea1.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 1")
            txt_detalle_tarea1.Focus()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA SEGUNDA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo2.Text.Length = 0 And txt_detalle_tarea2.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 2")
            btnBuscar_Numero_Orden2.Focus()
            Exit Sub
        End If
        'VALIDA QUE EL CAMPO DE LA SEGUNDA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo2.Text.Length <> 0 And txt_detalle_tarea2.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 2")
            txt_detalle_tarea2.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA TERCER TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo3.Text.Length = 0 And txt_detalle_tarea3.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 3")
            btnBuscar_Numero_Orden3.Focus()
            Exit Sub
        End If
        'VALIDA QUE EL CAMPO DE LA TERCER TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo3.Text.Length <> 0 And txt_detalle_tarea3.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 3")
            txt_detalle_tarea3.Focus()
            Exit Sub
        End If
        '------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA CUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo4.Text.Length = 0 And txt_detalle_tarea4.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 4")
            btnBuscar_Numero_Orden4.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA CUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo4.Text.Length <> 0 And txt_detalle_tarea4.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 4")
            txt_detalle_tarea4.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA QUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo5.Text.Length = 0 And txt_detalle_tarea5.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 5")
            btnBuscar_Numero_Orden5.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA QUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo5.Text.Length <> 0 And txt_detalle_tarea5.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 5")
            txt_detalle_tarea5.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA SEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo6.Text.Length = 0 And txt_detalle_tarea6.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 6")
            btnBuscar_Numero_Orden6.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA SEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo6.Text.Length <> 0 And txt_detalle_tarea6.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 6")
            txt_detalle_tarea6.Focus()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA SEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo7.Text.Length = 0 And txt_detalle_tarea7.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 7")
            btnBuscar_Numero_Orden7.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA SEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo7.Text.Length <> 0 And txt_detalle_tarea7.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 7")
            txt_detalle_tarea7.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA OCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo8.Text.Length = 0 And txt_detalle_tarea8.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 8")
            btnBuscar_Numero_Orden8.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA OCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo8.Text.Length <> 0 And txt_detalle_tarea8.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 8")
            txt_detalle_tarea8.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA NOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo9.Text.Length = 0 And txt_detalle_tarea9.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 9")
            btnBuscar_Numero_Orden9.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA NOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo9.Text.Length <> 0 And txt_detalle_tarea9.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 9")
            txt_detalle_tarea9.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo10.Text.Length = 0 And txt_detalle_tarea10.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 10")
            btnBuscar_Numero_Orden10.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo10.Text.Length <> 0 And txt_detalle_tarea10.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 10")
            txt_detalle_tarea10.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA UNDECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo11.Text.Length = 0 And txt_detalle_tarea11.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 11")
            btnBuscar_Numero_Orden11.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA UNDECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo11.Text.Length <> 0 And txt_detalle_tarea11.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 11")
            txt_detalle_tarea11.Focus()
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DUODECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo12.Text.Length = 0 And txt_detalle_tarea12.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 12")
            btnBuscar_Numero_Orden12.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DUODECIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo12.Text.Length <> 0 And txt_detalle_tarea12.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 12")
            txt_detalle_tarea12.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOTERCERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo13.Text.Length = 0 And txt_detalle_tarea13.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 13")
            btnBuscar_Numero_Orden13.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOTERCERA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo13.Text.Length <> 0 And txt_detalle_tarea13.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 13")
            txt_detalle_tarea13.Focus()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOCUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo14.Text.Length = 0 And txt_detalle_tarea14.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 14")
            btnBuscar_Numero_Orden14.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOCUARTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo14.Text.Length <> 0 And txt_detalle_tarea14.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 14")
            txt_detalle_tarea14.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOQUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo15.Text.Length = 0 And txt_detalle_tarea15.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 15")
            btnBuscar_Numero_Orden15.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOQUINTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo15.Text.Length <> 0 And txt_detalle_tarea15.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 15")
            txt_detalle_tarea15.Focus()
            Exit Sub
        End If

        '---------------------------------------------------------------------------------------------------
        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOSEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo16.Text.Length = 0 And txt_detalle_tarea16.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 16")
            btnBuscar_Numero_Orden16.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOSEXTA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo16.Text.Length <> 0 And txt_detalle_tarea16.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 16")
            txt_detalle_tarea16.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOSEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo17.Text.Length = 0 And txt_detalle_tarea17.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 17")
            btnBuscar_Numero_Orden17.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOSEPTIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo17.Text.Length <> 0 And txt_detalle_tarea17.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 17")
            txt_detalle_tarea17.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMOOCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo18.Text.Length = 0 And txt_detalle_tarea18.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 18")
            btnBuscar_Numero_Orden18.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMOOCTAVA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo18.Text.Length <> 0 And txt_detalle_tarea18.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 18")
            txt_detalle_tarea18.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA DECIMONOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo19.Text.Length = 0 And txt_detalle_tarea19.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 19")
            btnBuscar_Numero_Orden19.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA DECIMONOVENA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo19.Text.Length <> 0 And txt_detalle_tarea19.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 19")
            txt_detalle_tarea19.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        'VALIDA QUE EL NUMERO DE ORDEN DE LA BIGESIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo20.Text.Length = 0 And txt_detalle_tarea20.Text.Length <> 0 Then
            MsgBox("Seleccione una orden para la tarea 20")
            btnBuscar_Numero_Orden20.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL CAMPO DE LA BIGESIMA TAREA NO ESTE VACIO
        If txtNumero_Orden_Trabajo20.Text.Length <> 0 And txt_detalle_tarea20.Text.Length = 0 Then
            MsgBox("Complete el campo de la tarea 20")
            txt_detalle_tarea20.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------

        Try
            actualiza_y_guarda()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar tarea")
        End Try

    End Sub

    Sub limpiarcontroles()
        txt_id_tarea.Clear()
        txt_Id_Tarea1.Clear()
        txt_Id_Tarea2.Clear()
        txt_Id_Tarea3.Clear()
        txt_Id_Tarea4.Clear()
        txt_Id_Tarea5.Clear()
        txt_Id_Tarea6.Clear()
        txt_Id_Tarea7.Clear()
        txt_Id_Tarea8.Clear()
        txt_Id_Tarea9.Clear()
        txt_Id_Tarea10.Clear()
        txt_Id_Tarea11.Clear()
        txt_Id_Tarea12.Clear()
        txt_Id_Tarea13.Clear()
        txt_Id_Tarea14.Clear()
        txt_Id_Tarea15.Clear()
        txt_Id_Tarea16.Clear()
        txt_Id_Tarea17.Clear()
        txt_Id_Tarea18.Clear()
        txt_Id_Tarea19.Clear()
        txt_Id_Tarea20.Clear()

        txt_detalle_tarea1.Clear()
        txt_detalle_tarea2.Clear()
        txt_detalle_tarea3.Clear()
        txt_detalle_tarea4.Clear()
        txt_detalle_tarea5.Clear()
        txt_detalle_tarea6.Clear()
        txt_detalle_tarea7.Clear()
        txt_detalle_tarea8.Clear()
        txt_detalle_tarea9.Clear()
        txt_detalle_tarea10.Clear()
        txt_detalle_tarea11.Clear()
        txt_detalle_tarea12.Clear()
        txt_detalle_tarea13.Clear()
        txt_detalle_tarea14.Clear()
        txt_detalle_tarea15.Clear()
        txt_detalle_tarea16.Clear()
        txt_detalle_tarea17.Clear()
        txt_detalle_tarea18.Clear()
        txt_detalle_tarea19.Clear()
        txt_detalle_tarea20.Clear()

        txtTiempo_Estimado1.Clear()
        txtTiempo_Estimado2.Clear()
        txtTiempo_Estimado3.Clear()
        txtTiempo_Estimado2.Clear()
        txtTiempo_Estimado4.Clear()
        txtTiempo_Estimado5.Clear()
        txtTiempo_Estimado6.Clear()
        txtTiempo_Estimado7.Clear()
        txtTiempo_Estimado8.Clear()
        txtTiempo_Estimado9.Clear()
        txtTiempo_Estimado10.Clear()
        txtTiempo_Estimado11.Clear()
        txtTiempo_Estimado12.Clear()
        txtTiempo_Estimado13.Clear()
        txtTiempo_Estimado14.Clear()
        txtTiempo_Estimado15.Clear()
        txtTiempo_Estimado16.Clear()
        txtTiempo_Estimado17.Clear()
        txtTiempo_Estimado18.Clear()
        txtTiempo_Estimado19.Clear()
        txtTiempo_Estimado20.Clear()

        txtTiempo_Real1.Clear()
        txtTiempo_Real2.Clear()
        txtTiempo_Real3.Clear()
        txtTiempo_Real2.Clear()
        txtTiempo_Real4.Clear()
        txtTiempo_Real5.Clear()
        txtTiempo_Real6.Clear()
        txtTiempo_Real7.Clear()
        txtTiempo_Real8.Clear()
        txtTiempo_Real9.Clear()
        txtTiempo_Real10.Clear()
        txtTiempo_Real11.Clear()
        txtTiempo_Real12.Clear()
        txtTiempo_Real13.Clear()
        txtTiempo_Real14.Clear()
        txtTiempo_Real15.Clear()
        txtTiempo_Real16.Clear()
        txtTiempo_Real17.Clear()
        txtTiempo_Real18.Clear()
        txtTiempo_Real19.Clear()
        txtTiempo_Real20.Clear()

        txt_id_colaborador.Clear()
        txt_id_orden_trabajo1.Clear()

        txtHora_Finalizacion1.Clear()
        txtHora_Finalizacion2.Clear()
        txtHora_Finalizacion3.Clear()
        txtHora_Finalizacion4.Clear()
        txtHora_Finalizacion5.Clear()
        txtHora_Finalizacion6.Clear()
        txtHora_Finalizacion7.Clear()
        txtHora_Finalizacion8.Clear()
        txtHora_Finalizacion9.Clear()
        txtHora_Finalizacion10.Clear()
        txtHora_Finalizacion11.Clear()
        txtHora_Finalizacion12.Clear()
        txtHora_Finalizacion13.Clear()
        txtHora_Finalizacion14.Clear()
        txtHora_Finalizacion15.Clear()
        txtHora_Finalizacion16.Clear()
        txtHora_Finalizacion17.Clear()
        txtHora_Finalizacion18.Clear()
        txtHora_Finalizacion19.Clear()
        txtHora_Finalizacion20.Clear()

        txtObservaciones1.Clear()
        txtObservaciones2.Clear()
        txtObservaciones3.Clear()
        txtObservaciones4.Clear()
        txtObservaciones5.Clear()
        txtObservaciones6.Clear()
        txtObservaciones7.Clear()
        txtObservaciones8.Clear()
        txtObservaciones9.Clear()
        txtObservaciones10.Clear()
        txtObservaciones11.Clear()
        txtObservaciones12.Clear()
        txtObservaciones13.Clear()
        txtObservaciones14.Clear()
        txtObservaciones15.Clear()
        txtObservaciones16.Clear()
        txtObservaciones17.Clear()
        txtObservaciones18.Clear()
        txtObservaciones19.Clear()
        txtObservaciones20.Clear()

        txtNumero_Orden_Trabajo1.Clear()
        txtNumero_Orden_Trabajo2.Clear()
        txtNumero_Orden_Trabajo3.Clear()
        txtNumero_Orden_Trabajo4.Clear()
        txtNumero_Orden_Trabajo5.Clear()
        txtNumero_Orden_Trabajo6.Clear()
        txtNumero_Orden_Trabajo7.Clear()
        txtNumero_Orden_Trabajo8.Clear()
        txtNumero_Orden_Trabajo9.Clear()
        txtNumero_Orden_Trabajo10.Clear()
        txtNumero_Orden_Trabajo11.Clear()
        txtNumero_Orden_Trabajo12.Clear()
        txtNumero_Orden_Trabajo13.Clear()
        txtNumero_Orden_Trabajo14.Clear()
        txtNumero_Orden_Trabajo15.Clear()
        txtNumero_Orden_Trabajo16.Clear()
        txtNumero_Orden_Trabajo17.Clear()
        txtNumero_Orden_Trabajo18.Clear()
        txtNumero_Orden_Trabajo19.Clear()
        txtNumero_Orden_Trabajo20.Clear()

        txt_id_orden_trabajo1.Clear()
        txt_id_orden_trabajo2.Clear()
        txt_id_orden_trabajo3.Clear()
        txt_id_orden_trabajo4.Clear()
        txt_id_orden_trabajo5.Clear()
        txt_id_orden_trabajo6.Clear()
        txt_id_orden_trabajo7.Clear()
        txt_id_orden_trabajo8.Clear()
        txt_id_orden_trabajo9.Clear()
        txt_id_orden_trabajo10.Clear()
        txt_id_orden_trabajo11.Clear()
        txt_id_orden_trabajo12.Clear()
        txt_id_orden_trabajo13.Clear()
        txt_id_orden_trabajo14.Clear()
        txt_id_orden_trabajo15.Clear()
        txt_id_orden_trabajo16.Clear()
        txt_id_orden_trabajo17.Clear()
        txt_id_orden_trabajo18.Clear()
        txt_id_orden_trabajo19.Clear()
        txt_id_orden_trabajo20.Clear()

    End Sub

    Sub actualiza_y_guarda()
        Dim temp_txt As TextBox = New TextBox
        For i = 1 To 20
            Select Case i
                Case 1
                    If txt_Id_Tarea1.TextLength <> 0 Then
                        actualizar(txtTiempo_Estimado1, txtTiempo_Real1, txt_id_orden_trabajo1, txtHora_Finalizacion1, txt_detalle_tarea1, txtObservaciones1, txt_Id_Tarea1, txtEntrada, txtSalida)
                    ElseIf txt_id_orden_trabajo1.TextLength <> 0 Then
                        guardar(txtTiempo_Estimado1, txtTiempo_Real1, txt_id_orden_trabajo1, txtHora_Finalizacion1, txt_detalle_tarea1, txtObservaciones1, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    End If
                Case 2
                    If txt_Id_Tarea2.TextLength <> 0 Then
                        actualizar(txtTiempo_Estimado2, txtTiempo_Real2, txt_id_orden_trabajo2, txtHora_Finalizacion2, txt_detalle_tarea2, txtObservaciones2, txt_Id_Tarea2, txtEntrada, txtSalida)
                    ElseIf txt_id_orden_trabajo2.TextLength <> 0 Then
                        guardar(txtTiempo_Estimado2, txtTiempo_Real2, txt_id_orden_trabajo2, txtHora_Finalizacion2, txt_detalle_tarea2, txtObservaciones2, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    End If
                Case 3
                    If txt_Id_Tarea3.TextLength <> 0 Then
                        actualizar(txtTiempo_Estimado3, txtTiempo_Real3, txt_id_orden_trabajo3, txtHora_Finalizacion3, txt_detalle_tarea3, txtObservaciones3, txt_Id_Tarea3, txtEntrada, txtSalida)
                    ElseIf txt_id_orden_trabajo3.TextLength <> 0 Then
                        guardar(txtTiempo_Estimado3, txtTiempo_Real3, txt_id_orden_trabajo3, txtHora_Finalizacion3, txt_detalle_tarea3, txtObservaciones3, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    End If
                Case 4
                    If txt_Id_Tarea4.TextLength <> 0 Then
                        actualizar(txtTiempo_Estimado4, txtTiempo_Real4, txt_id_orden_trabajo4, txtHora_Finalizacion4, txt_detalle_tarea4, txtObservaciones4, txt_Id_Tarea4, txtEntrada, txtSalida)
                    ElseIf txt_id_orden_trabajo4.TextLength <> 0 Then
                        guardar(txtTiempo_Estimado4, txtTiempo_Real4, txt_id_orden_trabajo4, txtHora_Finalizacion4, txt_detalle_tarea4, txtObservaciones4, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    End If
                Case 5
                    If txt_Id_Tarea5.TextLength <> 0 Then
                        actualizar(txtTiempo_Estimado5, txtTiempo_Real5, txt_id_orden_trabajo5, txtHora_Finalizacion5, txt_detalle_tarea5, txtObservaciones5, txt_Id_Tarea5, txtEntrada, txtSalida)
                    ElseIf txt_id_orden_trabajo5.TextLength <> 0 Then
                        guardar(txtTiempo_Estimado5, txtTiempo_Real5, txt_id_orden_trabajo5, txtHora_Finalizacion5, txt_detalle_tarea5, txtObservaciones5, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    End If
                Case 6
                    If txt_Id_Tarea6.TextLength <> 0 Then
                        actualizar(txtTiempo_Estimado6, txtTiempo_Real6, txt_id_orden_trabajo6, txtHora_Finalizacion6, txt_detalle_tarea6, txtObservaciones6, txt_Id_Tarea6, txtEntrada, txtSalida)
                    ElseIf txt_id_orden_trabajo6.TextLength <> 0 Then
                        guardar(txtTiempo_Estimado6, txtTiempo_Real6, txt_id_orden_trabajo6, txtHora_Finalizacion6, txt_detalle_tarea6, txtObservaciones6, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    End If
                    'Case 7
                    '    If txt_Id_Tarea7.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado7, txtTiempo_Real7, txt_id_orden_trabajo7, txtHora_Finalizacion7, txt_detalle_tarea7, txtObservaciones7, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo7.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado7, txtTiempo_Real7, txt_id_orden_trabajo7, txtHora_Finalizacion7, txt_detalle_tarea7, txtObservaciones7, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 8
                    '    If txt_Id_Tarea8.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado8, txtTiempo_Real8, txt_id_orden_trabajo8, txtHora_Finalizacion8, txt_detalle_tarea8, txtObservaciones8, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo8.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado8, txtTiempo_Real8, txt_id_orden_trabajo8, txtHora_Finalizacion8, txt_detalle_tarea8, txtObservaciones8, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 9
                    '    If txt_Id_Tarea9.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado9, txtTiempo_Real9, txt_id_orden_trabajo9, txtHora_Finalizacion9, txt_detalle_tarea9, txtObservaciones9, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo9.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado9, txtTiempo_Real9, txt_id_orden_trabajo9, txtHora_Finalizacion9, txt_detalle_tarea9, txtObservaciones9, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 10
                    '    If txt_Id_Tarea10.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado10, txtTiempo_Real10, txt_id_orden_trabajo10, txtHora_Finalizacion10, txt_detalle_tarea10, txtObservaciones10, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo10.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado10, txtTiempo_Real10, txt_id_orden_trabajo10, txtHora_Finalizacion10, txt_detalle_tarea10, txtObservaciones10, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 11
                    '    If txt_Id_Tarea11.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado11, txtTiempo_Real11, txt_id_orden_trabajo11, txtHora_Finalizacion11, txt_detalle_tarea11, txtObservaciones11, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo11.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado11, txtTiempo_Real11, txt_id_orden_trabajo11, txtHora_Finalizacion11, txt_detalle_tarea11, txtObservaciones11, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 12
                    '    If txt_Id_Tarea12.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado12, txtTiempo_Real12, txt_id_orden_trabajo12, txtHora_Finalizacion12, txt_detalle_tarea12, txtObservaciones12, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo12.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado12, txtTiempo_Real12, txt_id_orden_trabajo12, txtHora_Finalizacion12, txt_detalle_tarea12, txtObservaciones12, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 13
                    '    If txt_Id_Tarea13.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado13, txtTiempo_Real13, txt_id_orden_trabajo13, txtHora_Finalizacion13, txt_detalle_tarea13, txtObservaciones13, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo13.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado13, txtTiempo_Real13, txt_id_orden_trabajo13, txtHora_Finalizacion13, txt_detalle_tarea13, txtObservaciones13, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 14
                    '    If txt_Id_Tarea14.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado14, txtTiempo_Real14, txt_id_orden_trabajo14, txtHora_Finalizacion14, txt_detalle_tarea14, txtObservaciones14, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo14.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado14, txtTiempo_Real14, txt_id_orden_trabajo14, txtHora_Finalizacion14, txt_detalle_tarea14, txtObservaciones14, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 15
                    '    If txt_Id_Tarea15.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado15, txtTiempo_Real15, txt_id_orden_trabajo15, txtHora_Finalizacion15, txt_detalle_tarea15, txtObservaciones15, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo15.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado15, txtTiempo_Real15, txt_id_orden_trabajo15, txtHora_Finalizacion15, txt_detalle_tarea15, txtObservaciones15, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 16
                    '    If txt_Id_Tarea16.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado16, txtTiempo_Real16, txt_id_orden_trabajo16, txtHora_Finalizacion16, txt_detalle_tarea16, txtObservaciones16, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo16.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado16, txtTiempo_Real16, txt_id_orden_trabajo16, txtHora_Finalizacion16, txt_detalle_tarea16, txtObservaciones16, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 17
                    '    If txt_Id_Tarea17.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado17, txtTiempo_Real17, txt_id_orden_trabajo17, txtHora_Finalizacion17, txt_detalle_tarea17, txtObservaciones17, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo17.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado17, txtTiempo_Real17, txt_id_orden_trabajo17, txtHora_Finalizacion17, txt_detalle_tarea17, txtObservaciones17, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 18
                    '    If txt_Id_Tarea18.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado18, txtTiempo_Real18, txt_id_orden_trabajo18, txtHora_Finalizacion18, txt_detalle_tarea18, txtObservaciones18, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo18.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado18, txtTiempo_Real18, txt_id_orden_trabajo18, txtHora_Finalizacion18, txt_detalle_tarea18, txtObservaciones18, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 19
                    '    If txt_Id_Tarea19.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado19, txtTiempo_Real19, txt_id_orden_trabajo19, txtHora_Finalizacion19, txt_detalle_tarea19, txtObservaciones19, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo19.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado19, txtTiempo_Real19, txt_id_orden_trabajo19, txtHora_Finalizacion19, txt_detalle_tarea19, txtObservaciones19, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                    'Case 20
                    '    If txt_Id_Tarea20.TextLength <> 0 Then
                    '        actualizar(txtTiempo_Estimado20, txtTiempo_Real20, txt_id_orden_trabajo20, txtHora_Finalizacion20, txt_detalle_tarea20, txtObservaciones20, txtEntrada, txtSalida)
                    '    ElseIf txt_id_orden_trabajo20.TextLength <> 0 Then
                    '        guardar(txtTiempo_Estimado20, txtTiempo_Real20, txt_id_orden_trabajo20, txtHora_Finalizacion20, txt_detalle_tarea20, txtObservaciones20, txt_Carga_Horaria1, txt_id_colaborador, dtpFecha, txtEntrada, txtSalida, i)
                    '    End If
                Case Else
            End Select
        Next
    End Sub

    Private Sub btnCancelar_Tarea_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Tarea.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Sub guardar(ByVal estimado As Object, ByVal real As Object, ByVal odt As Object, ByVal fin As Object, ByVal detalle As Object, ByVal obs As Object, ByVal carga As Object, _
                ByVal colab As Object, ByVal fecha As Object, ByVal entrada As Object, ByVal salida As Object, ByVal i As Integer)
        Dim tar = New TAREA

        If estimado.Text.Length <> 0 Then
            tar.TAR_tiempo_estimado = StrConv(estimado.Text, VbStrConv.ProperCase)
        Else
            tar.TAR_tiempo_estimado = 0
        End If
        If real.Text.Length <> 0 Then
            tar.TAR_tiempo_real = StrConv(real.Text, VbStrConv.ProperCase)
        Else
            tar.TAR_tiempo_real = 0
        End If
        tar.COL_id_colaborador = colab.Text
        tar.ORT_id_orden_trabajo = CInt(odt.Text)
        tar.TAR_hora_fin = StrConv(fin.Text, VbStrConv.ProperCase)

        tar.TAR_detalle_tarea = StrConv(detalle.Text, VbStrConv.ProperCase)
        tar.TAR_observaciones = StrConv(obs.Text, VbStrConv.ProperCase)
        tar.TAR_fecha = CDate(fecha.Text)

        If i = 1 Then
            If buscartarea = False Then
                tar.TAR_carga_horaria = StrConv(carga.Text, VbStrConv.ProperCase)
                tar.TAR_entrada = txtEntrada.Text
                tar.TAR_salida = txtSalida.Text
            End If
        End If
        datacontext.TAREA.InsertOnSubmit(tar)
        datacontext.SubmitChanges()

    End Sub

    Sub actualizar(ByVal estimado As Object, ByVal real As Object, ByVal odt As Object, ByVal fin As Object, ByVal detalle As Object, ByVal obs As Object, ByVal idtar As Object, ByVal ent As Object, ByVal sal As Object)

        Dim temp_idtar As String = CInt(idtar.text)

        Dim ActualizarTarea = (From P In datacontext.TAREA Where P.TAR_id_tarea = temp_idtar).ToList()(0)

        ActualizarTarea.TAR_tiempo_estimado = StrConv(estimado.Text, VbStrConv.ProperCase)
        ActualizarTarea.TAR_tiempo_real = StrConv(real.Text, VbStrConv.ProperCase)
        ActualizarTarea.ORT_id_orden_trabajo = CInt(odt.Text)
        ActualizarTarea.TAR_hora_fin = StrConv(fin.Text, VbStrConv.ProperCase)
        ActualizarTarea.TAR_detalle_tarea = StrConv(detalle.Text, VbStrConv.ProperCase)
        ActualizarTarea.TAR_observaciones = StrConv(obs.Text, VbStrConv.ProperCase)
        ActualizarTarea.TAR_entrada = StrConv(ent.Text, VbStrConv.ProperCase)
        ActualizarTarea.TAR_salida = StrConv(sal.Text, VbStrConv.ProperCase)
        datacontext.SubmitChanges()
    End Sub

    Private Sub txtEntrada_LostFocus(sender As Object, e As System.EventArgs) Handles txtEntrada.LostFocus
        Try
            If txtEntrada.TextLength <> 0 And txtSalida.TextLength <> 0 Then
                calcula_minutos()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Complete los campos 'Hora de Entrada' y 'Hora de Salida'")
        End Try
    End Sub

    Private Sub txtEntrada_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEntrada.TextChanged
        Try
            'VALIDA LA HORA INGRESADA
            Select Case Len(txtEntrada.Text)
                Case 5
                    If Microsoft.VisualBasic.Right(txtEntrada.Text, 2) > 59 Then
                        MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                        txtEntrada.Text = Microsoft.VisualBasic.Right(txtEntrada.Text, Len(txtEntrada.Text) - 2)
                    Else
                        txtEntrada.Text = txtEntrada.Text & ""
                    End If
                Case 2
                    If Microsoft.VisualBasic.Left(txtEntrada.Text, 2) > 23 Then
                        MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                        txtEntrada.Text = Microsoft.VisualBasic.Left(txtEntrada.Text, Len(txtEntrada.Text) - 2)
                    Else
                        txtEntrada.Text = txtEntrada.Text & ":"
                        Me.txtEntrada.SelectionStart = 3
                    End If
            End Select
        Catch ex As Exception
            MsgBox("El formato de la hora de entrada es: '00:00'")
        End Try
    End Sub

    Private Sub txtSalida_LostFocus(sender As Object, e As System.EventArgs) Handles txtSalida.LostFocus
        Try
            If txtEntrada.TextLength <> 0 And txtSalida.TextLength <> 0 Then
                calcula_minutos()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Complete los campos 'Hora de Entrada' y 'Hora de Salida'")
        End Try
    End Sub

    Private Sub txtSalida_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSalida.TextChanged
        Try
            'VALIDA LA HORA INGRESADA
            Select Case Len(txtSalida.Text)
                Case 5
                    If Microsoft.VisualBasic.Right(txtSalida.Text, 2) > 59 Then
                        MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                        txtSalida.Text = Microsoft.VisualBasic.Right(txtSalida.Text, Len(txtSalida.Text) - 2)
                    Else
                        txtSalida.Text = txtSalida.Text & ""
                    End If
                Case 2
                    If Microsoft.VisualBasic.Left(txtSalida.Text, 2) > 23 Then
                        MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                        txtSalida.Text = Microsoft.VisualBasic.Left(txtSalida.Text, Len(txtSalida.Text) - 2)
                    Else
                        txtSalida.Text = txtSalida.Text & ":"
                        Me.txtSalida.SelectionStart = 3
                    End If

            End Select
        Catch ex As Exception
            MsgBox("El formato de la hora de salida es: '00:00'")
        End Try
    End Sub

    Sub calcula_minutos()
        Dim qtddias As TimeSpan
        Dim totalmin As Integer = 0
        qtddias = CDate(txtSalida.Text).Subtract(CDate(txtEntrada.Text))
        totalmin = qtddias.TotalMinutes
        If totalmin < 0 Then
            totalmin = totalmin + 1440
        End If
        txt_Carga_Horaria1.Text = totalmin
    End Sub

    Private Sub btnBuscar_Numero_Orden2_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden2.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden2
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden3_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden3.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden3
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden4_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden4.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden4
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden5_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden5.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden5
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden6_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden6.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden6
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden7_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden7.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden7
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden8_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden8.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden8
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden9_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden9.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden9
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden10_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden10.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden10
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden11_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden11.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden11
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden12_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden12.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden12
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden13_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden13.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden13
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden14_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden14.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden14
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden15_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden15.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden15
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden16_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden16.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden16
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden17_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden17.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden17
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden18_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden18.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden18
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden19_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden19.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden19
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden20_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden20.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.quienllamobotonorden = Me.btnBuscar_Numero_Orden20
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.Show()
    End Sub
End Class