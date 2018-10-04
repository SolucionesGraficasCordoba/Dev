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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_prod_busqueda = New System.Windows.Forms.TextBox()
        CType(Me.dgvLista_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_prod_guardar
        '
        Me.btn_prod_guardar.Location = New System.Drawing.Point(69, 149)
        Me.btn_prod_guardar.Name = "btn_prod_guardar"
        Me.btn_prod_guardar.Size = New System.Drawing.Size(90, 22)
        Me.btn_prod_guardar.TabIndex = 4
        Me.btn_prod_guardar.Text = "Guardar"
        Me.btn_prod_guardar.UseVisualStyleBackColor = True
        '
        'tb_prod_codigo
        '
        Me.tb_prod_codigo.Location = New System.Drawing.Point(132, 23)
        Me.tb_prod_codigo.Name = "tb_prod_codigo"
        Me.tb_prod_codigo.Size = New System.Drawing.Size(112, 20)
        Me.tb_prod_codigo.TabIndex = 1
        '
        'tb_prod_descripcion
        '
        Me.tb_prod_descripcion.Location = New System.Drawing.Point(132, 52)
        Me.tb_prod_descripcion.Name = "tb_prod_descripcion"
        Me.tb_prod_descripcion.Size = New System.Drawing.Size(258, 20)
        Me.tb_prod_descripcion.TabIndex = 2
        '
        'tb_prod_stock
        '
        Me.tb_prod_stock.Location = New System.Drawing.Point(132, 78)
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
        Me.dgvLista_Productos.Size = New System.Drawing.Size(381, 182)
        Me.dgvLista_Productos.TabIndex = 4
        '
        'btn_prod_eliminar
        '
        Me.btn_prod_eliminar.Location = New System.Drawing.Point(261, 149)
        Me.btn_prod_eliminar.Name = "btn_prod_eliminar"
        Me.btn_prod_eliminar.Size = New System.Drawing.Size(90, 22)
        Me.btn_prod_eliminar.TabIndex = 6
        Me.btn_prod_eliminar.Text = "Eliminar"
        Me.btn_prod_eliminar.UseVisualStyleBackColor = True
        '
        'btn_prod_actualizar
        '
        Me.btn_prod_actualizar.Location = New System.Drawing.Point(165, 149)
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
        Me.btn_prod_salir.Location = New System.Drawing.Point(339, 461)
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
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Código de producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Descripción de producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cantidad en stock"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_prod_actualizar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_prod_eliminar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_prod_id)
        Me.GroupBox1.Controls.Add(Me.btn_prod_guardar)
        Me.GroupBox1.Controls.Add(Me.tb_prod_stock)
        Me.GroupBox1.Controls.Add(Me.tb_prod_descripcion)
        Me.GroupBox1.Controls.Add(Me.tb_prod_codigo)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 177)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de productos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_prod_busqueda)
        Me.GroupBox2.Controls.Add(Me.dgvLista_Productos)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 242)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de productos"
        '
        'tb_prod_busqueda
        '
        Me.tb_prod_busqueda.Location = New System.Drawing.Point(107, 28)
        Me.tb_prod_busqueda.Name = "tb_prod_busqueda"
        Me.tb_prod_busqueda.Size = New System.Drawing.Size(112, 20)
        Me.tb_prod_busqueda.TabIndex = 13
        '
        'frm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_prod_salir)
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
End Class
