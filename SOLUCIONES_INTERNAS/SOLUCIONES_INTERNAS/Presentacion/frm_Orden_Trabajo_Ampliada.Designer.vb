﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Orden_Trabajo_Ampliada
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
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.dtpFecha_Entrega_ODT = New System.Windows.Forms.DateTimePicker()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.btnImprimirFormulario = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnGuardar_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.txt_id_detalle_orden_trabajo1 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboPiezas_Producto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTamaño_Producto = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_producto = New System.Windows.Forms.TextBox()
        Me.btnCancelar_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnActualizar_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.btnNueva_Orden_Trabajo = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtNumero_Orden_Trabajo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBuscar_cliente = New System.Windows.Forms.Button()
        Me.txt_id_orden_trabajo = New System.Windows.Forms.TextBox()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFecha_Ingreso_ODT = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar_Vendedor = New System.Windows.Forms.Button()
        Me.txtNombre_vendedor = New System.Windows.Forms.TextBox()
        Me.txtid_vendedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTerminacion = New System.Windows.Forms.CheckBox()
        Me.chkGranFormato = New System.Windows.Forms.CheckBox()
        Me.chkOffset = New System.Windows.Forms.CheckBox()
        Me.chkDigital = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboFormato_3_Pliego_Entero = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_Cantidad_1_Pliego_Entero = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad_2_Pliego_Entero = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad_3_Pliego_Entero = New System.Windows.Forms.TextBox()
        Me.cboFormato_1_Pliego_Entero = New System.Windows.Forms.ComboBox()
        Me.cboFormato_2_Pliego_Entero = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Gramaje_3_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Papel_3_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Gramaje_2_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Papel_2_Soporte = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Gramaje_1_Soporte = New System.Windows.Forms.TextBox()
        Me.txt_Papel_1_Soporte = New System.Windows.Forms.TextBox()
        Me.cboImpresora_Offset = New System.Windows.Forms.ComboBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtChapas_Offset = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.cboModo_Impresion_Offset = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboFormato_3_Pliego_Maquina_Offset = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_1_Pliego_Maquina_Offset = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cboFormato_2_Pliego_Maquina_Offset = New System.Windows.Forms.ComboBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtCantidad_3_Pliego_Maquina_Offset = New System.Windows.Forms.TextBox()
        Me.cboFormato_1_Pliego_Maquina_Offset = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_2_Pliego_Maquina_Offset = New System.Windows.Forms.TextBox()
        Me.cboDireccion_Entrega = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboTipo_Impresion_Offset = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cboTipo_Orden = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboTipo_Impresion_Digital = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cboFormato_3_Pliego_Maquina_Digital = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_1_Pliego_Maquina_Digital = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFormato_2_Pliego_Maquina_Digital = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCantidad_3_Pliego_Maquina_Digital = New System.Windows.Forms.TextBox()
        Me.cboFormato_1_Pliego_Maquina_Digital = New System.Windows.Forms.ComboBox()
        Me.txtCantidad_2_Pliego_Maquina_Digital = New System.Windows.Forms.TextBox()
        Me.txtDato_Variable = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboModo_Impresion_Digital = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cboPiezas_Producto_Gran_Formato = New System.Windows.Forms.ComboBox()
        Me.cboCalidad_Gran_Formato = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTamaño_Producto_Gran_Formato = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_producto_Gran_Formato = New System.Windows.Forms.TextBox()
        Me.cboSistema_Gran_Formato = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtSustrato_Gran_Formato = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkPosicionado = New System.Windows.Forms.CheckBox()
        Me.chkMedio_Corte = New System.Windows.Forms.CheckBox()
        Me.chkSoldado = New System.Windows.Forms.CheckBox()
        Me.chkRuedo = New System.Windows.Forms.CheckBox()
        Me.chkCocido = New System.Windows.Forms.CheckBox()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.chkMontado = New System.Windows.Forms.CheckBox()
        Me.chkTrazado = New System.Windows.Forms.CheckBox()
        Me.chkDoblado = New System.Windows.Forms.CheckBox()
        Me.chkStamping = New System.Windows.Forms.CheckBox()
        Me.chkEncuadernacion = New System.Windows.Forms.CheckBox()
        Me.chkAdhesivado = New System.Windows.Forms.CheckBox()
        Me.chkPolipropileno = New System.Windows.Forms.CheckBox()
        Me.chkCorte = New System.Windows.Forms.CheckBox()
        Me.chkTroquelado = New System.Windows.Forms.CheckBox()
        Me.chkBarniz = New System.Windows.Forms.CheckBox()
        Me.chkLaca_UV = New System.Windows.Forms.CheckBox()
        Me.txt_descripcion_terminacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Red
        Me.Label56.Location = New System.Drawing.Point(597, 79)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(11, 13)
        Me.Label56.TabIndex = 103
        Me.Label56.Text = "*"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Red
        Me.Label55.Location = New System.Drawing.Point(530, 34)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(11, 13)
        Me.Label55.TabIndex = 102
        Me.Label55.Text = "*"
        '
        'dtpFecha_Entrega_ODT
        '
        Me.dtpFecha_Entrega_ODT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Entrega_ODT.Location = New System.Drawing.Point(547, 28)
        Me.dtpFecha_Entrega_ODT.Name = "dtpFecha_Entrega_ODT"
        Me.dtpFecha_Entrega_ODT.Size = New System.Drawing.Size(118, 20)
        Me.dtpFecha_Entrega_ODT.TabIndex = 101
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(454, 30)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 13)
        Me.Label54.TabIndex = 100
        Me.Label54.Text = "Fecha Entrega"
        '
        'btnImprimirFormulario
        '
        Me.btnImprimirFormulario.Location = New System.Drawing.Point(717, 712)
        Me.btnImprimirFormulario.Name = "btnImprimirFormulario"
        Me.btnImprimirFormulario.Size = New System.Drawing.Size(108, 33)
        Me.btnImprimirFormulario.TabIndex = 98
        Me.btnImprimirFormulario.Text = "Imprimir Formulario"
        Me.btnImprimirFormulario.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(633, 766)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "* (campos requeridos)"
        '
        'btnGuardar_Orden_Trabajo
        '
        Me.btnGuardar_Orden_Trabajo.Location = New System.Drawing.Point(831, 712)
        Me.btnGuardar_Orden_Trabajo.Name = "btnGuardar_Orden_Trabajo"
        Me.btnGuardar_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnGuardar_Orden_Trabajo.TabIndex = 92
        Me.btnGuardar_Orden_Trabajo.Text = "Guardar"
        Me.btnGuardar_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'txt_id_detalle_orden_trabajo1
        '
        Me.txt_id_detalle_orden_trabajo1.Location = New System.Drawing.Point(990, 23)
        Me.txt_id_detalle_orden_trabajo1.Name = "txt_id_detalle_orden_trabajo1"
        Me.txt_id_detalle_orden_trabajo1.Size = New System.Drawing.Size(32, 20)
        Me.txt_id_detalle_orden_trabajo1.TabIndex = 57
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(296, 19)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(11, 13)
        Me.Label49.TabIndex = 58
        Me.Label49.Text = "*"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(861, 26)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(129, 13)
        Me.Label45.TabIndex = 56
        Me.Label45.Text = "id_detalle_orden_trabajo1"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(182, 18)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(11, 13)
        Me.Label48.TabIndex = 57
        Me.Label48.Text = "*"
        '
        'cboPiezas_Producto
        '
        Me.cboPiezas_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas_Producto.FormattingEnabled = True
        Me.cboPiezas_Producto.Location = New System.Drawing.Point(197, 37)
        Me.cboPiezas_Producto.Name = "cboPiezas_Producto"
        Me.cboPiezas_Producto.Size = New System.Drawing.Size(159, 21)
        Me.cboPiezas_Producto.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tamaño (°°° x °°° Mm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cantidad"
        '
        'txtTamaño_Producto
        '
        Me.txtTamaño_Producto.Location = New System.Drawing.Point(363, 38)
        Me.txtTamaño_Producto.MaxLength = 50
        Me.txtTamaño_Producto.Name = "txtTamaño_Producto"
        Me.txtTamaño_Producto.Size = New System.Drawing.Size(117, 20)
        Me.txtTamaño_Producto.TabIndex = 9
        '
        'txt_cantidad_producto
        '
        Me.txt_cantidad_producto.Location = New System.Drawing.Point(132, 37)
        Me.txt_cantidad_producto.Name = "txt_cantidad_producto"
        Me.txt_cantidad_producto.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad_producto.TabIndex = 7
        '
        'btnCancelar_Orden_Trabajo
        '
        Me.btnCancelar_Orden_Trabajo.Location = New System.Drawing.Point(993, 712)
        Me.btnCancelar_Orden_Trabajo.Name = "btnCancelar_Orden_Trabajo"
        Me.btnCancelar_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar_Orden_Trabajo.TabIndex = 94
        Me.btnCancelar_Orden_Trabajo.Text = "Cancelar"
        Me.btnCancelar_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnActualizar_Orden_Trabajo
        '
        Me.btnActualizar_Orden_Trabajo.Location = New System.Drawing.Point(912, 712)
        Me.btnActualizar_Orden_Trabajo.Name = "btnActualizar_Orden_Trabajo"
        Me.btnActualizar_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar_Orden_Trabajo.TabIndex = 99
        Me.btnActualizar_Orden_Trabajo.Text = "Actualizar"
        Me.btnActualizar_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'btnNueva_Orden_Trabajo
        '
        Me.btnNueva_Orden_Trabajo.Location = New System.Drawing.Point(636, 712)
        Me.btnNueva_Orden_Trabajo.Name = "btnNueva_Orden_Trabajo"
        Me.btnNueva_Orden_Trabajo.Size = New System.Drawing.Size(75, 33)
        Me.btnNueva_Orden_Trabajo.TabIndex = 96
        Me.btnNueva_Orden_Trabajo.Text = "Nuevo"
        Me.btnNueva_Orden_Trabajo.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(91, 34)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(11, 13)
        Me.Label46.TabIndex = 90
        Me.Label46.Text = "*"
        '
        'txtNumero_Orden_Trabajo
        '
        Me.txtNumero_Orden_Trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Orden_Trabajo.Location = New System.Drawing.Point(111, 19)
        Me.txtNumero_Orden_Trabajo.MaxLength = 10
        Me.txtNumero_Orden_Trabajo.Multiline = True
        Me.txtNumero_Orden_Trabajo.Name = "txtNumero_Orden_Trabajo"
        Me.txtNumero_Orden_Trabajo.Size = New System.Drawing.Size(98, 41)
        Me.txtNumero_Orden_Trabajo.TabIndex = 68
        Me.txtNumero_Orden_Trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Número Orden"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(92, 72)
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(292, 20)
        Me.txt_nombre_cliente.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(77, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(77, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Cliente"
        '
        'btnBuscar_cliente
        '
        Me.btnBuscar_cliente.Location = New System.Drawing.Point(392, 71)
        Me.btnBuscar_cliente.Name = "btnBuscar_cliente"
        Me.btnBuscar_cliente.Size = New System.Drawing.Size(40, 23)
        Me.btnBuscar_cliente.TabIndex = 70
        Me.btnBuscar_cliente.Text = "..."
        Me.btnBuscar_cliente.UseVisualStyleBackColor = True
        '
        'txt_id_orden_trabajo
        '
        Me.txt_id_orden_trabajo.Location = New System.Drawing.Point(810, 759)
        Me.txt_id_orden_trabajo.Name = "txt_id_orden_trabajo"
        Me.txt_id_orden_trabajo.Size = New System.Drawing.Size(75, 20)
        Me.txt_id_orden_trabajo.TabIndex = 77
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(25, 65)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(10, 20)
        Me.txt_id_cliente.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(784, 762)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "TN"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(492, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 13)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "Dirección de Entrega"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(680, 34)
        Me.txt_observaciones.MaxLength = 350
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observaciones.Size = New System.Drawing.Size(370, 92)
        Me.txt_observaciones.TabIndex = 71
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(816, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Observaciones"
        '
        'dtpFecha_Ingreso_ODT
        '
        Me.dtpFecha_Ingreso_ODT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Ingreso_ODT.Location = New System.Drawing.Point(309, 28)
        Me.dtpFecha_Ingreso_ODT.Name = "dtpFecha_Ingreso_ODT"
        Me.dtpFecha_Ingreso_ODT.Size = New System.Drawing.Size(119, 20)
        Me.dtpFecha_Ingreso_ODT.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Fecha Ingreso"
        '
        'btnBuscar_Vendedor
        '
        Me.btnBuscar_Vendedor.Location = New System.Drawing.Point(392, 104)
        Me.btnBuscar_Vendedor.Name = "btnBuscar_Vendedor"
        Me.btnBuscar_Vendedor.Size = New System.Drawing.Size(40, 23)
        Me.btnBuscar_Vendedor.TabIndex = 69
        Me.btnBuscar_Vendedor.Text = "..."
        Me.btnBuscar_Vendedor.UseVisualStyleBackColor = True
        '
        'txtNombre_vendedor
        '
        Me.txtNombre_vendedor.Location = New System.Drawing.Point(92, 106)
        Me.txtNombre_vendedor.Name = "txtNombre_vendedor"
        Me.txtNombre_vendedor.Size = New System.Drawing.Size(292, 20)
        Me.txtNombre_vendedor.TabIndex = 82
        '
        'txtid_vendedor
        '
        Me.txtid_vendedor.Location = New System.Drawing.Point(10, 106)
        Me.txtid_vendedor.Name = "txtid_vendedor"
        Me.txtid_vendedor.Size = New System.Drawing.Size(10, 20)
        Me.txtid_vendedor.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Vendedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTerminacion)
        Me.GroupBox1.Controls.Add(Me.chkGranFormato)
        Me.GroupBox1.Controls.Add(Me.chkOffset)
        Me.GroupBox1.Controls.Add(Me.chkDigital)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.txt_id_detalle_orden_trabajo1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1056, 56)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Orden"
        '
        'chkTerminacion
        '
        Me.chkTerminacion.AutoSize = True
        Me.chkTerminacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTerminacion.Location = New System.Drawing.Point(664, 17)
        Me.chkTerminacion.Name = "chkTerminacion"
        Me.chkTerminacion.Size = New System.Drawing.Size(135, 28)
        Me.chkTerminacion.TabIndex = 0
        Me.chkTerminacion.Text = "Terminación"
        Me.chkTerminacion.UseVisualStyleBackColor = True
        '
        'chkGranFormato
        '
        Me.chkGranFormato.AutoSize = True
        Me.chkGranFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGranFormato.Location = New System.Drawing.Point(480, 17)
        Me.chkGranFormato.Name = "chkGranFormato"
        Me.chkGranFormato.Size = New System.Drawing.Size(145, 28)
        Me.chkGranFormato.TabIndex = 0
        Me.chkGranFormato.Text = "Gran Formato"
        Me.chkGranFormato.UseVisualStyleBackColor = True
        '
        'chkOffset
        '
        Me.chkOffset.AutoSize = True
        Me.chkOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOffset.Location = New System.Drawing.Point(224, 17)
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
        Me.chkDigital.Location = New System.Drawing.Point(354, 17)
        Me.chkDigital.Name = "chkDigital"
        Me.chkDigital.Size = New System.Drawing.Size(79, 28)
        Me.chkDigital.TabIndex = 0
        Me.chkDigital.Text = "Digital"
        Me.chkDigital.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje_3_Soporte)
        Me.GroupBox5.Controls.Add(Me.txt_Papel_3_Soporte)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje_2_Soporte)
        Me.GroupBox5.Controls.Add(Me.txt_Papel_2_Soporte)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txt_Gramaje_1_Soporte)
        Me.GroupBox5.Controls.Add(Me.txt_Papel_1_Soporte)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(613, 146)
        Me.GroupBox5.TabIndex = 105
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Soportes"
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
        Me.GroupBox8.Location = New System.Drawing.Point(369, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(230, 121)
        Me.GroupBox8.TabIndex = 133
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Pliego Entero"
        '
        'cboFormato_3_Pliego_Entero
        '
        Me.cboFormato_3_Pliego_Entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_3_Pliego_Entero.FormattingEnabled = True
        Me.cboFormato_3_Pliego_Entero.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato_3_Pliego_Entero.Location = New System.Drawing.Point(84, 91)
        Me.cboFormato_3_Pliego_Entero.Name = "cboFormato_3_Pliego_Entero"
        Me.cboFormato_3_Pliego_Entero.Size = New System.Drawing.Size(134, 21)
        Me.cboFormato_3_Pliego_Entero.TabIndex = 39
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(19, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "Cantidad"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(116, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Formato (Mm)"
        '
        'txt_Cantidad_1_Pliego_Entero
        '
        Me.txt_Cantidad_1_Pliego_Entero.Location = New System.Drawing.Point(9, 39)
        Me.txt_Cantidad_1_Pliego_Entero.Name = "txt_Cantidad_1_Pliego_Entero"
        Me.txt_Cantidad_1_Pliego_Entero.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad_1_Pliego_Entero.TabIndex = 30
        '
        'txt_Cantidad_2_Pliego_Entero
        '
        Me.txt_Cantidad_2_Pliego_Entero.Location = New System.Drawing.Point(9, 64)
        Me.txt_Cantidad_2_Pliego_Entero.Name = "txt_Cantidad_2_Pliego_Entero"
        Me.txt_Cantidad_2_Pliego_Entero.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad_2_Pliego_Entero.TabIndex = 34
        '
        'txt_Cantidad_3_Pliego_Entero
        '
        Me.txt_Cantidad_3_Pliego_Entero.Location = New System.Drawing.Point(9, 90)
        Me.txt_Cantidad_3_Pliego_Entero.Name = "txt_Cantidad_3_Pliego_Entero"
        Me.txt_Cantidad_3_Pliego_Entero.Size = New System.Drawing.Size(69, 20)
        Me.txt_Cantidad_3_Pliego_Entero.TabIndex = 38
        '
        'cboFormato_1_Pliego_Entero
        '
        Me.cboFormato_1_Pliego_Entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_1_Pliego_Entero.FormattingEnabled = True
        Me.cboFormato_1_Pliego_Entero.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato_1_Pliego_Entero.Location = New System.Drawing.Point(84, 40)
        Me.cboFormato_1_Pliego_Entero.Name = "cboFormato_1_Pliego_Entero"
        Me.cboFormato_1_Pliego_Entero.Size = New System.Drawing.Size(134, 21)
        Me.cboFormato_1_Pliego_Entero.TabIndex = 31
        '
        'cboFormato_2_Pliego_Entero
        '
        Me.cboFormato_2_Pliego_Entero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_2_Pliego_Entero.FormattingEnabled = True
        Me.cboFormato_2_Pliego_Entero.Items.AddRange(New Object() {"630 x 880", "650 x 500", "650 x 950", "700 x 500", "700 x 1000", "720 x 920", "720 x 1020", "740 x 1100", "760 x 1120", "820 x 1120", "820 x 1180", "860 x 610", "1000 x 660"})
        Me.cboFormato_2_Pliego_Entero.Location = New System.Drawing.Point(84, 66)
        Me.cboFormato_2_Pliego_Entero.Name = "cboFormato_2_Pliego_Entero"
        Me.cboFormato_2_Pliego_Entero.Size = New System.Drawing.Size(134, 21)
        Me.cboFormato_2_Pliego_Entero.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "1"
        '
        'txt_Gramaje_3_Soporte
        '
        Me.txt_Gramaje_3_Soporte.Location = New System.Drawing.Point(255, 104)
        Me.txt_Gramaje_3_Soporte.MaxLength = 10
        Me.txt_Gramaje_3_Soporte.Name = "txt_Gramaje_3_Soporte"
        Me.txt_Gramaje_3_Soporte.Size = New System.Drawing.Size(101, 20)
        Me.txt_Gramaje_3_Soporte.TabIndex = 20
        '
        'txt_Papel_3_Soporte
        '
        Me.txt_Papel_3_Soporte.Location = New System.Drawing.Point(24, 104)
        Me.txt_Papel_3_Soporte.MaxLength = 50
        Me.txt_Papel_3_Soporte.Name = "txt_Papel_3_Soporte"
        Me.txt_Papel_3_Soporte.Size = New System.Drawing.Size(225, 20)
        Me.txt_Papel_3_Soporte.TabIndex = 19
        '
        'txt_Gramaje_2_Soporte
        '
        Me.txt_Gramaje_2_Soporte.Location = New System.Drawing.Point(255, 78)
        Me.txt_Gramaje_2_Soporte.MaxLength = 10
        Me.txt_Gramaje_2_Soporte.Name = "txt_Gramaje_2_Soporte"
        Me.txt_Gramaje_2_Soporte.Size = New System.Drawing.Size(101, 20)
        Me.txt_Gramaje_2_Soporte.TabIndex = 16
        '
        'txt_Papel_2_Soporte
        '
        Me.txt_Papel_2_Soporte.Location = New System.Drawing.Point(24, 78)
        Me.txt_Papel_2_Soporte.MaxLength = 50
        Me.txt_Papel_2_Soporte.Name = "txt_Papel_2_Soporte"
        Me.txt_Papel_2_Soporte.Size = New System.Drawing.Size(225, 20)
        Me.txt_Papel_2_Soporte.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(268, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 13)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Gramaje/Grosor"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(67, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Papel/Sustrato"
        '
        'txt_Gramaje_1_Soporte
        '
        Me.txt_Gramaje_1_Soporte.Location = New System.Drawing.Point(255, 53)
        Me.txt_Gramaje_1_Soporte.MaxLength = 10
        Me.txt_Gramaje_1_Soporte.Name = "txt_Gramaje_1_Soporte"
        Me.txt_Gramaje_1_Soporte.Size = New System.Drawing.Size(101, 20)
        Me.txt_Gramaje_1_Soporte.TabIndex = 12
        '
        'txt_Papel_1_Soporte
        '
        Me.txt_Papel_1_Soporte.Location = New System.Drawing.Point(24, 53)
        Me.txt_Papel_1_Soporte.MaxLength = 50
        Me.txt_Papel_1_Soporte.Name = "txt_Papel_1_Soporte"
        Me.txt_Papel_1_Soporte.Size = New System.Drawing.Size(225, 20)
        Me.txt_Papel_1_Soporte.TabIndex = 11
        '
        'cboImpresora_Offset
        '
        Me.cboImpresora_Offset.FormattingEnabled = True
        Me.cboImpresora_Offset.Items.AddRange(New Object() {"CD/4", "CD/6", "SM", "SOR"})
        Me.cboImpresora_Offset.Location = New System.Drawing.Point(118, 254)
        Me.cboImpresora_Offset.Name = "cboImpresora_Offset"
        Me.cboImpresora_Offset.Size = New System.Drawing.Size(112, 21)
        Me.cboImpresora_Offset.TabIndex = 135
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(59, 257)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(53, 13)
        Me.Label66.TabIndex = 134
        Me.Label66.Text = "Impresora"
        '
        'txtChapas_Offset
        '
        Me.txtChapas_Offset.Location = New System.Drawing.Point(118, 224)
        Me.txtChapas_Offset.Name = "txtChapas_Offset"
        Me.txtChapas_Offset.Size = New System.Drawing.Size(86, 20)
        Me.txtChapas_Offset.TabIndex = 132
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(69, 227)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 13)
        Me.Label60.TabIndex = 131
        Me.Label60.Text = "Chapas"
        '
        'cboModo_Impresion_Offset
        '
        Me.cboModo_Impresion_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModo_Impresion_Offset.FormattingEnabled = True
        Me.cboModo_Impresion_Offset.Items.AddRange(New Object() {"Tire y Retire", "Frente y Dorso", "Frente", "Pinza y Contrapinza"})
        Me.cboModo_Impresion_Offset.Location = New System.Drawing.Point(119, 154)
        Me.cboModo_Impresion_Offset.Name = "cboModo_Impresion_Offset"
        Me.cboModo_Impresion_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboModo_Impresion_Offset.TabIndex = 128
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(30, 157)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(82, 13)
        Me.Label61.TabIndex = 129
        Me.Label61.Text = "Modo Impresión"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboFormato_3_Pliego_Maquina_Offset)
        Me.GroupBox3.Controls.Add(Me.txtCantidad_1_Pliego_Maquina_Offset)
        Me.GroupBox3.Controls.Add(Me.Label58)
        Me.GroupBox3.Controls.Add(Me.cboFormato_2_Pliego_Maquina_Offset)
        Me.GroupBox3.Controls.Add(Me.Label57)
        Me.GroupBox3.Controls.Add(Me.txtCantidad_3_Pliego_Maquina_Offset)
        Me.GroupBox3.Controls.Add(Me.cboFormato_1_Pliego_Maquina_Offset)
        Me.GroupBox3.Controls.Add(Me.txtCantidad_2_Pliego_Maquina_Offset)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 121)
        Me.GroupBox3.TabIndex = 128
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pliego Máquina"
        '
        'cboFormato_3_Pliego_Maquina_Offset
        '
        Me.cboFormato_3_Pliego_Maquina_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_3_Pliego_Maquina_Offset.FormattingEnabled = True
        Me.cboFormato_3_Pliego_Maquina_Offset.Items.AddRange(New Object() {"650 x 470", "650 x 315", "630 x 440", "590 x 410", "550 x 370", "510 x 360", "500 x 350", "500 x 325", "470 x 325", "440 x 315", "820 x 590", "740 x 550", "720 x 510"})
        Me.cboFormato_3_Pliego_Maquina_Offset.Location = New System.Drawing.Point(82, 94)
        Me.cboFormato_3_Pliego_Maquina_Offset.Name = "cboFormato_3_Pliego_Maquina_Offset"
        Me.cboFormato_3_Pliego_Maquina_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_3_Pliego_Maquina_Offset.TabIndex = 65
        '
        'txtCantidad_1_Pliego_Maquina_Offset
        '
        Me.txtCantidad_1_Pliego_Maquina_Offset.Location = New System.Drawing.Point(7, 43)
        Me.txtCantidad_1_Pliego_Maquina_Offset.Name = "txtCantidad_1_Pliego_Maquina_Offset"
        Me.txtCantidad_1_Pliego_Maquina_Offset.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_1_Pliego_Maquina_Offset.TabIndex = 60
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(17, 22)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(49, 13)
        Me.Label58.TabIndex = 67
        Me.Label58.Text = "Cantidad"
        '
        'cboFormato_2_Pliego_Maquina_Offset
        '
        Me.cboFormato_2_Pliego_Maquina_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_2_Pliego_Maquina_Offset.FormattingEnabled = True
        Me.cboFormato_2_Pliego_Maquina_Offset.Items.AddRange(New Object() {"650 x 470", "650 x 315", "630 x 440", "590 x 410", "550 x 370", "510 x 360", "500 x 350", "500 x 325", "470 x 325", "440 x 315", "820 x 590", "740 x 550", "720 x 510"})
        Me.cboFormato_2_Pliego_Maquina_Offset.Location = New System.Drawing.Point(82, 69)
        Me.cboFormato_2_Pliego_Maquina_Offset.Name = "cboFormato_2_Pliego_Maquina_Offset"
        Me.cboFormato_2_Pliego_Maquina_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_2_Pliego_Maquina_Offset.TabIndex = 63
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(93, 22)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(71, 13)
        Me.Label57.TabIndex = 66
        Me.Label57.Text = "Formato (Mm)"
        '
        'txtCantidad_3_Pliego_Maquina_Offset
        '
        Me.txtCantidad_3_Pliego_Maquina_Offset.Location = New System.Drawing.Point(7, 94)
        Me.txtCantidad_3_Pliego_Maquina_Offset.Name = "txtCantidad_3_Pliego_Maquina_Offset"
        Me.txtCantidad_3_Pliego_Maquina_Offset.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_3_Pliego_Maquina_Offset.TabIndex = 64
        '
        'cboFormato_1_Pliego_Maquina_Offset
        '
        Me.cboFormato_1_Pliego_Maquina_Offset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_1_Pliego_Maquina_Offset.FormattingEnabled = True
        Me.cboFormato_1_Pliego_Maquina_Offset.Items.AddRange(New Object() {"650 x 470", "650 x 315", "630 x 440", "590 x 410", "550 x 370", "510 x 360", "500 x 350", "500 x 325", "470 x 325", "440 x 315", "820 x 590", "740 x 550", "720 x 510"})
        Me.cboFormato_1_Pliego_Maquina_Offset.Location = New System.Drawing.Point(82, 43)
        Me.cboFormato_1_Pliego_Maquina_Offset.Name = "cboFormato_1_Pliego_Maquina_Offset"
        Me.cboFormato_1_Pliego_Maquina_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_1_Pliego_Maquina_Offset.TabIndex = 61
        '
        'txtCantidad_2_Pliego_Maquina_Offset
        '
        Me.txtCantidad_2_Pliego_Maquina_Offset.Location = New System.Drawing.Point(7, 68)
        Me.txtCantidad_2_Pliego_Maquina_Offset.Name = "txtCantidad_2_Pliego_Maquina_Offset"
        Me.txtCantidad_2_Pliego_Maquina_Offset.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_2_Pliego_Maquina_Offset.TabIndex = 62
        '
        'cboDireccion_Entrega
        '
        Me.cboDireccion_Entrega.FormattingEnabled = True
        Me.cboDireccion_Entrega.Items.AddRange(New Object() {"Casa Central", "Planta Industrial"})
        Me.cboDireccion_Entrega.Location = New System.Drawing.Point(453, 106)
        Me.cboDireccion_Entrega.Name = "cboDireccion_Entrega"
        Me.cboDireccion_Entrega.Size = New System.Drawing.Size(212, 21)
        Me.cboDireccion_Entrega.TabIndex = 128
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboTipo_Impresion_Offset)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.cboImpresora_Offset)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label66)
        Me.GroupBox2.Controls.Add(Me.cboModo_Impresion_Offset)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.txtChapas_Offset)
        Me.GroupBox2.Controls.Add(Me.Label60)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 285)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Offset"
        '
        'cboTipo_Impresion_Offset
        '
        Me.cboTipo_Impresion_Offset.FormattingEnabled = True
        Me.cboTipo_Impresion_Offset.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipo_Impresion_Offset.Location = New System.Drawing.Point(119, 191)
        Me.cboTipo_Impresion_Offset.Name = "cboTipo_Impresion_Offset"
        Me.cboTipo_Impresion_Offset.Size = New System.Drawing.Size(138, 21)
        Me.cboTipo_Impresion_Offset.TabIndex = 138
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(37, 194)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(76, 13)
        Me.Label35.TabIndex = 139
        Me.Label35.Text = "Tipo Impresión"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboDireccion_Entrega)
        Me.GroupBox4.Controls.Add(Me.Label56)
        Me.GroupBox4.Controls.Add(Me.Label55)
        Me.GroupBox4.Controls.Add(Me.dtpFecha_Entrega_ODT)
        Me.GroupBox4.Controls.Add(Me.Label54)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txt_observaciones)
        Me.GroupBox4.Controls.Add(Me.txtNumero_Orden_Trabajo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_nombre_cliente)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.btnBuscar_cliente)
        Me.GroupBox4.Controls.Add(Me.txt_id_cliente)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.dtpFecha_Ingreso_ODT)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.btnBuscar_Vendedor)
        Me.GroupBox4.Controls.Add(Me.txtNombre_vendedor)
        Me.GroupBox4.Controls.Add(Me.txtid_vendedor)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1056, 133)
        Me.GroupBox4.TabIndex = 130
        Me.GroupBox4.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(983, 765)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(11, 13)
        Me.Label47.TabIndex = 60
        Me.Label47.Text = "*"
        '
        'cboTipo_Orden
        '
        Me.cboTipo_Orden.FormattingEnabled = True
        Me.cboTipo_Orden.Items.AddRange(New Object() {"DG", "DO", "DI", "DV", "DS"})
        Me.cboTipo_Orden.Location = New System.Drawing.Point(1000, 759)
        Me.cboTipo_Orden.MaxLength = 10
        Me.cboTipo_Orden.Name = "cboTipo_Orden"
        Me.cboTipo_Orden.Size = New System.Drawing.Size(41, 21)
        Me.cboTipo_Orden.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(924, 761)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Tipo Orden"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboTipo_Impresion_Digital)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.txtDato_Variable)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.cboModo_Impresion_Digital)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(331, 430)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(294, 358)
        Me.GroupBox6.TabIndex = 131
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Digital"
        '
        'cboTipo_Impresion_Digital
        '
        Me.cboTipo_Impresion_Digital.FormattingEnabled = True
        Me.cboTipo_Impresion_Digital.Items.AddRange(New Object() {"1/0", "1/1", "1/4", "4/0", "4/1", "4/4"})
        Me.cboTipo_Impresion_Digital.Location = New System.Drawing.Point(117, 191)
        Me.cboTipo_Impresion_Digital.Name = "cboTipo_Impresion_Digital"
        Me.cboTipo_Impresion_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboTipo_Impresion_Digital.TabIndex = 136
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(35, 194)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 13)
        Me.Label34.TabIndex = 137
        Me.Label34.Text = "Tipo Impresión"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboFormato_3_Pliego_Maquina_Digital)
        Me.GroupBox7.Controls.Add(Me.txtCantidad_1_Pliego_Maquina_Digital)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.cboFormato_2_Pliego_Maquina_Digital)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.txtCantidad_3_Pliego_Maquina_Digital)
        Me.GroupBox7.Controls.Add(Me.cboFormato_1_Pliego_Maquina_Digital)
        Me.GroupBox7.Controls.Add(Me.txtCantidad_2_Pliego_Maquina_Digital)
        Me.GroupBox7.Location = New System.Drawing.Point(35, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(232, 121)
        Me.GroupBox7.TabIndex = 132
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Pliego Máquina"
        '
        'cboFormato_3_Pliego_Maquina_Digital
        '
        Me.cboFormato_3_Pliego_Maquina_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_3_Pliego_Maquina_Digital.FormattingEnabled = True
        Me.cboFormato_3_Pliego_Maquina_Digital.Items.AddRange(New Object() {"473 x 323", "480 x 323", "440 x 315", "400 x 295", "420 x 297", "356 x 215", "323 x 235", "340 x 220", "650 x 313", "630 x 220", "500 x 323", "700 x 330", "297 x 210", "360 x 255"})
        Me.cboFormato_3_Pliego_Maquina_Digital.Location = New System.Drawing.Point(82, 94)
        Me.cboFormato_3_Pliego_Maquina_Digital.Name = "cboFormato_3_Pliego_Maquina_Digital"
        Me.cboFormato_3_Pliego_Maquina_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_3_Pliego_Maquina_Digital.TabIndex = 65
        '
        'txtCantidad_1_Pliego_Maquina_Digital
        '
        Me.txtCantidad_1_Pliego_Maquina_Digital.Location = New System.Drawing.Point(7, 43)
        Me.txtCantidad_1_Pliego_Maquina_Digital.Name = "txtCantidad_1_Pliego_Maquina_Digital"
        Me.txtCantidad_1_Pliego_Maquina_Digital.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_1_Pliego_Maquina_Digital.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Cantidad"
        '
        'cboFormato_2_Pliego_Maquina_Digital
        '
        Me.cboFormato_2_Pliego_Maquina_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_2_Pliego_Maquina_Digital.FormattingEnabled = True
        Me.cboFormato_2_Pliego_Maquina_Digital.Items.AddRange(New Object() {"473 x 323", "480 x 323", "440 x 315", "400 x 295", "420 x 297", "356 x 215", "323 x 235", "340 x 220", "650 x 313", "630 x 220", "500 x 323", "700 x 330", "297 x 210", "360 x 255"})
        Me.cboFormato_2_Pliego_Maquina_Digital.Location = New System.Drawing.Point(82, 69)
        Me.cboFormato_2_Pliego_Maquina_Digital.Name = "cboFormato_2_Pliego_Maquina_Digital"
        Me.cboFormato_2_Pliego_Maquina_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_2_Pliego_Maquina_Digital.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(93, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Formato (Mm)"
        '
        'txtCantidad_3_Pliego_Maquina_Digital
        '
        Me.txtCantidad_3_Pliego_Maquina_Digital.Location = New System.Drawing.Point(7, 94)
        Me.txtCantidad_3_Pliego_Maquina_Digital.Name = "txtCantidad_3_Pliego_Maquina_Digital"
        Me.txtCantidad_3_Pliego_Maquina_Digital.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_3_Pliego_Maquina_Digital.TabIndex = 64
        '
        'cboFormato_1_Pliego_Maquina_Digital
        '
        Me.cboFormato_1_Pliego_Maquina_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato_1_Pliego_Maquina_Digital.FormattingEnabled = True
        Me.cboFormato_1_Pliego_Maquina_Digital.Items.AddRange(New Object() {"473 x 323", "480 x 323", "440 x 315", "400 x 295", "420 x 297", "356 x 215", "323 x 235", "340 x 220", "650 x 313", "630 x 220", "500 x 323", "700 x 330", "297 x 210", "360 x 255"})
        Me.cboFormato_1_Pliego_Maquina_Digital.Location = New System.Drawing.Point(82, 43)
        Me.cboFormato_1_Pliego_Maquina_Digital.Name = "cboFormato_1_Pliego_Maquina_Digital"
        Me.cboFormato_1_Pliego_Maquina_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboFormato_1_Pliego_Maquina_Digital.TabIndex = 61
        '
        'txtCantidad_2_Pliego_Maquina_Digital
        '
        Me.txtCantidad_2_Pliego_Maquina_Digital.Location = New System.Drawing.Point(7, 68)
        Me.txtCantidad_2_Pliego_Maquina_Digital.Name = "txtCantidad_2_Pliego_Maquina_Digital"
        Me.txtCantidad_2_Pliego_Maquina_Digital.Size = New System.Drawing.Size(69, 20)
        Me.txtCantidad_2_Pliego_Maquina_Digital.TabIndex = 62
        '
        'txtDato_Variable
        '
        Me.txtDato_Variable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato_Variable.Location = New System.Drawing.Point(6, 240)
        Me.txtDato_Variable.MaxLength = 350
        Me.txtDato_Variable.Multiline = True
        Me.txtDato_Variable.Name = "txtDato_Variable"
        Me.txtDato_Variable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDato_Variable.Size = New System.Drawing.Size(282, 109)
        Me.txtDato_Variable.TabIndex = 130
        Me.txtDato_Variable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(115, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 131
        Me.Label23.Text = "Dato Variable"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboModo_Impresion_Digital
        '
        Me.cboModo_Impresion_Digital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModo_Impresion_Digital.FormattingEnabled = True
        Me.cboModo_Impresion_Digital.Items.AddRange(New Object() {"Tire y Retire", "Frente y Dorso", "Frente", "Pinza y Contrapinza"})
        Me.cboModo_Impresion_Digital.Location = New System.Drawing.Point(117, 151)
        Me.cboModo_Impresion_Digital.Name = "cboModo_Impresion_Digital"
        Me.cboModo_Impresion_Digital.Size = New System.Drawing.Size(138, 21)
        Me.cboModo_Impresion_Digital.TabIndex = 128
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Modo Impresión"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(188, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 13)
        Me.Label26.TabIndex = 141
        Me.Label26.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(91, 29)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(11, 13)
        Me.Label28.TabIndex = 140
        Me.Label28.Text = "*"
        '
        'cboPiezas_Producto_Gran_Formato
        '
        Me.cboPiezas_Producto_Gran_Formato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiezas_Producto_Gran_Formato.FormattingEnabled = True
        Me.cboPiezas_Producto_Gran_Formato.Location = New System.Drawing.Point(106, 48)
        Me.cboPiezas_Producto_Gran_Formato.Name = "cboPiezas_Producto_Gran_Formato"
        Me.cboPiezas_Producto_Gran_Formato.Size = New System.Drawing.Size(168, 21)
        Me.cboPiezas_Producto_Gran_Formato.TabIndex = 133
        '
        'cboCalidad_Gran_Formato
        '
        Me.cboCalidad_Gran_Formato.FormattingEnabled = True
        Me.cboCalidad_Gran_Formato.Items.AddRange(New Object() {"Cartelería", "Alta", "Premium"})
        Me.cboCalidad_Gran_Formato.Location = New System.Drawing.Point(106, 115)
        Me.cboCalidad_Gran_Formato.Name = "cboCalidad_Gran_Formato"
        Me.cboCalidad_Gran_Formato.Size = New System.Drawing.Size(123, 21)
        Me.cboCalidad_Gran_Formato.TabIndex = 135
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(58, 118)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 13)
        Me.Label29.TabIndex = 139
        Me.Label29.Text = "Calidad"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(286, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 13)
        Me.Label30.TabIndex = 136
        Me.Label30.Text = "Tamaño (°°° x °°° Mm)"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(152, 26)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 13)
        Me.Label31.TabIndex = 137
        Me.Label31.Text = "Piezas"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(45, 26)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 13)
        Me.Label32.TabIndex = 138
        Me.Label32.Text = "Cantidad"
        '
        'txtTamaño_Producto_Gran_Formato
        '
        Me.txtTamaño_Producto_Gran_Formato.Location = New System.Drawing.Point(282, 49)
        Me.txtTamaño_Producto_Gran_Formato.MaxLength = 50
        Me.txtTamaño_Producto_Gran_Formato.Name = "txtTamaño_Producto_Gran_Formato"
        Me.txtTamaño_Producto_Gran_Formato.Size = New System.Drawing.Size(123, 20)
        Me.txtTamaño_Producto_Gran_Formato.TabIndex = 134
        '
        'txt_cantidad_producto_Gran_Formato
        '
        Me.txt_cantidad_producto_Gran_Formato.Location = New System.Drawing.Point(41, 48)
        Me.txt_cantidad_producto_Gran_Formato.Name = "txt_cantidad_producto_Gran_Formato"
        Me.txt_cantidad_producto_Gran_Formato.Size = New System.Drawing.Size(59, 20)
        Me.txt_cantidad_producto_Gran_Formato.TabIndex = 132
        '
        'cboSistema_Gran_Formato
        '
        Me.cboSistema_Gran_Formato.FormattingEnabled = True
        Me.cboSistema_Gran_Formato.Items.AddRange(New Object() {"Solvente", "Latex", "UV"})
        Me.cboSistema_Gran_Formato.Location = New System.Drawing.Point(294, 115)
        Me.cboSistema_Gran_Formato.Name = "cboSistema_Gran_Formato"
        Me.cboSistema_Gran_Formato.Size = New System.Drawing.Size(111, 21)
        Me.cboSistema_Gran_Formato.TabIndex = 143
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(242, 118)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 13)
        Me.Label33.TabIndex = 144
        Me.Label33.Text = "Sistema"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(54, 89)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(46, 13)
        Me.Label40.TabIndex = 146
        Me.Label40.Text = "Sustrato"
        '
        'txtSustrato_Gran_Formato
        '
        Me.txtSustrato_Gran_Formato.Location = New System.Drawing.Point(106, 86)
        Me.txtSustrato_Gran_Formato.MaxLength = 50
        Me.txtSustrato_Gran_Formato.Name = "txtSustrato_Gran_Formato"
        Me.txtSustrato_Gran_Formato.Size = New System.Drawing.Size(299, 20)
        Me.txtSustrato_Gran_Formato.TabIndex = 145
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtSustrato_Gran_Formato)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Controls.Add(Me.txt_cantidad_producto_Gran_Formato)
        Me.GroupBox9.Controls.Add(Me.txtTamaño_Producto_Gran_Formato)
        Me.GroupBox9.Controls.Add(Me.cboSistema_Gran_Formato)
        Me.GroupBox9.Controls.Add(Me.Label32)
        Me.GroupBox9.Controls.Add(Me.Label33)
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.Label28)
        Me.GroupBox9.Controls.Add(Me.cboCalidad_Gran_Formato)
        Me.GroupBox9.Controls.Add(Me.cboPiezas_Producto_Gran_Formato)
        Me.GroupBox9.Location = New System.Drawing.Point(631, 210)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(437, 146)
        Me.GroupBox9.TabIndex = 147
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Gran Formato"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkPosicionado)
        Me.GroupBox10.Controls.Add(Me.chkMedio_Corte)
        Me.GroupBox10.Controls.Add(Me.chkSoldado)
        Me.GroupBox10.Controls.Add(Me.chkRuedo)
        Me.GroupBox10.Controls.Add(Me.chkCocido)
        Me.GroupBox10.Controls.Add(Me.chkOtros)
        Me.GroupBox10.Controls.Add(Me.chkMontado)
        Me.GroupBox10.Controls.Add(Me.chkTrazado)
        Me.GroupBox10.Controls.Add(Me.chkDoblado)
        Me.GroupBox10.Controls.Add(Me.chkStamping)
        Me.GroupBox10.Controls.Add(Me.chkEncuadernacion)
        Me.GroupBox10.Controls.Add(Me.chkAdhesivado)
        Me.GroupBox10.Controls.Add(Me.chkPolipropileno)
        Me.GroupBox10.Controls.Add(Me.chkCorte)
        Me.GroupBox10.Controls.Add(Me.chkTroquelado)
        Me.GroupBox10.Controls.Add(Me.chkBarniz)
        Me.GroupBox10.Controls.Add(Me.chkLaca_UV)
        Me.GroupBox10.Controls.Add(Me.txt_descripcion_terminacion)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Location = New System.Drawing.Point(631, 371)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(437, 324)
        Me.GroupBox10.TabIndex = 148
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Terminación"
        '
        'chkPosicionado
        '
        Me.chkPosicionado.AutoSize = True
        Me.chkPosicionado.Location = New System.Drawing.Point(326, 146)
        Me.chkPosicionado.Name = "chkPosicionado"
        Me.chkPosicionado.Size = New System.Drawing.Size(84, 17)
        Me.chkPosicionado.TabIndex = 152
        Me.chkPosicionado.Text = "Posicionado"
        Me.chkPosicionado.UseVisualStyleBackColor = True
        '
        'chkMedio_Corte
        '
        Me.chkMedio_Corte.AutoSize = True
        Me.chkMedio_Corte.Location = New System.Drawing.Point(114, 72)
        Me.chkMedio_Corte.Name = "chkMedio_Corte"
        Me.chkMedio_Corte.Size = New System.Drawing.Size(83, 17)
        Me.chkMedio_Corte.TabIndex = 151
        Me.chkMedio_Corte.Text = "Medio Corte"
        Me.chkMedio_Corte.UseVisualStyleBackColor = True
        '
        'chkSoldado
        '
        Me.chkSoldado.AutoSize = True
        Me.chkSoldado.Location = New System.Drawing.Point(20, 145)
        Me.chkSoldado.Name = "chkSoldado"
        Me.chkSoldado.Size = New System.Drawing.Size(65, 17)
        Me.chkSoldado.TabIndex = 150
        Me.chkSoldado.Text = "Soldado"
        Me.chkSoldado.UseVisualStyleBackColor = True
        '
        'chkRuedo
        '
        Me.chkRuedo.AutoSize = True
        Me.chkRuedo.Location = New System.Drawing.Point(224, 145)
        Me.chkRuedo.Name = "chkRuedo"
        Me.chkRuedo.Size = New System.Drawing.Size(58, 17)
        Me.chkRuedo.TabIndex = 149
        Me.chkRuedo.Text = "Ruedo"
        Me.chkRuedo.UseVisualStyleBackColor = True
        '
        'chkCocido
        '
        Me.chkCocido.AutoSize = True
        Me.chkCocido.Location = New System.Drawing.Point(114, 145)
        Me.chkCocido.Name = "chkCocido"
        Me.chkCocido.Size = New System.Drawing.Size(59, 17)
        Me.chkCocido.TabIndex = 148
        Me.chkCocido.Text = "Cocido"
        Me.chkCocido.UseVisualStyleBackColor = True
        '
        'chkOtros
        '
        Me.chkOtros.AutoSize = True
        Me.chkOtros.Location = New System.Drawing.Point(20, 181)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(51, 17)
        Me.chkOtros.TabIndex = 147
        Me.chkOtros.Text = "Otros"
        Me.chkOtros.UseVisualStyleBackColor = True
        '
        'chkMontado
        '
        Me.chkMontado.AutoSize = True
        Me.chkMontado.Location = New System.Drawing.Point(20, 108)
        Me.chkMontado.Name = "chkMontado"
        Me.chkMontado.Size = New System.Drawing.Size(68, 17)
        Me.chkMontado.TabIndex = 147
        Me.chkMontado.Text = "Montado"
        Me.chkMontado.UseVisualStyleBackColor = True
        '
        'chkTrazado
        '
        Me.chkTrazado.AutoSize = True
        Me.chkTrazado.Location = New System.Drawing.Point(326, 108)
        Me.chkTrazado.Name = "chkTrazado"
        Me.chkTrazado.Size = New System.Drawing.Size(65, 17)
        Me.chkTrazado.TabIndex = 147
        Me.chkTrazado.Text = "Trazado"
        Me.chkTrazado.UseVisualStyleBackColor = True
        '
        'chkDoblado
        '
        Me.chkDoblado.AutoSize = True
        Me.chkDoblado.Location = New System.Drawing.Point(224, 37)
        Me.chkDoblado.Name = "chkDoblado"
        Me.chkDoblado.Size = New System.Drawing.Size(66, 17)
        Me.chkDoblado.TabIndex = 147
        Me.chkDoblado.Text = "Doblado"
        Me.chkDoblado.UseVisualStyleBackColor = True
        '
        'chkStamping
        '
        Me.chkStamping.AutoSize = True
        Me.chkStamping.Location = New System.Drawing.Point(224, 108)
        Me.chkStamping.Name = "chkStamping"
        Me.chkStamping.Size = New System.Drawing.Size(70, 17)
        Me.chkStamping.TabIndex = 147
        Me.chkStamping.Text = "Stamping"
        Me.chkStamping.UseVisualStyleBackColor = True
        '
        'chkEncuadernacion
        '
        Me.chkEncuadernacion.AutoSize = True
        Me.chkEncuadernacion.Location = New System.Drawing.Point(114, 108)
        Me.chkEncuadernacion.Name = "chkEncuadernacion"
        Me.chkEncuadernacion.Size = New System.Drawing.Size(104, 17)
        Me.chkEncuadernacion.TabIndex = 147
        Me.chkEncuadernacion.Text = "Encuadernación"
        Me.chkEncuadernacion.UseVisualStyleBackColor = True
        '
        'chkAdhesivado
        '
        Me.chkAdhesivado.AutoSize = True
        Me.chkAdhesivado.Location = New System.Drawing.Point(326, 72)
        Me.chkAdhesivado.Name = "chkAdhesivado"
        Me.chkAdhesivado.Size = New System.Drawing.Size(82, 17)
        Me.chkAdhesivado.TabIndex = 147
        Me.chkAdhesivado.Text = "Adhesivado"
        Me.chkAdhesivado.UseVisualStyleBackColor = True
        '
        'chkPolipropileno
        '
        Me.chkPolipropileno.AutoSize = True
        Me.chkPolipropileno.Location = New System.Drawing.Point(224, 72)
        Me.chkPolipropileno.Name = "chkPolipropileno"
        Me.chkPolipropileno.Size = New System.Drawing.Size(86, 17)
        Me.chkPolipropileno.TabIndex = 147
        Me.chkPolipropileno.Text = "Polipropileno"
        Me.chkPolipropileno.UseVisualStyleBackColor = True
        '
        'chkCorte
        '
        Me.chkCorte.AutoSize = True
        Me.chkCorte.Location = New System.Drawing.Point(20, 72)
        Me.chkCorte.Name = "chkCorte"
        Me.chkCorte.Size = New System.Drawing.Size(51, 17)
        Me.chkCorte.TabIndex = 147
        Me.chkCorte.Text = "Corte"
        Me.chkCorte.UseVisualStyleBackColor = True
        '
        'chkTroquelado
        '
        Me.chkTroquelado.AutoSize = True
        Me.chkTroquelado.Location = New System.Drawing.Point(326, 37)
        Me.chkTroquelado.Name = "chkTroquelado"
        Me.chkTroquelado.Size = New System.Drawing.Size(80, 17)
        Me.chkTroquelado.TabIndex = 147
        Me.chkTroquelado.Text = "Troquelado"
        Me.chkTroquelado.UseVisualStyleBackColor = True
        '
        'chkBarniz
        '
        Me.chkBarniz.AutoSize = True
        Me.chkBarniz.Location = New System.Drawing.Point(114, 37)
        Me.chkBarniz.Name = "chkBarniz"
        Me.chkBarniz.Size = New System.Drawing.Size(55, 17)
        Me.chkBarniz.TabIndex = 147
        Me.chkBarniz.Text = "Barniz"
        Me.chkBarniz.UseVisualStyleBackColor = True
        '
        'chkLaca_UV
        '
        Me.chkLaca_UV.AutoSize = True
        Me.chkLaca_UV.Location = New System.Drawing.Point(20, 37)
        Me.chkLaca_UV.Name = "chkLaca_UV"
        Me.chkLaca_UV.Size = New System.Drawing.Size(68, 17)
        Me.chkLaca_UV.TabIndex = 147
        Me.chkLaca_UV.Text = "Laca UV"
        Me.chkLaca_UV.UseVisualStyleBackColor = True
        '
        'txt_descripcion_terminacion
        '
        Me.txt_descripcion_terminacion.Location = New System.Drawing.Point(99, 213)
        Me.txt_descripcion_terminacion.MaxLength = 350
        Me.txt_descripcion_terminacion.Multiline = True
        Me.txt_descripcion_terminacion.Name = "txt_descripcion_terminacion"
        Me.txt_descripcion_terminacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcion_terminacion.Size = New System.Drawing.Size(332, 94)
        Me.txt_descripcion_terminacion.TabIndex = 145
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 146
        Me.Label12.Text = "Descripción"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label49)
        Me.GroupBox11.Controls.Add(Me.Label48)
        Me.GroupBox11.Controls.Add(Me.cboPiezas_Producto)
        Me.GroupBox11.Controls.Add(Me.Label7)
        Me.GroupBox11.Controls.Add(Me.Label3)
        Me.GroupBox11.Controls.Add(Me.Label2)
        Me.GroupBox11.Controls.Add(Me.txtTamaño_Producto)
        Me.GroupBox11.Controls.Add(Me.txt_cantidad_producto)
        Me.GroupBox11.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(613, 69)
        Me.GroupBox11.TabIndex = 149
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Producto"
        '
        'frm_Orden_Trabajo_Ampliada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 796)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.cboTipo_Orden)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnImprimirFormulario)
        Me.Controls.Add(Me.btnGuardar_Orden_Trabajo)
        Me.Controls.Add(Me.btnCancelar_Orden_Trabajo)
        Me.Controls.Add(Me.btnActualizar_Orden_Trabajo)
        Me.Controls.Add(Me.btnNueva_Orden_Trabajo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_id_orden_trabajo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Orden_Trabajo_Ampliada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Orden_Trabajo_Ampliada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Entrega_ODT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents btnImprimirFormulario As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents txt_id_detalle_orden_trabajo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño_Producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_producto As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnActualizar_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents btnNueva_Orden_Trabajo As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_Orden_Trabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents txt_id_orden_trabajo As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Ingreso_ODT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents txtNombre_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtid_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTerminacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkDigital As System.Windows.Forms.CheckBox
    Friend WithEvents chkGranFormato As System.Windows.Forms.CheckBox
    Friend WithEvents chkOffset As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Gramaje_3_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel_3_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Gramaje_2_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel_2_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_Gramaje_1_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Papel_1_Soporte As System.Windows.Forms.TextBox
    Friend WithEvents cboModo_Impresion_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato_3_Pliego_Maquina_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_1_Pliego_Maquina_Offset As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cboFormato_2_Pliego_Maquina_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad_3_Pliego_Maquina_Offset As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato_1_Pliego_Maquina_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_2_Pliego_Maquina_Offset As System.Windows.Forms.TextBox
    Friend WithEvents txtChapas_Offset As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents cboDireccion_Entrega As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato_3_Pliego_Entero As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad_1_Pliego_Entero As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad_2_Pliego_Entero As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad_3_Pliego_Entero As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato_1_Pliego_Entero As System.Windows.Forms.ComboBox
    Friend WithEvents cboFormato_2_Pliego_Entero As System.Windows.Forms.ComboBox
    Friend WithEvents cboImpresora_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboModo_Impresion_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDato_Variable As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cboPiezas_Producto_Gran_Formato As System.Windows.Forms.ComboBox
    Friend WithEvents cboCalidad_Gran_Formato As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTamaño_Producto_Gran_Formato As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_producto_Gran_Formato As System.Windows.Forms.TextBox
    Friend WithEvents cboSistema_Gran_Formato As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtSustrato_Gran_Formato As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion_terminacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkDoblado As System.Windows.Forms.CheckBox
    Friend WithEvents chkBarniz As System.Windows.Forms.CheckBox
    Friend WithEvents chkLaca_UV As System.Windows.Forms.CheckBox
    Friend WithEvents chkMontado As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrazado As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdhesivado As System.Windows.Forms.CheckBox
    Friend WithEvents chkPolipropileno As System.Windows.Forms.CheckBox
    Friend WithEvents chkCorte As System.Windows.Forms.CheckBox
    Friend WithEvents chkTroquelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkStamping As System.Windows.Forms.CheckBox
    Friend WithEvents chkEncuadernacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkPosicionado As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedio_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents chkSoldado As System.Windows.Forms.CheckBox
    Friend WithEvents chkRuedo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCocido As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFormato_3_Pliego_Maquina_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_1_Pliego_Maquina_Digital As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboFormato_2_Pliego_Maquina_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad_3_Pliego_Maquina_Digital As System.Windows.Forms.TextBox
    Friend WithEvents cboFormato_1_Pliego_Maquina_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad_2_Pliego_Maquina_Digital As System.Windows.Forms.TextBox
    Friend WithEvents cboTipo_Impresion_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cboTipo_Impresion_Digital As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cboTipo_Orden As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class