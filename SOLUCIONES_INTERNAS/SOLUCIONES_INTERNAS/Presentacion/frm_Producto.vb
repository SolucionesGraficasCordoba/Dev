Public Class frm_Producto
    Dim datacontext As New DataS_Interno

    Private Sub frm_Producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        txt_id_orden_trabajo.Visible = False
        txt_id_producto.Visible = False
        txt_id_producto_movimiento.Visible = False
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

            If txt_descripcion.TextLength = 0 Or txt_Stock.TextLength = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            Dim pro = New PRODUCTO
            pro.PROD_codigo = txt_Codigo.Text
            pro.PROD_descripcion = txt_descripcion.Text
            pro.PROD_stock = txt_Stock.Text
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
        txt_Stock.Clear()
    End Sub

    Public Sub cargargrillaproducto()
        Dim carga = (From pr In datacontext.PRODUCTO
                     Select pr.PROD_id, pr.PROD_codigo, pr.PROD_descripcion, pr.PROD_stock
                                    Order By PROD_codigo Ascending)
        dgvLista_Productos.DataSource = carga
    End Sub

    Private Sub btnActualizar_producto_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar_producto.Click
        If txt_descripcion.TextLength = 0 Or txt_Stock.TextLength = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarProducto = (From P In datacontext.PRODUCTO Where P.PROD_id = (txt_id_producto.Text.ToUpper)).ToList()(0)
            ActualizarProducto.PROD_codigo = txt_Codigo.Text
            ActualizarProducto.PROD_descripcion = txt_descripcion.Text
            ActualizarProducto.PROD_stock = txt_Stock.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrillaproducto()
            Me.limpiarcontroles()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Producto")
            Me.limpiarcontroles()
            Me.cargargrillaproducto()
            Me.Close()
        End Try
    End Sub

    Private Sub btnNuevo_producto_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo_producto.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar_cancelar.Click
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

    Private Sub btnEliminar_Colaborador_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar_Colaborador.Click
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
End Class