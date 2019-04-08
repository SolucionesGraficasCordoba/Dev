Public Class frm_Despacho
    Public Nro_linea_grid As Integer
    Dim datacontext As New DataS_Interno
    Private Sub btnBuscar_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_orden.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False

        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub frm_despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Hora_salida.CustomFormat = "HH:mm"

        Nro_linea_grid = 0

        armar_grilla_ordenes()
        buscar_ultimo_despacho()
        cmb_chofer.SelectedIndex = 0

    End Sub
    Sub buscar_ultimo_despacho()
        Try
            Dim buscaultimo = (From u In datacontext.DESPACHO Order By u.DES_campo_1 Descending Select u.DES_campo_1).ToList()(0)

            If IsNothing(buscaultimo) Then
                txt_numero_despacho.Text = 1
            Else
                txt_numero_despacho.Text = CInt(buscaultimo.ToString) + 1
            End If
        Catch ex As Exception
            txt_numero_despacho.Text = 1        
        End Try
    End Sub
    Sub armar_grilla_ordenes()
        dgv_lista_ordenes.AutoGenerateColumns = False
        dgv_lista_ordenes.Rows.Clear()

        dgv_lista_ordenes.Columns.Add("Id_Odt", "Id Odt")
        dgv_lista_ordenes.Columns.Add("Orden", "Orden de trabajo")
        dgv_lista_ordenes.Columns.Add("Fecha", "Fecha de entrega")
        dgv_lista_ordenes.Columns.Add("Hora", "Hora de entrega")
        dgv_lista_ordenes.Columns.Add("Observaciones", "Observaciones")

        dgv_lista_ordenes.Columns("Id_Odt").Visible = False
        dgv_lista_ordenes.Columns("Orden").ReadOnly = True



    End Sub

    Private Sub Btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar.Click
        Try
            If txt_numero_remito.TextLength <> 0 And txt_numero_remito.Enabled = True Then
                Dim buscaremito = (From d In datacontext.DESPACHO Select d.DES_nro_remito
                                   Where DES_nro_remito = txt_numero_remito.Text).Any
                If buscaremito = True Then
                    MsgBox("El remito ingresado ya existe.")
                    Exit Sub
                End If
            End If

            For i = 0 To dgv_lista_ordenes.RowCount - 2
                If dgv_lista_ordenes.Item("Fecha", i).Value = "" Or dgv_lista_ordenes.Item("Hora", i).Value = "" Then
                    MsgBox("Completar todas las fechas y horas de entrega de la grilla")
                    Exit Sub
                End If
            Next

            Dim temp_fecha_salida, temp_fecha_entrega As String

            temp_fecha_salida = dtp_Fecha_salida.Text & " " & dtp_Hora_salida.Text
            For i = 0 To dgv_lista_ordenes.RowCount - 2
                Dim des As New DESPACHO

                temp_fecha_entrega = dgv_lista_ordenes.Item("Fecha", i).Value & " " & dgv_lista_ordenes.Item("Hora", i).Value

                des.DES_campo_1 = txt_numero_despacho.Text
                des.DES_nro_remito = txt_numero_remito.Text
                des.DES_chofer = cmb_chofer.Text
                des.DES_fecha_salida = CDate(temp_fecha_salida)

                des.ORT_id_orden_trabajo = dgv_lista_ordenes.Item("Id_Odt", i).Value
                des.DES_fecha_entrega = CDate(temp_fecha_entrega)
                des.DES_observaciones = dgv_lista_ordenes.Item("Observaciones", i).Value

                datacontext.DESPACHO.InsertOnSubmit(des)
                datacontext.SubmitChanges()
            Next
            MsgBox("El remito fue guardado")
            limpiarcampos()
            If txt_numero_remito.Enabled = True Then
                buscar_ultimo_despacho()
            Else
                Close()
                frm_Listado_Despacho.cargargrilla_odtxrem()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar el remito")
        End Try
    End Sub
    Sub limpiarcampos()
        txt_numero_remito.Clear()
        dgv_lista_ordenes.Rows.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_quitar_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar_orden.Click
        Try
            dgv_lista_ordenes.Rows.RemoveAt(dgv_lista_ordenes.CurrentRow.Index)
        Catch ex As Exception
            MsgBox("Seleccionar fila para borrar")
        End Try
    End Sub
End Class