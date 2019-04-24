
Public Class frm_Sugerencia
    Dim datacontext As New DataS_Interno

    Private Sub frm_Sugerencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        txt_id_sugerencia.Visible = False
    End Sub

    Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click
        Try
            If txt_titulo.Text.Length = 0 Then
                MsgBox("Debe completar el Título")
                txt_titulo.Focus()
                Exit Sub
            End If
            Dim sug = New SUGERENCIA
            sug.SUG_fecha = StrConv(dtpFecha.Text, VbStrConv.ProperCase)
            sug.SUG_titulo = StrConv(txt_titulo.Text, VbStrConv.ProperCase)
            sug.SUG_sugerencia = txt_sugerencia.Text

            datacontext.SUGERENCIA.InsertOnSubmit(sug)
            datacontext.SubmitChanges()

            MsgBox("La Sugerencia se ha enviado correctamente!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox("La Sugerencia no pudo ser enviada, comunicarse con el administrador")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class