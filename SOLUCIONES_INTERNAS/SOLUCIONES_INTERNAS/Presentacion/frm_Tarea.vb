Public Class frm_Tarea
    Dim datacontext As New DataS_Interno

    Private Sub frm_Tarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_tarea.Visible = False
        Label1.Visible = False
        txt_detalle_tarea1.Focus()
        txt_id_colaborador.Visible = False
        txt_id_orden_trabajo.Visible = False

    End Sub

    Private Sub btnGuardar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Tarea.Click
        Try

            If txt_detalle_tarea1.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            'REGISTRO 1 DE TAREA
            Dim tar1 = New TAREA
            tar1.TAR_tiempo_estimado = txtTiempo_Estimado1.Text
            tar1.TAR_tiempo_real = txtTiempo_Real1.Text
            tar1.COL_id_colaborador = txt_id_colaborador.Text
            tar1.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar1.TAR_hora_fin = txtHora_Finalizacion1.Text
            tar1.TAR_carga_horaria = txt_Carga_Horaria1.Text
            tar1.TAR_detalle_tarea = txt_detalle_tarea1.Text
            tar1.TAR_observaciones = txtObservaciones1.Text
            tar1.TAR_fecha = dtpFecha.Text

            'REGISTRO 2 DE TAREA
            Dim tar2 = New TAREA
            tar2.TAR_tiempo_estimado = txtTiempo_Estimado2.Text
            tar2.TAR_tiempo_real = txtTiempo_Real2.Text
            tar2.COL_id_colaborador = txt_id_colaborador.Text
            tar2.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar2.TAR_hora_fin = txtHora_Finalizacion2.Text
            ' tar2.TAR_carga_horaria = txt_Carga_Horaria2.Text
            tar2.TAR_detalle_tarea = txt_detalle_tarea2.Text
            tar2.TAR_observaciones = txtObservaciones2.Text
            tar2.TAR_fecha = dtpFecha.Text

            'REGISTRO 3 DE TAREA
            Dim tar3 = New TAREA
            tar3.TAR_tiempo_estimado = txtTiempo_Estimado3.Text
            tar3.TAR_tiempo_real = txtTiempo_Real3.Text
            tar3.COL_id_colaborador = txt_id_colaborador.Text
            tar3.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar3.TAR_hora_fin = txtHora_Finalizacion3.Text
            ' tar3.TAR_carga_horaria = txt_Carga_Horaria3.Text
            tar3.TAR_detalle_tarea = txt_detalle_tarea3.Text
            tar3.TAR_observaciones = txtObservaciones3.Text
            tar3.TAR_fecha = dtpFecha.Text
          
            'REGISTRO 4 DE TAREA
            Dim tar4 = New TAREA
            tar4.TAR_tiempo_estimado = txtTiempo_Estimado4.Text
            tar4.TAR_tiempo_real = txtTiempo_Real4.Text
            tar4.COL_id_colaborador = txt_id_colaborador.Text
            tar4.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar4.TAR_hora_fin = txtHora_Finalizacion4.Text
            '  tar4.TAR_carga_horaria = txt_Carga_Horaria4.Text
            tar4.TAR_detalle_tarea = txt_detalle_tarea4.Text
            tar4.TAR_observaciones = txtObservaciones4.Text
            tar4.TAR_fecha = dtpFecha.Text

            'REGISTRO 5 DE TAREA
            Dim tar5 = New TAREA
            tar5.TAR_tiempo_estimado = txtTiempo_Estimado5.Text
            tar5.TAR_tiempo_real = txtTiempo_Real5.Text
            tar5.COL_id_colaborador = txt_id_colaborador.Text
            tar5.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar5.TAR_hora_fin = txtHora_Finalizacion5.Text
            '  tar5.TAR_carga_horaria = txt_Carga_Horaria5.Text
            tar5.TAR_detalle_tarea = txt_detalle_tarea5.Text
            tar5.TAR_observaciones = txtObservaciones5.Text
            tar5.TAR_fecha = dtpFecha.Text

            'REGISTRO 6 DE TAREA
            Dim tar6 = New TAREA
            tar6.TAR_tiempo_estimado = txtTiempo_Estimado6.Text
            tar6.TAR_tiempo_real = txtTiempo_Real6.Text
            tar6.COL_id_colaborador = txt_id_colaborador.Text
            tar6.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar6.TAR_hora_fin = txtHora_Finalizacion6.Text
            ' tar6.TAR_carga_horaria = txt_Carga_Horaria6.Text
            tar6.TAR_detalle_tarea = txt_detalle_tarea6.Text
            tar6.TAR_observaciones = txtObservaciones6.Text
            tar6.TAR_fecha = dtpFecha.Text

            'REGISTRO 7 DE TAREA
            Dim tar7 = New TAREA
            tar7.TAR_tiempo_estimado = txtTiempo_Estimado7.Text
            tar7.TAR_tiempo_real = txtTiempo_Real7.Text
            tar7.COL_id_colaborador = txt_id_colaborador.Text
            tar7.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar7.TAR_hora_fin = txtHora_Finalizacion7.Text
            '  tar7.TAR_carga_horaria = txt_Carga_Horaria7.Text
            tar7.TAR_detalle_tarea = txt_detalle_tarea7.Text
            tar7.TAR_observaciones = txtObservaciones5.Text
            tar7.TAR_fecha = dtpFecha.Text

            'REGISTRO 8 DE TAREA
            Dim tar8 = New TAREA
            tar8.TAR_tiempo_estimado = txtTiempo_Estimado8.Text
            tar8.TAR_tiempo_real = txtTiempo_Real8.Text
            tar8.COL_id_colaborador = txt_id_colaborador.Text
            tar8.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar8.TAR_hora_fin = txtHora_Finalizacion8.Text
            '  tar8.TAR_carga_horaria = txt_Carga_Horaria8.Text
            tar8.TAR_detalle_tarea = txt_detalle_tarea8.Text
            tar8.TAR_observaciones = txtObservaciones8.Text
            tar8.TAR_fecha = dtpFecha.Text

            'REGISTRO 9 DE TAREA
            Dim tar9 = New TAREA
            tar9.TAR_tiempo_estimado = txtTiempo_Estimado9.Text
            tar9.TAR_tiempo_real = txtTiempo_Real9.Text
            tar9.COL_id_colaborador = txt_id_colaborador.Text
            tar9.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar9.TAR_hora_fin = txtHora_Finalizacion9.Text
            ' tar9.TAR_carga_horaria = txt_Carga_Horaria9.Text
            tar9.TAR_detalle_tarea = txt_detalle_tarea9.Text
            tar9.TAR_observaciones = txtObservaciones9.Text
            tar9.TAR_fecha = dtpFecha.Text

            'REGISTRO 10 DE TAREA
            Dim tar10 = New TAREA
            tar10.TAR_tiempo_estimado = txtTiempo_Estimado10.Text
            tar10.TAR_tiempo_real = txtTiempo_Real10.Text
            tar10.COL_id_colaborador = txt_id_colaborador.Text
            tar10.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar10.TAR_hora_fin = txtHora_Finalizacion10.Text
            ' tar10.TAR_carga_horaria = txt_Carga_Horaria10.Text
            tar10.TAR_detalle_tarea = txt_detalle_tarea10.Text
            tar10.TAR_observaciones = txtObservaciones10.Text
            tar10.TAR_fecha = dtpFecha.Text

            'REGISTRO 11 DE TAREA
            Dim tar11 = New TAREA
            tar11.TAR_tiempo_estimado = txtTiempo_Estimado11.Text
            tar11.TAR_tiempo_real = txtTiempo_Real11.Text
            tar11.COL_id_colaborador = txt_id_colaborador.Text
            tar11.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar11.TAR_hora_fin = txtHora_Finalizacion11.Text
            ' tar11.TAR_carga_horaria = txt_Carga_Horaria11.Text
            tar11.TAR_detalle_tarea = txt_detalle_tarea11.Text
            tar11.TAR_observaciones = txtObservaciones11.Text
            tar11.TAR_fecha = dtpFecha.Text

            'REGISTRO 2 DE TAREA
            Dim tar12 = New TAREA
            tar12.TAR_tiempo_estimado = txtTiempo_Estimado12.Text
            tar12.TAR_tiempo_real = txtTiempo_Real2.Text
            tar12.COL_id_colaborador = txt_id_colaborador.Text
            tar12.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar12.TAR_hora_fin = txtHora_Finalizacion12.Text
            '  tar12.TAR_carga_horaria = txt_Carga_Horaria12.Text
            tar12.TAR_detalle_tarea = txt_detalle_tarea12.Text
            tar12.TAR_observaciones = txtObservaciones12.Text
            tar12.TAR_fecha = dtpFecha.Text

            'REGISTRO 13 DE TAREA
            Dim tar13 = New TAREA
            tar13.TAR_tiempo_estimado = txtTiempo_Estimado13.Text
            tar13.TAR_tiempo_real = txtTiempo_Real13.Text
            tar13.COL_id_colaborador = txt_id_colaborador.Text
            tar13.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar13.TAR_hora_fin = txtHora_Finalizacion13.Text
            '  tar13.TAR_carga_horaria = txt_Carga_Horaria13.Text
            tar13.TAR_detalle_tarea = txt_detalle_tarea13.Text
            tar13.TAR_observaciones = txtObservaciones13.Text
            tar13.TAR_fecha = dtpFecha.Text

            'REGISTRO 14 DE TAREA
            Dim tar14 = New TAREA
            tar14.TAR_tiempo_estimado = txtTiempo_Estimado14.Text
            tar14.TAR_tiempo_real = txtTiempo_Real14.Text
            tar14.COL_id_colaborador = txt_id_colaborador.Text
            tar14.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar14.TAR_hora_fin = txtHora_Finalizacion14.Text
            '  tar14.TAR_carga_horaria = txt_Carga_Horaria14.Text
            tar14.TAR_detalle_tarea = txt_detalle_tarea14.Text
            tar14.TAR_observaciones = txtObservaciones14.Text
            tar14.TAR_fecha = dtpFecha.Text

            'REGISTRO 15 DE TAREA
            Dim tar15 = New TAREA
            tar15.TAR_tiempo_estimado = txtTiempo_Estimado15.Text
            tar15.TAR_tiempo_real = txtTiempo_Real15.Text
            tar15.COL_id_colaborador = txt_id_colaborador.Text
            tar15.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar15.TAR_hora_fin = txtHora_Finalizacion15.Text
            '  tar15.TAR_carga_horaria = txt_Carga_Horaria15.Text
            tar15.TAR_detalle_tarea = txt_detalle_tarea15.Text
            tar15.TAR_observaciones = txtObservaciones15.Text
            tar15.TAR_fecha = dtpFecha.Text

            'REGISTRO 16 DE TAREA
            Dim tar16 = New TAREA
            tar16.TAR_tiempo_estimado = txtTiempo_Estimado16.Text
            tar16.TAR_tiempo_real = txtTiempo_Real16.Text
            tar16.COL_id_colaborador = txt_id_colaborador.Text
            tar16.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar16.TAR_hora_fin = txtHora_Finalizacion16.Text
            '  tar16.TAR_carga_horaria = txt_Carga_Horaria16.Text
            tar16.TAR_detalle_tarea = txt_detalle_tarea16.Text
            tar16.TAR_observaciones = txtObservaciones16.Text
            tar16.TAR_fecha = dtpFecha.Text

            'REGISTRO 17 DE TAREA
            Dim tar17 = New TAREA
            tar17.TAR_tiempo_estimado = txtTiempo_Estimado17.Text
            tar17.TAR_tiempo_real = txtTiempo_Real17.Text
            tar17.COL_id_colaborador = txt_id_colaborador.Text
            tar17.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar17.TAR_hora_fin = txtHora_Finalizacion17.Text
            '  tar17.TAR_carga_horaria = txt_Carga_Horaria17.Text
            tar17.TAR_detalle_tarea = txt_detalle_tarea17.Text
            tar17.TAR_observaciones = txtObservaciones17.Text
            tar17.TAR_fecha = dtpFecha.Text

            'REGISTRO 18 DE TAREA
            Dim tar18 = New TAREA
            tar18.TAR_tiempo_estimado = txtTiempo_Estimado18.Text
            tar18.TAR_tiempo_real = txtTiempo_Real18.Text
            tar18.COL_id_colaborador = txt_id_colaborador.Text
            tar18.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar18.TAR_hora_fin = txtHora_Finalizacion18.Text
            ' tar18.TAR_carga_horaria = txt_Carga_Horaria18.Text
            tar18.TAR_detalle_tarea = txt_detalle_tarea18.Text
            tar18.TAR_observaciones = txtObservaciones18.Text
            tar18.TAR_fecha = dtpFecha.Text

            'REGISTRO 19 DE TAREA
            Dim tar19 = New TAREA
            tar19.TAR_tiempo_estimado = txtTiempo_Estimado19.Text
            tar19.TAR_tiempo_real = txtTiempo_Real19.Text
            tar19.COL_id_colaborador = txt_id_colaborador.Text
            tar19.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar19.TAR_hora_fin = txtHora_Finalizacion19.Text
            ' tar19.TAR_carga_horaria = txt_Carga_Horaria19.Text
            tar19.TAR_detalle_tarea = txt_detalle_tarea19.Text
            tar19.TAR_observaciones = txtObservaciones19.Text
            tar19.TAR_fecha = dtpFecha.Text

            'REGISTRO 20 DE TAREA
            Dim tar20 = New TAREA
            tar20.TAR_tiempo_estimado = txtTiempo_Estimado20.Text
            tar20.TAR_tiempo_real = txtTiempo_Real20.Text
            tar20.COL_id_colaborador = txt_id_colaborador.Text
            tar20.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            tar20.TAR_hora_fin = txtHora_Finalizacion20.Text
            '  tar20.TAR_carga_horaria = txt_Carga_Horaria20.Text
            tar20.TAR_detalle_tarea = txt_detalle_tarea20.Text
            tar20.TAR_observaciones = txtObservaciones20.Text
            tar20.TAR_fecha = dtpFecha.Text

            datacontext.TAREA.InsertOnSubmit(tar1)
            datacontext.TAREA.InsertOnSubmit(tar2)
            datacontext.TAREA.InsertOnSubmit(tar3)
            datacontext.TAREA.InsertOnSubmit(tar4)
            datacontext.TAREA.InsertOnSubmit(tar5)
            datacontext.TAREA.InsertOnSubmit(tar6)
            datacontext.TAREA.InsertOnSubmit(tar7)
            datacontext.TAREA.InsertOnSubmit(tar8)
            datacontext.TAREA.InsertOnSubmit(tar9)
            datacontext.TAREA.InsertOnSubmit(tar10)
            datacontext.TAREA.InsertOnSubmit(tar11)
            datacontext.TAREA.InsertOnSubmit(tar12)
            datacontext.TAREA.InsertOnSubmit(tar13)
            datacontext.TAREA.InsertOnSubmit(tar14)
            datacontext.TAREA.InsertOnSubmit(tar15)
            datacontext.TAREA.InsertOnSubmit(tar16)
            datacontext.TAREA.InsertOnSubmit(tar17)
            datacontext.TAREA.InsertOnSubmit(tar18)
            datacontext.TAREA.InsertOnSubmit(tar19)
            datacontext.TAREA.InsertOnSubmit(tar20)
            datacontext.SubmitChanges()

            MsgBox("La tarea se ha creado correctamente", vbInformation)
            frm_Listado_Tareas.cargargrilla()
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("La tarea NO fue creada")
            limpiarcontroles()
            frm_Listado_Tareas.cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_tarea.Clear()
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
        txt_id_orden_trabajo.Clear()

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

    End Sub

    Private Sub btnActualizar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txt_detalle_tarea1.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarTarea = (From P In datacontext.TAREA
                                   Where P.TAR_id_tarea = (txt_id_tarea.Text.ToUpper)).ToList()(0)

            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado1.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado2.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado3.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado4.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado5.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado6.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado7.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado8.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado9.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado10.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado11.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado12.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado13.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado14.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado15.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado16.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado17.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado18.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado19.Text
            ActualizarTarea.TAR_tiempo_estimado = txtTiempo_Estimado20.Text

            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real1.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real2.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real3.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real4.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real5.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real6.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real7.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real8.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real9.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real10.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real11.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real12.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real13.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real14.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real15.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real16.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real17.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real18.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real19.Text
            ActualizarTarea.TAR_tiempo_real = txtTiempo_Real20.Text

            ActualizarTarea.COL_id_colaborador = txt_id_colaborador.Text
            ActualizarTarea.ORT_id_orden_trabajo = txt_id_colaborador.Text

            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion1.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion2.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion3.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion4.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion5.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion6.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion7.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion8.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion9.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion10.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion11.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion12.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion13.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion14.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion15.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion16.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion17.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion18.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion19.Text
            ActualizarTarea.TAR_hora_fin = txtHora_Finalizacion20.Text

            ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria1.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria2.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria3.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria4.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria5.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria6.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria7.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria8.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria9.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria10.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria11.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria12.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria13.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria14.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria15.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria16.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria17.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria18.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria19.Text
            'ActualizarTarea.TAR_carga_horaria = txt_Carga_Horaria20.Text

            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea1.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea2.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea3.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea4.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea5.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea6.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea7.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea8.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea9.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea10.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea11.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea12.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea13.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea14.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea15.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea16.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea17.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea18.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea19.Text
            ActualizarTarea.TAR_detalle_tarea = txt_detalle_tarea20.Text

            ActualizarTarea.TAR_observaciones = txtObservaciones1.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones2.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones3.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones4.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones5.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones6.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones7.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones8.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones9.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones10.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones11.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones12.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones13.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones14.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones15.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones16.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones17.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones18.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones19.Text
            ActualizarTarea.TAR_observaciones = txtObservaciones20.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            frm_Listado_Tareas.cargargrilla()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar tarea")
            Me.limpiarcontroles()
            frm_Listado_Tareas.cargargrilla()
        End Try
    End Sub

    'Private Sub dgvLista_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If dgvLista_Tareas.SelectedRows.Count > 0 Then
    '        txt_id_tarea.Text = dgvLista_Tareas.Item("TAR_id_tarea", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txtTiempo_Estimado.Text = dgvLista_Tareas.Item("TAR_tiempo_estimado", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txtTiempo_Real.Text = dgvLista_Tareas.Item("TAR_tiempo_real", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txt_id_colaborador.Text = dgvLista_Tareas.Item("COL_id_colaborador", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txt_nombre_colaborador.Text = dgvLista_Tareas.Item("COL_nombre_col", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txt_id_orden_trabajo.Text = dgvLista_Tareas.Item("ORT_id_orden_trabajo", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txtNumero_Orden_Trabajo.Text = dgvLista_Tareas.Item("ORT_numero_ot", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txtHora_Finalizacion.Text = dgvLista_Tareas.Item("TAR_hora_fin", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txt_Carga_Horaria.Text = dgvLista_Tareas.Item("TAR_carga_horaria", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txt_detalle_tarea.Text = dgvLista_Tareas.Item("TAR_detalle_tarea", dgvLista_Tareas.SelectedRows(0).Index).Value
    '        txtObservaciones.Text = dgvLista_Tareas.Item("TAR_observaciones", dgvLista_Tareas.SelectedRows(0).Index).Value
    '    Else
    '        MsgBox("Debe seleccionar una tarea")
    '    End If
    'End Sub

    Private Sub btnNuevo_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva_Tarea.Click
        limpiarcontroles()
    End Sub

    Private Sub btnCancelar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Tarea.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_detalle_tarea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnBuscar_Colaborador.Focus()
        End If
    End Sub


    Private Sub btnBuscar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Colaborador.Text = "Seleccionar Colaborador"
        frm_Colaborador.Show()
    End Sub

    Private Sub btnBuscar_Numero_Orden_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Numero_Orden.Click
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
    End Sub

    Private Sub btnBuscar_Colaborador_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Colaborador.Click
        frm_Colaborador.Text = "Seleccionar colaborador"
        frm_Colaborador.Show()
    End Sub
End Class