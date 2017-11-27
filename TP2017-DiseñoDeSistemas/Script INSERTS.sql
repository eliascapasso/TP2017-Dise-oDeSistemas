USE [TP2017]
GO
SET IDENTITY_INSERT [dbo].[TipoAsignatura] ON 

INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (1, N'Catedra')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (2, N'Curso')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (3, N'Seminario')
SET IDENTITY_INSERT [dbo].[TipoAsignatura] OFF
SET IDENTITY_INSERT [dbo].[Asignatura] ON 

INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura], [duracion]) VALUES (1, 1, N'Diseño de sistemas', NULL)
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura], [duracion]) VALUES (2, 1, N'Fisica 1', NULL)
SET IDENTITY_INSERT [dbo].[Asignatura] OFF
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([id_tipo_usuario], [descripcion]) VALUES (1, N'Bedel')
INSERT [dbo].[TipoUsuario] ([id_tipo_usuario], [descripcion]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (18, 1, N'admin', N'passDeAdmin123', N'', N'', N'', 2)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (26, 1, N'ecapasso', N'@Algo123', N'Elias', N'Capasso', N'Tarde', 1)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (27, 1, N'mgarcia', N'@Coso123', N'Mariano', N'Garcia', N'Mañana', 1)
INSERT [dbo].[Usuario] ([id_usuario], [activo], [nick], [contrasenia], [nombre], [apellido], [turno], [id_tipo_usuario]) VALUES (28, 1, N'cimpini', N'2017$Impi', N'Cristia', N'Impini', N'Mañana', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[Docente] ON 

INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (1, N'Cristian', N'Impini', N'cimpini@yahoo.com')
SET IDENTITY_INSERT [dbo].[Docente] OFF
SET IDENTITY_INSERT [dbo].[TipoAula] ON 

INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (1, N'Informatica')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (2, N'Multimedios')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (4, N'Sin recursos adicionales')
SET IDENTITY_INSERT [dbo].[TipoAula] OFF
