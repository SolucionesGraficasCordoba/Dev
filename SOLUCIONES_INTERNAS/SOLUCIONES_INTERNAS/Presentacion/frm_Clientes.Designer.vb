﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupNuevoCliente = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelar_Cliente = New System.Windows.Forms.Button()
        Me.btnActualizar_Cliente = New System.Windows.Forms.Button()
        Me.btnGuardar_Cliente = New System.Windows.Forms.Button()
        Me.btnNuevo_Cliente = New System.Windows.Forms.Button()
        Me.txt_telefono_cliente = New System.Windows.Forms.TextBox()
        Me.txt_mail_cliente = New System.Windows.Forms.TextBox()
        Me.txt_razonsocial_cliente = New System.Windows.Forms.TextBox()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoClientes = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Cliente = New System.Windows.Forms.Button()
        Me.txt_Buscar_Cliente = New System.Windows.Forms.TextBox()
        Me.dgvLista_Clientes = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevoCliente.SuspendLayout()
        Me.GroupListadoClientes.SuspendLayout()
        CType(Me.dgvLista_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupNuevoCliente
        '
        Me.GroupNuevoCliente.Controls.Add(Me.Label8)
        Me.GroupNuevoCliente.Controls.Add(Me.Label7)
        Me.GroupNuevoCliente.Controls.Add(Me.btnCancelar_Cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.btnActualizar_Cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.btnGuardar_Cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.btnNuevo_Cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_telefono_cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_mail_cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_razonsocial_cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_id_cliente)
        Me.GroupNuevoCliente.Controls.Add(Me.Label3)
        Me.GroupNuevoCliente.Controls.Add(Me.Label2)
        Me.GroupNuevoCliente.Controls.Add(Me.Label1)
        Me.GroupNuevoCliente.Location = New System.Drawing.Point(52, 23)
        Me.GroupNuevoCliente.Name = "GroupNuevoCliente"
        Me.GroupNuevoCliente.Size = New System.Drawing.Size(486, 221)
        Me.GroupNuevoCliente.TabIndex = 0
        Me.GroupNuevoCliente.TabStop = False
        Me.GroupNuevoCliente.Text = "Nuevo Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(105, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Teléfono"
        '
        'btnCancelar_Cliente
        '
        Me.btnCancelar_Cliente.Location = New System.Drawing.Point(365, 177)
        Me.btnCancelar_Cliente.Name = "btnCancelar_Cliente"
        Me.btnCancelar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Cliente.TabIndex = 2
        Me.btnCancelar_Cliente.Text = "Cancelar"
        Me.btnCancelar_Cliente.UseVisualStyleBackColor = True
        '
        'btnActualizar_Cliente
        '
        Me.btnActualizar_Cliente.Location = New System.Drawing.Point(270, 177)
        Me.btnActualizar_Cliente.Name = "btnActualizar_Cliente"
        Me.btnActualizar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Cliente.TabIndex = 2
        Me.btnActualizar_Cliente.Text = "Actualizar"
        Me.btnActualizar_Cliente.UseVisualStyleBackColor = True
        '
        'btnGuardar_Cliente
        '
        Me.btnGuardar_Cliente.Location = New System.Drawing.Point(172, 177)
        Me.btnGuardar_Cliente.Name = "btnGuardar_Cliente"
        Me.btnGuardar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Cliente.TabIndex = 4
        Me.btnGuardar_Cliente.Text = "Guardar"
        Me.btnGuardar_Cliente.UseVisualStyleBackColor = True
        '
        'btnNuevo_Cliente
        '
        Me.btnNuevo_Cliente.Location = New System.Drawing.Point(73, 177)
        Me.btnNuevo_Cliente.Name = "btnNuevo_Cliente"
        Me.btnNuevo_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Cliente.TabIndex = 2
        Me.btnNuevo_Cliente.Text = "Nuevo"
        Me.btnNuevo_Cliente.UseVisualStyleBackColor = True
        '
        'txt_telefono_cliente
        '
        Me.txt_telefono_cliente.Location = New System.Drawing.Point(108, 133)
        Me.txt_telefono_cliente.Name = "txt_telefono_cliente"
        Me.txt_telefono_cliente.Size = New System.Drawing.Size(164, 20)
        Me.txt_telefono_cliente.TabIndex = 3
        '
        'txt_mail_cliente
        '
        Me.txt_mail_cliente.Location = New System.Drawing.Point(108, 92)
        Me.txt_mail_cliente.Name = "txt_mail_cliente"
        Me.txt_mail_cliente.Size = New System.Drawing.Size(332, 20)
        Me.txt_mail_cliente.TabIndex = 2
        '
        'txt_razonsocial_cliente
        '
        Me.txt_razonsocial_cliente.Location = New System.Drawing.Point(108, 38)
        Me.txt_razonsocial_cliente.Name = "txt_razonsocial_cliente"
        Me.txt_razonsocial_cliente.Size = New System.Drawing.Size(332, 20)
        Me.txt_razonsocial_cliente.TabIndex = 1
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(354, 133)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_cliente.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Razón Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_cliente"
        '
        'GroupListadoClientes
        '
        Me.GroupListadoClientes.Controls.Add(Me.Label6)
        Me.GroupListadoClientes.Controls.Add(Me.Label5)
        Me.GroupListadoClientes.Controls.Add(Me.btnEliminar_Cliente)
        Me.GroupListadoClientes.Controls.Add(Me.txt_Buscar_Cliente)
        Me.GroupListadoClientes.Controls.Add(Me.dgvLista_Clientes)
        Me.GroupListadoClientes.Controls.Add(Me.Label4)
        Me.GroupListadoClientes.Location = New System.Drawing.Point(52, 260)
        Me.GroupListadoClientes.Name = "GroupListadoClientes"
        Me.GroupListadoClientes.Size = New System.Drawing.Size(486, 372)
        Me.GroupListadoClientes.TabIndex = 1
        Me.GroupListadoClientes.TabStop = False
        Me.GroupListadoClientes.Text = "Listado de Clientes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(444, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Clientes"
        '
        'btnEliminar_Cliente
        '
        Me.btnEliminar_Cliente.Location = New System.Drawing.Point(385, 38)
        Me.btnEliminar_Cliente.Name = "btnEliminar_Cliente"
        Me.btnEliminar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Cliente.TabIndex = 3
        Me.btnEliminar_Cliente.Text = "Eliminar"
        Me.btnEliminar_Cliente.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Cliente
        '
        Me.txt_Buscar_Cliente.Location = New System.Drawing.Point(74, 40)
        Me.txt_Buscar_Cliente.Name = "txt_Buscar_Cliente"
        Me.txt_Buscar_Cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_Cliente.TabIndex = 2
        '
        'dgvLista_Clientes
        '
        Me.dgvLista_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Clientes.Location = New System.Drawing.Point(24, 81)
        Me.dgvLista_Clientes.Name = "dgvLista_Clientes"
        Me.dgvLista_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Clientes.Size = New System.Drawing.Size(436, 253)
        Me.dgvLista_Clientes.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar"
        '
        'frm_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 656)
        Me.Controls.Add(Me.GroupListadoClientes)
        Me.Controls.Add(Me.GroupNuevoCliente)
        Me.Name = "frm_Cliente"
        Me.Text = "Clientes"
        Me.GroupNuevoCliente.ResumeLayout(False)
        Me.GroupNuevoCliente.PerformLayout()
        Me.GroupListadoClientes.ResumeLayout(False)
        Me.GroupListadoClientes.PerformLayout()
        CType(Me.dgvLista_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupNuevoCliente As System.Windows.Forms.GroupBox
    Friend WithEvents GroupListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar_Cliente As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Cliente As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Cliente As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Cliente As System.Windows.Forms.Button
    Friend WithEvents txt_telefono_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_razonsocial_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Cliente As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class