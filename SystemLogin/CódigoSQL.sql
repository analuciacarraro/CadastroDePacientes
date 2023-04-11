create database Patients

CREATE TABLE Patients (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    CPF NVARCHAR(11) UNIQUE,
    RG NVARCHAR(20),
    StateOfRG NVARCHAR(2),
    Email NVARCHAR(50),
    CellPhone NVARCHAR(20),
    Landline NVARCHAR(20),
    HealthInsurance NVARCHAR(50),
    HealthInsuranceCard NVARCHAR(50),
    CardValidity DATE
)

create database Registro
go
use Registro
create table user_tb
(
id_user int identity (1,1) primary key not null,
usuario varchar(20) not null,
senha varchar(20) not null
)