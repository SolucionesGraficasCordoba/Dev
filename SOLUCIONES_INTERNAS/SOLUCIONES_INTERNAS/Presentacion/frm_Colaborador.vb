Option Explicit On ''''''''''''''''''''''''''''''''''''''''''''''''''  

Imports System.Text
Imports System.IO
Imports System.Drawing.Printing

Public Class frm_Colaborador
    Dim datacontext As New DataS_Interno
    Public quienllamo_col As Form


    Private Sub frm_Colaborador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_id_colaborador.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        lblTotal_Colaboradores.Text = dgvLista_Colaboradores.Rows.Count

        'CARGA COMBOBOX SECTOR
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)
        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = -1
    End Sub

    Public Sub cargargrilla()
        Dim carga = (From col In datacontext.COLABORADOR
                                    Join sec In datacontext.SECTOR
                                    On col.SEC_id_sector Equals sec.SEC_id_sector
                                    Select
                                    col.COL_id_colaborador,
                                    col.COL_nombre_col,
                                    col.COL_apellido_col,
                                    col.SEC_id_sector,
                                    sec.SEC_nombre_sector
                                    Where SEC_nombre_sector <> "De Baja"
                                    Order By SEC_nombre_sector Ascending)
        dgvLista_Colaboradores.DataSource = carga
    End Sub

    Private Sub btnGuardar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Colaborador.Click
        Try
            Dim buscacliente = (From cli In datacontext.COLABORADOR
                                Select cli.COL_nombre_col, cli.COL_apellido_col, cli.SEC_id_sector
                                Where COL_nombre_col = txt_nombre_colaborador.Text.ToUpper And COL_apellido_col = txt_apellido_colaborador.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El colaborador ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_nombre_colaborador.Text.Length = 0 Then
                MsgBox("Ingrese el Nombre del Colaborador")
                txt_nombre_colaborador.Focus()
                Exit Sub
            End If

            If cbo_sector.Text.Length = 0 Then
                MsgBox("Debe seleccionar un Sector")
                cbo_sector.Focus()
                Exit Sub
            End If

            Dim col = New COLABORADOR
            col.COL_nombre_col = StrConv(txt_nombre_colaborador.Text, VbStrConv.ProperCase)
            col.COL_apellido_col = StrConv(txt_apellido_colaborador.Text, VbStrConv.ProperCase)
            col.SEC_id_sector = cbo_sector.SelectedValue

            datacontext.COLABORADOR.InsertOnSubmit(col)
            datacontext.SubmitChanges()
            MsgBox("El colaborador se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
            ' Me.Dispose()
        Catch ex As Exception
            MsgBox("Error al guardar al Colaborador")
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
        If txt_nombre_colaborador.Text.Length = 0 Then
            MsgBox("Ingrese el Nombre del Colaborador")
            txt_nombre_colaborador.Focus()
            Exit Sub
        End If

        If cbo_sector.Text.Length = 0 Then
            MsgBox("Debe seleccionar un Sector")
            cbo_sector.Focus()
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.COLABORADOR Where P.COL_id_colaborador = (txt_id_colaborador.Text.ToUpper)).ToList()(0)
            ActualizarCliente.COL_nombre_col = StrConv(txt_nombre_colaborador.Text, VbStrConv.ProperCase)
            ActualizarCliente.COL_apellido_col = StrConv(txt_apellido_colaborador.Text, VbStrConv.ProperCase)
            ActualizarCliente.SEC_id_sector = cbo_sector.SelectedValue

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Colaborador")
            Me.limpiarcontroles()
            Me.cargargrilla()
            Me.Close()
            ' Me.Dispose()
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
        dgvLista_Colaboradores.Columns.Add("SEC_nombre_sector", "Sector")

        dgvLista_Colaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvLista_Colaboradores.Columns(0).Visible = False
        dgvLista_Colaboradores.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvLista_Colaboradores.Columns(2).DataPropertyName = "COL_apellido_col"
        dgvLista_Colaboradores.Columns(3).DataPropertyName = "SEC_id_sector"
        dgvLista_Colaboradores.Columns(3).Visible = False
        dgvLista_Colaboradores.Columns(4).DataPropertyName = "SEC_nombre_sector"
        dgvLista_Colaboradores.Columns(4).Width = 150
    End Sub

    Private Sub dgvLista_Colaboradores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista_Colaboradores.Click
        Try
            If dgvLista_Colaboradores.SelectedRows.Count > 0 Then
                txt_id_colaborador.Text = dgvLista_Colaboradores.Item("COL_id_colaborador", dgvLista_Colaboradores.SelectedRows(0).Index).Value
                txt_nombre_colaborador.Text = dgvLista_Colaboradores.Item("COL_nombre_col", dgvLista_Colaboradores.SelectedRows(0).Index).Value
                txt_apellido_colaborador.Text = dgvLista_Colaboradores.Item("COL_apellido_col", dgvLista_Colaboradores.SelectedRows(0).Index).Value
                cbo_sector.Text = dgvLista_Colaboradores.Item("SEC_nombre_sector", dgvLista_Colaboradores.SelectedRows(0).Index).Value
            Else
                MsgBox("Debe seleccionar un colaborador")
            End If
        Catch ex As Exception

        End Try
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
                    Me.Close()
            End Select
            Me.Close()
        Else
            MsgBox("Debe seleccionar un colaborador")
        End If
    End Sub

    Private Sub btnNuevo_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Colaborador.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Colaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Colaborador.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_Buscar_Colaborador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Colaborador.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_Colaborador.Text & "*"
        Dim consultaalu = From U In datacontext.COLABORADOR
                          Join S In datacontext.SECTOR
                          On S.SEC_id_sector Equals U.SEC_id_sector
                          Select U.COL_id_colaborador, U.COL_nombre_col, U.COL_apellido_col, U.SEC_id_sector, S.SEC_nombre_sector
                          Where COL_nombre_col Like buscar.ToString
        dgvLista_Colaboradores.DataSource = consultaalu
        dgvLista_Colaboradores.ClearSelection()
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
        Try
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_Colaborador_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PrintDocument1.Print()

    End Sub

    Dim i As Integer = 0

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '' Definimos la fuente que vamos a usar para imprimir
        '' en este caso Arial de 10
        'Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        'Dim topMargin As Double = e.MarginBounds.Top
        'Dim yPos As Double = 0
        'Dim linesPerPage As Double = 0
        'Dim count As Integer = 0
        'Dim texto As String = ""
        'Dim row As System.Windows.Forms.DataGridViewRow

        '' Calculamos el número de líneas que caben en cada página
        'linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

        '' Imprimimos las cabeceras
        'Dim header As DataGridViewHeaderCell
        'For Each column As DataGridViewColumn In dgvLista_Colaboradores.Columns
        '    header = column.HeaderCell
        '    texto += vbTab + header.FormattedValue.ToString()
        'Next

        'yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        'e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        '' Dejamos una línea de separación
        'count += 2

        '' Recorremos las filas del DataGridView hasta que llegemos
        '' a las líneas que nos caben en cada página o al final del grid.
        'While count < linesPerPage AndAlso i < dgvLista_Colaboradores.Rows.Count
        '    row = dgvLista_Colaboradores.Rows(i)
        '    texto = ""
        '    For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
        '        'Comprobamos que la celda tenga algún valor, en caso de 
        '        'permitir añadir filas esto es muy importante
        '        If celda.Value IsNot Nothing Then
        '            texto += vbTab + celda.Value.ToString()
        '        End If
        '    Next

        '    ' Calculamos la posición en la que se escribe la línea
        '    yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

        '    ' Escribimos la línea con el objeto Graphics
        '    e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        '    ' Incrementamos los contadores
        '    count += 1
        '    i += 1
        'End While

        '' Una vez fuera del bucle comprobamos si nos quedan más filas
        '' por imprimir, si quedan saldrán en la siguente página
        'If i < dgvLista_Colaboradores.Rows.Count Then
        '    e.HasMorePages = True
        'Else
        '    ' si llegamos al final, se establece HasMorePages a
        '    ' false para que se acabe la impresión
        '    e.HasMorePages = False
        '    ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
        '    ' una impresión desde PrintPreviewDialog, se vuelve disparar este
        '    ' evento como si fuese la primera vez, y si i está con el valor de la
        '    ' última fila del grid no se imprime nada
        '    i = 0
        'End If


        Dim i As Integer = 0

        Dim printFont As New Font("Arial", 8)
        Dim topMargin As Single = 500 'e.MarginBounds.Top
        Dim yPos As Single = 0
        Dim linesPerPage As Single = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim row As DataGridViewRow
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        While count < linesPerPage AndAlso i < Me.dgvLista_Colaboradores.Rows.Count
            row = dgvLista_Colaboradores.Rows(i)
            texto = ""
            For Each celda As DataGridViewCell In row.Cells
                texto += vbTab & celda.Value '.ToString()
            Next
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
            e.Graphics.DrawString(texto, printFont, Brushes.Black, 30, yPos)
            count += 1
            i += 1
        End While
        If i < Me.dgvLista_Colaboradores.Rows.Count Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            i = 0
        End If


    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs)
        Me.PrintDocument1.Print()
    End Sub

End Class
