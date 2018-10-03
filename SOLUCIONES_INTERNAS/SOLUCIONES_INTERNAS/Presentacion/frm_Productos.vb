﻿Public Class frm_Productos
    Dim datacontext As New DataS_Interno
    Private Sub btn_prod_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_guardar.Click
        Try
            'consulta si el codigo de prod ya existe
            Dim buscaproducto = (From P In datacontext.PRODUCTO Select P.PROD_codigo, P.PROD_descripcion, P.PROD_id, P.PROD_stock Where PROD_codigo = tb_prod_codigo.Text).Any
            If buscaproducto = True Then
                MsgBox("El código de producto ya existe")
                Exit Sub
            End If
            'controla que la descripcion y el stock no esten vacios
            If tb_prod_descripcion.TextLength = 0 Or tb_prod_stock.TextLength = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            'instancia y guarda en nuevoo producto
            Dim prod = New PRODUCTO
            prod.PROD_codigo = tb_prod_codigo.Text
            prod.PROD_descripcion = tb_prod_descripcion.Text
            prod.PROD_stock = tb_prod_stock.Text

            datacontext.PRODUCTO.InsertOnSubmit(prod)
            datacontext.SubmitChanges()

            'consulta si quiere cargar otro cliente
            Select Case MsgBox("El producto fue ingresado, cargar otro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo producto")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    limpiarcampos()
            End Select
            cargargrilla()
        Catch ex As Exception
            MsgBox("El cliente no fue cargado")
            limpiarcampos()

        End Try
    End Sub
    Sub limpiarcampos()
        'limpia los textbox
        tb_prod_id.Clear()
        tb_prod_codigo.Clear()
        tb_prod_descripcion.Clear()
        tb_prod_stock.Clear()
    End Sub
    Sub armargrilla()
        'arma el datagrid
        dgvLista_Productos.Columns.Add("PROD_id", "ID_producto")
        dgvLista_Productos.Columns.Add("PROD_codigo", "Código")
        dgvLista_Productos.Columns.Add("PROD_descripcion", "Descripción")
        dgvLista_Productos.Columns.Add("PROD_stock", "Stock")

        dgvLista_Productos.Columns(0).DataPropertyName = "PROD_id"
        dgvLista_Productos.Columns(1).DataPropertyName = "PROD_codigo"
        dgvLista_Productos.Columns(2).DataPropertyName = "PROD_descripcion"
        dgvLista_Productos.Columns(3).DataPropertyName = "PROD_stock"
    End Sub
    Sub cargargrilla()
        'carga el datagrid
        Dim consultaprod = From p In datacontext.PRODUCTO Select p.PROD_codigo, p.PROD_descripcion, p.PROD_id, p.PROD_stock
        dgvLista_Productos.DataSource = consultaprod
    End Sub

    Private Sub frm_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiarcampos()
        armargrilla()
        cargargrilla()
        dgvLista_Productos.ClearSelection()
    End Sub


    Private Sub dgvLista_Productos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLista_Productos.Click
        If dgvLista_Productos.SelectedRows.Count > 0 Then
            tb_prod_id.Text = dgvLista_Productos.Item("PROD_id", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_codigo.Text = dgvLista_Productos.Item("PROD_codigo", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_descripcion.Text = dgvLista_Productos.Item("PROD_descripcion", dgvLista_Productos.SelectedRows(0).Index).Value
            tb_prod_stock.Text = dgvLista_Productos.Item("PROD_stock", dgvLista_Productos.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un producto")
        End If
    End Sub

    Private Sub btn_prod_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_actualizar.Click

        
        'controla que la descripcion y el stock no esten vacios
        If tb_prod_descripcion.TextLength = 0 Or tb_prod_stock.TextLength = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If

        Try
            Dim ActualizarProducto = (From p In datacontext.PRODUCTO Where p.PROD_id = tb_prod_id.Text).ToList()(0)
            ActualizarProducto.PROD_codigo = tb_prod_codigo.Text
            ActualizarProducto.PROD_descripcion = tb_prod_descripcion.Text
            ActualizarProducto.PROD_stock = tb_prod_stock.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se actualizaron")
            cargargrilla()

        Catch ex As Exception
            MsgBox("Los datos no se modificaron", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
            limpiarcampos()
            cargargrilla()
        End Try
    End Sub

    Private Sub btn_prod_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_eliminar.Click
        If dgvLista_Productos.SelectedRows.Count > 0 Then
            Dim eliminar = (From p In datacontext.PRODUCTO Where p.PROD_id = CInt(dgvLista_Productos.Item("PROD_id", dgvLista_Productos.SelectedRows(0).Index).Value)).ToList()(0)
            Select Case MsgBox("Se eliminará el producto seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar producto")
                Case MsgBoxResult.Yes
                    datacontext.PRODUCTO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El producto fue eliminado")
                    cargargrilla()
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub btn_prod_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prod_salir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tb_prod_busqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_prod_busqueda.TextChanged
        Dim buscarprod
        buscarprod = "*" & tb_prod_busqueda.Text & "*"
        Dim consultaprod = From p In datacontext.PRODUCTO Select p.PROD_codigo, p.PROD_descripcion, p.PROD_id, p.PROD_stock Where PROD_descripcion Like buscarprod.ToString
    End Sub
End Class