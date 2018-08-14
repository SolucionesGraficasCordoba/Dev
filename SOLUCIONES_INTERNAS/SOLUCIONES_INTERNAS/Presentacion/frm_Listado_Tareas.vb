Public Class frm_Listado_Tareas
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Public vble_id_colaborador As Integer 'Guarda el id de un personal
    ' Dim vble_colaborador As Integer 'Guarda el id de un horario
    Dim vble_colaborador, vble_fecha As String

    Private Sub frm_Listado_Tareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        dgvColaboradores.ClearSelection()
        Label6.Text = dgvColaboradores.Rows.Count
        'CARGA COMBOBOX SECTOR
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)

        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = -1
    End Sub

    Private Sub armargrillacolaborador()
        dgvColaboradores.Enabled = True
        dgvColaboradores.AutoGenerateColumns = False
        dgvColaboradores.Columns.Clear()

        dgvColaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvColaboradores.Columns.Add("COL_nombre_col", "Colaborador")
        dgvColaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvColaboradores.Columns(0).Visible = False
        dgvColaboradores.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvColaboradores.Columns(1).Width = 300

    End Sub

    Private Sub btnEliminar_Tarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Tarea.Click
        If dgvColaboradores.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.TAREA Where C.TAR_id_tarea = CInt(dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la tares seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar tarea")
                Case MsgBoxResult.Yes
                    datacontext.TAREA.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La tarea ha sido eliminada")

            End Select
        Else
            MsgBox("Debe seleccionar una tarea")
        End If
    End Sub

    'CARGA COLABORADOR DATAGRIDVIEW SEGUN LO QUE SELECCIONO EN EL COMBOBOX
    Private Sub cbo_sector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_sector.SelectedIndexChanged
        armargrillacolaborador()

        Dim consultaporsector = (From A In datacontext.SECTOR
                               Join C In datacontext.COLABORADOR
                               On A.SEC_id_sector Equals C.SEC_id_sector
                               Select C.COL_id_colaborador, C.COL_nombre_col, A.SEC_id_sector, A.SEC_nombre_sector
                               Where (SEC_id_sector = cbo_sector.SelectedIndex + 1)
                               Order By COL_nombre_col Ascending)
        dgvColaboradores.DataSource = consultaporsector
        Label6.Text = dgvColaboradores.Rows.Count
    End Sub

    Public Sub dgvColaboradores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColaboradores.CellClick

        If dgvColaboradores.SelectedRows.Count > 0 Then
            vble_id_colaborador = dgvColaboradores.Item("COL_id_colaborador", dgvColaboradores.SelectedRows(0).Index).Value
        End If
        vble_colaborador = dgvColaboradores.Item("COL_nombre_col", dgvColaboradores.SelectedRows(0).Index).Value
        vble_fecha = dtpFecha.Text
        Dim datagridtarea = (From o In datavistas.Vista_Tarea_x_Colaborador
                           Select o.TAR_id_tarea, o.TAR_detalle_tarea, o.TAR_tiempo_estimado, o.TAR_tiempo_real,
                           o.TAR_observaciones, o.ORT_id_orden_trabajo, o.ORT_numero_ot, o.TAR_fecha, o.TAR_carga_horaria, o.TAR_hora_fin, o.Expr1, o.COL_nombre_col
                           Where COL_nombre_col = vble_colaborador And TAR_fecha = vble_fecha)
        mostrargrillaobligaciones(datagridtarea)
        Label1.Text = dgvTarea_x_Colaborador.Rows.Count
    End Sub


    Public Sub mostrargrillaobligaciones(ByVal datasource As System.Linq.IQueryable)
        dgvTarea_x_Colaborador.AutoGenerateColumns = False
        dgvTarea_x_Colaborador.Columns.Clear()

        dgvTarea_x_Colaborador.Columns.Add("TAR_id_tarea", "id_tarea")
        dgvTarea_x_Colaborador.Columns.Add("TAR_detalle_tarea", "Tarea")
        dgvTarea_x_Colaborador.Columns.Add("TAR_tiempo_estimado", "Tiempo Estimado")
        dgvTarea_x_Colaborador.Columns.Add("TAR_tiempo_real", "Tiempo Real")
        dgvTarea_x_Colaborador.Columns.Add("TAR_observaciones", "Observaciones")
        dgvTarea_x_Colaborador.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgvTarea_x_Colaborador.Columns.Add("ORT_numero_ot", "Número de orden")
        dgvTarea_x_Colaborador.Columns.Add("TAR_fecha", "Fecha")
        dgvTarea_x_Colaborador.Columns.Add("TAR_carga_horaria", "Carga Horaria")
        dgvTarea_x_Colaborador.Columns.Add("TAR_hora_fin", "Hora de finalización")
        dgvTarea_x_Colaborador.Columns.Add("Expr1", "id_colaborador")
        dgvTarea_x_Colaborador.Columns.Add("COL_nombre_col", "Colaborador")

        dgvTarea_x_Colaborador.Columns(0).DataPropertyName = "TAR_id_tarea"
        dgvTarea_x_Colaborador.Columns(0).Visible = False
        dgvTarea_x_Colaborador.Columns(1).DataPropertyName = "TAR_detalle_tarea"
        dgvTarea_x_Colaborador.Columns(1).Width = 200
        dgvTarea_x_Colaborador.Columns(2).DataPropertyName = "TAR_tiempo_estimado"
        dgvTarea_x_Colaborador.Columns(3).DataPropertyName = "TAR_tiempo_real"
        dgvTarea_x_Colaborador.Columns(4).DataPropertyName = "TAR_observaciones"
        dgvTarea_x_Colaborador.Columns(5).DataPropertyName = "ORT_id_orden_trabajo"
        dgvTarea_x_Colaborador.Columns(5).Visible = False
        dgvTarea_x_Colaborador.Columns(6).DataPropertyName = "ORT_numero_ot"
        dgvTarea_x_Colaborador.Columns(6).Visible = False
        dgvTarea_x_Colaborador.Columns(7).DataPropertyName = "TAR_fecha"
        dgvTarea_x_Colaborador.Columns(7).Visible = False
        dgvTarea_x_Colaborador.Columns(8).DataPropertyName = "TAR_carga_horaria"
        dgvTarea_x_Colaborador.Columns(8).Visible = False
        dgvTarea_x_Colaborador.Columns(9).DataPropertyName = "TAR_hora_fin"
        dgvTarea_x_Colaborador.Columns(10).DataPropertyName = "Expr1"
        dgvTarea_x_Colaborador.Columns(10).Visible = False
        dgvTarea_x_Colaborador.Columns(11).DataPropertyName = "COL_nombre_col"
        dgvTarea_x_Colaborador.Columns(11).Visible = False

        dgvTarea_x_Colaborador.DataSource = datasource
        dgvTarea_x_Colaborador.ClearSelection()

    End Sub
 
    Private Sub btnModificar_Tarea_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar_Tarea.Click
        If Me.dgvTarea_x_Colaborador.SelectedRows.Count > 0 Then
            frm_Actualizar_Tarea.txt_id_tarea.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_tarea.Text = Me.dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_tiempo_estimado.Text = Me.dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_tiempo_real.Text = Me.dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_observaciones.Text = Me.dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_id_orden_trabajo.Text = Me.dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_numero_orden.Text = Me.dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.dtpFecha.Text = Me.dgvTarea_x_Colaborador.Item("TAR_fecha", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_Carga_Horaria.Text = Me.dgvTarea_x_Colaborador.Item("TAR_carga_horaria", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_hora_fin.Text = Me.dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_id_colaborador.Text = Me.dgvTarea_x_Colaborador.Item("Expr1", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_nombre_colaborador.Text = Me.dgvTarea_x_Colaborador.Item("COL_nombre_col", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar una tarea")
        End If
        frm_Actualizar_Tarea.Show()
    End Sub
End Class
