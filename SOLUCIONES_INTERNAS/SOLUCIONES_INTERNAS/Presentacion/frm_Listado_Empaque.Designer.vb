﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listado_Empaque
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
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.rbt_orden = New System.Windows.Forms.RadioButton()
        Me.rbt_despacho = New System.Windows.Forms.RadioButton()
        Me.rbt_entrega = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_estado = New System.Windows.Forms.DateTimePicker()
        Me.btn_agregarodt = New System.Windows.Forms.Button()
        Me.btn_generar_informe = New System.Windows.Forms.Button()
        Me.dgv_planificacion = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_planificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(12, 53)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(168, 20)
        Me.txt_buscar.TabIndex = 2
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(441, 486)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 21)
        Me.btn_modificar.TabIndex = 5
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(441, 486)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 21)
        Me.btn_eliminar.TabIndex = 6
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(548, 486)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(101, 21)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'rbt_orden
        '
        Me.rbt_orden.AutoSize = True
        Me.rbt_orden.Location = New System.Drawing.Point(6, 19)
        Me.rbt_orden.Name = "rbt_orden"
        Me.rbt_orden.Size = New System.Drawing.Size(67, 17)
        Me.rbt_orden.TabIndex = 8
        Me.rbt_orden.TabStop = True
        Me.rbt_orden.Text = "N° orden"
        Me.rbt_orden.UseVisualStyleBackColor = True
        '
        'rbt_despacho
        '
        Me.rbt_despacho.AutoSize = True
        Me.rbt_despacho.Location = New System.Drawing.Point(80, 19)
        Me.rbt_despacho.Name = "rbt_despacho"
        Me.rbt_despacho.Size = New System.Drawing.Size(87, 17)
        Me.rbt_despacho.TabIndex = 9
        Me.rbt_despacho.TabStop = True
        Me.rbt_despacho.Text = "N° despacho"
        Me.rbt_despacho.UseVisualStyleBackColor = True
        '
        'rbt_entrega
        '
        Me.rbt_entrega.AutoSize = True
        Me.rbt_entrega.Location = New System.Drawing.Point(169, 19)
        Me.rbt_entrega.Name = "rbt_entrega"
        Me.rbt_entrega.Size = New System.Drawing.Size(85, 17)
        Me.rbt_entrega.TabIndex = 10
        Me.rbt_entrega.TabStop = True
        Me.rbt_entrega.Text = "Fecha salida"
        Me.rbt_entrega.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_orden)
        Me.GroupBox1.Controls.Add(Me.rbt_entrega)
        Me.GroupBox1.Controls.Add(Me.rbt_despacho)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 45)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'dtp_fecha_estado
        '
        Me.dtp_fecha_estado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_estado.Location = New System.Drawing.Point(186, 53)
        Me.dtp_fecha_estado.Name = "dtp_fecha_estado"
        Me.dtp_fecha_estado.Size = New System.Drawing.Size(92, 20)
        Me.dtp_fecha_estado.TabIndex = 12
        '
        'btn_agregarodt
        '
        Me.btn_agregarodt.Location = New System.Drawing.Point(334, 486)
        Me.btn_agregarodt.Name = "btn_agregarodt"
        Me.btn_agregarodt.Size = New System.Drawing.Size(101, 21)
        Me.btn_agregarodt.TabIndex = 13
        Me.btn_agregarodt.Text = "Agregar odt"
        Me.btn_agregarodt.UseVisualStyleBackColor = True
        '
        'btn_generar_informe
        '
        Me.btn_generar_informe.Location = New System.Drawing.Point(12, 486)
        Me.btn_generar_informe.Name = "btn_generar_informe"
        Me.btn_generar_informe.Size = New System.Drawing.Size(101, 21)
        Me.btn_generar_informe.TabIndex = 14
        Me.btn_generar_informe.Text = "Generar informe"
        Me.btn_generar_informe.UseVisualStyleBackColor = True
        '
        'dgv_planificacion
        '
        Me.dgv_planificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_planificacion.Location = New System.Drawing.Point(13, 79)
        Me.dgv_planificacion.MultiSelect = False
        Me.dgv_planificacion.Name = "dgv_planificacion"
        Me.dgv_planificacion.Size = New System.Drawing.Size(636, 401)
        Me.dgv_planificacion.TabIndex = 1
        '
        'frm_Listado_Empaque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 515)
        Me.Controls.Add(Me.btn_generar_informe)
        Me.Controls.Add(Me.btn_agregarodt)
        Me.Controls.Add(Me.dtp_fecha_estado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_planificacion)
        Me.Name = "frm_Listado_Empaque"
        Me.Text = "Listado de empaques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_planificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents rbt_orden As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_despacho As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_entrega As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_estado As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_agregarodt As System.Windows.Forms.Button
    Friend WithEvents btn_generar_informe As System.Windows.Forms.Button
    Friend WithEvents dgv_planificacion As System.Windows.Forms.DataGridView
End Class