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
	insert into Ciclo(Nombre) values (@Nombre)
	insert into Ciclo(Anio) values (@Anio)
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
	insert into Carrera(Nombre) values (@Nombre)
	insert into Carrera(FacultadId) values (@FacultadId)
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
	INSERT INTO Asignatura(Nombre) VALUES (@Nombre)
	INSERT INTO Asignatura(Codigo) VALUES (@Codigo)
	INSERT INTO Asignatura(AulaId) VALUES (@AulaId)
	INSERT INTO Asignatura(CicloId) VALUES (@CicloId)
	INSERT INTO Asignatura(FacultadId) VALUES (@FacultadId)
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