﻿Public Class frm_Tarea
    Dim datacontext As New DataS_Interno
    Dim quienllamoboton As Button

    Private Sub btnGuardar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Tarea.Click

        If txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            If txt_detalle_tarea1.Text.Length <> 0 Or txtNumero_Orden_Trabajo1.Text.Length <> 0 Then
                'REGISTRO 1 DE TAREA
                ' Dim temphorario = Trim(txtEntrada.Text) + Trim(txtSalida.Text)
                Dim tar1 = New TAREA
                tar1.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado1.Text, VbStrConv.ProperCase)
                tar1.TAR_tiempo_real = StrConv(txtTiempo_Real1.Text, VbStrConv.ProperCase)
                tar1.COL_id_colaborador = txt_id_colaborador.Text
                tar1.ORT_id_orden_trabajo = txt_id_orden_trabajo1.Text
                tar1.TAR_hora_fin = StrConv(txtHora_Finalizacion1.Text, VbStrConv.ProperCase)
                tar1.TAR_carga_horaria = StrConv(txt_Carga_Horaria1.Text, VbStrConv.ProperCase)
                tar1.TAR_detalle_tarea = StrConv(txt_detalle_tarea1.Text, VbStrConv.ProperCase)
                tar1.TAR_observaciones = StrConv(txtObservaciones1.Text, VbStrConv.ProperCase)
                tar1.TAR_fecha = dtpFecha.Text
                tar1.TAR_entrada = txtEntrada.Text
                tar1.TAR_salida = txtSalida.Text

                datacontext.TAREA.InsertOnSubmit(tar1)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea2.Text.Length <> 0 Then
                'REGISTRO 2 DE TAREA
                Dim tar2 = New TAREA
                tar2.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado2.Text, VbStrConv.ProperCase)
                tar2.TAR_tiempo_real = StrConv(txtTiempo_Real2.Text, VbStrConv.ProperCase)
                tar2.COL_id_colaborador = txt_id_colaborador.Text
                tar2.ORT_id_orden_trabajo = txt_id_orden_trabajo2.Text
                tar2.TAR_hora_fin = StrConv(txtHora_Finalizacion2.Text, VbStrConv.ProperCase)
                tar2.TAR_detalle_tarea = StrConv(txt_detalle_tarea2.Text, VbStrConv.ProperCase)
                tar2.TAR_observaciones = StrConv(txtObservaciones2.Text, VbStrConv.ProperCase)
                tar2.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar2)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea3.Text.Length <> 0 Then
                'REGISTRO 3 DE TAREA
                Dim tar3 = New TAREA
                tar3.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado3.Text, VbStrConv.ProperCase)
                tar3.TAR_tiempo_real = StrConv(txtTiempo_Real3.Text, VbStrConv.ProperCase)
                tar3.COL_id_colaborador = txt_id_colaborador.Text
                tar3.ORT_id_orden_trabajo = txt_id_orden_trabajo3.Text
                tar3.TAR_hora_fin = StrConv(txtHora_Finalizacion3.Text, VbStrConv.ProperCase)
                tar3.TAR_detalle_tarea = StrConv(txt_detalle_tarea3.Text, VbStrConv.ProperCase)
                tar3.TAR_observaciones = StrConv(txtObservaciones3.Text, VbStrConv.ProperCase)
                tar3.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar3)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea4.Text.Length <> 0 Then
                'REGISTRO 4 DE TAREA
                Dim tar4 = New TAREA
                tar4.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado4.Text, VbStrConv.ProperCase)
                tar4.TAR_tiempo_real = StrConv(txtTiempo_Real4.Text, VbStrConv.ProperCase)
                tar4.COL_id_colaborador = txt_id_colaborador.Text
                tar4.ORT_id_orden_trabajo = txt_id_orden_trabajo4.Text
                tar4.TAR_hora_fin = StrConv(txtHora_Finalizacion4.Text, VbStrConv.ProperCase)
                tar4.TAR_detalle_tarea = StrConv(txt_detalle_tarea4.Text, VbStrConv.ProperCase)
                tar4.TAR_observaciones = StrConv(txtObservaciones4.Text, VbStrConv.ProperCase)
                tar4.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar4)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea5.Text.Length <> 0 Then
                'REGISTRO 5 DE TAREA
                Dim tar5 = New TAREA
                tar5.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado5.Text, VbStrConv.ProperCase)
                tar5.TAR_tiempo_real = StrConv(txtTiempo_Real5.Text, VbStrConv.ProperCase)
                tar5.COL_id_colaborador = txt_id_colaborador.Text
                tar5.ORT_id_orden_trabajo = txt_id_orden_trabajo5.Text
                tar5.TAR_hora_fin = StrConv(txtHora_Finalizacion5.Text, VbStrConv.ProperCase)
                tar5.TAR_detalle_tarea = StrConv(txt_detalle_tarea5.Text, VbStrConv.ProperCase)
                tar5.TAR_observaciones = StrConv(txtObservaciones5.Text, VbStrConv.ProperCase)
                tar5.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar5)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea6.Text.Length <> 0 Then
                'REGISTRO 6 DE TAREA
                Dim tar6 = New TAREA
                tar6.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado6.Text, VbStrConv.ProperCase)
                tar6.TAR_tiempo_real = StrConv(txtTiempo_Real6.Text, VbStrConv.ProperCase)
                tar6.COL_id_colaborador = txt_id_colaborador.Text
                tar6.ORT_id_orden_trabajo = txt_id_orden_trabajo6.Text
                tar6.TAR_hora_fin = StrConv(txtHora_Finalizacion6.Text, VbStrConv.ProperCase)
                tar6.TAR_detalle_tarea = StrConv(txt_detalle_tarea6.Text, VbStrConv.ProperCase)
                tar6.TAR_observaciones = StrConv(txtObservaciones6.Text, VbStrConv.ProperCase)
                tar6.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar6)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea7.Text.Length <> 0 Then
                'REGISTRO 7 DE TAREA
                Dim tar7 = New TAREA
                tar7.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado7.Text, VbStrConv.ProperCase)
                tar7.TAR_tiempo_real = StrConv(txtTiempo_Real7.Text, VbStrConv.ProperCase)
                tar7.COL_id_colaborador = txt_id_colaborador.Text
                tar7.ORT_id_orden_trabajo = txt_id_orden_trabajo7.Text
                tar7.TAR_hora_fin = StrConv(txtHora_Finalizacion7.Text, VbStrConv.ProperCase)
                tar7.TAR_detalle_tarea = StrConv(txt_detalle_tarea7.Text, VbStrConv.ProperCase)
                tar7.TAR_observaciones = StrConv(txtObservaciones5.Text, VbStrConv.ProperCase)
                tar7.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar7)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea8.Text.Length <> 0 Then
                'REGISTRO 8 DE TAREA
                Dim tar8 = New TAREA
                tar8.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado8.Text, VbStrConv.ProperCase)
                tar8.TAR_tiempo_real = StrConv(txtTiempo_Real8.Text, VbStrConv.ProperCase)
                tar8.COL_id_colaborador = txt_id_colaborador.Text
                tar8.ORT_id_orden_trabajo = txt_id_orden_trabajo8.Text
                tar8.TAR_hora_fin = StrConv(txtHora_Finalizacion8.Text, VbStrConv.ProperCase)
                tar8.TAR_detalle_tarea = StrConv(txt_detalle_tarea8.Text, VbStrConv.ProperCase)
                tar8.TAR_observaciones = StrConv(txtObservaciones8.Text, VbStrConv.ProperCase)
                tar8.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar8)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea9.Text.Length <> 0 Then
                'REGISTRO 9 DE TAREA
                Dim tar9 = New TAREA
                tar9.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado9.Text, VbStrConv.ProperCase)
                tar9.TAR_tiempo_real = StrConv(txtTiempo_Real9.Text, VbStrConv.ProperCase)
                tar9.COL_id_colaborador = txt_id_colaborador.Text
                tar9.ORT_id_orden_trabajo = txt_id_orden_trabajo9.Text
                tar9.TAR_hora_fin = StrConv(txtHora_Finalizacion9.Text, VbStrConv.ProperCase)
                tar9.TAR_detalle_tarea = StrConv(txt_detalle_tarea9.Text, VbStrConv.ProperCase)
                tar9.TAR_observaciones = StrConv(txtObservaciones9.Text, VbStrConv.ProperCase)
                tar9.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar9)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea10.Text.Length <> 0 Then
                'REGISTRO 10 DE TAREA
                Dim tar10 = New TAREA
                tar10.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado10.Text, VbStrConv.ProperCase)
                tar10.TAR_tiempo_real = StrConv(txtTiempo_Real10.Text, VbStrConv.ProperCase)
                tar10.COL_id_colaborador = txt_id_colaborador.Text
                tar10.ORT_id_orden_trabajo = txt_id_orden_trabajo10.Text
                tar10.TAR_hora_fin = StrConv(txtHora_Finalizacion10.Text, VbStrConv.ProperCase)
                tar10.TAR_detalle_tarea = StrConv(txt_detalle_tarea10.Text, VbStrConv.ProperCase)
                tar10.TAR_observaciones = StrConv(txtObservaciones10.Text, VbStrConv.ProperCase)
                tar10.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar10)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea11.Text.Length <> 0 Then
                'REGISTRO 11 DE TAREA
                Dim tar11 = New TAREA
                tar11.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado11.Text, VbStrConv.ProperCase)
                tar11.TAR_tiempo_real = StrConv(txtTiempo_Real11.Text, VbStrConv.ProperCase)
                tar11.COL_id_colaborador = txt_id_colaborador.Text
                tar11.ORT_id_orden_trabajo = txt_id_orden_trabajo11.Text
                tar11.TAR_hora_fin = StrConv(txtHora_Finalizacion11.Text, VbStrConv.ProperCase)
                tar11.TAR_detalle_tarea = StrConv(txt_detalle_tarea11.Text, VbStrConv.ProperCase)
                tar11.TAR_observaciones = StrConv(txtObservaciones11.Text, VbStrConv.ProperCase)
                tar11.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar11)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea12.Text.Length <> 0 Then
                'REGISTRO 12 DE TAREA
                Dim tar12 = New TAREA
                tar12.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado12.Text, VbStrConv.ProperCase)
                tar12.TAR_tiempo_real = StrConv(txtTiempo_Real2.Text, VbStrConv.ProperCase)
                tar12.COL_id_colaborador = txt_id_colaborador.Text
                tar12.ORT_id_orden_trabajo = txt_id_orden_trabajo12.Text
                tar12.TAR_hora_fin = StrConv(txtHora_Finalizacion12.Text, VbStrConv.ProperCase)
                tar12.TAR_detalle_tarea = StrConv(txt_detalle_tarea12.Text, VbStrConv.ProperCase)
                tar12.TAR_observaciones = StrConv(txtObservaciones12.Text, VbStrConv.ProperCase)
                tar12.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar12)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea13.Text.Length <> 0 Then
                'REGISTRO 13 DE TAREA
                Dim tar13 = New TAREA
                tar13.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado13.Text, VbStrConv.ProperCase)
                tar13.TAR_tiempo_real = StrConv(txtTiempo_Real13.Text, VbStrConv.ProperCase)
                tar13.COL_id_colaborador = txt_id_colaborador.Text
                tar13.ORT_id_orden_trabajo = txt_id_orden_trabajo13.Text
                tar13.TAR_hora_fin = StrConv(txtHora_Finalizacion13.Text, VbStrConv.ProperCase)
                tar13.TAR_detalle_tarea = StrConv(txt_detalle_tarea13.Text, VbStrConv.ProperCase)
                tar13.TAR_observaciones = StrConv(txtObservaciones13.Text, VbStrConv.ProperCase)
                tar13.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar13)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea14.Text.Length <> 0 Then
                'REGISTRO 14 DE TAREA
                Dim tar14 = New TAREA
                tar14.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado14.Text, VbStrConv.ProperCase)
                tar14.TAR_tiempo_real = StrConv(txtTiempo_Real14.Text, VbStrConv.ProperCase)
                tar14.COL_id_colaborador = txt_id_colaborador.Text
                tar14.ORT_id_orden_trabajo = txt_id_orden_trabajo14.Text
                tar14.TAR_hora_fin = StrConv(txtHora_Finalizacion14.Text, VbStrConv.ProperCase)
                tar14.TAR_detalle_tarea = StrConv(txt_detalle_tarea14.Text, VbStrConv.ProperCase)
                tar14.TAR_observaciones = StrConv(txtObservaciones14.Text, VbStrConv.ProperCase)
                tar14.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar14)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea15.Text.Length <> 0 Then
                'REGISTRO 15 DE TAREA
                Dim tar15 = New TAREA
                tar15.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado15.Text, VbStrConv.ProperCase)
                tar15.TAR_tiempo_real = StrConv(txtTiempo_Real15.Text, VbStrConv.ProperCase)
                tar15.COL_id_colaborador = txt_id_colaborador.Text
                tar15.ORT_id_orden_trabajo = txt_id_orden_trabajo15.Text
                tar15.TAR_hora_fin = StrConv(txtHora_Finalizacion15.Text, VbStrConv.ProperCase)
                tar15.TAR_detalle_tarea = StrConv(txt_detalle_tarea15.Text, VbStrConv.ProperCase)
                tar15.TAR_observaciones = StrConv(txtObservaciones15.Text, VbStrConv.ProperCase)
                tar15.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar15)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea16.Text.Length <> 0 Then
                'REGISTRO 16 DE TAREA
                Dim tar16 = New TAREA
                tar16.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado16.Text, VbStrConv.ProperCase)
                tar16.TAR_tiempo_real = StrConv(txtTiempo_Real16.Text, VbStrConv.ProperCase)
                tar16.COL_id_colaborador = txt_id_colaborador.Text
                tar16.ORT_id_orden_trabajo = txt_id_orden_trabajo16.Text
                tar16.TAR_hora_fin = StrConv(txtHora_Finalizacion16.Text, VbStrConv.ProperCase)
                tar16.TAR_detalle_tarea = StrConv(txt_detalle_tarea16.Text, VbStrConv.ProperCase)
                tar16.TAR_observaciones = StrConv(txtObservaciones16.Text, VbStrConv.ProperCase)
                tar16.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar16)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea17.Text.Length <> 0 Then
                'REGISTRO 17 DE TAREA
                Dim tar17 = New TAREA
                tar17.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado17.Text, VbStrConv.ProperCase)
                tar17.TAR_tiempo_real = StrConv(txtTiempo_Real17.Text, VbStrConv.ProperCase)
                tar17.COL_id_colaborador = txt_id_colaborador.Text
                tar17.ORT_id_orden_trabajo = txt_id_orden_trabajo17.Text
                tar17.TAR_hora_fin = StrConv(txtHora_Finalizacion17.Text, VbStrConv.ProperCase)
                tar17.TAR_detalle_tarea = StrConv(txt_detalle_tarea17.Text, VbStrConv.ProperCase)
                tar17.TAR_observaciones = StrConv(txtObservaciones17.Text, VbStrConv.ProperCase)
                tar17.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar17)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea18.Text.Length <> 0 Then
                'REGISTRO 18 DE TAREA
                Dim tar18 = New TAREA
                tar18.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado18.Text, VbStrConv.ProperCase)
                tar18.TAR_tiempo_real = StrConv(txtTiempo_Real18.Text, VbStrConv.ProperCase)
                tar18.COL_id_colaborador = txt_id_colaborador.Text
                tar18.ORT_id_orden_trabajo = txt_id_orden_trabajo18.Text
                tar18.TAR_hora_fin = StrConv(txtHora_Finalizacion18.Text, VbStrConv.ProperCase)
                tar18.TAR_detalle_tarea = StrConv(txt_detalle_tarea18.Text, VbStrConv.ProperCase)
                tar18.TAR_observaciones = StrConv(txtObservaciones18.Text, VbStrConv.ProperCase)
                tar18.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar18)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea19.Text.Length <> 0 Then
                'REGISTRO 19 DE TAREA
                Dim tar19 = New TAREA
                tar19.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado19.Text, VbStrConv.ProperCase)
                tar19.TAR_tiempo_real = StrConv(txtTiempo_Real19.Text, VbStrConv.ProperCase)
                tar19.COL_id_colaborador = txt_id_colaborador.Text
                tar19.ORT_id_orden_trabajo = txt_id_orden_trabajo19.Text
                tar19.TAR_hora_fin = StrConv(txtHora_Finalizacion19.Text, VbStrConv.ProperCase)
                tar19.TAR_detalle_tarea = StrConv(txt_detalle_tarea19.Text, VbStrConv.ProperCase)
                tar19.TAR_observaciones = StrConv(txtObservaciones19.Text, VbStrConv.ProperCase)
                tar19.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar19)
                datacontext.SubmitChanges()
            Else
            End If

            If txt_detalle_tarea20.Text.Length <> 0 Then
                'REGISTRO 20 DE TAREA
                Dim tar20 = New TAREA
                tar20.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado20.Text, VbStrConv.ProperCase)
                tar20.TAR_tiempo_real = StrConv(txtTiempo_Real20.Text, VbStrConv.ProperCase)
                tar20.COL_id_colaborador = txt_id_colaborador.Text
                tar20.ORT_id_orden_trabajo = txt_id_orden_trabajo20.Text
                tar20.TAR_hora_fin = StrConv(txtHora_Finalizacion20.Text, VbStrConv.ProperCase)
                tar20.TAR_detalle_tarea = StrConv(txt_detalle_tarea20.Text, VbStrConv.ProperCase)
                tar20.TAR_observaciones = StrConv(txtObservaciones20.Text, VbStrConv.ProperCase)
                tar20.TAR_fecha = dtpFecha.Text

                datacontext.TAREA.InsertOnSubmit(tar20)
                datacontext.SubmitChanges()
            Else
            End If

            Select Case MsgBox("La tarea se ha creado correctamente, desea imprimir??", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Imprimir Tareas")
                Case MsgBoxResult.Yes
                    PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
                    PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
                    '  PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

                    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 30
                    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 30
                    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 30
                    PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 30


                    PrintForm1.Print() 'imprimir
            End Select
            Me.Close()
        Catch ex As Exception
            MsgBox("La tarea NO fue creada")
            limpiarcontroles()
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

    End Sub

    Private Sub btnActualizar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txt_detalle_tarea1.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarTarea = (From P In datacontext.TAREA
                                   Where P.TAR_id_tarea = (txt_id_tarea.Text.ToUpper)).ToList()(0)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado1.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado2.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado3.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado4.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado5.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado6.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado7.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado8.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado9.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado10.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado11.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado12.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado13.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado14.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado15.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado16.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado17.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado18.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado19.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado20.Text, VbStrConv.ProperCase)

            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real1.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real2.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real3.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real4.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real5.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real6.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real7.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real8.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real9.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real10.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real11.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real12.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real13.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real14.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real15.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real16.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real17.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real18.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real19.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_tiempo_real = StrConv(txtTiempo_Real20.Text, VbStrConv.ProperCase)

            ActualizarTarea.COL_id_colaborador = txt_id_colaborador.Text
            ActualizarTarea.ORT_id_orden_trabajo = txt_id_colaborador.Text

            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion1.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion2.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion3.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion4.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion5.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion6.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion7.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion8.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion9.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion10.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion11.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion12.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion13.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion14.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion15.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion16.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion17.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion18.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion19.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_hora_fin = StrConv(txtHora_Finalizacion20.Text, VbStrConv.ProperCase)

            ActualizarTarea.TAR_carga_horaria = StrConv(txt_Carga_Horaria1.Text, VbStrConv.ProperCase)

            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea1.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea2.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea3.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea4.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea5.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea6.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea7.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea8.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea9.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea10.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea11.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea12.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea13.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea14.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea15.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea16.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea17.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea18.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea19.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_detalle_tarea = StrConv(txt_detalle_tarea20.Text, VbStrConv.ProperCase)

            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones1.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones2.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones3.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones4.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones5.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones6.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones7.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones8.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones9.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones10.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones11.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones12.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones13.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones14.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones15.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones16.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones17.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones18.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones19.Text, VbStrConv.ProperCase)
            ActualizarTarea.TAR_observaciones = StrConv(txtObservaciones20.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            ' frm_Listado_Tareas.cargargrilla()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar tarea")
            Me.limpiarcontroles()
            ' frm_Listado_Tareas.cargargrilla()
        End Try
    End Sub

    Private Sub btnNuevo_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva_Tarea.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
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

    Private Sub btnBuscar_Colaborador_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Colaborador.Click, Button3.Click
        frm_Colaborador.quienllamo_col = Me
        frm_Colaborador.Text = "Seleccionar colaborador"
        frm_Colaborador.Show()
        frm_Colaborador.GroupNuevoColaborador.Enabled = False
        frm_Colaborador.btnEliminar_Colaborador.Enabled = False
    End Sub

    Private Sub txtHora_Finalizacion1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion1.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion1.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion1.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion1.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion1.Text, Len(txtHora_Finalizacion1.Text) - 2)
                Else
                    txtHora_Finalizacion1.Text = txtHora_Finalizacion1.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion1.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion1.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion1.Text, Len(txtHora_Finalizacion1.Text) - 2)
                Else
                    txtHora_Finalizacion1.Text = txtHora_Finalizacion1.Text & ":"
                    Me.txtHora_Finalizacion1.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion2.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion2.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion2.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion2.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion2.Text, Len(txtHora_Finalizacion2.Text) - 2)
                Else
                    txtHora_Finalizacion2.Text = txtHora_Finalizacion2.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion2.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion2.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion2.Text, Len(txtHora_Finalizacion2.Text) - 2)
                Else
                    txtHora_Finalizacion2.Text = txtHora_Finalizacion2.Text & ":"
                    Me.txtHora_Finalizacion2.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion3.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion3.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion3.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion3.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion3.Text, Len(txtHora_Finalizacion3.Text) - 2)
                Else
                    txtHora_Finalizacion3.Text = txtHora_Finalizacion3.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion3.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion3.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion3.Text, Len(txtHora_Finalizacion3.Text) - 2)
                Else
                    txtHora_Finalizacion3.Text = txtHora_Finalizacion3.Text & ":"
                    Me.txtHora_Finalizacion3.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion4.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion4.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion4.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion4.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion4.Text, Len(txtHora_Finalizacion4.Text) - 2)
                Else
                    txtHora_Finalizacion4.Text = txtHora_Finalizacion4.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion4.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion4.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion4.Text, Len(txtHora_Finalizacion4.Text) - 2)
                Else
                    txtHora_Finalizacion4.Text = txtHora_Finalizacion4.Text & ":"
                    Me.txtHora_Finalizacion4.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion5.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion5.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion5.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion5.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion5.Text, Len(txtHora_Finalizacion5.Text) - 2)
                Else
                    txtHora_Finalizacion5.Text = txtHora_Finalizacion5.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion5.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion5.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion5.Text, Len(txtHora_Finalizacion5.Text) - 2)
                Else
                    txtHora_Finalizacion5.Text = txtHora_Finalizacion5.Text & ":"
                    Me.txtHora_Finalizacion5.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion6.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion6.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion6.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion6.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion6.Text, Len(txtHora_Finalizacion6.Text) - 2)
                Else
                    txtHora_Finalizacion6.Text = txtHora_Finalizacion6.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion6.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion6.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion6.Text, Len(txtHora_Finalizacion6.Text) - 2)
                Else
                    txtHora_Finalizacion6.Text = txtHora_Finalizacion6.Text & ":"
                    Me.txtHora_Finalizacion6.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion7.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion7.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion7.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion7.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion7.Text, Len(txtHora_Finalizacion7.Text) - 2)
                Else
                    txtHora_Finalizacion7.Text = txtHora_Finalizacion7.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion7.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion7.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion7.Text, Len(txtHora_Finalizacion7.Text) - 2)
                Else
                    txtHora_Finalizacion7.Text = txtHora_Finalizacion7.Text & ":"
                    Me.txtHora_Finalizacion7.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion8.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion8.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion8.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion8.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion8.Text, Len(txtHora_Finalizacion8.Text) - 2)
                Else
                    txtHora_Finalizacion8.Text = txtHora_Finalizacion8.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion8.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion8.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion8.Text, Len(txtHora_Finalizacion8.Text) - 2)
                Else
                    txtHora_Finalizacion8.Text = txtHora_Finalizacion8.Text & ":"
                    Me.txtHora_Finalizacion8.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion9.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion9.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion9.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion9.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion9.Text, Len(txtHora_Finalizacion9.Text) - 2)
                Else
                    txtHora_Finalizacion9.Text = txtHora_Finalizacion9.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion9.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion9.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion9.Text, Len(txtHora_Finalizacion9.Text) - 2)
                Else
                    txtHora_Finalizacion9.Text = txtHora_Finalizacion9.Text & ":"
                    Me.txtHora_Finalizacion9.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion10.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion10.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion10.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion10.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion10.Text, Len(txtHora_Finalizacion10.Text) - 2)
                Else
                    txtHora_Finalizacion10.Text = txtHora_Finalizacion10.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion10.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion10.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion10.Text, Len(txtHora_Finalizacion10.Text) - 2)
                Else
                    txtHora_Finalizacion10.Text = txtHora_Finalizacion10.Text & ":"
                    Me.txtHora_Finalizacion10.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion11.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion11.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion11.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion11.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion11.Text, Len(txtHora_Finalizacion11.Text) - 2)
                Else
                    txtHora_Finalizacion11.Text = txtHora_Finalizacion11.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion11.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion11.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion11.Text, Len(txtHora_Finalizacion11.Text) - 2)
                Else
                    txtHora_Finalizacion11.Text = txtHora_Finalizacion11.Text & ":"
                    Me.txtHora_Finalizacion11.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion12.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion12.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion12.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion12.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion12.Text, Len(txtHora_Finalizacion12.Text) - 2)
                Else
                    txtHora_Finalizacion12.Text = txtHora_Finalizacion12.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion12.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion12.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion12.Text, Len(txtHora_Finalizacion12.Text) - 2)
                Else
                    txtHora_Finalizacion12.Text = txtHora_Finalizacion12.Text & ":"
                    Me.txtHora_Finalizacion12.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion13.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion13.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion13.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion13.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion13.Text, Len(txtHora_Finalizacion13.Text) - 2)
                Else
                    txtHora_Finalizacion13.Text = txtHora_Finalizacion13.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion13.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion13.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion13.Text, Len(txtHora_Finalizacion13.Text) - 2)
                Else
                    txtHora_Finalizacion13.Text = txtHora_Finalizacion13.Text & ":"
                    Me.txtHora_Finalizacion13.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion14.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion14.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion14.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion14.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion14.Text, Len(txtHora_Finalizacion14.Text) - 2)
                Else
                    txtHora_Finalizacion14.Text = txtHora_Finalizacion14.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion14.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion14.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion14.Text, Len(txtHora_Finalizacion14.Text) - 2)
                Else
                    txtHora_Finalizacion14.Text = txtHora_Finalizacion14.Text & ":"
                    Me.txtHora_Finalizacion14.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion15.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion15.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion15.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion15.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion15.Text, Len(txtHora_Finalizacion15.Text) - 2)
                Else
                    txtHora_Finalizacion15.Text = txtHora_Finalizacion15.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion15.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion15.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion15.Text, Len(txtHora_Finalizacion15.Text) - 2)
                Else
                    txtHora_Finalizacion15.Text = txtHora_Finalizacion15.Text & ":"
                    Me.txtHora_Finalizacion15.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion16.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion16.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion16.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion16.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion16.Text, Len(txtHora_Finalizacion16.Text) - 2)
                Else
                    txtHora_Finalizacion16.Text = txtHora_Finalizacion16.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion16.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion16.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion16.Text, Len(txtHora_Finalizacion16.Text) - 2)
                Else
                    txtHora_Finalizacion16.Text = txtHora_Finalizacion16.Text & ":"
                    Me.txtHora_Finalizacion16.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion17.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion17.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion17.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion17.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion17.Text, Len(txtHora_Finalizacion17.Text) - 2)
                Else
                    txtHora_Finalizacion17.Text = txtHora_Finalizacion17.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion17.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion17.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion17.Text, Len(txtHora_Finalizacion17.Text) - 2)
                Else
                    txtHora_Finalizacion17.Text = txtHora_Finalizacion17.Text & ":"
                    Me.txtHora_Finalizacion17.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion18.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion18.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion18.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion18.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion18.Text, Len(txtHora_Finalizacion18.Text) - 2)
                Else
                    txtHora_Finalizacion18.Text = txtHora_Finalizacion18.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion18.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion18.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion18.Text, Len(txtHora_Finalizacion18.Text) - 2)
                Else
                    txtHora_Finalizacion18.Text = txtHora_Finalizacion18.Text & ":"
                    Me.txtHora_Finalizacion18.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion19.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion19.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion19.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion19.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion19.Text, Len(txtHora_Finalizacion19.Text) - 2)
                Else
                    txtHora_Finalizacion19.Text = txtHora_Finalizacion19.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion19.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion19.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion19.Text, Len(txtHora_Finalizacion19.Text) - 2)
                Else
                    txtHora_Finalizacion19.Text = txtHora_Finalizacion19.Text & ":"
                    Me.txtHora_Finalizacion19.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub txtHora_Finalizacion20_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora_Finalizacion20.TextChanged
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora_Finalizacion20.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora_Finalizacion20.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora_Finalizacion20.Text = Microsoft.VisualBasic.Right(txtHora_Finalizacion20.Text, Len(txtHora_Finalizacion20.Text) - 2)
                Else
                    txtHora_Finalizacion20.Text = txtHora_Finalizacion20.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora_Finalizacion20.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora_Finalizacion20.Text = Microsoft.VisualBasic.Left(txtHora_Finalizacion20.Text, Len(txtHora_Finalizacion20.Text) - 2)
                Else
                    txtHora_Finalizacion20.Text = txtHora_Finalizacion20.Text & ":"
                    Me.txtHora_Finalizacion20.SelectionStart = 3
                End If
        End Select
    End Sub

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click

        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden1
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden2_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden2.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden2
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden3_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden3.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden3
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden4_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden4.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden4
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden5_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden5.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden5
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden6_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden6.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden6
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden7_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden7.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden7
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden8_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden8.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden8
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden9_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden9.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden9
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden10_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden10.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden10
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden11_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden11.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden11
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden12_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden12.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden12
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden13_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden13.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden13
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden14_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden14.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden14
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden15_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden15.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden15
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden16_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden16.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden16
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden17_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden17.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden17
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden18_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden18.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden18
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden19_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden19.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden19
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub btnBuscar_Numero_Orden20_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden20.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.quienllamoboton = Me.btnBuscar_Numero_Orden20
        frm_Listado_Orden_Trabajo.Text = "Seleccionar orden"
        frm_Listado_Orden_Trabajo.Show()
        frm_Listado_Orden_Trabajo.btnEliminar_Orden.Enabled = False
        frm_Listado_Orden_Trabajo.dgv_detalle_orden.Enabled = False
        frm_Listado_Orden_Trabajo.GroupDetallesOrden.Enabled = False
    End Sub

    Private Sub txtTiempo_Estimado1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado1.KeyPress
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

    Private Sub txtTiempo_Estimado2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado2.KeyPress
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

    Private Sub txtTiempo_Estimado3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado3.KeyPress
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

    Private Sub txtTiempo_Estimado4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado4.KeyPress
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

    Private Sub txtTiempo_Estimado5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado5.KeyPress
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

    Private Sub txtTiempo_Estimado6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado6.KeyPress
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

    Private Sub txtTiempo_Estimado7_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado7.KeyPress
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

    Private Sub txtTiempo_Estimado8_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado8.KeyPress
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

    Private Sub txtTiempo_Estimado9_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado9.KeyPress
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

    Private Sub txtTiempo_Estimado10_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado10.KeyPress
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

    Private Sub txtTiempo_Estimado11_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado11.KeyPress
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

    Private Sub txtTiempo_Estimado12_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado12.KeyPress
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

    Private Sub txtTiempo_Estimado13_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado13.KeyPress
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

    Private Sub txtTiempo_Estimado14_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado14.KeyPress
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

    Private Sub txtTiempo_Estimado15_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado15.KeyPress
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

    Private Sub txtTiempo_Estimado16_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado16.KeyPress
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

    Private Sub txtTiempo_Estimado17_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado17.KeyPress
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

    Private Sub txtTiempo_Estimado18_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado18.KeyPress
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

    Private Sub txtTiempo_Estimado19_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado19.KeyPress
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

    Private Sub txtTiempo_Estimado20_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Estimado20.KeyPress
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

    Private Sub txtTiempo_Real1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real1.KeyPress
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

    Private Sub txtTiempo_Real2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real2.KeyPress
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

    Private Sub txtTiempo_Real3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real3.KeyPress
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

    Private Sub txtTiempo_Real4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real4.KeyPress
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

    Private Sub txtTiempo_Real5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real5.KeyPress
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

    Private Sub txtTiempo_Real6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real6.KeyPress
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

    Private Sub txtTiempo_Real7_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real7.KeyPress
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

    Private Sub txtTiempo_Real8_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real8.KeyPress
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

    Private Sub txtTiempo_Real9_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real9.KeyPress
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

    Private Sub txtTiempo_Real10_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real10.KeyPress
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

    Private Sub txtTiempo_Real11_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real11.KeyPress
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

    Private Sub txtTiempo_Real12_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real12.KeyPress
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

    Private Sub txtTiempo_Real13_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real13.KeyPress
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

    Private Sub txtTiempo_Real14_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real14.KeyPress
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

    Private Sub txtTiempo_Real15_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real15.KeyPress
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

    Private Sub txtTiempo_Real16_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real16.KeyPress
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

    Private Sub txtTiempo_Real17_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real17.KeyPress
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

    Private Sub txtTiempo_Real18_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real18.KeyPress
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

    Private Sub txtTiempo_Real19_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real19.KeyPress
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

    Private Sub txtTiempo_Real20_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo_Real20.KeyPress
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

    Private Sub Calcular()

        Dim val1 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado1.Text, val1)

        Dim val2 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado2.Text, val2)

        Dim val3 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado3.Text, val3)

        Dim val4 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado4.Text, val4)

        Dim val5 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado5.Text, val5)

        Dim val6 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado6.Text, val6)

        Dim val7 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado7.Text, val7)

        Dim val8 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado8.Text, val8)

        Dim val9 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado9.Text, val9)

        Dim val10 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado10.Text, val10)

        Dim val11 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado11.Text, val11)

        Dim val12 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado12.Text, val12)

        Dim val13 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado13.Text, val13)

        Dim val14 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado14.Text, val14)

        Dim val15 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado15.Text, val15)

        Dim val16 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado16.Text, val16)

        Dim val17 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado17.Text, val17)

        Dim val18 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado18.Text, val18)

        Dim val19 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado19.Text, val19)

        Dim val20 As Integer = 0
        Int32.TryParse(txtTiempo_Estimado20.Text, val20)

        Label35.Text = Convert.ToString(val1 + val2 + val3 + val4 + val5 + val6 + val7 + val8 + val9 + val10 + val11 + val12 + val13 + val14 + val15 + val16 + val17 + val18 + val19 + val20)


    End Sub

    Private Sub txtTiempo_Estimado1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado1.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado2.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado3.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado4.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado5.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado6.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado7.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado8.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado9.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado10.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado11.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado12.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado13.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado14.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado15.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado16.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado17.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado18.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado19.TextChanged
        Calcular()
    End Sub

    Private Sub txtTiempo_Estimado20_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTiempo_Estimado20.TextChanged
        Calcular()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirFormulario.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        '  PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = "A4"

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 30

        btnImprimirFormulario.Visible = False
        btnNueva_Tarea.Visible = False
        btnCancelar_Tarea.Visible = False
        btnGuardar_Tarea.Visible = False
        Label34.Visible = False

        PrintForm1.Print() 'imprimir
    End Sub

    Private Sub frm_Tarea_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click

        If txt_detalle_tarea1.Text.Length = 0 Or txt_id_colaborador.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarTarea1 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea1.Text.ToUpper)).ToList()(0)

            ActualizarTarea1.COL_id_colaborador = txt_id_colaborador.Text
            ActualizarTarea1.TAR_carga_horaria = StrConv(txt_Carga_Horaria1.Text, VbStrConv.ProperCase)
            ActualizarTarea1.TAR_entrada = StrConv(txtEntrada.Text, VbStrConv.ProperCase)
            ActualizarTarea1.TAR_salida = StrConv(txtSalida.Text, VbStrConv.ProperCase)

            If txt_detalle_tarea1.Text.Length <> 0 Or txtNumero_Orden_Trabajo1.Text.Length <> 0 Then
                ActualizarTarea1.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado1.Text, VbStrConv.ProperCase)
                ActualizarTarea1.TAR_tiempo_real = StrConv(txtTiempo_Real1.Text, VbStrConv.ProperCase)
                ActualizarTarea1.ORT_id_orden_trabajo = txt_id_orden_trabajo1.Text
                ActualizarTarea1.TAR_hora_fin = StrConv(txtHora_Finalizacion1.Text, VbStrConv.ProperCase)
                ActualizarTarea1.TAR_detalle_tarea = StrConv(txt_detalle_tarea1.Text, VbStrConv.ProperCase)
                ActualizarTarea1.TAR_observaciones = StrConv(txtObservaciones1.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            Dim ActualizarTarea2 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea2.Text.ToUpper)).ToList()(0)
            If txt_detalle_tarea2.Text.Length <> 0 Or txtNumero_Orden_Trabajo2.Text.Length <> 0 Then
                ActualizarTarea2.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado2.Text, VbStrConv.ProperCase)
                ActualizarTarea2.TAR_tiempo_real = StrConv(txtTiempo_Real2.Text, VbStrConv.ProperCase)
                ActualizarTarea2.ORT_id_orden_trabajo = txt_id_orden_trabajo2.Text
                ActualizarTarea2.TAR_hora_fin = StrConv(txtHora_Finalizacion2.Text, VbStrConv.ProperCase)
                ActualizarTarea2.TAR_detalle_tarea = StrConv(txt_detalle_tarea2.Text, VbStrConv.ProperCase)
                ActualizarTarea2.TAR_observaciones = StrConv(txtObservaciones2.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea3.Text.Length <> 0 Or txtNumero_Orden_Trabajo3.Text.Length <> 0 Then
                Dim ActualizarTarea3 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea3.Text.ToUpper)).ToList()(0)
                ActualizarTarea3.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado3.Text, VbStrConv.ProperCase)
                ActualizarTarea3.TAR_tiempo_real = StrConv(txtTiempo_Real3.Text, VbStrConv.ProperCase)
                ActualizarTarea3.ORT_id_orden_trabajo = txt_id_orden_trabajo3.Text
                ActualizarTarea3.TAR_hora_fin = StrConv(txtHora_Finalizacion3.Text, VbStrConv.ProperCase)
                ActualizarTarea3.TAR_detalle_tarea = StrConv(txt_detalle_tarea3.Text, VbStrConv.ProperCase)
                ActualizarTarea3.TAR_observaciones = StrConv(txtObservaciones3.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If


            If txt_detalle_tarea4.Text.Length <> 0 Or txtNumero_Orden_Trabajo4.Text.Length <> 0 Then
                Dim ActualizarTarea4 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea4.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado4.Text, VbStrConv.ProperCase)
                ActualizarTarea4.TAR_tiempo_real = StrConv(txtTiempo_Real4.Text, VbStrConv.ProperCase)
                ActualizarTarea4.ORT_id_orden_trabajo = txt_id_orden_trabajo4.Text
                ActualizarTarea4.TAR_hora_fin = StrConv(txtHora_Finalizacion4.Text, VbStrConv.ProperCase)
                ActualizarTarea4.TAR_detalle_tarea = StrConv(txt_detalle_tarea4.Text, VbStrConv.ProperCase)
                ActualizarTarea4.TAR_observaciones = StrConv(txtObservaciones4.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea5.Text.Length <> 0 Or txtNumero_Orden_Trabajo5.Text.Length <> 0 Then
                Dim ActualizarTarea5 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea5.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado5.Text, VbStrConv.ProperCase)
                ActualizarTarea5.TAR_tiempo_real = StrConv(txtTiempo_Real5.Text, VbStrConv.ProperCase)
                ActualizarTarea5.ORT_id_orden_trabajo = txt_id_orden_trabajo5.Text
                ActualizarTarea5.TAR_hora_fin = StrConv(txtHora_Finalizacion5.Text, VbStrConv.ProperCase)
                ActualizarTarea5.TAR_detalle_tarea = StrConv(txt_detalle_tarea5.Text, VbStrConv.ProperCase)
                ActualizarTarea5.TAR_observaciones = StrConv(txtObservaciones5.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea6.Text.Length <> 0 Or txtNumero_Orden_Trabajo6.Text.Length <> 0 Then
                Dim ActualizarTarea6 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea6.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado6.Text, VbStrConv.ProperCase)
                ActualizarTarea6.TAR_tiempo_real = StrConv(txtTiempo_Real6.Text, VbStrConv.ProperCase)
                ActualizarTarea6.ORT_id_orden_trabajo = txt_id_orden_trabajo6.Text
                ActualizarTarea6.TAR_hora_fin = StrConv(txtHora_Finalizacion6.Text, VbStrConv.ProperCase)
                ActualizarTarea6.TAR_detalle_tarea = StrConv(txt_detalle_tarea6.Text, VbStrConv.ProperCase)
                ActualizarTarea6.TAR_observaciones = StrConv(txtObservaciones6.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea7.Text.Length <> 0 Or txtNumero_Orden_Trabajo7.Text.Length <> 0 Then
                Dim ActualizarTarea7 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea7.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado7.Text, VbStrConv.ProperCase)
                ActualizarTarea7.TAR_tiempo_real = StrConv(txtTiempo_Real7.Text, VbStrConv.ProperCase)
                ActualizarTarea7.ORT_id_orden_trabajo = txt_id_orden_trabajo7.Text
                ActualizarTarea7.TAR_hora_fin = StrConv(txtHora_Finalizacion7.Text, VbStrConv.ProperCase)
                ActualizarTarea7.TAR_detalle_tarea = StrConv(txt_detalle_tarea7.Text, VbStrConv.ProperCase)
                ActualizarTarea7.TAR_observaciones = StrConv(txtObservaciones7.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea8.Text.Length <> 0 Or txtNumero_Orden_Trabajo8.Text.Length <> 0 Then
                Dim ActualizarTarea8 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea8.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado8.Text, VbStrConv.ProperCase)
                ActualizarTarea8.TAR_tiempo_real = StrConv(txtTiempo_Real8.Text, VbStrConv.ProperCase)
                ActualizarTarea8.ORT_id_orden_trabajo = txt_id_orden_trabajo8.Text
                ActualizarTarea8.TAR_hora_fin = StrConv(txtHora_Finalizacion8.Text, VbStrConv.ProperCase)
                ActualizarTarea8.TAR_detalle_tarea = StrConv(txt_detalle_tarea8.Text, VbStrConv.ProperCase)
                ActualizarTarea8.TAR_observaciones = StrConv(txtObservaciones8.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea9.Text.Length <> 0 Or txtNumero_Orden_Trabajo9.Text.Length <> 0 Then
                Dim ActualizarTarea9 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea9.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado9.Text, VbStrConv.ProperCase)
                ActualizarTarea9.TAR_tiempo_real = StrConv(txtTiempo_Real9.Text, VbStrConv.ProperCase)
                ActualizarTarea9.ORT_id_orden_trabajo = txt_id_orden_trabajo9.Text
                ActualizarTarea9.TAR_hora_fin = StrConv(txtHora_Finalizacion9.Text, VbStrConv.ProperCase)
                ActualizarTarea9.TAR_detalle_tarea = StrConv(txt_detalle_tarea9.Text, VbStrConv.ProperCase)
                ActualizarTarea9.TAR_observaciones = StrConv(txtObservaciones9.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea10.Text.Length <> 0 Or txtNumero_Orden_Trabajo10.Text.Length <> 0 Then
                Dim ActualizarTarea10 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea10.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado10.Text, VbStrConv.ProperCase)
                ActualizarTarea10.TAR_tiempo_real = StrConv(txtTiempo_Real10.Text, VbStrConv.ProperCase)
                ActualizarTarea10.ORT_id_orden_trabajo = txt_id_orden_trabajo10.Text
                ActualizarTarea10.TAR_hora_fin = StrConv(txtHora_Finalizacion10.Text, VbStrConv.ProperCase)
                ActualizarTarea10.TAR_detalle_tarea = StrConv(txt_detalle_tarea10.Text, VbStrConv.ProperCase)
                ActualizarTarea10.TAR_observaciones = StrConv(txtObservaciones10.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea11.Text.Length <> 0 Or txtNumero_Orden_Trabajo11.Text.Length <> 0 Then
                Dim ActualizarTarea11 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea11.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado11.Text, VbStrConv.ProperCase)
                ActualizarTarea11.TAR_tiempo_real = StrConv(txtTiempo_Real11.Text, VbStrConv.ProperCase)
                ActualizarTarea11.ORT_id_orden_trabajo = txt_id_orden_trabajo11.Text
                ActualizarTarea11.TAR_hora_fin = StrConv(txtHora_Finalizacion11.Text, VbStrConv.ProperCase)
                ActualizarTarea11.TAR_detalle_tarea = StrConv(txt_detalle_tarea11.Text, VbStrConv.ProperCase)
                ActualizarTarea11.TAR_observaciones = StrConv(txtObservaciones11.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea12.Text.Length <> 0 Or txtNumero_Orden_Trabajo12.Text.Length <> 0 Then
                Dim ActualizarTarea12 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea12.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado12.Text, VbStrConv.ProperCase)
                ActualizarTarea12.TAR_tiempo_real = StrConv(txtTiempo_Real12.Text, VbStrConv.ProperCase)
                ActualizarTarea12.ORT_id_orden_trabajo = txt_id_orden_trabajo12.Text
                ActualizarTarea12.TAR_hora_fin = StrConv(txtHora_Finalizacion12.Text, VbStrConv.ProperCase)
                ActualizarTarea12.TAR_detalle_tarea = StrConv(txt_detalle_tarea12.Text, VbStrConv.ProperCase)
                ActualizarTarea12.TAR_observaciones = StrConv(txtObservaciones12.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea13.Text.Length <> 0 Or txtNumero_Orden_Trabajo13.Text.Length <> 0 Then
                Dim ActualizarTarea13 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea13.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado13.Text, VbStrConv.ProperCase)
                ActualizarTarea13.TAR_tiempo_real = StrConv(txtTiempo_Real13.Text, VbStrConv.ProperCase)
                ActualizarTarea13.ORT_id_orden_trabajo = txt_id_orden_trabajo13.Text
                ActualizarTarea13.TAR_hora_fin = StrConv(txtHora_Finalizacion13.Text, VbStrConv.ProperCase)
                ActualizarTarea13.TAR_detalle_tarea = StrConv(txt_detalle_tarea13.Text, VbStrConv.ProperCase)
                ActualizarTarea13.TAR_observaciones = StrConv(txtObservaciones13.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea14.Text.Length <> 0 Or txtNumero_Orden_Trabajo14.Text.Length <> 0 Then
                Dim ActualizarTarea14 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea14.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado14.Text, VbStrConv.ProperCase)
                ActualizarTarea14.TAR_tiempo_real = StrConv(txtTiempo_Real14.Text, VbStrConv.ProperCase)
                ActualizarTarea14.ORT_id_orden_trabajo = txt_id_orden_trabajo14.Text
                ActualizarTarea14.TAR_hora_fin = StrConv(txtHora_Finalizacion14.Text, VbStrConv.ProperCase)
                ActualizarTarea14.TAR_detalle_tarea = StrConv(txt_detalle_tarea14.Text, VbStrConv.ProperCase)
                ActualizarTarea14.TAR_observaciones = StrConv(txtObservaciones14.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea15.Text.Length <> 0 Or txtNumero_Orden_Trabajo15.Text.Length <> 0 Then
                Dim ActualizarTarea15 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea15.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado15.Text, VbStrConv.ProperCase)
                ActualizarTarea15.TAR_tiempo_real = StrConv(txtTiempo_Real15.Text, VbStrConv.ProperCase)
                ActualizarTarea15.ORT_id_orden_trabajo = txt_id_orden_trabajo15.Text
                ActualizarTarea15.TAR_hora_fin = StrConv(txtHora_Finalizacion15.Text, VbStrConv.ProperCase)
                ActualizarTarea15.TAR_detalle_tarea = StrConv(txt_detalle_tarea15.Text, VbStrConv.ProperCase)
                ActualizarTarea15.TAR_observaciones = StrConv(txtObservaciones15.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea16.Text.Length <> 0 Or txtNumero_Orden_Trabajo16.Text.Length <> 0 Then
                Dim ActualizarTarea16 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea16.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado16.Text, VbStrConv.ProperCase)
                ActualizarTarea16.TAR_tiempo_real = StrConv(txtTiempo_Real16.Text, VbStrConv.ProperCase)
                ActualizarTarea16.ORT_id_orden_trabajo = txt_id_orden_trabajo16.Text
                ActualizarTarea16.TAR_hora_fin = StrConv(txtHora_Finalizacion16.Text, VbStrConv.ProperCase)
                ActualizarTarea16.TAR_detalle_tarea = StrConv(txt_detalle_tarea16.Text, VbStrConv.ProperCase)
                ActualizarTarea16.TAR_observaciones = StrConv(txtObservaciones16.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea17.Text.Length <> 0 Or txtNumero_Orden_Trabajo17.Text.Length <> 0 Then
                Dim ActualizarTarea17 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea17.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado17.Text, VbStrConv.ProperCase)
                ActualizarTarea17.TAR_tiempo_real = StrConv(txtTiempo_Real17.Text, VbStrConv.ProperCase)
                ActualizarTarea17.ORT_id_orden_trabajo = txt_id_orden_trabajo17.Text
                ActualizarTarea17.TAR_hora_fin = StrConv(txtHora_Finalizacion17.Text, VbStrConv.ProperCase)
                ActualizarTarea17.TAR_detalle_tarea = StrConv(txt_detalle_tarea17.Text, VbStrConv.ProperCase)
                ActualizarTarea17.TAR_observaciones = StrConv(txtObservaciones17.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea18.Text.Length <> 0 Or txtNumero_Orden_Trabajo18.Text.Length <> 0 Then
                Dim ActualizarTarea18 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea18.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado18.Text, VbStrConv.ProperCase)
                ActualizarTarea18.TAR_tiempo_real = StrConv(txtTiempo_Real18.Text, VbStrConv.ProperCase)
                ActualizarTarea18.ORT_id_orden_trabajo = txt_id_orden_trabajo18.Text
                ActualizarTarea18.TAR_hora_fin = StrConv(txtHora_Finalizacion18.Text, VbStrConv.ProperCase)
                ActualizarTarea18.TAR_detalle_tarea = StrConv(txt_detalle_tarea18.Text, VbStrConv.ProperCase)
                ActualizarTarea18.TAR_observaciones = StrConv(txtObservaciones18.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea19.Text.Length <> 0 Or txtNumero_Orden_Trabajo19.Text.Length <> 0 Then
                Dim ActualizarTarea19 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea19.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado19.Text, VbStrConv.ProperCase)
                ActualizarTarea19.TAR_tiempo_real = StrConv(txtTiempo_Real19.Text, VbStrConv.ProperCase)
                ActualizarTarea19.ORT_id_orden_trabajo = txt_id_orden_trabajo19.Text
                ActualizarTarea19.TAR_hora_fin = StrConv(txtHora_Finalizacion19.Text, VbStrConv.ProperCase)
                ActualizarTarea19.TAR_detalle_tarea = StrConv(txt_detalle_tarea19.Text, VbStrConv.ProperCase)
                ActualizarTarea19.TAR_observaciones = StrConv(txtObservaciones19.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            If txt_detalle_tarea20.Text.Length <> 0 Or txtNumero_Orden_Trabajo20.Text.Length <> 0 Then
                Dim ActualizarTarea20 = (From P In datacontext.TAREA Where P.TAR_id_tarea = (txt_Id_Tarea4.Text.ToUpper)).ToList()(0)
                ActualizarTarea20.TAR_tiempo_estimado = StrConv(txtTiempo_Estimado20.Text, VbStrConv.ProperCase)
                ActualizarTarea20.TAR_tiempo_real = StrConv(txtTiempo_Real20.Text, VbStrConv.ProperCase)
                ActualizarTarea20.ORT_id_orden_trabajo = txt_id_orden_trabajo20.Text
                ActualizarTarea20.TAR_hora_fin = StrConv(txtHora_Finalizacion20.Text, VbStrConv.ProperCase)
                ActualizarTarea20.TAR_detalle_tarea = StrConv(txt_detalle_tarea20.Text, VbStrConv.ProperCase)
                ActualizarTarea20.TAR_observaciones = StrConv(txtObservaciones20.Text, VbStrConv.ProperCase)
                datacontext.SubmitChanges()
            End If

            MsgBox("Los datos se han modificado correctamente")
            ' frm_Listado_Tareas.cargargrilla()
            Me.Close()
            frm_Listado_Tareas.Close()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar tarea")
            Me.limpiarcontroles()
            ' frm_Listado_Tareas.cargargrilla()
        End Try
    End Sub

    Private Sub txtEntrada_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEntrada.TextChanged
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
    End Sub

    Private Sub txtSalida_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSalida.TextChanged
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
    End Sub

End Class