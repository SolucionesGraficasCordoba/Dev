<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usuario
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
        Me.lblTotal_Usuarios = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Usuario = New System.Windows.Forms.Button()
        Me.txt_Buscar_Usuario = New System.Windows.Forms.TextBox()
        Me.dgvLista_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevoColaborador = New System.Windows.Forms.GroupBox()
        Me.txt_id_colaborador = New System.Windows.Forms.TextBox()
        Me.btnBuscar_Colaborador = New System.Windows.Forms.Button()
        Me.txt_nombre_colaborador = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_perfil = New System.Windows.Forms.ComboBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar_Usuario = New System.Windows.Forms.Button()
        Me.btnActualizar_Usuario = New System.Windows.Forms.Button()
        Me.btnGuardar_Usuario = New System.Windows.Forms.Button()
        Me.btnNuevo_Usuario = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_id_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoClientes.SuspendLayout()
        CType(Me.dgvLista_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevoColaborador.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoClientes
        '
        Me.GroupListadoClientes.Controls.Add(Me.lblTotal_Usuarios)
        Me.GroupListadoClientes.Controls.Add(Me.Label5)
        Me.GroupListadoClientes.Controls.Add(Me.btnEliminar_Usuario)
        Me.GroupListadoClientes.Controls.Add(Me.txt_Buscar_Usuario)
        Me.GroupListadoClientes.Controls.Add(Me.dgvLista_Usuarios)
        Me.GroupListadoClientes.Controls.Add(Me.Label4)
        Me.GroupListadoClientes.Location = New System.Drawing.Point(25, 294)
        Me.GroupListadoClientes.Name = "GroupListadoClientes"
        Me.GroupListadoClientes.Size = New System.Drawing.Size(486, 318)
        Me.GroupListadoClientes.TabIndex = 7
        Me.GroupListadoClientes.TabStop = False
        Me.GroupListadoClientes.Text = "Listado de Usuarios"
        '
        'lblTotal_Usuarios
        '
        Me.lblTotal_Usuarios.AutoSize = True
        Me.lblTotal_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Usuarios.Location = New System.Drawing.Point(442, 285)
        Me.lblTotal_Usuarios.Name = "lblTotal_Usuarios"
        Me.lblTotal_Usuarios.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Usuarios.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Usuarios"
        '
        'btnEliminar_Usuario
        '
        Me.btnEliminar_Usuario.Location = New System.Drawing.Point(385, 38)
        Me.btnEliminar_Usuario.Name = "btnEliminar_Usuario"
        Me.btnEliminar_Usuario.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Usuario.TabIndex = 3
        Me.btnEliminar_Usuario.Text = "Eliminar"
        Me.btnEliminar_Usuario.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Usuario
        '
        Me.txt_Buscar_Usuario.Location = New System.Drawing.Point(74, 40)
        Me.txt_Buscar_Usuario.Name = "txt_Buscar_Usuario"
        Me.txt_Buscar_Usuario.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_Usuario.TabIndex = 2
        '
        'dgvLista_Usuarios
        '
        Me.dgvLista_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Usuarios.Location = New System.Drawing.Point(24, 67)
        Me.dgvLista_Usuarios.Name = "dgvLista_Usuarios"
        Me.dgvLista_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Usuarios.Size = New System.Drawing.Size(436, 206)
        Me.dgvLista_Usuarios.TabIndex = 0
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
        'GroupNuevoColaborador
        '
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_id_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnBuscar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_nombre_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label10)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label12)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label11)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label7)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label8)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label6)
        Me.GroupNuevoColaborador.Controls.Add(Me.cbo_perfil)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_contraseña)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label9)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnCancelar_Usuario)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnActualizar_Usuario)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnGuardar_Usuario)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnNuevo_Usuario)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_usuario)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_id_usuario)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label3)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label2)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label1)
        Me.GroupNuevoColaborador.Location = New System.Drawing.Point(25, 24)
        Me.GroupNuevoColaborador.Name = "GroupNuevoColaborador"
        Me.GroupNuevoColaborador.Size = New System.Drawing.Size(486, 250)
        Me.GroupNuevoColaborador.TabIndex = 6
        Me.GroupNuevoColaborador.TabStop = False
        Me.GroupNuevoColaborador.Text = "Nuevo Usuario"
        '
        'txt_id_colaborador
        '
        Me.txt_id_colaborador.Location = New System.Drawing.Point(412, 141)
        Me.txt_id_colaborador.Name = "txt_id_colaborador"
        Me.txt_id_colaborador.Size = New System.Drawing.Size(27, 20)
        Me.txt_id_colaborador.TabIndex = 11
        '
        'btnBuscar_Colaborador
        '
        Me.btnBuscar_Colaborador.Location = New System.Drawing.Point(355, 138)
        Me.btnBuscar_Colaborador.Name = "btnBuscar_Colaborador"
        Me.btnBuscar_Colaborador.Size = New System.Drawing.Size(51, 23)
        Me.btnBuscar_Colaborador.TabIndex = 10
        Me.btnBuscar_Colaborador.Text = "..."
        Me.btnBuscar_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_nombre_colaborador
        '
        Me.txt_nombre_colaborador.Location = New System.Drawing.Point(129, 140)
        Me.txt_nombre_colaborador.Name = "txt_nombre_colaborador"
        Me.txt_nombre_colaborador.Size = New System.Drawing.Size(208, 20)
        Me.txt_nombre_colaborador.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(342, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(340, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(342, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(342, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(21, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "* (Campo Requerido)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Colaborador"
        '
        'cbo_perfil
        '
        Me.cbo_perfil.FormattingEnabled = True
        Me.cbo_perfil.Items.AddRange(New Object() {"ADMINISTRADOR", "COLABORADOR", "GERENCIA", "SUPERVISOR"})
        Me.cbo_perfil.Location = New System.Drawing.Point(129, 103)
        Me.cbo_perfil.Name = "cbo_perfil"
        Me.cbo_perfil.Size = New System.Drawing.Size(208, 21)
        Me.cbo_perfil.TabIndex = 7
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(129, 67)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(208, 20)
        Me.txt_contraseña.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Contraseña"
        '
        'btnCancelar_Usuario
        '
        Me.btnCancelar_Usuario.Location = New System.Drawing.Point(355, 186)
        Me.btnCancelar_Usuario.Name = "btnCancelar_Usuario"
        Me.btnCancelar_Usuario.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Usuario.TabIndex = 2
        Me.btnCancelar_Usuario.Text = "Cancelar"
        Me.btnCancelar_Usuario.UseVisualStyleBackColor = True
        '
        'btnActualizar_Usuario
        '
        Me.btnActualizar_Usuario.Location = New System.Drawing.Point(260, 186)
        Me.btnActualizar_Usuario.Name = "btnActualizar_Usuario"
        Me.btnActualizar_Usuario.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Usuario.TabIndex = 2
        Me.btnActualizar_Usuario.Text = "Actualizar"
        Me.btnActualizar_Usuario.UseVisualStyleBackColor = True
        '
        'btnGuardar_Usuario
        '
        Me.btnGuardar_Usuario.Location = New System.Drawing.Point(162, 186)
        Me.btnGuardar_Usuario.Name = "btnGuardar_Usuario"
        Me.btnGuardar_Usuario.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Usuario.TabIndex = 4
        Me.btnGuardar_Usuario.Text = "Guardar"
        Me.btnGuardar_Usuario.UseVisualStyleBackColor = True
        '
        'btnNuevo_Usuario
        '
        Me.btnNuevo_Usuario.Location = New System.Drawing.Point(63, 186)
        Me.btnNuevo_Usuario.Name = "btnNuevo_Usuario"
        Me.btnNuevo_Usuario.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Usuario.TabIndex = 2
        Me.btnNuevo_Usuario.Text = "Nuevo"
        Me.btnNuevo_Usuario.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(129, 32)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(208, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Location = New System.Drawing.Point(419, 31)
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(61, 20)
        Me.txt_id_usuario.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Perfil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_usuario"
        '
        'frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 637)
        Me.Controls.Add(Me.GroupListadoClientes)
        Me.Controls.Add(Me.GroupNuevoColaborador)
        Me.Name = "frm_Usuario"
        Me.Text = "Usuario"
        Me.GroupListadoClientes.ResumeLayout(False)
        Me.GroupListadoClientes.PerformLayout()
        CType(Me.dgvLista_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevoColaborador.ResumeLayout(False)
        Me.GroupNuevoColaborador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal_Usuarios As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Usuario As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevoColaborador As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_perfil As System.Windows.Forms.ComboBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Usuario As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Usuario As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Usuario As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Usuario As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
