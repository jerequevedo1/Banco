--Creación de la base de datos "Banco JJRG"
create database BancoJJRG
go
use BancoJJRG
go
create table Provincias
(
	id_provincia int identity(1,1) not null,
	nom_provincia varchar(35),
	constraint pk_id_provincia primary key(id_provincia)
)
go
create table Localidades
(
	id_localidad int identity(1,1) not null,
	nom_localidad varchar(35),
	id_provincia int,
	constraint pk_id_localidad primary key(id_localidad),
	constraint fk_id_provincia foreign key (id_provincia) references Provincias(id_provincia)
)
go
create table Barrios
(
	id_barrio int identity(1,1) not null,
	nom_barrio varchar(40),
	id_localidad int,
	constraint pk_id_barrio primary key(id_barrio),
	constraint fk_id_localidad foreign key (id_localidad) references Localidades(id_localidad)
)
go
create table Tipos_Cuentas
(
	id_tipo_cuenta int identity(1,1) not null,
	descripcion varchar(80),
	constraint pk_id_tipo_cuenta primary key(id_tipo_cuenta)
)
go
create table Tipos_Transacciones
(
	id_tipo_transac int identity(1,1) not null,
	descripcion varchar(80),
	constraint pk_id_tipo_transac primary key(id_tipo_transac)
)
go
create table Usuarios
(
	id_usuario int identity(1,1) not null,
	usuario varchar(50),
	contraseña varchar(18),
	constraint pk_id_usuario primary key(id_usuario)
)
go
create table Clientes
(
	id_cliente int identity(1,1) not null,
	nom_cliente varchar(50),
	ape_cliente varchar(50),
	dni int,
	cuil bigint,
	direccion varchar(100),
	telefono varchar(30),
	email varchar(80),
	id_barrio int,
	constraint pk_id_cliente primary key (id_cliente),
	constraint fk_id_clientes_barrio foreign key (id_barrio) references Barrios(id_barrio)
)
go
create table Cuentas 
(
	id_cuenta int identity(1,1) not null,
	cbu varchar(22),
	alias varchar(20),
	saldo_actual decimal,
	ultimo_movimiento varchar(100),
	saldo_en_descubierto decimal,
	id_cliente int,
	id_tipo_cuenta int,
	tipo_moneda char(1),
	constraint pk_id_cuenta primary key (id_cuenta),
	constraint fk_id_cta_cliente foreign key (id_cliente) references Clientes(id_cliente),
	constraint fk_id_cta_tipo_cta foreign key (id_tipo_cuenta) references Tipos_Cuentas(id_tipo_cuenta)
)
go
create table Transacciones 
(
	id_transaccion int identity(1,1) not null,
	fecha datetime,
	monto decimal,
	id_tipo_transac int,
	id_cuenta int,
	constraint pk_id_transaccion primary key (id_transaccion),
	constraint fk_id_transac_tipo_transac foreign key (id_tipo_transac) references Tipos_Transacciones(id_tipo_transac),
	constraint fk_id_transac_cta foreign key (id_cuenta) references Cuentas(id_cuenta)
)
go

