Imports System.IO
Imports System.Text

Public Class frm_Listado_Retrabajo

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub frm_Listado_Retrabajo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ArmaGrillaRetrabajo()
        CargarGrillaRetrabajo()
        lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
        dgvLista_ReTrabajos.ClearSelection()
    End Sub

    Public Sub CargarGrillaRetrabajo()
        Dim carga = (From dot In datacontext.DETALLE_ORDEN_TRABAJO
                                    Join ret In datacontext.RE_TRABAJO
                                    On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
                                    Join ort In datacontext.ORDEN_TRABAJO
                                    On ort.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
                                    Join pie In datacontext.PIEZA
                                    On pie.PIE_id_pieza Equals dot.PIE_id_pieza
                                            Select ret.RET_id_retrabajo,
                                    dot.PIE_id_pieza,
                                    pie.PIE_nombre_pie,
                                    ort.ORT_numero_ot,
                                    ret.RET_cantidad_dort,
                                    ret.RET_tamaño_dort,
                                    ret.RET_tipo_impresion_dort,
                                    ret.RET_origen_area,
                                    ret.RET_procedimiento,
                                    ret.RET_fecha,
                                    ret.RET_papel_soporte_1,
                                    ret.RET_papel_soporte_2,
                                    ret.RET_papel_soporte_3,
                                    ret.RET_gramaje_soporte_1,
                                    ret.RET_gramaje_soporte_2,
                                    ret.RET_gramaje_soporte_3,
                                    ret.RET_cantidad_soporte_1,
                                    ret.RET_cantidad_soporte_2,
                                    ret.RET_cantidad_soporte_3,
                                    ret.RET_formato_soporte_1,
                                    ret.RET_formato_soporte_2,
                                    ret.RET_formato_soporte_3,
                                    ort.ORT_id_orden_trabajo,
                                    dot.id_detalle_orden_trabajo,
                                    ort.ORT_fecha_ot,
                                    dot.DOT_cantidad_dot, dot.DOT_tamaño_dot
                                            Order By ORT_numero_ot Ascending)
        dgvLista_ReTrabajos.DataSource = carga
    End Sub

    Private Sub ArmaGrillaRetrabajo()
        dgvLista_ReTrabajos.Enabled = True
        dgvLista_ReTrabajos.AutoGenerateColumns = False
        dgvLista_ReTrabajos.Columns.Clear()

        dgvLista_ReTrabajos.Columns.Add("RET_id_retrabajo", "id_retrabajo")
        dgvLista_ReTrabajos.Columns.Add("ORT_numero_ot", "Número de Orden")
        dgvLista_ReTrabajos.Columns.Add("PIE_id_pieza", "id_pieza")
        dgvLista_ReTrabajos.Columns.Add("PIE_nombre_pie", "Pieza")
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_dort", "Cantidad")
        dgvLista_ReTrabajos.Columns.Add("DOT_tamaño_dot", "Tamaño")
        dgvLista_ReTrabajos.Columns.Add("RET_tipo_impresion_dort", "Tipo Impresión")
        dgvLista_ReTrabajos.Columns.Add("RET_origen_area", "Origen")
        dgvLista_ReTrabajos.Columns.Add("RET_procedimiento", "Procedimiento")
        dgvLista_ReTrabajos.Columns.Add("RET_fecha", "Fecha")
        dgvLista_ReTrabajos.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")

        dgvLista_ReTrabajos.Columns.Add("RET_papel_soporte_1", "Papel")
        dgvLista_ReTrabajos.Columns.Add("RET_gramaje_soporte_1", "Gramaje")
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_soporte_1", "Cantidad")
        dgvLista_ReTrabajos.Columns.Add("RET_formato_soporte_1", "Formato")

        dgvLista_ReTrabajos.Columns.Add("RET_papel_soporte_2", "Papel")
        dgvLista_ReTrabajos.Columns.Add("RET_gramaje_soporte_2", "Gramaje")
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_soporte_2", "Cantidad")
        dgvLista_ReTrabajos.Columns.Add("RET_formato_soporte_2", "Formato")

        dgvLista_ReTrabajos.Columns.Add("RET_papel_soporte_3", "Papel")
        dgvLista_ReTrabajos.Columns.Add("RET_gramaje_soporte_3", "Gramaje")
        dgvLista_ReTrabajos.Columns.Add("RET_cantidad_soporte_3", "Cantidad")
        dgvLista_ReTrabajos.Columns.Add("RET_formato_soporte_3", "Formato")
        dgvLista_ReTrabajos.Columns.Add("DOT_cantidad_dot", "Cantidad Original")
        dgvLista_ReTrabajos.Columns.Add("ORT_fecha_ot", "Fecha Original")


        dgvLista_ReTrabajos.Columns(0).DataPropertyName = "RET_id_retrabajo"
        dgvLista_ReTrabajos.Columns(0).Visible = False
        dgvLista_ReTrabajos.Columns(1).DataPropertyName = "ORT_numero_ot"
        dgvLista_ReTrabajos.Columns(2).DataPropertyName = "PIE_id_pieza"
        dgvLista_ReTrabajos.Columns(2).Visible = False
        dgvLista_ReTrabajos.Columns(3).DataPropertyName = "PIE_nombre_pie"
        dgvLista_ReTrabajos.Columns(4).DataPropertyName = "RET_cantidad_dort"
        dgvLista_ReTrabajos.Columns(5).DataPropertyName = "DOT_tamaño_dot"
        dgvLista_ReTrabajos.Columns(6).DataPropertyName = "RET_tipo_impresion_dort"
        dgvLista_ReTrabajos.Columns(7).DataPropertyName = "RET_origen_area"
        dgvLista_ReTrabajos.Columns(8).DataPropertyName = "RET_procedimiento"
        dgvLista_ReTrabajos.Columns(9).DataPropertyName = "RET_fecha"
        dgvLista_ReTrabajos.Columns(10).DataPropertyName = "ORT_id_orden_trabajo"
        dgvLista_ReTrabajos.Columns(10).Visible = False
        dgvLista_ReTrabajos.Columns(11).DataPropertyName = "RET_papel_soporte_1"
        dgvLista_ReTrabajos.Columns(12).DataPropertyName = "RET_gramaje_soporte_1"
        dgvLista_ReTrabajos.Columns(13).DataPropertyName = "RET_cantidad_soporte_1"
        dgvLista_ReTrabajos.Columns(14).DataPropertyName = "RET_formato_soporte_1"

        dgvLista_ReTrabajos.Columns(15).DataPropertyName = "RET_papel_soporte_2"
        dgvLista_ReTrabajos.Columns(15).Visible = False
        dgvLista_ReTrabajos.Columns(16).DataPropertyName = "RET_gramaje_soporte_2"
        dgvLista_ReTrabajos.Columns(16).Visible = False
        dgvLista_ReTrabajos.Columns(17).DataPropertyName = "RET_cantidad_soporte_2"
        dgvLista_ReTrabajos.Columns(17).Visible = False
        dgvLista_ReTrabajos.Columns(18).DataPropertyName = "RET_formato_soporte_2"
        dgvLista_ReTrabajos.Columns(18).Visible = False

        dgvLista_ReTrabajos.Columns(19).DataPropertyName = "RET_papel_soporte_3"
        dgvLista_ReTrabajos.Columns(19).Visible = False
        dgvLista_ReTrabajos.Columns(20).DataPropertyName = "RET_gramaje_soporte_3"
        dgvLista_ReTrabajos.Columns(20).Visible = False
        dgvLista_ReTrabajos.Columns(21).DataPropertyName = "RET_cantidad_soporte_3"
        dgvLista_ReTrabajos.Columns(21).Visible = False
        dgvLista_ReTrabajos.Columns(22).DataPropertyName = "RET_formato_soporte_3"
        dgvLista_ReTrabajos.Columns(22).Visible = False
        dgvLista_ReTrabajos.Columns(23).DataPropertyName = "DOT_cantidad_dot"
        'dgvLista_ReTrabajos.Columns(23).Visible = False
        dgvLista_ReTrabajos.Columns(24).DataPropertyName = "ORT_fecha_ot"
        ' dgvLista_ReTrabajos.Columns(24).Visible = False


    End Sub

    Private Sub btnEliminar_Colaborador_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar_ReTrabajo.Click

        If dgvLista_ReTrabajos.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.RE_TRABAJO Where C.RET_id_retrabajo = CInt(dgvLista_ReTrabajos.Item("RET_id_retrabajo", dgvLista_ReTrabajos.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el ReTrabajo seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar ReTrabajo")
                Case MsgBoxResult.Yes
                    datacontext.RE_TRABAJO.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El ReTrabajo ha sido eliminado")
                    CargarGrillaRetrabajo()
                    lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
            End Select
        Else
            MsgBox("Debe seleccionar un ReTrabajo")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click
        'LLENA LOS CAMPOS DE LA ORDEN
        If dgvLista_ReTrabajos.SelectedRows.Count > 0 Then
            frm_retrabajo.txt_id_re_trabajo.Text = dgvLista_ReTrabajos.Item("RET_id_retrabajo", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txtNumero_Orden_Trabajo.Text = dgvLista_ReTrabajos.Item("ORT_numero_ot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.cboPiezas1_Detalle1.SelectedText = dgvLista_ReTrabajos.Item("PIE_nombre_pie", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_cantidad_original.Text = dgvLista_ReTrabajos.Item("DOT_cantidad_dot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txtTamaño1_Detalle1.Text = dgvLista_ReTrabajos.Item("DOT_tamaño_dot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.cboTipoImpresion1_Detalle1.Text = dgvLista_ReTrabajos.Item("RET_tipo_impresion_dort", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_origen.Text = dgvLista_ReTrabajos.Item("RET_origen_area", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_procedimiento.Text = dgvLista_ReTrabajos.Item("RET_procedimiento", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.dtp_Fecha_Original.Text = dgvLista_ReTrabajos.Item("ORT_fecha_ot", dgvLista_ReTrabajos.SelectedRows(0).Index).Value
            frm_retrabajo.txt_id_orden_trabajo.Text = dgvLista_ReTrabajos.Item("ORT_id_orden_trabajo", dgvLista_ReTrabajos.Rows(0).Index).Value

            frm_retrabajo.txt_cantidad_retrabajo.Text = dgvLista_ReTrabajos.Item("RET_cantidad_dort", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.dtpFecha_Re_Trabajo.Text = dgvLista_ReTrabajos.Item("RET_fecha", dgvLista_ReTrabajos.Rows(0).Index).Value

            frm_retrabajo.txt_Papel1_Soporte1.Text = dgvLista_ReTrabajos.Item("RET_papel_soporte_1", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Gramaje1_Soporte1.Text = dgvLista_ReTrabajos("RET_gramaje_soporte_1", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Cantidad1_Soporte1.Text = dgvLista_ReTrabajos("RET_cantidad_soporte_1", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.cboFormato1_Soporte1.Text = dgvLista_ReTrabajos("RET_formato_soporte_1", dgvLista_ReTrabajos.Rows(0).Index).Value

            frm_retrabajo.txt_Papel2_Soporte1.Text = dgvLista_ReTrabajos.Item("RET_papel_soporte_2", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Gramaje2_Soporte1.Text = dgvLista_ReTrabajos("RET_gramaje_soporte_2", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Cantidad2_Soporte1.Text = dgvLista_ReTrabajos("RET_cantidad_soporte_2", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.cboFormato2_Soporte1.Text = dgvLista_ReTrabajos("RET_formato_soporte_2", dgvLista_ReTrabajos.Rows(0).Index).Value

            frm_retrabajo.txt_Papel3_Soporte1.Text = dgvLista_ReTrabajos.Item("RET_papel_soporte_3", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Gramaje3_Soporte1.Text = dgvLista_ReTrabajos("RET_gramaje_soporte_3", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.txt_Cantidad3_Soporte1.Text = dgvLista_ReTrabajos("RET_cantidad_soporte_3", dgvLista_ReTrabajos.Rows(0).Index).Value
            frm_retrabajo.cboFormato3_Soporte1.Text = dgvLista_ReTrabajos("RET_formato_soporte_3", dgvLista_ReTrabajos.Rows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un ReTrabajo")
            Exit Sub
        End If
        frm_retrabajo.btnGuardar_ReTrabajo.Enabled = False
        frm_retrabajo.btnImprimir.Enabled = True
        frm_retrabajo.btnBuscar_Numero_Orden1.Enabled = False
        frm_retrabajo.txt_cantidad_original.Enabled = False
        frm_retrabajo.txtNumero_Orden_Trabajo.Enabled = False
        frm_retrabajo.txt_origen.Enabled = False
        frm_retrabajo.txt_procedimiento.Enabled = False
        frm_retrabajo.dtp_Fecha_Original.Enabled = False
        frm_retrabajo.Label1.Visible = False
        frm_retrabajo.GroupProducto1.Enabled = False
        frm_retrabajo.txt_id_re_trabajo.Visible = False
        lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
        frm_retrabajo.Show()
    End Sub

    Private Sub rbtNumeroOrden_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNumeroOrden.CheckedChanged
        cboBuscar_Mes.Enabled = False
        cboBuscar_Mes.SelectedIndex = -1
        txt_Buscar_ReTrabajo.Enabled = True
    End Sub

    Private Sub rbtMes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMes.CheckedChanged
        cboBuscar_Mes.Enabled = True
        txt_Buscar_ReTrabajo.Enabled = False
        txt_Buscar_ReTrabajo.Clear()
    End Sub

    Private Sub txt_Buscar_ReTrabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_ReTrabajo.TextChanged
        Dim buscar As String
        If rbtNumeroOrden.Checked = True Then
            ArmaGrillaRetrabajo()
            buscar = Me.txt_Buscar_ReTrabajo.Text & "*"
            Dim consultaalu =
                 (From dot In datacontext.DETALLE_ORDEN_TRABAJO
                                        Join ret In datacontext.RE_TRABAJO
                                        On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
                                        Join ort In datacontext.ORDEN_TRABAJO
                                        On ort.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
                                        Join pie In datacontext.PIEZA
                                        On pie.PIE_id_pieza Equals dot.PIE_id_pieza
                                                Select ret.RET_id_retrabajo,
                                        dot.PIE_id_pieza,
                                        pie.PIE_nombre_pie,
                                        ort.ORT_numero_ot,
                                        ret.RET_cantidad_dort,
                                        ret.RET_tamaño_dort,
                                        ret.RET_tipo_impresion_dort,
                                        ret.RET_origen_area,
                                        ret.RET_procedimiento,
                                        ret.RET_fecha,
                                        ret.RET_papel_soporte_1,
                                        ret.RET_papel_soporte_2,
                                        ret.RET_papel_soporte_3,
                                        ret.RET_gramaje_soporte_1,
                                        ret.RET_gramaje_soporte_2,
                                        ret.RET_gramaje_soporte_3,
                                        ret.RET_cantidad_soporte_1,
                                        ret.RET_cantidad_soporte_2,
                                        ret.RET_cantidad_soporte_3,
                                        ret.RET_formato_soporte_1,
                                        ret.RET_formato_soporte_2,
                                        ret.RET_formato_soporte_3,
                                        ort.ORT_id_orden_trabajo,
                                        dot.id_detalle_orden_trabajo
                                        Where ORT_numero_ot Like buscar.ToString
                                        Order By ORT_numero_ot Ascending)
            dgvLista_ReTrabajos.DataSource = consultaalu
            lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
        End If
    End Sub

    Private Sub cboBuscar_Mes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboBuscar_Mes.SelectedIndexChanged
        If rbtMes.Checked = True Then
            Dim buscar As String
            ArmaGrillaRetrabajo()
            buscar = Me.cboBuscar_Mes.SelectedItem & "*"
            Dim consultaalu =
                 (From dot In datacontext.DETALLE_ORDEN_TRABAJO
                                        Join ret In datacontext.RE_TRABAJO
                                        On dot.id_detalle_orden_trabajo Equals ret.id_detalle_orden_trabajo
                                        Join ort In datacontext.ORDEN_TRABAJO
                                        On ort.ORT_id_orden_trabajo Equals dot.ORT_id_orden_trabajo
                                        Join pie In datacontext.PIEZA
                                        On pie.PIE_id_pieza Equals dot.PIE_id_pieza
                                        Select ret.RET_id_retrabajo,
                                        dot.PIE_id_pieza,
                                        pie.PIE_nombre_pie,
                                        ort.ORT_numero_ot,
                                        ret.RET_cantidad_dort,
                                        ret.RET_tamaño_dort,
                                        ret.RET_tipo_impresion_dort,
                                        ret.RET_origen_area,
                                        ret.RET_procedimiento,
                                        ret.RET_fecha,
                                        ret.RET_papel_soporte_1,
                                        ret.RET_papel_soporte_2,
                                        ret.RET_papel_soporte_3,
                                        ret.RET_gramaje_soporte_1,
                                        ret.RET_gramaje_soporte_2,
                                        ret.RET_gramaje_soporte_3,
                                        ret.RET_cantidad_soporte_1,
                                        ret.RET_cantidad_soporte_2,
                                        ret.RET_cantidad_soporte_3,
                                        ret.RET_formato_soporte_1,
                                        ret.RET_formato_soporte_2,
                                        ret.RET_formato_soporte_3,
                                        ort.ORT_id_orden_trabajo,
                                        dot.id_detalle_orden_trabajo
                                        Where (RET_fecha.Value.Month = cboBuscar_Mes.SelectedIndex + 1))
            dgvLista_ReTrabajos.DataSource = consultaalu
            lblTotal_Retrabajo.Text = dgvLista_ReTrabajos.Rows.Count
        End If
    End Sub

    Private Sub btnGenerarInforme_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarInforme.Click

        Dim consulta As String = "consulta_retrabajo_" + Date.Now.Millisecond.ToString + ".csv"
        ' Dim consulta1 As String = "consulta_total_mensual_" + Date.Now.Millisecond.ToString + ".csv"
        Dim filePath As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta
        ' Dim filePath1 As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta1
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        Try
            For i As Integer = 0 To dgvLista_ReTrabajos.Rows.Count - 1
                Dim array As String() = New String(dgvLista_ReTrabajos.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dgvLista_ReTrabajos.Columns.Count - 1
                        array(j) = dgvLista_ReTrabajos.Columns(j).HeaderText
                    Next
                    sb.AppendLine(String.Join(delimeter, array))
                End If
                For j As Integer = 0 To dgvLista_ReTrabajos.Columns.Count - 1

                    If Not dgvLista_ReTrabajos.Rows(i).IsNewRow Then

                        If dgvLista_ReTrabajos.Columns(j).HeaderText = "Fecha" Or dgvLista_ReTrabajos.Columns(j).HeaderText = "Colaborador" Then
                            array(j) = dgvLista_ReTrabajos(j, i).Value.ToString
                        Else
                            array(j) = Microsoft.VisualBasic.Right("   " + dgvLista_ReTrabajos(j, i).Value.ToString, 3)
                        End If
                    End If
                Next
                If Not dgvLista_ReTrabajos.Rows(i).IsNewRow Then
                    sb.AppendLine(String.Join(delimeter, array))
                End If
            Next
            File.WriteAllText(filePath, sb.ToString)
            ' File.WriteAllText(filePath1, sb1.ToString)
            ' File.AppendAllText(filePath, sb1.ToString)
            MsgBox("La consulta se ha generado correctamente")
            ' Process.Start(filePath)
            Me.Close()
        Catch ex As Exception
            MsgBox("Hubo un error al generar la consulta")
        End Try
    End Sub
End Class
