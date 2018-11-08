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
        Me.Btn_informe_diario = New System.Windows.Forms.Button()
        Me.btnModificarTodas = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbo_sector = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvColaboradores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar_Tarea = New System.Windows.Forms.Button()
        Me.groupListadoDetalleTarea = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTarea_x_Colaborador = New System.Windows.Forms.DataGridView()
        Me.btnModificar_Una = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnExportarListado = New System.Windows.Forms.Button()
        Me.GroupListadoTareas.SuspendLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupListadoDetalleTarea.SuspendLayout()
        CType(Me.dgvTarea_x_Colaborador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupListadoTareas
        '
        Me.GroupListadoTareas.Controls.Add(Me.Btn_informe_diario)
        Me.GroupListadoTareas.Controls.Add(Me.btnModificarTodas)
        Me.GroupListadoTareas.Controls.Add(Me.dtpFecha)
        Me.GroupListadoTareas.Controls.Add(Me.Label31)
        Me.GroupListadoTareas.Controls.Add(Me.cbo_sector)
        Me.GroupListadoTareas.Controls.Add(Me.Label6)
        Me.GroupListadoTareas.Controls.Add(Me.Label5)
        Me.GroupListadoTareas.Controls.Add(Me.dgvColaboradores)
        Me.GroupListadoTareas.Controls.Add(Me.Label4)
        Me.GroupListadoTareas.Location = New System.Drawing.Point(12, 12)
        Me.GroupListadoTareas.Name = "GroupListadoTareas"
        Me.GroupListadoTareas.Size = New System.Drawing.Size(512, 272)
        Me.GroupListadoTareas.TabIndex = 4
        Me.GroupListadoTareas.TabStop = False
        Me.GroupListadoTareas.Text = "Listado de Tareas"
        '
        'Btn_informe_diario
        '
        Me.Btn_informe_diario.Location = New System.Drawing.Point(269, 241)
        Me.Btn_informe_diario.Name = "Btn_informe_diario"
        Me.Btn_informe_diario.Size = New System.Drawing.Size(91, 23)
        Me.Btn_informe_diario.TabIndex = 3
        Me.Btn_informe_diario.Text = "Informe diario"
        Me.Btn_informe_diario.UseVisualStyleBackColor = True
        '
        'btnModificarTodas
        '
        Me.btnModificarTodas.Location = New System.Drawing.Point(391, 241)
        Me.btnModificarTodas.Name = "btnModificarTodas"
        Me.btnModificarTodas.Size = New System.Drawing.Size(104, 23)
        Me.btnModificarTodas.TabIndex = 4
        Me.btnModificarTodas.Text = "Modificar Todas"
        Me.btnModificarTodas.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(129, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(86, 23)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 13)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Fecha"
        '
        'cbo_sector
        '
        Me.cbo_sector.FormattingEnabled = True
        Me.cbo_sector.Location = New System.Drawing.Point(301, 19)
        Me.cbo_sector.Name = "cbo_sector"
        Me.cbo_sector.Size = New System.Drawing.Size(114, 21)
        Me.cbo_sector.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(178, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Colaboradores del sector"
        '
        'dgvColaboradores
        '
        Me.dgvColaboradores.AllowUserToAddRows = False
        Me.dgvColaboradores.AllowUserToDeleteRows = False
        Me.dgvColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradores.Location = New System.Drawing.Point(9, 46)
        Me.dgvColaboradores.MultiSelect = False
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColaboradores.Size = New System.Drawing.Size(486, 189)
        Me.dgvColaboradores.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sector"
        '
        'btnEliminar_Tarea
        '
        Me.btnEliminar_Tarea.Location = New System.Drawing.Point(390, 550)
        Me.btnEliminar_Tarea.Name = "btnEliminar_Tarea"
        Me.btnEliminar_Tarea.Size = New System.Drawing.Size(63, 23)
        Me.btnEliminar_Tarea.TabIndex = 9
        Me.btnEliminar_Tarea.Text = "Eliminar"
        Me.btnEliminar_Tarea.UseVisualStyleBackColor = True
        '
        'groupListadoDetalleTarea
        '
        Me.groupListadoDetalleTarea.Controls.Add(Me.Label35)
        Me.groupListadoDetalleTarea.Controls.Add(Me.Label7)
        Me.groupListadoDetalleTarea.Controls.Add(Me.Label1)
        Me.groupListadoDetalleTarea.Controls.Add(Me.Label2)
        Me.groupListadoDetalleTarea.Controls.Add(Me.dgvTarea_x_Colaborador)
        Me.groupListadoDetalleTarea.Location = New System.Drawing.Point(12, 290)
        Me.groupListadoDetalleTarea.Name = "groupListadoDetalleTarea"
        Me.groupListadoDetalleTarea.Size = New System.Drawing.Size(512, 254)
        Me.groupListadoDetalleTarea.TabIndex = 5
        Me.groupListadoDetalleTarea.TabStop = False
        Me.groupListadoDetalleTarea.Text = "Detalle de Tareas"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(389, 233)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(2, 15)
        Me.Label35.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(307, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Total estimado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(121, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad de Tareas"
        '
        'dgvTarea_x_Colaborador
        '
        Me.dgvTarea_x_Colaborador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTarea_x_Colaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarea_x_Colaborador.Location = New System.Drawing.Point(15, 19)
        Me.dgvTarea_x_Colaborador.Name = "dgvTarea_x_Colaborador"
        Me.dgvTarea_x_Colaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTarea_x_Colaborador.Size = New System.Drawing.Size(480, 210)
        Me.dgvTarea_x_Colaborador.TabIndex = 11
        '
        'btnModificar_Una
        '
        Me.btnModificar_Una.Location = New System.Drawing.Point(299, 550)
        Me.btnModificar_Una.Name = "btnModificar_Una"
        Me.btnModificar_Una.Size = New System.Drawing.Size(85, 23)
        Me.btnModificar_Una.TabIndex = 8
        Me.btnModificar_Una.Text = "Modificar Una"
        Me.btnModificar_Una.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(459, 550)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(63, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(205, 550)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar Tarea"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(144, 550)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(55, 23)
        Me.btnVer.TabIndex = 6
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnExportarListado
        '
        Me.btnExportarListado.Location = New System.Drawing.Point(8, 550)
        Me.btnExportarListado.Name = "btnExportarListado"
        Me.btnExportarListado.Size = New System.Drawing.Size(130, 23)
        Me.btnExportarListado.TabIndex = 5
        Me.btnExportarListado.Text = "Exportar Listado a PDF"
        Me.btnExportarListado.UseVisualStyleBackColor = True
        '
        'frm_Listado_Tareas
        '
        Me.AcceptButton = Me.Btn_informe_diario
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(536, 584)
        Me.Controls.Add(Me.btnExportarListado)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar_Una)
        Me.Controls.Add(Me.groupListadoDetalleTarea)
        Me.Controls.Add(Me.GroupListadoTareas)
        Me.Controls.Add(Me.btnEliminar_Tarea)
        Me.Name = "frm_Listado_Tareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Tareas y Detalles"
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
    Friend WithEvents btnModificar_Una As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnExportarListado As System.Windows.Forms.Button
    Friend WithEvents btnModificarTodas As System.Windows.Forms.Button
    Friend WithEvents Btn_informe_diario As System.Windows.Forms.Button
End Class
