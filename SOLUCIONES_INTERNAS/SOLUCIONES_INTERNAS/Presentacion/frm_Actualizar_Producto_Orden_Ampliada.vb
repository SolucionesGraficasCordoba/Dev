Public Class frm_Actualizar_Producto_Orden_Ampliada
    Dim datacontext As New DataS_Interno
    Private Sub frm_Actualizar_Producto_Orden_Ampliada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBO
        Dim combopieza1 = (From sec In datacontext.PIEZA
                             Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                             Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto.DataSource = combopieza1
        cboPiezas_Producto.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto.ValueMember = "PIE_id_pieza"

        'ASIGNA PIEZA SEGUN LO QUE CONTIENE EL GRID
        cboPiezas_Producto.SelectedValue = frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.Item("PIE_id_pieza", frm_listado_orden_trabajo_ampliada.dgv_detalle_orden.CurrentRow.Index).Value

    End Sub
End Class