/*
	ASIGNATURA: PROG. APLICADA III
	EQUIPO:
	WIBER DENILSON LOPÉZ PÉREZ
	KEVIN MIGUEL HENRÍQUEZ PÉREZ
	Nathalie Jeannette Sibrian Perez
*/

CREATE DATABASE ControlRegistrosCovi1d9
GO
USE ControlRegistrosCovi1d9

CREATE TABLE Estado(
	EstadoId int identity(1,1) primary key not null,
	Nombre text not null
)

CREATE TABLE Facultad(
	FacultadId int identity (1,1) primary key not null,
	Nombre text not null
)

CREATE TABLE Carrera(
	CarreraId int identity (1,1) primary key not null,
	Nombre text not null,
	FacultadId int foreign key(FacultadId) references Facultad(FacultadId) not null
)

CREATE TABLE Ciclo(
	CicloId int identity (1,1) primary key not null,
	Nombre varchar(10) not null,
	Anio varchar(4) not null
)

CREATE TABLE Aula(
	AulaId int identity (1,1) primary key not null,
	Nombre text not null
)

CREATE TABLE Asignatura(
	AsignaturaId int identity (1,1) primary key not null,
	Nombre text not null,
	Codigo text not null,
	AulaId int foreign key(AulaId) references Aula(AulaId) not null,
	CicloId int foreign key (CicloId) references Ciclo(CicloId) not null,
	FacultadId int foreign key (FacultadId) references Facultad(FacultadId) not null
)

CREATE TABLE Estudiante(
	EstudianteId int identity (1,1) primary key not null,
	Nombres text not null,
	Apellidos text not null,
	Codigo text not null,
	CarreraId int foreign key (CarreraId) references Carrera(CarreraId) not null,
	NumTelefono text not null,
	Genero text not null,
	Natalicio text not null,
	EstadoId int foreign key (EstadoId) references Estado(EstadoId) not null,
	Foto image not null
)

CREATE TABLE Inscripcion(
	InscripcionId int identity (1,1) primary key not null,
	EstudianteId int foreign key (EstudianteId) references Estudiante(EstudianteId) not null,
	CicloId int foreign key (CicloId) references Ciclo(CicloId) not null,
	AsignaturaId int foreign key (AsignaturaId) references Asignatura(AsignaturaId) not null
)

CREATE TABLE EstadoSalud(
	EstadoSaludId int identity (1,1) primary key not null,
	Nombre varchar(25) not null
)

CREATE TABLE Registro(
	RegistroId int identity (1,1) primary key not null,
	EstudianteId int foreign key (EstudianteId) references Estudiante(EstudianteId) not null,
	EstadoSaludId int foreign key(EstadoSaludId) references EstadoSalud(EstadoSaludId) not null,
	FechaDiagnostico datetime not null,
	TiempoRecuperacion text not null,
	FechaRecuperacion datetime not null
)

CREATE TABLE ListaCasos(
	CasoId int identity (1,1) primary key not null,
	RegistroId int foreign key (RegistroId) references Registro(RegistroId) not null,
	Fecha datetime not null, 
)
