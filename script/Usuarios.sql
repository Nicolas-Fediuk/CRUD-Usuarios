create database ProyectoUsuarios
go

use ProyectoUsuarios
go

create table Usuario(
DNI_usu varchar(10),
Nombre_usu varchar(15) not null,
Contraseña_usu varchar(15) not null,
Apellido_usu varchar(15) not null,
Correo_usu varchar(30) unique not null,
Celular_usu varchar(15) null default 'Sin celular', 
constraint PK_Usuario primary key (DNI_usu)
)
go

insert into Usuario(DNI_usu,Nombre_usu,Contraseña_usu,Apellido_usu,Correo_usu,Celular_usu)
select '12345678','pablo','123','cabrera','pc@gmail.com',null union
select '09876543','andrea','456','paola','apqgmail.com','1123456789' 
go

select * from Usuario

drop table Usuario