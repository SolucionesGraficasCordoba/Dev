<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Orden_Trabajo
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.btnEliminar_Orden = New System.Windows.Forms.Button()
        Me.btnModificar_Orden = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Buscar_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.dgvLista_Orden_Trabajo = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupDetallesOrden = New System.Windows.Forms.GroupBox()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnEliminar_Producto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_detalle_orden = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.dgvProcesos = New System.Windows.Forms.DataGridView()
        Me.GroupProcesoOrden = New System.Windows.Forms.GroupBox()
        Me.btnEliminarProceso = New System.Windows.Forms.Button()
        Me.btnModificarProceso = New System.Windows.Forms.Button()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDetallesOrden.SuspendLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupProcesoOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.btnModificar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.Label3)
        Me.GroupListadoPiezas.Controls.Add(Me.Label7)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_orden_trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Orden_Trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.Label8)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(10, 9)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(603, 243)
        Me.GroupListadoPiezas.TabIndex = 29
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Listado de Ordenes"
        '
        'btnEliminar_Orden
        '
        Me.btnEliminar_Orden.Location = New System.Drawing.Point(478, 209)
        Me.btnEliminar_Orden.Name = "btnEliminar_Orden"
        Me.btnEliminar_Orden.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar_Orden.TabIndex = 28
        Me.btnEliminar_Orden.Text = "Eliminar Orden"
        Me.btnEliminar_Orden.UseVisualStyleBackColor = True
        '
        'btnModificar_Orden
        '
        Me.btnModificar_Orden.Location = New System.Drawing.Point(353, 209)
        Me.btnModificar_Orden.Name = "btnModificar_Orden"
        Me.btnModificar_Orden.Size = New System.Drawing.Size(119, 23)
        Me.btnModificar_Orden.TabIndex = 29
        Me.btnModificar_Orden.Text = "Modificar Orden"
        Me.btnModificar_Orden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(104, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total de ordenes"
        '
        'txt_Buscar_orden_trabajo
        '
        Me.txt_Buscar_orden_trabajo.Location = New System.Drawing.Point(99, 19)
        Me.txt_Buscar_orden_trabajo.Name = "txt_Buscar_orden_trabajo"
        Me.txt_Buscar_orden_trabajo.Size = New System.Drawing.Size(133, 20)
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
        Me.dgvLista_Orden_Trabajo.Location = New System.Drawing.Point(13, 45)
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
        Me.dgvLista_Orden_Trabajo.Size = New System.Drawing.Size(578, 158)
        Me.dgvLista_Orden_Trabajo.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Número Orden"
        '
        'GroupDetallesOrden
        '
        Me.GroupDetallesOrden.Controls.Add(Me.btnModificarProducto)
        Me.GroupDetallesOrden.Controls.Add(Me.btnVer)
        Me.GroupDetallesOrden.Controls.Add(Me.btnEliminar_Producto)
        Me.GroupDetallesOrden.Controls.Add(Me.Label1)
        Me.GroupDetallesOrden.Controls.Add(Me.dgv_detalle_orden)
        Me.GroupDetallesOrden.Controls.Add(Me.Label2)
        Me.GroupDetallesOrden.Location = New System.Drawing.Point(10, 258)
        Me.GroupDetallesOrden.Name = "GroupDetallesOrden"
        Me.GroupDetallesOrden.Size = New System.Drawing.Size(603, 218)
        Me.GroupDetallesOrden.TabIndex = 30
        Me.GroupDetallesOrden.TabStop = False
        Me.GroupDetallesOrden.Text = "Detalles de la orden"
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(353, 186)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(119, 23)
        Me.btnModificarProducto.TabIndex = 38
        Me.btnModificarProducto.Text = "Modificar Producto"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(176, 184)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(67, 23)
        Me.btnVer.TabIndex = 37
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        Me.btnVer.Visible = False
        '
        'btnEliminar_Producto
        '
        Me.btnEliminar_Producto.Location = New System.Drawing.Point(478, 186)
        Me.btnEliminar_Producto.Name = "btnEliminar_Producto"
        Me.btnEliminar_Producto.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar_Producto.TabIndex = 35
        Me.btnEliminar_Producto.Text = "Eliminar Producto"
        Me.btnEliminar_Producto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(127, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 34
        '
        'dgv_detalle_orden
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_orden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_detalle_orden.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_detalle_orden.Location = New System.Drawing.Point(13, 19)
        Me.dgv_detalle_orden.Name = "dgv_detalle_orden"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_orden.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_detalle_orden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_orden.Size = New System.Drawing.Size(578, 158)
        Me.dgv_detalle_orden.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Productos de la orden"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(534, 677)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(67, 23)
        Me.btn_Cancelar.TabIndex = 36
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'dgvProcesos
        '
        Me.dgvProcesos.AllowUserToAddRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProcesos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProcesos.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvProcesos.Location = New System.Drawing.Point(11, 19)
        Me.dgvProcesos.Name = "dgvProcesos"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProcesos.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProcesos.Size = New System.Drawing.Size(578, 158)
        Me.dgvProcesos.TabIndex = 39
        '
        'GroupProcesoOrden
        '
        Me.GroupProcesoOrden.Controls.Add(Me.dgvProcesos)
        Me.GroupProcesoOrden.Location = New System.Drawing.Point(12, 482)
        Me.GroupProcesoOrden.Name = "GroupProcesoOrden"
        Me.GroupProcesoOrden.Size = New System.Drawing.Size(603, 189)
        Me.GroupProcesoOrden.TabIndex = 40
        Me.GroupProcesoOrden.TabStop = False
        Me.GroupProcesoOrden.Text = "Procesos"
        '
        'btnEliminarProceso
        '
        Me.btnEliminarProceso.Location = New System.Drawing.Point(415, 677)
        Me.btnEliminarProceso.Name = "btnEliminarProceso"
        Me.btnEliminarProceso.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminarProceso.TabIndex = 41
        Me.btnEliminarProceso.Text = "Eliminar Proceso"
        Me.btnEliminarProceso.UseVisualStyleBackColor = True
        '
        'btnModificarProceso
        '
        Me.btnModificarProceso.Location = New System.Drawing.Point(290, 677)
        Me.btnModificarProceso.Name = "btnModificarProceso"
        Me.btnModificarProceso.Size = New System.Drawing.Size(119, 23)
        Me.btnModificarProceso.TabIndex = 42
        Me.btnModificarProceso.Text = "Modificar Proceso"
        Me.btnModificarProceso.UseVisualStyleBackColor = True
        '
        'frm_Listado_Orden_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 710)
        Me.Controls.Add(Me.btnModificarProceso)
        Me.Controls.Add(Me.btnEliminarProceso)
        Me.Controls.Add(Me.GroupProcesoOrden)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.GroupDetallesOrden)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Name = "frm_Listado_Orden_Trabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de Trabajo"
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDetallesOrden.ResumeLayout(False)
        Me.GroupDetallesOrden.PerformLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupProcesoOrden.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Buscar_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Orden_Trabajo As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Orden As System.Windows.Forms.Button
    Friend WithEvents GroupDetallesOrden As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle_orden As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar_Orden As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_Producto As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents dgvProcesos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupProcesoOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnEliminarProceso As System.Windows.Forms.Button
    Friend WithEvents btnModificarProceso As System.Windows.Forms.Button
End Class
