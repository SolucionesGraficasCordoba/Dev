<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Movimientos
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
        Me.GroupDetallesOrden = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txt_Buscar_Producto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.dgv_movimientos = New System.Windows.Forms.DataGridView()
        Me.GroupDetallesOrden.SuspendLayout()
        CType(Me.dgv_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupDetallesOrden
        '
        Me.GroupDetallesOrden.Controls.Add(Me.btnImprimir)
        Me.GroupDetallesOrden.Controls.Add(Me.txt_Buscar_Producto)
        Me.GroupDetallesOrden.Controls.Add(Me.Label8)
        Me.GroupDetallesOrden.Controls.Add(Me.btn_Cancelar)
        Me.GroupDetallesOrden.Controls.Add(Me.dgv_movimientos)
        Me.GroupDetallesOrden.Location = New System.Drawing.Point(12, 12)
        Me.GroupDetallesOrden.Name = "GroupDetallesOrden"
        Me.GroupDetallesOrden.Size = New System.Drawing.Size(536, 299)
        Me.GroupDetallesOrden.TabIndex = 31
        Me.GroupDetallesOrden.TabStop = False
        Me.GroupDetallesOrden.Text = "Listado de Movimientos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(333, 266)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(90, 23)
        Me.btnImprimir.TabIndex = 40
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txt_Buscar_Producto
        '
        Me.txt_Buscar_Producto.Location = New System.Drawing.Point(141, 26)
        Me.txt_Buscar_Producto.Name = "txt_Buscar_Producto"
        Me.txt_Buscar_Producto.Size = New System.Drawing.Size(123, 20)
        Me.txt_Buscar_Producto.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Ingrese Producto"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(429, 266)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(90, 23)
        Me.btn_Cancelar.TabIndex = 36
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'dgv_movimientos
        '
        Me.dgv_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_movimientos.Location = New System.Drawing.Point(16, 52)
        Me.dgv_movimientos.Name = "dgv_movimientos"
        Me.dgv_movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_movimientos.Size = New System.Drawing.Size(503, 208)
        Me.dgv_movimientos.TabIndex = 32
        '
        'frm_Listado_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 319)
        Me.Controls.Add(Me.GroupDetallesOrden)
        Me.Name = "frm_Listado_Movimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Movimientos"
        Me.GroupDetallesOrden.ResumeLayout(False)
        Me.GroupDetallesOrden.PerformLayout()
        CType(Me.dgv_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupDetallesOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents dgv_movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Buscar_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
