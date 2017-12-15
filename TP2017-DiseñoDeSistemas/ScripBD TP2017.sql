create database TP2017;
USE [TP2017]
GO
/****** Object:  Table [dbo].[AnioLectivo]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[Asignatura]    Script Date: 15/12/2017 01:34:59 ******/
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
	[duracion] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[Cuatrimestre]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[DetalleReserva]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[Docente]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[DocenteAsignatura]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[HistContrasenia]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[Reserva]    Script Date: 15/12/2017 01:34:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fechaReserva] [time](7) NULL,
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
/****** Object:  Table [dbo].[TipoAsignatura]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[TipoAula]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 15/12/2017 01:34:59 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/12/2017 01:34:59 ******/
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
SET IDENTITY_INSERT [dbo].[AnioLectivo] ON 

INSERT [dbo].[AnioLectivo] ([id_anio_lectivo], [fecha_inicio], [fecha_fin]) VALUES (1, CAST(N'2018-03-01' AS Date), CAST(N'2018-11-23' AS Date))
SET IDENTITY_INSERT [dbo].[AnioLectivo] OFF
SET IDENTITY_INSERT [dbo].[Asignatura] ON 

INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura], [duracion]) VALUES (1, 1, N'Diseño de sistemas', NULL)
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura], [duracion]) VALUES (2, 1, N'Fisica 1', NULL)
SET IDENTITY_INSERT [dbo].[Asignatura] OFF
SET IDENTITY_INSERT [dbo].[Aula] ON 

INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (1, 1, 2, 1, 20, NULL, 10, 1, NULL, NULL, NULL, N'madera', 1)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (2, 1, 1, 1, 10, NULL, NULL, 1, 1, 1, 1, NULL, 2)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (4, 1, 1, NULL, 40, 1, NULL, NULL, NULL, NULL, NULL, NULL, 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (5, 1, 2, NULL, 10, NULL, 5, 1, NULL, NULL, NULL, N'madera', 1)
SET IDENTITY_INSERT [dbo].[Aula] OFF
SET IDENTITY_INSERT [dbo].[Cuatrimestre] ON 

INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (2, CAST(N'2018-03-01' AS Date), CAST(N'2018-06-30' AS Date), 1)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (3, CAST(N'2018-07-29' AS Date), CAST(N'2018-11-23' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Cuatrimestre] OFF
SET IDENTITY_INSERT [dbo].[Docente] ON 

INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (1, N'Cristian', N'Impini', N'cimpini@yahoo.com')
SET IDENTITY_INSERT [dbo].[Docente] OFF
SET IDENTITY_INSERT [dbo].[HistContrasenia] ON 

INSERT [dbo].[HistContrasenia] ([id_historial], [contrasenia], [id_usuario], [fecha_creacion]) VALUES (2, N'@Coso123', 30, CAST(N'2017-11-28 10:18:14.927' AS DateTime))
SET IDENTITY_INSERT [dbo].[HistContrasenia] OFF
SET IDENTITY_INSERT [dbo].[TipoAsignatura] ON 

INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (1, N'Catedra')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (2, N'Curso')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (3, N'Seminario')
SET IDENTITY_INSERT [dbo].[TipoAsignatura] OFF
SET IDENTITY_INSERT [dbo].[TipoAula] ON 

INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (1, N'Informatica')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (2, N'Multimedios')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (4, N'Sin recursos adicionales')
SET IDENTITY_INSERT [dbo].[TipoAula] OFF
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([id_tipo_usuario], [descripcion]) VALUES (1, N'Bedel')
INSERT [dbo].[TipoUsuario] ([id_tipo_usuario], [descripcion]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (18, 1, N'admin', N'passDeAdmin123', N'', N'', N'', 2)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (26, 1, N'ecapasso', N'@Algo123', N'Elias', N'Capasso', N'Tarde', 1)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (27, 1, N'mgarcia', N'@Coso123', N'Mariano', N'Garcia', N'Mañana', 1)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (28, 1, N'cimpini', N'2017$Impi', N'Cristia', N'Impini', N'Mañana', 1)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (30, 1, N'unNick', N'@Coso123', N'otroNombre', N'unApellido', N'Mañana', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
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
