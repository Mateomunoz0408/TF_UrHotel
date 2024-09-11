USE [master]
GO
/****** Object:  Database [db_TFUrHotel]    Script Date: 23/06/2024 20:46:31 ******/
CREATE DATABASE [db_TFUrHotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_TFUrHotel', FILENAME = N'D:\SQL Server 2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_TFUrHotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_TFUrHotel_log', FILENAME = N'D:\SQL Server 2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_TFUrHotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_TFUrHotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_TFUrHotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_TFUrHotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_TFUrHotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_TFUrHotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_TFUrHotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_TFUrHotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_TFUrHotel] SET  MULTI_USER 
GO
ALTER DATABASE [db_TFUrHotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_TFUrHotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_TFUrHotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_TFUrHotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_TFUrHotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_TFUrHotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_TFUrHotel] SET QUERY_STORE = OFF
GO
USE [db_TFUrHotel]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/06/2024 20:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Dni] [nvarchar](8) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Celular] [nvarchar](9) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 23/06/2024 20:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[Numero] [nvarchar](5) NOT NULL,
	[Estado] [nvarchar](30) NOT NULL,
	[Tipo] [nvarchar](30) NOT NULL,
	[Precio] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK_Habitacion] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 23/06/2024 20:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Codigo] [nvarchar](5) NOT NULL,
	[Cliente] [nvarchar](8) NOT NULL,
	[Habitacion] [nvarchar](5) NOT NULL,
	[Fecha_Entrada] [date] NOT NULL,
	[Fecha_Salida] [date] NOT NULL,
	[Monto_Total] [decimal](18, 0) NOT NULL,
	[Usuario] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/06/2024 20:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usuario] [nvarchar](20) NOT NULL,
	[Contraseña] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cliente] ([Dni], [Nombre], [Celular]) VALUES (N'12345678', N'Joe Martinez', N'987654321')
INSERT [dbo].[Cliente] ([Dni], [Nombre], [Celular]) VALUES (N'54673829', N'Vito Corleone', N'928174503')
INSERT [dbo].[Cliente] ([Dni], [Nombre], [Celular]) VALUES (N'72551599', N'Josue Cavero', N'975050092')
INSERT [dbo].[Cliente] ([Dni], [Nombre], [Celular]) VALUES (N'93847562', N'Han Solo', N'947283615')
GO
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A101', N'Ocupada', N'Estandar', CAST(40.50 AS Decimal(6, 2)))
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A102', N'Ocupada', N'Estandar', CAST(40.50 AS Decimal(6, 2)))
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A103', N'Disponible', N'Estandar', CAST(40.50 AS Decimal(6, 2)))
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A201', N'Disponible', N'Estandar', CAST(50.00 AS Decimal(6, 2)))
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A202', N'Disponible', N'Estandar', CAST(52.00 AS Decimal(6, 2)))
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A203', N'Disponible', N'Estandar', CAST(50.00 AS Decimal(6, 2)))
INSERT [dbo].[Habitacion] ([Numero], [Estado], [Tipo], [Precio]) VALUES (N'A701', N'Ocupada', N'Suite', CAST(500.00 AS Decimal(6, 2)))
GO
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'01', N'12345678', N'A102', CAST(N'2024-05-30' AS Date), CAST(N'2024-06-02' AS Date), CAST(122 AS Decimal(18, 0)), N'admin_Josue')
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'02', N'72551599', N'A101', CAST(N'2024-05-31' AS Date), CAST(N'2024-06-06' AS Date), CAST(243 AS Decimal(18, 0)), N'admin_Josue')
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'03', N'12345678', N'A701', CAST(N'2024-06-21' AS Date), CAST(N'2024-06-23' AS Date), CAST(1000 AS Decimal(18, 0)), N'admin_Josue')
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'04', N'72551599', N'A701', CAST(N'2024-06-01' AS Date), CAST(N'2024-06-07' AS Date), CAST(3000 AS Decimal(18, 0)), N'admin_Josue')
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'06', N'54673829', N'A102', CAST(N'2024-06-06' AS Date), CAST(N'2024-06-22' AS Date), CAST(648 AS Decimal(18, 0)), N'admin_Anthony')
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'07', N'72551599', N'A701', CAST(N'2024-03-01' AS Date), CAST(N'2024-04-30' AS Date), CAST(30000 AS Decimal(18, 0)), N'admin_Anthony')
INSERT [dbo].[Reserva] ([Codigo], [Cliente], [Habitacion], [Fecha_Entrada], [Fecha_Salida], [Monto_Total], [Usuario]) VALUES (N'08', N'93847562', N'A701', CAST(N'2024-01-04' AS Date), CAST(N'2024-02-23' AS Date), CAST(25000 AS Decimal(18, 0)), N'admin_Anthony')
GO
INSERT [dbo].[Usuario] ([Usuario], [Contraseña]) VALUES (N'admin_Anthony', N'aadmin123')
INSERT [dbo].[Usuario] ([Usuario], [Contraseña]) VALUES (N'admin_Carlos', N'cadmin123')
INSERT [dbo].[Usuario] ([Usuario], [Contraseña]) VALUES (N'admin_Josue', N'jadmin123')
INSERT [dbo].[Usuario] ([Usuario], [Contraseña]) VALUES (N'admin_Luis', N'ladmin123')
INSERT [dbo].[Usuario] ([Usuario], [Contraseña]) VALUES (N'admin_Mateo', N'madmin123')
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([Dni])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Habitacion] FOREIGN KEY([Habitacion])
REFERENCES [dbo].[Habitacion] ([Numero])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Habitacion]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([Usuario])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Usuario]
GO
USE [master]
GO
ALTER DATABASE [db_TFUrHotel] SET  READ_WRITE 
GO
