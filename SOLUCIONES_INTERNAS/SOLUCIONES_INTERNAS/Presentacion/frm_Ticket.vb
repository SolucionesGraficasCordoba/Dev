Public Class frm_Ticket
    Dim datacontext As New DataS_Interno

    Private Sub frm_Ticket_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Solicitud_Click(sender As System.Object, e As System.EventArgs) Handles btn_Solicitud.Click
        Try
            Dim cargaticket = (From tic In datacontext.TICKET
                               Select tic.TIC_id_ticket, tic.TIC_id_usuario, tic.TIC_recurso, tic.TIC_herramienta, tic.TIC_plazo_resolucion, tic.TIC_descripcion, tic.TIC_prioridad, _
                               tic.TIC_estado, tic.TIC_fecha_real_cierre, tic.TIC_fecha_estimado_cierre, tic.TIC_sector, tic.TIC_comentarios
                                Where TIC_recurso = StrConv(txt_recurso.Text, VbStrConv.ProperCase)).Any
            If cargaticket = True Then
                MsgBox("El ticket ingresado ya existe")
                'limpiarcontroles()
                Exit Sub
            End If
            If txt_recurso.Text.Length = 0 Then
                MsgBox("Debe completar el campo recurso")
                txt_recurso.Focus()
                Exit Sub
            End If

            If txt_herramienta.Text.Length = 0 Then
                MsgBox("Debe completar el campo herremienta")
                txt_herramienta.Focus()
                Exit Sub
            End If
            'GUARDA SOLICITANTE
            Dim ticket = New TICKET
            ticket.TIC_id_usuario = StrConv(txt_usuario.Text, VbStrConv.ProperCase)
            ticket.TIC_recurso = txt_recurso.Text
            ticket.TIC_herramienta = StrConv(txt_herramienta.Text, VbStrConv.ProperCase)
            ticket.TIC_plazo_resolucion = StrConv(txt_plazo.Text, VbStrConv.ProperCase)
            ticket.TIC_descripcion = StrConv(txt_descripcion.Text, VbStrConv.ProperCase)

            'GUARDA RECEPTOR
            ticket.TIC_prioridad = StrConv(cbo_prioridad.Text, VbStrConv.ProperCase)
            ticket.TIC_estado = StrConv(cbo_estado.Text, VbStrConv.ProperCase)
            ticket.TIC_fecha_estimado_cierre = StrConv(dtp_fecha_estimada.Text, VbStrConv.ProperCase)
            ticket.TIC_fecha_real_cierre = StrConv(dtp_fecha_real.Text, VbStrConv.ProperCase)
            ticket.TIC_sector = StrConv(txt_sector_dirigido.Text, VbStrConv.ProperCase)
            ticket.TIC_comentarios = StrConv(txt_comentarios.Text, VbStrConv.ProperCase)

            datacontext.TICKET.InsertOnSubmit(ticket)
            datacontext.SubmitChanges()

            MsgBox("El Ticket fue cargado exitosamente")
            Me.Close()
            '  cargargrilla()
            ' limpiarcontroles()

        Catch ex As Exception
            MsgBox("El Ticket no puedo ser cargado")
            ' limpiarcontroles()
            ' cargargrilla()
        End Try
    End Sub

    Private Sub btn_respuesta_Click(sender As System.Object, e As System.EventArgs) Handles btn_respuesta.Click
        Try
            Dim ActualizarTicket = (From P In datacontext.TICKET Where P.TIC_id_ticket = (txt_id_ticket.Text.ToUpper)).ToList()(0)
            ActualizarTicket.TIC_prioridad = StrConv(cbo_prioridad.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_estado = cbo_estado.Text
            ActualizarTicket.TIC_fecha_estimado_cierre = StrConv(dtp_fecha_estimada.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_fecha_real_cierre = StrConv(dtp_fecha_real.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_sector = StrConv(txt_sector_dirigido.Text, VbStrConv.ProperCase)
            ActualizarTicket.TIC_comentarios = StrConv(txt_comentarios.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            '  cargargrilla()
            '  Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Ticket")
            '  Me.limpiarcontroles()
            '  Me.cargargrilla()
        End Try
    End Sub

    Private Sub btnCancelar_Cliente_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_Cliente.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class