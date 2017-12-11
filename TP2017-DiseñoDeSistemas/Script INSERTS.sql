USE [TP2017]
GO
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
SET IDENTITY_INSERT [dbo].[HistContrasenia] ON 

INSERT [dbo].[HistContrasenia] ([id_historial], [contrasenia], [id_usuario], [fecha_creacion]) VALUES (2, N'@Coso123', 30, CAST(N'2017-11-28 10:18:14.927' AS DateTime))
SET IDENTITY_INSERT [dbo].[HistContrasenia] OFF
SET IDENTITY_INSERT [dbo].[Docente] ON 

INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (1, N'Cristian', N'Impini', N'cimpini@yahoo.com')
SET IDENTITY_INSERT [dbo].[Docente] OFF
SET IDENTITY_INSERT [dbo].[TipoAsignatura] ON 

INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (1, N'Catedra')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (2, N'Curso')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (3, N'Seminario')
SET IDENTITY_INSERT [dbo].[TipoAsignatura] OFF
SET IDENTITY_INSERT [dbo].[Asignatura] ON 

INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura], [duracion]) VALUES (1, 1, N'Diseño de sistemas', NULL)
INSERT [dbo].[Asignatura] ([id_asignatura], [id_tipo_asignatura], [nombre_asignatura], [duracion]) VALUES (2, 1, N'Fisica 1', NULL)
SET IDENTITY_INSERT [dbo].[Asignatura] OFF
SET IDENTITY_INSERT [dbo].[TipoAula] ON 

INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (1, N'Informatica')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (2, N'Multimedios')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (4, N'Sin recursos adicionales')
SET IDENTITY_INSERT [dbo].[TipoAula] OFF
SET IDENTITY_INSERT [dbo].[Aula] ON 

INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (1, 1, 2, 1, 20, NULL, 10, 1, NULL, NULL, NULL, N'madera', 1)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (2, 1, 1, 1, 10, NULL, NULL, 1, 1, 1, 1, NULL, 2)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (4, 1, 1, NULL, 40, 1, NULL, NULL, NULL, NULL, NULL, NULL, 4)
INSERT [dbo].[Aula] ([id_aula], [habilitado], [piso], [aire_acond], [capacidad], [ventilador], [cant_pc], [canion], [dvd], [tv], [pc], [tipo_pizarron], [id_tipo_aula]) VALUES (5, 1, 2, NULL, 10, NULL, 5, 1, NULL, NULL, NULL, N'madera', 1)
SET IDENTITY_INSERT [dbo].[Aula] OFF
SET IDENTITY_INSERT [dbo].[AnioLectivo] ON 

INSERT [dbo].[AnioLectivo] ([id_anio_lectivo], [fecha_inicio], [fecha_fin]) VALUES (1, CAST(N'2018-03-01' AS Date), CAST(N'2018-11-23' AS Date))
SET IDENTITY_INSERT [dbo].[AnioLectivo] OFF
SET IDENTITY_INSERT [dbo].[Cuatrimestre] ON 

INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (2, CAST(N'2018-03-01' AS Date), CAST(N'2018-06-30' AS Date), 1)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (3, CAST(N'2018-07-29' AS Date), CAST(N'2018-11-23' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Cuatrimestre] OFF
