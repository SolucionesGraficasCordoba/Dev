Public Class frm_Colaborador
    Dim datacontext As New DataS_Interno
    Public quienllamo_col As Form

    Private Sub frm_Colaborador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_colaborador.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        dgvLista_Colaboradores.ClearSelection()
        txt_nombre_colaborador.Focus()
        lblTotal_Colaboradores.Text = dgvLista_Colaboradores.Rows.Count

        'CARGA COMBOBOX SECTOR
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)

        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = 0
    End Sub

    Public Sub cargargrilla()
        Dim carga = (From col In datacontext.COLABORADOR
                                    Join sec In datacontext.SECTOR
                                    On col.SEC_id_sector Equals sec.SEC_id_sector
                                    Select col.COL_id_colaborador, col.COL_nombre_col, col.COL_apellido_col, col.SEC_id_sector, sec.SEC_nombre_sector
                                    Order By SEC_nombre_sector Ascending)
        dgvLista_Colaboradores.DataSource = carga
    End Sub


    Private Sub btnGuardar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Colaborador.Click
        Try
            Dim buscacliente = (From cli In datacontext.COLABORADOR
                                Select cli.COL_nombre_col, cli.COL_apellido_col, cli.SEC_id_sector
                                Where COL_nombre_col = txt_nombre_colaborador.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El colaborador ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_nombre_colaborador.Text.Length = 0 Or cbo_sector.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If

            Dim clie = New COLABORADOR
            clie.COL_nombre_col = txt_nombre_colaborador.Text
            clie.COL_apellido_col = txt_apellido_colaborador.Text
            clie.SEC_id_sector = cbo_sector.SelectedValue

            datacontext.COLABORADOR.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("El colaborador se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("El colaborador NO fue creado")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_colaborador.Clear()
        txt_nombre_colaborador.Clear()
        txt_apellido_colaborador.Clear()
        cbo_sector.SelectedIndex = -1
    End Sub

    Private Sub btnActualizar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Colaborador.Click
        If txt_nombre_colaborador.Text.Length = 0 Or cbo_sector.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.COLABORADOR Where P.COL_id_colaborador = (txt_id_colaborador.Text.ToUpper)).ToList()(0)
            ActualizarCliente.COL_nombre_col = txt_nombre_colaborador.Text
            ActualizarCliente.COL_apellido_col = txt_apellido_colaborador.Text
            ActualizarCliente.SEC_id_sector = cbo_sector.SelectedValue

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Private Sub armargrilla()
        dgvLista_Colaboradores.Enabled = True
        dgvLista_Colaboradores.AutoGenerateColumns = False
        dgvLista_Colaboradores.Columns.Clear()

        dgvLista_Colaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvLista_Colaboradores.Columns.Add("COL_nombre_col", "Nombre")
        dgvLista_Colaboradores.Columns.Add("COL_apellido_col", "Apellido")
        dgvLista_Colaboradores.Columns.Add("SEC_id_sector", "id_sector")
        dgvLista_Colaboradores.Columns.Add("SEC_nombre_sector", "Nombre del Sector")

        dgvLista_Colaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvLista_Colaboradores.Columns(0).Visible = False
        dgvLista_Colaboradores.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvLista_Colaboradores.Columns(1).Width = 150
        dgvLista_Colaboradores.Columns(2).DataPropertyName = "COL_apellido_col"
        dgvLista_Colaboradores.Columns(2).Width = 150
        dgvLista_Colaboradores.Columns(3).DataPropertyName = "SEC_id_sector"
        dgvLista_Colaboradores.Columns(3).Visible = False
        dgvLista_Colaboradores.Columns(4).DataPropertyName = "SEC_nombre_sector"
    End Sub

    Private Sub dgvLista_Colaboradores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_Colaboradores.Click
        If dgvLista_Colaboradores.SelectedRows.Count > 0 Then
            txt_id_colaborador.Text = dgvLista_Colaboradores.Item("COL_id_colaborador", dgvLista_Colaboradores.SelectedRows(0).Index).Value
            txt_nombre_colaborador.Text = dgvLista_Colaboradores.Item("COL_nombre_col", dgvLista_Colaboradores.SelectedRows(0).Index).Value
            txt_apellido_colaborador.Text = dgvLista_Colaboradores.Item("COL_apellido_col", dgvLista_Colaboradores.SelectedRows(0).Index).Value
            cbo_sector.Text = dgvLista_Colaboradores.Item("SEC_nombre_sector", dgvLista_Colaboradores.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un colaborador")
        End If
    End Sub

    Private Sub btnEliminar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Colaborador.Click
        If dgvLista_Colaboradores.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.COLABORADOR Where C.COL_id_colaborador = CInt(dgvLista_Colaboradores.Item("COL_id_colaborador", dgvLista_Colaboradores.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el colaborador seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar colaborador")
                Case MsgBoxResult.Yes
                    datacontext.COLABORADOR.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El colaborador ha sido eliminado")
                    cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar un colaborador")
        End If
    End Sub

    Private Sub btnNuevo_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Colaborador.Click
        limpiarcontroles()
    End Sub

    Private Sub btnCancelar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Colaborador.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Colaborador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Colaborador.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_Buscar_Colaborador.Text & "*"
        Dim consultaalu = From U In datacontext.COLABORADOR Select U.COL_id_colaborador, U.COL_nombre_col, U.COL_apellido_col, U.SEC_id_sector Where COL_nombre_col Like buscar.ToString
        dgvLista_Colaboradores.DataSource = consultaalu
    End Sub

    Private Sub txt_nombre_colaborador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre_colaborador.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_apellido_colaborador.Focus()
        End If
    End Sub

    Private Sub txt_apellido_colaborador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_apellido_colaborador.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_sector.Focus()
        End If
    End Sub

    Private Sub cbo_sector_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_sector.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Colaborador.Focus()
        End If
    End Sub

    Private Sub dgvLista_Colaboradores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Colaboradores.CellDoubleClick

        If quienllamo_col.Name = frm_Actualizar_Tarea.Name Then
            frm_Actualizar_Tarea.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
            frm_Actualizar_Tarea.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value

        ElseIf quienllamo_col.Name = frm_Tarea.Name Then
            frm_Tarea.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
            frm_Tarea.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value
        ElseIf quienllamo_col.Name = frm_Usuario.Name Then
            frm_Usuario.txt_id_colaborador.Text = dgvLista_Colaboradores.SelectedCells(0).Value
            frm_Usuario.txt_nombre_colaborador.Text = dgvLista_Colaboradores.SelectedCells(1).Value
        End If
        Me.Close()
    End Sub
End Class
