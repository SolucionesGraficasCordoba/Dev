Public Class frm_Proceso1
    Dim datacontext As New DataS_Interno
    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub frm_Proceso1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Proceso1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_id_detalle_orden.Visible = False
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        'Dim ActualizarProceso = (From p In datacontext.PROCESO
        '                             Where p.id_detalle_orden_trabajo = CInt(txt_id_detalle_orden.Text)).ToList()(0)
        'txt_id_detalle_orden_trabajo1.Text = ActualizarDetalle1.id_detalle_orden_trabajo
        'ActualizarProceso.id_detalle_orden_trabajo = txt_id_detalle_orden_trabajo1.Text
        'ActualizarProceso.PROC_descrip_digital = StrConv(Me.txt_descripc_digital.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_descrip_gran_formato = StrConv(Me.txt_descripc_gran_formato.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_descrip_logistica = StrConv(Me.txt_descripc_logistica.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_descrip_offset = StrConv(Me.txt_descripc_offset.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_descrip_terminacion = StrConv(Me.txt_descripc_terminacion.Text, VbStrConv.ProperCase)

        'ActualizarProceso.PROC_digital = StrConv(Me.groupDigital.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_gran_formato = StrConv(Me.groupGranFormato.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_logistica = StrConv(Me.groupLogistica.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_offset = StrConv(Me.groupOffSet.Text, VbStrConv.ProperCase)
        'ActualizarProceso.PROC_terminacion = StrConv(Me.groupTerminacion.Text, VbStrConv.ProperCase)

        'datacontext.SubmitChanges()
    End Sub
End Class