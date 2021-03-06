USE [TP2017]
GO
SET IDENTITY_INSERT [dbo].[AnioLectivo] ON 

INSERT [dbo].[AnioLectivo] ([id_anio_lectivo], [fecha_inicio], [fecha_fin]) VALUES (1, CAST(N'2018-03-01' AS Date), CAST(N'2018-11-23' AS Date))
INSERT [dbo].[AnioLectivo] ([id_anio_lectivo], [fecha_inicio], [fecha_fin]) VALUES (2, CAST(N'2019-01-01' AS Date), CAST(N'2019-12-30' AS Date))
INSERT [dbo].[AnioLectivo] ([id_anio_lectivo], [fecha_inicio], [fecha_fin]) VALUES (3, CAST(N'2017-01-01' AS Date), CAST(N'2017-12-31' AS Date))
SET IDENTITY_INSERT [dbo].[AnioLectivo] OFF
SET IDENTITY_INSERT [dbo].[Cuatrimestre] ON 

INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (4, CAST(N'2019-07-29' AS Date), CAST(N'2019-12-30' AS Date), 2)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (5, CAST(N'2018-03-01' AS Date), CAST(N'2018-06-29' AS Date), 1)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (6, CAST(N'2018-07-27' AS Date), CAST(N'2018-11-23' AS Date), 1)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (7, CAST(N'2019-01-01' AS Date), CAST(N'2019-06-25' AS Date), 2)
INSERT [dbo].[Cuatrimestre] ([id_cuatrimestre], [fecha_inicio], [fecha_fin], [id_anio_lectivo]) VALUES (8, CAST(N'2017-07-27' AS Date), CAST(N'2017-12-31' AS Date), 3)
SET IDENTITY_INSERT [dbo].[Cuatrimestre] OFF
SET IDENTITY_INSERT [dbo].[TipoAsignatura] ON 

INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (1, N'Catedra')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (2, N'Curso')
INSERT [dbo].[TipoAsignatura] ([id_tipo_asignatura], [descripcion]) VALUES (3, N'Seminario')
SET IDENTITY_INSERT [dbo].[TipoAsignatura] OFF
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
INSERT [dbo].[Docente] ([id_docente], [nombre_docente], [apellido_docente], [email_docente]) VALUES (41, N'Claudio', N'Bracalenti', N'cbraca@gmail.com')
SET IDENTITY_INSERT [dbo].[Docente] OFF
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (1, 1)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (1, 41)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (2, 11)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (6, 4)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (7, 5)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (7, 8)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (8, 3)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (9, 10)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (10, 8)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (10, 13)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (11, 5)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (11, 15)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (12, 16)
INSERT [dbo].[DocenteAsignatura] ([id_asignatura], [id_docente]) VALUES (12, 18)
SET IDENTITY_INSERT [dbo].[TipoAula] ON 

INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (1, N'Informatica')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (2, N'Multimedios')
INSERT [dbo].[TipoAula] ([id_tipo_aula], [descripcion]) VALUES (4, N'Sin recursos adicionales')
SET IDENTITY_INSERT [dbo].[TipoAula] OFF
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
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([id_tipo_usuario], [descripcion]) VALUES (1, N'Bedel')
INSERT [dbo].[TipoUsuario] ([id_tipo_usuario], [descripcion]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
