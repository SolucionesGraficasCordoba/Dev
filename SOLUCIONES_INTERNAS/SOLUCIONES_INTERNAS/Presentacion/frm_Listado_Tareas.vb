Public Class frm_Listado_Tareas
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub frm_Listado_Tareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'armargrilla()
        'cargargrilla()
        dgvLista_Tareas.ClearSelection()
        Label6.Text = dgvLista_Tareas.Rows.Count

        'CARGA COMBOBOX SECTOR
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)

        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = -1
    End Sub


    Private Sub armargrilla()
        dgvLista_Tareas.Enabled = True
        dgvLista_Tareas.AutoGenerateColumns = False
        dgvLista_Tareas.Columns.Clear()

        dgvLista_Tareas.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvLista_Tareas.Columns.Add("COL_nombre_col", "Colaborador")
        dgvLista_Tareas.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvLista_Tareas.Columns(0).Visible = False
        dgvLista_Tareas.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvLista_Tareas.Columns(1).Width = 300

    End Sub

    Private Sub btnEliminar_Tarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Tarea.Click
        If dgvLista_Tareas.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.TAREA Where C.TAR_id_tarea = CInt(dgvLista_Tareas.Item("TAR_id_tarea", dgvLista_Tareas.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la tares seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar tarea")
                Case MsgBoxResult.Yes
                    datacontext.TAREA.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La tarea ha sido eliminada")
                    cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar una tarea")
        End If
    End Sub

    'CARGA COLABORADOR DATAGRIDVIEW SEGUN LO QUE SELECCIONO EN EL COMBOBOX
    Private Sub cbo_sector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_sector.SelectedIndexChanged
        armargrilla()
        cargargrilla()
        Dim consultaporsector = (From A In datacontext.SECTOR
                               Join C In datacontext.COLABORADOR
                               On A.SEC_id_sector Equals C.SEC_id_sector
                               Select C.COL_id_colaborador, C.COL_nombre_col, A.SEC_id_sector, A.SEC_nombre_sector
                               Where (SEC_id_sector = cbo_sector.SelectedIndex + 1)
                               Order By COL_nombre_col Ascending)
        dgvLista_Tareas.DataSource = consultaporsector
        Label6.Text = dgvLista_Tareas.Rows.Count
    End Sub

    Public Sub cargargrilla()
        'Dim consultaCliente = (From U In datacontext.TAREA
        '                       Join ort In datacontext.ORDEN_TRABAJO
        '                       On U.ORT_id_orden_trabajo Equals ort.ORT_id_orden_trabajo
        '                       Join col In datacontext.COLABORADOR
        '                       On col.COL_id_colaborador Equals U.COL_id_colaborador
        '                        Join sec In datacontext.SECTOR
        '                      On sec.SEC_id_sector Equals col.SEC_id_sector
        '                      Select U.TAR_id_tarea, U.TAR_tiempo_estimado, U.TAR_tiempo_real, U.COL_id_colaborador,
        '                      col.COL_nombre_col, ort.ORT_numero_ot, U.TAR_hora_fin, U.TAR_carga_horaria, U.TAR_detalle_tarea,
        '                      U.TAR_observaciones, sec.SEC_id_sector, sec.SEC_nombre_sector
        '                      Order By ORT_numero_ot Ascending)
        'dgvLista_Tareas.DataSource = consultaCliente
    End Sub

    Private Sub dgvLista_Tareas_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Tareas.CellDoubleClick
        Dim consultaTarea = (From U In datacontext.SECTOR
                     Join ort In datacontext.COLABORADOR
                     On ort.SEC_id_sector Equals U.SEC_id_sector
                     Join col In datacontext.TAREA
                     On ort.COL_id_colaborador Equals col.COL_id_colaborador
                      Join sec In datacontext.ORDEN_TRABAJO
                    On sec.ORT_id_orden_trabajo Equals col.ORT_id_orden_trabajo
                    Select U.SEC_id_sector,
                    U.SEC_nombre_sector,
                    ort.COL_id_colaborador,
                    ort.COL_nombre_col,
                    col.TAR_id_tarea,
                    col.TAR_detalle_tarea,
                    col.TAR_fecha,
                    col.ORT_id_orden_trabajo,
                    sec.ORT_numero_ot
Where COL_id_colaborador = dgvLista_Tareas.CurrentRow.Cells("COL_id_colaborador").Value)
        ' Order By ORT_numero_ot Ascending)

        dgvTodasTareas.DataSource = consultaTarea
    End Sub
End Class


' Select Case Rb_dni.Checked
'            Case True
'                vble_dia = Dg_Docente_x_dia.Item("dia_semana", Dg_Docente_x_dia.SelectedRows(0).Index).Value
'                vble_turno = Dg_Docente_x_dia.Item("turno_textbox", Dg_Docente_x_dia.SelectedRows(0).Index).Value
'                vble_id_horario_pers = -1

'Dim datagridobligaciones = From o In datacontextvistas.vista_horario_personal
'                           Select o.nombre_materia, o.nombre_curso, o.numero, o.hora_inicio, o.hora_fin, o.id_horario, o.id_personal, o.dia_semana, o.turno_textbox
'                           Where dia_semana = vble_dia And turno_textbox = vble_turno And id_personal = vble_id_pers_asis
'                mostrargrillaobligaciones(datagridobligaciones)
'            Case False
'                If Dg_Docente_x_dia.SelectedRows.Count > 0 Then
'                    vble_id_pers_asis = Dg_Docente_x_dia.Item("id_personal", Dg_Docente_x_dia.SelectedRows(0).Index).Value
'                End If
'Dim datagridobligaciones = From o In datacontextvistas.vista_horario_personal
'                           Select o.nombre_materia, o.nombre_curso, o.numero, o.hora_inicio, o.hora_fin, o.id_horario, o.id_personal, o.dia_semana, o.turno_textbox Where dia_semana = Cmb_dia.Text And turno_textbox = Cmb_turno.Text And id_personal = vble_id_pers_asis
'                mostrargrillaobligaciones(datagridobligaciones)
'                Btn_editar_inasis_pers.Enabled = True

'        End Select