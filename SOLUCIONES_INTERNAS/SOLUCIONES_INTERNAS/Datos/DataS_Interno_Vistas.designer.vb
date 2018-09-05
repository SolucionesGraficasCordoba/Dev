﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="SOLUCIONES_INTERNAS")>  _
Partial Public Class DataS_Interno_Vistas
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.SOLUCIONES_INTERNAS.My.MySettings.Default.SOLUCIONES_INTERNASConnectionString1, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property VistaTareas() As System.Data.Linq.Table(Of VistaTareas)
		Get
			Return Me.GetTable(Of VistaTareas)
		End Get
	End Property
	
	Public ReadOnly Property Vista_Tarea_x_Colaborador() As System.Data.Linq.Table(Of Vista_Tarea_x_Colaborador)
		Get
			Return Me.GetTable(Of Vista_Tarea_x_Colaborador)
		End Get
	End Property
	
	Public ReadOnly Property Vista_Detalle_Orden_Trabajo() As System.Data.Linq.Table(Of Vista_Detalle_Orden_Trabajo)
		Get
			Return Me.GetTable(Of Vista_Detalle_Orden_Trabajo)
		End Get
	End Property
	
	Public ReadOnly Property Colaborador_por_Sector() As System.Data.Linq.Table(Of Colaborador_por_Sector)
		Get
			Return Me.GetTable(Of Colaborador_por_Sector)
		End Get
	End Property
	
	Public ReadOnly Property Tiempos_x_Sector() As System.Data.Linq.Table(Of Tiempos_x_Sector)
		Get
			Return Me.GetTable(Of Tiempos_x_Sector)
		End Get
	End Property
	
	Public ReadOnly Property Tiempos_Totales() As System.Data.Linq.Table(Of Tiempos_Totales)
		Get
			Return Me.GetTable(Of Tiempos_Totales)
		End Get
	End Property
	
	Public ReadOnly Property Totales_mensuales() As System.Data.Linq.Table(Of Totales_mensuales)
		Get
			Return Me.GetTable(Of Totales_mensuales)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.VistaTareas")>  _
Partial Public Class VistaTareas
	
	Private _SEC_id_sector As System.Nullable(Of Integer)
	
	Private _SEC_nombre_sector As String
	
	Private _COL_id_colaborador As Integer
	
	Private _COL_nombre_col As String
	
	Private _TAR_id_tarea As Integer
	
	Private _TAR_detalle_tarea As String
	
	Private _TAR_fecha As System.Nullable(Of Date)
	
	Private _ORT_id_orden_trabajo As System.Nullable(Of Integer)
	
	Private _ORT_numero_ot As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_id_sector", DbType:="Int")>  _
	Public Property SEC_id_sector() As System.Nullable(Of Integer)
		Get
			Return Me._SEC_id_sector
		End Get
		Set
			If (Me._SEC_id_sector.Equals(value) = false) Then
				Me._SEC_id_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_nombre_sector", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SEC_nombre_sector() As String
		Get
			Return Me._SEC_nombre_sector
		End Get
		Set
			If (String.Equals(Me._SEC_nombre_sector, value) = false) Then
				Me._SEC_nombre_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_id_colaborador", DbType:="Int NOT NULL")>  _
	Public Property COL_id_colaborador() As Integer
		Get
			Return Me._COL_id_colaborador
		End Get
		Set
			If ((Me._COL_id_colaborador = value)  _
						= false) Then
				Me._COL_id_colaborador = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_nombre_col", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property COL_nombre_col() As String
		Get
			Return Me._COL_nombre_col
		End Get
		Set
			If (String.Equals(Me._COL_nombre_col, value) = false) Then
				Me._COL_nombre_col = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_id_tarea", DbType:="Int NOT NULL")>  _
	Public Property TAR_id_tarea() As Integer
		Get
			Return Me._TAR_id_tarea
		End Get
		Set
			If ((Me._TAR_id_tarea = value)  _
						= false) Then
				Me._TAR_id_tarea = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_detalle_tarea", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property TAR_detalle_tarea() As String
		Get
			Return Me._TAR_detalle_tarea
		End Get
		Set
			If (String.Equals(Me._TAR_detalle_tarea, value) = false) Then
				Me._TAR_detalle_tarea = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_fecha", DbType:="Date")>  _
	Public Property TAR_fecha() As System.Nullable(Of Date)
		Get
			Return Me._TAR_fecha
		End Get
		Set
			If (Me._TAR_fecha.Equals(value) = false) Then
				Me._TAR_fecha = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_id_orden_trabajo", DbType:="Int")>  _
	Public Property ORT_id_orden_trabajo() As System.Nullable(Of Integer)
		Get
			Return Me._ORT_id_orden_trabajo
		End Get
		Set
			If (Me._ORT_id_orden_trabajo.Equals(value) = false) Then
				Me._ORT_id_orden_trabajo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_numero_ot", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property ORT_numero_ot() As String
		Get
			Return Me._ORT_numero_ot
		End Get
		Set
			If (String.Equals(Me._ORT_numero_ot, value) = false) Then
				Me._ORT_numero_ot = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Vista_Tarea_x_Colaborador")>  _
Partial Public Class Vista_Tarea_x_Colaborador
	
	Private _Expr1 As Integer
	
	Private _COL_nombre_col As String
	
	Private _SEC_id_sector As Integer
	
	Private _SEC_nombre_sector As String
	
	Private _ORT_numero_ot As String
	
	Private _TAR_id_tarea As Integer
	
	Private _TAR_tiempo_estimado As String
	
	Private _TAR_tiempo_real As String
	
	Private _ORT_id_orden_trabajo As System.Nullable(Of Integer)
	
	Private _TAR_hora_fin As String
	
	Private _TAR_carga_horaria As String
	
	Private _TAR_detalle_tarea As String
	
	Private _TAR_observaciones As String
	
	Private _TAR_fecha As System.Nullable(Of Date)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Expr1", DbType:="Int NOT NULL")>  _
	Public Property Expr1() As Integer
		Get
			Return Me._Expr1
		End Get
		Set
			If ((Me._Expr1 = value)  _
						= false) Then
				Me._Expr1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_nombre_col", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property COL_nombre_col() As String
		Get
			Return Me._COL_nombre_col
		End Get
		Set
			If (String.Equals(Me._COL_nombre_col, value) = false) Then
				Me._COL_nombre_col = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_id_sector", DbType:="Int NOT NULL")>  _
	Public Property SEC_id_sector() As Integer
		Get
			Return Me._SEC_id_sector
		End Get
		Set
			If ((Me._SEC_id_sector = value)  _
						= false) Then
				Me._SEC_id_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_nombre_sector", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SEC_nombre_sector() As String
		Get
			Return Me._SEC_nombre_sector
		End Get
		Set
			If (String.Equals(Me._SEC_nombre_sector, value) = false) Then
				Me._SEC_nombre_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_numero_ot", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property ORT_numero_ot() As String
		Get
			Return Me._ORT_numero_ot
		End Get
		Set
			If (String.Equals(Me._ORT_numero_ot, value) = false) Then
				Me._ORT_numero_ot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_id_tarea", DbType:="Int NOT NULL")>  _
	Public Property TAR_id_tarea() As Integer
		Get
			Return Me._TAR_id_tarea
		End Get
		Set
			If ((Me._TAR_id_tarea = value)  _
						= false) Then
				Me._TAR_id_tarea = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_tiempo_estimado", DbType:="VarChar(10)")>  _
	Public Property TAR_tiempo_estimado() As String
		Get
			Return Me._TAR_tiempo_estimado
		End Get
		Set
			If (String.Equals(Me._TAR_tiempo_estimado, value) = false) Then
				Me._TAR_tiempo_estimado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_tiempo_real", DbType:="VarChar(10)")>  _
	Public Property TAR_tiempo_real() As String
		Get
			Return Me._TAR_tiempo_real
		End Get
		Set
			If (String.Equals(Me._TAR_tiempo_real, value) = false) Then
				Me._TAR_tiempo_real = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_id_orden_trabajo", DbType:="Int")>  _
	Public Property ORT_id_orden_trabajo() As System.Nullable(Of Integer)
		Get
			Return Me._ORT_id_orden_trabajo
		End Get
		Set
			If (Me._ORT_id_orden_trabajo.Equals(value) = false) Then
				Me._ORT_id_orden_trabajo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_hora_fin", DbType:="VarChar(10)")>  _
	Public Property TAR_hora_fin() As String
		Get
			Return Me._TAR_hora_fin
		End Get
		Set
			If (String.Equals(Me._TAR_hora_fin, value) = false) Then
				Me._TAR_hora_fin = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_carga_horaria", DbType:="VarChar(10)")>  _
	Public Property TAR_carga_horaria() As String
		Get
			Return Me._TAR_carga_horaria
		End Get
		Set
			If (String.Equals(Me._TAR_carga_horaria, value) = false) Then
				Me._TAR_carga_horaria = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_detalle_tarea", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property TAR_detalle_tarea() As String
		Get
			Return Me._TAR_detalle_tarea
		End Get
		Set
			If (String.Equals(Me._TAR_detalle_tarea, value) = false) Then
				Me._TAR_detalle_tarea = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_observaciones", DbType:="VarChar(200)")>  _
	Public Property TAR_observaciones() As String
		Get
			Return Me._TAR_observaciones
		End Get
		Set
			If (String.Equals(Me._TAR_observaciones, value) = false) Then
				Me._TAR_observaciones = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_fecha", DbType:="Date")>  _
	Public Property TAR_fecha() As System.Nullable(Of Date)
		Get
			Return Me._TAR_fecha
		End Get
		Set
			If (Me._TAR_fecha.Equals(value) = false) Then
				Me._TAR_fecha = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Vista_Detalle_Orden_Trabajo")>  _
Partial Public Class Vista_Detalle_Orden_Trabajo
	
	Private _ORT_id_orden_trabajo As System.Nullable(Of Integer)
	
	Private _ORT_tipo_ot As String
	
	Private _ORT_numero_ot As String
	
	Private _ORT_observaciones_ot As String
	
	Private _VEN_id_vendedor As Integer
	
	Private _VEN_nombre_ven As String
	
	Private _CLI_id_cliente As Integer
	
	Private _CLI_razon_social As String
	
	Private _PIE_id_pieza As Integer
	
	Private _PIE_nombre_pie As String
	
	Private _id_detalle_orden_trabajo As Integer
	
	Private _DOT_cantidad_dot As System.Nullable(Of Integer)
	
	Private _DOT_tamaño_dot As String
	
	Private _DOT_tipo_impresion_dot As String
	
	Private _DOT_papel_soporte_1 As String
	
	Private _DOT_papel_soporte_2 As String
	
	Private _DOT_papel_soporte_3 As String
	
	Private _DOT_gramaje_soporte_1 As System.Nullable(Of Integer)
	
	Private _DOT_gramaje_soporte_2 As System.Nullable(Of Integer)
	
	Private _DOT_gramaje_soporte_3 As System.Nullable(Of Integer)
	
	Private _DOT_cantidad_soporte_1 As System.Nullable(Of Integer)
	
	Private _DOT_cantidad_soporte_2 As System.Nullable(Of Integer)
	
	Private _DOT_cantidad_soporte_3 As System.Nullable(Of Integer)
	
	Private _DOT_formato_soporte_1 As String
	
	Private _DOT_formato_soporte_2 As String
	
	Private _DOT_formato_soporte_3 As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_id_orden_trabajo", DbType:="Int")>  _
	Public Property ORT_id_orden_trabajo() As System.Nullable(Of Integer)
		Get
			Return Me._ORT_id_orden_trabajo
		End Get
		Set
			If (Me._ORT_id_orden_trabajo.Equals(value) = false) Then
				Me._ORT_id_orden_trabajo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_tipo_ot", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property ORT_tipo_ot() As String
		Get
			Return Me._ORT_tipo_ot
		End Get
		Set
			If (String.Equals(Me._ORT_tipo_ot, value) = false) Then
				Me._ORT_tipo_ot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_numero_ot", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property ORT_numero_ot() As String
		Get
			Return Me._ORT_numero_ot
		End Get
		Set
			If (String.Equals(Me._ORT_numero_ot, value) = false) Then
				Me._ORT_numero_ot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ORT_observaciones_ot", DbType:="VarChar(250)")>  _
	Public Property ORT_observaciones_ot() As String
		Get
			Return Me._ORT_observaciones_ot
		End Get
		Set
			If (String.Equals(Me._ORT_observaciones_ot, value) = false) Then
				Me._ORT_observaciones_ot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VEN_id_vendedor", DbType:="Int NOT NULL")>  _
	Public Property VEN_id_vendedor() As Integer
		Get
			Return Me._VEN_id_vendedor
		End Get
		Set
			If ((Me._VEN_id_vendedor = value)  _
						= false) Then
				Me._VEN_id_vendedor = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_VEN_nombre_ven", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property VEN_nombre_ven() As String
		Get
			Return Me._VEN_nombre_ven
		End Get
		Set
			If (String.Equals(Me._VEN_nombre_ven, value) = false) Then
				Me._VEN_nombre_ven = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_id_cliente", DbType:="Int NOT NULL")>  _
	Public Property CLI_id_cliente() As Integer
		Get
			Return Me._CLI_id_cliente
		End Get
		Set
			If ((Me._CLI_id_cliente = value)  _
						= false) Then
				Me._CLI_id_cliente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CLI_razon_social", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property CLI_razon_social() As String
		Get
			Return Me._CLI_razon_social
		End Get
		Set
			If (String.Equals(Me._CLI_razon_social, value) = false) Then
				Me._CLI_razon_social = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PIE_id_pieza", DbType:="Int NOT NULL")>  _
	Public Property PIE_id_pieza() As Integer
		Get
			Return Me._PIE_id_pieza
		End Get
		Set
			If ((Me._PIE_id_pieza = value)  _
						= false) Then
				Me._PIE_id_pieza = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PIE_nombre_pie", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property PIE_nombre_pie() As String
		Get
			Return Me._PIE_nombre_pie
		End Get
		Set
			If (String.Equals(Me._PIE_nombre_pie, value) = false) Then
				Me._PIE_nombre_pie = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_id_detalle_orden_trabajo", DbType:="Int NOT NULL")>  _
	Public Property id_detalle_orden_trabajo() As Integer
		Get
			Return Me._id_detalle_orden_trabajo
		End Get
		Set
			If ((Me._id_detalle_orden_trabajo = value)  _
						= false) Then
				Me._id_detalle_orden_trabajo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_cantidad_dot", DbType:="Int")>  _
	Public Property DOT_cantidad_dot() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_cantidad_dot
		End Get
		Set
			If (Me._DOT_cantidad_dot.Equals(value) = false) Then
				Me._DOT_cantidad_dot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_tamaño_dot", DbType:="VarChar(50)")>  _
	Public Property DOT_tamaño_dot() As String
		Get
			Return Me._DOT_tamaño_dot
		End Get
		Set
			If (String.Equals(Me._DOT_tamaño_dot, value) = false) Then
				Me._DOT_tamaño_dot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_tipo_impresion_dot", DbType:="VarChar(4)")>  _
	Public Property DOT_tipo_impresion_dot() As String
		Get
			Return Me._DOT_tipo_impresion_dot
		End Get
		Set
			If (String.Equals(Me._DOT_tipo_impresion_dot, value) = false) Then
				Me._DOT_tipo_impresion_dot = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_papel_soporte_1", DbType:="VarChar(50)")>  _
	Public Property DOT_papel_soporte_1() As String
		Get
			Return Me._DOT_papel_soporte_1
		End Get
		Set
			If (String.Equals(Me._DOT_papel_soporte_1, value) = false) Then
				Me._DOT_papel_soporte_1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_papel_soporte_2", DbType:="VarChar(50)")>  _
	Public Property DOT_papel_soporte_2() As String
		Get
			Return Me._DOT_papel_soporte_2
		End Get
		Set
			If (String.Equals(Me._DOT_papel_soporte_2, value) = false) Then
				Me._DOT_papel_soporte_2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_papel_soporte_3", DbType:="VarChar(50)")>  _
	Public Property DOT_papel_soporte_3() As String
		Get
			Return Me._DOT_papel_soporte_3
		End Get
		Set
			If (String.Equals(Me._DOT_papel_soporte_3, value) = false) Then
				Me._DOT_papel_soporte_3 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_gramaje_soporte_1", DbType:="Int")>  _
	Public Property DOT_gramaje_soporte_1() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_gramaje_soporte_1
		End Get
		Set
			If (Me._DOT_gramaje_soporte_1.Equals(value) = false) Then
				Me._DOT_gramaje_soporte_1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_gramaje_soporte_2", DbType:="Int")>  _
	Public Property DOT_gramaje_soporte_2() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_gramaje_soporte_2
		End Get
		Set
			If (Me._DOT_gramaje_soporte_2.Equals(value) = false) Then
				Me._DOT_gramaje_soporte_2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_gramaje_soporte_3", DbType:="Int")>  _
	Public Property DOT_gramaje_soporte_3() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_gramaje_soporte_3
		End Get
		Set
			If (Me._DOT_gramaje_soporte_3.Equals(value) = false) Then
				Me._DOT_gramaje_soporte_3 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_cantidad_soporte_1", DbType:="Int")>  _
	Public Property DOT_cantidad_soporte_1() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_cantidad_soporte_1
		End Get
		Set
			If (Me._DOT_cantidad_soporte_1.Equals(value) = false) Then
				Me._DOT_cantidad_soporte_1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_cantidad_soporte_2", DbType:="Int")>  _
	Public Property DOT_cantidad_soporte_2() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_cantidad_soporte_2
		End Get
		Set
			If (Me._DOT_cantidad_soporte_2.Equals(value) = false) Then
				Me._DOT_cantidad_soporte_2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_cantidad_soporte_3", DbType:="Int")>  _
	Public Property DOT_cantidad_soporte_3() As System.Nullable(Of Integer)
		Get
			Return Me._DOT_cantidad_soporte_3
		End Get
		Set
			If (Me._DOT_cantidad_soporte_3.Equals(value) = false) Then
				Me._DOT_cantidad_soporte_3 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_formato_soporte_1", DbType:="VarChar(15)")>  _
	Public Property DOT_formato_soporte_1() As String
		Get
			Return Me._DOT_formato_soporte_1
		End Get
		Set
			If (String.Equals(Me._DOT_formato_soporte_1, value) = false) Then
				Me._DOT_formato_soporte_1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_formato_soporte_2", DbType:="VarChar(15)")>  _
	Public Property DOT_formato_soporte_2() As String
		Get
			Return Me._DOT_formato_soporte_2
		End Get
		Set
			If (String.Equals(Me._DOT_formato_soporte_2, value) = false) Then
				Me._DOT_formato_soporte_2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOT_formato_soporte_3", DbType:="VarChar(15)")>  _
	Public Property DOT_formato_soporte_3() As String
		Get
			Return Me._DOT_formato_soporte_3
		End Get
		Set
			If (String.Equals(Me._DOT_formato_soporte_3, value) = false) Then
				Me._DOT_formato_soporte_3 = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Colaborador_por_Sector")>  _
Partial Public Class Colaborador_por_Sector
	
	Private _COL_id_colaborador As Integer
	
	Private _COL_nombre_col As String
	
	Private _SEC_id_sector As Integer
	
	Private _SEC_nombre_sector As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_id_colaborador", DbType:="Int NOT NULL")>  _
	Public Property COL_id_colaborador() As Integer
		Get
			Return Me._COL_id_colaborador
		End Get
		Set
			If ((Me._COL_id_colaborador = value)  _
						= false) Then
				Me._COL_id_colaborador = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_nombre_col", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property COL_nombre_col() As String
		Get
			Return Me._COL_nombre_col
		End Get
		Set
			If (String.Equals(Me._COL_nombre_col, value) = false) Then
				Me._COL_nombre_col = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_id_sector", DbType:="Int NOT NULL")>  _
	Public Property SEC_id_sector() As Integer
		Get
			Return Me._SEC_id_sector
		End Get
		Set
			If ((Me._SEC_id_sector = value)  _
						= false) Then
				Me._SEC_id_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_nombre_sector", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SEC_nombre_sector() As String
		Get
			Return Me._SEC_nombre_sector
		End Get
		Set
			If (String.Equals(Me._SEC_nombre_sector, value) = false) Then
				Me._SEC_nombre_sector = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Tiempos_x_Sector")>  _
Partial Public Class Tiempos_x_Sector
	
	Private _COL_id_colaborador As Integer
	
	Private _COL_nombre_col As String
	
	Private _TAR_id_tarea As Integer
	
	Private _TAR_tiempo_estimado As String
	
	Private _TAR_tiempo_real As String
	
	Private _TAR_carga_horaria As String
	
	Private _SEC_id_sector As System.Nullable(Of Integer)
	
	Private _TAR_fecha As System.Nullable(Of Date)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_id_colaborador", DbType:="Int NOT NULL")>  _
	Public Property COL_id_colaborador() As Integer
		Get
			Return Me._COL_id_colaborador
		End Get
		Set
			If ((Me._COL_id_colaborador = value)  _
						= false) Then
				Me._COL_id_colaborador = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_nombre_col", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property COL_nombre_col() As String
		Get
			Return Me._COL_nombre_col
		End Get
		Set
			If (String.Equals(Me._COL_nombre_col, value) = false) Then
				Me._COL_nombre_col = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_id_tarea", DbType:="Int NOT NULL")>  _
	Public Property TAR_id_tarea() As Integer
		Get
			Return Me._TAR_id_tarea
		End Get
		Set
			If ((Me._TAR_id_tarea = value)  _
						= false) Then
				Me._TAR_id_tarea = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_tiempo_estimado", DbType:="VarChar(10)")>  _
	Public Property TAR_tiempo_estimado() As String
		Get
			Return Me._TAR_tiempo_estimado
		End Get
		Set
			If (String.Equals(Me._TAR_tiempo_estimado, value) = false) Then
				Me._TAR_tiempo_estimado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_tiempo_real", DbType:="VarChar(10)")>  _
	Public Property TAR_tiempo_real() As String
		Get
			Return Me._TAR_tiempo_real
		End Get
		Set
			If (String.Equals(Me._TAR_tiempo_real, value) = false) Then
				Me._TAR_tiempo_real = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_carga_horaria", DbType:="VarChar(10)")>  _
	Public Property TAR_carga_horaria() As String
		Get
			Return Me._TAR_carga_horaria
		End Get
		Set
			If (String.Equals(Me._TAR_carga_horaria, value) = false) Then
				Me._TAR_carga_horaria = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_id_sector", DbType:="Int")>  _
	Public Property SEC_id_sector() As System.Nullable(Of Integer)
		Get
			Return Me._SEC_id_sector
		End Get
		Set
			If (Me._SEC_id_sector.Equals(value) = false) Then
				Me._SEC_id_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_fecha", DbType:="Date")>  _
	Public Property TAR_fecha() As System.Nullable(Of Date)
		Get
			Return Me._TAR_fecha
		End Get
		Set
			If (Me._TAR_fecha.Equals(value) = false) Then
				Me._TAR_fecha = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Tiempos_Totales")>  _
Partial Public Class Tiempos_Totales
	
	Private _COL_id_colaborador As Integer
	
	Private _COL_nombre_col As String
	
	Private _TAR_fecha As System.Nullable(Of Date)
	
	Private _Total_estimado As System.Nullable(Of Integer)
	
	Private _Total_real As System.Nullable(Of Integer)
	
	Private _SEC_id_sector As Integer
	
	Private _SEC_nombre_sector As String
	
	Private _Asignacion As System.Nullable(Of Integer)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_id_colaborador", DbType:="Int NOT NULL")>  _
	Public Property COL_id_colaborador() As Integer
		Get
			Return Me._COL_id_colaborador
		End Get
		Set
			If ((Me._COL_id_colaborador = value)  _
						= false) Then
				Me._COL_id_colaborador = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_nombre_col", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property COL_nombre_col() As String
		Get
			Return Me._COL_nombre_col
		End Get
		Set
			If (String.Equals(Me._COL_nombre_col, value) = false) Then
				Me._COL_nombre_col = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TAR_fecha", DbType:="Date")>  _
	Public Property TAR_fecha() As System.Nullable(Of Date)
		Get
			Return Me._TAR_fecha
		End Get
		Set
			If (Me._TAR_fecha.Equals(value) = false) Then
				Me._TAR_fecha = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Total estimado]", Storage:="_Total_estimado", DbType:="Int")>  _
	Public Property Total_estimado() As System.Nullable(Of Integer)
		Get
			Return Me._Total_estimado
		End Get
		Set
			If (Me._Total_estimado.Equals(value) = false) Then
				Me._Total_estimado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Total real]", Storage:="_Total_real", DbType:="Int")>  _
	Public Property Total_real() As System.Nullable(Of Integer)
		Get
			Return Me._Total_real
		End Get
		Set
			If (Me._Total_real.Equals(value) = false) Then
				Me._Total_real = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_id_sector", DbType:="Int NOT NULL")>  _
	Public Property SEC_id_sector() As Integer
		Get
			Return Me._SEC_id_sector
		End Get
		Set
			If ((Me._SEC_id_sector = value)  _
						= false) Then
				Me._SEC_id_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_nombre_sector", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SEC_nombre_sector() As String
		Get
			Return Me._SEC_nombre_sector
		End Get
		Set
			If (String.Equals(Me._SEC_nombre_sector, value) = false) Then
				Me._SEC_nombre_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Asignacion", DbType:="Int")>  _
	Public Property Asignacion() As System.Nullable(Of Integer)
		Get
			Return Me._Asignacion
		End Get
		Set
			If (Me._Asignacion.Equals(value) = false) Then
				Me._Asignacion = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Totales_mensuales")>  _
Partial Public Class Totales_mensuales
	
	Private _COL_id_colaborador As Integer
	
	Private _COL_nombre_col As String
	
	Private _Mes As System.Nullable(Of Integer)
	
	Private _SEC_id_sector As Integer
	
	Private _SEC_nombre_sector As String
	
	Private _Total_estimado_mensual As System.Nullable(Of Integer)
	
	Private _Total_real_mensual As System.Nullable(Of Integer)
	
	Private _Asignacion As System.Nullable(Of Integer)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_id_colaborador", DbType:="Int NOT NULL")>  _
	Public Property COL_id_colaborador() As Integer
		Get
			Return Me._COL_id_colaborador
		End Get
		Set
			If ((Me._COL_id_colaborador = value)  _
						= false) Then
				Me._COL_id_colaborador = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_COL_nombre_col", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property COL_nombre_col() As String
		Get
			Return Me._COL_nombre_col
		End Get
		Set
			If (String.Equals(Me._COL_nombre_col, value) = false) Then
				Me._COL_nombre_col = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Mes", DbType:="Int")>  _
	Public Property Mes() As System.Nullable(Of Integer)
		Get
			Return Me._Mes
		End Get
		Set
			If (Me._Mes.Equals(value) = false) Then
				Me._Mes = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_id_sector", DbType:="Int NOT NULL")>  _
	Public Property SEC_id_sector() As Integer
		Get
			Return Me._SEC_id_sector
		End Get
		Set
			If ((Me._SEC_id_sector = value)  _
						= false) Then
				Me._SEC_id_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SEC_nombre_sector", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SEC_nombre_sector() As String
		Get
			Return Me._SEC_nombre_sector
		End Get
		Set
			If (String.Equals(Me._SEC_nombre_sector, value) = false) Then
				Me._SEC_nombre_sector = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Total estimado mensual]", Storage:="_Total_estimado_mensual", DbType:="Int")>  _
	Public Property Total_estimado_mensual() As System.Nullable(Of Integer)
		Get
			Return Me._Total_estimado_mensual
		End Get
		Set
			If (Me._Total_estimado_mensual.Equals(value) = false) Then
				Me._Total_estimado_mensual = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Total real mensual]", Storage:="_Total_real_mensual", DbType:="Int")>  _
	Public Property Total_real_mensual() As System.Nullable(Of Integer)
		Get
			Return Me._Total_real_mensual
		End Get
		Set
			If (Me._Total_real_mensual.Equals(value) = false) Then
				Me._Total_real_mensual = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Asignacion", DbType:="Int")>  _
	Public Property Asignacion() As System.Nullable(Of Integer)
		Get
			Return Me._Asignacion
		End Get
		Set
			If (Me._Asignacion.Equals(value) = false) Then
				Me._Asignacion = value
			End If
		End Set
	End Property
End Class
