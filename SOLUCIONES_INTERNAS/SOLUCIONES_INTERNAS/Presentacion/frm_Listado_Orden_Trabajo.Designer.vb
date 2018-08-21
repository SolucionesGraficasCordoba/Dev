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
        Me.GroupListadoPiezas = New System.Windows.Forms.GroupBox()
        Me.btnEliminar_Orden = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Buscar_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.dgvLista_Orden_Trabajo = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnModificar_Orden = New System.Windows.Forms.Button()
        Me.btnEliminar_Detalle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_detalle_orden = New System.Windows.Forms.DataGridView()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Orden)
        Me.GroupListadoPiezas.Controls.Add(Me.Label3)
        Me.GroupListadoPiezas.Controls.Add(Me.Label7)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_orden_trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Orden_Trabajo)
        Me.GroupListadoPiezas.Controls.Add(Me.Label8)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(28, 26)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(575, 317)
        Me.GroupListadoPiezas.TabIndex = 29
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Listado de Ordenes"
        '
        'btnEliminar_Orden
        '
        Me.btnEliminar_Orden.Location = New System.Drawing.Point(439, 284)
        Me.btnEliminar_Orden.Name = "btnEliminar_Orden"
        Me.btnEliminar_Orden.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar_Orden.TabIndex = 28
        Me.btnEliminar_Orden.Text = "Eliminar Orden"
        Me.btnEliminar_Orden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(114, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 15)
        Me.Label3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total de ordenes"
        '
        'txt_Buscar_orden_trabajo
        '
        Me.txt_Buscar_orden_trabajo.Location = New System.Drawing.Point(110, 29)
        Me.txt_Buscar_orden_trabajo.Name = "txt_Buscar_orden_trabajo"
        Me.txt_Buscar_orden_trabajo.Size = New System.Drawing.Size(183, 20)
        Me.txt_Buscar_orden_trabajo.TabIndex = 2
        '
        'dgvLista_Orden_Trabajo
        '
        Me.dgvLista_Orden_Trabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Orden_Trabajo.Location = New System.Drawing.Point(24, 60)
        Me.dgvLista_Orden_Trabajo.Name = "dgvLista_Orden_Trabajo"
        Me.dgvLista_Orden_Trabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Orden_Trabajo.Size = New System.Drawing.Size(528, 208)
        Me.dgvLista_Orden_Trabajo.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Número Orden"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnModificar_Orden)
        Me.GroupBox1.Controls.Add(Me.btnEliminar_Detalle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgv_detalle_orden)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 365)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 283)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de la orden"
        '
        'btnModificar_Orden
        '
        Me.btnModificar_Orden.Location = New System.Drawing.Point(323, 250)
        Me.btnModificar_Orden.Name = "btnModificar_Orden"
        Me.btnModificar_Orden.Size = New System.Drawing.Size(113, 23)
        Me.btnModificar_Orden.TabIndex = 29
        Me.btnModificar_Orden.Text = "Modificar"
        Me.btnModificar_Orden.UseVisualStyleBackColor = True
        '
        'btnEliminar_Detalle
        '
        Me.btnEliminar_Detalle.Location = New System.Drawing.Point(442, 250)
        Me.btnEliminar_Detalle.Name = "btnEliminar_Detalle"
        Me.btnEliminar_Detalle.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar_Detalle.TabIndex = 35
        Me.btnEliminar_Detalle.Text = "Eliminar Detalle"
        Me.btnEliminar_Detalle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(117, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 15)
        Me.Label1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Items de la orden"
        '
        'dgv_detalle_orden
        '
        Me.dgv_detalle_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_orden.Location = New System.Drawing.Point(27, 30)
        Me.dgv_detalle_orden.Name = "dgv_detalle_orden"
        Me.dgv_detalle_orden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_orden.Size = New System.Drawing.Size(528, 208)
        Me.dgv_detalle_orden.TabIndex = 32
        '
        'frm_Listado_Orden_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 674)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Name = "frm_Listado_Orden_Trabajo"
        Me.Text = "Ordenes de Trabajo"
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Orden_Trabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_detalle_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Buscar_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Orden_Trabajo As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Orden As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle_orden As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar_Orden As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_Detalle As System.Windows.Forms.Button
End Class
