﻿Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_listado_orden_trabajo_ampliada
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public quienllamolistado_ot As Form
    Public quienllamoboton As Button

    Public vble_id_orden As Integer
    Public vble_id_detalle As Integer
    Dim vble_id_proceso As Integer
    Dim vble_colaborador, vble_fecha As String

    'campos y vbles para generar pdf
    'Public contadorcolumnasvisibles As Integer
    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont

    Private Sub frm_listado_orden_trabajo_ampliada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArmarGrillaOrden()
        CargarGrillaOrden()
    End Sub

    Private Sub ArmarGrillaDetalle(ByVal datasource As System.Linq.IQueryable)
        dgv_detalle_orden.Enabled = True
        dgv_detalle_orden.AutoGenerateColumns = False
        dgv_detalle_orden.Columns.Clear()

        dgv_detalle_orden.Columns.Add("ORT_id_orden_trabajo", "ORT_id_orden_trabajo")
        dgv_detalle_orden.Columns.Add("ORT_tipo_ot", "Tipo")
        dgv_detalle_orden.Columns.Add("ORT_numero_ot", "Número")
        dgv_detalle_orden.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgv_detalle_orden.Columns.Add("ORT_mejoras_ot", "Mejoras")
        dgv_detalle_orden.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgv_detalle_orden.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgv_detalle_orden.Columns.Add("VEN_apellido_ven", "Apellido")
        dgv_detalle_orden.Columns.Add("ORT_fecha_ot", "Fecha")
        dgv_detalle_orden.Columns.Add("ORT_fecha_entrega", "Fecha de Entrega")
        dgv_detalle_orden.Columns.Add("CLI_id_cliente", "id_cliente")
        dgv_detalle_orden.Columns.Add("CLI_razon_social", "Razón Social")
        dgv_detalle_orden.Columns.Add("CLI_domicilio", "Domicilio")
        dgv_detalle_orden.Columns.Add("PIE_id_pieza", "PIE_id_pieza")
        dgv_detalle_orden.Columns.Add("PIE_id_pieza_offset", "PIE_id_pieza_offset")
        dgv_detalle_orden.Columns.Add("PIE_nombre_pie", "Pieza")
        dgv_detalle_orden.Columns.Add("PIE_ubicacion", "PIE_ubicacion")
        dgv_detalle_orden.Columns.Add("id_detalle_orden_trabajo", "id_detalle_orden_trabajo")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_producto", "Cantidad Producto")
        dgv_detalle_orden.Columns.Add("DOT_tamaño_producto", "Tamaño Producto")
        dgv_detalle_orden.Columns.Add("DOT_tipo_impresion_dot", "DOT_tipo_impresion_dot")
        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_1", "DOT_papel_soporte_1")
        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_2", "DOT_papel_soporte_2")
        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_3", "DOT_papel_soporte_3")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_1", "DOT_gramaje_soporte_1")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_2", "DOT_gramaje_soporte_2")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_3", "DOT_gramaje_soporte_3")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_1", "DOT_cantidad_soporte_1")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_2", "DOT_cantidad_soporte_2")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_3", "DOT_cantidad_soporte_3")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_1", "DOT_formato_soporte_1")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_2", "DOT_formato_soporte_2")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_3", "DOT_formato_soporte_3")
        dgv_detalle_orden.Columns.Add("cantidad_1_PM_offset", "cantidad_1_PM_offset")
        dgv_detalle_orden.Columns.Add("cantidad_2_PM_offset", "cantidad_2_PM_offset")
        dgv_detalle_orden.Columns.Add("cantidad_3_PM_offset", "cantidad_3_PM_offset")
        dgv_detalle_orden.Columns.Add("formato_1_PM_offset", "formato_1_PM_offset")
        dgv_detalle_orden.Columns.Add("formato_2_PM_offset", "formato_2_PM_offset")
        dgv_detalle_orden.Columns.Add("formato_3_PM_offset", "formato_3_PM_offset")
        dgv_detalle_orden.Columns.Add("modo_impresion_offset", "modo_impresion_offset")
        dgv_detalle_orden.Columns.Add("tipo_impresion_offset", "tipo_impresion_offset")
        dgv_detalle_orden.Columns.Add("chapas_soporte1_offset", "chapas_soporte1_offset")
        dgv_detalle_orden.Columns.Add("chapas_soporte2_offset", "chapas_soporte2_offset")
        dgv_detalle_orden.Columns.Add("chapas_soporte3_offset", "chapas_soporte3_offset")
        dgv_detalle_orden.Columns.Add("impresora_offset", "impresora_offset")
        dgv_detalle_orden.Columns.Add("marca_offset", "marca_offset")
        dgv_detalle_orden.Columns.Add("cantidad_1_PM_digital", "cantidad_1_PM_digital")
        dgv_detalle_orden.Columns.Add("cantidad_2_PM_digital", "cantidad_2_PM_digital")
        dgv_detalle_orden.Columns.Add("cantidad_3_PM_digital", "cantidad_3_PM_digital")
        dgv_detalle_orden.Columns.Add("formato_1_PM_digital", "formato_1_PM_digital")
        dgv_detalle_orden.Columns.Add("formato_2_PM_digital", "formato_2_PM_digital")
        dgv_detalle_orden.Columns.Add("formato_3_PM_digital", "formato_3_PM_digital")
        dgv_detalle_orden.Columns.Add("modo_impresion_digital", "modo_impresion_digital")
        dgv_detalle_orden.Columns.Add("tipo_impresion_digital", "tipo_impresion_digital")
        dgv_detalle_orden.Columns.Add("dato_variable", "dato_variable")
        dgv_detalle_orden.Columns.Add("cantidad_gran_formato", "cantidad_gran_formato")
        dgv_detalle_orden.Columns.Add("tamaño_gran_formato", "tamaño_gran_formato")
        dgv_detalle_orden.Columns.Add("sustrato_gran_formato", "sustrato_gran_formato")
        dgv_detalle_orden.Columns.Add("calidad_gran_formato", "calidad_gran_formato")
        dgv_detalle_orden.Columns.Add("sistema_gran_formato", "sistema_gran_formato")
        dgv_detalle_orden.Columns.Add("tipo_terminacion", "tipo_terminacion")
        dgv_detalle_orden.Columns.Add("descripcion_terminacion", "descripcion_terminacion")

        dgv_detalle_orden.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_detalle_orden.Columns(0).Visible = False
        dgv_detalle_orden.Columns(1).DataPropertyName = "ORT_tipo_ot"
        dgv_detalle_orden.Columns(1).Visible = False
        dgv_detalle_orden.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgv_detalle_orden.Columns(2).Visible = False
        dgv_detalle_orden.Columns(3).DataPropertyName = "ORT_observaciones_ot"
        dgv_detalle_orden.Columns(3).Visible = False
        dgv_detalle_orden.Columns(4).DataPropertyName = "ORT_mejoras_ot"
        dgv_detalle_orden.Columns(4).Visible = False
        dgv_detalle_orden.Columns(5).DataPropertyName = "VEN_id_vendedor"
        dgv_detalle_orden.Columns(5).Visible = False
        dgv_detalle_orden.Columns(6).DataPropertyName = "VEN_nombre_ven"
        dgv_detalle_orden.Columns(6).Visible = False
        dgv_detalle_orden.Columns(7).DataPropertyName = "VEN_apellido_ven"
        dgv_detalle_orden.Columns(7).Visible = False
        dgv_detalle_orden.Columns(8).DataPropertyName = "ORT_fecha_ot"
        dgv_detalle_orden.Columns(8).Visible = False
        dgv_detalle_orden.Columns(9).DataPropertyName = "ORT_fecha_entrega"
        dgv_detalle_orden.Columns(9).Visible = False
        dgv_detalle_orden.Columns(10).DataPropertyName = "CLI_id_cliente"
        dgv_detalle_orden.Columns(10).Visible = False
        dgv_detalle_orden.Columns(11).DataPropertyName = "CLI_razon_social"
        dgv_detalle_orden.Columns(11).Visible = False
        dgv_detalle_orden.Columns(12).DataPropertyName = "CLI_domicilio"
        dgv_detalle_orden.Columns(12).Visible = False
        dgv_detalle_orden.Columns(13).DataPropertyName = "PIE_id_pieza"
        dgv_detalle_orden.Columns(13).Visible = False
        dgv_detalle_orden.Columns(14).DataPropertyName = "PIE_id_pieza_offset"
        dgv_detalle_orden.Columns(14).Visible = False
        dgv_detalle_orden.Columns(15).DataPropertyName = "PIE_nombre_pie"
        dgv_detalle_orden.Columns(16).DataPropertyName = "PIE_ubicacion"
        dgv_detalle_orden.Columns(16).Visible = False
        dgv_detalle_orden.Columns(17).DataPropertyName = "id_detalle_orden_trabajo"
        dgv_detalle_orden.Columns(17).Visible = False
        dgv_detalle_orden.Columns(18).DataPropertyName = "DOT_cantidad_producto"
        dgv_detalle_orden.Columns(19).DataPropertyName = "DOT_tamaño_producto"
        dgv_detalle_orden.Columns(20).DataPropertyName = "DOT_tipo_impresion_dot"
        dgv_detalle_orden.Columns(20).Visible = False
        dgv_detalle_orden.Columns(21).DataPropertyName = "DOT_papel_soporte_1"
        dgv_detalle_orden.Columns(22).DataPropertyName = "DOT_papel_soporte_2"
        dgv_detalle_orden.Columns(23).DataPropertyName = "DOT_papel_soporte_3"
        dgv_detalle_orden.Columns(24).DataPropertyName = "DOT_gramaje_soporte_1"
        dgv_detalle_orden.Columns(25).DataPropertyName = "DOT_gramaje_soporte_2"
        dgv_detalle_orden.Columns(26).DataPropertyName = "DOT_gramaje_soporte_3"
        dgv_detalle_orden.Columns(27).DataPropertyName = "DOT_cantidad_soporte_1"
        dgv_detalle_orden.Columns(28).DataPropertyName = "DOT_cantidad_soporte_2"
        dgv_detalle_orden.Columns(29).DataPropertyName = "DOT_cantidad_soporte_3"
        dgv_detalle_orden.Columns(30).DataPropertyName = "DOT_formato_soporte_1"
        dgv_detalle_orden.Columns(31).DataPropertyName = "DOT_formato_soporte_2"
        dgv_detalle_orden.Columns(32).DataPropertyName = "DOT_formato_soporte_3"
        dgv_detalle_orden.Columns(33).DataPropertyName = "cantidad_1_PM_offset"
        dgv_detalle_orden.Columns(34).DataPropertyName = "cantidad_2_PM_offset"
        dgv_detalle_orden.Columns(35).DataPropertyName = "cantidad_3_PM_offset"
        dgv_detalle_orden.Columns(36).DataPropertyName = "formato_1_PM_offset"
        dgv_detalle_orden.Columns(37).DataPropertyName = "formato_2_PM_offset"
        dgv_detalle_orden.Columns(38).DataPropertyName = "formato_3_PM_offset"
        dgv_detalle_orden.Columns(39).DataPropertyName = "modo_impresion_offset"
        dgv_detalle_orden.Columns(40).DataPropertyName = "tipo_impresion_offset"
        dgv_detalle_orden.Columns(41).DataPropertyName = "chapas_soporte1_offset"
        dgv_detalle_orden.Columns(42).DataPropertyName = "chapas_soporte2_offset"
        dgv_detalle_orden.Columns(43).DataPropertyName = "chapas_soporte3_offset"
        dgv_detalle_orden.Columns(44).DataPropertyName = "impresora_offset"
        dgv_detalle_orden.Columns(45).DataPropertyName = "marca_offset"
        dgv_detalle_orden.Columns(46).DataPropertyName = "cantidad_1_PM_digital"
        dgv_detalle_orden.Columns(47).DataPropertyName = "cantidad_2_PM_digital"
        dgv_detalle_orden.Columns(48).DataPropertyName = "cantidad_3_PM_digital"
        dgv_detalle_orden.Columns(49).DataPropertyName = "formato_1_PM_digital"
        dgv_detalle_orden.Columns(50).DataPropertyName = "formato_2_PM_digital"
        dgv_detalle_orden.Columns(51).DataPropertyName = "formato_3_PM_digital"
        dgv_detalle_orden.Columns(52).DataPropertyName = "modo_impresion_digital"
        dgv_detalle_orden.Columns(52).Visible = False
        dgv_detalle_orden.Columns(53).DataPropertyName = "tipo_impresion_digital"
        dgv_detalle_orden.Columns(54).DataPropertyName = "dato_variable"
        dgv_detalle_orden.Columns(55).DataPropertyName = "cantidad_gran_formato"
        dgv_detalle_orden.Columns(56).DataPropertyName = "tamaño_gran_formato"
        dgv_detalle_orden.Columns(57).DataPropertyName = "sustrato_gran_formato"
        dgv_detalle_orden.Columns(58).DataPropertyName = "calidad_gran_formato"
        dgv_detalle_orden.Columns(59).DataPropertyName = "sistema_gran_formato"
        dgv_detalle_orden.Columns(60).DataPropertyName = "tipo_terminacion"
        dgv_detalle_orden.Columns(60).Visible = False
        dgv_detalle_orden.Columns(61).DataPropertyName = "descripcion_terminacion"
        dgv_detalle_orden.DataSource = datasource
        dgv_detalle_orden.ClearSelection()
    End Sub

    'CARGA GRILLA ORDEN TRABAJO
    Public Sub CargarGrillaOrden()
        Dim consultaOrden = (From U In datacontext.ORDEN_TRABAJO
                               Join ort In datacontext.VENDEDOR
                               On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                               Join col In datacontext.CLIENTE
                               On col.CLI_id_cliente Equals U.CLI_id_cliente
                              Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_fecha_entrega, U.ORT_tipo_ot, U.ORT_numero_ot,
                              U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Order By ORT_id_orden_trabajo Descending)
        dgvLista_Orden_Trabajo.DataSource = consultaOrden
        dgvLista_Orden_Trabajo.ClearSelection()
    End Sub

    'ARMA GRILLA ORDEN
    Private Sub ArmarGrillaOrden()
        dgvLista_Orden_Trabajo.Enabled = True
        dgvLista_Orden_Trabajo.AutoGenerateColumns = False
        dgvLista_Orden_Trabajo.Columns.Clear()

        dgvLista_Orden_Trabajo.Columns.Add("ORT_id_orden_trabajo", "TN")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_tipo_ot", "Tipo")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_numero_ot", "Número")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_fecha_ot", "Fecha")
        dgvLista_Orden_Trabajo.Columns.Add("CLI_id_cliente", "id_cliente")
        dgvLista_Orden_Trabajo.Columns.Add("CLI_razon_social", "Razón Social")
        dgvLista_Orden_Trabajo.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgvLista_Orden_Trabajo.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_mejoras_ot", "Mejoras")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_fecha_entrega", "Fecha de Entrega")

        dgvLista_Orden_Trabajo.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgvLista_Orden_Trabajo.Columns(0).Visible = False
        dgvLista_Orden_Trabajo.Columns(1).DataPropertyName = "ORT_tipo_ot"
        '  dgvLista_Orden_Trabajo.Columns(1).Width = 50
        dgvLista_Orden_Trabajo.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvLista_Orden_Trabajo.Columns(3).DataPropertyName = "ORT_fecha_ot"
        dgvLista_Orden_Trabajo.Columns(4).DataPropertyName = "CLI_id_cliente"
        dgvLista_Orden_Trabajo.Columns(4).Visible = False
        dgvLista_Orden_Trabajo.Columns(5).DataPropertyName = "CLI_razon_social"
        dgvLista_Orden_Trabajo.Columns(5).Width = 160
        dgvLista_Orden_Trabajo.Columns(6).DataPropertyName = "VEN_id_vendedor"
        dgvLista_Orden_Trabajo.Columns(6).Visible = False
        dgvLista_Orden_Trabajo.Columns(7).DataPropertyName = "VEN_nombre_ven"
        dgvLista_Orden_Trabajo.Columns(8).DataPropertyName = "ORT_observaciones_ot"
        dgvLista_Orden_Trabajo.Columns(9).DataPropertyName = "ORT_mejoras_ot"
        dgvLista_Orden_Trabajo.Columns(9).Visible = False
        dgvLista_Orden_Trabajo.Columns(10).DataPropertyName = "ORT_fecha_entrega"
    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellClick
        'VALIDA QUE SE HAYA SELECCONADO UN SECTOR Y UNA FECHA
        If dgvLista_Orden_Trabajo.Rows.Count = 0 Then
            MsgBox("No hay órdenes", MsgBoxStyle.Information + MsgBoxStyle.Information, "Seleccionar")
            Exit Sub
        End If
        Try
            vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            CargarGrillaDetalle()
        Catch ex As Exception
        End Try


        'frm_Actualizar_Producto_Orden_Ampliada.LimpiarDigital()
        'frm_Actualizar_Producto_Orden_Ampliada.LimpiarGranFormato()
        'frm_Actualizar_Producto_Orden_Ampliada.LimpiarOffset()
        'frm_Actualizar_Producto_Orden_Ampliada.LimpiarProducto_Soportes()
        'frm_Actualizar_Producto_Orden_Ampliada.LimpiarTerminacion()


    End Sub

    Public Sub CargarGrillaDetalle()
        Dim dgDetalleOrden = (From det_ord In datavistas.Vista_Detalle_Orden_Trabajo_Ampliada
Select
det_ord.ORT_id_orden_trabajo,
det_ord.ORT_tipo_ot,
det_ord.ORT_numero_ot,
det_ord.ORT_observaciones_ot,
det_ord.ORT_mejoras_ot,
det_ord.VEN_id_vendedor,
det_ord.VEN_nombre_ven,
det_ord.VEN_apellido_ven,
det_ord.ORT_fecha_ot,
det_ord.ORT_fecha_entrega,
det_ord.CLI_id_cliente,
det_ord.CLI_razon_social,
det_ord.CLI_domicilio,
det_ord.PIE_id_pieza,
det_ord.PIE_id_pieza_offset,
det_ord.PIE_nombre_pie,
det_ord.PIE_ubicacion,
det_ord.id_detalle_orden_trabajo,
det_ord.DOT_cantidad_producto,
det_ord.DOT_tamaño_producto,
det_ord.DOT_tipo_impresion_dot,
det_ord.DOT_papel_soporte_1,
det_ord.DOT_papel_soporte_2,
det_ord.DOT_papel_soporte_3,
det_ord.DOT_gramaje_soporte_1,
det_ord.DOT_gramaje_soporte_2,
det_ord.DOT_gramaje_soporte_3,
det_ord.DOT_cantidad_soporte_1,
det_ord.DOT_cantidad_soporte_2,
det_ord.DOT_cantidad_soporte_3,
det_ord.DOT_formato_soporte_1,
det_ord.DOT_formato_soporte_2,
det_ord.DOT_formato_soporte_3,
det_ord.cantidad_1_PM_offset,
det_ord.cantidad_2_PM_offset,
det_ord.cantidad_3_PM_offset,
det_ord.formato_1_PM_offset,
det_ord.formato_2_PM_offset,
det_ord.formato_3_PM_offset,
det_ord.modo_impresion_offset,
det_ord.tipo_impresion_offset,
det_ord.chapas_soporte1_offset,
det_ord.chapas_soporte2_offset,
det_ord.chapas_soporte3_offset,
det_ord.impresora_offset,
det_ord.marca_offset,
det_ord.cantidad_1_PM_digital,
det_ord.cantidad_2_PM_digital,
det_ord.cantidad_3_PM_digital,
det_ord.formato_1_PM_digital,
det_ord.formato_2_PM_digital,
det_ord.formato_3_PM_digital,
det_ord.modo_impresion_digital,
det_ord.tipo_impresion_digital,
det_ord.dato_variable,
det_ord.cantidad_gran_formato,
det_ord.tamaño_gran_formato,
det_ord.sustrato_gran_formato,
det_ord.calidad_gran_formato,
det_ord.sistema_gran_formato,
det_ord.tipo_terminacion,
det_ord.descripcion_terminacion
Where ORT_id_orden_trabajo = vble_id_orden)
        ArmarGrillaDetalle(dgDetalleOrden)
    End Sub

    Private Sub txt_Buscar_orden_trabajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        Dim buscar As String
        ArmarGrillaOrden()
        buscar = "*" & Me.txt_Buscar_orden_trabajo.Text & "*"
        Dim consultaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_fecha_entrega, U.ORT_tipo_ot, U.ORT_numero_ot,
                             U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Where ORT_numero_ot Like buscar.ToString
                             Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = consultaCliente
        dgvLista_Orden_Trabajo.ClearSelection()
        dgv_detalle_orden.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub txt_Buscar_Cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Cliente.TextChanged
        Dim buscar As String
        ArmarGrillaOrden()
        buscar = "*" & Me.txt_Buscar_Cliente.Text & "*"
        Dim BuscaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo,
                             U.ORT_fecha_ot,
                             U.ORT_fecha_entrega,
                             U.ORT_tipo_ot,
                             U.ORT_numero_ot,
                             U.ORT_observaciones_ot,
                             U.ORT_mejoras_ot,
                             U.VEN_id_vendedor,
                             ort.VEN_nombre_ven,
                             U.CLI_id_cliente,
                             col.CLI_razon_social
                              Where CLI_razon_social Like buscar.ToString)
        ' Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = BuscaCliente
        dgvLista_Orden_Trabajo.ClearSelection()
        dgv_detalle_orden.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub dtp_Buscar_Fecha_Entrega_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Buscar_Fecha_Entrega.ValueChanged
        Dim buscar As String
        ArmarGrillaOrden()
        buscar = Me.dtp_Buscar_Fecha_Entrega.Text & "*"

        Dim BuscaFecha = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo,
                             U.ORT_fecha_ot,
                             U.ORT_fecha_entrega,
                             U.ORT_tipo_ot,
                             U.ORT_numero_ot,
                             U.ORT_observaciones_ot,
                             U.ORT_mejoras_ot,
                             U.VEN_id_vendedor,
                             ort.VEN_nombre_ven,
                             U.CLI_id_cliente,
                             col.CLI_razon_social
                              Where ORT_fecha_entrega.Value.Date = dtp_Buscar_Fecha_Entrega.Text)
        ' Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = BuscaFecha
        dgvLista_Orden_Trabajo.ClearSelection()
        dgv_detalle_orden.DataSource = ""
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub btnEliminar_Orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Orden.Click
        If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.ORDEN_TRABAJO Where C.ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la orden y su detalle correspondiente, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar orden y detalle")
                Case MsgBoxResult.Yes
                    datacontext.ORDEN_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La orden y su detalle han sido eliminados")
                    CargarGrillaOrden()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un orden")
        End If
    End Sub

    Private Sub btnEliminar_Producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Producto.Click
        If dgv_detalle_orden.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.DETALLE_ORDEN_TRABAJO Where C.id_detalle_orden_trabajo = CInt(dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el detalle y proceso relacionado a él, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar detalle de la orden")
                Case MsgBoxResult.Yes
                    datacontext.DETALLE_ORDEN_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El detalle de la orden ha sido eliminada")
                    ' CargarDetalle()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un detalle")
        End If
    End Sub

    Private Sub btnModificarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarProducto.Click

        'LIMPIA CAMPOS CUANDO SE ABRE EL FORMULARIO
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarDigital()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarGranFormato()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarOffset()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarProducto_Soportes()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarTerminacion()

        'LLENA EL FORMULARIO CON LOS DATOS DEL GRID
        If dgv_detalle_orden.SelectedRows.Count > 0 Then
            frm_Actualizar_Producto_Orden_Ampliada.txt_id_orden_trabajo.Text = dgv_detalle_orden.Item("ORT_id_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value 'id_orden_trabajo
            frm_Actualizar_Producto_Orden_Ampliada.txtNumero_Orden_Trabajo.Text = dgv_detalle_orden.Item("ORT_numero_ot", dgv_detalle_orden.SelectedRows(0).Index).Value 'numero orden

            frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto.Text = dgv_detalle_orden.Item("DOT_cantidad_producto", dgv_detalle_orden.SelectedRows(0).Index).Value

            frm_Actualizar_Producto_Orden_Ampliada.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtTamaño_Producto.Text = dgv_detalle_orden.Item("DOT_tamaño_producto", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Papel_1_Soporte.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Papel_2_Soporte.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Papel_3_Soporte.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Gramaje_1_Soporte.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Gramaje_2_Soporte.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Gramaje_3_Soporte.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboModo_Impresion_Offset.Text = dgv_detalle_orden.Item("modo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Impresion_Offset.Text = dgv_detalle_orden.Item("tipo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_1.Text = dgv_detalle_orden.Item("chapas_soporte1_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_2.Text = dgv_detalle_orden.Item("chapas_soporte2_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_3.Text = dgv_detalle_orden.Item("chapas_soporte3_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboImpresora_Offset.Text = dgv_detalle_orden.Item("impresora_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboMarca_Offset.Text = dgv_detalle_orden.Item("marca_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Impresion_Digital.Text = dgv_detalle_orden.Item("tipo_impresion_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtDato_Variable.Text = dgv_detalle_orden.Item("dato_variable", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.Text = dgv_detalle_orden.Item("cantidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtTamaño_Producto_Gran_Formato.Text = dgv_detalle_orden.Item("tamaño_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtSustrato_Gran_Formato.Text = dgv_detalle_orden.Item("sustrato_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboCalidad_Gran_Formato.Text = dgv_detalle_orden.Item("calidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboSistema_Gran_Formato.Text = dgv_detalle_orden.Item("sistema_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_descripcion_terminacion.Text = dgv_detalle_orden.Item("descripcion_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

            Dim tempterminacion As String
            tempterminacion = dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

            If tempterminacion.Contains("T01") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True
            End If
            If tempterminacion.Contains("T02") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True
            End If
            If tempterminacion.Contains("T03") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True
            End If
            If tempterminacion.Contains("T04") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True
            End If
            If tempterminacion.Contains("T05") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True
            End If
            If tempterminacion.Contains("T06") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True
            End If
            If tempterminacion.Contains("T07") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True
            End If
            If tempterminacion.Contains("T08") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True
            End If
            If tempterminacion.Contains("T09") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True
            End If
            If tempterminacion.Contains("T10") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True
            End If
            If tempterminacion.Contains("T11") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True
            End If
            If tempterminacion.Contains("T12") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True
            End If
            If tempterminacion.Contains("T13") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True
            End If
            If tempterminacion.Contains("T14") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True
            End If
            If tempterminacion.Contains("T15") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True
            End If
            If tempterminacion.Contains("T16") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True
            End If
            If tempterminacion.Contains("T17") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True
            End If
            If tempterminacion.Contains("T18") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True
            End If
            If tempterminacion.Contains("T19") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True
            End If
            If tempterminacion.Contains("T20") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True
            End If
            If tempterminacion.Contains("T21") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True
            End If
            If tempterminacion.Contains("T22") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True
            End If
            If tempterminacion.Contains("T23") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True
            End If
            If tempterminacion.Contains("T24") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True
            End If
            If tempterminacion.Contains("T25") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True
            End If
            If tempterminacion.Contains("T26") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True
            End If
        End If

        'CONTROLES OFFSET
        If frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then

            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True

            'CONTROLES DIGITAL
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then

            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True

            'CONTROLES GRAN FORMATO
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then

            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False
            'habilita y deshabilita de groupbox
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = True

            'CONTROLES TERMINACION
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True Then

            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False

            'CONTROLES OFFSET Y DIGITAL
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 _
            And frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then

            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True

            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False


            'CONTROLES OFFSET, DIGITAL Y TERMINACION
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 _
            And frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 _
            And frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then

            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True

            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False


            'CONTROLES DIGITAL,TERMINACION
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True Then


            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True

            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False


            'CONTROLES OFFSET Y TERMINACION
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True Then

            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = True

            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = True

            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = True


            'CONTROLES GRAN FORMATO, TERMINACION
        ElseIf frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True Then

            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = True

            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False

            'habilita y deshabilita de groupbox
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = True
        End If

        frm_Actualizar_Producto_Orden_Ampliada.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Producto_Orden_Ampliada.Label1.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Orden.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.Label5.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.Label45.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False

        frm_Actualizar_Producto_Orden_Ampliada.ShowDialog()
        'Try
        '    frm_Actualizar_Producto_Orden_Ampliada.cboPiezas_Producto.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.SelectedRows(0).Index).Value
        '    frm_Actualizar_Producto_Orden_Ampliada.cboPiezas_Producto_Gran_Formato.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnModificar_Orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Orden.Click
        'If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then
        '    frm_Actualizar_Orden.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.dtpFecha_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.cboTipo_Orden.Text = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value


        '    frm_Actualizar_Orden.dtpFecha_Entrega.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_entrega", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

        '    frm_Actualizar_Orden.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        '    frm_Actualizar_Orden.txt_mejoras.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        'End If
        'frm_Actualizar_Orden.txtNumero_Orden_Trabajo.Enabled = False
        'frm_Actualizar_Orden.Label1.Visible = False
        'frm_Actualizar_Orden.txt_id_orden_trabajo.Visible = False
        'frm_Actualizar_Orden.txt_id_cliente.Visible = False
        'frm_Actualizar_Orden.txtid_vendedor.Visible = False
        'frm_Actualizar_Orden.txtNombre_vendedor.Enabled = False
        'frm_Actualizar_Orden.txt_nombre_cliente.Enabled = False
        'frm_Actualizar_Orden.ShowDialog()

    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarDigital()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarGranFormato()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarOffset()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarProducto_Soportes()
        frm_Actualizar_Producto_Orden_Ampliada.LimpiarTerminacion()

        If dgv_detalle_orden.SelectedRows.Count > 0 Then
            frm_Actualizar_Producto_Orden_Ampliada.txt_id_orden_trabajo.Text = dgv_detalle_orden.Item("ORT_id_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value 'id_orden_trabajo
            frm_Actualizar_Producto_Orden_Ampliada.txtNumero_Orden_Trabajo.Text = dgv_detalle_orden.Item("ORT_numero_ot", dgv_detalle_orden.SelectedRows(0).Index).Value 'numero orden

            frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto.Text = dgv_detalle_orden.Item("DOT_cantidad_producto", dgv_detalle_orden.SelectedRows(0).Index).Value

            frm_Actualizar_Producto_Orden_Ampliada.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtTamaño_Producto.Text = dgv_detalle_orden.Item("DOT_tamaño_producto", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Papel_1_Soporte.Text = dgv_detalle_orden.Item("DOT_papel_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Papel_2_Soporte.Text = dgv_detalle_orden.Item("DOT_papel_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Papel_3_Soporte.Text = dgv_detalle_orden.Item("DOT_papel_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Gramaje_1_Soporte.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Gramaje_2_Soporte.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Gramaje_3_Soporte.Text = dgv_detalle_orden.Item("DOT_gramaje_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_Cantidad_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_cantidad_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_1", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_2", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Entero.Text = dgv_detalle_orden.Item("DOT_formato_soporte_3", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("cantidad_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_1_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_2_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Maquina_Offset.Text = dgv_detalle_orden.Item("formato_3_PM_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboModo_Impresion_Offset.Text = dgv_detalle_orden.Item("modo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Impresion_Offset.Text = dgv_detalle_orden.Item("tipo_impresion_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_1.Text = dgv_detalle_orden.Item("chapas_soporte1_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_2.Text = dgv_detalle_orden.Item("chapas_soporte2_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_chapa_soporte_3.Text = dgv_detalle_orden.Item("chapas_soporte3_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboImpresora_Offset.Text = dgv_detalle_orden.Item("impresora_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboMarca_Offset.Text = dgv_detalle_orden.Item("marca_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("cantidad_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_1_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_1_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_2_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_2_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboFormato_3_Pliego_Maquina_Digital.Text = dgv_detalle_orden.Item("formato_3_PM_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Impresion_Digital.Text = dgv_detalle_orden.Item("tipo_impresion_digital", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtDato_Variable.Text = dgv_detalle_orden.Item("dato_variable", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.Text = dgv_detalle_orden.Item("cantidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtTamaño_Producto_Gran_Formato.Text = dgv_detalle_orden.Item("tamaño_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txtSustrato_Gran_Formato.Text = dgv_detalle_orden.Item("sustrato_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboCalidad_Gran_Formato.Text = dgv_detalle_orden.Item("calidad_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.cboSistema_Gran_Formato.Text = dgv_detalle_orden.Item("sistema_gran_formato", dgv_detalle_orden.SelectedRows(0).Index).Value
            frm_Actualizar_Producto_Orden_Ampliada.txt_descripcion_terminacion.Text = dgv_detalle_orden.Item("descripcion_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value


            Dim tempterminacion As String
            tempterminacion = dgv_detalle_orden.Item("tipo_terminacion", dgv_detalle_orden.SelectedRows(0).Index).Value

            If tempterminacion.Contains("T01") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True
            End If
            If tempterminacion.Contains("T02") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True
            End If
            If tempterminacion.Contains("T03") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True
            End If
            If tempterminacion.Contains("T04") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True
            End If
            If tempterminacion.Contains("T05") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True
            End If
            If tempterminacion.Contains("T06") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True
            End If
            If tempterminacion.Contains("T07") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True
            End If
            If tempterminacion.Contains("T08") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True
            End If
            If tempterminacion.Contains("T09") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True
            End If
            If tempterminacion.Contains("T10") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True
            End If
            If tempterminacion.Contains("T11") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True
            End If
            If tempterminacion.Contains("T12") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True
            End If
            If tempterminacion.Contains("T13") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True
            End If
            If tempterminacion.Contains("T14") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True
            End If
            If tempterminacion.Contains("T15") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True
            End If
            If tempterminacion.Contains("T16") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True
            End If
            If tempterminacion.Contains("T17") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True
            End If
            If tempterminacion.Contains("T18") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True
            End If
            If tempterminacion.Contains("T19") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True
            End If

            If tempterminacion.Contains("T20") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True
            End If
            If tempterminacion.Contains("T21") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True
            End If
            If tempterminacion.Contains("T22") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True
            End If
            If tempterminacion.Contains("T23") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True
            End If
            If tempterminacion.Contains("T24") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True
            End If
            If tempterminacion.Contains("T25") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True
            End If
            If tempterminacion.Contains("T26") Then
                frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True
            End If
        End If

        'CONTROLES OFFSET
        If frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Offset.TextLength <> 0 Then
            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False
            'habilita y deshabilita de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Enabled = False
            'habilita y deshabilita de groupbox
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
            'limpia campos de groupbox
            'frm_Orden_Trabajo_Ampliada.LimpiarDigital()
            'frm_Orden_Trabajo_Ampliada.LimpiarGranFormato()
            'frm_Orden_Trabajo_Ampliada.LimpiarTerminacion()
        End If

        'CONTROLES DIGITAL
        If frm_Actualizar_Producto_Orden_Ampliada.txtCantidad_1_Pliego_Maquina_Digital.TextLength <> 0 Then
            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False
            'habilita y deshabilita de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Enabled = False
            'habilita y deshabilita de groupbox
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False

            'frm_Orden_Trabajo_Ampliada.LimpiarOffset()
            'frm_Orden_Trabajo_Ampliada.LimpiarGranFormato()
            'frm_Orden_Trabajo_Ampliada.LimpiarTerminacion()
        End If

        'CONTROLES GRAN FORMATO
        If frm_Actualizar_Producto_Orden_Ampliada.txt_cantidad_producto_Gran_Formato.TextLength <> 0 Then
            'estado de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkGranFormato.Checked = True
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Checked = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False
            'habilita y deshabilita de checkbox
            frm_Actualizar_Producto_Orden_Ampliada.chkDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.chkOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Enabled = False
            'habilita y deshabilita de groupbox
            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False

            'frm_Orden_Trabajo_Ampliada.LimpiarDigital()
            'frm_Orden_Trabajo_Ampliada.LimpiarOffset()
            'frm_Orden_Trabajo_Ampliada.LimpiarTerminacion()
        End If

        'CONTROLES TERMINACION
        If frm_Actualizar_Producto_Orden_Ampliada.chkAdhesivado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkBarniz.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkCocido.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkCuño.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkDoblado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkEncuadernacion.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkFresado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkGuillotinado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkLaca_UV.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkLacaUVSectorizada.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkMedio_Corte.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkMontado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPBrillante.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkOPPMate.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkOtros.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPlastificado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkPosicionado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkRuedo.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkSoldado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkStamping.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkTrazado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkTroquelado.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkArmadoRevistas.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkEstampado.Checked = True _
            Or frm_Actualizar_Producto_Orden_Ampliada.chkPegadoManual.Checked = True Or frm_Actualizar_Producto_Orden_Ampliada.chkTermosellado.Checked = True Then

            frm_Actualizar_Producto_Orden_Ampliada.chkTerminacion.Checked = False

            frm_Actualizar_Producto_Orden_Ampliada.groupOffset.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupDigital.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupTerminacion.Enabled = True
            frm_Actualizar_Producto_Orden_Ampliada.GroupProducto_Soportes.Enabled = False
            frm_Actualizar_Producto_Orden_Ampliada.GroupGranFormato.Enabled = False

            'frm_Orden_Trabajo_Ampliada.LimpiarDigital()
            'frm_Orden_Trabajo_Ampliada.LimpiarOffset()
            'frm_Orden_Trabajo_Ampliada.LimpiarGranFormato()
        End If

        frm_Actualizar_Producto_Orden_Ampliada.txtNumero_Orden_Trabajo.Enabled = False
        frm_Actualizar_Producto_Orden_Ampliada.Label1.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.txt_id_orden_trabajo.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.cboTipo_Orden.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.Label5.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.Label45.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.txt_id_detalle_orden_trabajo1.Visible = False
        frm_Actualizar_Producto_Orden_Ampliada.btnActualizar_Orden_Trabajo.Enabled = False
        frm_Actualizar_Producto_Orden_Ampliada.ShowDialog()
        'Try
        '    frm_Actualizar_Producto_Orden_Ampliada.cboPiezas_Producto.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza", dgv_detalle_orden.SelectedRows(0).Index).Value
        '    frm_Actualizar_Producto_Orden_Ampliada.cboPiezas_Producto_Gran_Formato.SelectedValue = dgv_detalle_orden.Item("PIE_id_pieza_offset", dgv_detalle_orden.SelectedRows(0).Index).Value
        'Catch ex As Exception
        'End Try
    End Sub


    Private Sub rbtNroOrden_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNroOrden.CheckedChanged
        If rbtNroOrden.Checked = True Then
            txt_Buscar_Cliente.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = False
            txt_Buscar_orden_trabajo.Enabled = True
            txt_Buscar_orden_trabajo.Focus()
            txt_Buscar_Cliente.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
        End If
        CargarGrillaOrden()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtCliente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCliente.CheckedChanged
        If rbtCliente.Checked = True Then
            txt_Buscar_orden_trabajo.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = False
            txt_Buscar_Cliente.Enabled = True
            txt_Buscar_Cliente.Focus()
            txt_Buscar_orden_trabajo.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
        End If
        CargarGrillaOrden()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub rbtFechaEntrega_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtFechaEntrega.CheckedChanged
        If rbtFechaEntrega.Checked = True Then
            Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
            txt_Buscar_orden_trabajo.Enabled = False
            txt_Buscar_Cliente.Enabled = False
            dtp_Buscar_Fecha_Entrega.Enabled = True
            dtp_Buscar_Fecha_Entrega.Focus()
            txt_Buscar_orden_trabajo.Clear()
            txt_Buscar_Cliente.Clear()
            dtp_Buscar_Fecha_Entrega.Text = Now
            If dtp_Buscar_Fecha_Entrega.Text = Now Then
                CargarGrillaOrden()
            End If
        End If
        CargarGrillaOrden()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class

'USE [PREPRODUCCION]
'GO
'/****** Object:  View [dbo].[Vista_Detalle_Orden_Trabajo_Ampliada]    Script Date: 01/04/2019 17:00:01 ******/
'SET ANSI_NULLS ON
'GO
'SET QUOTED_IDENTIFIER ON
'GO
'CREATE VIEW [dbo].[Vista_Detalle_Orden_Trabajo_Ampliada]
'AS
'SELECT     dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo, dbo.ORDEN_TRABAJO.ORT_tipo_ot, dbo.ORDEN_TRABAJO.ORT_numero_ot, 
'                      dbo.ORDEN_TRABAJO.ORT_observaciones_ot, dbo.ORDEN_TRABAJO.ORT_mejoras_ot, dbo.ORDEN_TRABAJO.VEN_id_vendedor, dbo.VENDEDOR.VEN_nombre_ven, 
'                      dbo.VENDEDOR.VEN_apellido_ven, dbo.ORDEN_TRABAJO.ORT_fecha_ot, dbo.ORDEN_TRABAJO.ORT_fecha_entrega, dbo.ORDEN_TRABAJO.CLI_id_cliente, 
'                      dbo.CLIENTE.CLI_razon_social, dbo.CLIENTE.CLI_domicilio, dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza, dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza_offset, 
'                      dbo.PIEZA.PIE_nombre_pie, dbo.PIEZA.PIE_ubicacion, dbo.DETALLE_ORDEN_TRABAJO.id_detalle_orden_trabajo, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_producto, dbo.DETALLE_ORDEN_TRABAJO.DOT_tamaño_producto, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_tipo_impresion_dot, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_1, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_3, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_2, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_3, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_1, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_3, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_2, 
'                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_3, dbo.DETALLE_ORDEN_TRABAJO.cantidad_1_PM_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.cantidad_2_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.cantidad_3_PM_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.formato_1_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.formato_2_PM_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.formato_3_PM_offset, dbo.DETALLE_ORDEN_TRABAJO.modo_impresion_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.tipo_impresion_offset, dbo.DETALLE_ORDEN_TRABAJO.chapas_soporte1_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.chapas_soporte2_offset, dbo.DETALLE_ORDEN_TRABAJO.chapas_soporte3_offset, 
'                      dbo.DETALLE_ORDEN_TRABAJO.impresora_offset, dbo.DETALLE_ORDEN_TRABAJO.marca_offset, dbo.DETALLE_ORDEN_TRABAJO.cantidad_1_PM_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.cantidad_2_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.cantidad_3_PM_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.formato_1_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.formato_2_PM_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.formato_3_PM_digital, dbo.DETALLE_ORDEN_TRABAJO.modo_impresion_digital, 
'                      dbo.DETALLE_ORDEN_TRABAJO.tipo_impresion_digital, dbo.DETALLE_ORDEN_TRABAJO.dato_variable, dbo.DETALLE_ORDEN_TRABAJO.cantidad_gran_formato, 
'                      dbo.DETALLE_ORDEN_TRABAJO.tamaño_gran_formato, dbo.DETALLE_ORDEN_TRABAJO.sustrato_gran_formato, 
'                      dbo.DETALLE_ORDEN_TRABAJO.calidad_gran_formato, dbo.DETALLE_ORDEN_TRABAJO.sistema_gran_formato, dbo.DETALLE_ORDEN_TRABAJO.tipo_terminacion, 
'                      dbo.DETALLE_ORDEN_TRABAJO.descripcion_terminacion, PIEZA_1.PIE_nombre_pie AS Expr1, PIEZA_1.PIE_ubicacion AS Expr2
'FROM         dbo.DETALLE_ORDEN_TRABAJO INNER JOIN
'                      dbo.ORDEN_TRABAJO ON dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo INNER JOIN
'                      dbo.PIEZA ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza = dbo.PIEZA.PIE_id_pieza INNER JOIN
'                      dbo.CLIENTE ON dbo.ORDEN_TRABAJO.CLI_id_cliente = dbo.CLIENTE.CLI_id_cliente INNER JOIN
'                      dbo.VENDEDOR ON dbo.ORDEN_TRABAJO.VEN_id_vendedor = dbo.VENDEDOR.VEN_id_vendedor INNER JOIN
'                      dbo.PIEZA AS PIEZA_1 ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza_offset = PIEZA_1.PIE_id_pieza
'GO
'EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
'Begin DesignProperties = 
'   Begin PaneConfigurations = 
'      Begin PaneConfiguration = 0
'         NumPanes = 4
'         Configuration = "(H (1[69] 4[3] 2[3] 3) )"
'      End
'      Begin PaneConfiguration = 1
'         NumPanes = 3
'         Configuration = "(H (1 [50] 4 [25] 3))"
'      End
'      Begin PaneConfiguration = 2
'         NumPanes = 3
'         Configuration = "(H (1 [50] 2 [25] 3))"
'      End
'      Begin PaneConfiguration = 3
'         NumPanes = 3
'         Configuration = "(H (4 [30] 2 [40] 3))"
'      End
'      Begin PaneConfiguration = 4
'         NumPanes = 2
'         Configuration = "(H (1 [56] 3))"
'      End
'      Begin PaneConfiguration = 5
'         NumPanes = 2
'         Configuration = "(H (2 [66] 3))"
'      End
'      Begin PaneConfiguration = 6
'         NumPanes = 2
'         Configuration = "(H (4 [50] 3))"
'      End
'      Begin PaneConfiguration = 7
'         NumPanes = 1
'         Configuration = "(V (3))"
'      End
'      Begin PaneConfiguration = 8
'         NumPanes = 3
'         Configuration = "(H (1[56] 4[18] 2) )"
'      End
'      Begin PaneConfiguration = 9
'         NumPanes = 2
'         Configuration = "(H (1 [75] 4))"
'      End
'      Begin PaneConfiguration = 10
'         NumPanes = 2
'         Configuration = "(H (1[66] 2) )"
'      End
'      Begin PaneConfiguration = 11
'         NumPanes = 2
'         Configuration = "(H (4 [60] 2))"
'      End
'      Begin PaneConfiguration = 12
'         NumPanes = 1
'         Configuration = "(H (1) )"
'      End
'      Begin PaneConfiguration = 13
'         NumPanes = 1
'         Configuration = "(V (4))"
'      End
'      Begin PaneConfiguration = 14
'         NumPanes = 1
'         Configuration = "(V (2))"
'      End
'      ActivePaneConfig = 0
'   End
'   Begin DiagramPane = 
'      Begin Origin = 
'         Top = 0
'         Left = 0
'      End
'      Begin Tables = 
'         Begin Table = "DETALLE_ORDEN_TRABAJO"
'            Begin Extent = 
'               Top = 6
'               Left = 38
'               Bottom = 794
'               Right = 250
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "ORDEN_TRABAJO"
'            Begin Extent = 
'               Top = 57
'               Left = 478
'               Bottom = 255
'               Right = 679
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "PIEZA"
'            Begin Extent = 
'               Top = 330
'               Left = 453
'               Bottom = 435
'               Right = 651
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "CLIENTE"
'            Begin Extent = 
'               Top = 298
'               Left = 751
'               Bottom = 468
'               Right = 949
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "VENDEDOR"
'            Begin Extent = 
'               Top = 114
'               Left = 764
'               Bottom = 250
'               Right = 962
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'         Begin Table = "PIEZA_1"
'            Begin Extent = 
'               Top = 464
'               Left = 322
'               Bottom = 568
'               Right = 520
'            End
'            DisplayFlags = 280
'            TopColumn = 0
'         End
'      End
'   End
'   Begin SQLPane = 
'   End
'   Begin DataPane = 
'      Begin ParameterDefaults = ""
'      End
'      Begin ColumnWidths = 63
'         Width = 284
'         Width = 1500
'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_Ampliada'
'GO
'EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'         Width = 1500
'      End
'   End
'   Begin CriteriaPane = 
'      Begin ColumnWidths = 11
'         Column = 1440
'         Alias = 900
'         Table = 1170
'         Output = 720
'         Append = 1400
'         NewValue = 1170
'         SortType = 1350
'         SortOrder = 1410
'         GroupBy = 1350
'         Filter = 1350
'         Or = 1350
'         Or = 1350
'         Or = 1350
'      End
'   End
'End
'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_Ampliada'
'GO
'EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_Ampliada'
'GO
