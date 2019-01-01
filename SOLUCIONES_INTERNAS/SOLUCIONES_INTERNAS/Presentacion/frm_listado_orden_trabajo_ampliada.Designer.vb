<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_orden_trabajo_ampliada
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupDetallesOrden = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnEliminar_Producto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_detalle_orden = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.btn_ODT_mostrar_listado_pdf = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.rbtFechaEntrega = New System.Windows.Forms.RadioButton()
        Me.rbtCliente = New System.Windows.Forms.RadioButton()
        Me.rbtNroOrden = New System.Windows.Forms.RadioButton()
        Me.dtp_Buscar_Fecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.txt_Buscar_Cliente = New System.Windows.Forms.TextBox()
        Me.btnEliminar_Orden = New System.Windows.Forms.Button()
        Me.btnModificar_Orden = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Buscar_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.dgvLista_Orden_Trabajo = New System.Windows.Forms.DataGridView()
        Me.GroupDetallesOrden.SuspendLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupDetallesOrden
        '
        Me.GroupDetallesOrden.Controls.Add(Me.btn_Cancelar)
        Me.GroupDetallesOrden.Controls.Add(Me.btnModificarProducto)
        Me.GroupDetallesOrden.Controls.Add(Me.btnEliminar_Producto)
        Me.GroupDetallesOrden.Controls.Add(Me.Label1)
        Me.GroupDetallesOrden.Controls.Add(Me.dgv_detalle_orden)
        Me.GroupDetallesOrden.Controls.Add(Me.Label2)
        Me.GroupDetallesOrden.Location = New System.Drawing.Point(12, 369)
        Me.GroupDetallesOrden.Name = "GroupDetallesOrden"
        Me.GroupDetallesOrden.Size = New System.Drawing.Size(1091, 208)
        Me.GroupDetallesOrden.TabIndex = 32
        Me.GroupDetallesOrden.TabStop = False
        Me.GroupDetallesOrden.Text = "Detalles de la orden"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(1007, 169)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(67, 33)
        Me.btn_Cancelar.TabIndex = 39
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(763, 169)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(119, 33)
        Me.btnModificarProducto.TabIndex = 38
        Me.btnModificarProducto.Text = "Modificar Producto"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminar_Producto
        '
        Me.btnEliminar_Producto.Location = New System.Drawing.Point(888, 169)
        Me.btnEliminar_Producto.Name = "btnEliminar_Producto"
        Me.btnEliminar_Producto.Size = New System.Drawing.Size(113, 33)
        Me.btnEliminar_Producto.TabIndex = 35
        Me.btnEliminar_Producto.Text = "Eliminar Producto"
        Me.btnEliminar_Producto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(127, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 34
        '
        'dgv_detalle_orden
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_orden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_detalle_orden.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_detalle_orden.Location = New System.Drawing.Point(17, 19)
        Me.dgv_detalle_orden.MultiSelect = False
        Me.dgv_detalle_orden.Name = "dgv_detalle_orden"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_orden.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_detalle_orden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_orden.Size = New System.Drawing.Size(1057, 140)
        Me.dgv_detalle_orden.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Productos de la orden"
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.btn_ODT_mostrar_listado_pdf)
        Me.GroupListadoPiezas.Controls.Add(Me.btnVer)
        Me.GroupListadoPiezas.Controls.Add(Me.rbtFechaEntrega)
        Me.GroupListadoPiezas.Controls.Add(Me.rbtCliente)
        Me.GroupListadoPiezas.Controls.Add(Me.rbtNroOrden)
        Me.GroupListadoPiezas.Controls.Add(Me.dtp_Buscar_Fecha_Entrega)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_Cliente)
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.btnModificar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.Label3)
        Me.GroupListadoPiezas.Controls.Add(Me.Label7)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_orden_trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Orden_Trabajo)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(12, 12)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(1091, 351)
        Me.GroupListadoPiezas.TabIndex = 31
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Listado de Ordenes"
        '
        'btn_ODT_mostrar_listado_pdf
        '
        Me.btn_ODT_mostrar_listado_pdf.Location = New System.Drawing.Point(702, 311)
        Me.btn_ODT_mostrar_listado_pdf.Name = "btn_ODT_mostrar_listado_pdf"
        Me.btn_ODT_mostrar_listado_pdf.Size = New System.Drawing.Size(128, 33)
        Me.btn_ODT_mostrar_listado_pdf.TabIndex = 37
        Me.btn_ODT_mostrar_listado_pdf.Text = "Exportar Listado a PDF"
        Me.btn_ODT_mostrar_listado_pdf.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(629, 311)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(67, 33)
        Me.btnVer.TabIndex = 37
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        Me.btnVer.Visible = False
        '
        'rbtFechaEntrega
        '
        Me.rbtFechaEntrega.AutoSize = True
        Me.rbtFechaEntrega.Location = New System.Drawing.Point(478, 20)
        Me.rbtFechaEntrega.Name = "rbtFechaEntrega"
        Me.rbtFechaEntrega.Size = New System.Drawing.Size(110, 17)
        Me.rbtFechaEntrega.TabIndex = 5
        Me.rbtFechaEntrega.TabStop = True
        Me.rbtFechaEntrega.Text = "Fecha de Entrega"
        Me.rbtFechaEntrega.UseVisualStyleBackColor = True
        '
        'rbtCliente
        '
        Me.rbtCliente.AutoSize = True
        Me.rbtCliente.Location = New System.Drawing.Point(240, 19)
        Me.rbtCliente.Name = "rbtCliente"
        Me.rbtCliente.Size = New System.Drawing.Size(131, 17)
        Me.rbtCliente.TabIndex = 3
        Me.rbtCliente.TabStop = True
        Me.rbtCliente.Text = "Cliente / Razón Social"
        Me.rbtCliente.UseVisualStyleBackColor = True
        '
        'rbtNroOrden
        '
        Me.rbtNroOrden.AutoSize = True
        Me.rbtNroOrden.Location = New System.Drawing.Point(59, 19)
        Me.rbtNroOrden.Name = "rbtNroOrden"
        Me.rbtNroOrden.Size = New System.Drawing.Size(74, 17)
        Me.rbtNroOrden.TabIndex = 1
        Me.rbtNroOrden.TabStop = True
        Me.rbtNroOrden.Text = "Nro Orden"
        Me.rbtNroOrden.UseVisualStyleBackColor = True
        '
        'dtp_Buscar_Fecha_Entrega
        '
        Me.dtp_Buscar_Fecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Buscar_Fecha_Entrega.Location = New System.Drawing.Point(594, 19)
        Me.dtp_Buscar_Fecha_Entrega.Name = "dtp_Buscar_Fecha_Entrega"
        Me.dtp_Buscar_Fecha_Entrega.Size = New System.Drawing.Size(134, 20)
        Me.dtp_Buscar_Fecha_Entrega.TabIndex = 6
        '
        'txt_Buscar_Cliente
        '
        Me.txt_Buscar_Cliente.Location = New System.Drawing.Point(377, 18)
        Me.txt_Buscar_Cliente.Name = "txt_Buscar_Cliente"
        Me.txt_Buscar_Cliente.Size = New System.Drawing.Size(95, 20)
        Me.txt_Buscar_Cliente.TabIndex = 4
        '
        'btnEliminar_Orden
        '
        Me.btnEliminar_Orden.Location = New System.Drawing.Point(961, 311)
        Me.btnEliminar_Orden.Name = "btnEliminar_Orden"
        Me.btnEliminar_Orden.Size = New System.Drawing.Size(113, 33)
        Me.btnEliminar_Orden.TabIndex = 28
        Me.btnEliminar_Orden.Text = "Eliminar Orden"
        Me.btnEliminar_Orden.UseVisualStyleBackColor = True
        '
        'btnModificar_Orden
        '
        Me.btnModificar_Orden.Location = New System.Drawing.Point(836, 311)
        Me.btnModificar_Orden.Name = "btnModificar_Orden"
        Me.btnModificar_Orden.Size = New System.Drawing.Size(119, 33)
        Me.btnModificar_Orden.TabIndex = 29
        Me.btnModificar_Orden.Text = "Modificar Orden"
        Me.btnModificar_Orden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(106, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total de ordenes"
        '
        'txt_Buscar_orden_trabajo
        '
        Me.txt_Buscar_orden_trabajo.Location = New System.Drawing.Point(139, 19)
        Me.txt_Buscar_orden_trabajo.Name = "txt_Buscar_orden_trabajo"
        Me.txt_Buscar_orden_trabajo.Size = New System.Drawing.Size(95, 20)
        Me.txt_Buscar_orden_trabajo.TabIndex = 2
        '
        'dgvLista_Orden_Trabajo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista_Orden_Trabajo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLista_Orden_Trabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista_Orden_Trabajo.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLista_Orden_Trabajo.Location = New System.Drawing.Point(17, 45)
        Me.dgvLista_Orden_Trabajo.Name = "dgvLista_Orden_Trabajo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista_Orden_Trabajo.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLista_Orden_Trabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Orden_Trabajo.Size = New System.Drawing.Size(1057, 258)
        Me.dgvLista_Orden_Trabajo.TabIndex = 0
        '
        'frm_listado_orden_trabajo_ampliada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 587)
        Me.Controls.Add(Me.GroupDetallesOrden)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Name = "frm_listado_orden_trabajo_ampliada"
        Me.Text = "frm_listado_orden_trabajo_ampliada"
        Me.GroupDetallesOrden.ResumeLayout(False)
        Me.GroupDetallesOrden.PerformLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupDetallesOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_Producto As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle_orden As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ODT_mostrar_listado_pdf As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents rbtFechaEntrega As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNroOrden As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_Buscar_Fecha_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Buscar_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar_Orden As System.Windows.Forms.Button
    Friend WithEvents btnModificar_Orden As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Buscar_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Orden_Trabajo As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
End Class
