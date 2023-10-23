create database MAXIKIOSCO_DB
use MAXIKIOSCO_DB

create table PROVEDOR(
Id int identity,
Nom_razonsocial varchar(30) not null,
Telefono int not null,
Mail varchar(40) not null,
Direccion varchar(50) not null,
Cuit int not null,
Activo bit default 1,
primary key (Id)
)



insert into PROVEDOR
values ('Coca Cola sociedad anonima', 11338742, 'cocacolasociedadanonima@gmail.com',
'avenida siempre viva', 298649213, 1)
insert into PROVEDOR
values ('Playadito sociedad', 31245645, 'YerbaPlayadito@gmail.com',
'calle falsa 123', 543526546, 1)
insert into PROVEDOR
values ('Taragui', 21242354, 'Taraguilala@gmail.com',
'calle lala', 312412452, 1)


create table PRODUCTO(
Id int identity,
Categoria varchar(25) not null,
Marca varchar(25) not null,
Cantidad int not null default 1,
StockMinimo int not null default 1,
Precio decimal not null,
PrecioProveedor decimal not null,
Activo bit default 1,
IdProvedor int,
primary key(Id),
foreign key (IdProvedor) references PROVEDOR(Id)
)

SELECT * FROM PRODUCTO
insert into PRODUCTO 
values ('Gaseosa','CocaCol',10,5,500,300,1,1)

insert into CLIENTE
values ('Javier','Gonzalez', '36777999', '20367779995', 'respInscripto', '20/3/1994','Av siempre viva 2536','Guernica','jgonzalez@gmail.com', '1134567890',1)
insert into CLIENTE
values ('Daiana','Velazquez', '39888666', '20398886663', 'monotributo', '09/05/1995','Av Olivera 1532','Guernica','dvelazquezz@gmail.com', '1123452160',1)
insert into CLIENTE
values ('Sebastianr','Felsch', '33932126', '20339321265', 'consFinal', '09/06/1988','Calle falsa 123','Guernica','sfelsch@gmail.com', '1137795756',1)


create table CLIENTE(
id int identity,
nombre varchar(25) not null,
apellido varchar(25) not null,
dni varchar(25) not null,
cuilCuit varchar(25) not null,
condicionIva varchar(25) not null,
fechaNacimiento varchar(25),
direccion varchar(25),
localidad varchar(25),
mail varchar(25),
telefono varchar(25),
activo bit not null default 1,
primary key(id)
)

create table ROL (
id int identity,
nombre varchar(30) not null,
descripcion varchar(20) not null,
primary key (id)
)

create table USUARIO (
nombreUsuario varchar(30) unique,
nombre varchar(30) not null,
apellido varchar(30) not null,
contrasenia varchar(30) not null,
idRol int,
primary key (nombreUsuario),
foreign key (idRol) references Rol(id)
)

insert into ROL
values ('Administrador', 'Master')
insert into ROL
values ('Vendedor', 'Normal')

insert into Usuario
values ('javier123','Javier', 'González', 123, 1)

select * from ROL

select * from USUARIO