﻿Public Class frm_Despacho
    Public Nro_linea_grid As Integer
    Dim datacontext As New DataS_Interno
    Public dt_empaque As New Data.DataTable
    Private Sub btnBuscar_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        'frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        'frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        'frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        'frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        'frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False

        'frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub frm_despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If tbp_logistica.Enabled = True Then
            dtp_Hora_salida.CustomFormat = "HH:mm"

            Nro_linea_grid = 0

            armar_grilla_ordenes()
            buscar_ultimo_despacho()
            cmb_chofer.SelectedIndex = 0
        Else
            armar_grilla_empaque()
        End If

    End Sub

    Sub buscar_ultimo_despacho()
        Try
            Dim buscaultimo = (From u In datacontext.DESPACHO Order By Convert.ToInt32(u.DES_nro_despacho) Descending Select u.DES_nro_despacho).ToList()(0)

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

    Private Sub Btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If txt_numero_remito.TextLength <> 0 And txt_numero_remito.Enabled = True Then
        '        Dim buscaremito = (From d In datacontext.DESPACHO Select d.DES_nro_remito
        '                           Where DES_nro_remito = txt_numero_remito.Text).Any
        '        If buscaremito = True Then
        '            MsgBox("El remito ingresado ya existe.")
        '            Exit Sub
        '        End If
        '    End If

        '    For i = 0 To dgv_lista_ordenes.RowCount - 2
        '        If dgv_lista_ordenes.Item("Fecha", i).Value = "" Or dgv_lista_ordenes.Item("Hora", i).Value = "" Then
        '            MsgBox("Completar todas las fechas y horas de entrega de la grilla")
        '            Exit Sub
        '        End If
        '    Next

        '    Dim temp_fecha_salida, temp_fecha_entrega As String

        '    temp_fecha_salida = dtp_Fecha_salida.Text & " " & dtp_Hora_salida.Text
        '    For i = 0 To dgv_lista_ordenes.RowCount - 2
        '        Dim des As New DESPACHO

        '        temp_fecha_entrega = dgv_lista_ordenes.Item("Fecha", i).Value & " " & dgv_lista_ordenes.Item("Hora", i).Value

        '        des.DES_nro_despacho = txt_numero_despacho.Text
        '        des.DES_nro_remito = txt_numero_remito.Text
        '        des.DES_chofer = cmb_chofer.Text
        '        des.DES_fecha_salida = CDate(temp_fecha_salida)

        '        des.ORT_id_orden_trabajo = dgv_lista_ordenes.Item("Id_Odt", i).Value
        '        des.DES_fecha_entrega = CDate(temp_fecha_entrega)
        '        des.DES_observaciones = dgv_lista_ordenes.Item("Observaciones", i).Value

        '        datacontext.DESPACHO.InsertOnSubmit(des)
        '        datacontext.SubmitChanges()
        '    Next
        '    MsgBox("El remito fue guardado")
        '    limpiarcampos()
        '    If txt_numero_remito.Enabled = True Then
        '        buscar_ultimo_despacho()
        '    Else
        '        Close()
        '        frm_Listado_Despacho.cargargrilla_odtxrem()
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error al guardar el remito")
        'End Try
    End Sub
    Sub limpiarcampos()
        txt_numero_remito.Clear()
        dgv_lista_ordenes.Rows.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Close()
    End Sub

    Private Sub btn_quitar_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    dgv_lista_ordenes.Rows.RemoveAt(dgv_lista_ordenes.CurrentRow.Index)
        'Catch ex As Exception
        '    MsgBox("Seleccionar fila para borrar")
        'End Try
    End Sub

    Private Sub btnBuscar_orden_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_orden.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False

        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub Btn_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar.Click
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

                des.DES_nro_despacho = txt_numero_despacho.Text
                des.DES_nro_remito = txt_numero_remito.Text
                des.DES_chofer = cmb_chofer.Text
                des.DES_fecha_salida = CDate(temp_fecha_salida)

                des.ORT_id_orden_trabajo = dgv_lista_ordenes.Item("Id_Odt", i).Value
                des.DES_fecha_entrega = CDate(temp_fecha_entrega)
                des.DES_observaciones = dgv_lista_ordenes.Item("Observaciones", i).Value

                datacontext.DESPACHO.InsertOnSubmit(des)
            Next
            datacontext.SubmitChanges()

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


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_quitar_orden_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar_orden.Click
        Try
            dgv_lista_ordenes.Rows.RemoveAt(dgv_lista_ordenes.CurrentRow.Index)
            Nro_linea_grid = Nro_linea_grid - 1
        Catch ex As Exception
            MsgBox("Seleccionar fila para borrar")
        End Try
    End Sub

    Private Sub btn_emp_buscar_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_emp_buscar_orden.Click
        frm_listado_orden_trabajo_ampliada.quienllamolistado_ot = Me
        frm_listado_orden_trabajo_ampliada.Text = "Seleccionar Orden"
        frm_listado_orden_trabajo_ampliada.GroupDetallesOrden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnAgregarProducto.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnModificar_Orden.Enabled = False
        frm_listado_orden_trabajo_ampliada.btnEliminar_Orden.Enabled = False

        frm_listado_orden_trabajo_ampliada.Show()
    End Sub

    Private Sub btn_emp_quitar_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_emp_quitar_orden.Click
        Try
            dgv_emp_lista_ordenes.Rows.RemoveAt(dgv_emp_lista_ordenes.CurrentRow.Index)
        Catch ex As Exception
            MsgBox("Seleccionar fila para borrar")
        End Try
    End Sub

    Private Sub Btn_emp_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_emp_guardar.Click
        'Try
        For i = 0 To dgv_emp_lista_ordenes.RowCount - 2
            Dim emp As New DESPACHO
            emp.ORT_id_orden_trabajo = CInt(dgv_emp_lista_ordenes.Item("ORT_id_orden_trabajo", i).Value)
            datacontext.DESPACHO.InsertOnSubmit(emp)
        Next
        datacontext.SubmitChanges()
        MsgBox("La planificación fue guardada")
        ' dgv_emp_lista_ordenes.Rows.Clear()
        Close()
        'Catch ex As Exception
        '    MsgBox("Error al guardar el remito")
        '    Exit Sub
        'End Try
    End Sub

    Sub armar_grilla_empaque()
        dgv_emp_lista_ordenes.AutoGenerateColumns = False
        dgv_emp_lista_ordenes.Rows.Clear()

        dgv_emp_lista_ordenes.Columns.Add("ORT_id_orden_trabajo", "Id Odt")
        dgv_emp_lista_ordenes.Columns.Add("ORT_numero_ot", "Orden de trabajo")

        dgv_emp_lista_ordenes.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_emp_lista_ordenes.Columns(1).DataPropertyName = "ORT_numero_ot"


        'SE UTILIZA UNA CLASE PARA PODER MODIFICAR LOS ELEMENTOS DE UN DATAGRID ENLAZADO A UN ORIGEN DE DATOS
        Dim empaque = (From c In datacontext.ORDEN_TRABAJO
        Where (Not (From e In datacontext.DESPACHO
                    Select e.ORT_id_orden_trabajo).Contains(c.ORT_id_orden_trabajo)) And c.ORT_fecha_entrega = System.DateTime.Now.ToShortDateString
        Select New clase_empaque(c.ORT_id_orden_trabajo, c.ORT_numero_ot))

        ' SE CREA UN DATA TABLE YA QUE NO SE PUEDEN AGREGAR FILAS A UN DATAGRID ENLAZADO A UN ORIGEN DE DATOS.. POR LO QUE.. EL DATATABLE SE ENLAZA AL 
        'ORIGEN DE DATOS, Y SE USA EL DATATABLE COMO DATASOURCE DEL DATAGRIDVIEW

        dt_empaque.Columns.Add("ORT_id_orden_trabajo")
        dt_empaque.Columns.Add("ORT_numero_ot")

        'SE COPIAN LAS FILAS DEL ORIGEN DE DATOS AL DATATABLE
        Dim nueva_fila As DataRow
        For Each row In empaque
            With dt_empaque
                nueva_fila = dt_empaque.NewRow
                nueva_fila("ORT_id_orden_trabajo") = row.ORT_id_orden_trabajo
                nueva_fila("ORT_numero_ot") = row.ORT_numero_ot
                .Rows.Add(nueva_fila)
            End With
        Next

        'SE USA EL DATATABLE COMO DATASOURCE
        dgv_emp_lista_ordenes.DataSource = dt_empaque
    End Sub


    Private Sub btn_emp_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_emp_cancelar.Click
        Close()
    End Sub
End Class
Public Class clase_empaque
    Public _ORT_id_orden_trabajo
    Public _ORT_numero_ot

    Sub New(ByVal ort_id As Integer, ByVal ort_nro As String)
        _ORT_id_orden_trabajo = ort_id
        _ORT_numero_ot = ort_nro
    End Sub
    Property ORT_id_orden_trabajo() As String
        Get
            Return _ORT_id_orden_trabajo
        End Get
        Set(ByVal value As String)
            Me._ORT_id_orden_trabajo = value
        End Set
    End Property
    Property ORT_numero_ot() As String
        Get
            Return _ORT_numero_ot
        End Get
        Set(ByVal value As String)
            Me._ORT_numero_ot = value
        End Set
    End Property
End Class