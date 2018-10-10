Public Class frm_Listado_Movimientos

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub txt_Buscar_orden_trabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_Producto.TextChanged
        Dim buscar As String
        ArmaGrillaRetrabajo()
        buscar = Me.txt_Buscar_Producto.Text & "*"

        Dim carga = (From p In datacontext.PRODUCTO
                                   Join pm In datacontext.PRODUCTO_MOVIMIENTO
                                   On pm.PROD_id Equals p.PROD_id
                                   Select p.PROD_id,
                                   p.PROD_codigo,
                                   p.PROD_descripcion,
                                   p.PROD_stock,
                                   p.PROD_stock_minimo,
                                   pm.PROD_MOV_id,
                                   pm.PROD_MOV_fecha,
                                   pm.PROD_MOV_tipo,
                                   pm.PROD_MOV_cantidad
                                   Where PROD_descripcion Like buscar.ToString Order By PROD_MOV_fecha Descending)
        dgv_movimientos.DataSource = carga
    End Sub

    Private Sub frm_Listado_Movimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ArmaGrillaRetrabajo()
        CargarGrillaMovimiento()
        dgv_movimientos.ClearSelection()
    End Sub

    Private Sub ArmaGrillaRetrabajo()
        dgv_movimientos.Enabled = True
        dgv_movimientos.AutoGenerateColumns = False
        dgv_movimientos.Columns.Clear()

        dgv_movimientos.Columns.Add("PROD_id", "id_producto")
        dgv_movimientos.Columns.Add("PROD_codigo", "Código")
        dgv_movimientos.Columns.Add("PROD_descripcion", "Descripción")
        dgv_movimientos.Columns.Add("PROD_stock_minimo", "Mínimo")
        dgv_movimientos.Columns.Add("PROD_stock", "Stock")

        dgv_movimientos.Columns.Add("PROD_MOV_id", "id_prod_movimiento")
        dgv_movimientos.Columns.Add("PROD_MOV_fecha", "Fecha")
        dgv_movimientos.Columns.Add("PROD_MOV_tipo", "Tipo")
        dgv_movimientos.Columns.Add("PROD_MOV_cantidad", "Cantidad")
        dgv_movimientos.Columns.Add("ORT_id_orden_trabajo", "ODT")

        dgv_movimientos.Columns(0).DataPropertyName = "PROD_id"
        dgv_movimientos.Columns(0).Visible = False
        dgv_movimientos.Columns(1).DataPropertyName = "PROD_codigo"
        dgv_movimientos.Columns(1).Width = 50
        dgv_movimientos.Columns(2).DataPropertyName = "PROD_descripcion"
        dgv_movimientos.Columns(2).Width = 150
        dgv_movimientos.Columns(3).DataPropertyName = "PROD_stock_minimo"
        dgv_movimientos.Columns(3).Width = 50
        dgv_movimientos.Columns(4).DataPropertyName = "PROD_stock"
        dgv_movimientos.Columns(4).Width = 50
   
        dgv_movimientos.Columns(5).DataPropertyName = "PROD_MOV_id"
        dgv_movimientos.Columns(5).Visible = False
        dgv_movimientos.Columns(6).DataPropertyName = "PROD_MOV_fecha"
        dgv_movimientos.Columns(7).DataPropertyName = "PROD_MOV_tipo"
        dgv_movimientos.Columns(7).Visible = False
        dgv_movimientos.Columns(7).Width = 50
        dgv_movimientos.Columns(8).DataPropertyName = "PROD_MOV_cantidad"
        dgv_movimientos.Columns(8).Visible = False
        dgv_movimientos.Columns(9).DataPropertyName = "ORT_id_orden_trabajo"
    End Sub

    Public Sub CargarGrillaMovimiento()
        Dim carga = (From p In datacontext.PRODUCTO
                                   Join pm In datacontext.PRODUCTO_MOVIMIENTO
                                   On pm.PROD_id Equals p.PROD_id
                                   Select p.PROD_id,
                                   p.PROD_codigo,
                                   p.PROD_descripcion,
                                   p.PROD_stock,
                                   p.PROD_stock_minimo,
                                   pm.PROD_MOV_id,
                                   pm.PROD_MOV_fecha,
                                   pm.PROD_MOV_tipo,
                                   pm.PROD_MOV_cantidad Order By PROD_MOV_id Descending)

        dgv_movimientos.DataSource = carga
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class