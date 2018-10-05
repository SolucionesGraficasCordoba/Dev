Public Class frm_Listado_Movimientos

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub txt_Buscar_orden_trabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        Dim buscar As String
        '  armargrilla()
        buscar = Me.txt_Buscar_orden_trabajo.Text & "*"
        Dim consultaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_tipo_ot, U.ORT_numero_ot,
                             U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Where ORT_numero_ot Like buscar.ToString
                             Order By ORT_numero_ot Ascending)
        dgv_movimientos.DataSource = consultaCliente
    End Sub
End Class