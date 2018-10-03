<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Producto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_Stock = New System.Windows.Forms.TextBox()
        Me.txt_id_producto_movimiento = New System.Windows.Forms.TextBox()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.txt_id_producto = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupListadoColaboradores = New System.Windows.Forms.GroupBox()
        Me.lblTotal_Colaboradores = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEliminar_Colaborador = New System.Windows.Forms.Button()
        Me.txt_Buscar_Producto = New System.Windows.Forms.TextBox()
        Me.dgvLista_Productos = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGuardar_producto = New System.Windows.Forms.Button()
        Me.btnCancelar_cancelar = New System.Windows.Forms.Button()
        Me.btnActualizar_producto = New System.Windows.Forms.Button()
        Me.btnNuevo_producto = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupListadoColaboradores.SuspendLayout()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "id_orden_trabajo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "id_producto_movimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(76, 20)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(243, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'txt_Stock
        '
        Me.txt_Stock.Location = New System.Drawing.Point(243, 153)
        Me.txt_Stock.Name = "txt_Stock"
        Me.txt_Stock.Size = New System.Drawing.Size(100, 20)
        Me.txt_Stock.TabIndex = 7
        '
        'txt_id_producto_movimiento
        '
        Me.txt_id_producto_movimiento.Location = New System.Drawing.Point(462, 19)
        Me.txt_id_producto_movimiento.Name = "txt_id_producto_movimiento"
        Me.txt_id_producto_movimiento.Size = New System.Drawing.Size(24, 20)
        Me.txt_id_producto_movimiento.TabIndex = 8
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(444, 151)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(24, 20)
        Me.txt_id_orden_trabajo.TabIndex = 9
        '
        'txt_id_producto
        '
        Me.txt_id_producto.Location = New System.Drawing.Point(363, 45)
        Me.txt_id_producto.Name = "txt_id_producto"
        Me.txt_id_producto.Size = New System.Drawing.Size(24, 20)
        Me.txt_id_producto.TabIndex = 10
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(76, 153)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_Cantidad.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.btnGuardar_producto)
        Me.GroupBox1.Controls.Add(Me.btnCancelar_cancelar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar_producto)
        Me.GroupBox1.Controls.Add(Me.btnNuevo_producto)
        Me.GroupBox1.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox1.Controls.Add(Me.txt_Stock)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txt_Codigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 231)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Producto"
        '
        'GroupListadoColaboradores
        '
        Me.GroupListadoColaboradores.Controls.Add(Me.lblTotal_Colaboradores)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label10)
        Me.GroupListadoColaboradores.Controls.Add(Me.btnEliminar_Colaborador)
        Me.GroupListadoColaboradores.Controls.Add(Me.txt_Buscar_Producto)
        Me.GroupListadoColaboradores.Controls.Add(Me.dgvLista_Productos)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label11)
        Me.GroupListadoColaboradores.Controls.Add(Me.txt_id_producto_movimiento)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label7)
        Me.GroupListadoColaboradores.Controls.Add(Me.txt_id_producto)
        Me.GroupListadoColaboradores.Controls.Add(Me.Label1)
        Me.GroupListadoColaboradores.Location = New System.Drawing.Point(12, 260)
        Me.GroupListadoColaboradores.Name = "GroupListadoColaboradores"
        Me.GroupListadoColaboradores.Size = New System.Drawing.Size(585, 372)
        Me.GroupListadoColaboradores.TabIndex = 68
        Me.GroupListadoColaboradores.TabStop = False
        Me.GroupListadoColaboradores.Text = "Listado de Productos"
        '
        'lblTotal_Colaboradores
        '
        Me.lblTotal_Colaboradores.AutoSize = True
        Me.lblTotal_Colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Colaboradores.Location = New System.Drawing.Point(529, 347)
        Me.lblTotal_Colaboradores.Name = "lblTotal_Colaboradores"
        Me.lblTotal_Colaboradores.Size = New System.Drawing.Size(2, 15)
        Me.lblTotal_Colaboradores.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total de Productos"
        '
        'btnEliminar_Colaborador
        '
        Me.btnEliminar_Colaborador.Location = New System.Drawing.Point(494, 38)
        Me.btnEliminar_Colaborador.Name = "btnEliminar_Colaborador"
        Me.btnEliminar_Colaborador.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar_Colaborador.TabIndex = 3
        Me.btnEliminar_Colaborador.Text = "Eliminar"
        Me.btnEliminar_Colaborador.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Producto
        '
        Me.txt_Buscar_Producto.Location = New System.Drawing.Point(116, 40)
        Me.txt_Buscar_Producto.Name = "txt_Buscar_Producto"
        Me.txt_Buscar_Producto.Size = New System.Drawing.Size(206, 20)
        Me.txt_Buscar_Producto.TabIndex = 2
        '
        'dgvLista_Productos
        '
        Me.dgvLista_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Productos.Location = New System.Drawing.Point(24, 81)
        Me.dgvLista_Productos.Name = "dgvLista_Productos"
        Me.dgvLista_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Productos.Size = New System.Drawing.Size(545, 253)
        Me.dgvLista_Productos.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ingrese Nombre"
        '
        'btnGuardar_producto
        '
        Me.btnGuardar_producto.Location = New System.Drawing.Point(215, 193)
        Me.btnGuardar_producto.Name = "btnGuardar_producto"
        Me.btnGuardar_producto.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_producto.TabIndex = 71
        Me.btnGuardar_producto.Text = "Guardar"
        Me.btnGuardar_producto.UseVisualStyleBackColor = True
        '
        'btnCancelar_cancelar
        '
        Me.btnCancelar_cancelar.Location = New System.Drawing.Point(414, 193)
        Me.btnCancelar_cancelar.Name = "btnCancelar_cancelar"
        Me.btnCancelar_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_cancelar.TabIndex = 70
        Me.btnCancelar_cancelar.Text = "Cancelar"
        Me.btnCancelar_cancelar.UseVisualStyleBackColor = True
        '
        'btnActualizar_producto
        '
        Me.btnActualizar_producto.Location = New System.Drawing.Point(313, 193)
        Me.btnActualizar_producto.Name = "btnActualizar_producto"
        Me.btnActualizar_producto.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_producto.TabIndex = 69
        Me.btnActualizar_producto.Text = "Actualizar"
        Me.btnActualizar_producto.UseVisualStyleBackColor = True
        '
        'btnNuevo_producto
        '
        Me.btnNuevo_producto.Location = New System.Drawing.Point(117, 193)
        Me.btnNuevo_producto.Name = "btnNuevo_producto"
        Me.btnNuevo_producto.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_producto.TabIndex = 68
        Me.btnNuevo_producto.Text = "Nuevo"
        Me.btnNuevo_producto.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(76, 62)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(492, 71)
        Me.txt_descripcion.TabIndex = 72
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(405, 23)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(164, 20)
        Me.txt_tipo.TabIndex = 73
        '
        'frm_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 647)
        Me.Controls.Add(Me.GroupListadoColaboradores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Producto"
        Me.Text = "Movimiento de Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupListadoColaboradores.ResumeLayout(False)
        Me.GroupListadoColaboradores.PerformLayout()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_producto_movimiento As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupListadoColaboradores As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal_Colaboradores As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Colaborador As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Producto As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar_producto As System.Windows.Forms.Button
    Friend WithEvents btnCancelar_cancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_producto As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_producto As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
End Class
