CREATE DATABASE PROYECTO_UAM_technologies;
USE PROYECTO_UAM_technologies
SELECT *FROM CLIENTE
---------------------------------------------------------------CLIENTES
CREATE TABLE CLIENTE(
ID INT IDENTITY(01,1)PRIMARY KEY,
NOMBRES VARCHAR (100),
APELLIDOS VARCHAR (100),
DNI CHAR(8),
PROVINCIA VARCHAR(100),
GENERO VARCHAR(30),
EDAD INT,
DIRECCION VARCHAR (100),
FECHA date,
FOTO IMAGE 
)




---STORE PROCEDURE PARA REGISTRAR CLIENTES

CREATE PROCEDURE REGISTRAR_CLIENTE
	@NOMBRES varchar(100),
	@APELLIDOS varchar(100),
	@DNI char(8),
	@EDAD int,
	@DIRECCION varchar(100),
	@PROVINCIA varchar(100),
	@GENERO VARCHAR(30),
	@FOTO image
	
AS
BEGIN
	insert into CLIENTE(NOMBRES,APELLIDOS,DNI,EDAD,DIRECCION,PROVINCIA,GENERO,FECHA,FOTO)	values 
	(@NOMBRES,@APELLIDOS,@DNI,@EDAD,@DIRECCION,@PROVINCIA,@GENERO,GETDATE(),@FOTO)
END
GO

select *from CLIENTE

----STORE PROCEDURE PARA ELIMINAR CLIENTES
create procedure BORRAR_CLIENTE
@ID INT
as
BEGIN
DELETE FROM CLIENTE WHERE ID = @ID;
END


----STORE PROCEDURE PARA EDITAR CLIENTES
CREATE PROCEDURE EDITA_CLIENTES
	@NOMBRES varchar(100),
	@APELLIDOS varchar(100),
	@DNI char(8),
	@EDAD int,
	@DIRECCION varchar(100),
	@PROVINCIA varchar(100),
	@FOTO image
AS
BEGIN
    UPDATE CLIENTE SET NOMBRES=@NOMBRES,APELLIDOS=@APELLIDOS,EDAD=@EDAD,
    DIRECCION=@DIRECCION,PROVINCIA=@PROVINCIA,FOTO=@FOTO WHERE @NOMBRES = @NOMBRES;

END


------------------------------------------------------------------------PROVINCIAS

CREATE TABLE PROVINCIAS(
IDPROVINCIAS INT IDENTITY(1,1),
PROVINCIA VARCHAR(40),

)

Insert into PROVINCIAS
values ('San jose'),('Alajuela'),('Cartago'),('Heredia'),('Guanacaste'),('Puntarenas'),('Limon')
--//////////////////////////////////////////////////////////////////
CREATE PROCEDURE CONSULTAPROVINCIA                  

AS

SELECT IDPROVINCIAS,PROVINCIA FROM PROVINCIAS
GO

--------------------------------------------------------------------------------------GENERO
create table genero(
IDGENERO INT IDENTITY (1,1),
GENERO VARCHAR(40)

)

Insert into genero
values ('Masculino'),('Femenino')

CREATE PROCEDURE CONSULTAGENERO                  

AS

SELECT IDGENERO,GENERO FROM genero
GO
----------------------------CONDUCTORES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

CREATE TABLE CONDUCTOR(
ID INT IDENTITY(01,1)PRIMARY KEY,
PLACA VARCHAR(100),
A�O INT,
COLOR VARCHAR(100),
NOMBRES VARCHAR (100),
APELLIDOS VARCHAR (100),
DNI CHAR(8),
EDAD INT,
DIRECCION VARCHAR (100),
PROVINCIA VARCHAR (100),
FECHA DATE,
FOTO IMAGE )

ALTER TABLE CONDUCTOR
ADD MONTO_RECAUDADO INT;


--STORE PROCEDURE PARA REGISTRAR CONDUCTOR

CREATE PROCEDURE REGISTRAR_CONDUCTOR
    @PLACA VARCHAR(100),
    @A�O INT,
    @COLOR VARCHAR(100),
	@NOMBRES varchar(100),
	@APELLIDOS varchar(100),
	@DNI char(8),
	@EDAD int,
	@DIRECCION varchar(100),
	@PROVINCIA varchar(100),
	@FECHA date,
	@FOTO image
AS
BEGIN
	insert into CONDUCTOR(PLACA,A�O,COLOR,NOMBRES,APELLIDOS,DNI,EDAD,DIRECCION,PROVINCIA,FECHA,FOTO)	values 
	(@PLACA,@A�O,@COLOR,@NOMBRES,@APELLIDOS,@DNI,@EDAD,@DIRECCION,@PROVINCIA,@FECHA,@FOTO)
END
GO

----STORE PROCEDURE PARA ELIMINAR CONDUCTOR
create procedure BORRAR_CONDUCTOR
@ID INT
as
BEGIN
DELETE FROM CLIENTE WHERE ID = @ID;
END


----STORE PROCEDURE PARA EDITAR CONDUCTOR
CREATE PROCEDURE EDITA_CONDUCTOR
   @PLACA VARCHAR(100),
    @A�O INT,
    @COLOR VARCHAR(100),
	@NOMBRES varchar(100),
	@APELLIDOS varchar(100),
	@DNI char(8),
	@EDAD int,
	@DIRECCION varchar(100),
	@PROVINCIA varchar(100),
	@FOTO image
AS
BEGIN
    UPDATE CONDUCTOR SET  PLACA=@PLACA,A�O=@A�O,COLOR=@COLOR, NOMBRES=@NOMBRES,APELLIDOS=@APELLIDOS,EDAD=@EDAD,
    DIRECCION=@DIRECCION,PROVINCIA=@PROVINCIA,FOTO=@FOTO WHERE @NOMBRES = @NOMBRES;

END

-------RUTAS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
CREATE TABLE RUTAS(
IDRUTA INT IDENTITY(01,1) PRIMARY KEY,
RUTA VARCHAR(100),
DISTANCIAKM INT,
)

ALTER TABLE RUTAS
ADD MONTO_RECAUDADO INT;

------STORE PROCEDURE PARA AGREGAR RUTAS
CREATE PROCEDURE REGISTRA_RUTAS 
@RUTA VARCHAR(100),
@DISTANCIAKM INT
AS
BEGIN
    INSERT INTO RUTAS (RUTA,DISTANCIAKM) VALUES
	(@RUTA,@DISTANCIAKM)
END
GO





------STORE PROCEDURE PARA EDITAR RUTAS
ALTER PROCEDURE EDITA_RUTAS
@RUTA VARCHAR(100),
@DISTANCIAKM INT,
@IDRUTA INT


AS
BEGIN
    UPDATE RUTAS SET @IDRUTA= @IDRUTA, RUTA = @RUTA, DISTANCIAKM=@DISTANCIAKM
	WHERE IDRUTA=@IDRUTA             /*INDICAR PRIMERO EL NOMBRE DE LA RUTA LUEGO LOS KILOMETROS DE DISTANCIA Y POR ULTIMO EL ID*/
END


------STORE PROCEDURE PARA ELIMINAR RUTAS
CREATE PROCEDURE DESACTIVA_RUTA
@IDRUTA INT
as
BEGIN
DELETE FROM RUTAS WHERE IDRUTA=@IDRUTA;
END


SELECT *FROM RUTAS
