<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ingreso
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Contraseña"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(105, 26)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(213, 20)
        Me.txt_usuario.TabIndex = 17
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(47, 115)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 18
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(137, 115)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(14, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "*  (Campo Requerido)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(320, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(320, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "*"
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(228, 115)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(122, 23)
        Me.btnCambiarContraseña.TabIndex = 19
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(105, 67)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(213, 20)
        Me.txt_contraseña.TabIndex = 23
        '
        'frm_ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 183)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCambiarContraseña)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frm_ingreso"
        Me.Text = "Ingreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
End Class
