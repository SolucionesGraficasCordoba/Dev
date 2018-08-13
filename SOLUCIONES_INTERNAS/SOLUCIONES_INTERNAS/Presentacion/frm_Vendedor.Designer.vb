<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vendedor
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
        Me.GroupListadoClientes = New System.Windows.Forms.GroupBox()
        Me.lblTotal_Vendedores = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_vendedor = New System.Windows.Forms.Button()
        Me.txt_Buscar_vendedor = New System.Windows.Forms.TextBox()
        Me.dgvLista_vendedores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevoVendedor = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_telefono_vendedor = New System.Windows.Forms.TextBox()
        Me.txt_mail_vendedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_apellido_vendedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar_Vendedor = New System.Windows.Forms.Button()
        Me.btnActualizar_Vendedor = New System.Windows.Forms.Button()
        Me.btnGuardar_Vendedor = New System.Windows.Forms.Button()
        Me.btnNuevo_Vendedor = New System.Windows.Forms.Button()
        Me.txt_nombre_vendedor = New System.Windows.Forms.TextBox()
        Me.txt_id_vendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoClientes.SuspendLayout()
        CType(Me.dgvLista_vendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevoVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoClientes
        '
        Me.GroupListadoClientes.Controls.Add(Me.lblTotal_Vendedores)
        Me.GroupListadoClientes.Controls.Add(Me.Label5)
        Me.GroupListadoClientes.Controls.Add(Me.btnEliminar_vendedor)
        Me.GroupListadoClientes.Controls.Add(Me.txt_Buscar_vendedor)
        Me.GroupListadoClientes.Controls.Add(Me.dgvLista_vendedores)
        Me.GroupListadoClientes.Controls.Add(Me.Label4)
        Me.GroupListadoClientes.Location = New System.Drawing.Point(31, 311)
        Me.GroupListadoClientes.Name = "GroupListadoClientes"
        Me.GroupListadoClientes.Size = New System.Drawing.Size(486, 372)
        Me.GroupListadoClientes.TabIndex = 3
        Me.GroupListadoClientes.TabStop = False
        Me.GroupListadoClientes.Text = "Listado de Vendedores"
        '
        'lblTotal_Vendedores
        '
        Me.lblTotal_Vendedores.AutoSize = True
        Me.lblTotal_Vendedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Vendedores.Location = New System.Drawing.Point(444, 347)
        Me.lblTotal_Vendedores.Name = "lblTotal_Vendedores"
        Me.lblTotal_Vendedores.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Vendedores.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(320, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Vendedores"
        '
        'btnEliminar_vendedor
        '
        Me.btnEliminar_vendedor.Location = New System.Drawing.Point(385, 38)
        Me.btnEliminar_vendedor.Name = "btnEliminar_vendedor"
        Me.btnEliminar_vendedor.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_vendedor.TabIndex = 3
        Me.btnEliminar_vendedor.Text = "Eliminar"
        Me.btnEliminar_vendedor.UseVisualStyleBackColor = True
        '
        'txt_Buscar_vendedor
        '
        Me.txt_Buscar_vendedor.Location = New System.Drawing.Point(74, 40)
        Me.txt_Buscar_vendedor.Name = "txt_Buscar_vendedor"
        Me.txt_Buscar_vendedor.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_vendedor.TabIndex = 2
        '
        'dgvLista_vendedores
        '
        Me.dgvLista_vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_vendedores.Location = New System.Drawing.Point(24, 81)
        Me.dgvLista_vendedores.Name = "dgvLista_vendedores"
        Me.dgvLista_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_vendedores.Size = New System.Drawing.Size(436, 253)
        Me.dgvLista_vendedores.TabIndex = 0
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
        'GroupNuevoVendedor
        '
        Me.GroupNuevoVendedor.Controls.Add(Me.Label7)
        Me.GroupNuevoVendedor.Controls.Add(Me.txt_telefono_vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.txt_mail_vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.Label3)
        Me.GroupNuevoVendedor.Controls.Add(Me.txt_apellido_vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.Label9)
        Me.GroupNuevoVendedor.Controls.Add(Me.Label8)
        Me.GroupNuevoVendedor.Controls.Add(Me.btnCancelar_Vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.btnActualizar_Vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.btnGuardar_Vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.btnNuevo_Vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.txt_nombre_vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.txt_id_vendedor)
        Me.GroupNuevoVendedor.Controls.Add(Me.Label2)
        Me.GroupNuevoVendedor.Controls.Add(Me.Label1)
        Me.GroupNuevoVendedor.Location = New System.Drawing.Point(31, 33)
        Me.GroupNuevoVendedor.Name = "GroupNuevoVendedor"
        Me.GroupNuevoVendedor.Size = New System.Drawing.Size(486, 262)
        Me.GroupNuevoVendedor.TabIndex = 2
        Me.GroupNuevoVendedor.TabStop = False
        Me.GroupNuevoVendedor.Text = "Nuevo Vendedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Teléfono"
        '
        'txt_telefono_vendedor
        '
        Me.txt_telefono_vendedor.Location = New System.Drawing.Point(105, 171)
        Me.txt_telefono_vendedor.Name = "txt_telefono_vendedor"
        Me.txt_telefono_vendedor.Size = New System.Drawing.Size(164, 20)
        Me.txt_telefono_vendedor.TabIndex = 10
        '
        'txt_mail_vendedor
        '
        Me.txt_mail_vendedor.Location = New System.Drawing.Point(105, 130)
        Me.txt_mail_vendedor.Name = "txt_mail_vendedor"
        Me.txt_mail_vendedor.Size = New System.Drawing.Size(332, 20)
        Me.txt_mail_vendedor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mail"
        '
        'txt_apellido_vendedor
        '
        Me.txt_apellido_vendedor.Location = New System.Drawing.Point(105, 88)
        Me.txt_apellido_vendedor.Name = "txt_apellido_vendedor"
        Me.txt_apellido_vendedor.Size = New System.Drawing.Size(332, 20)
        Me.txt_apellido_vendedor.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Apellido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(102, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'btnCancelar_Vendedor
        '
        Me.btnCancelar_Vendedor.Location = New System.Drawing.Point(356, 216)
        Me.btnCancelar_Vendedor.Name = "btnCancelar_Vendedor"
        Me.btnCancelar_Vendedor.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Vendedor.TabIndex = 2
        Me.btnCancelar_Vendedor.Text = "Cancelar"
        Me.btnCancelar_Vendedor.UseVisualStyleBackColor = True
        '
        'btnActualizar_Vendedor
        '
        Me.btnActualizar_Vendedor.Location = New System.Drawing.Point(261, 216)
        Me.btnActualizar_Vendedor.Name = "btnActualizar_Vendedor"
        Me.btnActualizar_Vendedor.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Vendedor.TabIndex = 2
        Me.btnActualizar_Vendedor.Text = "Actualizar"
        Me.btnActualizar_Vendedor.UseVisualStyleBackColor = True
        '
        'btnGuardar_Vendedor
        '
        Me.btnGuardar_Vendedor.Location = New System.Drawing.Point(163, 216)
        Me.btnGuardar_Vendedor.Name = "btnGuardar_Vendedor"
        Me.btnGuardar_Vendedor.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Vendedor.TabIndex = 4
        Me.btnGuardar_Vendedor.Text = "Guardar"
        Me.btnGuardar_Vendedor.UseVisualStyleBackColor = True
        '
        'btnNuevo_Vendedor
        '
        Me.btnNuevo_Vendedor.Location = New System.Drawing.Point(64, 216)
        Me.btnNuevo_Vendedor.Name = "btnNuevo_Vendedor"
        Me.btnNuevo_Vendedor.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Vendedor.TabIndex = 2
        Me.btnNuevo_Vendedor.Text = "Nuevo"
        Me.btnNuevo_Vendedor.UseVisualStyleBackColor = True
        '
        'txt_nombre_vendedor
        '
        Me.txt_nombre_vendedor.Location = New System.Drawing.Point(105, 39)
        Me.txt_nombre_vendedor.Name = "txt_nombre_vendedor"
        Me.txt_nombre_vendedor.Size = New System.Drawing.Size(332, 20)
        Me.txt_nombre_vendedor.TabIndex = 1
        '
        'txt_id_vendedor
        '
        Me.txt_id_vendedor.Location = New System.Drawing.Point(365, 174)
        Me.txt_id_vendedor.Name = "txt_id_vendedor"
        Me.txt_id_vendedor.Size = New System.Drawing.Size(72, 20)
        Me.txt_id_vendedor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_vendedor"
        '
        'frm_Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 712)
        Me.Controls.Add(Me.GroupListadoClientes)
        Me.Controls.Add(Me.GroupNuevoVendedor)
        Me.Name = "frm_Vendedor"
        Me.Text = "Vendedor"
        Me.GroupListadoClientes.ResumeLayout(False)
        Me.GroupListadoClientes.PerformLayout()
        CType(Me.dgvLista_vendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevoVendedor.ResumeLayout(False)
        Me.GroupNuevoVendedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal_Vendedores As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_vendedor As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_vendedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevoVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Vendedor As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
