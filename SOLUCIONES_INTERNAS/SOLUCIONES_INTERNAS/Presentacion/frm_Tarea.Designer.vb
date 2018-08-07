<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Tarea
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Tarea = New System.Windows.Forms.Button()
        Me.txt_Buscar_Tarea = New System.Windows.Forms.TextBox()
        Me.dgvLista_Tareas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevaTarea = New System.Windows.Forms.GroupBox()
        Me.txt_Carga_Horaria = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTiempo_Real = New System.Windows.Forms.TextBox()
        Me.txtTiempo_Estimado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHora_Finalizacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_detalle_tarea = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscar_Numero_Orden = New System.Windows.Forms.Button()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar_Colaborador = New System.Windows.Forms.Button()
        Me.txt_nombre_colaborador = New System.Windows.Forms.TextBox()
        Me.btnCancelar_Tarea = New System.Windows.Forms.Button()
        Me.btnActualizar_Tarea = New System.Windows.Forms.Button()
        Me.btnGuardar_Tarea = New System.Windows.Forms.Button()
        Me.btnNueva_Tarea = New System.Windows.Forms.Button()
        Me.txt_id_colaborador = New System.Windows.Forms.TextBox()
        Me.txt_id_tarea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoClientes.SuspendLayout()
        CType(Me.dgvLista_Tareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevaTarea.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoClientes
        '
        Me.GroupListadoClientes.Controls.Add(Me.Label6)
        Me.GroupListadoClientes.Controls.Add(Me.Label5)
        Me.GroupListadoClientes.Controls.Add(Me.btnEliminar_Tarea)
        Me.GroupListadoClientes.Controls.Add(Me.txt_Buscar_Tarea)
        Me.GroupListadoClientes.Controls.Add(Me.dgvLista_Tareas)
        Me.GroupListadoClientes.Controls.Add(Me.Label4)
        Me.GroupListadoClientes.Location = New System.Drawing.Point(34, 459)
        Me.GroupListadoClientes.Name = "GroupListadoClientes"
        Me.GroupListadoClientes.Size = New System.Drawing.Size(486, 372)
        Me.GroupListadoClientes.TabIndex = 3
        Me.GroupListadoClientes.TabStop = False
        Me.GroupListadoClientes.Text = "Listado de Tareas"
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
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Tareas"
        '
        'btnEliminar_Tarea
        '
        Me.btnEliminar_Tarea.Location = New System.Drawing.Point(385, 38)
        Me.btnEliminar_Tarea.Name = "btnEliminar_Tarea"
        Me.btnEliminar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Tarea.TabIndex = 3
        Me.btnEliminar_Tarea.Text = "Eliminar"
        Me.btnEliminar_Tarea.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Tarea
        '
        Me.txt_Buscar_Tarea.Location = New System.Drawing.Point(74, 40)
        Me.txt_Buscar_Tarea.Name = "txt_Buscar_Tarea"
        Me.txt_Buscar_Tarea.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_Tarea.TabIndex = 2
        '
        'dgvLista_Tareas
        '
        Me.dgvLista_Tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Tareas.Location = New System.Drawing.Point(24, 81)
        Me.dgvLista_Tareas.Name = "dgvLista_Tareas"
        Me.dgvLista_Tareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Tareas.Size = New System.Drawing.Size(436, 253)
        Me.dgvLista_Tareas.TabIndex = 0
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
        'GroupNuevaTarea
        '
        Me.GroupNuevaTarea.Controls.Add(Me.txt_Carga_Horaria)
        Me.GroupNuevaTarea.Controls.Add(Me.Label13)
        Me.GroupNuevaTarea.Controls.Add(Me.txtTiempo_Real)
        Me.GroupNuevaTarea.Controls.Add(Me.txtTiempo_Estimado)
        Me.GroupNuevaTarea.Controls.Add(Me.Label9)
        Me.GroupNuevaTarea.Controls.Add(Me.Label2)
        Me.GroupNuevaTarea.Controls.Add(Me.txtHora_Finalizacion)
        Me.GroupNuevaTarea.Controls.Add(Me.Label12)
        Me.GroupNuevaTarea.Controls.Add(Me.Label14)
        Me.GroupNuevaTarea.Controls.Add(Me.txt_detalle_tarea)
        Me.GroupNuevaTarea.Controls.Add(Me.Label10)
        Me.GroupNuevaTarea.Controls.Add(Me.txtObservaciones)
        Me.GroupNuevaTarea.Controls.Add(Me.Label8)
        Me.GroupNuevaTarea.Controls.Add(Me.Label11)
        Me.GroupNuevaTarea.Controls.Add(Me.btnBuscar_Numero_Orden)
        Me.GroupNuevaTarea.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.GroupNuevaTarea.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupNuevaTarea.Controls.Add(Me.Label7)
        Me.GroupNuevaTarea.Controls.Add(Me.btnBuscar_Colaborador)
        Me.GroupNuevaTarea.Controls.Add(Me.txt_nombre_colaborador)
        Me.GroupNuevaTarea.Controls.Add(Me.btnCancelar_Tarea)
        Me.GroupNuevaTarea.Controls.Add(Me.btnActualizar_Tarea)
        Me.GroupNuevaTarea.Controls.Add(Me.btnGuardar_Tarea)
        Me.GroupNuevaTarea.Controls.Add(Me.btnNueva_Tarea)
        Me.GroupNuevaTarea.Controls.Add(Me.txt_id_colaborador)
        Me.GroupNuevaTarea.Controls.Add(Me.txt_id_tarea)
        Me.GroupNuevaTarea.Controls.Add(Me.Label3)
        Me.GroupNuevaTarea.Controls.Add(Me.Label1)
        Me.GroupNuevaTarea.Location = New System.Drawing.Point(34, 32)
        Me.GroupNuevaTarea.Name = "GroupNuevaTarea"
        Me.GroupNuevaTarea.Size = New System.Drawing.Size(486, 407)
        Me.GroupNuevaTarea.TabIndex = 2
        Me.GroupNuevaTarea.TabStop = False
        Me.GroupNuevaTarea.Text = "Nueva Tarea"
        '
        'txt_Carga_Horaria
        '
        Me.txt_Carga_Horaria.Location = New System.Drawing.Point(350, 168)
        Me.txt_Carga_Horaria.Name = "txt_Carga_Horaria"
        Me.txt_Carga_Horaria.Size = New System.Drawing.Size(108, 20)
        Me.txt_Carga_Horaria.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(266, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Carga horaria"
        '
        'txtTiempo_Real
        '
        Me.txtTiempo_Real.Location = New System.Drawing.Point(109, 205)
        Me.txtTiempo_Real.Name = "txtTiempo_Real"
        Me.txtTiempo_Real.Size = New System.Drawing.Size(76, 20)
        Me.txtTiempo_Real.TabIndex = 31
        '
        'txtTiempo_Estimado
        '
        Me.txtTiempo_Estimado.Location = New System.Drawing.Point(109, 171)
        Me.txtTiempo_Estimado.Name = "txtTiempo_Estimado"
        Me.txtTiempo_Estimado.Size = New System.Drawing.Size(76, 20)
        Me.txtTiempo_Estimado.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tiempo real"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tiempo estimado"
        '
        'txtHora_Finalizacion
        '
        Me.txtHora_Finalizacion.Location = New System.Drawing.Point(350, 208)
        Me.txtHora_Finalizacion.Name = "txtHora_Finalizacion"
        Me.txtHora_Finalizacion.Size = New System.Drawing.Size(108, 20)
        Me.txtHora_Finalizacion.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(244, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Hora de finalización"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(71, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "(Campo Requerido)"
        '
        'txt_detalle_tarea
        '
        Me.txt_detalle_tarea.Location = New System.Drawing.Point(70, 32)
        Me.txt_detalle_tarea.Name = "txt_detalle_tarea"
        Me.txt_detalle_tarea.Size = New System.Drawing.Size(398, 20)
        Me.txt_detalle_tarea.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Tarea"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(109, 245)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(351, 100)
        Me.txtObservaciones.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(150, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Observaciones"
        '
        'btnBuscar_Numero_Orden
        '
        Me.btnBuscar_Numero_Orden.Location = New System.Drawing.Point(384, 121)
        Me.btnBuscar_Numero_Orden.Name = "btnBuscar_Numero_Orden"
        Me.btnBuscar_Numero_Orden.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar_Numero_Orden.TabIndex = 13
        Me.btnBuscar_Numero_Orden.Text = "..."
        Me.btnBuscar_Numero_Orden.UseVisualStyleBackColor = True
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(150, 123)
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(226, 20)
        Me.txtNumero_Orden_Trabajo.TabIndex = 12
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(104, 123)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(40, 20)
        Me.txt_id_orden_trabajo.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Orden de trabajo"
        '
        'btnBuscar_Colaborador
        '
        Me.btnBuscar_Colaborador.Location = New System.Drawing.Point(384, 80)
        Me.btnBuscar_Colaborador.Name = "btnBuscar_Colaborador"
        Me.btnBuscar_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar_Colaborador.TabIndex = 9
        Me.btnBuscar_Colaborador.Text = "..."
        Me.btnBuscar_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_nombre_colaborador
        '
        Me.txt_nombre_colaborador.Location = New System.Drawing.Point(150, 82)
        Me.txt_nombre_colaborador.Name = "txt_nombre_colaborador"
        Me.txt_nombre_colaborador.Size = New System.Drawing.Size(226, 20)
        Me.txt_nombre_colaborador.TabIndex = 8
        '
        'btnCancelar_Tarea
        '
        Me.btnCancelar_Tarea.Location = New System.Drawing.Point(364, 363)
        Me.btnCancelar_Tarea.Name = "btnCancelar_Tarea"
        Me.btnCancelar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Tarea.TabIndex = 2
        Me.btnCancelar_Tarea.Text = "Cancelar"
        Me.btnCancelar_Tarea.UseVisualStyleBackColor = True
        '
        'btnActualizar_Tarea
        '
        Me.btnActualizar_Tarea.Location = New System.Drawing.Point(269, 363)
        Me.btnActualizar_Tarea.Name = "btnActualizar_Tarea"
        Me.btnActualizar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Tarea.TabIndex = 2
        Me.btnActualizar_Tarea.Text = "Actualizar"
        Me.btnActualizar_Tarea.UseVisualStyleBackColor = True
        '
        'btnGuardar_Tarea
        '
        Me.btnGuardar_Tarea.Location = New System.Drawing.Point(171, 363)
        Me.btnGuardar_Tarea.Name = "btnGuardar_Tarea"
        Me.btnGuardar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Tarea.TabIndex = 4
        Me.btnGuardar_Tarea.Text = "Guardar"
        Me.btnGuardar_Tarea.UseVisualStyleBackColor = True
        '
        'btnNueva_Tarea
        '
        Me.btnNueva_Tarea.Location = New System.Drawing.Point(72, 363)
        Me.btnNueva_Tarea.Name = "btnNueva_Tarea"
        Me.btnNueva_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnNueva_Tarea.TabIndex = 2
        Me.btnNueva_Tarea.Text = "Nuevo"
        Me.btnNueva_Tarea.UseVisualStyleBackColor = True
        '
        'txt_id_colaborador
        '
        Me.txt_id_colaborador.Location = New System.Drawing.Point(104, 82)
        Me.txt_id_colaborador.Name = "txt_id_colaborador"
        Me.txt_id_colaborador.Size = New System.Drawing.Size(40, 20)
        Me.txt_id_colaborador.TabIndex = 2
        '
        'txt_id_tarea
        '
        Me.txt_id_tarea.Location = New System.Drawing.Point(28, 314)
        Me.txt_id_tarea.Name = "txt_id_tarea"
        Me.txt_id_tarea.Size = New System.Drawing.Size(66, 20)
        Me.txt_id_tarea.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Colaborador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_tarea"
        '
        'frm_Tarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 843)
        Me.Controls.Add(Me.GroupListadoClientes)
        Me.Controls.Add(Me.GroupNuevaTarea)
        Me.Name = "frm_Tarea"
        Me.Text = "Tarea"
        Me.GroupListadoClientes.ResumeLayout(False)
        Me.GroupListadoClientes.PerformLayout()
        CType(Me.dgvLista_Tareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevaTarea.ResumeLayout(False)
        Me.GroupNuevaTarea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Tarea As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Tarea As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Tareas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevaTarea As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Tarea As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Tarea As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Tarea As System.Windows.Forms.Button
    Friend WithEvents btnNueva_Tarea As System.Windows.Forms.Button
    Friend WithEvents txt_id_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_tarea As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Numero_Orden As System.Windows.Forms.Button
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHora_Finalizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_detalle_tarea As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Carga_Horaria As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTiempo_Real As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempo_Estimado As System.Windows.Forms.TextBox
End Class
