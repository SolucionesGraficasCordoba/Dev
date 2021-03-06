USE [master]
GO
/****** Object:  Database [PREPRODUCCION]    Script Date: 12/29/2018 09:26:00 ******/
CREATE DATABASE [PREPRODUCCION] ON  PRIMARY 
( NAME = N'SOLUCIONES_INTERNAS', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\PREPRODUCCION.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SOLUCIONES_INTERNAS_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\PREPRODUCCION_1.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PREPRODUCCION] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PREPRODUCCION].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PREPRODUCCION] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PREPRODUCCION] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PREPRODUCCION] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PREPRODUCCION] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PREPRODUCCION] SET ARITHABORT OFF
GO
ALTER DATABASE [PREPRODUCCION] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [PREPRODUCCION] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PREPRODUCCION] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PREPRODUCCION] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PREPRODUCCION] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PREPRODUCCION] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PREPRODUCCION] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PREPRODUCCION] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PREPRODUCCION] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PREPRODUCCION] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PREPRODUCCION] SET  DISABLE_BROKER
GO
ALTER DATABASE [PREPRODUCCION] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PREPRODUCCION] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PREPRODUCCION] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PREPRODUCCION] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PREPRODUCCION] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PREPRODUCCION] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PREPRODUCCION] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PREPRODUCCION] SET  READ_WRITE
GO
ALTER DATABASE [PREPRODUCCION] SET RECOVERY SIMPLE
GO
ALTER DATABASE [PREPRODUCCION] SET  MULTI_USER
GO
ALTER DATABASE [PREPRODUCCION] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PREPRODUCCION] SET DB_CHAINING OFF
GO
USE [PREPRODUCCION]
GO
/****** Object:  User [vheredia]    Script Date: 12/29/2018 09:26:00 ******/
CREATE USER [vheredia] FOR LOGIN [vheredia] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [preprensa1]    Script Date: 12/29/2018 09:26:00 ******/
CREATE USER [preprensa1] FOR LOGIN [preprensa1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [pbaldo]    Script Date: 12/29/2018 09:26:00 ******/
CREATE USER [pbaldo] FOR LOGIN [pbaldo] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [offset]    Script Date: 12/29/2018 09:26:00 ******/
CREATE USER [offset] FOR LOGIN [offset] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [lmonici]    Script Date: 12/29/2018 09:26:00 ******/
CREATE USER [lmonici] FOR LOGIN [lmonici] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Calidad]    Script Date: 12/29/2018 09:26:00 ******/
CREATE USER [Calidad] FOR LOGIN [Calidad] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[CLI_id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[CLI_razon_social] [varchar](50) NOT NULL,
	[CLI_mail_cli] [varchar](50) NULL,
	[CLI_telefono_cli] [varchar](15) NULL,
	[CLI_domicilio] [varchar](50) NULL,
	[CLI_localidad] [varchar](50) NULL,
	[CLI_codigo_postal] [varchar](10) NULL,
 CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[CLI_id_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[PROD_id] [int] IDENTITY(1,1) NOT NULL,
	[PROD_codigo] [varchar](15) NULL,
	[PROD_descripcion] [varchar](50) NOT NULL,
	[PROD_stock] [int] NOT NULL,
	[PROD_stock_minimo] [int] NULL,
 CONSTRAINT [PK_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[PROD_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SECTOR]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SECTOR](
	[SEC_id_sector] [int] IDENTITY(1,1) NOT NULL,
	[SEC_nombre_sector] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[SEC_id_sector] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDEDOR]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDEDOR](
	[VEN_id_vendedor] [int] IDENTITY(1,1) NOT NULL,
	[VEN_nombre_ven] [varchar](50) NOT NULL,
	[VEN_apellido_ven] [varchar](50) NOT NULL,
	[VEN_mail_ven] [varchar](50) NULL,
	[VEN_telefono_ven] [varchar](15) NULL,
 CONSTRAINT [PK_VENDEDOR] PRIMARY KEY CLUSTERED 
(
	[VEN_id_vendedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PIEZA]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PIEZA](
	[PIE_id_pieza] [int] IDENTITY(1,1) NOT NULL,
	[PIE_nombre_pie] [varchar](30) NOT NULL,
	[PIE_ubicacion] [varchar](1) NULL,
 CONSTRAINT [PK_PIEZA] PRIMARY KEY CLUSTERED 
(
	[PIE_id_pieza] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERMISO]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERMISO](
	[PER_id_permiso] [int] IDENTITY(1,1) NOT NULL,
	[PER_permiso] [varchar](20) NULL,
	[PER_abm] [varchar](5) NULL,
	[USU_id_usuario] [int] NULL,
 CONSTRAINT [PK_PERMISO] PRIMARY KEY CLUSTERED 
(
	[PER_id_permiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ORDEN_TRABAJO]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORDEN_TRABAJO](
	[ORT_id_orden_trabajo] [int] IDENTITY(1,1) NOT NULL,
	[ORT_fecha_ot] [date] NOT NULL,
	[ORT_tipo_ot] [varchar](10) NOT NULL,
	[ORT_numero_ot] [varchar](10) NOT NULL,
	[ORT_observaciones_ot] [varchar](350) NULL,
	[ORT_mejoras_ot] [varchar](250) NULL,
	[VEN_id_vendedor] [int] NOT NULL,
	[CLI_id_cliente] [int] NOT NULL,
	[ORT_fecha_entrega] [date] NULL,
 CONSTRAINT [PK_ORDEN_TRABAJO] PRIMARY KEY CLUSTERED 
(
	[ORT_id_orden_trabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COLABORADOR]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COLABORADOR](
	[COL_id_colaborador] [int] IDENTITY(1,1) NOT NULL,
	[COL_nombre_col] [varchar](50) NOT NULL,
	[COL_apellido_col] [varchar](50) NULL,
	[SEC_id_sector] [int] NULL,
 CONSTRAINT [PK_COLABORADOR] PRIMARY KEY CLUSTERED 
(
	[COL_id_colaborador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTO_MOVIMIENTO]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO_MOVIMIENTO](
	[PROD_MOV_id] [int] IDENTITY(1,1) NOT NULL,
	[PROD_MOV_fecha] [date] NULL,
	[ORT_id_orden_trabajo] [varchar](15) NULL,
	[PROD_MOV_tipo] [varchar](15) NULL,
	[PROD_MOV_cantidad] [int] NULL,
	[PROD_id] [int] NOT NULL,
 CONSTRAINT [PK_PRODUCTO_MOVIMIENTO] PRIMARY KEY CLUSTERED 
(
	[PROD_MOV_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAREA]    Script Date: 12/29/2018 09:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAREA](
	[TAR_id_tarea] [int] IDENTITY(1,1) NOT NULL,
	[TAR_tiempo_estimado] [varchar](10) NULL,
	[TAR_tiempo_real] [varchar](10) NULL,
	[COL_id_colaborador] [int] NOT NULL,
	[ORT_id_orden_trabajo] [int] NULL,
	[TAR_hora_fin] [varchar](10) NULL,
	[TAR_carga_horaria] [varchar](10) NULL,
	[TAR_detalle_tarea] [varchar](100) NOT NULL,
	[TAR_observaciones] [varchar](200) NULL,
	[TAR_fecha] [date] NULL,
	[TAR_entrada] [varchar](10) NULL,
	[TAR_salida] [varchar](10) NULL,
 CONSTRAINT [PK_TAREA] PRIMARY KEY CLUSTERED 
(
	[TAR_id_tarea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Producto_Movimento]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Producto_Movimento]
AS
SELECT     dbo.PRODUCTO.PROD_id, dbo.PRODUCTO.PROD_codigo, dbo.PRODUCTO.PROD_descripcion, dbo.PRODUCTO.PROD_stock, dbo.PRODUCTO.PROD_stock_minimo, 
                      dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_id, dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_fecha, dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_tipo, 
                      dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_cantidad
FROM         dbo.PRODUCTO INNER JOIN
                      dbo.PRODUCTO_MOVIMIENTO ON dbo.PRODUCTO.PROD_id = dbo.PRODUCTO_MOVIMIENTO.PROD_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[57] 4[4] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PRODUCTO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 144
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PRODUCTO_MOVIMIENTO"
            Begin Extent = 
               Top = 181
               Left = 266
               Bottom = 337
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Producto_Movimento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Producto_Movimento'
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[USU_id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[USU_usuario] [varchar](50) NULL,
	[USU_contraseña] [varchar](50) NULL,
	[USU_perfil] [varchar](15) NULL,
	[COL_id_colaborador] [int] NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[USU_id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Vista_Lista_Movimientos]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Lista_Movimientos]
AS
SELECT     dbo.PRODUCTO.PROD_id, dbo.PRODUCTO.PROD_codigo, dbo.PRODUCTO.PROD_descripcion, dbo.PRODUCTO.PROD_stock_minimo, dbo.PRODUCTO.PROD_stock, 
                      dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_id, dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_tipo, dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_cantidad, 
                      dbo.PRODUCTO_MOVIMIENTO.ORT_id_orden_trabajo, dbo.PRODUCTO_MOVIMIENTO.PROD_MOV_fecha
FROM         dbo.PRODUCTO_MOVIMIENTO INNER JOIN
                      dbo.PRODUCTO ON dbo.PRODUCTO_MOVIMIENTO.PROD_id = dbo.PRODUCTO.PROD_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[14] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PRODUCTO"
            Begin Extent = 
               Top = 50
               Left = 307
               Bottom = 191
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PRODUCTO_MOVIMIENTO"
            Begin Extent = 
               Top = 47
               Left = 622
               Bottom = 206
               Right = 821
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Lista_Movimientos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Lista_Movimientos'
GO
/****** Object:  Table [dbo].[DETALLE_ORDEN_TRABAJO]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DETALLE_ORDEN_TRABAJO](
	[id_detalle_orden_trabajo] [int] IDENTITY(1,1) NOT NULL,
	[DOT_cantidad_producto] [int] NULL,
	[DOT_tamaño_producto] [varchar](50) NULL,
	[DOT_tipo_impresion_dot] [varchar](4) NULL,
	[DOT_papel_soporte_1] [varchar](50) NULL,
	[DOT_papel_soporte_2] [varchar](50) NULL,
	[DOT_papel_soporte_3] [varchar](50) NULL,
	[DOT_gramaje_soporte_1] [varchar](10) NULL,
	[DOT_gramaje_soporte_2] [varchar](10) NULL,
	[DOT_gramaje_soporte_3] [varchar](10) NULL,
	[DOT_cantidad_soporte_1] [int] NULL,
	[DOT_cantidad_soporte_2] [int] NULL,
	[DOT_cantidad_soporte_3] [int] NULL,
	[DOT_formato_soporte_1] [varchar](15) NULL,
	[DOT_formato_soporte_2] [varchar](15) NULL,
	[DOT_formato_soporte_3] [varchar](15) NULL,
	[PIE_id_pieza] [int] NULL,
	[ORT_id_orden_trabajo] [int] NULL,
	[cantidad_1_PM_offset] [int] NULL,
	[cantidad_2_PM_offset] [int] NULL,
	[cantidad_3_PM_offset] [int] NULL,
	[formato_1_PM_offset] [varchar](15) NULL,
	[formato_2_PM_offset] [varchar](15) NULL,
	[formato_3_PM_offset] [varchar](15) NULL,
	[PIE_id_pieza_offset] [int] NULL,
	[modo_impresion_offset] [varchar](25) NULL,
	[tipo_impresion_offset] [varchar](15) NULL,
	[chapas_soporte1_offset] [int] NULL,
	[chapas_soporte2_offset] [int] NULL,
	[chapas_soporte3_offset] [int] NULL,
	[impresora_offset] [varchar](15) NULL,
	[marca_offset] [varchar](15) NULL,
	[cantidad_1_PM_digital] [int] NULL,
	[cantidad_2_PM_digital] [int] NULL,
	[cantidad_3_PM_digital] [int] NULL,
	[formato_1_PM_digital] [varchar](15) NULL,
	[formato_2_PM_digital] [varchar](15) NULL,
	[formato_3_PM_digital] [varchar](15) NULL,
	[modo_impresion_digital] [varchar](15) NULL,
	[tipo_impresion_digital] [varchar](15) NULL,
	[dato_variable] [varchar](350) NULL,
	[cantidad_gran_formato] [int] NULL,
	[tamaño_gran_formato] [varchar](15) NULL,
	[sustrato_gran_formato] [varchar](25) NULL,
	[calidad_gran_formato] [varchar](25) NULL,
	[sistema_gran_formato] [varchar](25) NULL,
	[tipo_terminacion] [varchar](60) NULL,
	[descripcion_terminacion] [varchar](350) NULL,
 CONSTRAINT [PK_DETALLE_ORDEN_TRABAJO] PRIMARY KEY CLUSTERED 
(
	[id_detalle_orden_trabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Colaborador_por_Sector]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Colaborador_por_Sector]
AS
SELECT     dbo.COLABORADOR.COL_id_colaborador, dbo.COLABORADOR.COL_nombre_col, dbo.SECTOR.SEC_id_sector, dbo.SECTOR.SEC_nombre_sector
FROM         dbo.COLABORADOR INNER JOIN
                      dbo.SECTOR ON dbo.COLABORADOR.SEC_id_sector = dbo.SECTOR.SEC_id_sector
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COLABORADOR"
            Begin Extent = 
               Top = 168
               Left = 410
               Bottom = 303
               Right = 608
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SECTOR"
            Begin Extent = 
               Top = 25
               Left = 115
               Bottom = 122
               Right = 313
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Colaborador_por_Sector'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Colaborador_por_Sector'
GO
/****** Object:  View [dbo].[VistaTareas]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaTareas]
AS
SELECT     dbo.COLABORADOR.SEC_id_sector, dbo.SECTOR.SEC_nombre_sector, dbo.COLABORADOR.COL_id_colaborador, dbo.COLABORADOR.COL_nombre_col, 
                      dbo.TAREA.TAR_id_tarea, dbo.TAREA.TAR_detalle_tarea, dbo.TAREA.TAR_fecha, dbo.TAREA.ORT_id_orden_trabajo, dbo.ORDEN_TRABAJO.ORT_numero_ot
FROM         dbo.SECTOR INNER JOIN
                      dbo.COLABORADOR ON dbo.SECTOR.SEC_id_sector = dbo.COLABORADOR.SEC_id_sector INNER JOIN
                      dbo.TAREA ON dbo.COLABORADOR.COL_id_colaborador = dbo.TAREA.COL_id_colaborador INNER JOIN
                      dbo.ORDEN_TRABAJO ON dbo.TAREA.ORT_id_orden_trabajo = dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[65] 4[3] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 54
               Left = 731
               Bottom = 250
               Right = 932
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SECTOR"
            Begin Extent = 
               Top = 235
               Left = 55
               Bottom = 330
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "COLABORADOR"
            Begin Extent = 
               Top = 78
               Left = 284
               Bottom = 208
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TAREA"
            Begin Extent = 
               Top = 222
               Left = 507
               Bottom = 440
               Right = 706
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
    ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaTareas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaTareas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaTareas'
GO
/****** Object:  View [dbo].[Vista_Tarea_x_Colaborador]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Tarea_x_Colaborador]
AS
SELECT     dbo.COLABORADOR.COL_id_colaborador AS Expr1, dbo.COLABORADOR.COL_nombre_col, dbo.SECTOR.SEC_id_sector, dbo.SECTOR.SEC_nombre_sector, 
                      dbo.ORDEN_TRABAJO.ORT_numero_ot, dbo.TAREA.TAR_id_tarea, dbo.TAREA.TAR_tiempo_estimado, dbo.TAREA.TAR_tiempo_real, dbo.TAREA.ORT_id_orden_trabajo,
                       dbo.TAREA.TAR_hora_fin, dbo.TAREA.TAR_carga_horaria, dbo.TAREA.TAR_detalle_tarea, dbo.TAREA.TAR_observaciones, dbo.TAREA.TAR_fecha, 
                      dbo.TAREA.TAR_entrada, dbo.TAREA.TAR_salida
FROM         dbo.COLABORADOR INNER JOIN
                      dbo.SECTOR ON dbo.COLABORADOR.SEC_id_sector = dbo.SECTOR.SEC_id_sector INNER JOIN
                      dbo.TAREA ON dbo.COLABORADOR.COL_id_colaborador = dbo.TAREA.COL_id_colaborador INNER JOIN
                      dbo.ORDEN_TRABAJO ON dbo.TAREA.ORT_id_orden_trabajo = dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[60] 4[3] 2[2] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COLABORADOR"
            Begin Extent = 
               Top = 30
               Left = 313
               Bottom = 157
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SECTOR"
            Begin Extent = 
               Top = 125
               Left = 569
               Bottom = 214
               Right = 767
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TAREA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 250
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 181
               Left = 266
               Bottom = 386
               Right = 467
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
      ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Tarea_x_Colaborador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'   SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Tarea_x_Colaborador'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Tarea_x_Colaborador'
GO
/****** Object:  View [dbo].[Tiempos_x_Sector]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Tiempos_x_Sector]
AS
SELECT     TOP (100) PERCENT dbo.COLABORADOR.COL_id_colaborador, dbo.COLABORADOR.COL_nombre_col, dbo.TAREA.TAR_id_tarea, dbo.TAREA.TAR_tiempo_estimado, 
                      dbo.TAREA.TAR_tiempo_real, dbo.TAREA.TAR_carga_horaria, dbo.COLABORADOR.SEC_id_sector, dbo.TAREA.TAR_fecha
FROM         dbo.TAREA INNER JOIN
                      dbo.COLABORADOR ON dbo.TAREA.COL_id_colaborador = dbo.COLABORADOR.COL_id_colaborador
ORDER BY dbo.COLABORADOR.COL_nombre_col, dbo.TAREA.TAR_fecha
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[3] 2[50] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TAREA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 225
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "COLABORADOR"
            Begin Extent = 
               Top = 6
               Left = 275
               Bottom = 132
               Right = 473
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Tiempos_x_Sector'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Tiempos_x_Sector'
GO
/****** Object:  View [dbo].[Tiempos_Totales]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Tiempos_Totales]
AS
SELECT     dbo.COLABORADOR.COL_id_colaborador, dbo.COLABORADOR.COL_nombre_col, dbo.TAREA.TAR_fecha, SUM(CONVERT(int, dbo.TAREA.TAR_tiempo_estimado)) 
                      AS [Total estimado], SUM(CONVERT(int, dbo.TAREA.TAR_tiempo_real)) AS [Total real], dbo.SECTOR.SEC_id_sector, dbo.SECTOR.SEC_nombre_sector, 
                      SUM(CONVERT(int, dbo.TAREA.TAR_carga_horaria)) AS Asignacion, CONVERT(varchar, dbo.TAREA.TAR_fecha) AS CADENA
FROM         dbo.COLABORADOR INNER JOIN
                      dbo.TAREA ON dbo.COLABORADOR.COL_id_colaborador = dbo.TAREA.COL_id_colaborador INNER JOIN
                      dbo.SECTOR ON dbo.COLABORADOR.SEC_id_sector = dbo.SECTOR.SEC_id_sector
GROUP BY dbo.COLABORADOR.COL_id_colaborador, dbo.COLABORADOR.COL_nombre_col, dbo.TAREA.TAR_fecha, dbo.SECTOR.SEC_id_sector, 
                      dbo.SECTOR.SEC_nombre_sector
HAVING      (SUM(CONVERT(int, dbo.TAREA.TAR_tiempo_real)) >= 1)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[18] 4[3] 3[57] 2) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COLABORADOR"
            Begin Extent = 
               Top = 60
               Left = 959
               Bottom = 179
               Right = 1157
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TAREA"
            Begin Extent = 
               Top = 16
               Left = 484
               Bottom = 269
               Right = 683
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SECTOR"
            Begin Extent = 
               Top = 183
               Left = 730
               Bottom = 284
               Right = 928
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 3870
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Tiempos_Totales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Tiempos_Totales'
GO
/****** Object:  View [dbo].[Movimiento_Orden]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Movimiento_Orden]
AS
SELECT     dbo.ORDEN_TRABAJO.ORT_numero_ot, dbo.TAREA.TAR_id_tarea, dbo.TAREA.TAR_detalle_tarea, dbo.TAREA.TAR_tiempo_real, dbo.TAREA.TAR_fecha, 
                      dbo.COLABORADOR.COL_id_colaborador, dbo.COLABORADOR.COL_nombre_col, dbo.COLABORADOR.SEC_id_sector, dbo.SECTOR.SEC_nombre_sector, 
                      dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo
FROM         dbo.ORDEN_TRABAJO INNER JOIN
                      dbo.TAREA ON dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.TAREA.ORT_id_orden_trabajo INNER JOIN
                      dbo.COLABORADOR ON dbo.TAREA.COL_id_colaborador = dbo.COLABORADOR.COL_id_colaborador INNER JOIN
                      dbo.SECTOR ON dbo.COLABORADOR.SEC_id_sector = dbo.SECTOR.SEC_id_sector
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[61] 4[3] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 326
               Left = 262
               Bottom = 530
               Right = 463
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TAREA"
            Begin Extent = 
               Top = 371
               Left = 616
               Bottom = 622
               Right = 815
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "COLABORADOR"
            Begin Extent = 
               Top = 324
               Left = 1013
               Bottom = 443
               Right = 1211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SECTOR"
            Begin Extent = 
               Top = 519
               Left = 1240
               Bottom = 608
               Right = 1438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2310
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Movimiento_Orden'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Movimiento_Orden'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Movimiento_Orden'
GO
/****** Object:  Table [dbo].[RE-TRABAJO]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RE-TRABAJO](
	[RET_id_retrabajo] [int] IDENTITY(1,1) NOT NULL,
	[id_detalle_orden_trabajo] [int] NULL,
	[RET_cantidad_dort] [int] NULL,
	[RET_tamaño_dort] [varchar](50) NULL,
	[RET_tipo_impresion_dort] [varchar](4) NULL,
	[RET_origen_area] [varchar](100) NULL,
	[RET_procedimiento] [varchar](350) NULL,
	[RET_fecha] [date] NULL,
	[RET_papel_soporte_1] [varchar](50) NULL,
	[RET_papel_soporte_2] [varchar](50) NULL,
	[RET_papel_soporte_3] [varchar](50) NULL,
	[RET_gramaje_soporte_1] [int] NULL,
	[RET_gramaje_soporte_2] [varchar](50) NULL,
	[RET_gramaje_soporte_3] [varchar](50) NULL,
	[RET_cantidad_soporte_1] [int] NULL,
	[RET_cantidad_soporte_2] [int] NULL,
	[RET_cantidad_soporte_3] [int] NULL,
	[RET_formato_soporte_1] [varchar](15) NULL,
	[RET_formato_soporte_2] [varchar](15) NULL,
	[RET_formato_soporte_3] [varchar](15) NULL,
	[RET_fecha_entrega] [date] NULL,
	[RET_impresora_offset] [varchar](15) NULL,
 CONSTRAINT [PK_RE-TRABAJO] PRIMARY KEY CLUSTERED 
(
	[RET_id_retrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROCESO]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROCESO](
	[PROC_id_proceso] [int] IDENTITY(1,1) NOT NULL,
	[id_detalle_orden_trabajo] [int] NULL,
	[PROC_offset] [varchar](20) NULL,
	[PROC_descrip_offset] [varchar](250) NULL,
	[PROC_digital] [varchar](20) NULL,
	[PROC_descrip_digital] [varchar](250) NULL,
	[PROC_gran_formato] [varchar](50) NULL,
	[PROC_descrip_gran_formato] [varchar](250) NULL,
	[PROC_terminacion] [varchar](50) NULL,
	[PROC_descrip_terminacion] [varchar](250) NULL,
	[PROC_logistica] [varchar](50) NULL,
	[PROC_descrip_logistica] [varchar](250) NULL,
 CONSTRAINT [PK_PROCESO] PRIMARY KEY CLUSTERED 
(
	[PROC_id_proceso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Vista_Detalle_Orden_Trabajo_2]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Detalle_Orden_Trabajo_2]
AS
SELECT     dbo.PIEZA.PIE_nombre_pie, dbo.PIEZA.PIE_ubicacion, dbo.VENDEDOR.VEN_nombre_ven, dbo.VENDEDOR.VEN_apellido_ven, dbo.ORDEN_TRABAJO.ORT_fecha_ot, 
                      dbo.ORDEN_TRABAJO.ORT_tipo_ot, dbo.ORDEN_TRABAJO.ORT_numero_ot, dbo.ORDEN_TRABAJO.ORT_observaciones_ot, dbo.ORDEN_TRABAJO.ORT_mejoras_ot, 
                      dbo.ORDEN_TRABAJO.VEN_id_vendedor, dbo.ORDEN_TRABAJO.ORT_fecha_entrega, dbo.ORDEN_TRABAJO.CLI_id_cliente, dbo.CLIENTE.CLI_razon_social
FROM         dbo.CLIENTE INNER JOIN
                      dbo.ORDEN_TRABAJO ON dbo.CLIENTE.CLI_id_cliente = dbo.ORDEN_TRABAJO.CLI_id_cliente INNER JOIN
                      dbo.DETALLE_ORDEN_TRABAJO ON dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo INNER JOIN
                      dbo.PIEZA ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza = dbo.PIEZA.PIE_id_pieza INNER JOIN
                      dbo.VENDEDOR ON dbo.ORDEN_TRABAJO.VEN_id_vendedor = dbo.VENDEDOR.VEN_id_vendedor
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[69] 4[3] 2[22] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 159
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 317
               Left = 94
               Bottom = 536
               Right = 295
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PIEZA"
            Begin Extent = 
               Top = 11
               Left = 632
               Bottom = 115
               Right = 830
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VENDEDOR"
            Begin Extent = 
               Top = 165
               Left = 36
               Bottom = 313
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DETALLE_ORDEN_TRABAJO"
            Begin Extent = 
               Top = 5
               Left = 338
               Bottom = 574
               Right = 550
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_2'
GO
/****** Object:  View [dbo].[Vista_Detalle_Orden_Trabajo_1]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Detalle_Orden_Trabajo_1]
AS
SELECT     dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo, dbo.ORDEN_TRABAJO.ORT_tipo_ot, dbo.ORDEN_TRABAJO.ORT_numero_ot, 
                      dbo.ORDEN_TRABAJO.ORT_observaciones_ot, dbo.ORDEN_TRABAJO.VEN_id_vendedor, dbo.VENDEDOR.VEN_nombre_ven, dbo.ORDEN_TRABAJO.CLI_id_cliente, 
                      dbo.CLIENTE.CLI_razon_social, dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza, dbo.PIEZA.PIE_nombre_pie, 
                      dbo.DETALLE_ORDEN_TRABAJO.id_detalle_orden_trabajo, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_dot, dbo.DETALLE_ORDEN_TRABAJO.DOT_tamaño_dot, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_tipo_impresion_dot, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_1, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_3, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_2, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_3, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_1, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_3, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_2, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_3, dbo.ORDEN_TRABAJO.ORT_fecha_entrega
FROM         dbo.DETALLE_ORDEN_TRABAJO INNER JOIN
                      dbo.PIEZA ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza = dbo.PIEZA.PIE_id_pieza INNER JOIN
                      dbo.ORDEN_TRABAJO ON dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo INNER JOIN
                      dbo.VENDEDOR ON dbo.ORDEN_TRABAJO.VEN_id_vendedor = dbo.VENDEDOR.VEN_id_vendedor INNER JOIN
                      dbo.CLIENTE ON dbo.ORDEN_TRABAJO.CLI_id_cliente = dbo.CLIENTE.CLI_id_cliente
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[4] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DETALLE_ORDEN_TRABAJO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 363
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PIEZA"
            Begin Extent = 
               Top = 6
               Left = 288
               Bottom = 95
               Right = 486
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 280
               Left = 282
               Bottom = 525
               Right = 483
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VENDEDOR"
            Begin Extent = 
               Top = 6
               Left = 524
               Bottom = 170
               Right = 722
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 473
               Left = 21
               Bottom = 675
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 28
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo_1'
GO
/****** Object:  View [dbo].[Vista_Detalle_Orden_Trabajo]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Detalle_Orden_Trabajo]
AS
SELECT     dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo, dbo.ORDEN_TRABAJO.ORT_tipo_ot, dbo.ORDEN_TRABAJO.ORT_numero_ot, 
                      dbo.ORDEN_TRABAJO.ORT_observaciones_ot, dbo.ORDEN_TRABAJO.VEN_id_vendedor, dbo.VENDEDOR.VEN_nombre_ven, dbo.ORDEN_TRABAJO.CLI_id_cliente, 
                      dbo.CLIENTE.CLI_razon_social, dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza, dbo.PIEZA.PIE_nombre_pie, 
                      dbo.DETALLE_ORDEN_TRABAJO.id_detalle_orden_trabajo, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_dot, dbo.DETALLE_ORDEN_TRABAJO.DOT_tamaño_dot, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_tipo_impresion_dot, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_1, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_papel_soporte_3, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_2, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_gramaje_soporte_3, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_1, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_2, dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_soporte_3, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_1, dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_2, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_formato_soporte_3
FROM         dbo.CLIENTE INNER JOIN
                      dbo.ORDEN_TRABAJO ON dbo.CLIENTE.CLI_id_cliente = dbo.ORDEN_TRABAJO.CLI_id_cliente INNER JOIN
                      dbo.DETALLE_ORDEN_TRABAJO ON dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo INNER JOIN
                      dbo.PIEZA ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza = dbo.PIEZA.PIE_id_pieza INNER JOIN
                      dbo.VENDEDOR ON dbo.ORDEN_TRABAJO.VEN_id_vendedor = dbo.VENDEDOR.VEN_id_vendedor
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[72] 4[3] 3[4] 2) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CLIENTE"
            Begin Extent = 
               Top = 440
               Left = 54
               Bottom = 559
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 297
               Left = 451
               Bottom = 489
               Right = 652
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DETALLE_ORDEN_TRABAJO"
            Begin Extent = 
               Top = 20
               Left = 152
               Bottom = 358
               Right = 364
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PIEZA"
            Begin Extent = 
               Top = 31
               Left = 569
               Bottom = 130
               Right = 767
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VENDEDOR"
            Begin Extent = 
               Top = 179
               Left = 760
               Bottom = 330
               Right = 958
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         A' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'lias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Detalle_Orden_Trabajo'
GO
/****** Object:  View [dbo].[Totales_mensuales]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Totales_mensuales]
AS
SELECT     COL_id_colaborador, COL_nombre_col, DATEPART(MM, TAR_fecha) AS Mes, SEC_id_sector, SEC_nombre_sector, SUM(CONVERT(int, [Total estimado])) 
                      AS [Total estimado mensual], SUM(CONVERT(int, [Total real])) AS [Total real mensual], SUM(CONVERT(int, Asignacion)) AS Asignacion
FROM         dbo.Tiempos_Totales
GROUP BY COL_id_colaborador, COL_nombre_col, DATEPART(MM, TAR_fecha), SEC_id_sector, SEC_nombre_sector
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[22] 2[22] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tiempos_Totales"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 185
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Totales_mensuales'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Totales_mensuales'
GO
/****** Object:  View [dbo].[Listado_ReTrabajo]    Script Date: 12/29/2018 09:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Listado_ReTrabajo]
AS
SELECT     dbo.[RE-TRABAJO].RET_id_retrabajo, dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza, dbo.PIEZA.PIE_nombre_pie, dbo.ORDEN_TRABAJO.ORT_numero_ot, 
                      dbo.[RE-TRABAJO].RET_cantidad_dort, dbo.[RE-TRABAJO].RET_tamaño_dort, dbo.[RE-TRABAJO].RET_tipo_impresion_dort, dbo.[RE-TRABAJO].RET_origen_area, 
                      dbo.[RE-TRABAJO].RET_procedimiento, dbo.[RE-TRABAJO].RET_fecha, dbo.[RE-TRABAJO].RET_papel_soporte_1, dbo.[RE-TRABAJO].RET_papel_soporte_2, 
                      dbo.[RE-TRABAJO].RET_papel_soporte_3, dbo.[RE-TRABAJO].RET_gramaje_soporte_1, dbo.[RE-TRABAJO].RET_gramaje_soporte_2, 
                      dbo.[RE-TRABAJO].RET_gramaje_soporte_3, dbo.[RE-TRABAJO].RET_cantidad_soporte_1, dbo.[RE-TRABAJO].RET_cantidad_soporte_2, 
                      dbo.[RE-TRABAJO].RET_cantidad_soporte_3, dbo.[RE-TRABAJO].RET_formato_soporte_1, dbo.[RE-TRABAJO].RET_formato_soporte_2, 
                      dbo.[RE-TRABAJO].RET_formato_soporte_3, dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo, dbo.DETALLE_ORDEN_TRABAJO.id_detalle_orden_trabajo, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_cantidad_dot, dbo.ORDEN_TRABAJO.ORT_fecha_ot, dbo.DETALLE_ORDEN_TRABAJO.DOT_tamaño_dot, 
                      dbo.DETALLE_ORDEN_TRABAJO.DOT_tipo_impresion_dot, dbo.ORDEN_TRABAJO.ORT_fecha_entrega
FROM         dbo.DETALLE_ORDEN_TRABAJO INNER JOIN
                      dbo.[RE-TRABAJO] ON dbo.DETALLE_ORDEN_TRABAJO.id_detalle_orden_trabajo = dbo.[RE-TRABAJO].id_detalle_orden_trabajo INNER JOIN
                      dbo.ORDEN_TRABAJO ON dbo.DETALLE_ORDEN_TRABAJO.ORT_id_orden_trabajo = dbo.ORDEN_TRABAJO.ORT_id_orden_trabajo INNER JOIN
                      dbo.PIEZA ON dbo.DETALLE_ORDEN_TRABAJO.PIE_id_pieza = dbo.PIEZA.PIE_id_pieza
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[3] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DETALLE_ORDEN_TRABAJO"
            Begin Extent = 
               Top = 13
               Left = 614
               Bottom = 350
               Right = 826
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RE-TRABAJO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDEN_TRABAJO"
            Begin Extent = 
               Top = 115
               Left = 384
               Bottom = 311
               Right = 585
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PIEZA"
            Begin Extent = 
               Top = 149
               Left = 855
               Bottom = 238
               Right = 1053
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 40
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Listado_ReTrabajo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Listado_ReTrabajo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Listado_ReTrabajo'
GO
/****** Object:  ForeignKey [FK_ORDEN_TRABAJO_CLIENTE]    Script Date: 12/29/2018 09:26:02 ******/
ALTER TABLE [dbo].[ORDEN_TRABAJO]  WITH CHECK ADD  CONSTRAINT [FK_ORDEN_TRABAJO_CLIENTE] FOREIGN KEY([CLI_id_cliente])
REFERENCES [dbo].[CLIENTE] ([CLI_id_cliente])
GO
ALTER TABLE [dbo].[ORDEN_TRABAJO] CHECK CONSTRAINT [FK_ORDEN_TRABAJO_CLIENTE]
GO
/****** Object:  ForeignKey [FK_ORDEN_TRABAJO_VENDEDOR]    Script Date: 12/29/2018 09:26:02 ******/
ALTER TABLE [dbo].[ORDEN_TRABAJO]  WITH CHECK ADD  CONSTRAINT [FK_ORDEN_TRABAJO_VENDEDOR] FOREIGN KEY([VEN_id_vendedor])
REFERENCES [dbo].[VENDEDOR] ([VEN_id_vendedor])
GO
ALTER TABLE [dbo].[ORDEN_TRABAJO] CHECK CONSTRAINT [FK_ORDEN_TRABAJO_VENDEDOR]
GO
/****** Object:  ForeignKey [FK_COLABORADOR_Sector]    Script Date: 12/29/2018 09:26:02 ******/
ALTER TABLE [dbo].[COLABORADOR]  WITH CHECK ADD  CONSTRAINT [FK_COLABORADOR_Sector] FOREIGN KEY([SEC_id_sector])
REFERENCES [dbo].[SECTOR] ([SEC_id_sector])
GO
ALTER TABLE [dbo].[COLABORADOR] CHECK CONSTRAINT [FK_COLABORADOR_Sector]
GO
/****** Object:  ForeignKey [FK_PRODUCTO_MOVIMIENTO_PRODUCTO1]    Script Date: 12/29/2018 09:26:02 ******/
ALTER TABLE [dbo].[PRODUCTO_MOVIMIENTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO_MOVIMIENTO_PRODUCTO1] FOREIGN KEY([PROD_id])
REFERENCES [dbo].[PRODUCTO] ([PROD_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PRODUCTO_MOVIMIENTO] CHECK CONSTRAINT [FK_PRODUCTO_MOVIMIENTO_PRODUCTO1]
GO
/****** Object:  ForeignKey [FK_TAREA_COLABORADOR]    Script Date: 12/29/2018 09:26:02 ******/
ALTER TABLE [dbo].[TAREA]  WITH CHECK ADD  CONSTRAINT [FK_TAREA_COLABORADOR] FOREIGN KEY([COL_id_colaborador])
REFERENCES [dbo].[COLABORADOR] ([COL_id_colaborador])
GO
ALTER TABLE [dbo].[TAREA] CHECK CONSTRAINT [FK_TAREA_COLABORADOR]
GO
/****** Object:  ForeignKey [FK_TAREA_ORDEN_TRABAJO]    Script Date: 12/29/2018 09:26:02 ******/
ALTER TABLE [dbo].[TAREA]  WITH CHECK ADD  CONSTRAINT [FK_TAREA_ORDEN_TRABAJO] FOREIGN KEY([ORT_id_orden_trabajo])
REFERENCES [dbo].[ORDEN_TRABAJO] ([ORT_id_orden_trabajo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TAREA] CHECK CONSTRAINT [FK_TAREA_ORDEN_TRABAJO]
GO
/****** Object:  ForeignKey [FK_USUARIO_COLABORADOR]    Script Date: 12/29/2018 09:26:04 ******/
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_COLABORADOR] FOREIGN KEY([COL_id_colaborador])
REFERENCES [dbo].[COLABORADOR] ([COL_id_colaborador])
GO
ALTER TABLE [dbo].[USUARIO] CHECK CONSTRAINT [FK_USUARIO_COLABORADOR]
GO
/****** Object:  ForeignKey [FK_DETALLE_ORDEN_TRABAJO_ORDEN_TRABAJO]    Script Date: 12/29/2018 09:26:04 ******/
ALTER TABLE [dbo].[DETALLE_ORDEN_TRABAJO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_ORDEN_TRABAJO_ORDEN_TRABAJO] FOREIGN KEY([ORT_id_orden_trabajo])
REFERENCES [dbo].[ORDEN_TRABAJO] ([ORT_id_orden_trabajo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_ORDEN_TRABAJO] CHECK CONSTRAINT [FK_DETALLE_ORDEN_TRABAJO_ORDEN_TRABAJO]
GO
/****** Object:  ForeignKey [FK_DETALLE_ORDEN_TRABAJO_PIEZA]    Script Date: 12/29/2018 09:26:04 ******/
ALTER TABLE [dbo].[DETALLE_ORDEN_TRABAJO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_ORDEN_TRABAJO_PIEZA] FOREIGN KEY([PIE_id_pieza])
REFERENCES [dbo].[PIEZA] ([PIE_id_pieza])
GO
ALTER TABLE [dbo].[DETALLE_ORDEN_TRABAJO] CHECK CONSTRAINT [FK_DETALLE_ORDEN_TRABAJO_PIEZA]
GO
/****** Object:  ForeignKey [FK_RE-TRABAJO_DETALLE_ORDEN_TRABAJO]    Script Date: 12/29/2018 09:26:04 ******/
ALTER TABLE [dbo].[RE-TRABAJO]  WITH CHECK ADD  CONSTRAINT [FK_RE-TRABAJO_DETALLE_ORDEN_TRABAJO] FOREIGN KEY([id_detalle_orden_trabajo])
REFERENCES [dbo].[DETALLE_ORDEN_TRABAJO] ([id_detalle_orden_trabajo])
GO
ALTER TABLE [dbo].[RE-TRABAJO] CHECK CONSTRAINT [FK_RE-TRABAJO_DETALLE_ORDEN_TRABAJO]
GO
/****** Object:  ForeignKey [FK_PROCESO_DETALLE_ORDEN_TRABAJO]    Script Date: 12/29/2018 09:26:04 ******/
ALTER TABLE [dbo].[PROCESO]  WITH CHECK ADD  CONSTRAINT [FK_PROCESO_DETALLE_ORDEN_TRABAJO] FOREIGN KEY([id_detalle_orden_trabajo])
REFERENCES [dbo].[DETALLE_ORDEN_TRABAJO] ([id_detalle_orden_trabajo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PROCESO] CHECK CONSTRAINT [FK_PROCESO_DETALLE_ORDEN_TRABAJO]
GO
