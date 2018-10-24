Public Class frm_Actualizar_Orden
    Dim datacontext As New DataS_Interno
    Private Sub btnBuscar_Vendedor_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Vendedor.Click

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        'VALIDA CAMPOS OBLIGATORIOS
        If txtNumero_Orden_Trabajo.Text.Length = 0 _
                Or cboTipo_Orden.Text.Length = 0 _
                Or txtid_vendedor.Text.Length = 0 _
                Or txt_id_cliente.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            'ACTUALIZA LA ORDEN DE TRABAJO
            Dim ActualizarOrden = (From P In datacontext.ORDEN_TRABAJO Where P.ORT_id_orden_trabajo = (txt_id_orden_trabajo.Text.ToUpper)).ToList()(0)
            ActualizarOrden.ORT_fecha_ot = dtpFecha_Orden_Trabajo.Text
            ActualizarOrden.ORT_tipo_ot = cboTipo_Orden.SelectedItem
            ActualizarOrden.ORT_numero_ot = txtNumero_Orden_Trabajo.Text
            ActualizarOrden.ORT_observaciones_ot = txt_observaciones.Text
            ActualizarOrden.ORT_mejoras_ot = txt_mejoras.Text
            ActualizarOrden.VEN_id_vendedor = txtid_vendedor.Text
            ActualizarOrden.CLI_id_cliente = txt_id_cliente.Text
            ActualizarOrden.ORT_fecha_entrega = dtpFecha_Entrega.Text
            datacontext.SubmitChanges()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Orden")
        End Try
    End Sub
End Class