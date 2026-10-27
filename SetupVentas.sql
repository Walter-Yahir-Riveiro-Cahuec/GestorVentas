-- =============================================
-- Script: SetupVentas.sql
-- Propósito: Creación de la base de datos GestorVentasDB, 
--            tabla Ventas e inserción de datos de prueba.
-- =============================================

IF DB_ID('GestorVentasDB') IS NULL
BEGIN
    CREATE DATABASE GestorVentasDB;
END
GO

USE GestorVentasDB;
GO

-- Creación de la tabla Ventas si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Ventas' AND type = 'U')
BEGIN
    CREATE TABLE Ventas (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Cliente NVARCHAR(100) NOT NULL,
        Fecha DATETIME NOT NULL,
        Monto DECIMAL(18, 2) NOT NULL
    );
END
GO

-- Inserción de 5 registros de datos de prueba variados si la tabla está vacía
IF NOT EXISTS (SELECT 1 FROM Ventas)
BEGIN
    INSERT INTO Ventas (Cliente, Fecha, Monto) VALUES 
    (N'Carlos Mendoza', '2026-01-15T10:30:00', 1250.50),
    (N'Ana María Gómez', '2026-02-20T14:15:00', 450.75),
    (N'Roberto Valenzuela', '2026-03-05T09:00:00', 3200.00),
    (N'Lucía Fernández', '2026-03-18T16:45:00', 890.25),
    (N'Marcos Delgado', '2026-04-02T11:20:00', 2150.80);
END
GO

-- Verificación de datos insertados
SELECT Id, Cliente, Fecha, Monto FROM Ventas;
GO
