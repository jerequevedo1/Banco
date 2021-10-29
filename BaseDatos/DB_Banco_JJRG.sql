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
	contrasenia varchar(18),
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

-- SP Login

CREATE PROCEDURE [SP_CONSULTAR_USUARIO]
@usuario varchar(50),
@password varchar(18)
AS
BEGIN
	
	SELECT top 1 * from USUARIOS WHERE usuario=@usuario and contrasenia=@password;
END
GO
CREATE proc PA_CONSULTA_CLIENTE_FILTRO
@nroCliente int =null,
@ClienteNombre varchar(150)=null,
@tipo int=null,
@activo varchar(1)
AS
	 if @tipo=0 --filtro por numero cliente 
	select id_cliente 'ID Cliente', nom_cliente Nombre,ape_cliente Apellido, dni DNI,
    direccion Direccion, telefono Telefono, email Email,  'fecha_baja' fechaB from Clientes
	WHERE (@nroCliente is null OR id_cliente=@nroCliente)
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N'))
		order by id_cliente asc     
	 if @tipo=1 --filtro por nombre
		select id_cliente 'ID Cliente', nom_cliente Nombre,ape_cliente Apellido, dni DNI,
        direccion Direccion, telefono Telefono, email Email,  'fecha_baja' fechaB from Clientes
		 WHERE (@ClienteNombre is null OR (nom_cliente like '%' + @ClienteNombre + '%'))
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N'))
		 order by id_cliente asc  
    if @tipo=2 --filtro por bajas
	   select id_cliente 'ID Cliente', nom_cliente Nombre,ape_cliente Apellido, dni DNI,
        direccion Direccion, telefono Telefono, email Email,  'fecha_baja' fechaB from Clientes
		 WHERE 'fecha_baja' is not null
	     order by id_cliente asc
