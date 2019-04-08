<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Despacho
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_chofer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_Hora_salida = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha_salida = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_numero_remito = New System.Windows.Forms.TextBox()
        Me.btnBuscar_orden = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_lista_ordenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numero_despacho = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_lista_ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_numero_despacho)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_chofer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp_Hora_salida)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha_salida)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_numero_remito)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del remito"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Chofer"
        '
        'cmb_chofer
        '
        Me.cmb_chofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_chofer.FormattingEnabled = True
        Me.cmb_chofer.Items.AddRange(New Object() {"Seleccionar", "Javier Perea", "Walter Farías", "Laureano", "Guillermo Akerman", "Sebastián Agote", "Marcelo Domínguez", "Tercero", "Retira de planta", "Retira de central", "Instalaciones"})
        Me.cmb_chofer.Location = New System.Drawing.Point(394, 13)
        Me.cmb_chofer.Name = "cmb_chofer"
        Me.cmb_chofer.Size = New System.Drawing.Size(255, 21)
        Me.cmb_chofer.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Remito N°"
        '
        'dtp_Hora_salida
        '
        Me.dtp_Hora_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Hora_salida.Location = New System.Drawing.Point(564, 46)
        Me.dtp_Hora_salida.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hora_salida.Name = "dtp_Hora_salida"
        Me.dtp_Hora_salida.Size = New System.Drawing.Size(85, 20)
        Me.dtp_Hora_salida.TabIndex = 17
        '
        'dtp_Fecha_salida
        '
        Me.dtp_Fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_salida.Location = New System.Drawing.Point(473, 46)
        Me.dtp_Fecha_salida.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtp_Fecha_salida.Name = "dtp_Fecha_salida"
        Me.dtp_Fecha_salida.Size = New System.Drawing.Size(85, 20)
        Me.dtp_Fecha_salida.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha  y hora de salida"
        '
        'txt_numero_remito
        '
        Me.txt_numero_remito.Location = New System.Drawing.Point(130, 44)
        Me.txt_numero_remito.Name = "txt_numero_remito"
        Me.txt_numero_remito.Size = New System.Drawing.Size(177, 20)
        Me.txt_numero_remito.TabIndex = 12
        '
        'btnBuscar_orden
        '
        Me.btnBuscar_orden.Location = New System.Drawing.Point(85, 18)
        Me.btnBuscar_orden.Name = "btnBuscar_orden"
        Me.btnBuscar_orden.Size = New System.Drawing.Size(52, 21)
        Me.btnBuscar_orden.TabIndex = 10
        Me.btnBuscar_orden.Text = "..."
        Me.btnBuscar_orden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Agregar orden"
        '
        'dgv_lista_ordenes
        '
        Me.dgv_lista_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista_ordenes.Location = New System.Drawing.Point(5, 45)
        Me.dgv_lista_ordenes.Name = "dgv_lista_ordenes"
        Me.dgv_lista_ordenes.Size = New System.Drawing.Size(718, 309)
        Me.dgv_lista_ordenes.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_lista_ordenes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnBuscar_orden)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 360)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle del remito"
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Location = New System.Drawing.Point(510, 462)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(107, 30)
        Me.Btn_guardar.TabIndex = 3
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Despacho Nº"
        '
        'txt_numero_despacho
        '
        Me.txt_numero_despacho.Enabled = False
        Me.txt_numero_despacho.Location = New System.Drawing.Point(130, 13)
        Me.txt_numero_despacho.Name = "txt_numero_despacho"
        Me.txt_numero_despacho.Size = New System.Drawing.Size(177, 20)
        Me.txt_numero_despacho.TabIndex = 23
        '
        'frm_Despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 500)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Despacho"
        Me.Text = "Despacho"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_lista_ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar_orden As System.Windows.Forms.Button
    Friend WithEvents txt_numero_remito As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Fecha_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_Hora_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_chofer As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_lista_ordenes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_despacho As System.Windows.Forms.TextBox
End Class
