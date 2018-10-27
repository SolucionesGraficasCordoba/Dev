<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_retrabajo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_retrabajo))
        Me.txt_id_re_trabajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_procedimiento = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_origen = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnBuscar_Numero_Orden1 = New System.Windows.Forms.Button()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnGuardar_ReTrabajo = New System.Windows.Forms.Button()
        Me.GroupProducto1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cantidad_retrabajo = New System.Windows.Forms.TextBox()
        Me.dtpFecha_Re_Trabajo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboFormato3_Soporte1 = New System.Windows.Forms.ComboBox()
        Me.cboFormato2_Soporte1 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Cantidad3_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje3_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Papel3_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad2_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje2_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Papel2_Soporte1 = New System.Windows.Forms.TextBox()
        Me.cboFormato1_Soporte1 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Cantidad1_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje1_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_Papel1_Soporte1 = New System.Windows.Forms.TextBox()
        Me.txt_id_detalle_orden_trabajo1 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cboPiezas1_Detalle1 = New System.Windows.Forms.ComboBox()
        Me.cboTipoImpresion1_Detalle1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTamaño1_Detalle1 = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_original = New System.Windows.Forms.TextBox()
        Me.btnCancelar_ReTrabajo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.dtp_Fecha_Original = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnImprimirFormulario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupProducto1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id_re_trabajo
        '
        Me.txt_id_re_trabajo.Location = New System.Drawing.Point(625, 15)
        Me.txt_id_re_trabajo.Name = "txt_id_re_trabajo"
        Me.txt_id_re_trabajo.Size = New System.Drawing.Size(53, 20)
        Me.txt_id_re_trabajo.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(551, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "id_re_trabajo"
        '
        'txt_procedimiento
        '
        Me.txt_procedimiento.Location = New System.Drawing.Point(85, 92)
        Me.txt_procedimiento.MaxLength = 100
        Me.txt_procedimiento.Name = "txt_procedimiento"
        Me.txt_procedimiento.Size = New System.Drawing.Size(593, 20)
        Me.txt_procedimiento.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Procedimiento"
        '
        'txt_origen
        '
        Me.txt_origen.Location = New System.Drawing.Point(85, 55)
        Me.txt_origen.MaxLength = 100
        Me.txt_origen.Name = "txt_origen"
        Me.txt_origen.Size = New System.Drawing.Size(593, 20)
        Me.txt_origen.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(41, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Origen"
        '
        'btnBuscar_Numero_Orden1
        '
        Me.btnBuscar_Numero_Orden1.Location = New System.Drawing.Point(273, 16)
        Me.btnBuscar_Numero_Orden1.Name = "btnBuscar_Numero_Orden1"
        Me.btnBuscar_Numero_Orden1.Size = New System.Drawing.Size(63, 23)
        Me.btnBuscar_Numero_Orden1.TabIndex = 1
        Me.btnBuscar_Numero_Orden1.Text = "..."
        Me.btnBuscar_Numero_Orden1.UseVisualStyleBackColor = True
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(85, 18)
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(182, 20)
        Me.txtNumero_Orden_Trabajo.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "OT"
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(342, 18)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(23, 20)
        Me.txt_id_orden_trabajo.TabIndex = 77
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(18, 355)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "* (campos requeridos)"
        '
        'btnGuardar_ReTrabajo
        '
        Me.btnGuardar_ReTrabajo.Location = New System.Drawing.Point(522, 350)
        Me.btnGuardar_ReTrabajo.Name = "btnGuardar_ReTrabajo"
        Me.btnGuardar_ReTrabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar_ReTrabajo.TabIndex = 19
        Me.btnGuardar_ReTrabajo.Text = "Guardar"
        Me.btnGuardar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'GroupProducto1
        '
        Me.GroupProducto1.Controls.Add(Me.Label9)
        Me.GroupProducto1.Controls.Add(Me.Label10)
        Me.GroupProducto1.Controls.Add(Me.txt_cantidad_retrabajo)
        Me.GroupProducto1.Controls.Add(Me.dtpFecha_Re_Trabajo)
        Me.GroupProducto1.Controls.Add(Me.Label6)
        Me.GroupProducto1.Controls.Add(Me.GroupBox5)
        Me.GroupProducto1.Location = New System.Drawing.Point(15, 197)
        Me.GroupProducto1.Name = "GroupProducto1"
        Me.GroupProducto1.Size = New System.Drawing.Size(675, 147)
        Me.GroupProducto1.TabIndex = 84
        Me.GroupProducto1.TabStop = False
        Me.GroupProducto1.Text = "Producto "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(63, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Cantidad"
        '
        'txt_cantidad_retrabajo
        '
        Me.txt_cantidad_retrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_retrabajo.Location = New System.Drawing.Point(80, 71)
        Me.txt_cantidad_retrabajo.Multiline = True
        Me.txt_cantidad_retrabajo.Name = "txt_cantidad_retrabajo"
        Me.txt_cantidad_retrabajo.Size = New System.Drawing.Size(111, 45)
        Me.txt_cantidad_retrabajo.TabIndex = 6
        Me.txt_cantidad_retrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_Re_Trabajo
        '
        Me.dtpFecha_Re_Trabajo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Re_Trabajo.Location = New System.Drawing.Point(81, 38)
        Me.dtpFecha_Re_Trabajo.Name = "dtpFecha_Re_Trabajo"
        Me.dtpFecha_Re_Trabajo.Size = New System.Drawing.Size(110, 20)
        Me.dtpFecha_Re_Trabajo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Fecha"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboFormato3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.cboFormato2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Papel3_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Papel2_Soporte1)
        Me.GroupBox5.Controls.Add(Me.cboFormato1_Soporte1)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txt_Cantidad1_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje1_Soporte1)
        Me.GroupBox5.Controls.Add(Me.txt_Papel1_Soporte1)
        Me.GroupBox5.Location = New System.Drawing.Point(230, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(433, 123)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Soportes"
        '
        'cboFormato3_Soporte1
        '
        Me.cboFormato3_Soporte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato3_Soporte1.FormattingEnabled = True
        Me.cboFormato3_Soporte1.Items.AddRange(New Object() {"Mts.", "Mts2", "Unidad"})
        Me.cboFormato3_Soporte1.Location = New System.Drawing.Point(338, 92)
        Me.cboFormato3_Soporte1.Name = "cboFormato3_Soporte1"
        Me.cboFormato3_Soporte1.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato3_Soporte1.TabIndex = 18
        '
        'cboFormato2_Soporte1
        '
        Me.cboFormato2_Soporte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato2_Soporte1.FormattingEnabled = True
        Me.cboFormato2_Soporte1.Items.AddRange(New Object() {"Mts.", "Mts2", "Unidad"})
        Me.cboFormato2_Soporte1.Location = New System.Drawing.Point(338, 67)
        Me.cboFormato2_Soporte1.Name = "cboFormato2_Soporte1"
        Me.cboFormato2_Soporte1.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato2_Soporte1.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 95)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "1"
        '
        'txt_Cantidad3_Soporte1
        '
        Me.txt_Cantidad3_Soporte1.Location = New System.Drawing.Point(263, 92)
        Me.txt_Cantidad3_Soporte1.Name = "txt_Cantidad3_Soporte1"
        Me.txt_Cantidad3_Soporte1.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad3_Soporte1.TabIndex = 17
        '
        'txt_Gramaje3_Soporte1
        '
        Me.txt_Gramaje3_Soporte1.Location = New System.Drawing.Point(193, 92)
        Me.txt_Gramaje3_Soporte1.Name = "txt_Gramaje3_Soporte1"
        Me.txt_Gramaje3_Soporte1.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje3_Soporte1.TabIndex = 16
        '
        'txt_Papel3_Soporte1
        '
        Me.txt_Papel3_Soporte1.Location = New System.Drawing.Point(24, 93)
        Me.txt_Papel3_Soporte1.MaxLength = 50
        Me.txt_Papel3_Soporte1.Name = "txt_Papel3_Soporte1"
        Me.txt_Papel3_Soporte1.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel3_Soporte1.TabIndex = 15
        '
        'txt_Cantidad2_Soporte1
        '
        Me.txt_Cantidad2_Soporte1.Location = New System.Drawing.Point(263, 66)
        Me.txt_Cantidad2_Soporte1.Name = "txt_Cantidad2_Soporte1"
        Me.txt_Cantidad2_Soporte1.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad2_Soporte1.TabIndex = 13
        '
        'txt_Gramaje2_Soporte1
        '
        Me.txt_Gramaje2_Soporte1.Location = New System.Drawing.Point(193, 66)
        Me.txt_Gramaje2_Soporte1.Name = "txt_Gramaje2_Soporte1"
        Me.txt_Gramaje2_Soporte1.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje2_Soporte1.TabIndex = 12
        '
        'txt_Papel2_Soporte1
        '
        Me.txt_Papel2_Soporte1.Location = New System.Drawing.Point(24, 67)
        Me.txt_Papel2_Soporte1.MaxLength = 50
        Me.txt_Papel2_Soporte1.Name = "txt_Papel2_Soporte1"
        Me.txt_Papel2_Soporte1.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel2_Soporte1.TabIndex = 11
        '
        'cboFormato1_Soporte1
        '
        Me.cboFormato1_Soporte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato1_Soporte1.FormattingEnabled = True
        Me.cboFormato1_Soporte1.Items.AddRange(New Object() {"Mts.", "Mts2", "Unidad"})
        Me.cboFormato1_Soporte1.Location = New System.Drawing.Point(338, 41)
        Me.cboFormato1_Soporte1.Name = "cboFormato1_Soporte1"
        Me.cboFormato1_Soporte1.Size = New System.Drawing.Size(89, 21)
        Me.cboFormato1_Soporte1.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(355, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Formato"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(270, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Cantidad"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(197, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Gramaje"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(86, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Papel"
        '
        'txt_Cantidad1_Soporte1
        '
        Me.txt_Cantidad1_Soporte1.Location = New System.Drawing.Point(263, 41)
        Me.txt_Cantidad1_Soporte1.Name = "txt_Cantidad1_Soporte1"
        Me.txt_Cantidad1_Soporte1.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad1_Soporte1.TabIndex = 9
        '
        'txt_Gramaje1_Soporte1
        '
        Me.txt_Gramaje1_Soporte1.Location = New System.Drawing.Point(193, 41)
        Me.txt_Gramaje1_Soporte1.Name = "txt_Gramaje1_Soporte1"
        Me.txt_Gramaje1_Soporte1.Size = New System.Drawing.Size(64, 20)
        Me.txt_Gramaje1_Soporte1.TabIndex = 8
        '
        'txt_Papel1_Soporte1
        '
        Me.txt_Papel1_Soporte1.Location = New System.Drawing.Point(24, 42)
        Me.txt_Papel1_Soporte1.MaxLength = 50
        Me.txt_Papel1_Soporte1.Name = "txt_Papel1_Soporte1"
        Me.txt_Papel1_Soporte1.Size = New System.Drawing.Size(163, 20)
        Me.txt_Papel1_Soporte1.TabIndex = 7
        '
        'txt_id_detalle_orden_trabajo1
        '
        Me.txt_id_detalle_orden_trabajo1.Location = New System.Drawing.Point(269, 353)
        Me.txt_id_detalle_orden_trabajo1.Name = "txt_id_detalle_orden_trabajo1"
        Me.txt_id_detalle_orden_trabajo1.Size = New System.Drawing.Size(17, 20)
        Me.txt_id_detalle_orden_trabajo1.TabIndex = 57
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(140, 356)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(129, 13)
        Me.Label45.TabIndex = 56
        Me.Label45.Text = "id_detalle_orden_trabajo1"
        '
        'cboPiezas1_Detalle1
        '
        Me.cboPiezas1_Detalle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPiezas1_Detalle1.FormattingEnabled = True
        Me.cboPiezas1_Detalle1.Location = New System.Drawing.Point(108, 35)
        Me.cboPiezas1_Detalle1.Name = "cboPiezas1_Detalle1"
        Me.cboPiezas1_Detalle1.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas1_Detalle1.TabIndex = 56
        '
        'cboTipoImpresion1_Detalle1
        '
        Me.cboTipoImpresion1_Detalle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboTipoImpresion1_Detalle1.FormattingEnabled = True
        Me.cboTipoImpresion1_Detalle1.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipoImpresion1_Detalle1.Location = New System.Drawing.Point(378, 35)
        Me.cboTipoImpresion1_Detalle1.Name = "cboTipoImpresion1_Detalle1"
        Me.cboTipoImpresion1_Detalle1.Size = New System.Drawing.Size(63, 21)
        Me.cboTipoImpresion1_Detalle1.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tipo Impresión"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tamaño"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cantidad"
        '
        'txtTamaño1_Detalle1
        '
        Me.txtTamaño1_Detalle1.Location = New System.Drawing.Point(278, 35)
        Me.txtTamaño1_Detalle1.MaxLength = 50
        Me.txtTamaño1_Detalle1.Name = "txtTamaño1_Detalle1"
        Me.txtTamaño1_Detalle1.Size = New System.Drawing.Size(92, 20)
        Me.txtTamaño1_Detalle1.TabIndex = 34
        '
        'txt_cantidad_original
        '
        Me.txt_cantidad_original.Location = New System.Drawing.Point(43, 36)
        Me.txt_cantidad_original.Name = "txt_cantidad_original"
        Me.txt_cantidad_original.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad_original.TabIndex = 33
        '
        'btnCancelar_ReTrabajo
        '
        Me.btnCancelar_ReTrabajo.Location = New System.Drawing.Point(603, 350)
        Me.btnCancelar_ReTrabajo.Name = "btnCancelar_ReTrabajo"
        Me.btnCancelar_ReTrabajo.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar_ReTrabajo.TabIndex = 20
        Me.btnCancelar_ReTrabajo.Text = "Cancelar"
        Me.btnCancelar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.cboPiezas1_Detalle1)
        Me.GroupBox1.Controls.Add(Me.cboTipoImpresion1_Detalle1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTamaño1_Detalle1)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad_original)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 69)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos originales"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(342, 20)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(11, 13)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "*"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(194, 22)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(11, 13)
        Me.Label49.TabIndex = 58
        Me.Label49.Text = "*"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(93, 20)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(11, 13)
        Me.Label48.TabIndex = 57
        Me.Label48.Text = "*"
        '
        'dtp_Fecha_Original
        '
        Me.dtp_Fecha_Original.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Original.Location = New System.Drawing.Point(422, 15)
        Me.dtp_Fecha_Original.Name = "dtp_Fecha_Original"
        Me.dtp_Fecha_Original.Size = New System.Drawing.Size(109, 20)
        Me.dtp_Fecha_Original.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(379, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Fecha"
        '
        'btnImprimirFormulario
        '
        Me.btnImprimirFormulario.Location = New System.Drawing.Point(397, 350)
        Me.btnImprimirFormulario.Name = "btnImprimirFormulario"
        Me.btnImprimirFormulario.Size = New System.Drawing.Size(119, 23)
        Me.btnImprimirFormulario.TabIndex = 21
        Me.btnImprimirFormulario.Text = "Imprimir Formulario"
        Me.btnImprimirFormulario.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(68, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "*"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frm_retrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 384)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnImprimirFormulario)
        Me.Controls.Add(Me.dtp_Fecha_Original)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_id_detalle_orden_trabajo1)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.btnGuardar_ReTrabajo)
        Me.Controls.Add(Me.GroupProducto1)
        Me.Controls.Add(Me.btnCancelar_ReTrabajo)
        Me.Controls.Add(Me.btnBuscar_Numero_Orden1)
        Me.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_id_orden_trabajo)
        Me.Controls.Add(Me.txt_id_re_trabajo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_procedimiento)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_origen)
        Me.Controls.Add(Me.Label18)
        Me.Name = "frm_retrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden  de Re-Trabajo"
        Me.GroupProducto1.ResumeLayout(False)
        Me.GroupProducto1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_id_re_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_procedimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_origen As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Numero_Orden1 As System.Windows.Forms.Button
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar_ReTrabajo As System.Windows.Forms.Button
    Friend WithEvents GroupProducto1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_detalle_orden_trabajo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas1_Detalle1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato3_Soporte1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato2_Soporte1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad3_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje3_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel3_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad2_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje2_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel2_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato1_Soporte1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad1_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje1_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel1_Soporte1 As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoImpresion1_Detalle1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño1_Detalle1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_original As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar_ReTrabajo As System.Windows.Forms.Button
    Friend WithEvents dtpFecha_Re_Trabajo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_retrabajo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Fecha_Original As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnImprimirFormulario As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
