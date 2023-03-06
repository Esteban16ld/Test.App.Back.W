USE MASTER
GO

IF NOT EXISTS(SELECT name FROM master.dbo.sysdatabases WHERE name ='TestAppW_DB')

CREATE DATABASE TestAppW_DB

GO

USE TestAppW_DB

GO


IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Riders')

CREATE TABLE Riders(
Id INT PRIMARY KEY IDENTITY (1,1),
IdDriver int not null,
Identification varchar(50) not null,
Name varchar (50) not null,
LastName varchar(50) not null,
)

GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Drivers')

CREATE TABLE Drivers(
Id INT PRIMARY KEY IDENTITY (1,1),
Identification varchar(50) not null,
Name varchar (50) not null,
LastName varchar(50) not null,
IsOccupied bit not null,
CarType varchar(50) not null
)

GO

ALTER TABLE Riders
ADD CONSTRAINT FK_Drivers_Riders
FOREIGN KEY (IdDriver) REFERENCES Drivers(Id)


INSERT INTO Drivers(Identification, Name, LastName, IsOccupied, CarType)
VALUES('6255549821', 'Camilo', 'Lopez', 0, 'Aveo GT')

INSERT INTO Drivers(Identification, Name, LastName, IsOccupied, CarType)
VALUES('123549821', 'Alberto', 'Perez', 0, 'Mustang GT')

INSERT INTO Drivers(Identification, Name, LastName, IsOccupied, CarType)
VALUES('1547656821', 'Lautaro', 'Higuita', 0, 'Spark GT')


INSERT INTO Riders(IdDriver, Identification, Name, LastName)
VALUES(1, '123456789', 'Pedro', 'Cardenas')

INSERT INTO Riders(IdDriver, Identification, Name, LastName)
VALUES(1, '123456549', 'Arturo', 'Caceres')

INSERT INTO Riders(IdDriver, Identification, Name, LastName)
VALUES(1, '124510009', 'Leo', 'Castillo')