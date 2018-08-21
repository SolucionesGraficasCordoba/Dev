<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Tareas
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
        Me.GroupListadoTareas = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbo_sector = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvColaboradores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar_Tarea = New System.Windows.Forms.Button()
        Me.groupListadoDetalleTarea = New System.Windows.Forms.GroupBox()
        Me.btnModificar_Tarea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTarea_x_Colaborador = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupListadoTareas.SuspendLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupListadoDetalleTarea.SuspendLayout()
        CType(Me.dgvTarea_x_Colaborador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupListadoTareas
        '
        Me.GroupListadoTareas.Controls.Add(Me.dtpFecha)
        Me.GroupListadoTareas.Controls.Add(Me.Label31)
        Me.GroupListadoTareas.Controls.Add(Me.cbo_sector)
        Me.GroupListadoTareas.Controls.Add(Me.Label6)
        Me.GroupListadoTareas.Controls.Add(Me.Label5)
        Me.GroupListadoTareas.Controls.Add(Me.dgvColaboradores)
        Me.GroupListadoTareas.Controls.Add(Me.Label4)
        Me.GroupListadoTareas.Location = New System.Drawing.Point(28, 22)
        Me.GroupListadoTareas.Name = "GroupListadoTareas"
        Me.GroupListadoTareas.Size = New System.Drawing.Size(572, 312)
        Me.GroupListadoTareas.TabIndex = 4
        Me.GroupListadoTareas.TabStop = False
        Me.GroupListadoTareas.Text = "Listado de Tareas"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(187, 28)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecha.TabIndex = 48
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(144, 31)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 13)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Fecha"
        '
        'cbo_sector
        '
        Me.cbo_sector.FormattingEnabled = True
        Me.cbo_sector.Location = New System.Drawing.Point(382, 28)
        Me.cbo_sector.Name = "cbo_sector"
        Me.cbo_sector.Size = New System.Drawing.Size(176, 21)
        Me.cbo_sector.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(120, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Tareas"
        '
        'dgvColaboradores
        '
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradores.Location = New System.Drawing.Point(30, 65)
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColaboradores.Size = New System.Drawing.Size(528, 208)
        Me.dgvColaboradores.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sector"
        '
        'btnEliminar_Tarea
        '
        Me.btnEliminar_Tarea.Location = New System.Drawing.Point(433, 651)
        Me.btnEliminar_Tarea.Name = "btnEliminar_Tarea"
        Me.btnEliminar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Tarea.TabIndex = 3
        Me.btnEliminar_Tarea.Text = "Eliminar"
        Me.btnEliminar_Tarea.UseVisualStyleBackColor = True
        '
        'groupListadoDetalleTarea
        '
        Me.groupListadoDetalleTarea.Controls.Add(Me.Label1)
        Me.groupListadoDetalleTarea.Controls.Add(Me.Label2)
        Me.groupListadoDetalleTarea.Controls.Add(Me.dgvTarea_x_Colaborador)
        Me.groupListadoDetalleTarea.Location = New System.Drawing.Point(28, 349)
        Me.groupListadoDetalleTarea.Name = "groupListadoDetalleTarea"
        Me.groupListadoDetalleTarea.Size = New System.Drawing.Size(572, 287)
        Me.groupListadoDetalleTarea.TabIndex = 5
        Me.groupListadoDetalleTarea.TabStop = False
        Me.groupListadoDetalleTarea.Text = "Detalle de Tareas"
        '
        'btnModificar_Tarea
        '
        Me.btnModificar_Tarea.Location = New System.Drawing.Point(352, 651)
        Me.btnModificar_Tarea.Name = "btnModificar_Tarea"
        Me.btnModificar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar_Tarea.TabIndex = 31
        Me.btnModificar_Tarea.Text = "Modificar"
        Me.btnModificar_Tarea.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(131, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad de Tareas"
        '
        'dgvTarea_x_Colaborador
        '
        Me.dgvTarea_x_Colaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarea_x_Colaborador.Location = New System.Drawing.Point(15, 34)
        Me.dgvTarea_x_Colaborador.Name = "dgvTarea_x_Colaborador"
        Me.dgvTarea_x_Colaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTarea_x_Colaborador.Size = New System.Drawing.Size(537, 210)
        Me.dgvTarea_x_Colaborador.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(514, 651)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frm_Listado_Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 695)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar_Tarea)
        Me.Controls.Add(Me.groupListadoDetalleTarea)
        Me.Controls.Add(Me.GroupListadoTareas)
        Me.Controls.Add(Me.btnEliminar_Tarea)
        Me.Name = "frm_Listado_Tareas"
        Me.Text = "frm_Listado_Tareas"
        Me.GroupListadoTareas.ResumeLayout(False)
        Me.GroupListadoTareas.PerformLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupListadoDetalleTarea.ResumeLayout(False)
        Me.groupListadoDetalleTarea.PerformLayout()
        CType(Me.dgvTarea_x_Colaborador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoTareas As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Tarea As System.Windows.Forms.Button
    Friend WithEvents dgvColaboradores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents groupListadoDetalleTarea As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvTarea_x_Colaborador As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_sector As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificar_Tarea As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
