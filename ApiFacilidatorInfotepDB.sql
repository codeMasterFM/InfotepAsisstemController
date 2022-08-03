create database infotedb;

use infotedb;

create table usuario(
	id_usuario int PRIMARY key identity(1,1),
	usuario varchar(30),
	clave varchar(20),
);

create table asistencia_facilitador(
	id_asis_facilitador int primary key identity(1,1),
	cedula_facilitador VARCHAR(20),
	codigo_materia VARCHAR(20),
	hora_llegada varchar(12),
	fecha date,
	hora_salida VARCHAR(12)

);
	
create table asistencia_participante(
	id_asis_participante int primary key identity(1,1),
	cedula_participante VARCHAR(20),
	codigo_materia VARCHAR(20),
	aula varchar(110),
	hora_llegada varchar(12),
	fecha date,
	hora_salida VARCHAR(12)
);
create table correos(
id int identity(1,1) primary key,
nombre varchar(30),
correo varchar(100)
);

//script nuevo

create database infotedb;

use infotedb;

create table usuario(
id_usuario int PRIMARY key identity(1,1),
usuario varchar(30),
clave varchar(20),
);

create table asistencia_facilitador(
id_asis_facilitador int primary key identity(1,1),
cedula_facilitador VARCHAR(20),
codigo_materia VARCHAR(20),
hora_llegada varchar(12),
fecha date,
hora_salida VARCHAR(12)
);

create table correos(
id_correo int identity(1,1) primary key,
nombre varchar(30),
correo varchar(100)
);

create table asistencia_participante(
id_asis_participante int primary key identity(1,1),
cedula_participante VARCHAR(20),
codigo_materia VARCHAR(20),
aula varchar(110),
hora_llegada varchar(12),
fecha date,
hora_salida VARCHAR(12)
);

create procedure Rango_Fecha_Facilitador
(
@Fecha1 date,
@Fecha2 date
)

as
begin
select * from asistencia_facilitador where fecha between @Fecha1 and @Fecha2
end

exec Rango_Fecha_Facilitador '2022-05-17','2022-07-19'

create procedure Rango_Fecha_Participante
(
@Fecha1 date,
@Fecha2 date
)
as
begin
select * from asistencia_participante where fecha between @Fecha1 and @Fecha2
end

exec Rango_Fecha_Participante '2022-05-17','2022-05-19'


insert into usuario(usuario,clave)
values
('usro-1','1234'),
('usro-2','5678'),
('usro-3','8901'),
('usro-4','2345'),
('usro-5','6789');

insert into asistencia_facilitador(cedula_facilitador,codigo_materia,fecha)
values
('001-987456-2','000258-9','2022-05-17'),
('001-987456-2','000258-9','2022-05-18'),
('001-987456-2','000258-9','2022-05-25'),
('001-987456-2','000258-9','2022-06-04'),
('001-987456-2','000258-9','2022-06-10'),
('001-987456-2','000258-9','2022-07-05'),
('001-987456-2','000258-9','2022-08-30'),
('001-987456-2','000258-9','2022-09-19');

insert into asistencia_participante(cedula_participante,codigo_materia,fecha)
values
('001-987456-2','000258-9','2022-05-17'),
('001-987456-2','000258-9','2022-05-18'),
('001-987456-2','000258-9','2022-05-25'),
('001-987456-2','000258-9','2022-06-04'),
('001-987456-2','000258-9','2022-06-10'),
('001-987456-2','000258-9','2022-07-05'),
('001-987456-2','000258-9','2022-08-30'),
('001-987456-2','000258-9','2022-09-19');

insert into correos(nombre, correo)
values
('yosmaylis','yomi@gmail.com'),
('isaura','isa@gmail.com');
