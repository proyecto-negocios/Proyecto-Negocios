USE tempdb
go

IF NOT EXISTS(SELECT * FROM sys.databases WHERE [name] = 'Estacionamiento')
	BEGIN
		CREATE DATABASE Estacionamiento
	END
GO

CREATE SCHEMA Park
GO

USE Estacionamiento
GO

-- Creacion de las Tablas 
CREATE TABLE Park.Tipo_Carro
(
	id INT IDENTITY (1,1) NOT NULL
	CONSTRAINT PK_Tipo_Carro_id PRIMARY KEY CLUSTERED,
	tipo_carro NVARCHAR (30) NOT NULL 
)
GO

CREATE TABLE Park.Carro
(
	id INT IDENTITY (1,1) NOT NULL
	CONSTRAINT PK_Carro_id PRIMARY KEY CLUSTERED,
	placa NVARCHAR (30) NOT NULL,
	fecha_ingreso DATETIME,
	fecha_salida DATETIME	
)
GO

CREATE TABLE Park.Cobro
(
	id_cobro INT IDENTITY (1,1) NOT NULL,
	id INT IDENTITY (1,1) NOT NULL,
	fecha_ingreso DATETIME,
	fecha_salida DATETIME	
)


