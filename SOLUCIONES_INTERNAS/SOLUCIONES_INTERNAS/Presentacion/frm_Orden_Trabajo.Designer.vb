<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Orden_Trabajo
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBuscar_Vendedor = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_razonsocial_cliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar_Detalle_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnActualizar_Detalle_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnGuardar_Detalle_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnNuevo_Detalle_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEliminar_Sector = New System.Windows.Forms.Button()
        Me.txt_Buscar_Sector = New System.Windows.Forms.TextBox()
        Me.dgvLista_Sector = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Sector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 88)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(125, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(316, 20)
        Me.TextBox4.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(82, 40)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(37, 20)
        Me.TextBox5.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnBuscar_Vendedor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txt_razonsocial_cliente)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 157)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(78, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.ComboBox1.Location = New System.Drawing.Point(359, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 20)
        Me.TextBox1.TabIndex = 10
        '
        'btnBuscar_Vendedor
        '
        Me.btnBuscar_Vendedor.Location = New System.Drawing.Point(447, 113)
        Me.btnBuscar_Vendedor.Name = "btnBuscar_Vendedor"
        Me.btnBuscar_Vendedor.Size = New System.Drawing.Size(52, 23)
        Me.btnBuscar_Vendedor.TabIndex = 14
        Me.btnBuscar_Vendedor.Text = "..."
        Me.btnBuscar_Vendedor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Número"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(125, 115)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(316, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 20)
        Me.TextBox2.TabIndex = 12
        '
        'txt_razonsocial_cliente
        '
        Me.txt_razonsocial_cliente.Location = New System.Drawing.Point(374, 71)
        Me.txt_razonsocial_cliente.Name = "txt_razonsocial_cliente"
        Me.txt_razonsocial_cliente.Size = New System.Drawing.Size(125, 20)
        Me.txt_razonsocial_cliente.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Vendedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad"
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(294, 90)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(29, 20)
        Me.txt_id_orden_trabajo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_orden_trabajo"
        '
        'btnCancelar_Detalle_Orden_Trabajo
        '
        Me.btnCancelar_Detalle_Orden_Trabajo.Location = New System.Drawing.Point(400, 295)
        Me.btnCancelar_Detalle_Orden_Trabajo.Name = "btnCancelar_Detalle_Orden_Trabajo"
        Me.btnCancelar_Detalle_Orden_Trabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Detalle_Orden_Trabajo.TabIndex = 23
        Me.btnCancelar_Detalle_Orden_Trabajo.Text = "Cancelar"
        Me.btnCancelar_Detalle_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnActualizar_Detalle_Orden_Trabajo
        '
        Me.btnActualizar_Detalle_Orden_Trabajo.Location = New System.Drawing.Point(305, 295)
        Me.btnActualizar_Detalle_Orden_Trabajo.Name = "btnActualizar_Detalle_Orden_Trabajo"
        Me.btnActualizar_Detalle_Orden_Trabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Detalle_Orden_Trabajo.TabIndex = 22
        Me.btnActualizar_Detalle_Orden_Trabajo.Text = "Actualizar"
        Me.btnActualizar_Detalle_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnGuardar_Detalle_Orden_Trabajo
        '
        Me.btnGuardar_Detalle_Orden_Trabajo.Location = New System.Drawing.Point(207, 295)
        Me.btnGuardar_Detalle_Orden_Trabajo.Name = "btnGuardar_Detalle_Orden_Trabajo"
        Me.btnGuardar_Detalle_Orden_Trabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Detalle_Orden_Trabajo.TabIndex = 24
        Me.btnGuardar_Detalle_Orden_Trabajo.Text = "Guardar"
        Me.btnGuardar_Detalle_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnNuevo_Detalle_Orden_Trabajo
        '
        Me.btnNuevo_Detalle_Orden_Trabajo.Location = New System.Drawing.Point(108, 295)
        Me.btnNuevo_Detalle_Orden_Trabajo.Name = "btnNuevo_Detalle_Orden_Trabajo"
        Me.btnNuevo_Detalle_Orden_Trabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Detalle_Orden_Trabajo.TabIndex = 21
        Me.btnNuevo_Detalle_Orden_Trabajo.Text = "Nuevo"
        Me.btnNuevo_Detalle_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.btnCancelar_Detalle_Orden_Trabajo)
        Me.GroupBox3.Controls.Add(Me.btnActualizar_Detalle_Orden_Trabajo)
        Me.GroupBox3.Controls.Add(Me.btnGuardar_Detalle_Orden_Trabajo)
        Me.GroupBox3.Controls.Add(Me.btnNuevo_Detalle_Orden_Trabajo)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 344)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.Button2)
        Me.GroupListadoPiezas.Controls.Add(Me.Label3)
        Me.GroupListadoPiezas.Controls.Add(Me.Label7)
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Sector)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_Sector)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Sector)
        Me.GroupListadoPiezas.Controls.Add(Me.Label8)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(16, 390)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(582, 372)
        Me.GroupListadoPiezas.TabIndex = 28
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Detalles de la orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(444, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(347, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total de Sectores"
        '
        'btnEliminar_Sector
        '
        Me.btnEliminar_Sector.Location = New System.Drawing.Point(309, 38)
        Me.btnEliminar_Sector.Name = "btnEliminar_Sector"
        Me.btnEliminar_Sector.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Sector.TabIndex = 3
        Me.btnEliminar_Sector.Text = "Eliminar"
        Me.btnEliminar_Sector.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Sector
        '
        Me.txt_Buscar_Sector.Location = New System.Drawing.Point(74, 40)
        Me.txt_Buscar_Sector.Name = "txt_Buscar_Sector"
        Me.txt_Buscar_Sector.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_Sector.TabIndex = 2
        '
        'dgvLista_Sector
        '
        Me.dgvLista_Sector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Sector.Location = New System.Drawing.Point(24, 81)
        Me.dgvLista_Sector.Name = "dgvLista_Sector"
        Me.dgvLista_Sector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Sector.Size = New System.Drawing.Size(533, 253)
        Me.dgvLista_Sector.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Buscar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cargar Detalle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_Orden_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 788)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frm_Orden_Trabajo"
        Me.Text = "Detalle de Orden"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Sector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_razonsocial_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Detalle_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Detalle_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Detalle_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Detalle_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Sector As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Sector As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Sector As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
