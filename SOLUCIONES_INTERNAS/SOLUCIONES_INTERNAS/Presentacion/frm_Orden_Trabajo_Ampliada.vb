Public Class frm_Orden_Trabajo_Ampliada

    Dim datacontext As New DataS_Interno

    Private Sub frm_Orden_Trabajo_Ampliada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                           Where PIE_ubicacion = "D"
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto.DataSource = combopieza1
        cboPiezas_Producto.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto.ValueMember = "PIE_id_pieza"
        cboPiezas_Producto.SelectedIndex = -1

        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie, sec.PIE_ubicacion
                           Where PIE_ubicacion = "G"
                           Order By PIE_nombre_pie Ascending)
        cboPiezas_Producto_Gran_Formato.DataSource = combopieza2
        cboPiezas_Producto_Gran_Formato.DisplayMember = "PIE_nombre_pie"
        cboPiezas_Producto_Gran_Formato.ValueMember = "PIE_id_pieza"
        cboPiezas_Producto_Gran_Formato.SelectedIndex = -1
    End Sub

    Private Sub btnBuscar_cliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.btnEliminar_Cliente.Enabled = False
        frm_Cliente.GroupNuevoCliente.Enabled = False
        frm_Cliente.Show()
    End Sub
End Class