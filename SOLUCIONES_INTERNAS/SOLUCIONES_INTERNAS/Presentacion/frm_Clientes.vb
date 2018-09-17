﻿Public Class frm_Cliente
    Dim datacontext As New DataS_Interno
    Public quienllamocliente As Form


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_id_cliente.Visible = False
        Label1.Visible = False
        armargrilla()
        cargargrilla()
        dgvLista_Clientes.ClearSelection()
        txt_razonsocial_cliente.Focus()
        Label6.Text = dgvLista_Clientes.Rows.Count
        btnNuevo_Cliente.Visible = False
    End Sub

    Private Sub btnGuardar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Cliente.Click
        Try
            Dim buscacliente = (From cli In datacontext.CLIENTE Select cli.CLI_razon_social, cli.CLI_mail_cli, cli.CLI_telefono_cli Where CLI_razon_social = txt_razonsocial_cliente.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El cliente ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If

            If txt_razonsocial_cliente.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub

            End If
            Dim clie = New CLIENTE
            clie.CLI_razon_social = txt_razonsocial_cliente.Text
            clie.CLI_mail_cli = txt_mail_cliente.Text
            clie.CLI_telefono_cli = txt_telefono_cliente.Text


            datacontext.CLIENTE.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("El cliente se ha creado correctamente", vbInformation)
            cargargrilla()
            limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("El cliente NO fue creado")
            limpiarcontroles()
            cargargrilla()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_id_cliente.Clear()
        txt_razonsocial_cliente.Clear()
        txt_mail_cliente.Clear()
        txt_telefono_cliente.Clear()
    End Sub

    Private Sub btnActualizar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar_Cliente.Click
        If txt_razonsocial_cliente.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.CLIENTE Where P.CLI_id_cliente = (txt_id_cliente.Text.ToUpper)).ToList()(0)

            ActualizarCliente.CLI_razon_social = txt_razonsocial_cliente.Text
            ActualizarCliente.CLI_mail_cli = txt_mail_cliente.Text
            ActualizarCliente.CLI_telefono_cli = txt_telefono_cliente.Text
          
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            cargargrilla()
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            Me.limpiarcontroles()
            Me.cargargrilla()
        End Try
    End Sub

    Public Sub cargargrilla()

        Dim consultaCliente = From U In datacontext.CLIENTE
                              Select U.CLI_id_cliente, U.CLI_razon_social, U.CLI_mail_cli, U.CLI_telefono_cli
                              Order By CLI_razon_social Ascending
        dgvLista_Clientes.DataSource = consultaCliente
    End Sub

    Private Sub armargrilla()
        dgvLista_Clientes.Enabled = True
        dgvLista_Clientes.AutoGenerateColumns = False
        dgvLista_Clientes.Columns.Clear()

        dgvLista_Clientes.Columns.Add("CLI_id_cliente", "id_cliente")
        dgvLista_Clientes.Columns.Add("CLI_razon_social", " Razón Social")
        dgvLista_Clientes.Columns.Add("CLI_mail_cli", "Mail")
        dgvLista_Clientes.Columns.Add("CLI_telefono_cli", "Teléfono")

        dgvLista_Clientes.Columns(0).DataPropertyName = "CLI_id_cliente"
        dgvLista_Clientes.Columns(0).Visible = False
        dgvLista_Clientes.Columns(1).DataPropertyName = "CLI_razon_social"
        dgvLista_Clientes.Columns(1).Width = 200
        dgvLista_Clientes.Columns(2).DataPropertyName = "CLI_mail_cli"
        dgvLista_Clientes.Columns(2).Width = 150
        dgvLista_Clientes.Columns(3).DataPropertyName = "CLI_telefono_cli"
      

    End Sub


    Private Sub dgvLista_Clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLista_Clientes.Click
        If dgvLista_Clientes.SelectedRows.Count > 0 Then
            txt_id_cliente.Text = dgvLista_Clientes.Item("CLI_id_cliente", dgvLista_Clientes.SelectedRows(0).Index).Value
            txt_razonsocial_cliente.Text = dgvLista_Clientes.Item("CLI_razon_social", dgvLista_Clientes.SelectedRows(0).Index).Value
            txt_mail_cliente.Text = dgvLista_Clientes.Item("CLI_mail_cli", dgvLista_Clientes.SelectedRows(0).Index).Value
            txt_telefono_cliente.Text = dgvLista_Clientes.Item("CLI_telefono_cli", dgvLista_Clientes.SelectedRows(0).Index).Value
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub

    Private Sub btnEliminar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Cliente.Click
        If dgvLista_Clientes.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.CLIENTE Where C.CLI_id_cliente = CInt(dgvLista_Clientes.Item("CLI_id_cliente", dgvLista_Clientes.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el cliente seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente")
                Case MsgBoxResult.Yes
                    datacontext.CLIENTE.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El cliente ha sido eliminado")
                    cargargrilla()
                    Me.Close()
            End Select
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub

    Private Sub btnNuevo_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Cliente.Click
        Select Case MsgBox("Se limpiarán todos los campos, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Limpiar campos")
            Case MsgBoxResult.Yes
                limpiarcontroles()
        End Select
    End Sub

    Private Sub btnCancelar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Cliente.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Buscar_Cliente.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_Buscar_Cliente.Text & "*"
        Dim consultaalu = From U In datacontext.CLIENTE Select U.CLI_id_cliente, U.CLI_razon_social, U.CLI_mail_cli, U.CLI_telefono_cli Where CLI_razon_social Like buscar.ToString
        dgvLista_Clientes.DataSource = consultaalu
    End Sub

    Private Sub txt_razonsocial_cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_razonsocial_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_mail_cliente.Focus()
        End If
    End Sub

    Private Sub txt_mail_cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mail_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_telefono_cliente.Focus()
        End If
    End Sub

    Private Sub txt_telefono_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_telefono_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Cliente.Focus()
        End If
    End Sub

    Private Sub dgvLista_Clientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista_Clientes.CellDoubleClick

        If quienllamocliente.Name = frm_Etiqueta_Modelo_1.Name Then
            frm_Etiqueta_Modelo_1.txtId_Cliente.Text = dgvLista_Clientes.SelectedCells(0).Value
            frm_Etiqueta_Modelo_1.txtDirigidoA.Text = dgvLista_Clientes.SelectedCells(1).Value

        ElseIf quienllamocliente.Name = frm_Orden_Trabajo.Name Then
            frm_Orden_Trabajo.txt_id_cliente.Text = dgvLista_Clientes.SelectedCells(0).Value
            frm_Orden_Trabajo.txt_nombre_cliente.Text = dgvLista_Clientes.SelectedCells(1).Value
        End If
        Me.Close()
    End Sub
End Class
