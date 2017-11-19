create database TP2017;

use TP2017;
create table TipoUsuario(
id_tipo_usuario int IDENTITY(1,1) PRIMARY KEY,
descripcion varchar(10)
);

create table Usuario(
id_usuario int IDENTITY(1,1) PRIMARY KEY,
activo bit,
nick varchar(10) not null,
contrasenia varchar(20) not null,
nombre varchar(20),
apellido varchar(20),
turno varchar(20),
id_tipo_usuario int  FOREIGN KEY REFERENCES TipoUsuario(id_tipo_usuario),
);

create table HistContrasenia(
id_historial int IDENTITY(1,1) PRIMARY KEY,
contrasenia varchar(20),
id_usuario int  FOREIGN KEY REFERENCES Usuario(id_usuario),
fecha_creacion dateTime
);

create table TipoPizarron(
id_tipo_pizarron int IDENTITY(1,1) PRIMARY KEY,
descripcion varchar(20)
);
create table TipoAula(
id_tipo_aula int IDENTITY(1,1) PRIMARY KEY,
descripcion varchar(20)
);
create table Aula(
id_aula int IDENTITY(1,1) PRIMARY KEY,
habilitado bit,
piso int not null,
aire_acond bit,
capacidad int not null,
ventilador bit,
cant_pc int,
canion bit,
dvd bit,
tv bit,
pc bit,
id_tipo_pizarron int  FOREIGN KEY REFERENCES TipoPizarron(id_tipo_pizarron),
id_tipo_aula int  FOREIGN KEY REFERENCES TipoAula(id_tipo_aula)
);

create table Docente(
id_docente int IDENTITY(1,1) PRIMARY KEY,
nombre_docente varchar(20),
apellido_docente varchar(20),
email_docente varchar(50)
);

create table TipoAsignatura(
id_tipo_asignatura int IDENTITY(1,1) PRIMARY KEY,
descripcion varchar(20)
);
create table Asignatura(
id_asignatura int IDENTITY(1,1) PRIMARY KEY,
id_tipo_asignatura int  FOREIGN KEY REFERENCES TipoAsignatura(id_tipo_asignatura),
nombre_asignatura varchar(50),
duracion time,
);

create table DocenteAsignatura(
id_asignatura int  FOREIGN KEY REFERENCES Asignatura(id_asignatura),
id_docente int  FOREIGN KEY REFERENCES docente(id_docente),
primary key (id_asignatura,id_docente)
);
create table AnioLectivo(
id_anio_lectivo int identity (1,1) primary key,
fecha_inicio date,
fecha_fin date
);
create table TipoPeriodo(
id_tipo_periodo int identity (1,1) primary key,
descripcion varchar(20)
);
create table Periodo(
id_periodo int identity (1,1) primary key,
id_tipo_periodo int  FOREIGN KEY REFERENCES TipoPeriodo(id_tipo_periodo),
fecha_inicio date,
fecha_fin date,
id_anio_lectivo int  FOREIGN KEY REFERENCES AnioLectivo(id_anio_lectivo)
);
create table NombreDia(
id_nombre_dia int identity (1,1) primary key,
descripcion varchar(20)
)
create table Dia(
id_dia int identity (1,1) primary key,
id_periodo int  FOREIGN KEY REFERENCES Periodo(id_periodo),
fecha date,
id_nombre_dia int  FOREIGN KEY REFERENCES NombreDia(id_nombre_dia),
);
create table TipoReserva(
id_tipo_reserva int identity (1,1) primary key,
descripcion varchar(20)
);
create table Reserva(
id_reserva int identity (1,1) primary key,
hora_inicio time,
capacidad int,
activa bit,
id_usuario int  FOREIGN KEY REFERENCES Usuario(id_usuario),
id_asignatura int  FOREIGN KEY REFERENCES Asignatura(id_asignatura),
id_tipo_reserva int  FOREIGN KEY REFERENCES TipoReserva(id_tipo_reserva),
id_docente int  FOREIGN KEY REFERENCES docente(id_docente)
);
create table DetalleReserva(
id_detalle_reserva int identity (1,1) primary key,
id_dia int  FOREIGN KEY REFERENCES Dia(id_dia),
id_reserva int  FOREIGN KEY REFERENCES Reserva(id_reserva),
id_aula int  FOREIGN KEY REFERENCES Aula(id_aula),
hora_inicio time,
duracion time
);
