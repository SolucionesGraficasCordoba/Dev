<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mensaje
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
        Me.GroupComentario = New System.Windows.Forms.GroupBox()
        Me.txt_Titulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Envio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_id_mensaje = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.txt_id_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupRespuesta = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.btn_respuesta = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupComentario.SuspendLayout()
        Me.GroupRespuesta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupComentario
        '
        Me.GroupComentario.Controls.Add(Me.Label7)
        Me.GroupComentario.Controls.Add(Me.Label6)
        Me.GroupComentario.Controls.Add(Me.txt_Titulo)
        Me.GroupComentario.Controls.Add(Me.Label3)
        Me.GroupComentario.Controls.Add(Me.btn_Envio)
        Me.GroupComentario.Controls.Add(Me.Label1)
        Me.GroupComentario.Controls.Add(Me.Label18)
        Me.GroupComentario.Controls.Add(Me.txt_id_mensaje)
        Me.GroupComentario.Controls.Add(Me.dtp_fecha_pedido)
        Me.GroupComentario.Controls.Add(Me.txt_id_usuario)
        Me.GroupComentario.Controls.Add(Me.Label5)
        Me.GroupComentario.Controls.Add(Me.Label10)
        Me.GroupComentario.Controls.Add(Me.txt_comentario)
        Me.GroupComentario.Controls.Add(Me.txt_nombre_usuario)
        Me.GroupComentario.Controls.Add(Me.Label2)
        Me.GroupComentario.Location = New System.Drawing.Point(12, 12)
        Me.GroupComentario.Name = "GroupComentario"
        Me.GroupComentario.Size = New System.Drawing.Size(501, 312)
        Me.GroupComentario.TabIndex = 27
        Me.GroupComentario.TabStop = False
        Me.GroupComentario.Text = "Comentario"
        '
        'txt_Titulo
        '
        Me.txt_Titulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_Titulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Titulo.Location = New System.Drawing.Point(94, 93)
        Me.txt_Titulo.MaxLength = 50
        Me.txt_Titulo.Name = "txt_Titulo"
        Me.txt_Titulo.Size = New System.Drawing.Size(392, 20)
        Me.txt_Titulo.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Título"
        '
        'btn_Envio
        '
        Me.btn_Envio.Location = New System.Drawing.Point(411, 269)
        Me.btn_Envio.Name = "btn_Envio"
        Me.btn_Envio.Size = New System.Drawing.Size(75, 33)
        Me.btn_Envio.TabIndex = 41
        Me.btn_Envio.Text = "Envío"
        Me.btn_Envio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "id_usuario"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(316, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "id_mensaje"
        '
        'txt_id_mensaje
        '
        Me.txt_id_mensaje.Location = New System.Drawing.Point(382, 22)
        Me.txt_id_mensaje.MaxLength = 10
        Me.txt_id_mensaje.Name = "txt_id_mensaje"
        Me.txt_id_mensaje.Size = New System.Drawing.Size(46, 20)
        Me.txt_id_mensaje.TabIndex = 24
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(94, 22)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha_pedido.TabIndex = 34
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Location = New System.Drawing.Point(273, 22)
        Me.txt_id_usuario.MaxLength = 10
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(22, 20)
        Me.txt_id_usuario.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 26)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Observación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   de Carga"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(94, 132)
        Me.txt_comentario.MaxLength = 350
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_comentario.Size = New System.Drawing.Size(392, 131)
        Me.txt_comentario.TabIndex = 5
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'GroupRespuesta
        '
        Me.GroupRespuesta.Controls.Add(Me.Label15)
        Me.GroupRespuesta.Controls.Add(Me.Label4)
        Me.GroupRespuesta.Controls.Add(Me.txt_respuesta)
        Me.GroupRespuesta.Controls.Add(Me.btn_respuesta)
        Me.GroupRespuesta.Location = New System.Drawing.Point(12, 330)
        Me.GroupRespuesta.Name = "GroupRespuesta"
        Me.GroupRespuesta.Size = New System.Drawing.Size(501, 198)
        Me.GroupRespuesta.TabIndex = 28
        Me.GroupRespuesta.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(82, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Respuesta"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(94, 19)
        Me.txt_respuesta.MaxLength = 350
        Me.txt_respuesta.Multiline = True
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_respuesta.Size = New System.Drawing.Size(392, 131)
        Me.txt_respuesta.TabIndex = 42
        '
        'btn_respuesta
        '
        Me.btn_respuesta.Location = New System.Drawing.Point(411, 156)
        Me.btn_respuesta.Name = "btn_respuesta"
        Me.btn_respuesta.Size = New System.Drawing.Size(75, 33)
        Me.btn_respuesta.TabIndex = 41
        Me.btn_respuesta.Text = "Respuesta"
        Me.btn_respuesta.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(82, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(80, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "*"
        '
        'frm_Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 539)
        Me.Controls.Add(Me.GroupRespuesta)
        Me.Controls.Add(Me.GroupComentario)
        Me.Name = "frm_Mensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje"
        Me.GroupComentario.ResumeLayout(False)
        Me.GroupComentario.PerformLayout()
        Me.GroupRespuesta.ResumeLayout(False)
        Me.GroupRespuesta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupComentario As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_id_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Envio As System.Windows.Forms.Button
    Friend WithEvents GroupRespuesta As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_respuesta As System.Windows.Forms.TextBox
    Friend WithEvents btn_respuesta As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
