Public Class frm_Mensaje

    Dim datacontext As New DataS_Interno

    Private Sub btn_Envio_Click(sender As System.Object, e As System.EventArgs) Handles btn_Envio.Click
        If txt_Titulo.Text.Length = 0 Then
            MsgBox("Debe completar el campo 'Título'")
            Exit Sub
        End If
        If txt_comentario.Text.Length = 0 Then
            MsgBox("Debe completar el campo 'Comentario'")
            Exit Sub
        End If
        Try
            'GUARDA SOLICITANTE
            Dim men = New MENSAJE
            men.USU_id_usuario = StrConv(txt_id_usuario.Text, VbStrConv.ProperCase)
            men.MEN_fecha_mensaje = dtp_fecha_pedido.Text
            men.MEN_titulo = StrConv(txt_Titulo.Text, VbStrConv.ProperCase)
            men.MEN_comentario = StrConv(txt_comentario.Text, VbStrConv.ProperCase)
            men.MEN_respuesta = StrConv(txt_respuesta.Text, VbStrConv.ProperCase)

            datacontext.MENSAJE.InsertOnSubmit(men)
            datacontext.SubmitChanges()
            'Dim ultimoticket = (From ut In datacontext.TICKET
            '                    Select ut.TIC_id_ticket
            '                    Order By TIC_id_ticket Descending).ToList()(0)
            MsgBox("El Mensaje fue enviado exitosamente")
            Me.Close()
        Catch ex As Exception
            MsgBox("El Mensaje no puedo ser enviado")
        End Try
    End Sub

    Private Sub btn_respuesta_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_respuesta.Click

        If txt_respuesta.Text.Length = 0 Then
            MsgBox("Debe completar el campo 'Respuesta'")
            Exit Sub
        End If
        Try
            Dim ActualizarMensaje = (From P In datacontext.MENSAJE Where P.MEN_id_mensaje = (txt_id_mensaje.Text.ToUpper)).ToList()(0)
            ActualizarMensaje.MEN_respuesta = StrConv(txt_respuesta.Text, VbStrConv.ProperCase)

            datacontext.SubmitChanges()
            MsgBox("La Respuesta ha sido enviada correctamente")
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Enviar Respuesta")
        End Try
    End Sub

    Private Sub frm_Mensaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class