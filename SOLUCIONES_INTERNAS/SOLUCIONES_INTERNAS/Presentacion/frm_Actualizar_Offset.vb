Public Class frm_Actualizar_Offset

    Private Sub btnBuscar_Numero_Orden1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Numero_Orden1.Click
        frm_listado_orden_trabajo_ampliada.quien_llamo_listado_orden_ampliada = Me
        frm_listado_orden_trabajo_ampliada.Show()

    End Sub
End Class