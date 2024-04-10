create database examen2soft
use examen2soft 

create table trabajador
(id_trabajador int primary key not null,
nombres varchar(50) not null,
apellidos  varchar(50) not null,
sueldo decimal not null,
categoria varchar(50) not null
)


