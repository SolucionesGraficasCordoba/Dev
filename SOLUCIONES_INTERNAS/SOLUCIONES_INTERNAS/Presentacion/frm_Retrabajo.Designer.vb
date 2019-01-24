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
        Me.dtp_Nueva_Fecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cantidad_retrabajo = New System.Windows.Forms.TextBox()
        Me.dtpFecha_Re_Trabajo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnCancelar_ReTrabajo = New System.Windows.Forms.Button()
        Me.dtp_Fecha_Ingreso_Original = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnImprimirFormulario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.dtpFecha_Entrega_Original = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupDatosOriginales = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPiezas1_Detalle1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTamaño1_Detalle1 = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_original = New System.Windows.Forms.TextBox()
        Me.GroupProducto1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_detalle = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboFormato_3_Pliego_Entero = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_Cantidad_1_Pliego_Entero = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad_2_Pliego_Entero = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad_3_Pliego_Entero = New System.Windows.Forms.TextBox()
        Me.cboFormato_1_Pliego_Entero = New System.Windows.Forms.ComboBox()
        Me.cboFormato_2_Pliego_Entero = New System.Windows.Forms.ComboBox()
        Me.txt_Gramaje_3_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Papel_3_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje_2_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Papel_2_Soporte = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Gramaje_1_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Papel_1_Soporte = New System.Windows.Forms.TextBox()
        Me.groupOffset = New System.Windows.Forms.GroupBox()
        Me.cboMarca_Offset = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cboModo_Impresion_Offset = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cboImpresora_Offset = New System.Windows.Forms.ComboBox()
        Me.cboTipo_Impresion_Offset = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupDigital = New System.Windows.Forms.GroupBox()
        Me.cboTipo_Impresion_Digital = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtDato_Variable = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupReTrabajo = New System.Windows.Forms.GroupBox()
        Me.GroupTipoOrden = New System.Windows.Forms.GroupBox()
        Me.chkOffset = New System.Windows.Forms.CheckBox()
        Me.chkDigital = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_chapa_soporte_3 = New System.Windows.Forms.TextBox()
        Me.txt_chapa_soporte_2 = New System.Windows.Forms.TextBox()
        Me.txt_chapa_soporte_1 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboFormato_3_Pliego_Maquina_Offset = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_1_Pliego_Maquina_Offset = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cboFormato_2_Pliego_Maquina_Offset = New System.Windows.Forms.ComboBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtCantidad_3_Pliego_Maquina_Offset = New System.Windows.Forms.TextBox()
        Me.cboFormato_1_Pliego_Maquina_Offset = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_2_Pliego_Maquina_Offset = New System.Windows.Forms.TextBox()
        Me.cboFormato_3_Pliego_Maquina_Digital = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_1_Pliego_Maquina_Digital = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboFormato_2_Pliego_Maquina_Digital = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCantidad_3_Pliego_Maquina_Digital = New System.Windows.Forms.TextBox()
        Me.cboFormato_1_Pliego_Maquina_Digital = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_2_Pliego_Maquina_Digital = New System.Windows.Forms.TextBox()
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Buscar_Nro_Orden = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupDatosOriginales.SuspendLayout()
        Me.GroupProducto1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.groupOffset.SuspendLayout()
        Me.GroupDigital.SuspendLayout()
        Me.GroupReTrabajo.SuspendLayout()
        Me.GroupTipoOrden.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupListado.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id_re_trabajo
        '
        Me.txt_id_re_trabajo.Location = New System.Drawing.Point(304, 14)
        Me.txt_id_re_trabajo.Name = "txt_id_re_trabajo"
        Me.txt_id_re_trabajo.Size = New System.Drawing.Size(10, 20)
        Me.txt_id_re_trabajo.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "id_re_trabajo"
        '
        'txt_procedimiento
        '
        Me.txt_procedimiento.Location = New System.Drawing.Point(228, 87)
        Me.txt_procedimiento.MaxLength = 100
        Me.txt_procedimiento.Multiline = True
        Me.txt_procedimiento.Name = "txt_procedimiento"
        Me.txt_procedimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_procedimiento.Size = New System.Drawing.Size(353, 20)
        Me.txt_procedimiento.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(140, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Procedimiento"
        '
        'txt_origen
        '
        Me.txt_origen.Location = New System.Drawing.Point(228, 58)
        Me.txt_origen.MaxLength = 100
        Me.txt_origen.Multiline = True
        Me.txt_origen.Name = "txt_origen"
        Me.txt_origen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_origen.Size = New System.Drawing.Size(353, 20)
        Me.txt_origen.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(135, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Causa / Origen"
        '
        'btnBuscar_Numero_Orden1
        '
        Me.btnBuscar_Numero_Orden1.Location = New System.Drawing.Point(228, 44)
        Me.btnBuscar_Numero_Orden1.Name = "btnBuscar_Numero_Orden1"
        Me.btnBuscar_Numero_Orden1.Size = New System.Drawing.Size(63, 23)
        Me.btnBuscar_Numero_Orden1.TabIndex = 1
        Me.btnBuscar_Numero_Orden1.Text = "..."
        Me.btnBuscar_Numero_Orden1.UseVisualStyleBackColor = True
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(74, 23)
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(148, 44)
        Me.txtNumero_Orden_Trabajo.TabIndex = 78
        Me.txtNumero_Orden_Trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 26)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = " Número " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Orden"
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(297, 46)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(16, 20)
        Me.txt_id_orden_trabajo.TabIndex = 77
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(11, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "* (campos requeridos)"
        '
        'btnGuardar_ReTrabajo
        '
        Me.btnGuardar_ReTrabajo.Location = New System.Drawing.Point(1021, 654)
        Me.btnGuardar_ReTrabajo.Name = "btnGuardar_ReTrabajo"
        Me.btnGuardar_ReTrabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_ReTrabajo.TabIndex = 19
        Me.btnGuardar_ReTrabajo.Text = "Guardar"
        Me.btnGuardar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'dtp_Nueva_Fecha_Entrega
        '
        Me.dtp_Nueva_Fecha_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Nueva_Fecha_Entrega.Location = New System.Drawing.Point(471, 19)
        Me.dtp_Nueva_Fecha_Entrega.Name = "dtp_Nueva_Fecha_Entrega"
        Me.dtp_Nueva_Fecha_Entrega.Size = New System.Drawing.Size(110, 20)
        Me.dtp_Nueva_Fecha_Entrega.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(349, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 13)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Nueva Fec. de Entrega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(97, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Cantidad"
        '
        'txt_cantidad_retrabajo
        '
        Me.txt_cantidad_retrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_retrabajo.Location = New System.Drawing.Point(26, 64)
        Me.txt_cantidad_retrabajo.Multiline = True
        Me.txt_cantidad_retrabajo.Name = "txt_cantidad_retrabajo"
        Me.txt_cantidad_retrabajo.Size = New System.Drawing.Size(99, 43)
        Me.txt_cantidad_retrabajo.TabIndex = 6
        Me.txt_cantidad_retrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_Re_Trabajo
        '
        Me.dtpFecha_Re_Trabajo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Re_Trabajo.Location = New System.Drawing.Point(228, 19)
        Me.dtpFecha_Re_Trabajo.Name = "dtpFecha_Re_Trabajo"
        Me.dtpFecha_Re_Trabajo.Size = New System.Drawing.Size(110, 20)
        Me.dtpFecha_Re_Trabajo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Fecha de Retrabajo"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(66, 18)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(129, 13)
        Me.Label45.TabIndex = 56
        Me.Label45.Text = "id_detalle_orden_trabajo1"
        '
        'btnCancelar_ReTrabajo
        '
        Me.btnCancelar_ReTrabajo.Location = New System.Drawing.Point(1102, 654)
        Me.btnCancelar_ReTrabajo.Name = "btnCancelar_ReTrabajo"
        Me.btnCancelar_ReTrabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_ReTrabajo.TabIndex = 20
        Me.btnCancelar_ReTrabajo.Text = "Cancelar"
        Me.btnCancelar_ReTrabajo.UseVisualStyleBackColor = True
        '
        'dtp_Fecha_Ingreso_Original
        '
        Me.dtp_Fecha_Ingreso_Original.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Ingreso_Original.Location = New System.Drawing.Point(422, 23)
        Me.dtp_Fecha_Ingreso_Original.Name = "dtp_Fecha_Ingreso_Original"
        Me.dtp_Fecha_Ingreso_Original.Size = New System.Drawing.Size(109, 20)
        Me.dtp_Fecha_Ingreso_Original.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(326, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Fecha de Ingreso"
        '
        'btnImprimirFormulario
        '
        Me.btnImprimirFormulario.Location = New System.Drawing.Point(815, 654)
        Me.btnImprimirFormulario.Name = "btnImprimirFormulario"
        Me.btnImprimirFormulario.Size = New System.Drawing.Size(119, 33)
        Me.btnImprimirFormulario.TabIndex = 21
        Me.btnImprimirFormulario.Text = "Imprimir Formulario"
        Me.btnImprimirFormulario.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(59, 39)
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
        'dtpFecha_Entrega_Original
        '
        Me.dtpFecha_Entrega_Original.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Entrega_Original.Location = New System.Drawing.Point(422, 49)
        Me.dtpFecha_Entrega_Original.Name = "dtpFecha_Entrega_Original"
        Me.dtpFecha_Entrega_Original.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecha_Entrega_Original.TabIndex = 91
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(326, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Fecha de Entrega"
        '
        'GroupDatosOriginales
        '
        Me.GroupDatosOriginales.Controls.Add(Me.Label7)
        Me.GroupDatosOriginales.Controls.Add(Me.dtpFecha_Entrega_Original)
        Me.GroupDatosOriginales.Controls.Add(Me.cboPiezas1_Detalle1)
        Me.GroupDatosOriginales.Controls.Add(Me.Label12)
        Me.GroupDatosOriginales.Controls.Add(Me.Label4)
        Me.GroupDatosOriginales.Controls.Add(Me.Label3)
        Me.GroupDatosOriginales.Controls.Add(Me.dtp_Fecha_Ingreso_Original)
        Me.GroupDatosOriginales.Controls.Add(Me.Label2)
        Me.GroupDatosOriginales.Controls.Add(Me.Label11)
        Me.GroupDatosOriginales.Controls.Add(Me.txtTamaño1_Detalle1)
        Me.GroupDatosOriginales.Controls.Add(Me.txt_cantidad_original)
        Me.GroupDatosOriginales.Controls.Add(Me.btnBuscar_Numero_Orden1)
        Me.GroupDatosOriginales.Controls.Add(Me.txt_id_orden_trabajo)
        Me.GroupDatosOriginales.Controls.Add(Me.Label5)
        Me.GroupDatosOriginales.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.GroupDatosOriginales.Location = New System.Drawing.Point(15, 9)
        Me.GroupDatosOriginales.Name = "GroupDatosOriginales"
        Me.GroupDatosOriginales.Size = New System.Drawing.Size(552, 128)
        Me.GroupDatosOriginales.TabIndex = 93
        Me.GroupDatosOriginales.TabStop = False
        Me.GroupDatosOriginales.Text = "Datos originales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Tamaño (°°° x °°° Mm)"
        '
        'cboPiezas1_Detalle1
        '
        Me.cboPiezas1_Detalle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPiezas1_Detalle1.FormattingEnabled = True
        Me.cboPiezas1_Detalle1.Location = New System.Drawing.Point(162, 101)
        Me.cboPiezas1_Detalle1.Name = "cboPiezas1_Detalle1"
        Me.cboPiezas1_Detalle1.Size = New System.Drawing.Size(162, 21)
        Me.cboPiezas1_Detalle1.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cantidad"
        '
        'txtTamaño1_Detalle1
        '
        Me.txtTamaño1_Detalle1.Location = New System.Drawing.Point(330, 102)
        Me.txtTamaño1_Detalle1.MaxLength = 50
        Me.txtTamaño1_Detalle1.Name = "txtTamaño1_Detalle1"
        Me.txtTamaño1_Detalle1.Size = New System.Drawing.Size(153, 20)
        Me.txtTamaño1_Detalle1.TabIndex = 34
        '
        'txt_cantidad_original
        '
        Me.txt_cantidad_original.Location = New System.Drawing.Point(97, 101)
        Me.txt_cantidad_original.Name = "txt_cantidad_original"
        Me.txt_cantidad_original.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad_original.TabIndex = 33
        '
        'GroupProducto1
        '
        Me.GroupProducto1.Controls.Add(Me.GroupDigital)
        Me.GroupProducto1.Controls.Add(Me.groupOffset)
        Me.GroupProducto1.Controls.Add(Me.Label17)
        Me.GroupProducto1.Controls.Add(Me.GroupBox8)
        Me.GroupProducto1.Controls.Add(Me.txt_Gramaje_3_Soporte)
        Me.GroupProducto1.Controls.Add(Me.txt_Papel_3_Soporte)
        Me.GroupProducto1.Controls.Add(Me.txt_Gramaje_2_Soporte)
        Me.GroupProducto1.Controls.Add(Me.txt_Papel_2_Soporte)
        Me.GroupProducto1.Controls.Add(Me.Label24)
        Me.GroupProducto1.Controls.Add(Me.Label25)
        Me.GroupProducto1.Controls.Add(Me.txt_Gramaje_1_Soporte)
        Me.GroupProducto1.Controls.Add(Me.txt_Papel_1_Soporte)
        Me.GroupProducto1.Location = New System.Drawing.Point(15, 194)
        Me.GroupProducto1.Name = "GroupProducto1"
        Me.GroupProducto1.Size = New System.Drawing.Size(1161, 224)
        Me.GroupProducto1.TabIndex = 84
        Me.GroupProducto1.TabStop = False
        Me.GroupProducto1.Text = "Producto "
        '
        'txt_id_detalle
        '
        Me.txt_id_detalle.Location = New System.Drawing.Point(195, 15)
        Me.txt_id_detalle.Name = "txt_id_detalle"
        Me.txt_id_detalle.Size = New System.Drawing.Size(30, 20)
        Me.txt_id_detalle.TabIndex = 94
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboFormato_3_Pliego_Entero)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.txt_Cantidad_1_Pliego_Entero)
        Me.GroupBox8.Controls.Add(Me.txt_Cantidad_2_Pliego_Entero)
        Me.GroupBox8.Controls.Add(Me.txt_Cantidad_3_Pliego_Entero)
        Me.GroupBox8.Controls.Add(Me.cboFormato_1_Pliego_Entero)
        Me.GroupBox8.Controls.Add(Me.cboFormato_2_Pliego_Entero)
        Me.GroupBox8.Location = New System.Drawing.Point(319, 11)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(230, 202)
        Me.GroupBox8.TabIndex = 142
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Pliego Entero Digital / Offset"
        '
        'cboFormato_3_Pliego_Entero
        '
        Me.cboFormato_3_Pliego_Entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_3_Pliego_Entero.FormattingEnabled = True
        Me.cboFormato_3_Pliego_Entero.Items.AddRange(New Object() {"", "630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato_3_Pliego_Entero.Location = New System.Drawing.Point(90, 93)
        Me.cboFormato_3_Pliego_Entero.Name = "cboFormato_3_Pliego_Entero"
        Me.cboFormato_3_Pliego_Entero.Size = New System.Drawing.Size(134, 21)
        Me.cboFormato_3_Pliego_Entero.TabIndex = 28
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(27, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "Cantidad"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(122, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Formato (Mm)"
        '
        'txt_Cantidad_1_Pliego_Entero
        '
        Me.txt_Cantidad_1_Pliego_Entero.Location = New System.Drawing.Point(15, 41)
        Me.txt_Cantidad_1_Pliego_Entero.MaxLength = 7
        Me.txt_Cantidad_1_Pliego_Entero.Name = "txt_Cantidad_1_Pliego_Entero"
        Me.txt_Cantidad_1_Pliego_Entero.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad_1_Pliego_Entero.TabIndex = 13
        '
        'txt_Cantidad_2_Pliego_Entero
        '
        Me.txt_Cantidad_2_Pliego_Entero.Location = New System.Drawing.Point(15, 66)
        Me.txt_Cantidad_2_Pliego_Entero.MaxLength = 7
        Me.txt_Cantidad_2_Pliego_Entero.Name = "txt_Cantidad_2_Pliego_Entero"
        Me.txt_Cantidad_2_Pliego_Entero.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad_2_Pliego_Entero.TabIndex = 20
        '
        'txt_Cantidad_3_Pliego_Entero
        '
        Me.txt_Cantidad_3_Pliego_Entero.Location = New System.Drawing.Point(15, 92)
        Me.txt_Cantidad_3_Pliego_Entero.MaxLength = 7
        Me.txt_Cantidad_3_Pliego_Entero.Name = "txt_Cantidad_3_Pliego_Entero"
        Me.txt_Cantidad_3_Pliego_Entero.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad_3_Pliego_Entero.TabIndex = 27
        '
        'cboFormato_1_Pliego_Entero
        '
        Me.cboFormato_1_Pliego_Entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_1_Pliego_Entero.FormattingEnabled = True
        Me.cboFormato_1_Pliego_Entero.Items.AddRange(New Object() {"", "630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato_1_Pliego_Entero.Location = New System.Drawing.Point(90, 42)
        Me.cboFormato_1_Pliego_Entero.Name = "cboFormato_1_Pliego_Entero"
        Me.cboFormato_1_Pliego_Entero.Size = New System.Drawing.Size(134, 21)
        Me.cboFormato_1_Pliego_Entero.TabIndex = 14
        '
        'cboFormato_2_Pliego_Entero
        '
        Me.cboFormato_2_Pliego_Entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_2_Pliego_Entero.FormattingEnabled = True
        Me.cboFormato_2_Pliego_Entero.Items.AddRange(New Object() {"", "630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato_2_Pliego_Entero.Location = New System.Drawing.Point(90, 68)
        Me.cboFormato_2_Pliego_Entero.Name = "cboFormato_2_Pliego_Entero"
        Me.cboFormato_2_Pliego_Entero.Size = New System.Drawing.Size(134, 21)
        Me.cboFormato_2_Pliego_Entero.TabIndex = 21
        '
        'txt_Gramaje_3_Soporte
        '
        Me.txt_Gramaje_3_Soporte.Location = New System.Drawing.Point(222, 103)
        Me.txt_Gramaje_3_Soporte.MaxLength = 10
        Me.txt_Gramaje_3_Soporte.Name = "txt_Gramaje_3_Soporte"
        Me.txt_Gramaje_3_Soporte.Size = New System.Drawing.Size(85, 20)
        Me.txt_Gramaje_3_Soporte.TabIndex = 139
        '
        'txt_Papel_3_Soporte
        '
        Me.txt_Papel_3_Soporte.Location = New System.Drawing.Point(14, 103)
        Me.txt_Papel_3_Soporte.MaxLength = 50
        Me.txt_Papel_3_Soporte.Name = "txt_Papel_3_Soporte"
        Me.txt_Papel_3_Soporte.Size = New System.Drawing.Size(202, 20)
        Me.txt_Papel_3_Soporte.TabIndex = 138
        '
        'txt_Gramaje_2_Soporte
        '
        Me.txt_Gramaje_2_Soporte.Location = New System.Drawing.Point(222, 77)
        Me.txt_Gramaje_2_Soporte.MaxLength = 10
        Me.txt_Gramaje_2_Soporte.Name = "txt_Gramaje_2_Soporte"
        Me.txt_Gramaje_2_Soporte.Size = New System.Drawing.Size(85, 20)
        Me.txt_Gramaje_2_Soporte.TabIndex = 137
        '
        'txt_Papel_2_Soporte
        '
        Me.txt_Papel_2_Soporte.Location = New System.Drawing.Point(14, 77)
        Me.txt_Papel_2_Soporte.MaxLength = 50
        Me.txt_Papel_2_Soporte.Name = "txt_Papel_2_Soporte"
        Me.txt_Papel_2_Soporte.Size = New System.Drawing.Size(202, 20)
        Me.txt_Papel_2_Soporte.TabIndex = 136
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(223, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 13)
        Me.Label24.TabIndex = 140
        Me.Label24.Text = "Gramaje/Grosor"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(89, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 141
        Me.Label25.Text = "Papel/Sustrato"
        '
        'txt_Gramaje_1_Soporte
        '
        Me.txt_Gramaje_1_Soporte.Location = New System.Drawing.Point(222, 52)
        Me.txt_Gramaje_1_Soporte.MaxLength = 10
        Me.txt_Gramaje_1_Soporte.Name = "txt_Gramaje_1_Soporte"
        Me.txt_Gramaje_1_Soporte.Size = New System.Drawing.Size(85, 20)
        Me.txt_Gramaje_1_Soporte.TabIndex = 135
        '
        'txt_Papel_1_Soporte
        '
        Me.txt_Papel_1_Soporte.Location = New System.Drawing.Point(14, 52)
        Me.txt_Papel_1_Soporte.MaxLength = 50
        Me.txt_Papel_1_Soporte.Name = "txt_Papel_1_Soporte"
        Me.txt_Papel_1_Soporte.Size = New System.Drawing.Size(202, 20)
        Me.txt_Papel_1_Soporte.TabIndex = 134
        '
        'groupOffset
        '
        Me.groupOffset.Controls.Add(Me.txt_chapa_soporte_3)
        Me.groupOffset.Controls.Add(Me.txt_chapa_soporte_2)
        Me.groupOffset.Controls.Add(Me.txt_chapa_soporte_1)
        Me.groupOffset.Controls.Add(Me.Label36)
        Me.groupOffset.Controls.Add(Me.cboFormato_3_Pliego_Maquina_Offset)
        Me.groupOffset.Controls.Add(Me.txtCantidad_1_Pliego_Maquina_Offset)
        Me.groupOffset.Controls.Add(Me.Label58)
        Me.groupOffset.Controls.Add(Me.cboFormato_2_Pliego_Maquina_Offset)
        Me.groupOffset.Controls.Add(Me.Label57)
        Me.groupOffset.Controls.Add(Me.txtCantidad_3_Pliego_Maquina_Offset)
        Me.groupOffset.Controls.Add(Me.cboFormato_1_Pliego_Maquina_Offset)
        Me.groupOffset.Controls.Add(Me.txtCantidad_2_Pliego_Maquina_Offset)
        Me.groupOffset.Controls.Add(Me.cboMarca_Offset)
        Me.groupOffset.Controls.Add(Me.Label61)
        Me.groupOffset.Controls.Add(Me.cboModo_Impresion_Offset)
        Me.groupOffset.Controls.Add(Me.Label14)
        Me.groupOffset.Controls.Add(Me.Label66)
        Me.groupOffset.Controls.Add(Me.cboImpresora_Offset)
        Me.groupOffset.Controls.Add(Me.cboTipo_Impresion_Offset)
        Me.groupOffset.Controls.Add(Me.Label35)
        Me.groupOffset.Location = New System.Drawing.Point(555, 11)
        Me.groupOffset.Name = "groupOffset"
        Me.groupOffset.Size = New System.Drawing.Size(335, 202)
        Me.groupOffset.TabIndex = 150
        Me.groupOffset.TabStop = False
        Me.groupOffset.Text = "Pliego Máquina Offset"
        '
        'cboMarca_Offset
        '
        Me.cboMarca_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca_Offset.FormattingEnabled = True
        Me.cboMarca_Offset.Items.AddRange(New Object() {"AGFA TU", "KODAK", "KTP - KONITA"})
        Me.cboMarca_Offset.Location = New System.Drawing.Point(207, 163)
        Me.cboMarca_Offset.Name = "cboMarca_Offset"
        Me.cboMarca_Offset.Size = New System.Drawing.Size(109, 21)
        Me.cboMarca_Offset.TabIndex = 144
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(149, 129)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(52, 26)
        Me.Label61.TabIndex = 145
        Me.Label61.Text = "   Modo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Impresión"
        '
        'cboModo_Impresion_Offset
        '
        Me.cboModo_Impresion_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModo_Impresion_Offset.FormattingEnabled = True
        Me.cboModo_Impresion_Offset.Items.AddRange(New Object() {"TIRE Y RETIRE", "PINZA Y CONTRAPINZA", "FRENTE Y DORSO", "SOLO FRENTE"})
        Me.cboModo_Impresion_Offset.Location = New System.Drawing.Point(207, 129)
        Me.cboModo_Impresion_Offset.Name = "cboModo_Impresion_Offset"
        Me.cboModo_Impresion_Offset.Size = New System.Drawing.Size(109, 21)
        Me.cboModo_Impresion_Offset.TabIndex = 143
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(164, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 148
        Me.Label14.Text = "Marca"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(9, 166)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(53, 13)
        Me.Label66.TabIndex = 146
        Me.Label66.Text = "Impresora"
        '
        'cboImpresora_Offset
        '
        Me.cboImpresora_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora_Offset.FormattingEnabled = True
        Me.cboImpresora_Offset.Items.AddRange(New Object() {"CD/4", "CD/6", "SM", "SOR"})
        Me.cboImpresora_Offset.Location = New System.Drawing.Point(71, 163)
        Me.cboImpresora_Offset.Name = "cboImpresora_Offset"
        Me.cboImpresora_Offset.Size = New System.Drawing.Size(75, 21)
        Me.cboImpresora_Offset.TabIndex = 142
        '
        'cboTipo_Impresion_Offset
        '
        Me.cboTipo_Impresion_Offset.FormattingEnabled = True
        Me.cboTipo_Impresion_Offset.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipo_Impresion_Offset.Location = New System.Drawing.Point(71, 132)
        Me.cboTipo_Impresion_Offset.Name = "cboTipo_Impresion_Offset"
        Me.cboTipo_Impresion_Offset.Size = New System.Drawing.Size(75, 21)
        Me.cboTipo_Impresion_Offset.TabIndex = 141
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(15, 129)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(52, 26)
        Me.Label35.TabIndex = 147
        Me.Label35.Text = "    Tipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Impresión"
        '
        'GroupDigital
        '
        Me.GroupDigital.Controls.Add(Me.cboFormato_3_Pliego_Maquina_Digital)
        Me.GroupDigital.Controls.Add(Me.txtCantidad_1_Pliego_Maquina_Digital)
        Me.GroupDigital.Controls.Add(Me.Label15)
        Me.GroupDigital.Controls.Add(Me.cboFormato_2_Pliego_Maquina_Digital)
        Me.GroupDigital.Controls.Add(Me.Label16)
        Me.GroupDigital.Controls.Add(Me.txtCantidad_3_Pliego_Maquina_Digital)
        Me.GroupDigital.Controls.Add(Me.cboFormato_1_Pliego_Maquina_Digital)
        Me.GroupDigital.Controls.Add(Me.txtCantidad_2_Pliego_Maquina_Digital)
        Me.GroupDigital.Controls.Add(Me.cboTipo_Impresion_Digital)
        Me.GroupDigital.Controls.Add(Me.Label34)
        Me.GroupDigital.Controls.Add(Me.txtDato_Variable)
        Me.GroupDigital.Controls.Add(Me.Label23)
        Me.GroupDigital.Location = New System.Drawing.Point(896, 11)
        Me.GroupDigital.Name = "GroupDigital"
        Me.GroupDigital.Size = New System.Drawing.Size(256, 202)
        Me.GroupDigital.TabIndex = 132
        Me.GroupDigital.TabStop = False
        Me.GroupDigital.Text = "Pliego Máquina Digital"
        '
        'cboTipo_Impresion_Digital
        '
        Me.cboTipo_Impresion_Digital.FormattingEnabled = True
        Me.cboTipo_Impresion_Digital.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipo_Impresion_Digital.Location = New System.Drawing.Point(153, 119)
        Me.cboTipo_Impresion_Digital.Name = "cboTipo_Impresion_Digital"
        Me.cboTipo_Impresion_Digital.Size = New System.Drawing.Size(85, 21)
        Me.cboTipo_Impresion_Digital.TabIndex = 36
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(71, 122)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 13)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "Tipo Impresión"
        '
        'txtDato_Variable
        '
        Me.txtDato_Variable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato_Variable.Location = New System.Drawing.Point(6, 155)
        Me.txtDato_Variable.MaxLength = 350
        Me.txtDato_Variable.Multiline = True
        Me.txtDato_Variable.Name = "txtDato_Variable"
        Me.txtDato_Variable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDato_Variable.Size = New System.Drawing.Size(232, 37)
        Me.txtDato_Variable.TabIndex = 130
        Me.txtDato_Variable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 139)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 131
        Me.Label23.Text = "Dato Variable"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupReTrabajo
        '
        Me.GroupReTrabajo.Controls.Add(Me.dtp_Nueva_Fecha_Entrega)
        Me.GroupReTrabajo.Controls.Add(Me.txt_procedimiento)
        Me.GroupReTrabajo.Controls.Add(Me.Label19)
        Me.GroupReTrabajo.Controls.Add(Me.Label13)
        Me.GroupReTrabajo.Controls.Add(Me.Label18)
        Me.GroupReTrabajo.Controls.Add(Me.Label6)
        Me.GroupReTrabajo.Controls.Add(Me.txt_origen)
        Me.GroupReTrabajo.Controls.Add(Me.Label9)
        Me.GroupReTrabajo.Controls.Add(Me.dtpFecha_Re_Trabajo)
        Me.GroupReTrabajo.Controls.Add(Me.Label10)
        Me.GroupReTrabajo.Controls.Add(Me.txt_cantidad_retrabajo)
        Me.GroupReTrabajo.Location = New System.Drawing.Point(573, 9)
        Me.GroupReTrabajo.Name = "GroupReTrabajo"
        Me.GroupReTrabajo.Size = New System.Drawing.Size(603, 128)
        Me.GroupReTrabajo.TabIndex = 133
        Me.GroupReTrabajo.TabStop = False
        '
        'GroupTipoOrden
        '
        Me.GroupTipoOrden.Controls.Add(Me.txt_id_detalle)
        Me.GroupTipoOrden.Controls.Add(Me.chkOffset)
        Me.GroupTipoOrden.Controls.Add(Me.chkDigital)
        Me.GroupTipoOrden.Controls.Add(Me.Label45)
        Me.GroupTipoOrden.Controls.Add(Me.Label1)
        Me.GroupTipoOrden.Controls.Add(Me.txt_id_re_trabajo)
        Me.GroupTipoOrden.Location = New System.Drawing.Point(12, 143)
        Me.GroupTipoOrden.Name = "GroupTipoOrden"
        Me.GroupTipoOrden.Size = New System.Drawing.Size(1164, 45)
        Me.GroupTipoOrden.TabIndex = 134
        Me.GroupTipoOrden.TabStop = False
        Me.GroupTipoOrden.Text = "Tipo de Orden"
        '
        'chkOffset
        '
        Me.chkOffset.AutoSize = True
        Me.chkOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOffset.Location = New System.Drawing.Point(457, 9)
        Me.chkOffset.Name = "chkOffset"
        Me.chkOffset.Size = New System.Drawing.Size(76, 28)
        Me.chkOffset.TabIndex = 0
        Me.chkOffset.Text = "Offset"
        Me.chkOffset.UseVisualStyleBackColor = True
        '
        'chkDigital
        '
        Me.chkDigital.AutoSize = True
        Me.chkDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDigital.Location = New System.Drawing.Point(587, 9)
        Me.chkDigital.Name = "chkDigital"
        Me.chkDigital.Size = New System.Drawing.Size(79, 28)
        Me.chkDigital.TabIndex = 0
        Me.chkDigital.Text = "Digital"
        Me.chkDigital.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1144, 170)
        Me.DataGridView1.TabIndex = 135
        '
        'txt_chapa_soporte_3
        '
        Me.txt_chapa_soporte_3.Location = New System.Drawing.Point(240, 93)
        Me.txt_chapa_soporte_3.MaxLength = 2
        Me.txt_chapa_soporte_3.Name = "txt_chapa_soporte_3"
        Me.txt_chapa_soporte_3.Size = New System.Drawing.Size(75, 20)
        Me.txt_chapa_soporte_3.TabIndex = 158
        '
        'txt_chapa_soporte_2
        '
        Me.txt_chapa_soporte_2.Location = New System.Drawing.Point(241, 67)
        Me.txt_chapa_soporte_2.MaxLength = 2
        Me.txt_chapa_soporte_2.Name = "txt_chapa_soporte_2"
        Me.txt_chapa_soporte_2.Size = New System.Drawing.Size(75, 20)
        Me.txt_chapa_soporte_2.TabIndex = 155
        '
        'txt_chapa_soporte_1
        '
        Me.txt_chapa_soporte_1.Location = New System.Drawing.Point(241, 42)
        Me.txt_chapa_soporte_1.MaxLength = 2
        Me.txt_chapa_soporte_1.Name = "txt_chapa_soporte_1"
        Me.txt_chapa_soporte_1.Size = New System.Drawing.Size(75, 20)
        Me.txt_chapa_soporte_1.TabIndex = 152
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(256, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 161
        Me.Label36.Text = "Chapas"
        '
        'cboFormato_3_Pliego_Maquina_Offset
        '
        Me.cboFormato_3_Pliego_Maquina_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_3_Pliego_Maquina_Offset.FormattingEnabled = True
        Me.cboFormato_3_Pliego_Maquina_Offset.Items.AddRange(New Object() {"", "650 x 470", "650 x 315", "630 x 440", "610 x 430", "590 x 410", "550 x 370", "510 x 360", "500 x 350", "500 x 325", "470 x 325", "440 x 315", "820 x 590", "740 x 550", "720 x 510"})
        Me.cboFormato_3_Pliego_Maquina_Offset.Location = New System.Drawing.Point(97, 93)
        Me.cboFormato_3_Pliego_Maquina_Offset.Name = "cboFormato_3_Pliego_Maquina_Offset"
        Me.cboFormato_3_Pliego_Maquina_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_3_Pliego_Maquina_Offset.TabIndex = 157
        '
        'txtCantidad_1_Pliego_Maquina_Offset
        '
        Me.txtCantidad_1_Pliego_Maquina_Offset.Location = New System.Drawing.Point(22, 42)
        Me.txtCantidad_1_Pliego_Maquina_Offset.MaxLength = 7
        Me.txtCantidad_1_Pliego_Maquina_Offset.Name = "txtCantidad_1_Pliego_Maquina_Offset"
        Me.txtCantidad_1_Pliego_Maquina_Offset.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_1_Pliego_Maquina_Offset.TabIndex = 150
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(32, 25)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(49, 13)
        Me.Label58.TabIndex = 160
        Me.Label58.Text = "Cantidad"
        '
        'cboFormato_2_Pliego_Maquina_Offset
        '
        Me.cboFormato_2_Pliego_Maquina_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_2_Pliego_Maquina_Offset.FormattingEnabled = True
        Me.cboFormato_2_Pliego_Maquina_Offset.Items.AddRange(New Object() {"", "650 x 470", "650 x 315", "630 x 440", "610 x 430", "590 x 410", "550 x 370", "510 x 360", "500 x 350", "500 x 325", "470 x 325", "440 x 315", "820 x 590", "740 x 550", "720 x 510"})
        Me.cboFormato_2_Pliego_Maquina_Offset.Location = New System.Drawing.Point(97, 68)
        Me.cboFormato_2_Pliego_Maquina_Offset.Name = "cboFormato_2_Pliego_Maquina_Offset"
        Me.cboFormato_2_Pliego_Maquina_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_2_Pliego_Maquina_Offset.TabIndex = 154
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(130, 25)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(71, 13)
        Me.Label57.TabIndex = 159
        Me.Label57.Text = "Formato (Mm)"
        '
        'txtCantidad_3_Pliego_Maquina_Offset
        '
        Me.txtCantidad_3_Pliego_Maquina_Offset.Location = New System.Drawing.Point(22, 93)
        Me.txtCantidad_3_Pliego_Maquina_Offset.MaxLength = 7
        Me.txtCantidad_3_Pliego_Maquina_Offset.Name = "txtCantidad_3_Pliego_Maquina_Offset"
        Me.txtCantidad_3_Pliego_Maquina_Offset.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_3_Pliego_Maquina_Offset.TabIndex = 156
        '
        'cboFormato_1_Pliego_Maquina_Offset
        '
        Me.cboFormato_1_Pliego_Maquina_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_1_Pliego_Maquina_Offset.FormattingEnabled = True
        Me.cboFormato_1_Pliego_Maquina_Offset.Items.AddRange(New Object() {"", "650 x 470", "650 x 315", "630 x 440", "610 x 430", "590 x 410", "550 x 370", "510 x 360", "500 x 350", "500 x 325", "470 x 325", "440 x 315", "820 x 590", "740 x 550", "720 x 510"})
        Me.cboFormato_1_Pliego_Maquina_Offset.Location = New System.Drawing.Point(97, 42)
        Me.cboFormato_1_Pliego_Maquina_Offset.Name = "cboFormato_1_Pliego_Maquina_Offset"
        Me.cboFormato_1_Pliego_Maquina_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_1_Pliego_Maquina_Offset.TabIndex = 151
        '
        'txtCantidad_2_Pliego_Maquina_Offset
        '
        Me.txtCantidad_2_Pliego_Maquina_Offset.Location = New System.Drawing.Point(22, 67)
        Me.txtCantidad_2_Pliego_Maquina_Offset.MaxLength = 7
        Me.txtCantidad_2_Pliego_Maquina_Offset.Name = "txtCantidad_2_Pliego_Maquina_Offset"
        Me.txtCantidad_2_Pliego_Maquina_Offset.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_2_Pliego_Maquina_Offset.TabIndex = 153
        '
        'cboFormato_3_Pliego_Maquina_Digital
        '
        Me.cboFormato_3_Pliego_Maquina_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_3_Pliego_Maquina_Digital.FormattingEnabled = True
        Me.cboFormato_3_Pliego_Maquina_Digital.Items.AddRange(New Object() {"", "473 x 323", "480 x 323", "440 x 315", "400 x 295", "420 x 297", "356 x 215", "323 x 235", "340 x 220", "650 x 313", "630 x 220", "500 x 323", "700 x 330", "297 x 210", "360 x 255"})
        Me.cboFormato_3_Pliego_Maquina_Digital.Location = New System.Drawing.Point(100, 92)
        Me.cboFormato_3_Pliego_Maquina_Digital.Name = "cboFormato_3_Pliego_Maquina_Digital"
        Me.cboFormato_3_Pliego_Maquina_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_3_Pliego_Maquina_Digital.TabIndex = 143
        '
        'txtCantidad_1_Pliego_Maquina_Digital
        '
        Me.txtCantidad_1_Pliego_Maquina_Digital.Location = New System.Drawing.Point(25, 41)
        Me.txtCantidad_1_Pliego_Maquina_Digital.MaxLength = 7
        Me.txtCantidad_1_Pliego_Maquina_Digital.Name = "txtCantidad_1_Pliego_Maquina_Digital"
        Me.txtCantidad_1_Pliego_Maquina_Digital.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_1_Pliego_Maquina_Digital.TabIndex = 138
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Cantidad"
        '
        'cboFormato_2_Pliego_Maquina_Digital
        '
        Me.cboFormato_2_Pliego_Maquina_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_2_Pliego_Maquina_Digital.FormattingEnabled = True
        Me.cboFormato_2_Pliego_Maquina_Digital.Items.AddRange(New Object() {"", "473 x 323", "480 x 323", "440 x 315", "400 x 295", "420 x 297", "356 x 215", "323 x 235", "340 x 220", "650 x 313", "630 x 220", "500 x 323", "700 x 330", "297 x 210", "360 x 255"})
        Me.cboFormato_2_Pliego_Maquina_Digital.Location = New System.Drawing.Point(100, 67)
        Me.cboFormato_2_Pliego_Maquina_Digital.Name = "cboFormato_2_Pliego_Maquina_Digital"
        Me.cboFormato_2_Pliego_Maquina_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_2_Pliego_Maquina_Digital.TabIndex = 141
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(135, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Formato (Mm)"
        '
        'txtCantidad_3_Pliego_Maquina_Digital
        '
        Me.txtCantidad_3_Pliego_Maquina_Digital.Location = New System.Drawing.Point(25, 92)
        Me.txtCantidad_3_Pliego_Maquina_Digital.MaxLength = 7
        Me.txtCantidad_3_Pliego_Maquina_Digital.Name = "txtCantidad_3_Pliego_Maquina_Digital"
        Me.txtCantidad_3_Pliego_Maquina_Digital.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_3_Pliego_Maquina_Digital.TabIndex = 142
        '
        'cboFormato_1_Pliego_Maquina_Digital
        '
        Me.cboFormato_1_Pliego_Maquina_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_1_Pliego_Maquina_Digital.FormattingEnabled = True
        Me.cboFormato_1_Pliego_Maquina_Digital.Items.AddRange(New Object() {"", "473 x 323", "480 x 323", "440 x 315", "400 x 295", "420 x 297", "356 x 215", "323 x 235", "340 x 220", "650 x 313", "630 x 220", "500 x 323", "700 x 330", "297 x 210", "360 x 255", "650 x 235", "480 x 330", "457 x 350"})
        Me.cboFormato_1_Pliego_Maquina_Digital.Location = New System.Drawing.Point(100, 41)
        Me.cboFormato_1_Pliego_Maquina_Digital.Name = "cboFormato_1_Pliego_Maquina_Digital"
        Me.cboFormato_1_Pliego_Maquina_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_1_Pliego_Maquina_Digital.TabIndex = 139
        '
        'txtCantidad_2_Pliego_Maquina_Digital
        '
        Me.txtCantidad_2_Pliego_Maquina_Digital.Location = New System.Drawing.Point(25, 66)
        Me.txtCantidad_2_Pliego_Maquina_Digital.MaxLength = 7
        Me.txtCantidad_2_Pliego_Maquina_Digital.Name = "txtCantidad_2_Pliego_Maquina_Digital"
        Me.txtCantidad_2_Pliego_Maquina_Digital.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_2_Pliego_Maquina_Digital.TabIndex = 140
        '
        'GroupListado
        '
        Me.GroupListado.Controls.Add(Me.txt_Buscar_Nro_Orden)
        Me.GroupListado.Controls.Add(Me.Label20)
        Me.GroupListado.Controls.Add(Me.DataGridView1)
        Me.GroupListado.Location = New System.Drawing.Point(15, 424)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(1164, 223)
        Me.GroupListado.TabIndex = 136
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado de Re-Trabajos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(412, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 13)
        Me.Label20.TabIndex = 136
        Me.Label20.Text = "Buscar por Nro Orden"
        '
        'txt_Buscar_Nro_Orden
        '
        Me.txt_Buscar_Nro_Orden.Location = New System.Drawing.Point(528, 19)
        Me.txt_Buscar_Nro_Orden.MaxLength = 50
        Me.txt_Buscar_Nro_Orden.Name = "txt_Buscar_Nro_Orden"
        Me.txt_Buscar_Nro_Orden.Size = New System.Drawing.Size(202, 20)
        Me.txt_Buscar_Nro_Orden.TabIndex = 137
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(940, 654)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar.TabIndex = 137
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frm_retrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 699)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupTipoOrden)
        Me.Controls.Add(Me.GroupDatosOriginales)
        Me.Controls.Add(Me.GroupProducto1)
        Me.Controls.Add(Me.btnImprimirFormulario)
        Me.Controls.Add(Me.GroupReTrabajo)
        Me.Controls.Add(Me.btnCancelar_ReTrabajo)
        Me.Controls.Add(Me.btnGuardar_ReTrabajo)
        Me.Controls.Add(Me.GroupListado)
        Me.Name = "frm_retrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden  de Re-Trabajo"
        Me.GroupDatosOriginales.ResumeLayout(False)
        Me.GroupDatosOriginales.PerformLayout()
        Me.GroupProducto1.ResumeLayout(False)
        Me.GroupProducto1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.groupOffset.ResumeLayout(False)
        Me.groupOffset.PerformLayout()
        Me.GroupDigital.ResumeLayout(False)
        Me.GroupDigital.PerformLayout()
        Me.GroupReTrabajo.ResumeLayout(False)
        Me.GroupReTrabajo.PerformLayout()
        Me.GroupTipoOrden.ResumeLayout(False)
        Me.GroupTipoOrden.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupListado.ResumeLayout(False)
        Me.GroupListado.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_ReTrabajo As System.Windows.Forms.Button
    Friend WithEvents dtpFecha_Re_Trabajo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_retrabajo As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Fecha_Ingreso_Original As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnImprimirFormulario As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents dtp_Nueva_Fecha_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupDatosOriginales As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Entrega_Original As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPiezas1_Detalle1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño1_Detalle1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_original As System.Windows.Forms.TextBox
    Friend WithEvents GroupProducto1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_detalle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato_3_Pliego_Entero As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad_1_Pliego_Entero As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad_2_Pliego_Entero As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad_3_Pliego_Entero As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato_1_Pliego_Entero As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato_2_Pliego_Entero As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Gramaje_3_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel_3_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje_2_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel_2_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_Gramaje_1_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel_1_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents groupOffset As System.Windows.Forms.GroupBox
    Friend WithEvents cboMarca_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents cboModo_Impresion_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents cboImpresora_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipo_Impresion_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupDigital As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipo_Impresion_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtDato_Variable As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupReTrabajo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupTipoOrden As System.Windows.Forms.GroupBox
    Friend WithEvents chkOffset As System.Windows.Forms.CheckBox
    Friend WithEvents chkDigital As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cboFormato_3_Pliego_Maquina_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_1_Pliego_Maquina_Digital As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboFormato_2_Pliego_Maquina_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad_3_Pliego_Maquina_Digital As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato_1_Pliego_Maquina_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_2_Pliego_Maquina_Digital As System.Windows.Forms.TextBox
    Friend WithEvents txt_chapa_soporte_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_chapa_soporte_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_chapa_soporte_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboFormato_3_Pliego_Maquina_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_1_Pliego_Maquina_Offset As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cboFormato_2_Pliego_Maquina_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad_3_Pliego_Maquina_Offset As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato_1_Pliego_Maquina_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_2_Pliego_Maquina_Offset As System.Windows.Forms.TextBox
    Friend WithEvents GroupListado As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Buscar_Nro_Orden As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
