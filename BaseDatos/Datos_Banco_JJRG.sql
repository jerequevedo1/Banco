-- Datos Insertados - BD Farmacéutica
set dateformat dmy
--Provincias

Insert into Provincias (nom_provincia) values ('Córdoba')
Insert into Provincias (nom_provincia) values ('San Luis')
Insert into Provincias (nom_provincia) values ('Santa Fe')
Insert into Provincias (nom_provincia) values ('Buenos Aires')

--Select *
--From Provincias

--Localidades

Insert into Localidades (id_provincia, nom_localidad) values (1,'Córdoba Capital')
Insert into Localidades (id_provincia, nom_localidad) values (1, 'Villa Allende')
Insert into Localidades (id_provincia, nom_localidad) values (1, 'Alta Gracia')
Insert into Localidades (id_provincia, nom_localidad) values (1, 'Mendiolaza')

Insert into Localidades (id_provincia, nom_localidad) values (2,'San Luis Capital')
Insert into Localidades (id_provincia, nom_localidad) values (2, 'Villa Mercedes')
Insert into Localidades (id_provincia, nom_localidad) values (2, 'Villa de Merlo')
Insert into Localidades (id_provincia, nom_localidad) values (2, 'La Punta')

Insert into Localidades (id_provincia, nom_localidad) values (3,'Santa Fe Capital')
Insert into Localidades (id_provincia, nom_localidad) values (3, 'Rosario')
Insert into Localidades (id_provincia, nom_localidad) values (3, 'Rafaela')
Insert into Localidades (id_provincia, nom_localidad) values (3, 'Sunchales')

Insert into Localidades (id_provincia, nom_localidad) values (4,'CABA')
Insert into Localidades (id_provincia, nom_localidad) values (4, 'La Plata')
Insert into Localidades (id_provincia, nom_localidad) values (4, 'Avellaneda')
Insert into Localidades (id_provincia, nom_localidad) values (4, 'Morón')

--Select *
--From Localidades

--Barrios

Insert into Barrios (id_localidad, nom_barrio) values (1, 'Centro')
Insert into Barrios (id_localidad, nom_barrio) values (1, 'Alberdi')
Insert into Barrios (id_localidad, nom_barrio) values (1, 'Nueva Córdoba')
Insert into Barrios (id_localidad, nom_barrio) values (1, 'Cerro de las Rosas')
Insert into Barrios (id_localidad, nom_barrio) values (2, 'San Isidro')
Insert into Barrios (id_localidad, nom_barrio) values (2, 'San Martín')
Insert into Barrios (id_localidad, nom_barrio) values (3, 'Parque del Virrey')
Insert into Barrios (id_localidad, nom_barrio) values (3, 'Portales del Sol')
Insert into Barrios (id_localidad, nom_barrio) values (4, 'El Talar')

Insert into Barrios (id_localidad, nom_barrio) values (5, 'Unión')
Insert into Barrios (id_localidad, nom_barrio) values (6, 'Jardín del Sur')
Insert into Barrios (id_localidad, nom_barrio) values (7, 'Barranca Colorada')
Insert into Barrios (id_localidad, nom_barrio) values (8, 'La Candelaria')

Insert into Barrios (id_localidad, nom_barrio) values (9, 'Sur')
Insert into Barrios (id_localidad, nom_barrio) values (9, 'Centro')
Insert into Barrios (id_localidad, nom_barrio) values (10, 'Parque')
Insert into Barrios (id_localidad, nom_barrio) values (10, 'Abasto')
Insert into Barrios (id_localidad, nom_barrio) values (11, '2 de Abril')
Insert into Barrios (id_localidad, nom_barrio) values (11, 'Barranquitas')
Insert into Barrios (id_localidad, nom_barrio) values (12, 'Colón')

Insert into Barrios (id_localidad, nom_barrio) values (13, 'Almagro')
Insert into Barrios (id_localidad, nom_barrio) values (13, 'Parque Avellaneda')
Insert into Barrios (id_localidad, nom_barrio) values (14, 'Carmen Oeste')
Insert into Barrios (id_localidad, nom_barrio) values (15, 'Sarandí')
Insert into Barrios (id_localidad, nom_barrio) values (16, 'Santa Laura')

--Select *
--From Barrios

--Usuarios

Insert into Usuarios (usuario, contrasenia) values ('jpoltenguerci', 'C123456')
Insert into Usuarios (usuario, contrasenia) values ('jquevedo', '102030$')
Insert into Usuarios (usuario, contrasenia) values ('gmedrano', '405060$')
Insert into Usuarios (usuario, contrasenia) values ('rmedina', '708090$')

--Select *
--From Usuarios

--Tipos de Cuentas

Insert into Tipos_Cuentas (descripcion) values ('Caja de Ahorro')
Insert into Tipos_Cuentas (descripcion) values ('Cuenta Corriente')
Insert into Tipos_Cuentas (descripcion) values ('Cuenta Sueldo')

--Select *
--From Tipos_Cuentas

--Tipos de Transacciones

Insert into Tipos_Transacciones (descripcion) values ('Depósito')
Insert into Tipos_Transacciones (descripcion) values ('Transferencia')
Insert into Tipos_Transacciones (descripcion) values ('Acreditación')
Insert into Tipos_Transacciones (descripcion) values ('Acreditación de haberes')
Insert into Tipos_Transacciones (descripcion) values ('Pago de Servicio')
Insert into Tipos_Transacciones (descripcion) values ('Extracción Por Cajero')

--Select *
--From Tipos_Transacciones

--Clientes

Insert into Clientes (nom_cliente, ape_cliente, dni, cuil, direccion, telefono, email, id_barrio,fecha_alta,fecha_baja) values ('Rosalia', 'Suarez', 33567844, 27335678446, 'Tucuman 348', '3516598223', 'rosisuarez@gmail.com', 1,getdate(),null)
Insert into Clientes (nom_cliente, ape_cliente, dni, cuil, direccion, telefono, email, id_barrio,fecha_alta,fecha_baja) values ('Francisco', 'Flores', 28733499, 20287334995, 'San Martin 1145', '3515451109', 'fflores@hotmail.com', 10,getdate(),null)
Insert into Clientes (nom_cliente, ape_cliente, dni, cuil, direccion, telefono, email, id_barrio,fecha_alta,fecha_baja) values ('Ismael', 'Rodriguez', 30045283, 20300452837, 'Rodriguez del Busto 2040', '3512498709', 'rodiguezismael05@hotmail.com', 4,getdate(),null)

--Select *
--From Clientes

--Cuentas

Insert into Cuentas (cbu, alias, saldo_actual, ultimo_movimiento, saldo_en_descubierto,limite_descubierto, id_cliente, id_tipo_cuenta, tipo_moneda,fecha_alta,fecha_baja) values ('0200557341000007712948', 'rosalia.suarez', 34785, 'Extracción por Cajero Automático Banco Macro Suc 1189', 0,1000, 1, 3, 'P',getdate(),null)
Insert into Cuentas (cbu, alias, saldo_actual, ultimo_movimiento, saldo_en_descubierto,limite_descubierto, id_cliente, id_tipo_cuenta, tipo_moneda,fecha_alta,fecha_baja) values ('0200746241000006183303', 'fran.flores', 12790, 'Depósito por ventanilla Banco Galicia Suc 04689', 0,3000, 2, 1, 'P',getdate(),null)
Insert into Cuentas (cbu, alias, saldo_actual, ultimo_movimiento, saldo_en_descubierto,limite_descubierto, id_cliente, id_tipo_cuenta, tipo_moneda,fecha_alta,fecha_baja) values ('0200746241000436456803', 'Ismael.Rodriguez', 15000, 'Acreditacion de haberes', 0,5000, 3, 1, 'P',getdate(),null)


--Select *
--From Cuentas

--Transacciones

Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('10/05/2021', 105000, 4, 1)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('12/05/2021', 5000, 5, 1)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('12/05/2021', 15200, 2, 1)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('27/05/2021', 25000, 5, 1)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('02/06/2021', 105000, 5, 1)

Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('24/07/2021', 14500, 3, 2)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('04/08/2021', 97000, 3, 2)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('19/08/2021', 30000, 3, 2)
Insert into Transacciones (fecha, monto, id_tipo_transac, id_cuenta) values ('20/08/2021', 20000, 1, 2)


--Select *
--From Transacciones

--hacer esto por unica vez y eliminar lineas
update Cuentas
set fecha_alta=getdate()
update Clientes
set fecha_alta=getdate()

