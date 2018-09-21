Public Class frm_Listado_Orden_Trabajo
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public quienllamolistado_ot As Form
    Public quienllamoboton As Button

    Public vble_id_orden As Integer
    Dim vble_colaborador, vble_fecha As String

    Private Sub frm_Detalle_Orden_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()
        armargrilla()
        Label3.Text = dgvLista_Orden_Trabajo.Rows.Count
        dgvLista_Orden_Trabajo.ClearSelection()
        'dgv_detalle_orden.Enabled = False
    End Sub

    'CARGA GRILLA ORDEN
    Public Sub cargargrilla()
        Dim consultaOrden = (From U In datacontext.ORDEN_TRABAJO
                               Join ort In datacontext.VENDEDOR
                               On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                               Join col In datacontext.CLIENTE
                               On col.CLI_id_cliente Equals U.CLI_id_cliente
                              Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_tipo_ot, U.ORT_numero_ot,
                              U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Order By ORT_id_orden_trabajo Descending)
        dgvLista_Orden_Trabajo.DataSource = consultaOrden
    End Sub

    'ARMA GRILLA DETALLE
    Private Sub armargrilla()
        dgvLista_Orden_Trabajo.Enabled = True
        dgvLista_Orden_Trabajo.AutoGenerateColumns = False
        dgvLista_Orden_Trabajo.Columns.Clear()

        dgvLista_Orden_Trabajo.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_tipo_ot", "Tipo")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_numero_ot", "Número")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_fecha_ot", "Fecha")
        dgvLista_Orden_Trabajo.Columns.Add("CLI_id_cliente", "id_cliente")
        dgvLista_Orden_Trabajo.Columns.Add("CLI_razon_social", "Razón Social")
        dgvLista_Orden_Trabajo.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgvLista_Orden_Trabajo.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgvLista_Orden_Trabajo.Columns.Add("ORT_mejoras_ot", "Mejoras")
        
        dgvLista_Orden_Trabajo.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgvLista_Orden_Trabajo.Columns(0).Visible = False
        dgvLista_Orden_Trabajo.Columns(1).DataPropertyName = "ORT_tipo_ot"
        dgvLista_Orden_Trabajo.Columns(1).Width = 50
        dgvLista_Orden_Trabajo.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgvLista_Orden_Trabajo.Columns(3).DataPropertyName = "ORT_fecha_ot"
        dgvLista_Orden_Trabajo.Columns(4).DataPropertyName = "CLI_id_cliente"
        dgvLista_Orden_Trabajo.Columns(4).Visible = False
        dgvLista_Orden_Trabajo.Columns(5).DataPropertyName = "CLI_razon_social"
        dgvLista_Orden_Trabajo.Columns(6).DataPropertyName = "VEN_id_vendedor"
        dgvLista_Orden_Trabajo.Columns(6).Visible = False
        dgvLista_Orden_Trabajo.Columns(7).DataPropertyName = "VEN_nombre_ven"
        dgvLista_Orden_Trabajo.Columns(8).DataPropertyName = "ORT_observaciones_ot"
        dgvLista_Orden_Trabajo.Columns(9).DataPropertyName = "ORT_mejoras_ot"
        dgvLista_Orden_Trabajo.Columns(9).Visible = False

    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellClick

        'VALIDA QUE SE HAYA SELECCONADO UN SECTOR Y UNA FECHA
        If dgvLista_Orden_Trabajo.Rows.Count = 0 Then
            MsgBox("No hay órdenes", MsgBoxStyle.Information + MsgBoxStyle.Information, "Seleccionar")
            Exit Sub
        End If
        'CARGA DETALLES DE LA ORDEN
        If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then
            vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        End If
        vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
        CargarDetalle()
      
    End Sub

    Public Sub CargarDetalle()
        Dim datagriddetalleorden = (From o In datavistas.Vista_Detalle_Orden_Trabajo_1
                          Select o.ORT_id_orden_trabajo, o.ORT_tipo_ot, o.ORT_numero_ot, o.ORT_observaciones_ot,
                          o.VEN_id_vendedor, o.VEN_nombre_ven, o.CLI_id_cliente, o.CLI_razon_social, _
                          o.PIE_id_pieza, o.PIE_nombre_pie, o.id_detalle_orden_trabajo, o.DOT_cantidad_dot, _
                          o.DOT_tamaño_dot, o.DOT_tipo_impresion_dot, o.DOT_papel_soporte_1, o.DOT_papel_soporte_2, o.DOT_papel_soporte_3, _
                          o.DOT_gramaje_soporte_1, o.DOT_gramaje_soporte_2, o.DOT_gramaje_soporte_3, _
                          o.DOT_cantidad_soporte_1, o.DOT_cantidad_soporte_2, o.DOT_cantidad_soporte_3, _
                          o.DOT_formato_soporte_1, o.DOT_formato_soporte_2, o.DOT_formato_soporte_3
                          Where ORT_id_orden_trabajo = vble_id_orden)
        mostrargrillaobligaciones(datagriddetalleorden)
        Label1.Text = dgv_detalle_orden.Rows.Count
    End Sub

    Public Sub mostrargrillaobligaciones(ByVal datasource As System.Linq.IQueryable)
        dgv_detalle_orden.AutoGenerateColumns = False
        dgv_detalle_orden.Columns.Clear()

        dgv_detalle_orden.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgv_detalle_orden.Columns.Add("ORT_tipo_ot", "Tipo de orden")
        dgv_detalle_orden.Columns.Add("ORT_numero_ot", "Número de orden")
        dgv_detalle_orden.Columns.Add("ORT_observaciones_ot", "Observaciones")
        dgv_detalle_orden.Columns.Add("VEN_id_vendedor", "id_vendedor")
        dgv_detalle_orden.Columns.Add("VEN_nombre_ven", "Vendedor")
        dgv_detalle_orden.Columns.Add("CLI_id_cliente", "id_cliente")
        dgv_detalle_orden.Columns.Add("CLI_razon_social", "Razón social")
        dgv_detalle_orden.Columns.Add("PIE_id_pieza", "id_pieza")
        dgv_detalle_orden.Columns.Add("PIE_nombre_pie", "Pieza")
        dgv_detalle_orden.Columns.Add("id_detalle_orden_trabajo", "id_detalle_orden_trabajo")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_dot", "Cantidad")
        dgv_detalle_orden.Columns.Add("DOT_tamaño_dot", "Tamaño")
        dgv_detalle_orden.Columns.Add("DOT_tipo_impresion_dot", "Tipo de impresión")

        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_1", "Soporte 1")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_1", "Gramaje 1")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_1", "Cantidad 1")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_1", "Formato 1")

        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_2", "Soporte 2")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_2", "Gramaje 2")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_2", "Cantidad 2")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_2", "Formato 2")

        dgv_detalle_orden.Columns.Add("DOT_papel_soporte_3", "Soporte 3")
        dgv_detalle_orden.Columns.Add("DOT_gramaje_soporte_3", "Gramaje 3")
        dgv_detalle_orden.Columns.Add("DOT_cantidad_soporte_3", "Cantidad 3")
        dgv_detalle_orden.Columns.Add("DOT_formato_soporte_3", "Formato soporte 3")

        dgv_detalle_orden.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgv_detalle_orden.Columns(0).Visible = False
        dgv_detalle_orden.Columns(1).DataPropertyName = "ORT_tipo_ot"
        dgv_detalle_orden.Columns(1).Visible = False
        dgv_detalle_orden.Columns(2).DataPropertyName = "ORT_numero_ot"
        dgv_detalle_orden.Columns(2).Visible = False
        dgv_detalle_orden.Columns(3).DataPropertyName = "ORT_observaciones_ot"
        dgv_detalle_orden.Columns(3).Width = 200
        dgv_detalle_orden.Columns(3).Visible = False
        dgv_detalle_orden.Columns(4).DataPropertyName = "VEN_id_vendedor"
        dgv_detalle_orden.Columns(4).Visible = False
        dgv_detalle_orden.Columns(5).DataPropertyName = "VEN_nombre_ven"
        dgv_detalle_orden.Columns(5).Visible = False
        dgv_detalle_orden.Columns(6).DataPropertyName = "CLI_id_cliente"
        dgv_detalle_orden.Columns(6).Visible = False
        dgv_detalle_orden.Columns(7).DataPropertyName = "CLI_razon_social"
        dgv_detalle_orden.Columns(7).Visible = False
        dgv_detalle_orden.Columns(8).DataPropertyName = "PIE_id_pieza"
        dgv_detalle_orden.Columns(8).Visible = False
        dgv_detalle_orden.Columns(9).DataPropertyName = "PIE_nombre_pie"
        dgv_detalle_orden.Columns(10).DataPropertyName = "id_detalle_orden_trabajo"
        dgv_detalle_orden.Columns(10).Visible = False
        dgv_detalle_orden.Columns(11).DataPropertyName = "DOT_cantidad_dot"
        dgv_detalle_orden.Columns(12).DataPropertyName = "DOT_tamaño_dot"
        dgv_detalle_orden.Columns(13).DataPropertyName = "DOT_tipo_impresion_dot"
        dgv_detalle_orden.Columns(14).DataPropertyName = "DOT_papel_soporte_1"
        dgv_detalle_orden.Columns(14).Visible = False
        dgv_detalle_orden.Columns(15).DataPropertyName = "DOT_gramaje_soporte_1"
        dgv_detalle_orden.Columns(15).Visible = False
        dgv_detalle_orden.Columns(16).DataPropertyName = "DOT_cantidad_soporte_1"
        dgv_detalle_orden.Columns(16).Visible = False
        dgv_detalle_orden.Columns(17).DataPropertyName = "DOT_formato_soporte_1"
        dgv_detalle_orden.Columns(17).Visible = False
        dgv_detalle_orden.Columns(18).DataPropertyName = "DOT_papel_soporte_2"
        dgv_detalle_orden.Columns(18).Visible = False
        dgv_detalle_orden.Columns(19).DataPropertyName = "DOT_gramaje_soporte_2"
        dgv_detalle_orden.Columns(19).Visible = False
        dgv_detalle_orden.Columns(20).DataPropertyName = "DOT_cantidad_soporte_2"
        dgv_detalle_orden.Columns(20).Visible = False
        dgv_detalle_orden.Columns(21).DataPropertyName = "DOT_formato_soporte_2"
        dgv_detalle_orden.Columns(21).Visible = False
        dgv_detalle_orden.Columns(22).DataPropertyName = "DOT_papel_soporte_3"
        dgv_detalle_orden.Columns(22).Visible = False
        dgv_detalle_orden.Columns(23).DataPropertyName = "DOT_gramaje_soporte_3"
        dgv_detalle_orden.Columns(23).Visible = False
        dgv_detalle_orden.Columns(24).DataPropertyName = "DOT_cantidad_soporte_3"
        dgv_detalle_orden.Columns(24).Visible = False
        dgv_detalle_orden.Columns(25).DataPropertyName = "DOT_formato_soporte_3"
        dgv_detalle_orden.Columns(25).Visible = False
        dgv_detalle_orden.DataSource = datasource
        dgv_detalle_orden.ClearSelection()
    End Sub

    'FUNCIONA BIEN
    Private Sub btnModificar_Orden_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar_Orden.Click

        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas1_Detalle1.DataSource = combopieza1
        frm_Orden_Trabajo.cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA DETALLE 2
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas2_Detalle2.DataSource = combopieza2
        frm_Orden_Trabajo.cboPiezas2_Detalle2.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas2_Detalle2.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA DETALLE 3
        Dim combopieza3 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas3_Detalle3.DataSource = combopieza3
        frm_Orden_Trabajo.cboPiezas3_Detalle3.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas3_Detalle3.ValueMember = "PIE_id_pieza"

        If dgvLista_Orden_Trabajo.SelectedRows.Count = 0 Then
            MsgBox("debe seleccionar una orden")
        Else

            vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

            'LLENA LOS CAMPOS DE LA ORDEN
            If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then
                frm_Orden_Trabajo.txt_id_orden_trabajo.Text = vble_id_orden
                frm_Orden_Trabajo.cboTipo_Orden.SelectedItem = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.dtpFecha_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
                frm_Orden_Trabajo.txt_mejoras.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

                Dim flag1 As Integer
                Dim flag2 As Integer
                Dim flag3 As Integer

                If dgv_detalle_orden.RowCount = 1 Then
                    flag1 = 1
                    flag2 = 0
                    flag3 = 0
                ElseIf dgv_detalle_orden.RowCount = 2 Then
                    flag1 = 1
                    flag2 = 1
                    flag3 = 0
                ElseIf dgv_detalle_orden.RowCount = 3 Then
                    flag1 = 1
                    flag2 = 1
                    flag3 = 1
                End If

                If flag1 = 1 Then
                    frm_Orden_Trabajo.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_cantidad1_detalle1.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(0).Index).Value
                    frm_Orden_Trabajo.cboPiezas1_Detalle1.SelectedValue = dgv_detalle_orden("PIE_id_pieza", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txtTamaño1_Detalle1.Text = dgv_detalle_orden("DOT_tamaño_dot", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.cboTipoImpresion1_Detalle1.SelectedItem = dgv_detalle_orden("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(0).Index).Value

                    frm_Orden_Trabajo.txt_Papel1_Soporte1.Text = dgv_detalle_orden("DOT_papel_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_Papel2_Soporte1.Text = dgv_detalle_orden("DOT_papel_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_Papel3_Soporte1.Text = dgv_detalle_orden("DOT_papel_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                    frm_Orden_Trabajo.txt_Gramaje1_Soporte1.Text = dgv_detalle_orden("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_Gramaje2_Soporte1.Text = dgv_detalle_orden("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_Gramaje3_Soporte1.Text = dgv_detalle_orden("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                    frm_Orden_Trabajo.txt_Cantidad1_Soporte1.Text = dgv_detalle_orden("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_Cantidad2_Soporte1.Text = dgv_detalle_orden("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.txt_Cantidad3_Soporte1.Text = dgv_detalle_orden("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                    frm_Orden_Trabajo.cboFormato1_Soporte1.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.cboFormato2_Soporte1.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                    frm_Orden_Trabajo.cboFormato3_Soporte1.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                    frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedIndex = -1
                    frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1
                End If

                If flag2 = 1 Then
                    frm_Orden_Trabajo.txt_id_detalle_orden_trabajo2.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_cantidad2_detalle2.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(1).Index).Value
                    frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedValue = dgv_detalle_orden("PIE_id_pieza", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txtTamaño2_Detalle2.Text = dgv_detalle_orden("DOT_tamaño_dot", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.cboTipoImpresion2_Detalle2.SelectedItem = dgv_detalle_orden("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(1).Index).Value

                    frm_Orden_Trabajo.txt_Papel1_Soporte2.Text = dgv_detalle_orden("DOT_papel_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_Papel2_Soporte2.Text = dgv_detalle_orden("DOT_papel_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_Papel3_Soporte2.Text = dgv_detalle_orden("DOT_papel_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                    frm_Orden_Trabajo.txt_Gramaje1_Soporte2.Text = dgv_detalle_orden("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_Gramaje2_Soporte2.Text = dgv_detalle_orden("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_Gramaje3_Soporte2.Text = dgv_detalle_orden("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                    frm_Orden_Trabajo.txt_Cantidad1_Soporte2.Text = dgv_detalle_orden("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_Cantidad2_Soporte2.Text = dgv_detalle_orden("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.txt_Cantidad3_Soporte2.Text = dgv_detalle_orden("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                    frm_Orden_Trabajo.cboFormato1_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.cboFormato2_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                    frm_Orden_Trabajo.cboFormato3_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                    frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1

                End If

                If flag3 = 1 Then
                    frm_Orden_Trabajo.txt_id_detalle_orden_trabajo3.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_cantidad3_detalle3.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(2).Index).Value
                    frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedValue = dgv_detalle_orden("PIE_id_pieza", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txtTamaño3_Detalle3.Text = dgv_detalle_orden("DOT_tamaño_dot", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.cboTipoImpresion3_Detalle3.SelectedItem = dgv_detalle_orden("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(2).Index).Value

                    frm_Orden_Trabajo.txt_Papel1_Soporte3.Text = dgv_detalle_orden("DOT_papel_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_Papel2_Soporte3.Text = dgv_detalle_orden("DOT_papel_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_Papel3_Soporte3.Text = dgv_detalle_orden("DOT_papel_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                    frm_Orden_Trabajo.txt_Gramaje1_Soporte3.Text = dgv_detalle_orden("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_Gramaje2_Soporte3.Text = dgv_detalle_orden("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_Gramaje3_Soporte3.Text = dgv_detalle_orden("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                    frm_Orden_Trabajo.txt_Cantidad1_Soporte3.Text = dgv_detalle_orden("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_Cantidad2_Soporte3.Text = dgv_detalle_orden("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.txt_Cantidad3_Soporte3.Text = dgv_detalle_orden("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                    frm_Orden_Trabajo.cboFormato1_Soporte3.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.cboFormato2_Soporte3.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                    frm_Orden_Trabajo.cboFormato3_Soporte3.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(2).Index).Value
                End If
            End If
            frm_Orden_Trabajo.Show()
            Me.Close()
            frm_Orden_Trabajo.btnNueva_Orden_Trabajo.Enabled = False
            frm_Orden_Trabajo.btnGuardar_Orden_Trabajo.Enabled = False
        End If

    End Sub

    Private Sub txt_Buscar_orden_trabajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_Buscar_orden_trabajo.Text & "*"
        Dim consultaCliente = (From U In datacontext.ORDEN_TRABAJO
                              Join ort In datacontext.VENDEDOR
                              On U.VEN_id_vendedor Equals ort.VEN_id_vendedor
                              Join col In datacontext.CLIENTE
                              On col.CLI_id_cliente Equals U.CLI_id_cliente
                             Select U.ORT_id_orden_trabajo, U.ORT_fecha_ot, U.ORT_tipo_ot, U.ORT_numero_ot,
                             U.ORT_observaciones_ot, U.ORT_mejoras_ot, U.VEN_id_vendedor, ort.VEN_nombre_ven, U.CLI_id_cliente, col.CLI_razon_social
                              Where ORT_numero_ot Like buscar.ToString
                             Order By ORT_numero_ot Ascending)
        dgvLista_Orden_Trabajo.DataSource = consultaCliente
    End Sub

    Private Sub btn_cargar_detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Orden_Trabajo.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Orden.Click
        If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.ORDEN_TRABAJO Where C.ORT_id_orden_trabajo = CInt(dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la orden y su detalle correspondiente, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar orden y detalle")
                Case MsgBoxResult.Yes
                    datacontext.ORDEN_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La orden y su detalle han sido eliminadas")
                    cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar un orden")
        End If
    End Sub

    Private Sub dgvLista_Orden_Trabajo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Orden_Trabajo.CellDoubleClick

        'LLAMA AL FORMULARIO ACTUALIZAR TAREA
        If quienllamolistado_ot.Name = frm_Actualizar_Tarea.Name Then
            frm_Actualizar_Tarea.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
            frm_Actualizar_Tarea.txt_numero_orden.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

            'LLAMA AL FORMULARIO TAREA
        ElseIf quienllamolistado_ot.Name = frm_Tarea.Name Then

            Select Case quienllamoboton.Name
                Case frm_Tarea.btnBuscar_Numero_Orden1.Name
                    frm_Tarea.txt_id_orden_trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo1.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden2.Name
                    frm_Tarea.txt_id_orden_trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo2.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden3.Name
                    frm_Tarea.txt_id_orden_trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo3.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden4.Name
                    frm_Tarea.txt_id_orden_trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo4.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden5.Name
                    frm_Tarea.txt_id_orden_trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo5.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden6.Name
                    frm_Tarea.txt_id_orden_trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo6.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden7.Name
                    frm_Tarea.txt_id_orden_trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo7.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden8.Name
                    frm_Tarea.txt_id_orden_trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo8.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden9.Name
                    frm_Tarea.txt_id_orden_trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo9.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden10.Name
                    frm_Tarea.txt_id_orden_trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo10.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden11.Name
                    frm_Tarea.txt_id_orden_trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo11.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden12.Name
                    frm_Tarea.txt_id_orden_trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo12.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden13.Name
                    frm_Tarea.txt_id_orden_trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo13.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden14.Name
                    frm_Tarea.txt_id_orden_trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo14.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden15.Name
                    frm_Tarea.txt_id_orden_trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo15.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden16.Name
                    frm_Tarea.txt_id_orden_trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo16.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden17.Name
                    frm_Tarea.txt_id_orden_trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo17.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden18.Name
                    frm_Tarea.txt_id_orden_trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo18.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden19.Name
                    frm_Tarea.txt_id_orden_trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo19.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value

                Case frm_Tarea.btnBuscar_Numero_Orden20.Name
                    frm_Tarea.txt_id_orden_trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
                    frm_Tarea.txtNumero_Orden_Trabajo20.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
            End Select
        End If

        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'FUNCIONA BIEN
    Private Sub btnEliminar_Detalle_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar_Detalle.Click
        If dgv_detalle_orden.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.DETALLE_ORDEN_TRABAJO Where C.id_detalle_orden_trabajo = CInt(dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgv_detalle_orden.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el detalle seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar detalle de la orden")
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

    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click
        'CARGA COMBOBOX PIEZA DETALLE 1
        Dim combopieza1 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas1_Detalle1.DataSource = combopieza1
        frm_Orden_Trabajo.cboPiezas1_Detalle1.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas1_Detalle1.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA DETALLE 2
        Dim combopieza2 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas2_Detalle2.DataSource = combopieza2
        frm_Orden_Trabajo.cboPiezas2_Detalle2.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas2_Detalle2.ValueMember = "PIE_id_pieza"

        'CARGA COMBOBOX PIEZA DETALLE 3
        Dim combopieza3 = (From sec In datacontext.PIEZA
                           Select sec.PIE_id_pieza, sec.PIE_nombre_pie
                           Order By PIE_nombre_pie Ascending)
        frm_Orden_Trabajo.cboPiezas3_Detalle3.DataSource = combopieza3
        frm_Orden_Trabajo.cboPiezas3_Detalle3.DisplayMember = "PIE_nombre_pie"
        frm_Orden_Trabajo.cboPiezas3_Detalle3.ValueMember = "PIE_id_pieza"

        vble_id_orden = dgvLista_Orden_Trabajo.Item("ORT_id_orden_trabajo", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

        'LLENA LOS CAMPOS DE LA ORDEN
        If dgvLista_Orden_Trabajo.SelectedRows.Count > 0 Then
            frm_Orden_Trabajo.txt_id_orden_trabajo.Text = vble_id_orden
            frm_Orden_Trabajo.cboTipo_Orden.SelectedItem = dgvLista_Orden_Trabajo.Item("ORT_tipo_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_numero_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.dtpFecha_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.Item("ORT_fecha_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_id_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_id_cliente", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_nombre_cliente.Text = dgvLista_Orden_Trabajo.Item("CLI_razon_social", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txtid_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_id_vendedor", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txtNombre_vendedor.Text = dgvLista_Orden_Trabajo.Item("VEN_nombre_ven", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_observaciones.Text = dgvLista_Orden_Trabajo.Item("ORT_observaciones_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value
            frm_Orden_Trabajo.txt_mejoras.Text = dgvLista_Orden_Trabajo.Item("ORT_mejoras_ot", dgvLista_Orden_Trabajo.SelectedRows(0).Index).Value

            Dim flag1, flag2, flag3 As Integer

            If dgv_detalle_orden.RowCount = 1 Then
                flag1 = 1
                flag2 = 0
                flag3 = 0
            ElseIf dgv_detalle_orden.RowCount = 2 Then
                flag1 = 1
                flag2 = 1
                flag3 = 0
            ElseIf dgv_detalle_orden.RowCount = 3 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
            End If

            If flag1 = 1 Then
                frm_Orden_Trabajo.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_cantidad1_detalle1.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(0).Index).Value
                frm_Orden_Trabajo.cboPiezas1_Detalle1.SelectedValue = dgv_detalle_orden("PIE_id_pieza", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txtTamaño1_Detalle1.Text = dgv_detalle_orden("DOT_tamaño_dot", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.cboTipoImpresion1_Detalle1.SelectedItem = dgv_detalle_orden("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.txt_Papel1_Soporte1.Text = dgv_detalle_orden("DOT_papel_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Papel2_Soporte1.Text = dgv_detalle_orden("DOT_papel_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Papel3_Soporte1.Text = dgv_detalle_orden("DOT_papel_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.txt_Gramaje1_Soporte1.Text = dgv_detalle_orden("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Gramaje2_Soporte1.Text = dgv_detalle_orden("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Gramaje3_Soporte1.Text = dgv_detalle_orden("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.txt_Cantidad1_Soporte1.Text = dgv_detalle_orden("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Cantidad2_Soporte1.Text = dgv_detalle_orden("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.txt_Cantidad3_Soporte1.Text = dgv_detalle_orden("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.cboFormato1_Soporte1.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.cboFormato2_Soporte1.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(0).Index).Value
                frm_Orden_Trabajo.cboFormato3_Soporte1.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(0).Index).Value

                frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedIndex = -1
                frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1
            End If

            If flag2 = 1 Then
                frm_Orden_Trabajo.txt_id_detalle_orden_trabajo2.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_cantidad2_detalle2.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(1).Index).Value
                frm_Orden_Trabajo.cboPiezas2_Detalle2.SelectedValue = dgv_detalle_orden("PIE_id_pieza", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txtTamaño2_Detalle2.Text = dgv_detalle_orden("DOT_tamaño_dot", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.cboTipoImpresion2_Detalle2.SelectedItem = dgv_detalle_orden("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.txt_Papel1_Soporte2.Text = dgv_detalle_orden("DOT_papel_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Papel2_Soporte2.Text = dgv_detalle_orden("DOT_papel_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Papel3_Soporte2.Text = dgv_detalle_orden("DOT_papel_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.txt_Gramaje1_Soporte2.Text = dgv_detalle_orden("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Gramaje2_Soporte2.Text = dgv_detalle_orden("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Gramaje3_Soporte2.Text = dgv_detalle_orden("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.txt_Cantidad1_Soporte2.Text = dgv_detalle_orden("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Cantidad2_Soporte2.Text = dgv_detalle_orden("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.txt_Cantidad3_Soporte2.Text = dgv_detalle_orden("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.cboFormato1_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.cboFormato2_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(1).Index).Value
                frm_Orden_Trabajo.cboFormato3_Soporte2.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(1).Index).Value

                frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedIndex = -1

            End If

            If flag3 = 1 Then
                frm_Orden_Trabajo.txt_id_detalle_orden_trabajo3.Text = dgv_detalle_orden.Item("id_detalle_orden_trabajo", dgvLista_Orden_Trabajo.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_cantidad3_detalle3.Text = dgv_detalle_orden.Item("DOT_cantidad_dot", dgvLista_Orden_Trabajo.Rows(2).Index).Value
                frm_Orden_Trabajo.cboPiezas3_Detalle3.SelectedValue = dgv_detalle_orden("PIE_id_pieza", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txtTamaño3_Detalle3.Text = dgv_detalle_orden("DOT_tamaño_dot", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.cboTipoImpresion3_Detalle3.SelectedItem = dgv_detalle_orden("DOT_tipo_impresion_dot", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.txt_Papel1_Soporte3.Text = dgv_detalle_orden("DOT_papel_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Papel2_Soporte3.Text = dgv_detalle_orden("DOT_papel_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Papel3_Soporte3.Text = dgv_detalle_orden("DOT_papel_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.txt_Gramaje1_Soporte3.Text = dgv_detalle_orden("DOT_gramaje_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Gramaje2_Soporte3.Text = dgv_detalle_orden("DOT_gramaje_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Gramaje3_Soporte3.Text = dgv_detalle_orden("DOT_gramaje_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.txt_Cantidad1_Soporte3.Text = dgv_detalle_orden("DOT_cantidad_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Cantidad2_Soporte3.Text = dgv_detalle_orden("DOT_cantidad_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.txt_Cantidad3_Soporte3.Text = dgv_detalle_orden("DOT_cantidad_soporte_3", dgv_detalle_orden.Rows(2).Index).Value

                frm_Orden_Trabajo.cboFormato1_Soporte3.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_1", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.cboFormato2_Soporte3.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_2", dgv_detalle_orden.Rows(2).Index).Value
                frm_Orden_Trabajo.cboFormato3_Soporte3.SelectedItem = dgv_detalle_orden("DOT_formato_soporte_3", dgv_detalle_orden.Rows(2).Index).Value
            End If
        End If
        Me.Close()
        frm_Orden_Trabajo.btnNueva_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnGuardar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnActualizar_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.GroupProducto1.Enabled = False
        frm_Orden_Trabajo.GroupProducto2.Enabled = False
        frm_Orden_Trabajo.GroupProducto3.Enabled = False
        frm_Orden_Trabajo.txt_observaciones.Enabled = False
        frm_Orden_Trabajo.txt_mejoras.Enabled = False
        frm_Orden_Trabajo.cboTipo_Orden.Enabled = False
        frm_Orden_Trabajo.dtpFecha_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.txtNumero_Orden_Trabajo.Enabled = False
        frm_Orden_Trabajo.btnBuscar_cliente.Enabled = False
        frm_Orden_Trabajo.btnBuscar_Vendedor.Enabled = False
        frm_Orden_Trabajo.btnImprimir.enabled = True
        frm_Orden_Trabajo.Show()
    End Sub

    Private Sub dgv_detalle_orden_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_detalle_orden.CellDoubleClick
        quienllamolistado_ot.Name = frm_retrabajo.Name
        frm_retrabajo.txt_id_orden_trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(0).Value
        frm_retrabajo.txtNumero_Orden_Trabajo.Text = dgvLista_Orden_Trabajo.SelectedCells(2).Value
        frm_retrabajo.txt_cantidad_original.Text = dgv_detalle_orden.SelectedCells(11).Value
        frm_retrabajo.cboPiezas1_Detalle1.Text = dgv_detalle_orden.SelectedCells(9).Value
        frm_retrabajo.txtTamaño1_Detalle1.Text = dgv_detalle_orden.SelectedCells(12).Value
        frm_retrabajo.cboTipoImpresion1_Detalle1.Text = dgv_detalle_orden.SelectedCells(13).Value
        frm_retrabajo.txt_id_detalle_orden_trabajo1.Text = dgv_detalle_orden.SelectedCells(10).Value
        frm_retrabajo.dtp_Fecha_Original.Text = dgvLista_Orden_Trabajo.SelectedCells(3).Value
        Me.Close()
    End Sub

   
End Class