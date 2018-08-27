<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Actualizar_Tarea
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
        Me.txt_id_tarea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_tarea = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt_numero_orden = New System.Windows.Forms.TextBox()
        Me.btn_buscar_numero_orden = New System.Windows.Forms.Button()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar_colaborador = New System.Windows.Forms.Button()
        Me.txt_nombre_colaborador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_colaborador = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tiempo_estimado = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_Carga_Horaria = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_tiempo_real = New System.Windows.Forms.TextBox()
        Me.btn_Actualizar_Tarea = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hora_fin = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id_tarea
        '
        Me.txt_id_tarea.Location = New System.Drawing.Point(30, 280)
        Me.txt_id_tarea.Name = "txt_id_tarea"
        Me.txt_id_tarea.Size = New System.Drawing.Size(66, 20)
        Me.txt_id_tarea.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "id_tarea"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(26, 236)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(78, 13)
        Me.Label57.TabIndex = 140
        Me.Label57.Text = "Observaciones"
        '
        'txt_tarea
        '
        Me.txt_tarea.Location = New System.Drawing.Point(64, 26)
        Me.txt_tarea.Name = "txt_tarea"
        Me.txt_tarea.Size = New System.Drawing.Size(371, 20)
        Me.txt_tarea.TabIndex = 149
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(18, 29)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(40, 13)
        Me.Label61.TabIndex = 148
        Me.Label61.Text = "Tareas"
        '
        'txt_numero_orden
        '
        Me.txt_numero_orden.Location = New System.Drawing.Point(130, 71)
        Me.txt_numero_orden.Name = "txt_numero_orden"
        Me.txt_numero_orden.Size = New System.Drawing.Size(245, 20)
        Me.txt_numero_orden.TabIndex = 162
        '
        'btn_buscar_numero_orden
        '
        Me.btn_buscar_numero_orden.Location = New System.Drawing.Point(381, 69)
        Me.btn_buscar_numero_orden.Name = "btn_buscar_numero_orden"
        Me.btn_buscar_numero_orden.Size = New System.Drawing.Size(54, 23)
        Me.btn_buscar_numero_orden.TabIndex = 165
        Me.btn_buscar_numero_orden.Text = "..."
        Me.btn_buscar_numero_orden.UseVisualStyleBackColor = True
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(130, 71)
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(245, 20)
        Me.txtNumero_Orden_Trabajo.TabIndex = 163
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(36, 74)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 13)
        Me.Label36.TabIndex = 158
        Me.Label36.Text = "Orden de trabajo"
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(17, 66)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(13, 20)
        Me.txt_id_orden_trabajo.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Orden de trabajo"
        '
        'btn_buscar_colaborador
        '
        Me.btn_buscar_colaborador.Location = New System.Drawing.Point(381, 108)
        Me.btn_buscar_colaborador.Name = "btn_buscar_colaborador"
        Me.btn_buscar_colaborador.Size = New System.Drawing.Size(54, 23)
        Me.btn_buscar_colaborador.TabIndex = 156
        Me.btn_buscar_colaborador.Text = "..."
        Me.btn_buscar_colaborador.UseVisualStyleBackColor = True
        '
        'txt_nombre_colaborador
        '
        Me.txt_nombre_colaborador.Location = New System.Drawing.Point(130, 110)
        Me.txt_nombre_colaborador.Name = "txt_nombre_colaborador"
        Me.txt_nombre_colaborador.Size = New System.Drawing.Size(245, 20)
        Me.txt_nombre_colaborador.TabIndex = 155
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Colaborador"
        '
        'txt_id_colaborador
        '
        Me.txt_id_colaborador.Location = New System.Drawing.Point(17, 101)
        Me.txt_id_colaborador.Name = "txt_id_colaborador"
        Me.txt_id_colaborador.Size = New System.Drawing.Size(13, 20)
        Me.txt_id_colaborador.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Colaborador"
        '
        'txt_tiempo_estimado
        '
        Me.txt_tiempo_estimado.Location = New System.Drawing.Point(133, 192)
        Me.txt_tiempo_estimado.Name = "txt_tiempo_estimado"
        Me.txt_tiempo_estimado.Size = New System.Drawing.Size(80, 20)
        Me.txt_tiempo_estimado.TabIndex = 176
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(40, 195)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(87, 13)
        Me.Label58.TabIndex = 174
        Me.Label58.Text = "Tiempo estimado"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(235, 195)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(62, 13)
        Me.Label59.TabIndex = 175
        Me.Label59.Text = "Tiempo real"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(63, 150)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecha.TabIndex = 173
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(20, 153)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(37, 13)
        Me.Label62.TabIndex = 170
        Me.Label62.Text = "Fecha"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(20, 153)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 13)
        Me.Label31.TabIndex = 171
        Me.Label31.Text = "Fecha"
        '
        'txt_Carga_Horaria
        '
        Me.txt_Carga_Horaria.Location = New System.Drawing.Point(373, 155)
        Me.txt_Carga_Horaria.Name = "txt_Carga_Horaria"
        Me.txt_Carga_Horaria.Size = New System.Drawing.Size(76, 20)
        Me.txt_Carga_Horaria.TabIndex = 168
        Me.txt_Carga_Horaria.Text = "540"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 166
        Me.Label13.Text = "Carga horaria"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_hora_fin)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones)
        Me.GroupBox1.Controls.Add(Me.txt_tiempo_estimado)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.txt_tiempo_real)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label62)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txt_Carga_Horaria)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_numero_orden)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_numero_orden)
        Me.GroupBox1.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_colaborador)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_colaborador)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_id_colaborador)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label57)
        Me.GroupBox1.Controls.Add(Me.txt_tarea)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.txt_id_tarea)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 335)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(113, 233)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(322, 78)
        Me.txt_observaciones.TabIndex = 180
        '
        'txt_tiempo_real
        '
        Me.txt_tiempo_real.Location = New System.Drawing.Point(303, 192)
        Me.txt_tiempo_real.Name = "txt_tiempo_real"
        Me.txt_tiempo_real.Size = New System.Drawing.Size(76, 20)
        Me.txt_tiempo_real.TabIndex = 177
        '
        'btn_Actualizar_Tarea
        '
        Me.btn_Actualizar_Tarea.Location = New System.Drawing.Point(326, 372)
        Me.btn_Actualizar_Tarea.Name = "btn_Actualizar_Tarea"
        Me.btn_Actualizar_Tarea.Size = New System.Drawing.Size(75, 23)
        Me.btn_Actualizar_Tarea.TabIndex = 179
        Me.btn_Actualizar_Tarea.Text = "Actualizar"
        Me.btn_Actualizar_Tarea.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(411, 372)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 180
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(245, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 181
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Hora Fin"
        '
        'txt_hora_fin
        '
        Me.txt_hora_fin.Location = New System.Drawing.Point(219, 150)
        Me.txt_hora_fin.Name = "txt_hora_fin"
        Me.txt_hora_fin.Size = New System.Drawing.Size(66, 20)
        Me.txt_hora_fin.TabIndex = 182
        '
        'frm_Actualizar_Tarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 403)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Actualizar_Tarea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Actualizar_Tarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Tarea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_id_tarea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txt_tarea As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_orden As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_numero_orden As System.Windows.Forms.Button
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar_colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id_colaborador As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_tiempo_estimado As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_Carga_Horaria As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tiempo_real As System.Windows.Forms.TextBox
    Friend WithEvents btn_Actualizar_Tarea As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_hora_fin As System.Windows.Forms.TextBox
End Class
