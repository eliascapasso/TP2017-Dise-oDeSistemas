USE [TP2017]
GO
/****** Object:  Table [dbo].[AnioLectivo]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[Asignatura]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[Aula]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[Cuatrimestre]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[DetalleReserva]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[Docente]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[DocenteAsignatura]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[HistContrasenia]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[Reserva]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[TipoAsignatura]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[TipoAula]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 18/12/2017 20:06:41 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/12/2017 20:06:41 ******/
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
INSERT [dbo].[AnioLectivo] ([id_anio_lectivo], [fecha_inicio], [fecha_fin]) VALUES (2, CAST(N'2017-01-01' AS Date), CAST(N'2017-12-30' AS Date))
SET IDENTITY_INSERT [dbo].[AnioLectivo] OFF
SET IDENTITY_INSERT [dbo].[Asignatura] ON 

INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (1, 1, N'Diseño de sistemas')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (2, 1, N'Fisica 1')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (6, 1, N'Fisica 2')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (7, 1, N'Análisis Matematico 1')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (8, 1, N'Análisis Matematico 2')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (9, 1, N'Análisis de Sistemas')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (10, 2, N'JAVA')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (11, 2, N'Programación WEB')
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura]) VALUES (12, 3, N'Oracle')
SET IDENTITY_INSERT [dbo].[Asignatura] OFF
SET IDENTITY_INSERT [dbo].[Aula] ON 

INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (1, 1, 2, 1, 20, NULL, 10, 1, NULL, NULL, NULL, N'Marcador', 1)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (2, 1, 1, 1, 10, NULL, NULL, 1, 1, 1, 1, N'Tiza', 2)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (4, 1, 1, NULL, 40, 1, NULL, NULL, NULL, NULL, NULL, N'Tiza', 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (5, 1, 2, NULL, 10, NULL, 5, 1, NULL, NULL, NULL, N'Marcador', 1)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (6, 1, 2, 1, 35, NULL, 15, 1, NULL, NULL, NULL, N'Marcador', 1)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (7, 1, 3, 1, 30, NULL, 20, 1, NULL, NULL, NULL, N'Marcador', 1)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (8, 1, 2, 1, 12, NULL, NULL, 1, 1, 0, 1, N'Marcador', 2)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (9, 1, 1, NULL, 25, 1, NULL, NULL, NULL, NULL, NULL, N'Tiza', 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (10, 1, 1, NULL, 32, 1, NULL, NULL, NULL, NULL, NULL, N'Marcador', 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (11, 1, 1, NULL, 35, 1, NULL, NULL, NULL, NULL, NULL, N'Tiza', 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (12, 1, 1, NULL, 30, 1, NULL, NULL, NULL, NULL, NULL, N'Tiza', 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (13, 1, 1, NULL, 25, 1, NULL, NULL, NULL, NULL, NULL, N'Tiza', 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (15, 1, 2, 1, 20, NULL, NULL, 1, 1, 1, 1, N'Marcador', 2)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (16, 1, 2, 1, 22, NULL, NULL, 1, 1, 1, 1, N'Marcador', 2)
SET IDENTITY_INSERT [dbo].[Aula] OFF
SET IDENTITY_INSERT [dbo].[Cuatrimestre] ON 

INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (4, CAST(N'2017-06-01' AS Date), CAST(N'2017-12-30' AS Date), 2)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (5, CAST(N'2018-03-01' AS Date), CAST(N'2018-06-29' AS Date), 1)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (6, CAST(N'2018-07-27' AS Date), CAST(N'2018-11-23' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Cuatrimestre] OFF
SET IDENTITY_INSERT [dbo].[Docente] ON 

INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (1, N'Cristian', N'Impini', N'cimpini@yahoo.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (2, N'Wesley', N'Bento', N'wbento1@epa.gov')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (3, N'Karlan', N'Broggini', N'kbroggini2@vimeo.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (4, N'Pembroke', N'Kornilyev', N'pkornilyev3@pbs.org')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (5, N'Cassius', N'Foulger', N'cfoulger4@g.co')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (6, N'Lyell', N'Bloxsome', N'lbloxsome5@furl.net')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (7, N'Inger', N'Gouldthorp', N'igouldthorp6@ftc.gov')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (8, N'Gayelord', N'Frood', N'gfrood7@mediafire.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (9, N'Cedric', N'Cherry Holme', N'ccherryholme8@stumbleupon.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (10, N'Eugene', N'Norledge', N'enorledge9@springer.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (11, N'Alasteir', N'Beecroft', N'abeecrofta@bloomberg.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (12, N'Lindon', N'Penright', N'lpenrightb@vinaora.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (13, N'Packston', N'Mcwhinnie', N'pmcwhinniec@tinyurl.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (14, N'Dorian', N'Bison', N'dbisond@google.com.hk')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (15, N'Juan', N'Meers', N'jmeerse@opera.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (16, N'Dene', N'Alexsandrov', N'dalexsandrovf@omniture.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (17, N'Hamil', N'Sleeman', N'hsleemang@meetup.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (18, N'Alic', N'Danskine', N'adanskineh@studiopress.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (19, N'Archibaldo', N'Moye', N'amoyei@webnode.com')
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (20, N'Chrissie', N'Quenby', N'cquenbyj@scribd.com')
SET IDENTITY_INSERT [dbo].[Docente] OFF
SET IDENTITY_INSERT [dbo].[HistContrasenia] ON 

INSERT [dbo].[HistContrasenia] ([id_historial], [contrasenia], [id_usuario], [fecha_creacion]) VALUES (2, N'@Coso123', 30, CAST(N'2017-11-28 10:18:14.927' AS DateTime))
INSERT [dbo].[HistContrasenia] ([id_historial], [contrasenia], [id_usuario], [fecha_creacion]) VALUES (3, N'@Algo123', 31, CAST(N'2017-12-17 15:26:44.253' AS DateTime))
INSERT [dbo].[HistContrasenia] ([id_historial], [contrasenia], [id_usuario], [fecha_creacion]) VALUES (4, N'@Algo124', 31, CAST(N'2017-12-17 15:30:25.757' AS DateTime))
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
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (31, 1, N'nick', N'@Algo124', N'alguien', N'alguien', N'Noche', 1)
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
