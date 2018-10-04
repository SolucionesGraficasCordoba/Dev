<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Productos
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
        Me.btn_prod_guardar = New System.Windows.Forms.Button()
        Me.tb_prod_codigo = New System.Windows.Forms.TextBox()
        Me.tb_prod_descripcion = New System.Windows.Forms.TextBox()
        Me.tb_prod_stock = New System.Windows.Forms.TextBox()
        Me.dgvLista_Productos = New System.Windows.Forms.DataGridView()
        Me.btn_prod_eliminar = New System.Windows.Forms.Button()
        Me.btn_prod_actualizar = New System.Windows.Forms.Button()
        Me.tb_prod_id = New System.Windows.Forms.TextBox()
        Me.btn_prod_salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_prod_busqueda = New System.Windows.Forms.TextBox()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_prod_guardar
        '
        Me.btn_prod_guardar.Location = New System.Drawing.Point(64, 158)
        Me.btn_prod_guardar.Name = "btn_prod_guardar"
        Me.btn_prod_guardar.Size = New System.Drawing.Size(90, 22)
        Me.btn_prod_guardar.TabIndex = 4
        Me.btn_prod_guardar.Text = "Guardar"
        Me.btn_prod_guardar.UseVisualStyleBackColor = True
        '
        'tb_prod_codigo
        '
        Me.tb_prod_codigo.Location = New System.Drawing.Point(77, 23)
        Me.tb_prod_codigo.Name = "tb_prod_codigo"
        Me.tb_prod_codigo.Size = New System.Drawing.Size(112, 20)
        Me.tb_prod_codigo.TabIndex = 1
        '
        'tb_prod_descripcion
        '
        Me.tb_prod_descripcion.Location = New System.Drawing.Point(77, 55)
        Me.tb_prod_descripcion.Name = "tb_prod_descripcion"
        Me.tb_prod_descripcion.Size = New System.Drawing.Size(302, 20)
        Me.tb_prod_descripcion.TabIndex = 2
        '
        'tb_prod_stock
        '
        Me.tb_prod_stock.Location = New System.Drawing.Point(179, 90)
        Me.tb_prod_stock.Multiline = True
        Me.tb_prod_stock.Name = "tb_prod_stock"
        Me.tb_prod_stock.Size = New System.Drawing.Size(50, 50)
        Me.tb_prod_stock.TabIndex = 3
        Me.tb_prod_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvLista_Productos
        '
        Me.dgvLista_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista_Productos.Location = New System.Drawing.Point(9, 54)
        Me.dgvLista_Productos.Name = "dgvLista_Productos"
        Me.dgvLista_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista_Productos.Size = New System.Drawing.Size(381, 169)
        Me.dgvLista_Productos.TabIndex = 4
        '
        'btn_prod_eliminar
        '
        Me.btn_prod_eliminar.Location = New System.Drawing.Point(289, 19)
        Me.btn_prod_eliminar.Name = "btn_prod_eliminar"
        Me.btn_prod_eliminar.Size = New System.Drawing.Size(90, 22)
        Me.btn_prod_eliminar.TabIndex = 6
        Me.btn_prod_eliminar.Text = "Eliminar"
        Me.btn_prod_eliminar.UseVisualStyleBackColor = True
        '
        'btn_prod_actualizar
        '
        Me.btn_prod_actualizar.Location = New System.Drawing.Point(160, 158)
        Me.btn_prod_actualizar.Name = "btn_prod_actualizar"
        Me.btn_prod_actualizar.Size = New System.Drawing.Size(90, 22)
        Me.btn_prod_actualizar.TabIndex = 5
        Me.btn_prod_actualizar.Text = "Actualizar"
        Me.btn_prod_actualizar.UseVisualStyleBackColor = True
        '
        'tb_prod_id
        '
        Me.tb_prod_id.Location = New System.Drawing.Point(343, 23)
        Me.tb_prod_id.Name = "tb_prod_id"
        Me.tb_prod_id.Size = New System.Drawing.Size(49, 20)
        Me.tb_prod_id.TabIndex = 7
        '
        'btn_prod_salir
        '
        Me.btn_prod_salir.Location = New System.Drawing.Point(256, 158)
        Me.btn_prod_salir.Name = "btn_prod_salir"
        Me.btn_prod_salir.Size = New System.Drawing.Size(90, 22)
        Me.btn_prod_salir.TabIndex = 8
        Me.btn_prod_salir.Text = "Salir"
        Me.btn_prod_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id_producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cantidad en stock"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_prod_salir)
        Me.GroupBox1.Controls.Add(Me.btn_prod_actualizar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_prod_id)
        Me.GroupBox1.Controls.Add(Me.btn_prod_guardar)
        Me.GroupBox1.Controls.Add(Me.tb_prod_stock)
        Me.GroupBox1.Controls.Add(Me.tb_prod_descripcion)
        Me.GroupBox1.Controls.Add(Me.tb_prod_codigo)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 212)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de productos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(13, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "* (Campo Requerido)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(381, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(235, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tb_prod_busqueda)
        Me.GroupBox2.Controls.Add(Me.dgvLista_Productos)
        Me.GroupBox2.Controls.Add(Me.btn_prod_eliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 262)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de productos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(379, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(2, 15)
        Me.Label9.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ingrese Producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Total de Productos"
        '
        'tb_prod_busqueda
        '
        Me.tb_prod_busqueda.Location = New System.Drawing.Point(107, 21)
        Me.tb_prod_busqueda.Name = "tb_prod_busqueda"
        Me.tb_prod_busqueda.Size = New System.Drawing.Size(159, 20)
        Me.tb_prod_busqueda.TabIndex = 13
        '
        'frm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Productos"
        Me.Text = "Productos"
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_prod_guardar As System.Windows.Forms.Button
    Friend WithEvents tb_prod_codigo As System.Windows.Forms.TextBox
    Friend WithEvents tb_prod_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents tb_prod_stock As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_prod_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_prod_actualizar As System.Windows.Forms.Button
    Friend WithEvents tb_prod_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_prod_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_prod_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
