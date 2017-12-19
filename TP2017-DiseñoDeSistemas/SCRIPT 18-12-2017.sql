USE [master]
GO
/****** Object:  Database [TP2017]    Script Date: 19/12/2017 01:41:48 ******/
CREATE DATABASE [TP2017]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP2017', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TP2017.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TP2017_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TP2017_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TP2017] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP2017].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP2017] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP2017] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP2017] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP2017] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP2017] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP2017] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TP2017] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP2017] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP2017] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP2017] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP2017] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP2017] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP2017] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP2017] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP2017] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TP2017] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP2017] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP2017] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP2017] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP2017] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP2017] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP2017] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP2017] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP2017] SET  MULTI_USER 
GO
ALTER DATABASE [TP2017] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP2017] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP2017] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP2017] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TP2017] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TP2017]
GO
/****** Object:  Table [dbo].[AnioLectivo]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnioLectivo](
	[id_anio_lectivo] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [date] NULL,
	[fecha_fin] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_anio_lectivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asignatura](
	[id_asignatura] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_asignatura] [int] NULL,
	[nombre_asignatura] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[habilitado] [bit] NULL,
	[piso] [int] NOT NULL,
	[aire_acond] [bit] NULL,
	[capacidad] [int] NOT NULL,
	[ventilador] [bit] NULL,
	[cant_pc] [int] NULL,
	[canion] [bit] NULL,
	[dvd] [bit] NULL,
	[tv] [bit] NULL,
	[pc] [bit] NULL,
	[tipo_pizarron] [varchar](50) NULL,
	[id_tipo_aula] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuatrimestre]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuatrimestre](
	[id_cuatrimestre] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [date] NULL,
	[fecha_fin] [date] NULL,
	[id_anio_lectivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cuatrimestre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleReserva]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleReserva](
	[id_detalle_reserva] [int] IDENTITY(1,1) NOT NULL,
	[dia] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[id_reserva] [int] NULL,
	[id_aula] [int] NULL,
	[hora_inicio] [time](7) NULL,
	[duracion] [time](7) NULL,
	[id_cuatrimestre] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Docente]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docente](
	[id_docente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_docente] [varchar](50) NULL,
	[apellido_docente] [varchar](50) NULL,
	[email_docente] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocenteAsignatura]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocenteAsignatura](
	[id_asignatura] [int] NOT NULL,
	[id_docente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_asignatura] ASC,
	[id_docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HistContrasenia]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistContrasenia](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[contrasenia] [varchar](50) NULL,
	[id_usuario] [int] NULL,
	[fecha_creacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fechaReserva] [datetime] NULL,
	[capacidad] [int] NULL,
	[activa] [bit] NULL,
	[id_usuario] [int] NULL,
	[id_asignatura] [int] NULL,
	[tipo_reserva] [varchar](50) NULL,
	[id_docente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoAsignatura]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoAsignatura](
	[id_tipo_asignatura] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoAula]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoAula](
	[id_tipo_aula] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[id_tipo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 19/12/2017 01:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NULL,
	[nick] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[turno] [varchar](50) NULL,
	[id_tipo_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Asignatura]  WITH CHECK ADD FOREIGN KEY([id_tipo_asignatura])
REFERENCES [dbo].[TipoAsignatura] ([id_tipo_asignatura])
GO
ALTER TABLE [dbo].[Aula]  WITH CHECK ADD FOREIGN KEY([id_tipo_aula])
REFERENCES [dbo].[TipoAula] ([id_tipo_aula])
GO
ALTER TABLE [dbo].[Cuatrimestre]  WITH CHECK ADD FOREIGN KEY([id_anio_lectivo])
REFERENCES [dbo].[AnioLectivo] ([id_anio_lectivo])
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD FOREIGN KEY([id_aula])
REFERENCES [dbo].[Aula] ([id_aula])
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD FOREIGN KEY([id_cuatrimestre])
REFERENCES [dbo].[Cuatrimestre] ([id_cuatrimestre])
GO
ALTER TABLE [dbo].[DetalleReserva]  WITH CHECK ADD FOREIGN KEY([id_reserva])
REFERENCES [dbo].[Reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[DocenteAsignatura]  WITH CHECK ADD FOREIGN KEY([id_asignatura])
REFERENCES [dbo].[Asignatura] ([id_asignatura])
GO
ALTER TABLE [dbo].[DocenteAsignatura]  WITH CHECK ADD FOREIGN KEY([id_docente])
REFERENCES [dbo].[Docente] ([id_docente])
GO
ALTER TABLE [dbo].[HistContrasenia]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([id_asignatura])
REFERENCES [dbo].[Asignatura] ([id_asignatura])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([id_docente])
REFERENCES [dbo].[Docente] ([id_docente])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([id_tipo_usuario])
REFERENCES [dbo].[TipoUsuario] ([id_tipo_usuario])
GO
USE [master]
GO
ALTER DATABASE [TP2017] SET  READ_WRITE 
GO
