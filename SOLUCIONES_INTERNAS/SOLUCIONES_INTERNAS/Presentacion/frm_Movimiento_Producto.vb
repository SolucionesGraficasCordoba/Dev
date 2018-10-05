Public Class frm_Movimiento_Producto
    Dim datacontext As New DataS_Interno

    Private Sub frm_Producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        txt_id_orden_trabajo.Visible = False
        txt_id_producto.Visible = False
        txt_id_producto_movimiento.Visible = False
        armargrilla()
        cargargrillaproducto()

        cbo_Tipo_Producto.Enabled = False
        txt_Codigo.Enabled = False
        txt_descripcion.Enabled = False
        txt_Cantidad.Focus()
        lblTotal_Productos.Text = dgvLista_Productos.RowCount
        btnEliminar.Enabled = False
        dgvLista_Productos.ClearSelection()
    End Sub

    Private Sub btnGuardar_producto_Click(sender As System.Object, e As System.EventArgs)
        Try
            Dim buscarProducto = (From prod In datacontext.PRODUCTO
                                  Select prod.PROD_codigo, prod.PROD_descripcion, prod.PROD_stock
                                  Where PROD_descripcion = txt_descripcion.Text).Any
            If buscarProducto = True Then
                MsgBox("El Producto ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_descripcion.TextLength = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            Dim pro = New PRODUCTO
            pro.PROD_codigo = txt_Codigo.Text
            pro.PROD_descripcion = txt_descripcion.Text
            datacontext.PRODUCTO.InsertOnSubmit(pro)
            datacontext.SubmitChanges()
            MsgBox("El producto se ha creado correctamente", vbInformation)
        Catch ex As Exception
            MsgBox("El producto NO fue creado")
            limpiarcontroles()
            cargargrillaproducto()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_Codigo.Clear()
        txt_descripcion.Clear()

    End Sub

    Public Sub cargargrillaproducto()
        Dim carga = (From pr In datacontext.PRODUCTO
                     Select pr.PROD_id, pr.PROD_codigo, pr.PROD_descripcion, pr.PROD_stock
                                    Order By PROD_codigo Ascending)
        dgvLista_Productos.DataSource = carga
    End Sub

    Private Sub btnNuevo_producto_Click(sender As System.Object, e As System.EventArgs)
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Colaborador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_Producto.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_Buscar_Producto.Text & "*"
        Dim consultaprod = From U In datacontext.PRODUCTO
                          Select U.PROD_id, U.PROD_codigo, U.PROD_descripcion, U.PROD_stock
                          Where PROD_codigo Like buscar.ToString
        dgvLista_Productos.DataSource = consultaprod
    End Sub

    Private Sub armargrilla()
        dgvLista_Productos.Enabled = True
        dgvLista_Productos.AutoGenerateColumns = False
        dgvLista_Productos.Columns.Clear()

        dgvLista_Productos.Columns.Add("PROD_id", "id_producto")
        dgvLista_Productos.Columns.Add("PROD_codigo", "Código")
        dgvLista_Productos.Columns.Add("PROD_descripcion", "Descripción")
        dgvLista_Productos.Columns.Add("PROD_stock", "Stock")

        dgvLista_Productos.Columns(0).DataPropertyName = "PROD_id"
        dgvLista_Productos.Columns(0).Visible = False
        dgvLista_Productos.Columns(1).DataPropertyName = "PROD_codigo"
        dgvLista_Productos.Columns(2).DataPropertyName = "PROD_descripcion"
        dgvLista_Productos.Columns(2).Width = 200
        dgvLista_Productos.Columns(3).DataPropertyName = "PROD_stock"
    End Sub

    Private Sub btnEliminar_Colaborador_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If dgvLista_Productos.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.PRODUCTO Where C.PROD_id = CInt(dgvLista_Productos.Item("PROD_id", dgvLista_Productos.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el producto seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Producto")
                Case MsgBoxResult.Yes
                    datacontext.PRODUCTO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El producto ha sido eliminado")
                    cargargrillaproducto()
            End Select
        Else
            MsgBox("Debe seleccionar un producto")
        End If
    End Sub

    Private Sub dgvLista_Productos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Productos.CellClick

        If dgvLista_Productos.SelectedRows.Count > 0 Then
            txt_id_producto.Text = dgvLista_Productos.Item("PROD_id", dgvLista_Productos.SelectedRows(0).Index).Value
            txt_Codigo.Text = dgvLista_Productos.Item("PROD_codigo", dgvLista_Productos.SelectedRows(0).Index).Value
            txt_descripcion.Text = dgvLista_Productos.Item("PROD_descripcion", dgvLista_Productos.SelectedRows(0).Index).Value
            txt_Cantidad.Focus()
        Else
            MsgBox("Debe seleccionar un Producto")
        End If
    End Sub

    Private Sub btnIngresar_Stock_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar_Stock.Click

        'ACA DEBERIA GUARDAR EN LA TABLA MOVIMIENTO_PRODUCTO Y ADEMAS ACTUALIZAR STOCK EN LA TABLA PRODUCTOS
        Try
            If txt_Cantidad.TextLength = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            Dim prod_mov = New PRODUCTO_MOVIMIENTO
            txt_id_producto_movimiento.Text = prod_mov.PROD_MOV_id
            prod_mov.PROD_MOV_id = txt_id_producto_movimiento.Text
            prod_mov.PROD_MOV_fecha = dtpFecha.Text
            If txt_id_orden_trabajo.TextLength <> 0 Then
                prod_mov.ORT_id_orden_trabajo = txt_id_orden_trabajo.Text
            End If
            prod_mov.PROD_MOV_tipo = cbo_Tipo_Producto.Text
            prod_mov.PROD_MOV_cantidad = txt_Cantidad.Text
            prod_mov.PROD_id = txt_id_producto.Text

            datacontext.PRODUCTO_MOVIMIENTO.InsertOnSubmit(prod_mov)

            Dim cantidadtemporal As Integer
            Dim ActualizarStock = (From c In datacontext.PRODUCTO Where c.PROD_id = CInt(txt_id_producto.Text)).ToList()(0)

            cantidadtemporal = CInt(ActualizarStock.PROD_stock)

            If cbo_Tipo_Producto.Text = "Alta" Then
                cantidadtemporal = cantidadtemporal + CInt(txt_Cantidad.Text)
                'frm_Productos.tb_prod_stock.Text = CInt(txt_Cantidad.Text)
            Else
                cantidadtemporal = cantidadtemporal - CInt(txt_Cantidad.Text)
            End If
            ActualizarStock.PROD_stock = CInt(cantidadtemporal)

            datacontext.SubmitChanges()
            Select Case MsgBox("El Stock se ha actualizado, cargar otro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cargar Stock")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    limpiarcampos()
            End Select
        Catch ex As Exception
            MsgBox("El Stock no se ha sido actualizado")
           
        End Try
    End Sub

    Sub limpiarcampos()
        txt_Codigo.Clear()
        txt_descripcion.Clear()
        txt_Cantidad.Clear()
    End Sub
   
    Private Sub btnBuscar_cliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar_cliente.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.Text = "Seleccionar Orden"
        frm_Listado_Orden_Trabajo.Show()
    End Sub
End Class