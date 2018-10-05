Imports System.IO
Imports System.Text

Public Class frm_Etiqueta_Modelo_1


    Private Sub frm_Etiqueta_Modelo_1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Label2.Enabled = False
        Label15.Enabled = False
        Label16.Enabled = False
        Label17.Enabled = False
        Label18.Enabled = False
        'Label22.Visible = False 'HACER VISIBLE CUANDO SEA NECESARIO
        'Label25.Visible = False 'HACER VISIBLE CUANDO SEA NECESARIO
        ArmarEtiqueta()
        txtId_Cliente.Visible = False
        txt_id_orden.Visible = False
        btnBuscarCliente.Visible = False
        btnBuscar_Orden.Focus()

        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCliente.Click
        frm_Cliente.quienllamocliente = Me
        frm_Cliente.Text = "Seleccionar Cliente"
        frm_Cliente.Show()
    End Sub

    Private Sub btnNuevaEtiqueta_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiarEtiqueta.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar Campos")
            Case MsgBoxResult.Yes
                Limpiar()
        End Select
    End Sub

    Sub Limpiar()
        txtDescripcionEntrega.Clear()
        txtDirigidoA.Clear()
        txtId_Cliente.Clear()
        txt_id_orden.Clear()
        txt_orden.Clear()
        txtSolicitante.Clear()
        txtSector.Clear()
        txtDomicilio.Clear()
        txtLocalidad.Clear()
        txtCodigoPostal.Clear()
        txtDespachado.Clear()
        txtSeccion.Clear()
        txtCantidadBultos.Clear()
        txtNumeroBultos.Clear()
        txtUnidadxBulto.Clear()
        txtTotalBultos.Clear()
        txtPeso.Clear()
        cboLogo.SelectedIndex = -1
    End Sub

    Private Sub ArmarEtiqueta()
        dgv_Etiquetas.Enabled = True
        dgv_Etiquetas.AutoGenerateColumns = False
        dgv_Etiquetas.Columns.Clear()

        dgv_Etiquetas.Columns.Add(txt_orden.Text, "Orden")
        dgv_Etiquetas.Columns.Add(txtDescripcionEntrega.Text, "Descrición")
        dgv_Etiquetas.Columns.Add("CLI_id_cliente", "id_cliente")
        dgv_Etiquetas.Columns(2).Visible = False
        dgv_Etiquetas.Columns.Add("CLI_razon_social", "Dirigido a")
        dgv_Etiquetas.Columns.Add(txtSolicitante.Text, "Solicitante")
        dgv_Etiquetas.Columns.Add(txtSector.Text, "Sector")
        dgv_Etiquetas.Columns.Add("CLI_domicilio", "Domicilio")
        dgv_Etiquetas.Columns.Add("CLI_localidad", "Localidad")
        dgv_Etiquetas.Columns.Add("CLI_codigo_postal", "CP")
        dgv_Etiquetas.Columns.Add(txtDespachado.Text, "Despachado")
        dgv_Etiquetas.Columns.Add(txtSeccion.Text, "Sección")
        dgv_Etiquetas.Columns.Add(txtCantidadBultos.Text, "Cantidad")
        dgv_Etiquetas.Columns.Add(txtNumeroBultos.Text, "Nro Bultos")
        dgv_Etiquetas.Columns.Add(txtUnidadxBulto.Text, "Unid_x_Bulto")
        dgv_Etiquetas.Columns.Add(txtTotalBultos.Text, "Total Bultos")
        dgv_Etiquetas.Columns.Add(txtPeso.Text, "Peso")
        dgv_Etiquetas.Columns.Add(cboLogo.Text, "Logo")
    End Sub

    Public Sub CargaEtiqueta()
        Dim row As String() = New String() {txt_orden.Text.ToUpper,
                                            txtDescripcionEntrega.Text.ToUpper,
                                            txtId_Cliente.Text.ToUpper,
                                            txtDirigidoA.Text.ToUpper,
                                            txtSolicitante.Text.ToUpper, _
                                            txtSector.Text.ToUpper,
                                            txtDomicilio.Text.ToUpper,
                                            txtLocalidad.Text.ToUpper,
                                            txtCodigoPostal.Text.ToUpper,
                                            txtDespachado.Text.ToUpper,
                                            txtSeccion.Text.ToUpper,
                                            txtCantidadBultos.Text.ToUpper,
                                            txtNumeroBultos.Text.ToUpper, _
                                            txtUnidadxBulto.Text.ToUpper,
                                            txtTotalBultos.Text.ToUpper,
                                            txtPeso.Text.ToUpper,
                                            cboLogo.Text.ToUpper}
        dgv_Etiquetas.Rows.Add(row)
        ' Limpiar()
        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click

        If txtDescripcionEntrega.Text.Length = 0 Then
            MsgBox("La descripción del producto a entregar no puede estar vacío")
            txtDescripcionEntrega.Focus()
            Exit Sub
        End If
        If txtDirigidoA.Text.Length = 0 Then
            MsgBox("El nombre del cliente no puede quedar vacío")
            btnBuscarCliente.Focus()
            Exit Sub
        End If
        If txtDomicilio.Text.Length = 0 Then
            MsgBox("La dirección no puede quedar vacío")
            txtDomicilio.Focus()
            Exit Sub
        End If
        If txtCantidadBultos.Text.Length = 0 Then
            MsgBox("La cantidad de bultos no puede quedar vacío")
            txtCantidadBultos.Focus()
            Exit Sub
        End If
        If txtNumeroBultos.Text.Length = 0 Then
            MsgBox("El número de bultos no puede quedar vacío")
            txtNumeroBultos.Focus()
            Exit Sub
        End If
        If txtUnidadxBulto.Text.Length = 0 Then
            MsgBox("La unidad por bulto no puede quedar vacío")
            txtUnidadxBulto.Focus()
            Exit Sub
        End If
        If txtTotalBultos.Text.Length = 0 Then
            MsgBox("El total de bultos no puede quedar vacío")
            txtTotalBultos.Focus()
            Exit Sub
        End If
        CargaEtiqueta()

        ' txtDescripcionEntrega.Clear()
        '  txtDirigidoA.Clear()
        '  txtId_Cliente.Clear()
        ' txt_id_orden.Clear()
        ' txt_orden.Clear()
        '  txtSolicitante.Clear()
        '  txtSector.Clear()
        '  txtDomicilio.Clear()
        '  txtLocalidad.Clear()
        '  txtCodigoPostal.Clear()
        '  txtDespachado.Clear()
        ' txtSeccion.Clear()
        txtCantidadBultos.Clear()
        txtNumeroBultos.Clear()
        txtUnidadxBulto.Clear()
        txtTotalBultos.Clear()
        txtPeso.Clear()
        cboLogo.SelectedIndex = -1

        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnGenerarEtiquetas_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarEtiquetas.Click
        Dim consulta As String = "modelo_etiquetas_" + Date.Now.Millisecond.ToString + ".csv"
        Dim filePath As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta
        ' Dim filePath As String = "E:\trabajos\Trabajo Vale\Modelo de etiquetas\" + consulta
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        Try
            For i As Integer = 0 To dgv_Etiquetas.Rows.Count - 1
                Dim array As String() = New String(dgv_Etiquetas.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dgv_Etiquetas.Columns.Count - 1
                        array(j) = dgv_Etiquetas.Columns(j).HeaderText
                    Next
                    sb.AppendLine(String.Join(delimeter, array))
                End If
                For j As Integer = 0 To dgv_Etiquetas.Columns.Count - 1
                    array(j) = dgv_Etiquetas(j, i).Value.ToString
                Next
                If Not dgv_Etiquetas.Rows(i).IsNewRow Then
                    sb.AppendLine(String.Join(delimeter, array))
                End If
            Next
            File.WriteAllText(filePath, sb.ToString)
            MsgBox("La consulta se ha generado correctamente")

            '  Process.Start(filePath)
            txtCantidadBultos.Clear()
            txtNumeroBultos.Clear()
            txtUnidadxBulto.Clear()
            txtTotalBultos.Clear()
            txtPeso.Clear()
            cboLogo.SelectedIndex = -1

            dgv_Etiquetas.Rows.Clear()

        Catch ex As Exception
            MsgBox("Hubo un error al generar la consulta")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Select Case MsgBox("Se eliminará la fila seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Fila")
            Case MsgBoxResult.Yes
                For Each r As DataGridViewRow In dgv_Etiquetas.SelectedRows
                    dgv_Etiquetas.Rows.Remove(r)
                Next
        End Select
        dgv_Etiquetas.ClearSelection()
    End Sub

    Private Sub btnBuscar_Orden_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBuscar_Orden.Click
        frm_Listado_Orden_Trabajo.quienllamolistado_ot = Me
        frm_Listado_Orden_Trabajo.Text = "Seleccionar Orden"
        frm_Listado_Orden_Trabajo.Show()
    End Sub
End Class

