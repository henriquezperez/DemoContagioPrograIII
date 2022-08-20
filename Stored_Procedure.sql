USE ControlRegistrosCovi1d9
go

CREATE PROC sp_CicloSelectAll
AS
BEGIN
	select * FROM Ciclo
end
go
	
create proc sp_CicloInsert
	@Nombre varchar (10),
	@Anio varchar (4)
as 
begin
	insert into Ciclo(Nombre, Anio) values (@Nombre, @Anio)
end
go

CREATE PROC sp_CarreraSelectAll
AS
BEGIN
	select * FROM Carrera
end	
GO

create proc sp_CarreraInsert
	@Nombre text,
	@FacultadId int
as 
begin
	insert into Carrera(Nombre, FacultadId) values (@Nombre, @FacultadId)
end
go

CREATE PROC sp_AulaSelectAll
AS
BEGIN
	SELECT * FROM Aula
END
GO

CREATE PROC sp_AulaInsert
	@Nombre text
AS 
BEGIN
	INSERT INTO Aula(Nombre) VALUES (@Nombre)
END
GO

CREATE PROC sp_AsignaturaSelectAll
AS
BEGIN
	SELECT * FROM Asignatura
END
GO

CREATE PROC sp_AsignaturaInsert
	@Nombre text,
	@Codigo text,
	@AulaId int,
	@CicloId int,
	@FacultadId int
AS 
BEGIN
	INSERT INTO Asignatura(Nombre, Codigo, AulaId, CicloId, FacultadId)
	VALUES (@Nombre, @Codigo, @AulaId, @CicloId, @FacultadId)
END
GO

CREATE PROC sp_FacultadSelectAll
AS
BEGIN
	SELECT * FROM Facultad
END
GO

CREATE PROC sp_FacultadInsert
	@Nombre text
AS 
BEGIN
	INSERT INTO Facultad(Nombre) VALUES (@Nombre)
END
GO

CREATE PROC sp_EstudianteSelectAll
AS
BEGIN
	SELECT * FROM Estudiante
END
GO

CREATE PROC sp_EstudianteInsert
	@Nombres text,
	@Apellidos text,
	@Codigo text,
	@CarreraId int,
	@NumTelefono text,
	@Genero text,
	@Natalicio text,
	@EstadoId int
AS 
BEGIN
	INSERT INTO Estudiante(Nombres, Apellidos, Codigo, CarreraId, NumTelefono, Genero, Natalicio, EstadoId)
	VALUES (@Nombres, @Apellidos, @Codigo, @CarreraId, @NumTelefono, @Genero, @Natalicio, @EstadoId)
END
GO
/*
CREATE PROC sp_EstudianteInsert
	@Nombres text,
	@Apellidos text,
	@Codigo text,
	@CarreraId int,
	@NumTelefono text,
	@Genero text,
	@Natalicio text,
	@EstadoId int,
	@Foto Image
AS 
BEGIN
	INSERT INTO Estudiante(Nombres, Apellidos, Codigo, CarreraId, NumTelefono, Genero, Natalicio, EstadoId, Foto)
	VALUES (@Nombres, @Apellidos, @Codigo, @CarreraId, @NumTelefono, @Genero, @Natalicio, @EstadoId, @Foto)
END
GO
*/