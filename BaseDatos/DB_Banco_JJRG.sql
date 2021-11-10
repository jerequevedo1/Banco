--Creación de la base de datos "Banco JJRG"
set dateformat dmy
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
	fecha_alta datetime, 
	fecha_baja datetime
	constraint pk_id_cliente primary key (id_cliente),
	constraint fk_id_clientes_barrio foreign key (id_barrio) references Barrios(id_barrio)
)
go
create table Cuentas 
(
	id_cuenta int identity(1,1) not null,
	cbu varchar(22),
	alias varchar(20),
	saldo_actual decimal(18,0),
	ultimo_movimiento varchar(100),
	saldo_en_descubierto decimal(18,0),
	limite_descubierto decimal(18,0),
	id_cliente int,
	id_tipo_cuenta int,
	tipo_moneda char(1),
	fecha_alta datetime, 
	fecha_baja datetime
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
create PROC [dbo].[PA_CONSULTA_CLIENTE_FILTRO]
@nroCliente int =null,
@ClienteNombre varchar(150)=null,
@tipo int,
@fechaDesde datetime=null,
@fechaHasta datetime=null,
@activo varchar(1)
AS
	 if @tipo=0 --filtro por numero cliente 
		select id_cliente 'ID Cliente', nom_cliente Nombre,ape_cliente Apellido, dni DNI,
		direccion Direccion, telefono Telefono, email Email,fecha_baja fechaBaja,fecha_alta fechaAlta 
		from Clientes
		WHERE (@nroCliente is null OR id_cliente=@nroCliente)
			 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N' and fecha_baja IS  NULL))
			AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,fecha_alta) > @fechaDesde AND convert(date,fecha_alta) <= @fechaHasta))
		order by id_cliente asc     
	 if @tipo=1 --filtro por cliente
		select id_cliente 'ID Cliente', nom_cliente Nombre,ape_cliente Apellido, dni DNI,
        direccion Direccion, telefono Telefono, email Email,fecha_baja fechaBaja,fecha_alta fechaAlta 
		from Clientes
		WHERE (@ClienteNombre is null OR (nom_cliente like '%' + @ClienteNombre + '%')OR(ape_cliente like '%' + @ClienteNombre + '%'))
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N' and fecha_baja IS  NULL))
		 AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,fecha_alta) > @fechaDesde AND convert(date,fecha_alta) <= @fechaHasta))
		order by id_cliente asc  
    if @tipo=2 --filtro por bajas
	   select id_cliente 'ID Cliente', nom_cliente Nombre,ape_cliente Apellido, dni DNI,
        direccion Direccion, telefono Telefono, email Email,fecha_baja fechaBaja,fecha_alta fechaAlta 
		from Clientes
		WHERE ((@activo = 'N' or @activo = 'S') and fecha_baja IS NOT NULL) and
		(@ClienteNombre is null OR (nom_cliente like '%' + @ClienteNombre + '%')OR(ape_cliente like '%' + @ClienteNombre + '%'))
	    AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,fecha_alta) > @fechaDesde AND convert(date,fecha_alta) <= @fechaHasta))
		order by id_cliente asc
GO
create PROC PA_CONSULTA_CUENTA_FILTRO
@nroCuenta int =null,
@cbu varchar(22)=null,
@alias varchar(22)=null,
@ClienteNombre varchar(150)=null,
@fechaDesde date=null,
@fechaHasta date=null,
@tipo int,
@activo varchar(1)
AS
	  if @tipo=0 --filtro por numero cuenta 
		select id_cuenta 'ID Cuenta',nom_cliente Nombre,ape_cliente Apellido, dni DNI,
		tc.descripcion,cbu Cbu,alias Alias,tipo_moneda 'Tipo Moneda',saldo_actual saldo,
		c.fecha_baja fechaBaja,c.fecha_alta fechaAlta,c.id_cliente,tc.id_tipo_cuenta
		from Cuentas c join Clientes cl on c.id_cliente=cl.id_cliente 
		join Tipos_Cuentas tc on tc.id_tipo_cuenta=c.id_tipo_cuenta
		WHERE (@nroCuenta is null OR id_cuenta=@nroCuenta)
			 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N' and c.fecha_baja IS  NULL))
			 AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
		order by id_cuenta asc     
	 if @tipo=1 --filtro por cliente
		select id_cuenta 'ID Cuenta',nom_cliente Nombre,ape_cliente Apellido, dni DNI,
		tc.descripcion,cbu Cbu,alias Alias,tipo_moneda 'Tipo Moneda',saldo_actual saldo,
		c.fecha_baja fechaBaja,c.fecha_alta fechaAlta,c.id_cliente,tc.id_tipo_cuenta
		from Cuentas c join Clientes cl on c.id_cliente=cl.id_cliente 
		join Tipos_Cuentas tc on tc.id_tipo_cuenta=c.id_tipo_cuenta
		WHERE (@ClienteNombre is null OR (nom_cliente like '%' + @ClienteNombre + '%')OR(ape_cliente like '%' + @ClienteNombre + '%'))
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N' and c.fecha_baja IS  NULL))
		 AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
		order by id_cuenta asc  
    if @tipo=2 --filtro por cbu
		select id_cuenta 'ID Cuenta',nom_cliente Nombre,ape_cliente Apellido, dni DNI,
		tc.descripcion,cbu Cbu,alias Alias,tipo_moneda 'Tipo Moneda',saldo_actual saldo,
		c.fecha_baja fechaBaja,c.fecha_alta fechaAlta,c.id_cliente,tc.id_tipo_cuenta
		from Cuentas c join Clientes cl on c.id_cliente=cl.id_cliente 
		join Tipos_Cuentas tc on tc.id_tipo_cuenta=c.id_tipo_cuenta
		WHERE (@cbu is null OR (cbu like '%' + trim(str(@cbu)) + '%'))
			 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N' and c.fecha_baja IS  NULL))
			 AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
	    order by id_cuenta asc
	if @tipo=3 --filtro por alias
		select id_cuenta 'ID Cuenta',nom_cliente Nombre,ape_cliente Apellido, dni DNI,
		tc.descripcion,cbu Cbu,alias Alias,tipo_moneda 'Tipo Moneda',saldo_actual saldo,
		c.fecha_baja fechaBaja,c.fecha_alta fechaAlta,c.id_cliente,tc.id_tipo_cuenta
		from Cuentas c join Clientes cl on c.id_cliente=cl.id_cliente 
		join Tipos_Cuentas tc on tc.id_tipo_cuenta=c.id_tipo_cuenta
		WHERE (@alias is null OR (alias like '%' + @alias + '%'))
			 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N' and c.fecha_baja IS  NULL))
			 AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
	    order by id_cuenta asc
	if @tipo=4 --filtro por bajas
		select id_cuenta 'ID Cuenta',nom_cliente Nombre,ape_cliente Apellido, dni DNI,
		tc.descripcion,cbu Cbu,alias Alias,tipo_moneda 'Tipo Moneda',saldo_actual saldo,
		c.fecha_baja fechaBaja,c.fecha_alta fechaAlta,c.id_cliente,tc.id_tipo_cuenta
		from Cuentas c join Clientes cl on c.id_cliente=cl.id_cliente 
		join Tipos_Cuentas tc on tc.id_tipo_cuenta=c.id_tipo_cuenta
		WHERE ((@activo = 'N' or @activo = 'S') and c.fecha_baja IS NOT NULL) and 
		(@ClienteNombre is null OR (nom_cliente like '%' + @ClienteNombre + '%')OR(ape_cliente like '%' + @ClienteNombre + '%'))
	    AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
		order by id_cuenta asc
go
create PROC [dbo].[PA_CONSULTA_CLIENTE_SIMPLE]
@ClienteNombre varchar(150)
as
		if @ClienteNombre not like ''
			select id_cliente,nom_cliente,ape_cliente,dni,cuil,direccion,telefono,email,b.id_barrio,l.id_localidad,p.id_provincia
			from Clientes c join Barrios b on b.id_barrio=c.id_barrio
				join Localidades l on l.id_localidad=b.id_localidad
				join Provincias p on p.id_provincia=l.id_provincia
			WHERE ((nom_cliente like '%' + @ClienteNombre + '%')OR(ape_cliente like '%' + @ClienteNombre + '%'))
			and c.fecha_baja is null
			order by id_cliente asc 
go
Create PROC PA_CONSULTA_TIPO_CUENTA
as
			select *
			from Tipos_Cuentas
			order by 2 asc 
go
--SP
CREATE PROC SP_CONSULTAR_CLIENTE_POR_ID
@nro int
AS
BEGIN

	SELECT c.id_cliente, c.nom_cliente, c.ape_cliente, c.dni,  c.cuil,c.direccion,c.telefono,c.email,
	c.id_barrio, c.fecha_baja, c.fecha_alta, l.id_localidad, p.id_provincia
	FROM Clientes c, Cuentas cu, Barrios b, Localidades l, Provincias p
	WHERE c.id_cliente = cu.id_cliente
	AND c.id_barrio= b.id_barrio
    AND b.id_localidad=	l.id_localidad
	AND l.id_provincia=p.id_provincia
	AND c.id_cliente= @nro;
END

go
create proc PA_INSERTAR_CLIENTE
@nom_cliente varchar(50),
@ape_cliente varchar(40),
@dni int,
@cuil bigint,
@direccion varchar (50),
@telefono  varchar(50),
@email    varchar(50),
@id_barrio int,
@id_cliente int output
as
 insert into Clientes values(@nom_cliente,@ape_cliente,@dni,@cuil,@direccion,@telefono,@email,@id_barrio,getdate(),null)
 set @id_cliente = SCOPE_IDENTITY();
go
create proc PA_INSERTAR_CUENTA
@cbu varchar(22),
@alias varchar(20),
@saldo_actual decimal(18,0),
@limite_descubierto decimal(18,0),
@id_cliente int,
@id_tipo_cuenta int,
@tipo_moneda char
as
	insert into Cuentas values(@cbu,@alias,@saldo_actual,'',0,@limite_descubierto,@id_cliente,@id_tipo_cuenta,@tipo_moneda,getdate(),null)
go
create proc PA_EDITAR_CLIENTE
      @id_cliente int,
      @nom_cliente varchar(50),
      @ape_cliente varchar(40),
      @dni int,
      @cuil bigint,
      @direccion varchar (50),
      @telefono  varchar(50),
      @email    varchar(50),
      @id_barrio int
	  AS
     update Clientes set
      nom_cliente=@nom_cliente,
      ape_cliente=@ape_cliente,
      dni=@dni,
      cuil=@cuil,
      direccion=@direccion,
      telefono=@telefono,
      email=@email,
      id_barrio=@id_barrio
	  where id_cliente=@id_cliente
go
create PROCEDURE SP_CONSULTAR_PROVINCIAS
AS
BEGIN
	
	SELECT * FROM Provincias order by 2 asc;
END
go

create PROC PA_REPORTE_CUENTAS_CLIENTE 
 @saldoMinimo decimal(18)
as  
  SELECT 
  Clientes.id_cliente, Clientes.nom_cliente, Clientes.ape_cliente, Cuentas.id_cuenta, Cuentas.cbu, Cuentas.saldo_actual  
    FROM   Clientes 
	INNER JOIN  Cuentas ON Clientes.id_cliente = Cuentas.id_cliente   
	where saldo_actual >= @saldoMinimo 
go

create PROC PA_EDITAR_CUENTA
@id_cuenta int,
@cbu varchar(22),
@alias varchar(20),
@saldo_actual decimal(18,0),
@limite_descubierto decimal(18,0),
@id_cliente int,
@id_tipo_cuenta int,
@tipo_moneda char
as
	update Cuentas set
	cbu=@cbu,
	alias=@alias,
	saldo_actual=@saldo_actual,
	limite_descubierto=@limite_descubierto,
	id_cliente=@id_cliente,
	id_tipo_cuenta=@id_tipo_cuenta,
	tipo_moneda=@tipo_moneda
	where id_cuenta=@id_cuenta


go
     --sp
Create PROC PA_DELETE_CUENTA
@nro_cuenta int
AS
BEGIN
	UPDATE CUENTAS SET fecha_baja = GETDATE()
	WHERE id_cuenta = @nro_cuenta;	
END

go
create PROC PA_DELETE_CLIENTE
@nro_cli int
AS
BEGIN
	UPDATE Clientes SET fecha_baja = GETDATE()
	WHERE id_cliente = @nro_cli;
	UPDATE Cuentas SET fecha_baja = GETDATE()
	WHERE id_cliente = @nro_cli;


END

GO

CREATE PROCEDURE SP_CONSULTAR_LOCALIDADES
@id_prov int
AS
BEGIN
	SELECT * FROM Localidades  where id_provincia=@id_prov order by 2 asc;
END

GO
CREATE  PROCEDURE SP_CONSULTAR_BARRIOS
@id_loc int
AS
BEGIN
	
	SELECT * FROM BARRIOS where id_localidad=@id_loc order by 2 asc;
END
GO
create PROCEDURE PA_CONSULTAR_CUENTA_POR_ID
@nro int
AS
	select c.id_cliente,nom_cliente,ape_cliente, dni,cuil,direccion,telefono,l.id_localidad,p.id_provincia,b.id_barrio,email,
		id_cuenta,cbu,alias,saldo_actual,limite_descubierto,tc.id_tipo_cuenta,tipo_moneda,
		c.fecha_baja,c.fecha_alta
	from Cuentas c join Clientes cl on c.id_cliente=cl.id_cliente 
		join Tipos_Cuentas tc on tc.id_tipo_cuenta=c.id_tipo_cuenta
		join Barrios b on b.id_barrio=cl.id_barrio
		join Localidades l on l.id_localidad=b.id_localidad
		join Provincias p on p.id_provincia=l.id_provincia
	where c.id_cuenta=@nro
GO
create proc PA_CONSULTA_TRANSACCIONES
@nroTransaccion int=null,
@nom_cliente varchar(25)=null,
@fechaDesde datetime=null,
@fechaHasta datetime=null,
@tipo int
AS
set dateformat dmy
if @tipo=0
SELECT id_transaccion,fecha,c.id_cuenta,ape_cliente,nom_cliente, monto,tt.descripcion
FROM Transacciones t join Tipos_Transacciones tt on t.id_tipo_transac=tt.id_tipo_transac
	join Cuentas c on c.id_cuenta=t.id_cuenta
	join Clientes cl on  cl.id_cliente=c.id_cliente
WHERE (@nroTransaccion is null OR id_transaccion=@nroTransaccion)
		AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
if @tipo=1
SELECT id_transaccion,fecha,c.id_cuenta,ape_cliente,nom_cliente, monto,tt.descripcion
FROM Transacciones t join Tipos_Transacciones tt on t.id_tipo_transac=tt.id_tipo_transac
	join Cuentas c on c.id_cuenta=t.id_cuenta
	join Clientes cl on  cl.id_cliente=c.id_cliente
WHERE (@nom_cliente is null OR (nom_cliente like '%' + @nom_cliente + '%')
		OR(ape_cliente like '%' + @nom_cliente + '%'))
		AND((@fechaDesde is null and @fechaHasta is  null) OR (convert(date,c.fecha_alta) > @fechaDesde AND convert(date,c.fecha_alta) <= @fechaHasta))
GO
CREATE PROC PA_PROXIMA_CUENTA
@next int OUTPUT
AS
	SET @next = (SELECT MAX(id_cuenta)+1  FROM Cuentas)
GO
CREATE proc PA_PROXIMO_CLIENTE
@next int OUTPUT
AS
	SET @next = (SELECT MAX(id_cliente)+1  FROM Clientes)
