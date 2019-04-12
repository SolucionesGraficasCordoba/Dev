<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ticket
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
        Me.txt_id_ticket = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_respuesta = New System.Windows.Forms.Button()
        Me.GroupListadoClientes = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_comentarios = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_estimada = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_real = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.cbo_prioridad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_sector_dirigido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupNuevoCliente = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_herramienta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_plazo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_id_usuario = New System.Windows.Forms.TextBox()
        Me.txt_recurso = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar_Cliente = New System.Windows.Forms.Button()
        Me.btn_Solicitud = New System.Windows.Forms.Button()
        Me.GroupListadoClientes.SuspendLayout()
        Me.GroupNuevoCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id_ticket
        '
        Me.txt_id_ticket.Location = New System.Drawing.Point(149, 286)
        Me.txt_id_ticket.MaxLength = 10
        Me.txt_id_ticket.Name = "txt_id_ticket"
        Me.txt_id_ticket.Size = New System.Drawing.Size(97, 20)
        Me.txt_id_ticket.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "id_ticket"
        '
        'btn_respuesta
        '
        Me.btn_respuesta.Location = New System.Drawing.Point(240, 550)
        Me.btn_respuesta.Name = "btn_respuesta"
        Me.btn_respuesta.Size = New System.Drawing.Size(75, 33)
        Me.btn_respuesta.TabIndex = 15
        Me.btn_respuesta.Text = "Respuesta"
        Me.btn_respuesta.UseVisualStyleBackColor = True
        '
        'GroupListadoClientes
        '
        Me.GroupListadoClientes.Controls.Add(Me.Label4)
        Me.GroupListadoClientes.Controls.Add(Me.txt_comentarios)
        Me.GroupListadoClientes.Controls.Add(Me.dtp_fecha_estimada)
        Me.GroupListadoClientes.Controls.Add(Me.dtp_fecha_real)
        Me.GroupListadoClientes.Controls.Add(Me.Label14)
        Me.GroupListadoClientes.Controls.Add(Me.cbo_estado)
        Me.GroupListadoClientes.Controls.Add(Me.cbo_prioridad)
        Me.GroupListadoClientes.Controls.Add(Me.Label6)
        Me.GroupListadoClientes.Controls.Add(Me.Label8)
        Me.GroupListadoClientes.Controls.Add(Me.txt_sector_dirigido)
        Me.GroupListadoClientes.Controls.Add(Me.Label12)
        Me.GroupListadoClientes.Controls.Add(Me.Label13)
        Me.GroupListadoClientes.Location = New System.Drawing.Point(12, 318)
        Me.GroupListadoClientes.Name = "GroupListadoClientes"
        Me.GroupListadoClientes.Size = New System.Drawing.Size(501, 226)
        Me.GroupListadoClientes.TabIndex = 12
        Me.GroupListadoClientes.TabStop = False
        Me.GroupListadoClientes.Text = "Receptor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Comentarios"
        '
        'txt_comentarios
        '
        Me.txt_comentarios.Location = New System.Drawing.Point(86, 140)
        Me.txt_comentarios.MaxLength = 350
        Me.txt_comentarios.Multiline = True
        Me.txt_comentarios.Name = "txt_comentarios"
        Me.txt_comentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_comentarios.Size = New System.Drawing.Size(392, 71)
        Me.txt_comentarios.TabIndex = 31
        '
        'dtp_fecha_estimada
        '
        Me.dtp_fecha_estimada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_estimada.Location = New System.Drawing.Point(146, 67)
        Me.dtp_fecha_estimada.Name = "dtp_fecha_estimada"
        Me.dtp_fecha_estimada.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_estimada.TabIndex = 30
        '
        'dtp_fecha_real
        '
        Me.dtp_fecha_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_real.Location = New System.Drawing.Point(391, 67)
        Me.dtp_fecha_real.Name = "dtp_fecha_real"
        Me.dtp_fecha_real.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_real.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Fecha estimada de cierre"
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Items.AddRange(New Object() {"Seleccionar", "Nuevo", "Atendido", "Frenado"})
        Me.cbo_estado.Location = New System.Drawing.Point(330, 28)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(156, 21)
        Me.cbo_estado.TabIndex = 28
        '
        'cbo_prioridad
        '
        Me.cbo_prioridad.FormattingEnabled = True
        Me.cbo_prioridad.Items.AddRange(New Object() {"Seleccionar", "Baja", "Media", "Alta"})
        Me.cbo_prioridad.Location = New System.Drawing.Point(69, 28)
        Me.cbo_prioridad.Name = "cbo_prioridad"
        Me.cbo_prioridad.Size = New System.Drawing.Size(156, 21)
        Me.cbo_prioridad.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha real de cierre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Sector dirigido"
        '
        'txt_sector_dirigido
        '
        Me.txt_sector_dirigido.Location = New System.Drawing.Point(86, 109)
        Me.txt_sector_dirigido.MaxLength = 50
        Me.txt_sector_dirigido.Name = "txt_sector_dirigido"
        Me.txt_sector_dirigido.Size = New System.Drawing.Size(393, 20)
        Me.txt_sector_dirigido.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(284, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Prioridad"
        '
        'GroupNuevoCliente
        '
        Me.GroupNuevoCliente.Controls.Add(Me.Label16)
        Me.GroupNuevoCliente.Controls.Add(Me.Label15)
        Me.GroupNuevoCliente.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupNuevoCliente.Controls.Add(Me.Label5)
        Me.GroupNuevoCliente.Controls.Add(Me.Label1)
        Me.GroupNuevoCliente.Controls.Add(Me.Label11)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_herramienta)
        Me.GroupNuevoCliente.Controls.Add(Me.Label9)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_plazo)
        Me.GroupNuevoCliente.Controls.Add(Me.Label10)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_descripcion)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_id_usuario)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_recurso)
        Me.GroupNuevoCliente.Controls.Add(Me.txt_nombre_usuario)
        Me.GroupNuevoCliente.Controls.Add(Me.Label3)
        Me.GroupNuevoCliente.Controls.Add(Me.Label2)
        Me.GroupNuevoCliente.Location = New System.Drawing.Point(12, 12)
        Me.GroupNuevoCliente.Name = "GroupNuevoCliente"
        Me.GroupNuevoCliente.Size = New System.Drawing.Size(501, 261)
        Me.GroupNuevoCliente.TabIndex = 11
        Me.GroupNuevoCliente.TabStop = False
        Me.GroupNuevoCliente.Text = "Solicitante"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(81, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(81, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "*"
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(236, 19)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_pedido.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha de pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "días"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Herramienta"
        '
        'txt_herramienta
        '
        Me.txt_herramienta.Location = New System.Drawing.Point(94, 119)
        Me.txt_herramienta.MaxLength = 50
        Me.txt_herramienta.Name = "txt_herramienta"
        Me.txt_herramienta.Size = New System.Drawing.Size(392, 20)
        Me.txt_herramienta.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Plazo de resolución requerido"
        '
        'txt_plazo
        '
        Me.txt_plazo.Location = New System.Drawing.Point(169, 148)
        Me.txt_plazo.MaxLength = 5
        Me.txt_plazo.Name = "txt_plazo"
        Me.txt_plazo.Size = New System.Drawing.Size(58, 20)
        Me.txt_plazo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Descripción"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(94, 176)
        Me.txt_descripcion.MaxLength = 350
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcion.Size = New System.Drawing.Size(392, 71)
        Me.txt_descripcion.TabIndex = 5
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Location = New System.Drawing.Point(27, 57)
        Me.txt_id_usuario.MaxLength = 10
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(13, 20)
        Me.txt_id_usuario.TabIndex = 4
        '
        'txt_recurso
        '
        Me.txt_recurso.Location = New System.Drawing.Point(94, 89)
        Me.txt_recurso.MaxLength = 50
        Me.txt_recurso.Name = "txt_recurso"
        Me.txt_recurso.Size = New System.Drawing.Size(392, 20)
        Me.txt_recurso.TabIndex = 1
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nombre_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(94, 57)
        Me.txt_nombre_usuario.MaxLength = 50
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(392, 20)
        Me.txt_nombre_usuario.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Recurso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'btnCancelar_Cliente
        '
        Me.btnCancelar_Cliente.Location = New System.Drawing.Point(438, 281)
        Me.btnCancelar_Cliente.Name = "btnCancelar_Cliente"
        Me.btnCancelar_Cliente.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Cliente.TabIndex = 14
        Me.btnCancelar_Cliente.Text = "Cancelar"
        Me.btnCancelar_Cliente.UseVisualStyleBackColor = True
        '
        'btn_Solicitud
        '
        Me.btn_Solicitud.Location = New System.Drawing.Point(357, 281)
        Me.btn_Solicitud.Name = "btn_Solicitud"
        Me.btn_Solicitud.Size = New System.Drawing.Size(75, 33)
        Me.btn_Solicitud.TabIndex = 13
        Me.btn_Solicitud.Text = "Solicitud"
        Me.btn_Solicitud.UseVisualStyleBackColor = True
        '
        'frm_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 598)
        Me.Controls.Add(Me.txt_id_ticket)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_respuesta)
        Me.Controls.Add(Me.GroupListadoClientes)
        Me.Controls.Add(Me.GroupNuevoCliente)
        Me.Controls.Add(Me.btnCancelar_Cliente)
        Me.Controls.Add(Me.btn_Solicitud)
        Me.Name = "frm_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket"
        Me.GroupListadoClientes.ResumeLayout(False)
        Me.GroupListadoClientes.PerformLayout()
        Me.GroupNuevoCliente.ResumeLayout(False)
        Me.GroupNuevoCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_id_ticket As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_respuesta As System.Windows.Forms.Button
    Friend WithEvents GroupListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_comentarios As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_estimada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_real As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_sector_dirigido As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevoCliente As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_herramienta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_plazo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_recurso As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Cliente As System.Windows.Forms.Button
    Friend WithEvents btn_Solicitud As System.Windows.Forms.Button
End Class
