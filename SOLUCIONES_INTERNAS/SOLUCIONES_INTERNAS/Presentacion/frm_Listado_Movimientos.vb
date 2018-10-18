Public Class frm_Listado_Movimientos

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    'Private Sub txt_Buscar_orden_trabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_Producto.TextChanged
  

    '    Dim carga = (From p In datavistas.Vista_Lista_Movimientos
    '                               Select p.PROD_id,
    '                               p.PROD_codigo,
    '                               p.PROD_descripcion,
    '                               p.PROD_stock,
    '                               p.PROD_stock_minimo,
    '                               p.PROD_MOV_id,
    '                               p.PROD_MOV_fecha,
    '                               p.PROD_MOV_tipo,
    '                               p.PROD_MOV_cantidad,
    '                               p.ORT_id_orden_trabajo
    '                               Where PROD_descripcion Like buscar.ToString And PROD_MOV_fecha.Value.Month = cboMes.SelectedIndex + 1)
    '    dgv_movimientos.DataSource = carga
    'End Sub

    Public Sub CargarGrillaMovimiento()
        Dim buscar As String

        buscar = Me.txt_Buscar_Producto.Text & "*"
        Dim carga = (From p In datavistas.Vista_Lista_Movimientos
                       Select p.PROD_id,
                                   p.PROD_codigo,
                                   p.PROD_descripcion,
                                   p.PROD_stock,
                                   p.PROD_stock_minimo,
                                   p.PROD_MOV_id,
                                   p.PROD_MOV_fecha,
                                   p.PROD_MOV_tipo,
                                   p.PROD_MOV_cantidad,
                                   p.ORT_id_orden_trabajo
                 Where PROD_descripcion Like buscar.ToString And PROD_MOV_fecha.Value.Month = cboMes.SelectedIndex + 1)
        dgv_movimientos.DataSource = carga
    End Sub

    ' Where (PROD_descripcion = txt_Buscar_Producto.Text And PROD_MOV_fecha.Value.Month = cboMes.SelectedIndex + 1))

    Private Sub frm_Listado_Movimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ArmaGrillaProductoMovimiento()
        'CargarGrillaMovimiento()

        Dim carga = (From p In datavistas.Vista_Lista_Movimientos
                      Select p.PROD_id,
                                  p.PROD_codigo,
                                  p.PROD_descripcion,
                                  p.PROD_stock,
                                  p.PROD_stock_minimo,
                                  p.PROD_MOV_id,
                                  p.PROD_MOV_fecha,
                                  p.PROD_MOV_tipo,
                                  p.PROD_MOV_cantidad,
                                  p.ORT_id_orden_trabajo)
        dgv_movimientos.DataSource = carga



        dgv_movimientos.ClearSelection()
    End Sub

    Private Sub ArmaGrillaProductoMovimiento()
        dgv_movimientos.Enabled = True
        dgv_movimientos.AutoGenerateColumns = False
        dgv_movimientos.Columns.Clear()

        dgv_movimientos.Columns.Add("PROD_id", "id_producto")
        dgv_movimientos.Columns.Add("PROD_codigo", "Código")
        dgv_movimientos.Columns.Add("PROD_descripcion", "Descripción")
        dgv_movimientos.Columns.Add("PROD_stock_minimo", "Mínimo")
        dgv_movimientos.Columns.Add("PROD_stock", "Stock")

        dgv_movimientos.Columns.Add("PROD_MOV_id", "id_prod_movimiento")

        dgv_movimientos.Columns.Add("PROD_MOV_tipo", "Tipo")
        dgv_movimientos.Columns.Add("PROD_MOV_cantidad", "Cantidad")
        dgv_movimientos.Columns.Add("ORT_id_orden_trabajo", "ODT")
        dgv_movimientos.Columns.Add("PROD_MOV_fecha", "Fecha")

        dgv_movimientos.Columns(0).DataPropertyName = "PROD_id"
        dgv_movimientos.Columns(0).Visible = False
        dgv_movimientos.Columns(1).DataPropertyName = "PROD_codigo"
        dgv_movimientos.Columns(1).Width = 50
        dgv_movimientos.Columns(1).Visible = True
        dgv_movimientos.Columns(2).DataPropertyName = "PROD_descripcion"
        dgv_movimientos.Columns(2).Width = 150
        dgv_movimientos.Columns(3).DataPropertyName = "PROD_stock_minimo"
        dgv_movimientos.Columns(3).Width = 50
        dgv_movimientos.Columns(3).Visible = False
        dgv_movimientos.Columns(4).DataPropertyName = "PROD_stock"
        dgv_movimientos.Columns(4).Width = 50
        dgv_movimientos.Columns(4).Visible = False
        dgv_movimientos.Columns(5).DataPropertyName = "PROD_MOV_id"
        dgv_movimientos.Columns(5).Visible = False
        dgv_movimientos.Columns(6).DataPropertyName = "PROD_MOV_tipo"
        dgv_movimientos.Columns(6).Visible = True
        dgv_movimientos.Columns(6).Width = 50
        dgv_movimientos.Columns(7).DataPropertyName = "PROD_MOV_cantidad"
        dgv_movimientos.Columns(7).Visible = True
        dgv_movimientos.Columns(8).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_movimientos.Columns(9).DataPropertyName = "PROD_MOV_fecha"
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frm_Listado_Movimientos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        CargarGrillaMovimiento()

    End Sub

    Private Sub txt_Buscar_Producto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_Producto.TextChanged
        CargarGrillaMovimiento()
    End Sub
End Class