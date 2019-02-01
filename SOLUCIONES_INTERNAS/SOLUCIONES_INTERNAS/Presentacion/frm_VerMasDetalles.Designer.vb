<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VerMasDetalles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VerMasDetalles))
        Me.Principal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Orden_Trabajo = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Tarea = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Producto = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ReTrabajo = New System.Windows.Forms.TabPage()
        Me.Etiquetas = New System.Windows.Forms.TabPage()
        Me.Principal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Orden_Trabajo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tarea.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Principal
        '
        Me.Principal.Controls.Add(Me.TabPage1)
        Me.Principal.Controls.Add(Me.Orden_Trabajo)
        Me.Principal.Controls.Add(Me.Tarea)
        Me.Principal.Controls.Add(Me.Producto)
        Me.Principal.Controls.Add(Me.ReTrabajo)
        Me.Principal.Controls.Add(Me.Etiquetas)
        Me.Principal.Location = New System.Drawing.Point(2, 1)
        Me.Principal.Name = "Principal"
        Me.Principal.SelectedIndex = 0
        Me.Principal.Size = New System.Drawing.Size(912, 647)
        Me.Principal.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(904, 621)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Principal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(649, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Formulario Principal"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SOLUCIONES_INTERNAS.My.Resources.Resources.principal1
        Me.PictureBox3.Location = New System.Drawing.Point(527, 379)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(351, 225)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(16, 16)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(485, 588)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Orden_Trabajo
        '
        Me.Orden_Trabajo.BackColor = System.Drawing.Color.DarkGray
        Me.Orden_Trabajo.Controls.Add(Me.Label2)
        Me.Orden_Trabajo.Controls.Add(Me.TextBox2)
        Me.Orden_Trabajo.Controls.Add(Me.PictureBox2)
        Me.Orden_Trabajo.Location = New System.Drawing.Point(4, 22)
        Me.Orden_Trabajo.Name = "Orden_Trabajo"
        Me.Orden_Trabajo.Padding = New System.Windows.Forms.Padding(3)
        Me.Orden_Trabajo.Size = New System.Drawing.Size(904, 621)
        Me.Orden_Trabajo.TabIndex = 1
        Me.Orden_Trabajo.Text = "Orden Trabajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(631, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Formulario Orden Trabajo"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(16, 16)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(485, 588)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SOLUCIONES_INTERNAS.My.Resources.Resources.nuevaordenampliada
        Me.PictureBox2.Location = New System.Drawing.Point(527, 341)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(351, 263)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Tarea
        '
        Me.Tarea.BackColor = System.Drawing.Color.DarkGray
        Me.Tarea.Controls.Add(Me.Label1)
        Me.Tarea.Controls.Add(Me.TextBox1)
        Me.Tarea.Controls.Add(Me.PictureBox1)
        Me.Tarea.Location = New System.Drawing.Point(4, 22)
        Me.Tarea.Name = "Tarea"
        Me.Tarea.Padding = New System.Windows.Forms.Padding(3)
        Me.Tarea.Size = New System.Drawing.Size(904, 621)
        Me.Tarea.TabIndex = 0
        Me.Tarea.Text = "Tarea"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(659, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Formulario Tarea"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(16, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(485, 588)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SOLUCIONES_INTERNAS.My.Resources.Resources.nueva_tarea
        Me.PictureBox1.Location = New System.Drawing.Point(527, 335)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Producto
        '
        Me.Producto.BackColor = System.Drawing.Color.DarkGray
        Me.Producto.Controls.Add(Me.Label5)
        Me.Producto.Controls.Add(Me.Label4)
        Me.Producto.Controls.Add(Me.PictureBox5)
        Me.Producto.Controls.Add(Me.TextBox4)
        Me.Producto.Controls.Add(Me.PictureBox4)
        Me.Producto.Location = New System.Drawing.Point(4, 22)
        Me.Producto.Name = "Producto"
        Me.Producto.Padding = New System.Windows.Forms.Padding(3)
        Me.Producto.Size = New System.Drawing.Size(904, 621)
        Me.Producto.TabIndex = 3
        Me.Producto.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(621, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Formulario Movimiento Productos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(649, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Formulario Productos"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SOLUCIONES_INTERNAS.My.Resources.Resources.nuevo_producto
        Me.PictureBox5.Location = New System.Drawing.Point(527, 32)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(351, 263)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(22, 16)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(485, 588)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SOLUCIONES_INTERNAS.My.Resources.Resources.alta_productos
        Me.PictureBox4.Location = New System.Drawing.Point(527, 341)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(351, 263)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(809, 654)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 33)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'ReTrabajo
        '
        Me.ReTrabajo.Location = New System.Drawing.Point(4, 22)
        Me.ReTrabajo.Name = "ReTrabajo"
        Me.ReTrabajo.Padding = New System.Windows.Forms.Padding(3)
        Me.ReTrabajo.Size = New System.Drawing.Size(904, 621)
        Me.ReTrabajo.TabIndex = 4
        Me.ReTrabajo.Text = "Re-Trabajo"
        Me.ReTrabajo.UseVisualStyleBackColor = True
        '
        'Etiquetas
        '
        Me.Etiquetas.Location = New System.Drawing.Point(4, 22)
        Me.Etiquetas.Name = "Etiquetas"
        Me.Etiquetas.Padding = New System.Windows.Forms.Padding(3)
        Me.Etiquetas.Size = New System.Drawing.Size(904, 621)
        Me.Etiquetas.TabIndex = 5
        Me.Etiquetas.Text = "Etiquetas"
        Me.Etiquetas.UseVisualStyleBackColor = True
        '
        'frm_VerMasDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 699)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Principal)
        Me.Name = "frm_VerMasDetalles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Más Detalles"
        Me.Principal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Orden_Trabajo.ResumeLayout(False)
        Me.Orden_Trabajo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tarea.ResumeLayout(False)
        Me.Tarea.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto.ResumeLayout(False)
        Me.Producto.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Principal As System.Windows.Forms.TabControl
    Friend WithEvents Tarea As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Orden_Trabajo As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Producto As System.Windows.Forms.TabPage
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReTrabajo As System.Windows.Forms.TabPage
    Friend WithEvents Etiquetas As System.Windows.Forms.TabPage
End Class
