﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Actualizar_Offset
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_chapa_soporte_1 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboMarca_Offset = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cboImpresora_Original = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPiezas1_Detalle1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_Fecha_Ingreso_Original = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTamaño1_Detalle1 = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_original = New System.Windows.Forms.TextBox()
        Me.btnBuscar_Numero_Orden1 = New System.Windows.Forms.Button()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_id_detalle_orden_trabajo1 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnGuardar_ReTrabajo = New System.Windows.Forms.Button()
        Me.dtp_Nueva_Fecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cantidad_chapas_retrabajo = New System.Windows.Forms.TextBox()
        Me.dtpFecha_Re_Trabajo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar_ReTrabajo = New System.Windows.Forms.Button()
        Me.txt_id_re_trabajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_procedimiento = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboImpresora_Offset = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_chapa_soporte_1)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.cboMarca_Offset)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label66)
        Me.GroupBox1.Controls.Add(Me.cboImpresora_Original)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboPiezas1_Detalle1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha_Ingreso_Original)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTamaño1_Detalle1)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad_original)
        Me.GroupBox1.Controls.Add(Me.btnBuscar_Numero_Orden1)
        Me.GroupBox1.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 182)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos originales"
        '
        'txt_chapa_soporte_1
        '
        Me.txt_chapa_soporte_1.Location = New System.Drawing.Point(413, 107)
        Me.txt_chapa_soporte_1.MaxLength = 2
        Me.txt_chapa_soporte_1.Name = "txt_chapa_soporte_1"
        Me.txt_chapa_soporte_1.Size = New System.Drawing.Size(75, 20)
        Me.txt_chapa_soporte_1.TabIndex = 152
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(428, 91)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 151
        Me.Label36.Text = "Chapas"
        '
        'cboMarca_Offset
        '
        Me.cboMarca_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca_Offset.FormattingEnabled = True
        Me.cboMarca_Offset.Items.AddRange(New Object() {"AGFA TU", "KODAK", "KTP - KONITA"})
        Me.cboMarca_Offset.Location = New System.Drawing.Point(214, 146)
        Me.cboMarca_Offset.Name = "cboMarca_Offset"
        Me.cboMarca_Offset.Size = New System.Drawing.Size(127, 21)
        Me.cboMarca_Offset.TabIndex = 145
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(171, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "Marca"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(27, 149)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(53, 13)
        Me.Label66.TabIndex = 142
        Me.Label66.Text = "Impresora"
        '
        'cboImpresora_Original
        '
        Me.cboImpresora_Original.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora_Original.FormattingEnabled = True
        Me.cboImpresora_Original.Items.AddRange(New Object() {"CD/4", "CD/6", "SM", "SOR"})
        Me.cboImpresora_Original.Location = New System.Drawing.Point(86, 146)
        Me.cboImpresora_Original.Name = "cboImpresora_Original"
        Me.cboImpresora_Original.Size = New System.Drawing.Size(75, 21)
        Me.cboImpresora_Original.TabIndex = 143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Tamaño (°°° x °°° Mm)"
        '
        'cboPiezas1_Detalle1
        '
        Me.cboPiezas1_Detalle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas1_Detalle1.FormattingEnabled = True
        Me.cboPiezas1_Detalle1.Location = New System.Drawing.Point(86, 107)
        Me.cboPiezas1_Detalle1.Name = "cboPiezas1_Detalle1"
        Me.cboPiezas1_Detalle1.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas1_Detalle1.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piezas"
        '
        'dtp_Fecha_Ingreso_Original
        '
        Me.dtp_Fecha_Ingreso_Original.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Ingreso_Original.Location = New System.Drawing.Point(362, 41)
        Me.dtp_Fecha_Ingreso_Original.Name = "dtp_Fecha_Ingreso_Original"
        Me.dtp_Fecha_Ingreso_Original.Size = New System.Drawing.Size(109, 20)
        Me.dtp_Fecha_Ingreso_Original.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(304, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 26)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Ingreso"
        '
        'txtTamaño1_Detalle1
        '
        Me.txtTamaño1_Detalle1.Location = New System.Drawing.Point(254, 107)
        Me.txtTamaño1_Detalle1.MaxLength = 50
        Me.txtTamaño1_Detalle1.Name = "txtTamaño1_Detalle1"
        Me.txtTamaño1_Detalle1.Size = New System.Drawing.Size(153, 20)
        Me.txtTamaño1_Detalle1.TabIndex = 34
        '
        'txt_cantidad_original
        '
        Me.txt_cantidad_original.Location = New System.Drawing.Point(21, 107)
        Me.txt_cantidad_original.Name = "txt_cantidad_original"
        Me.txt_cantidad_original.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad_original.TabIndex = 33
        '
        'btnBuscar_Numero_Orden1
        '
        Me.btnBuscar_Numero_Orden1.Location = New System.Drawing.Point(246, 19)
        Me.btnBuscar_Numero_Orden1.Name = "btnBuscar_Numero_Orden1"
        Me.btnBuscar_Numero_Orden1.Size = New System.Drawing.Size(46, 23)
        Me.btnBuscar_Numero_Orden1.TabIndex = 1
        Me.btnBuscar_Numero_Orden1.Text = "..."
        Me.btnBuscar_Numero_Orden1.UseVisualStyleBackColor = True
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(247, 53)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(23, 20)
        Me.txt_id_orden_trabajo.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 26)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Número de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Orden"
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(86, 19)
        Me.txtNumero_Orden_Trabajo.MaxLength = 10
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(154, 54)
        Me.txtNumero_Orden_Trabajo.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(18, 467)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 155
        Me.Label17.Text = "* (campos requeridos)"
        '
        'txt_id_detalle_orden_trabajo1
        '
        Me.txt_id_detalle_orden_trabajo1.Location = New System.Drawing.Point(233, 484)
        Me.txt_id_detalle_orden_trabajo1.Name = "txt_id_detalle_orden_trabajo1"
        Me.txt_id_detalle_orden_trabajo1.Size = New System.Drawing.Size(17, 20)
        Me.txt_id_detalle_orden_trabajo1.TabIndex = 150
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(104, 487)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(129, 13)
        Me.Label45.TabIndex = 149
        Me.Label45.Text = "id_detalle_orden_trabajo1"
        '
        'btnGuardar_ReTrabajo
        '
        Me.btnGuardar_ReTrabajo.Location = New System.Drawing.Point(370, 470)
        Me.btnGuardar_ReTrabajo.Name = "btnGuardar_ReTrabajo"
        Me.btnGuardar_ReTrabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_ReTrabajo.TabIndex = 146
        Me.btnGuardar_ReTrabajo.Text = "Guardar"
        Me.btnGuardar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'dtp_Nueva_Fecha_Entrega
        '
        Me.dtp_Nueva_Fecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Nueva_Fecha_Entrega.Location = New System.Drawing.Point(377, 22)
        Me.dtp_Nueva_Fecha_Entrega.Name = "dtp_Nueva_Fecha_Entrega"
        Me.dtp_Nueva_Fecha_Entrega.Size = New System.Drawing.Size(110, 20)
        Me.dtp_Nueva_Fecha_Entrega.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(244, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 13)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Nueva Fecha de Entrega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(111, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 26)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = " Cantidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Chapas"
        '
        'txt_cantidad_chapas_retrabajo
        '
        Me.txt_cantidad_chapas_retrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_chapas_retrabajo.Location = New System.Drawing.Point(124, 62)
        Me.txt_cantidad_chapas_retrabajo.Name = "txt_cantidad_chapas_retrabajo"
        Me.txt_cantidad_chapas_retrabajo.Size = New System.Drawing.Size(110, 20)
        Me.txt_cantidad_chapas_retrabajo.TabIndex = 6
        Me.txt_cantidad_chapas_retrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_Re_Trabajo
        '
        Me.dtpFecha_Re_Trabajo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Re_Trabajo.Location = New System.Drawing.Point(124, 22)
        Me.dtpFecha_Re_Trabajo.Name = "dtpFecha_Re_Trabajo"
        Me.dtpFecha_Re_Trabajo.Size = New System.Drawing.Size(110, 20)
        Me.dtpFecha_Re_Trabajo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Fecha de Retrabajo"
        '
        'btnCancelar_ReTrabajo
        '
        Me.btnCancelar_ReTrabajo.Location = New System.Drawing.Point(451, 470)
        Me.btnCancelar_ReTrabajo.Name = "btnCancelar_ReTrabajo"
        Me.btnCancelar_ReTrabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_ReTrabajo.TabIndex = 147
        Me.btnCancelar_ReTrabajo.Text = "Cancelar"
        Me.btnCancelar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'txt_id_re_trabajo
        '
        Me.txt_id_re_trabajo.Location = New System.Drawing.Point(342, 483)
        Me.txt_id_re_trabajo.Name = "txt_id_re_trabajo"
        Me.txt_id_re_trabajo.Size = New System.Drawing.Size(10, 20)
        Me.txt_id_re_trabajo.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "id_re_trabajo"
        '
        'txt_procedimiento
        '
        Me.txt_procedimiento.Location = New System.Drawing.Point(6, 143)
        Me.txt_procedimiento.MaxLength = 350
        Me.txt_procedimiento.Multiline = True
        Me.txt_procedimiento.Name = "txt_procedimiento"
        Me.txt_procedimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_procedimiento.Size = New System.Drawing.Size(495, 115)
        Me.txt_procedimiento.TabIndex = 145
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 154
        Me.Label19.Text = "Observaciones"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(255, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "Motivo"
        '
        'cboMotivo
        '
        Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"EPR - ERROR PRENSA", "REI - REIMPRESION", "EFO - ERROR FOTOMECANICA", "DIS - CAMBIO DISEÑO", "TL - TIRAJE LARGO"})
        Me.cboMotivo.Location = New System.Drawing.Point(307, 62)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(180, 21)
        Me.cboMotivo.TabIndex = 159
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboImpresora_Offset)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboMotivo)
        Me.GroupBox2.Controls.Add(Me.dtp_Nueva_Fecha_Entrega)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpFecha_Re_Trabajo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad_chapas_retrabajo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_procedimiento)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 264)
        Me.GroupBox2.TabIndex = 160
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(293, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "*"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"AGFA TU", "KODAK", "KTP - KONITA"})
        Me.ComboBox3.Location = New System.Drawing.Point(307, 101)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox3.TabIndex = 163
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Marca"
        '
        'cboImpresora_Offset
        '
        Me.cboImpresora_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora_Offset.FormattingEnabled = True
        Me.cboImpresora_Offset.Items.AddRange(New Object() {"CD/4", "CD/6", "SM", "SOR"})
        Me.cboImpresora_Offset.Location = New System.Drawing.Point(124, 101)
        Me.cboImpresora_Offset.Name = "cboImpresora_Offset"
        Me.cboImpresora_Offset.Size = New System.Drawing.Size(110, 21)
        Me.cboImpresora_Offset.TabIndex = 161
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(65, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "Impresora"
        '
        'frm_Actualizar_Offset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 516)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnGuardar_ReTrabajo)
        Me.Controls.Add(Me.btnCancelar_ReTrabajo)
        Me.Controls.Add(Me.txt_id_detalle_orden_trabajo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.txt_id_re_trabajo)
        Me.Name = "frm_Actualizar_Offset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repetición de Chapas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas1_Detalle1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha_Ingreso_Original As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño1_Detalle1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_original As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_id_detalle_orden_trabajo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar_ReTrabajo As System.Windows.Forms.Button
    Friend WithEvents dtp_Nueva_Fecha_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_chapas_retrabajo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_Re_Trabajo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_ReTrabajo As System.Windows.Forms.Button
    Friend WithEvents txt_id_re_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_procedimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboImpresora_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents cboMarca_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents cboImpresora_Original As System.Windows.Forms.ComboBox
    Friend WithEvents txt_chapa_soporte_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Numero_Orden1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
