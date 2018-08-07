<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Sector
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar_Sector = New System.Windows.Forms.Button()
        Me.txt_Buscar_Sector = New System.Windows.Forms.TextBox()
        Me.dgvLista_Sector = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupNuevaSector = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar_Sector = New System.Windows.Forms.Button()
        Me.btnActualizar_Sector = New System.Windows.Forms.Button()
        Me.btnGuardar_Sector = New System.Windows.Forms.Button()
        Me.btnNuevo_Sector = New System.Windows.Forms.Button()
        Me.txt_nombre_sector = New System.Windows.Forms.TextBox()
        Me.txt_id_sector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupListadoPiezas.SuspendLayout()
        CType(Me.dgvLista_Sector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevaSector.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupListadoPiezas
        '
        Me.GroupListadoPiezas.Controls.Add(Me.Label6)
        Me.GroupListadoPiezas.Controls.Add(Me.Label5)
        Me.GroupListadoPiezas.Controls.Add(Me.btnEliminar_Sector)
        Me.GroupListadoPiezas.Controls.Add(Me.txt_Buscar_Sector)
        Me.GroupListadoPiezas.Controls.Add(Me.dgvLista_Sector)
        Me.GroupListadoPiezas.Controls.Add(Me.Label4)
        Me.GroupListadoPiezas.Location = New System.Drawing.Point(26, 198)
        Me.GroupListadoPiezas.Name = "GroupListadoPiezas"
        Me.GroupListadoPiezas.Size = New System.Drawing.Size(486, 372)
        Me.GroupListadoPiezas.TabIndex = 5
        Me.GroupListadoPiezas.TabStop = False
        Me.GroupListadoPiezas.Text = "Listado de Sectores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(444, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 15)
        Me.Label6.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(347, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total de Sectores"
        '
        'btnEliminar_Sector
        '
        Me.btnEliminar_Sector.Location = New System.Drawing.Point(385, 38)
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
        Me.dgvLista_Sector.Size = New System.Drawing.Size(436, 253)
        Me.dgvLista_Sector.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar"
        '
        'GroupNuevaSector
        '
        Me.GroupNuevaSector.Controls.Add(Me.Label8)
        Me.GroupNuevaSector.Controls.Add(Me.btnCancelar_Sector)
        Me.GroupNuevaSector.Controls.Add(Me.btnActualizar_Sector)
        Me.GroupNuevaSector.Controls.Add(Me.btnGuardar_Sector)
        Me.GroupNuevaSector.Controls.Add(Me.btnNuevo_Sector)
        Me.GroupNuevaSector.Controls.Add(Me.txt_nombre_sector)
        Me.GroupNuevaSector.Controls.Add(Me.txt_id_sector)
        Me.GroupNuevaSector.Controls.Add(Me.Label2)
        Me.GroupNuevaSector.Controls.Add(Me.Label1)
        Me.GroupNuevaSector.Location = New System.Drawing.Point(26, 25)
        Me.GroupNuevaSector.Name = "GroupNuevaSector"
        Me.GroupNuevaSector.Size = New System.Drawing.Size(486, 157)
        Me.GroupNuevaSector.TabIndex = 4
        Me.GroupNuevaSector.TabStop = False
        Me.GroupNuevaSector.Text = "Nueva Sector"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(105, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "(Campo Requerido)"
        '
        'btnCancelar_Sector
        '
        Me.btnCancelar_Sector.Location = New System.Drawing.Point(365, 103)
        Me.btnCancelar_Sector.Name = "btnCancelar_Sector"
        Me.btnCancelar_Sector.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_Sector.TabIndex = 2
        Me.btnCancelar_Sector.Text = "Cancelar"
        Me.btnCancelar_Sector.UseVisualStyleBackColor = True
        '
        'btnActualizar_Sector
        '
        Me.btnActualizar_Sector.Location = New System.Drawing.Point(270, 103)
        Me.btnActualizar_Sector.Name = "btnActualizar_Sector"
        Me.btnActualizar_Sector.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar_Sector.TabIndex = 2
        Me.btnActualizar_Sector.Text = "Actualizar"
        Me.btnActualizar_Sector.UseVisualStyleBackColor = True
        '
        'btnGuardar_Sector
        '
        Me.btnGuardar_Sector.Location = New System.Drawing.Point(172, 103)
        Me.btnGuardar_Sector.Name = "btnGuardar_Sector"
        Me.btnGuardar_Sector.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_Sector.TabIndex = 4
        Me.btnGuardar_Sector.Text = "Guardar"
        Me.btnGuardar_Sector.UseVisualStyleBackColor = True
        '
        'btnNuevo_Sector
        '
        Me.btnNuevo_Sector.Location = New System.Drawing.Point(73, 103)
        Me.btnNuevo_Sector.Name = "btnNuevo_Sector"
        Me.btnNuevo_Sector.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo_Sector.TabIndex = 2
        Me.btnNuevo_Sector.Text = "Nuevo"
        Me.btnNuevo_Sector.UseVisualStyleBackColor = True
        '
        'txt_nombre_sector
        '
        Me.txt_nombre_sector.Location = New System.Drawing.Point(108, 38)
        Me.txt_nombre_sector.Name = "txt_nombre_sector"
        Me.txt_nombre_sector.Size = New System.Drawing.Size(332, 20)
        Me.txt_nombre_sector.TabIndex = 1
        '
        'txt_id_sector
        '
        Me.txt_id_sector.Location = New System.Drawing.Point(340, 64)
        Me.txt_id_sector.Name = "txt_id_sector"
        Me.txt_id_sector.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_sector.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_pieza"
        '
        'frm_Sector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 597)
        Me.Controls.Add(Me.GroupListadoPiezas)
        Me.Controls.Add(Me.GroupNuevaSector)
        Me.Name = "frm_Sector"
        Me.Text = "Sector"
        Me.GroupListadoPiezas.ResumeLayout(False)
        Me.GroupListadoPiezas.PerformLayout()
        CType(Me.dgvLista_Sector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevaSector.ResumeLayout(False)
        Me.GroupNuevaSector.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupListadoPiezas As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar_Sector As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar_Sector As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista_Sector As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupNuevaSector As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Sector As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Sector As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Sector As System.Windows.Forms.Button
    Friend WithEvents btnNuevo_Sector As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_sector As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_sector As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
