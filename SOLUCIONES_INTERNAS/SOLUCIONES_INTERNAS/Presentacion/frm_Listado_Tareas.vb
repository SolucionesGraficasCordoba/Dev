Public Class frm_Listado_Tareas

    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public vble_id_colaborador As Integer
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

    'ARMA LA GRILLA DEL COLABORADOR
    Private Sub armargrillacolaborador()
        dgvColaboradores.Enabled = True
        dgvColaboradores.AutoGenerateColumns = False
        dgvColaboradores.Columns.Clear()

        dgvColaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvColaboradores.Columns.Add("COL_nombre_col", "Colaborador")

        dgvColaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvColaboradores.Columns(0).Visible = False
        dgvColaboradores.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvColaboradores.Columns(1).Width = 350
    End Sub

    'BOTON ELIMINAR
    Private Sub btnEliminar_Tarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Tarea.Click

        If dgvTarea_x_Colaborador.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar una Tarea")
        Else
            Dim eliminar = (From C In datacontext.TAREA Where C.TAR_id_tarea = CInt(dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.SelectedRows(0).Index).Value)).ToList()(0)
            Select Case MsgBox("Se eliminará la tares seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar tarea")
                Case MsgBoxResult.Yes
                    datacontext.TAREA.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La Tarea ha sido eliminada")
            End Select
            Me.Close()
        End If
    End Sub

    'CARGA COLABORADOR DATAGRIDVIEW SEGUN LO QUE SELECCIONO EN EL COMBOBOX
    Private Sub cbo_sector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_sector.SelectedIndexChanged
        armargrillacolaborador()
        Dim consultaporsector = (From A In datavistas.Colaborador_por_Sector
                                Select A.COL_id_colaborador,
                                A.COL_nombre_col,
                                A.SEC_id_sector,
                                A.SEC_nombre_sector
          Where (SEC_id_sector = CInt(cbo_sector.SelectedIndex + 1)))
        dgvColaboradores.DataSource = consultaporsector
        Label6.Text = dgvColaboradores.Rows.Count
    End Sub

    Public Sub dgvColaboradores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColaboradores.CellClick

        'CARGA TAREAS DEL COLABORADOR SEGUN SECTOR Y FECHA
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

        ' dgvColaboradores.ClearSelection()

        'VALIDA SI TIENE ASIGNADAS TAREAS AL COLABORADOR
        'If dgvTarea_x_Colaborador.Rows.Count = 0 Then
        '    MsgBox("No se le ha asignado ninguna tarea", MsgBoxStyle.Information, "Listado de tareas")
        '    btnAgregar.Enabled = True
        '    Exit Sub
        'End If
        'Label1.Text = dgvTarea_x_Colaborador.Rows.Count

        If dgvTarea_x_Colaborador.Rows.Count = 0 Then
            If Me.Text = "Modificar Tarea" Then
                Select Case MsgBox("No se le ha asignado ninguna tarea, desea agregar una?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Agregar tarea")
                    Case MsgBoxResult.Yes
                        btnAgregar.Enabled = True
                        btnModificar_Tarea.Enabled = False
                        btnEliminar_Tarea.Enabled = False
                        Label1.Text = dgvTarea_x_Colaborador.Rows.Count
                End Select
            ElseIf Me.Text = "Eliminar Tarea" Then
                If dgvTarea_x_Colaborador.Rows.Count = 0 Then
                    MsgBox("No tiene tareas asignadas para eliminar", MsgBoxStyle.Information, "Listado de tareas")
                    Label1.Text = dgvTarea_x_Colaborador.Rows.Count
                    Exit Sub
                End If
            End If
        End If
    End Sub

    'ARMA GRILLA DE TAREAS SEGUN COLABORADOR
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
        dgvTarea_x_Colaborador.Columns(2).Width = 60
        dgvTarea_x_Colaborador.Columns(3).DataPropertyName = "TAR_tiempo_real"
        dgvTarea_x_Colaborador.Columns(3).Width = 60
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
        dgvTarea_x_Colaborador.Columns(9).Width = 60
        dgvTarea_x_Colaborador.Columns(10).DataPropertyName = "Expr1"
        dgvTarea_x_Colaborador.Columns(10).Visible = False
        dgvTarea_x_Colaborador.Columns(11).DataPropertyName = "COL_nombre_col"
        dgvTarea_x_Colaborador.Columns(11).Visible = False

        dgvTarea_x_Colaborador.DataSource = datasource
        dgvTarea_x_Colaborador.ClearSelection()
    End Sub

    'BOTON MODIFICAR (CARGA LOS DATOS EN CADA UNO DE LOS CONTROLES)
    Private Sub btnModificar_Tarea_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar_Tarea.Click

        If dgvColaboradores.RowCount = 0 Then
            MsgBox("Debe seleccionar un Sector")
            Exit Sub
        End If
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
            Exit Sub
        End If
        frm_Actualizar_Tarea.Show()
        frm_Actualizar_Tarea.btnGuardar.Enabled = False
        frm_Actualizar_Tarea.btn_buscar_colaborador.Enabled = False
        frm_Actualizar_Tarea.btn_buscar_numero_orden.Enabled = False
    End Sub

    'BOTON CANCELAR CIERRA EL FORMULARIO ACTUAL
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If Me.dgvColaboradores.SelectedRows.Count > 0 Then
            frm_Actualizar_Tarea.dtpFecha.Text = dtpFecha.Text
            frm_Actualizar_Tarea.txt_id_colaborador.Text = Me.dgvColaboradores.Item("COL_id_colaborador", dgvColaboradores.SelectedRows(0).Index).Value
            frm_Actualizar_Tarea.txt_nombre_colaborador.Text = Me.dgvColaboradores.Item("COL_nombre_col", dgvColaboradores.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar una tarea")
            Exit Sub
        End If
        frm_Actualizar_Tarea.Show()
        frm_Actualizar_Tarea.btn_Actualizar_Tarea.Enabled = False
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        Dim fechaactual = System.DateTime.Now.ToString("dd/mm/yyyy")
        If dtpFecha.Text <= fechaactual Then
            '  btnModificar_Tarea.Enabled = False
        Else
            btnModificar_Tarea.Enabled = True
        End If
    End Sub

    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click

        'CARGA EL ENCABEZADO DEL FORMULARIO TAREAS
        If dgvColaboradores.Rows.Count = 0 Then
            MsgBox("Debe selecconar un Sector")
            Exit Sub
        Else
        End If

        If dgvTarea_x_Colaborador.Rows.Count <> 0 Then
            frm_Tarea.txt_id_colaborador.Text = Me.dgvColaboradores.Item("COL_id_colaborador", dgvColaboradores.SelectedRows(0).Index).Value
            frm_Tarea.txt_nombre_colaborador.Text = Me.dgvColaboradores.Item("COL_nombre_col", dgvColaboradores.SelectedRows(0).Index).Value
            frm_Tarea.dtpFecha.Text = Me.dgvTarea_x_Colaborador.Item("TAR_fecha", dgvTarea_x_Colaborador.Rows(0).Index).Value
            frm_Tarea.txt_Carga_Horaria1.Text = Me.dgvTarea_x_Colaborador.Item("TAR_carga_horaria", dgvTarea_x_Colaborador.Rows(0).Index).Value

            Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8, flag9, flag10, flag11, flag12, flag13, flag14, flag15, flag16, flag17, flag18, flag19, flag20 As Integer

            If dgvTarea_x_Colaborador.RowCount = 1 Then
                flag1 = 1
                flag2 = 0
            ElseIf dgvTarea_x_Colaborador.RowCount = 2 Then
                flag1 = 1
                flag2 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 3 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 4 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 5 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 6 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 7 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 8 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 9 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 10 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 11 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 12 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 13 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 14 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 15 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 16 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 17 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 18 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                flag18 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 19 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                flag18 = 1
                flag19 = 1
            ElseIf dgvTarea_x_Colaborador.RowCount = 20 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                flag18 = 1
                flag19 = 1
                flag20 = 1

            End If

            If flag1 = 1 Then
                frm_Tarea.txt_detalle_tarea1.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_Tarea.txtTiempo_Estimado1.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_Tarea.txtTiempo_Real1.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_Tarea.txtHora_Finalizacion1.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_Tarea.txtObservaciones1.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_Tarea.txt_id_orden_trabajo1.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo1.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(0).Index).Value
            End If

            If flag2 = 1 Then
                frm_Tarea.txt_detalle_tarea2.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_Tarea.txtTiempo_Estimado2.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_Tarea.txtTiempo_Real2.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_Tarea.txtHora_Finalizacion2.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_Tarea.txtObservaciones2.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_Tarea.txt_id_orden_trabajo2.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo2.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(1).Index).Value
            End If

            If flag3 = 1 Then
                frm_Tarea.txt_detalle_tarea3.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_Tarea.txtTiempo_Estimado3.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_Tarea.txtTiempo_Real3.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_Tarea.txtHora_Finalizacion3.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_Tarea.txtObservaciones3.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_Tarea.txt_id_orden_trabajo3.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo3.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(2).Index).Value
            End If

            If flag4 = 1 Then
                frm_Tarea.txt_detalle_tarea4.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_Tarea.txtTiempo_Estimado4.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_Tarea.txtTiempo_Real4.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_Tarea.txtHora_Finalizacion4.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_Tarea.txtObservaciones4.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_Tarea.txt_id_orden_trabajo4.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo4.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(3).Index).Value
            End If

            If flag5 = 1 Then
                frm_Tarea.txt_detalle_tarea5.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_Tarea.txtTiempo_Estimado5.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_Tarea.txtTiempo_Real5.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_Tarea.txtHora_Finalizacion5.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_Tarea.txtObservaciones5.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_Tarea.txt_id_orden_trabajo5.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo5.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(4).Index).Value
            End If

            If flag6 = 1 Then
                frm_Tarea.txt_detalle_tarea6.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_Tarea.txtTiempo_Estimado6.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_Tarea.txtTiempo_Real6.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_Tarea.txtHora_Finalizacion6.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_Tarea.txtObservaciones6.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_Tarea.txt_id_orden_trabajo6.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo6.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(5).Index).Value
            End If

            If flag7 = 1 Then
                frm_Tarea.txt_detalle_tarea7.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_Tarea.txtTiempo_Estimado7.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_Tarea.txtTiempo_Real7.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_Tarea.txtHora_Finalizacion7.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_Tarea.txtObservaciones7.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_Tarea.txt_id_orden_trabajo7.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo7.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(6).Index).Value
            End If

            If flag8 = 1 Then
                frm_Tarea.txt_detalle_tarea8.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_Tarea.txtTiempo_Estimado8.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_Tarea.txtTiempo_Real8.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_Tarea.txtHora_Finalizacion8.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_Tarea.txtObservaciones8.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_Tarea.txt_id_orden_trabajo8.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo8.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(7).Index).Value
            End If

            If flag9 = 1 Then
                frm_Tarea.txt_detalle_tarea9.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_Tarea.txtTiempo_Estimado9.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_Tarea.txtTiempo_Real9.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_Tarea.txtHora_Finalizacion9.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_Tarea.txtObservaciones9.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_Tarea.txt_id_orden_trabajo9.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo9.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(8).Index).Value
            End If

            If flag10 = 1 Then
                frm_Tarea.txt_detalle_tarea10.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_Tarea.txtTiempo_Estimado10.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_Tarea.txtTiempo_Real10.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_Tarea.txtHora_Finalizacion10.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_Tarea.txtObservaciones10.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_Tarea.txt_id_orden_trabajo10.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo10.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(9).Index).Value
            End If

            If flag11 = 1 Then
                frm_Tarea.txt_detalle_tarea11.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_Tarea.txtTiempo_Estimado11.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_Tarea.txtTiempo_Real11.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_Tarea.txtHora_Finalizacion11.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_Tarea.txtObservaciones11.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_Tarea.txt_id_orden_trabajo11.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo11.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(10).Index).Value
            End If

            If flag12 = 1 Then
                frm_Tarea.txt_detalle_tarea12.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_Tarea.txtTiempo_Estimado12.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_Tarea.txtTiempo_Real12.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_Tarea.txtHora_Finalizacion12.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_Tarea.txtObservaciones12.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_Tarea.txt_id_orden_trabajo12.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo12.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(11).Index).Value
            End If

            If flag13 = 1 Then
                frm_Tarea.txt_detalle_tarea13.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_Tarea.txtTiempo_Estimado13.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_Tarea.txtTiempo_Real13.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_Tarea.txtHora_Finalizacion13.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_Tarea.txtObservaciones13.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_Tarea.txt_id_orden_trabajo13.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo13.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(12).Index).Value
            End If

            If flag14 = 1 Then
                frm_Tarea.txt_detalle_tarea14.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_Tarea.txtTiempo_Estimado14.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_Tarea.txtTiempo_Real14.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_Tarea.txtHora_Finalizacion14.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_Tarea.txtObservaciones14.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_Tarea.txt_id_orden_trabajo14.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo14.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(13).Index).Value
            End If

            If flag15 = 1 Then
                frm_Tarea.txt_detalle_tarea15.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_Tarea.txtTiempo_Estimado15.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_Tarea.txtTiempo_Real15.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_Tarea.txtHora_Finalizacion15.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_Tarea.txtObservaciones15.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_Tarea.txt_id_orden_trabajo15.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo15.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(14).Index).Value
            End If

            If flag16 = 1 Then
                frm_Tarea.txt_detalle_tarea16.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_Tarea.txtTiempo_Estimado16.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_Tarea.txtTiempo_Real16.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_Tarea.txtHora_Finalizacion16.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_Tarea.txtObservaciones16.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_Tarea.txt_id_orden_trabajo16.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo16.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(15).Index).Value
            End If

            If flag17 = 1 Then
                frm_Tarea.txt_detalle_tarea17.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_Tarea.txtTiempo_Estimado17.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_Tarea.txtTiempo_Real17.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_Tarea.txtHora_Finalizacion17.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_Tarea.txtObservaciones17.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_Tarea.txt_id_orden_trabajo17.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo17.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(16).Index).Value
            End If

            If flag18 = 1 Then
                frm_Tarea.txt_detalle_tarea18.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_Tarea.txtTiempo_Estimado18.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_Tarea.txtTiempo_Real18.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_Tarea.txtHora_Finalizacion18.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_Tarea.txtObservaciones18.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_Tarea.txt_id_orden_trabajo18.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo18.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(17).Index).Value
            End If

            If flag19 = 1 Then
                frm_Tarea.txt_detalle_tarea19.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_Tarea.txtTiempo_Estimado19.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_Tarea.txtTiempo_Real19.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_Tarea.txtHora_Finalizacion19.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_Tarea.txtObservaciones19.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_Tarea.txt_id_orden_trabajo19.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo19.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(18).Index).Value
            End If

            If flag20 = 1 Then
                frm_Tarea.txt_detalle_tarea20.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_Tarea.txtTiempo_Estimado20.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_Tarea.txtTiempo_Real20.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_Tarea.txtHora_Finalizacion20.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_Tarea.txtObservaciones20.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_Tarea.txt_id_orden_trabajo20.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_Tarea.txtNumero_Orden_Trabajo20.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(19).Index).Value
            End If
        Else
            MsgBox("El Colaborador no tiene tareas por mostrar")
            Exit Sub
        End If
        frm_Tarea.Text = "Consultar Tarea"
        frm_Tarea.btnImprimir.Visible = True
        frm_Tarea.txt_nombre_colaborador.Enabled = False
        DeshabilitarText()
        frm_Tarea.ShowDialog()


    End Sub

    Public Sub DeshabilitarText()
        frm_Tarea.txt_detalle_tarea1.Enabled = False
        frm_Tarea.txt_detalle_tarea2.Enabled = False
        frm_Tarea.txt_detalle_tarea3.Enabled = False
        frm_Tarea.txt_detalle_tarea4.Enabled = False
        frm_Tarea.txt_detalle_tarea5.Enabled = False
        frm_Tarea.txt_detalle_tarea6.Enabled = False
        frm_Tarea.txt_detalle_tarea7.Enabled = False
        frm_Tarea.txt_detalle_tarea8.Enabled = False
        frm_Tarea.txt_detalle_tarea9.Enabled = False
        frm_Tarea.txt_detalle_tarea10.Enabled = False
        frm_Tarea.txt_detalle_tarea11.Enabled = False
        frm_Tarea.txt_detalle_tarea12.Enabled = False
        frm_Tarea.txt_detalle_tarea13.Enabled = False
        frm_Tarea.txt_detalle_tarea14.Enabled = False
        frm_Tarea.txt_detalle_tarea15.Enabled = False
        frm_Tarea.txt_detalle_tarea16.Enabled = False
        frm_Tarea.txt_detalle_tarea17.Enabled = False
        frm_Tarea.txt_detalle_tarea18.Enabled = False
        frm_Tarea.txt_detalle_tarea19.Enabled = False
        frm_Tarea.txt_detalle_tarea20.Enabled = False

        frm_Tarea.txtTiempo_Estimado1.Enabled = False
        frm_Tarea.txtTiempo_Estimado2.Enabled = False
        frm_Tarea.txtTiempo_Estimado3.Enabled = False
        frm_Tarea.txtTiempo_Estimado4.Enabled = False
        frm_Tarea.txtTiempo_Estimado5.Enabled = False
        frm_Tarea.txtTiempo_Estimado6.Enabled = False
        frm_Tarea.txtTiempo_Estimado7.Enabled = False
        frm_Tarea.txtTiempo_Estimado8.Enabled = False
        frm_Tarea.txtTiempo_Estimado9.Enabled = False
        frm_Tarea.txtTiempo_Estimado10.Enabled = False
        frm_Tarea.txtTiempo_Estimado11.Enabled = False
        frm_Tarea.txtTiempo_Estimado12.Enabled = False
        frm_Tarea.txtTiempo_Estimado13.Enabled = False
        frm_Tarea.txtTiempo_Estimado14.Enabled = False
        frm_Tarea.txtTiempo_Estimado15.Enabled = False
        frm_Tarea.txtTiempo_Estimado16.Enabled = False
        frm_Tarea.txtTiempo_Estimado17.Enabled = False
        frm_Tarea.txtTiempo_Estimado18.Enabled = False
        frm_Tarea.txtTiempo_Estimado19.Enabled = False
        frm_Tarea.txtTiempo_Estimado20.Enabled = False

        frm_Tarea.txtTiempo_Real1.Enabled = False
        frm_Tarea.txtTiempo_Real2.Enabled = False
        frm_Tarea.txtTiempo_Real3.Enabled = False
        frm_Tarea.txtTiempo_Real4.Enabled = False
        frm_Tarea.txtTiempo_Real5.Enabled = False
        frm_Tarea.txtTiempo_Real6.Enabled = False
        frm_Tarea.txtTiempo_Real7.Enabled = False
        frm_Tarea.txtTiempo_Real8.Enabled = False
        frm_Tarea.txtTiempo_Real9.Enabled = False
        frm_Tarea.txtTiempo_Real10.Enabled = False
        frm_Tarea.txtTiempo_Real11.Enabled = False
        frm_Tarea.txtTiempo_Real12.Enabled = False
        frm_Tarea.txtTiempo_Real13.Enabled = False
        frm_Tarea.txtTiempo_Real14.Enabled = False
        frm_Tarea.txtTiempo_Real15.Enabled = False
        frm_Tarea.txtTiempo_Real16.Enabled = False
        frm_Tarea.txtTiempo_Real17.Enabled = False
        frm_Tarea.txtTiempo_Real18.Enabled = False
        frm_Tarea.txtTiempo_Real19.Enabled = False
        frm_Tarea.txtTiempo_Real20.Enabled = False

        frm_Tarea.txtHora_Finalizacion1.Enabled = False
        frm_Tarea.txtHora_Finalizacion2.Enabled = False
        frm_Tarea.txtHora_Finalizacion3.Enabled = False
        frm_Tarea.txtHora_Finalizacion4.Enabled = False
        frm_Tarea.txtHora_Finalizacion5.Enabled = False
        frm_Tarea.txtHora_Finalizacion6.Enabled = False
        frm_Tarea.txtHora_Finalizacion7.Enabled = False
        frm_Tarea.txtHora_Finalizacion8.Enabled = False
        frm_Tarea.txtHora_Finalizacion9.Enabled = False
        frm_Tarea.txtHora_Finalizacion10.Enabled = False
        frm_Tarea.txtHora_Finalizacion11.Enabled = False
        frm_Tarea.txtHora_Finalizacion12.Enabled = False
        frm_Tarea.txtHora_Finalizacion13.Enabled = False
        frm_Tarea.txtHora_Finalizacion14.Enabled = False
        frm_Tarea.txtHora_Finalizacion15.Enabled = False
        frm_Tarea.txtHora_Finalizacion16.Enabled = False
        frm_Tarea.txtHora_Finalizacion17.Enabled = False
        frm_Tarea.txtHora_Finalizacion18.Enabled = False
        frm_Tarea.txtHora_Finalizacion19.Enabled = False
        frm_Tarea.txtHora_Finalizacion20.Enabled = False

        frm_Tarea.txtObservaciones1.Enabled = False
        frm_Tarea.txtObservaciones2.Enabled = False
        frm_Tarea.txtObservaciones3.Enabled = False
        frm_Tarea.txtObservaciones4.Enabled = False
        frm_Tarea.txtObservaciones5.Enabled = False
        frm_Tarea.txtObservaciones6.Enabled = False
        frm_Tarea.txtObservaciones7.Enabled = False
        frm_Tarea.txtObservaciones8.Enabled = False
        frm_Tarea.txtObservaciones9.Enabled = False
        frm_Tarea.txtObservaciones10.Enabled = False
        frm_Tarea.txtObservaciones11.Enabled = False
        frm_Tarea.txtObservaciones12.Enabled = False
        frm_Tarea.txtObservaciones13.Enabled = False
        frm_Tarea.txtObservaciones14.Enabled = False
        frm_Tarea.txtObservaciones15.Enabled = False
        frm_Tarea.txtObservaciones16.Enabled = False
        frm_Tarea.txtObservaciones17.Enabled = False
        frm_Tarea.txtObservaciones18.Enabled = False
        frm_Tarea.txtObservaciones19.Enabled = False
        frm_Tarea.txtObservaciones20.Enabled = False

        frm_Tarea.btnBuscar_Numero_Orden1.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden2.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden3.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden4.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden5.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden6.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden7.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden8.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden9.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden10.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden11.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden12.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden13.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden14.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden15.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden16.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden17.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden18.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden19.Enabled = False
        frm_Tarea.btnBuscar_Numero_Orden20.Enabled = False

        frm_Tarea.txtNumero_Orden_Trabajo1.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo2.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo3.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo4.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo5.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo6.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo7.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo8.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo9.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo10.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo11.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo12.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo13.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo14.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo15.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo16.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo17.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo18.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo19.Enabled = False
        frm_Tarea.txtNumero_Orden_Trabajo20.Enabled = False

        frm_Tarea.txt_id_orden_trabajo1.Visible = False
        frm_Tarea.txt_id_orden_trabajo2.Visible = False
        frm_Tarea.txt_id_orden_trabajo3.Visible = False
        frm_Tarea.txt_id_orden_trabajo4.Visible = False
        frm_Tarea.txt_id_orden_trabajo5.Visible = False
        frm_Tarea.txt_id_orden_trabajo6.Visible = False
        frm_Tarea.txt_id_orden_trabajo7.Visible = False
        frm_Tarea.txt_id_orden_trabajo8.Visible = False
        frm_Tarea.txt_id_orden_trabajo9.Visible = False
        frm_Tarea.txt_id_orden_trabajo10.Visible = False
        frm_Tarea.txt_id_orden_trabajo11.Visible = False
        frm_Tarea.txt_id_orden_trabajo12.Visible = False
        frm_Tarea.txt_id_orden_trabajo13.Visible = False
        frm_Tarea.txt_id_orden_trabajo14.Visible = False
        frm_Tarea.txt_id_orden_trabajo15.Visible = False
        frm_Tarea.txt_id_orden_trabajo16.Visible = False
        frm_Tarea.txt_id_orden_trabajo17.Visible = False
        frm_Tarea.txt_id_orden_trabajo18.Visible = False
        frm_Tarea.txt_id_orden_trabajo19.Visible = False
        frm_Tarea.txt_id_orden_trabajo20.Visible = False

        frm_Tarea.btnImprimir.Enabled = True
        frm_Tarea.btnBuscar_Colaborador.Enabled = False
        frm_Tarea.dtpFecha.Enabled = False
        frm_Tarea.txt_Carga_Horaria1.Enabled = False
        frm_Tarea.btnImprimir.Enabled = True
        frm_Tarea.btnNueva_Tarea.Enabled = False
        frm_Tarea.btnGuardar_Tarea.Enabled = False
        frm_Tarea.Label1.Visible = False
        frm_Tarea.txt_id_colaborador.Visible = False
        frm_Tarea.txt_id_tarea.Visible = False
    End Sub

    Private Sub frm_Listado_Tareas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        SetFormatting()
    End Sub

    Private Sub SetFormatting()
        Me.dgvTarea_x_Colaborador.Columns("UnitPrice").DefaultCellStyle.Format = "c"
        Me.dgvTarea_x_Colaborador.Columns("ShipDate").DefaultCellStyle.Format = "d"
        Me.dgvTarea_x_Colaborador.Columns("CustomerName").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvTarea_x_Colaborador.DefaultCellStyle.NullValue = "no entry"
        Me.dgvTarea_x_Colaborador.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
    End Sub
End Class
