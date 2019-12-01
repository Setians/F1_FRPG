--use master
--drop database Formula_1

--Creacion de Base de datos
--Create database Formula_1
--use Formula_1

--Creacion de Tablas
create table F1_Corredores
(
ID_Corredor int identity(1,1) not null,
Pais_Corredor varchar(30) null,
LugarN_Corredor varchar(50) null,
FechaN_Corredor smalldatetime null,
Nombre_Corredor varchar(30) not null,
Apellido_Corredor varchar(30) not null,
Imagen_Corredor varchar(150) null,
constraint pk_Corredor primary key (iD_Corredor)
)

create table F1_Equipos
(
ID_Equipo int identity(1,1) not null,
Central_Equipos varchar(50) null,
Jefe_Equipo varchar(50) null,
AñoD_Equipo int null,
Nombre_Equipo varchar(70) not null,
JefeT_Equipo varchar(50)null,
constraint pk_Equipo primary key (iD_Equipo)
)

create table F1_Circuitos
(
ID_Circuito int identity (1,1) not null,
PrimerGP_Circuito varchar(5) null,
Nombre_Circuito varchar (50) not null,
Pais_Circuito varchar(50) null,
Longitud varchar(20) null,
Imagen_Circuito varchar(150) null,
constraint pk_Circuito primary key (id_Circuito)
)

create table F1_Temporadas
(
ID_Temporada int identity (1,1) not null,
Nombre_Temporada int not null,
constraint pk_Temporada primary key (id_Temporada)
)
create table F1_CorredoresxEquipoxTemporadas
(
 id_Corredor_CET int not null,
 id_Equipo_CET int not null,
 id_Temporadas_CET int not null,
 constraint pk_CET primary key (id_Corredor_Cet,id_equipo_cet,id_temporadas_cet)
)

create table F1_Carreras
(
ID_Carrera int identity(1,1) not null,
ID_Circuito_Carrera int not null,
id_Temporada int not null,
Nombre_Carrera varchar(50) not null,
NumeroVueltas_Carrera int not null,
Distancia_Carrera varchar(50) null,
constraint pk_Carrera primary key (ID_Carrera)
)
create table F1_CarrerasxCorredor
(
IDCarrera_CC int not null,
idConductor_CC int not null,
Posiciongrilla_CC int not null,
PosicionFinal_CC int not null,
VueltasCompletadas_CC int not null,
Tiempo_CC  varchar(50) not null,
constraint pk_CC primary key (Idcarrera_cc, idConductor_cc)
)
---______________RELACIONES
-------- Referencias de carrerasxCorredor------
alter table F1_CarrerasxCorredor add constraint FK_CC foreign key (IdCarrera_CC)
references F1_Carreras(ID_Carrera) 
alter table F1_CarrerasxCorredor add constraint FK_CxC foreign key (IDConductor_CC)
references F1_Corredores(ID_Corredor)
-------------------------------------------------
-------- Referencias de CorredoresxEquipoxTemporadas------
alter table F1_CorredoresxEquipoxTemporadas add constraint FK_CxET foreign key (ID_Corredor_CET)
references F1_Corredores(ID_Corredor)
alter table F1_CorredoresxEquipoxTemporadas add constraint FK_CExT foreign key (id_Equipo_CET)
references F1_Equipos(Id_Equipo)
alter table F1_CorredoresxEquipoxTemporadas add constraint FK_CxExT foreign key (id_Temporadas_CET)
references F1_Temporadas(ID_Temporada)
-------------------------------------------------
-------- Referencias de Carrera------
alter table F1_Carreras add constraint FK_Carreras foreign key (ID_Circuito_Carrera)
references F1_Circuitos(iD_Circuito)
alter table F1_Carreras add constraint FK_CarrerasxT foreign key (id_Temporada)
references F1_Temporadas(ID_TEmporada)
-------------------------------------------------
go


--Procedimientos almacenados
---------Procedimientos de Corredores--------------
CREATE PROCEDURE spInsertarCorredor
(

@NOMBRECorredor varCHAR(30),
@ApellidoCorredor varchar(30),
@LugarNacimientoCorredor varchar (50),
@FechaNacCorr smalldatetime,
@PaisCorredor varchar(30),
@ImagenCorredor varchar(150)
)
AS
INSERT INTO F1_Corredores
(

Nombre_Corredor,
Apellido_Corredor,
LugarN_Corredor,
FechaN_Corredor,
Pais_Corredor,
Imagen_Corredor
)
VALUES
(

@NOMBRECorredor ,
@ApellidoCorredor ,
@LugarNacimientoCorredor,
@FechaNacCorr,
@PaisCorredor,
@ImagenCorredor
)
RETURN
go

CREATE PROCEDURE spEliminarCorredor
	(
	@IDCorredor INT
	) 
	AS
	DELETE FROM F1_Corredores
	WHERE ID_Corredor=@IDCorredor
	RETURN
	go
	
	
CREATE PROCEDURE spActualizarCorredor
(
@IDCorredor INT,
@NOMBRECorredor varCHAR(30),
@ApellidoCorredor varchar(30),
@LugarNacimientoCorredor varchar (50),
@FechaNacCorr smalldatetime,
@PaisCorredor char(30)
)
AS
UPDATE F1_Corredores
SET
Nombre_Corredor=@NOMBRECorredor,
Apellido_Corredor=@ApellidoCorredor,
Pais_Corredor=@PaisCorredor,
LugarN_Corredor=@LugarNacimientoCorredor,
FechaN_Corredor=@FechaNacCorr
WHERE
ID_Corredor=@IDCorredor
RETURN	
go




---------Procedimientos de Equipos--------------
CREATE PROCEDURE spInsertarEquipo
(

@NombreEquipo varCHAR(30),
@CentralEquipo varchar(30),
@JefeEquipo varchar (50),
@JefeTEquipo varchar(30),
@AñoEquipo int)
AS
INSERT INTO F1_Equipos
(

Nombre_Equipo,
Central_Equipos,
Jefe_Equipo,
JefeT_Equipo,
AñoD_Equipo
)
VALUES
(

@NombreEquipo ,
@CentralEquipo ,
@JefeEquipo ,
@JefeTEquipo ,
@AñoEquipo
)
RETURN
go

CREATE PROCEDURE spEliminarEquipo
	(
	@IDEquipo INT
	) 
	AS
	DELETE FROM F1_Equipos
	WHERE ID_Equipo=@IDEquipo
	RETURN
	go
	
	
CREATE PROCEDURE spActualizarEquipo
(

@NombreEquipo varCHAR(30),
@CentralEquipo varchar(30),
@JefeEquipo varchar (50),
@JefeTEquipo varchar(30),
@AñoEquipo int,
@IDEquipo int
)
AS
UPDATE F1_Equipos
SET
Nombre_Equipo=@NombreEquipo,
Central_Equipos=@CentralEquipo,
Jefe_Equipo=@JefeEquipo,
JefeT_Equipo=@JefeEquipo,
AñoD_Equipo=@AñoEquipo
WHERE
ID_Equipo=@IDEquipo
RETURN	
go

---------Procedimientos de Circuitos--------------
CREATE PROCEDURE spInsertarCircuito
(

@NombreCircuito varCHAR(50),
@PrimerGPCircuito int,
@PaisCircuito varchar (30),
@LongitudCircuito char(20)
)
AS
INSERT INTO F1_Circuitos
(

Nombre_Circuito,
PrimerGP_Circuito,
Pais_Circuito,
Longitud
)
VALUES
(

@NombreCircuito ,
@PrimerGPCircuito ,
@PaisCircuito ,
@LongitudCircuito 
)
RETURN
go

CREATE PROCEDURE spEliminarCircuito
	(
	@IDCircuito INT
	) 
	AS
	DELETE FROM F1_Circuitos
	WHERE ID_Circuito=@IDCircuito
	RETURN
	go
	
	
CREATE PROCEDURE spActualizarCircuito
(
@IDCircuito int,
@NombreCircuito varCHAR(50),
@PrimerGPCircuito int,
@PaisCircuito varchar (30),
@LongitudCircuito varchar(20)
)
AS
UPDATE F1_Circuitos
SET
Nombre_Circuito=@NombreCircuito,
PrimerGP_Circuito=@PrimerGPCircuito,
Pais_Circuito=@PaisCircuito,
Longitud=@LongitudCircuito
WHERE
ID_Circuito=@IDCircuito
RETURN	
go
---------------Temporadas------------------

CREATE PROCEDURE spInsertarTemporada
(

@NombreTemporada varchar(20),
@IDTemporada int
)
AS
INSERT INTO F1_Temporadas
(

Nombre_Temporada,
ID_Temporada
)
VALUES
(
@NombreTemporada,
@IDTemporada
)
RETURN
go

CREATE PROCEDURE spEliminarTemporada
	(
	@IDTemporada INT
	) 
	AS
	DELETE FROM F1_Temporadas
	WHERE ID_Temporada=@IDTemporada
	RETURN
	go

CREATE PROCEDURE spActualizarTemporada
(
@IDTemporada int,
@NombreTemporada varchar(20)
)
AS
UPDATE F1_Temporadas
SET
Nombre_Temporada=@NombreTemporada
WHERE
ID_Temporada=@IDTemporada
RETURN	
go

------------Carreras---------------------	

CREATE PROCEDURE spInsertarCarrera
(

@NombreCarrera varchar(30),
@IDCircuito int,
@IDTemporada int,
@NumeroVueltas int,
@Distancia varchar(50)
)
AS
INSERT INTO F1_Carreras
(
Nombre_Carrera,
ID_Circuito_Carrera,
id_Temporada,
NumeroVueltas_Carrera,
Distancia_Carrera
)
VALUES
(
@NombreCarrera,
@IDCircuito,
@IDTemporada,
@NumeroVueltas,
@Distancia
)
RETURN
go

CREATE PROCEDURE spEliminarCarrera
	(
	@IDCarrera INT
	) 
	AS
	DELETE FROM F1_Carreras
	WHERE ID_Carrera=@IDCarrera
	RETURN
	go

CREATE PROCEDURE spActualizarCarrera
(
@NombreCarrera varchar(30),
@IDCarrera int,
@IDCircuito int,
@IDTemporada int,
@NumeroVueltas int,
@Distancia varchar(50)
)
AS
UPDATE F1_Carreras
SET
Nombre_Carrera=@NombreCarrera,
ID_Circuito_Carrera=@IDCircuito,
id_Temporada=@IDTemporada,
NumeroVueltas_Carrera=@NumeroVueltas,
Distancia_Carrera=@Distancia
WHERE
ID_Carrera=@IDCarrera
RETURN	
go	
----------EXCXT----------------------------
CREATE PROCEDURE spInsertarEquipoXCorredor
(

@IDCorredor int,
@IDEquipo int,
@IDTemporada int
)
AS
INSERT INTO F1_CorredoresxEquipoxTemporadas
(
id_Corredor_CET,
id_Equipo_CET,
id_Temporadas_CET
)
VALUES
(
@IDCorredor,
@IDEquipo,
@IDTemporada
)
RETURN
go

CREATE PROCEDURE spEliminarEquipoXCorredor
	(
	@IDCorredor INT,
	@IDEquipo INT,
	@IDTemporada int
	) 
	AS
	DELETE FROM F1_CorredoresxEquipoxTemporadas
	WHERE id_Corredor_CET=@IDCorredor and id_Equipo_CET=@IDEquipo and id_Temporadas_CET=@IDTemporada
	RETURN
	go

CREATE PROCEDURE spActualizarEquipoXCorredor
(
@IDCorredor int,
@IDEquipo int,
@IDTemporada int
)
AS
UPDATE F1_CorredoresxEquipoxTemporadas
SET
id_Corredor_CET=@IDCorredor,
id_Equipo_CET=@IDEquipo,
id_Temporadas_CET=@IDTemporada
WHERE
id_Corredor_CET=@IDCorredor and id_Equipo_CET=@IDEquipo and id_Temporadas_CET=@IDTemporada
RETURN	
go	
-----------CXC-----------------------------
CREATE PROCEDURE spInsertarCorredorXCarrera
(
@IDCarrera int,
@IDCorredor int,
@PosicionGrilla int,
@PosicionFinal int,
@VueltasCompletadas int,
@Tiempo time(7)
)
AS
INSERT INTO F1_CarrerasxCorredor
(
IDCarrera_CC,
idConductor_CC,
Posiciongrilla_CC,
PosicionFinal_CC,
VueltasCompletadas_CC,
Tiempo_CC
)
VALUES
(
@IDCarrera ,
@IDCorredor ,
@PosicionGrilla ,
@PosicionFinal ,
@VueltasCompletadas,
@Tiempo
)
RETURN
go

CREATE PROCEDURE spEliminarCorredorXCarrera
	(
	@IDCarrera INT,
	@IDCorredor INT
	) 
	AS
	DELETE FROM F1_CarrerasxCorredor
	WHERE IDCarrera_CC=@IDCarrera and idConductor_CC=@IDCorredor
	RETURN
	go

CREATE PROCEDURE spActualizarCorredorXCarrera
(
@IDCarrera int,
@IDCorredor int,
@PosicionGrilla int,
@PosicionFinal int,
@VueltasCompletadas int,
@Tiempo time(7)
)
AS
UPDATE F1_CarrerasxCorredor
SET
IDCarrera_CC=@IDCarrera,
idConductor_CC=@IDCorredor,
Posiciongrilla_CC=@PosicionGrilla,
PosicionFinal_CC=@PosicionFinal,
VueltasCompletadas_CC=@VueltasCompletadas,
Tiempo_CC=@Tiempo
WHERE
IDCarrera_CC=@IDCarrera and idConductor_CC=@IDCorredor
RETURN	
go	


create Procedure SP_ResultadoXCarrerasxTemporada
@idTemporada int,
@idCarrera int
as
select Nombre_Temporada as Temporada,(d.Nombre_Corredor+ ' '+d.Apellido_Corredor) as Corredor,
a.Nombre_Carrera as Carrera, e.Nombre_Circuito as Circuito,
PosicionFinal_CC as [Resultado Final], Puntos = 
case
when Nombre_Temporada >= 2010 then
	(case
	when PosicionFinal_CC = 1 then 25
	when PosicionFinal_CC = 2 then 18
	when PosicionFinal_CC = 3 then 15
	when PosicionFinal_CC = 4 then 10
	when PosicionFinal_CC = 5 then 8
	when PosicionFinal_CC = 6 then 6
	when PosicionFinal_CC = 7 then 5
	when PosicionFinal_CC = 8 then 3
	when PosicionFinal_CC = 9 then 2
	when PosicionFinal_CC = 10 then 1
	end)
when Nombre_Temporada >= 1950 and Nombre_Temporada <= 1954 then
	(case
	when PosicionFinal_CC = 1 then 8
	when PosicionFinal_CC = 2 then 6	
	when PosicionFinal_CC = 3 then 4
	when PosicionFinal_CC = 3 then 3
	when PosicionFinal_CC = 3 then 2
	end)
end
from F1_CarrerasXCorredor c 
inner join  F1_Corredores d on (c.idConductor_CC = d.ID_Corredor)
inner join  F1_Carreras a on (c.idCarrera_CC = a.id_Carrera)  
inner join F1_Circuitos e on (a.id_Circuito_Carrera = e.ID_Circuito)
inner join F1_temporadas f on (a.id_Temporada = f.Id_Temporada)
where f.Id_Temporada = @idTemporada and a.id_Carrera = @idCarrera
order by [Resultado Final], Nombre_Temporada
return
go






---CONSULTAS


Select ID_Corredor as id, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores order by id desc
go

use Formula_1
go

---Carga de datos 

exec spInsertarCorredor 'Lewis', 'Hamilton','Stevenage, Inglaterra', '07/01/1985', 'Reino Unido','D:\mtias\lab\Formula1\imagenes\Corredores\Hamilton.jpg'
exec spInsertarCorredor 'Sebastian', 'Vettel','Heppenheim, Alemania', '03/07/1987', 'Alemania',  'D:\mtias\lab\Formula1\imagenes\Corredores\Vettel.jpg'
exec spInsertarCorredor 'Kimi', 'Räikkönen','Espoo, Finlandia', '17/10/1979', 'Finlandia', 'D:\mtias\lab\Formula1\imagenes\Corredores\Raikonen.jpg'   
exec spInsertarCorredor 'Juan Manuel', 'Fangio','Balcarce, Argentina', '24/6/1911', 'Argentina', 'D:\mtias\lab\Formula1\imagenes\Corredores\Fangio.png'
exec spInsertarCorredor 'Lando', 'Norris','Bristol, Inglaterra', '13/11/1999', 'Reino Unido', 'D:\mtias\lab\Formula1\imagenes\Corredores\Lando Norris.jpg'   
exec spInsertarCorredor 'Max', 'Verstappen','Hasselt, Bélgica', '30/09/1997', 'Paises Bajos', 'D:\mtias\lab\Formula1\imagenes\Corredores\Max Verstappen.jpg'






Select Pais_Corredor from F1_Corredores where F1_Corredores.ID_Corredor = 1;

Select CONVERT( VARCHAR , FechaN_Corredor , 103 )as fecha from F1_Corredores where F1_Corredores.ID_Corredor = 1
Select Imagen_Corredor from F1_Corredores where ID_Corredor = 1

Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores where Pais_Corredor = 'Alemania'
Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores order by CONVERT( VARCHAR , FechaN_Corredor , 112 ) desc

use Formula_1

Select DISTINCT Pais_Corredor from F1_Corredores 


Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores where Pais_Corredor = 'Reino Unido' order by CONVERT( VARCHAR , FechaN_Corredor , 112 ) desc

---Cargado de Circuitos
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud], [Imagen_Circuito]) VALUES   (1996, 'Melbourne Grand Prix Circuit', 'Melbourne, Australia', '5.303 km', '\imagenes\Circuitos\Melbourne Grand Prix Circuit.png')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1950, 'Circuit de Monaco', 'MonteCarlo, Monaco', '3.337km ')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2009, 'Yas Marina Circuit', 'Abu Dhabi, Emiratos Árabes Unidos', '5.554km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1973, 'Autódromo José Carlos Pace', 'São Paulo, Brazil', '4.309km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1963, 'Autódromo Hermanos Rodríguez', 'Ciudad de Mexico, Mexico', '4.304km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2012, 'Circuit of The Americas', 'Austin, Estados Unidos', '5.513km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1987, 'Suzuka International Racing Course', 'Suzuka, Japon', '5.807km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2014, 'Sochi Autodrom', 'Sochi, Rusia', '5.848km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2008, 'Marina Bay Street Circuit', 'Marina Bay, Singapur', '5.063km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1950, 'Autodromo Nazionale Monza', 'Monza, Italia', '5.793km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1950, 'Circuit de Spa-Francorchamps', 'Francorchamps, Belgica', '7.004km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1986, 'Hungaroring', 'Budapest, Hungría', '4.381km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1970, 'Hockenheimring', 'Hockenheim, Alemania', '4.574km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1950, 'Silverstone Circuit', 'Northamptonshire, Reino Unido', '5.891km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1970, 'Red Bull Ring', 'Spielberg, Austria', '4.318km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1971, 'Circuit Paul Ricard', 'Le Castellet, Francia', '5.842km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1978, 'Circuit Gilles-Villeneuve', 'Montreal, Canadá', '4.361km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (1991, 'Circuit de Barcelona-Catalunya', 'Montmeló, España', '4.655km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2016, 'Baku City Circuit', 'Bakú, Azerbaiyán', '6.003km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2004, 'Shanghai International Circuit', 'Shanghái, China', '5.451km')
INSERT INTO [Formula_1].[dbo].[F1_Circuitos] ([PrimerGP_Circuito], [Nombre_Circuito], [Pais_Circuito], [Longitud]) VALUES   (2004, 'Bahrain International Circuit', 'Sakhir, Baréin', '5.412km')


---Cargad de Temporadas

insert into f1_Temporadas(Nombre_Temporada) 
values ('2018')

insert into f1_Temporadas(Nombre_Temporada) 
values ('1950')
---Carga de Equipos

insert into f1_equipos
values('Brackley, United Kingdom','Toto Wolff',1970,'Mercedes AMG Petronas Motorsport','James Allison')

insert into f1_equipos
values('Maranello, Italy','Mattia Binotto',1950,'Scuderia Ferrari Mission Winnow','TBC')

insert into f1_equipos
values('N/A','Frédéric Vasseur',1993,'Alfa Romeo Racing','Simone Resta')

insert into f1_Equipos
values('Milton Keynes, United Kingdom','Christian Horner','1997','Aston Martin Red Bull Racing','Pierre Waché
')

---Carga de Carreras
insert into f1_carreras
values(1,1,'FORMULA 1 2018 ROLEX AUSTRALIAN GRAND PRIX',58,'5,303 kilómetros (3,3 mi)')
insert into f1_carreras
values(2,1,'FORMULA 1 GRAND PRIX DE MONACO 2018 ',78,'318,1 kilómetros (197,66 mi)')

--Carga de corredores en equipo por temporada
insert into f1_corredoresxequipoxtemporadas
values(1,1,1)
select * from f1_Equipos
insert into f1_CorredoresxEquipoxTemporadas
values(2,2,1)

insert into f1_CorredoresxEquipoxTemporadas
values(4,3,2)

---Carga de carrreras
select * from f1_Circuitos
insert into f1_CarrerasxCorredor
values(1,2,3,1,58,'1:29:33.283')

insert into f1_CarrerasxCorredor
values(1,1,1,2,58,'+5.036s')


insert into f1_CarrerasxCorredor
values(1,3,2,3,58,'+6.309s')


insert into f1_CarrerasxCorredor
values(2,4,1,1,100,'3:13:18.700')


-------------corredor x equipo x temporada---------------
select (c.Nombre_Corredor+ ' '+c.Apellido_Corredor) as Corredor, Nombre_Equipo as Equipo, Nombre_Temporada as Temporada
from f1_CorredoresxEquipoxTemporadas a 
inner join f1_Temporadas b on (id_Temporadas_CET = id_Temporada)
inner join f1_Corredores c on (id_Corredor_Cet = ID_Corredor)
inner join f1_Equipos d on (id_Equipo_CET = id_Equipo)
order by Temporada desc

-------------------RESULTADO DE CARRERA -----
select Nombre_Temporada as Temporada,(d.Nombre_Corredor+ ' '+d.Apellido_Corredor) as Corredor,
a.Nombre_Carrera as Carrera, e.Nombre_Circuito as Circuito,
PosicionFinal_CC as [Resultado Final], Puntos = 
case
when Nombre_Temporada >= 2010 then
	(case
	when PosicionFinal_CC = 1 then 25
	when PosicionFinal_CC = 2 then 18
	when PosicionFinal_CC = 3 then 15
	when PosicionFinal_CC = 4 then 10
	when PosicionFinal_CC = 5 then 8
	when PosicionFinal_CC = 6 then 6
	when PosicionFinal_CC = 7 then 5
	when PosicionFinal_CC = 8 then 3
	when PosicionFinal_CC = 9 then 2
	when PosicionFinal_CC = 10 then 1
	end)
when Nombre_Temporada >= 1950 and Nombre_Temporada <= 1954 then
	(case
	when PosicionFinal_CC = 1 then 8
	when PosicionFinal_CC = 2 then 6	
	when PosicionFinal_CC = 3 then 4
	when PosicionFinal_CC = 3 then 3
	when PosicionFinal_CC = 3 then 2
	end)
end
from F1_CarrerasXCorredor c 
inner join  F1_Corredores d on (c.idConductor_CC = d.ID_Corredor)
inner join  F1_Carreras a on (c.idCarrera_CC = a.id_Carrera)  
inner join F1_Circuitos e on (a.id_Circuito_Carrera = e.ID_Circuito)
inner join F1_temporadas f on (a.id_Temporada = f.Id_Temporada)
where f.Id_Temporada = 1 and a.id_Carrera = 1
order by [Resultado Final], Nombre_Temporada


exec SP_ResultadoXCarrerasxTemporada 1,1



 --Triggers

 
create trigger TRG_VerificarCorredorEnTemporada 
on F1_CarrerasxCorredor
for insert
as
begin
	declare @idCarrera int,
	@idConductor int,
	@Temporada int
	select @idCarrera = IDCarrera_CC, @idConductor = idConductor_CC, @Temporada=b.id_Temporada
	from inserted a inner join F1_Carreras b
	on (a.IDCarrera_CC = b.ID_Carrera)  
	
	IF EXISTS (SELECT * FROM F1_CorredoresxEquipoxTemporadas a 
			WHERE a.id_Corredor_CET = @idConductor and @Temporada=id_Temporadas_CET) 
		BEGIN
			SELECT 'Corredor agregado con exito' 
		END
	ELSE
		BEGIN
			SELECT 'El corredor no tiene equipo en la temporada actual'
			rollback tran
		END	
end




select * FROM F1_CorredoresxEquipoxTemporadas 

select * from f1_Carreras where id_Carrera=1

select * from f1_Corredores 

select * from f1_CarrerasxCorredor
select * from f1_Equipos

insert into F1_CorredoresxEquipoxTemporadas 
values(6,4,1)

insert into f1_CarrerasxCorredor (idCarrera_CC ,idConductor_CC,Tiempo_CC,Posiciongrilla_CC,PosicionFinal_CC,VueltasCompletadas_CC)
values(1,6,'+28.945s',4,6,58)

select * from f1_Circuitos
select * from f1_Carreras

---CircuitosXTemporada
select Nombre_Circuito as Circuito, Pais_Circuito as Pais, c.Nombre_Temporada as Temporada from F1_Circuitos a
left join f1_Carreras b on (a.id_Circuito = b.id_Circuito_Carrera)
left join f1_Temporadas c on (b.id_Temporada = c.id_Temporada)
where b.id_Temporada = 1


----Sumar los segundos arriba del primero en finalizar la carrera
 select *, Tiempo_CC as Tiempo = case when Posiciongrilla_CC is not 1 
 
 from f1_CarrerasxCorredor    
 
 
 SELECT CONVERT(varchar,
						DATEADD(ms,
						 Cast(replace(
										replace('+28.945s','+',''),
								's','') as decimal(18,4))
								 * 1000,
  CONVERT(datetime, '1:29:33.283', 114)), 114) as DATA_TYPE  




select * from f1_Temporadas