<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.GroupNuevoCliente.SuspendLayout()
        Me.GroupListadoClientes.SuspendLayout()
        CType(Me.dgvLista_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupNuevoCliente
        '
        Me.GroupNuevoCliente.Controls.Add(Me.Label11)
        Me.GroupNuevoCliente.Controls.Add(Me.TextBox3)
        Me.GroupNuevoCliente.Controls.Add(Me.Label9)
        Me.GroupNuevoCliente.Controls.Add(Me.txtLocalidad)
        Me.GroupNuevoCliente.Controls.Add(Me.Label10)
        Me.GroupNuevoCliente.Controls.Add(Me.TextBox2)
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
        Me.GroupNuevoCliente.Location = New System.Drawing.Point(26, 21)
        Me.GroupNuevoCliente.Name = "GroupNuevoCliente"
        Me.GroupNuevoCliente.Size = New System.Drawing.Size(486, 260)
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
        Me.Label7.Location = New System.Drawing.Point(201, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "CP"
        '
        'btnCancelar_Cliente
        '
        Me.btnCancelar_Cliente.Location = New System.Drawing.Point(355, 231)
        Me.btnCancelar_Cliente.Name = "btnCancelar_Cliente"
        Me.btnCancelar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Cliente.TabIndex = 2
        Me.btnCancelar_Cliente.Text = "Cancelar"
        Me.btnCancelar_Cliente.UseVisualStyleBackColor = True
        '
        'btnActualizar_Cliente
        '
        Me.btnActualizar_Cliente.Location = New System.Drawing.Point(260, 231)
        Me.btnActualizar_Cliente.Name = "btnActualizar_Cliente"
        Me.btnActualizar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Cliente.TabIndex = 2
        Me.btnActualizar_Cliente.Text = "Actualizar"
        Me.btnActualizar_Cliente.UseVisualStyleBackColor = True
        '
        'btnGuardar_Cliente
        '
        Me.btnGuardar_Cliente.Location = New System.Drawing.Point(162, 231)
        Me.btnGuardar_Cliente.Name = "btnGuardar_Cliente"
        Me.btnGuardar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Cliente.TabIndex = 4
        Me.btnGuardar_Cliente.Text = "Guardar"
        Me.btnGuardar_Cliente.UseVisualStyleBackColor = True
        '
        'btnNuevo_Cliente
        '
        Me.btnNuevo_Cliente.Location = New System.Drawing.Point(63, 231)
        Me.btnNuevo_Cliente.Name = "btnNuevo_Cliente"
        Me.btnNuevo_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Cliente.TabIndex = 2
        Me.btnNuevo_Cliente.Text = "Nuevo"
        Me.btnNuevo_Cliente.UseVisualStyleBackColor = True
        '
        'txt_telefono_cliente
        '
        Me.txt_telefono_cliente.Location = New System.Drawing.Point(226, 189)
        Me.txt_telefono_cliente.Name = "txt_telefono_cliente"
        Me.txt_telefono_cliente.Size = New System.Drawing.Size(63, 20)
        Me.txt_telefono_cliente.TabIndex = 3
        '
        'txt_mail_cliente
        '
        Me.txt_mail_cliente.Location = New System.Drawing.Point(108, 92)
        Me.txt_mail_cliente.Name = "txt_mail_cliente"
        Me.txt_mail_cliente.Size = New System.Drawing.Size(352, 20)
        Me.txt_mail_cliente.TabIndex = 2
        '
        'txt_razonsocial_cliente
        '
        Me.txt_razonsocial_cliente.Location = New System.Drawing.Point(90, 38)
        Me.txt_razonsocial_cliente.Name = "txt_razonsocial_cliente"
        Me.txt_razonsocial_cliente.Size = New System.Drawing.Size(370, 20)
        Me.txt_razonsocial_cliente.TabIndex = 1
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(365, 12)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(24, 20)
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
        Me.Label1.Location = New System.Drawing.Point(307, 15)
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
        Me.GroupListadoClientes.Location = New System.Drawing.Point(26, 287)
        Me.GroupListadoClientes.Name = "GroupListadoClientes"
        Me.GroupListadoClientes.Size = New System.Drawing.Size(486, 338)
        Me.GroupListadoClientes.TabIndex = 1
        Me.GroupListadoClientes.TabStop = False
        Me.GroupListadoClientes.Text = "Listado de Clientes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(447, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Clientes"
        '
        'btnEliminar_Cliente
        '
        Me.btnEliminar_Cliente.Location = New System.Drawing.Point(385, 19)
        Me.btnEliminar_Cliente.Name = "btnEliminar_Cliente"
        Me.btnEliminar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Cliente.TabIndex = 3
        Me.btnEliminar_Cliente.Text = "Eliminar"
        Me.btnEliminar_Cliente.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Cliente
        '
        Me.txt_Buscar_Cliente.Location = New System.Drawing.Point(185, 21)
        Me.txt_Buscar_Cliente.Name = "txt_Buscar_Cliente"
        Me.txt_Buscar_Cliente.Size = New System.Drawing.Size(167, 20)
        Me.txt_Buscar_Cliente.TabIndex = 2
        '
        'dgvLista_Clientes
        '
        Me.dgvLista_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Clientes.Location = New System.Drawing.Point(24, 58)
        Me.dgvLista_Clientes.Name = "dgvLista_Clientes"
        Me.dgvLista_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Clientes.Size = New System.Drawing.Size(436, 253)
        Me.dgvLista_Clientes.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingrese Nombre/Razón Social"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Teléfono"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(353, 189)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(107, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Dirección"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(68, 139)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(392, 20)
        Me.TextBox3.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Localidad"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(63, 189)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(130, 20)
        Me.txtLocalidad.TabIndex = 13
        '
        'frm_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 637)
        Me.Controls.Add(Me.GroupListadoClientes)
        Me.Controls.Add(Me.GroupNuevoCliente)
        Me.Name = "frm_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
