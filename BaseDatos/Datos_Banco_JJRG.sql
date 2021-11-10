USE [BancoJJRG]
GO

INSERT [dbo].[Provincias] ([id_provincia], [nom_provincia]) VALUES (1, N'Córdoba')
INSERT [dbo].[Provincias] ([id_provincia], [nom_provincia]) VALUES (2, N'San Luis')
INSERT [dbo].[Provincias] ([id_provincia], [nom_provincia]) VALUES (3, N'Santa Fe')
INSERT [dbo].[Provincias] ([id_provincia], [nom_provincia]) VALUES (4, N'Buenos Aires')

GO


INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (1, N'Córdoba Capital', 1)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (2, N'Villa Allende', 1)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (3, N'Alta Gracia', 1)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (4, N'Mendiolaza', 1)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (5, N'San Luis Capital', 2)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (6, N'Villa Mercedes', 2)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (7, N'Villa de Merlo', 2)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (8, N'La Punta', 2)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (9, N'Santa Fe Capital', 3)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (10, N'Rosario', 3)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (11, N'Rafaela', 3)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (12, N'Sunchales', 3)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (13, N'CABA', 4)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (14, N'La Plata', 4)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (15, N'Avellaneda', 4)
INSERT [dbo].[Localidades] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (16, N'Morón', 4)

GO


INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (1, N'Centro', 1)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (2, N'Alberdi', 1)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (3, N'Nueva Córdoba', 1)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (4, N'Cerro de las Rosas', 1)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (5, N'San Isidro', 2)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (6, N'San Martín', 2)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (7, N'Parque del Virrey', 3)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (8, N'Portales del Sol', 3)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (9, N'El Talar', 4)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (10, N'Unión', 5)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (11, N'Jardín del Sur', 6)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (12, N'Barranca Colorada', 7)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (13, N'La Candelaria', 8)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (14, N'Sur', 9)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (15, N'Centro', 9)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (16, N'Parque', 10)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (17, N'Abasto', 10)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (18, N'2 de Abril', 11)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (19, N'Barranquitas', 11)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (20, N'Colón', 12)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (21, N'Almagro', 13)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (22, N'Parque Avellaneda', 13)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (23, N'Carmen Oeste', 14)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (24, N'Sarandí', 15)
INSERT [dbo].[Barrios] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (25, N'Santa Laura', 16)

GO


INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [cuil], [direccion], [telefono], [email], [id_barrio], [fecha_alta], [fecha_baja]) VALUES (1, N'Rosalia', N'Suarez', 33567844, 27335678446, N'Tucuman 348', N'3516598223', N'rosisuarez@gmail.com', 1, CAST(N'2021-11-10T00:41:38.360' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [cuil], [direccion], [telefono], [email], [id_barrio], [fecha_alta], [fecha_baja]) VALUES (2, N'Francisco', N'Flores', 28733499, 20287334995, N'San Martin 1145', N'3515451109', N'fflores@hotmail.com', 10, CAST(N'2021-11-10T00:41:38.360' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [cuil], [direccion], [telefono], [email], [id_barrio], [fecha_alta], [fecha_baja]) VALUES (3, N'Ismael', N'Rodriguez', 30045283, 20300452837, N'Rodriguez del Busto 2040', N'3512498709', N'rodiguezismael05@hotmail.com', 4, CAST(N'2021-11-10T00:41:38.363' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [cuil], [direccion], [telefono], [email], [id_barrio], [fecha_alta], [fecha_baja]) VALUES (4, N'Jeremias', N'Quevedo', 12432342, 43534534345, N'9 de julio', N'3516132261', N'jere@gmail.com', 2, CAST(N'2021-11-10T00:47:17.937' AS DateTime), NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [cuil], [direccion], [telefono], [email], [id_barrio], [fecha_alta], [fecha_baja]) VALUES (5, N'Pedrito', N'Clavito', 34242342, 32423423532, N'direccion', N'13423525332', N'email@gmail.com', 21, CAST(N'2021-11-10T01:02:48.777' AS DateTime), CAST(N'2021-11-10T01:02:55.880' AS DateTime))

GO


INSERT [dbo].[Tipos_Cuentas] ([id_tipo_cuenta], [descripcion]) VALUES (1, N'Caja de Ahorro')
INSERT [dbo].[Tipos_Cuentas] ([id_tipo_cuenta], [descripcion]) VALUES (2, N'Cuenta Corriente')
INSERT [dbo].[Tipos_Cuentas] ([id_tipo_cuenta], [descripcion]) VALUES (3, N'Cuenta Sueldo')
SET IDENTITY_INSERT [dbo].[Tipos_Cuentas] OFF
GO


INSERT [dbo].[Cuentas] ([id_cuenta], [cbu], [alias], [saldo_actual], [ultimo_movimiento], [saldo_en_descubierto], [limite_descubierto], [id_cliente], [id_tipo_cuenta], [tipo_moneda], [fecha_alta], [fecha_baja]) VALUES (1, N'0200557341000007712948', N'rosalia.suarez', CAST(34785 AS Decimal(18, 0)), N'Extracción por Cajero Automático Banco Macro Suc 1189', CAST(0 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), 1, 3, N'P', CAST(N'2021-11-10T00:41:38.363' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([id_cuenta], [cbu], [alias], [saldo_actual], [ultimo_movimiento], [saldo_en_descubierto], [limite_descubierto], [id_cliente], [id_tipo_cuenta], [tipo_moneda], [fecha_alta], [fecha_baja]) VALUES (2, N'0200746241000006183303', N'fran.flores', CAST(12790 AS Decimal(18, 0)), N'Depósito por ventanilla Banco Galicia Suc 04689', CAST(0 AS Decimal(18, 0)), CAST(3000 AS Decimal(18, 0)), 2, 1, N'P', CAST(N'2021-11-10T00:41:38.367' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([id_cuenta], [cbu], [alias], [saldo_actual], [ultimo_movimiento], [saldo_en_descubierto], [limite_descubierto], [id_cliente], [id_tipo_cuenta], [tipo_moneda], [fecha_alta], [fecha_baja]) VALUES (3, N'0200746241000436456803', N'Ismael.Rodriguez', CAST(15000 AS Decimal(18, 0)), N'Acreditacion de haberes', CAST(0 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), 3, 1, N'P', CAST(N'2021-11-10T00:41:38.367' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([id_cuenta], [cbu], [alias], [saldo_actual], [ultimo_movimiento], [saldo_en_descubierto], [limite_descubierto], [id_cliente], [id_tipo_cuenta], [tipo_moneda], [fecha_alta], [fecha_baja]) VALUES (4, N'1342342342342323423333', N'jere.alias', CAST(0 AS Decimal(18, 0)), N'', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 4, 1, N'P', CAST(N'2021-11-10T00:47:17.940' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([id_cuenta], [cbu], [alias], [saldo_actual], [ultimo_movimiento], [saldo_en_descubierto], [limite_descubierto], [id_cliente], [id_tipo_cuenta], [tipo_moneda], [fecha_alta], [fecha_baja]) VALUES (5, N'1423423423424434253434', N'jere.al', CAST(10300 AS Decimal(18, 0)), N'', CAST(0 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), 4, 3, N'P', CAST(N'2021-11-10T00:48:14.690' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([id_cuenta], [cbu], [alias], [saldo_actual], [ultimo_movimiento], [saldo_en_descubierto], [limite_descubierto], [id_cliente], [id_tipo_cuenta], [tipo_moneda], [fecha_alta], [fecha_baja]) VALUES (6, N'3424324234234234233433', N'alias.pruebapab', CAST(0 AS Decimal(18, 0)), N'', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 5, 1, N'P', CAST(N'2021-11-10T01:02:48.790' AS DateTime), CAST(N'2021-11-10T01:02:55.880' AS DateTime))

GO


INSERT [dbo].[Tipos_Transacciones] ([id_tipo_transac], [descripcion]) VALUES (1, N'Depósito')
INSERT [dbo].[Tipos_Transacciones] ([id_tipo_transac], [descripcion]) VALUES (2, N'Transferencia')
INSERT [dbo].[Tipos_Transacciones] ([id_tipo_transac], [descripcion]) VALUES (3, N'Acreditación')
INSERT [dbo].[Tipos_Transacciones] ([id_tipo_transac], [descripcion]) VALUES (4, N'Acreditación de haberes')
INSERT [dbo].[Tipos_Transacciones] ([id_tipo_transac], [descripcion]) VALUES (5, N'Pago de Servicio')
INSERT [dbo].[Tipos_Transacciones] ([id_tipo_transac], [descripcion]) VALUES (6, N'Extracción Por Cajero')

GO


INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (1, CAST(N'2021-05-10T00:00:00.000' AS DateTime), CAST(105000 AS Decimal(18, 0)), 4, 1)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (2, CAST(N'2021-05-12T00:00:00.000' AS DateTime), CAST(5000 AS Decimal(18, 0)), 5, 1)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (3, CAST(N'2021-05-12T00:00:00.000' AS DateTime), CAST(15200 AS Decimal(18, 0)), 2, 1)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (4, CAST(N'2021-05-27T00:00:00.000' AS DateTime), CAST(25000 AS Decimal(18, 0)), 5, 1)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (5, CAST(N'2021-06-02T00:00:00.000' AS DateTime), CAST(105000 AS Decimal(18, 0)), 5, 1)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (6, CAST(N'2021-07-24T00:00:00.000' AS DateTime), CAST(14500 AS Decimal(18, 0)), 3, 2)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (7, CAST(N'2021-08-04T00:00:00.000' AS DateTime), CAST(97000 AS Decimal(18, 0)), 3, 2)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (8, CAST(N'2021-08-19T00:00:00.000' AS DateTime), CAST(30000 AS Decimal(18, 0)), 3, 2)
INSERT [dbo].[Transacciones] ([id_transaccion], [fecha], [monto], [id_tipo_transac], [id_cuenta]) VALUES (9, CAST(N'2021-08-20T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), 1, 2)

GO


INSERT [dbo].[Usuarios] ([id_usuario], [usuario], [contrasenia]) VALUES (1, N'jpoltenguerci', N'C123456')
INSERT [dbo].[Usuarios] ([id_usuario], [usuario], [contrasenia]) VALUES (2, N'jquevedo', N'102030$')
INSERT [dbo].[Usuarios] ([id_usuario], [usuario], [contrasenia]) VALUES (3, N'gmedrano', N'405060$')
INSERT [dbo].[Usuarios] ([id_usuario], [usuario], [contrasenia]) VALUES (4, N'rmedina', N'708090$')

GO


