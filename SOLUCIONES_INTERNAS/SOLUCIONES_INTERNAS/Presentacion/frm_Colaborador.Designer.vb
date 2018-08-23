<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Colaborador
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
        Me.GroupListadoColaboradores = New System.Windows.Forms.GroupBox()
        Me.lblTotal_Colaboradores = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Colaborador = New System.Windows.Forms.Button()
        Me.txt_Buscar_Colaborador = New System.Windows.Forms.TextBox()
        Me.dgvLista_Colaboradores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevoColaborador = New System.Windows.Forms.GroupBox()
        Me.cbo_sector = New System.Windows.Forms.ComboBox()
        Me.txt_apellido_colaborador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar_Colaborador = New System.Windows.Forms.Button()
        Me.btnActualizar_Colaborador = New System.Windows.Forms.Button()
        Me.btnGuardar_Colaborador = New System.Windows.Forms.Button()
        Me.btnNuevo_Colaborador = New System.Windows.Forms.Button()
        Me.txt_nombre_colaborador = New System.Windows.Forms.TextBox()
        Me.txt_id_colaborador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoColaboradores.SuspendLayout()
        CType(Me.dgvLista_Colaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevoColaborador.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoColaboradores
        '
        Me.GroupListadoColaboradores.Controls.Add(Me.lblTotal_Colaboradores)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label5)
        Me.GroupListadoColaboradores.Controls.Add(Me.btnEliminar_Colaborador)
        Me.GroupListadoColaboradores.Controls.Add(Me.txt_Buscar_Colaborador)
        Me.GroupListadoColaboradores.Controls.Add(Me.dgvLista_Colaboradores)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label4)
        Me.GroupListadoColaboradores.Location = New System.Drawing.Point(30, 268)
        Me.GroupListadoColaboradores.Name = "GroupListadoColaboradores"
        Me.GroupListadoColaboradores.Size = New System.Drawing.Size(486, 372)
        Me.GroupListadoColaboradores.TabIndex = 5
        Me.GroupListadoColaboradores.TabStop = False
        Me.GroupListadoColaboradores.Text = "Listado de Colaborador"
        '
        'lblTotal_Colaboradores
        '
        Me.lblTotal_Colaboradores.AutoSize = True
        Me.lblTotal_Colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Colaboradores.Location = New System.Drawing.Point(444, 347)
        Me.lblTotal_Colaboradores.Name = "lblTotal_Colaboradores"
        Me.lblTotal_Colaboradores.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Colaboradores.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Colaboradores"
        '
        'btnEliminar_Colaborador
        '
        Me.btnEliminar_Colaborador.Location = New System.Drawing.Point(385, 38)
        Me.btnEliminar_Colaborador.Name = "btnEliminar_Colaborador"
        Me.btnEliminar_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Colaborador.TabIndex = 3
        Me.btnEliminar_Colaborador.Text = "Eliminar"
        Me.btnEliminar_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Colaborador
        '
        Me.txt_Buscar_Colaborador.Location = New System.Drawing.Point(74, 40)
        Me.txt_Buscar_Colaborador.Name = "txt_Buscar_Colaborador"
        Me.txt_Buscar_Colaborador.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_Colaborador.TabIndex = 2
        '
        'dgvLista_Colaboradores
        '
        Me.dgvLista_Colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Colaboradores.Location = New System.Drawing.Point(24, 81)
        Me.dgvLista_Colaboradores.Name = "dgvLista_Colaboradores"
        Me.dgvLista_Colaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Colaboradores.Size = New System.Drawing.Size(436, 253)
        Me.dgvLista_Colaboradores.TabIndex = 0
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
        Me.GroupNuevoColaborador.Controls.Add(Me.cbo_sector)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_apellido_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label9)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label8)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnCancelar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnActualizar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnGuardar_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.btnNuevo_Colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_nombre_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.txt_id_colaborador)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label3)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label2)
        Me.GroupNuevoColaborador.Controls.Add(Me.Label1)
        Me.GroupNuevoColaborador.Location = New System.Drawing.Point(30, 26)
        Me.GroupNuevoColaborador.Name = "GroupNuevoColaborador"
        Me.GroupNuevoColaborador.Size = New System.Drawing.Size(486, 225)
        Me.GroupNuevoColaborador.TabIndex = 4
        Me.GroupNuevoColaborador.TabStop = False
        Me.GroupNuevoColaborador.Text = "Nuevo Colaborador"
        '
        'cbo_sector
        '
        Me.cbo_sector.FormattingEnabled = True
        Me.cbo_sector.Location = New System.Drawing.Point(105, 133)
        Me.cbo_sector.Name = "cbo_sector"
        Me.cbo_sector.Size = New System.Drawing.Size(214, 21)
        Me.cbo_sector.TabIndex = 7
        '
        'txt_apellido_colaborador
        '
        Me.txt_apellido_colaborador.Location = New System.Drawing.Point(105, 88)
        Me.txt_apellido_colaborador.Name = "txt_apellido_colaborador"
        Me.txt_apellido_colaborador.Size = New System.Drawing.Size(332, 20)
        Me.txt_apellido_colaborador.TabIndex = 6
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
        'btnCancelar_Colaborador
        '
        Me.btnCancelar_Colaborador.Location = New System.Drawing.Point(357, 181)
        Me.btnCancelar_Colaborador.Name = "btnCancelar_Colaborador"
        Me.btnCancelar_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Colaborador.TabIndex = 2
        Me.btnCancelar_Colaborador.Text = "Cancelar"
        Me.btnCancelar_Colaborador.UseVisualStyleBackColor = True
        '
        'btnActualizar_Colaborador
        '
        Me.btnActualizar_Colaborador.Location = New System.Drawing.Point(262, 181)
        Me.btnActualizar_Colaborador.Name = "btnActualizar_Colaborador"
        Me.btnActualizar_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Colaborador.TabIndex = 2
        Me.btnActualizar_Colaborador.Text = "Actualizar"
        Me.btnActualizar_Colaborador.UseVisualStyleBackColor = True
        '
        'btnGuardar_Colaborador
        '
        Me.btnGuardar_Colaborador.Location = New System.Drawing.Point(164, 181)
        Me.btnGuardar_Colaborador.Name = "btnGuardar_Colaborador"
        Me.btnGuardar_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Colaborador.TabIndex = 4
        Me.btnGuardar_Colaborador.Text = "Guardar"
        Me.btnGuardar_Colaborador.UseVisualStyleBackColor = True
        '
        'btnNuevo_Colaborador
        '
        Me.btnNuevo_Colaborador.Location = New System.Drawing.Point(65, 181)
        Me.btnNuevo_Colaborador.Name = "btnNuevo_Colaborador"
        Me.btnNuevo_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Colaborador.TabIndex = 2
        Me.btnNuevo_Colaborador.Text = "Nuevo"
        Me.btnNuevo_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_nombre_colaborador
        '
        Me.txt_nombre_colaborador.Location = New System.Drawing.Point(105, 39)
        Me.txt_nombre_colaborador.Name = "txt_nombre_colaborador"
        Me.txt_nombre_colaborador.Size = New System.Drawing.Size(332, 20)
        Me.txt_nombre_colaborador.TabIndex = 1
        '
        'txt_id_colaborador
        '
        Me.txt_id_colaborador.Location = New System.Drawing.Point(360, 133)
        Me.txt_id_colaborador.Name = "txt_id_colaborador"
        Me.txt_id_colaborador.Size = New System.Drawing.Size(61, 20)
        Me.txt_id_colaborador.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sector"
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
        Me.Label1.Location = New System.Drawing.Point(353, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_colaborador"
        '
        'frm_Colaborador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 661)
        Me.Controls.Add(Me.GroupListadoColaboradores)
        Me.Controls.Add(Me.GroupNuevoColaborador)
        Me.Name = "frm_Colaborador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colaborador"
        Me.GroupListadoColaboradores.ResumeLayout(False)
        Me.GroupListadoColaboradores.PerformLayout()
        CType(Me.dgvLista_Colaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevoColaborador.ResumeLayout(False)
        Me.GroupNuevoColaborador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoColaboradores As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal_Colaboradores As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Colaborador As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Colaboradores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevoColaborador As System.Windows.Forms.GroupBox
    Friend WithEvents txt_apellido_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_sector As System.Windows.Forms.ComboBox
End Class
