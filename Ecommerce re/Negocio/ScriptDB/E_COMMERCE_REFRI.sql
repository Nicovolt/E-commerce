USE master;
GO

-- Eliminar la base de datos si existe
IF EXISTS(SELECT name FROM sys.databases WHERE name = 'E_COMMERCE_REFRI')
BEGIN
    ALTER DATABASE E_COMMERCE_REFRI SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE E_COMMERCE_REFRI;
END
GO

CREATE DATABASE E_COMMERCE_REFRI;
GO

USE E_COMMERCE_REFRI;
GO

-- Crear las tablas base (sin dependencias)
CREATE TABLE Articulo (
    id_articulo INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(90) NOT NULL,
    precio float NOT NULL,
    id_marca VARCHAR(50) NOT NULL,
    id_categoria VARCHAR(50),
	stock int,

);
