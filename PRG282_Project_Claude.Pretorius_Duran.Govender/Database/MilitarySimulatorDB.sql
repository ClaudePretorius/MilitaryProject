USE master
GO

DROP DATABASE MilitarySimulatorDB
GO

CREATE DATABASE MilitarySimulatorDB
GO

USE MilitarySimulatorDB
GO

CREATE TABLE Aircraft
(
Aircraft_ID int IDENTITY(1,1) PRIMARY KEY ,
[Model_Name] VARCHAR(30) NOT NULL,
[Type] VARCHAR(25) NOT NULL,
Manufacturer VARCHAR(40) NOT NULL,
Health int NOT NULL,
[Fuel_Capacity(L)] INT NOT NULL,
[Fuel_Consumption(L/km)] Float NOT NULL,
[Distance_Per_Tank(km)] Float NOT NULL,
[Speed(km/h)]INT NOT NULL,
[Ammunition_Type] VARCHAR(20) NOT NULL,
[Ammunition_Amount] INT NOT NULL,
[Damage(Per_Ammunition_Type)]INT NOT NULL
)

GO


INSERT INTO Aircraft
VALUES
('F-16 Fighting Falcon', 'Fighter-Jet', 'Lockheed Martin Corporation', 2000,1700,3.36,505.95,2050,'Cannon-Bullet',500,5),
('F-16 Fighting Falcon', 'Fighter-Jet', 'Lockheed Martin Corporation', 2000,1700,3.36,505.95,2100,'Missile',6,100),
('Rockwell B-1 Lancer', 'Bomber', 'Rockwell International', 5000,120000,7.40,16200,1010,'Conventional-Bomb',84,200),
('Rockwell B-1 Lancer', 'Bomber', 'Rockwell International', 7000,120000,7.40,16200,1010,'Nuclear-Bomb',24,2000)

GO

SELECT * FROM Aircraft;
GO