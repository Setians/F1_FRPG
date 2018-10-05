Create database Formula_1
go
use Formula_1
go
create table F1_Corredores
(
ID_Corredor int identity(1,1) not null,
Pais_Corredor char(30) null,
LugarN_Corredor char(50) null,
FechaN_Corredor smalldatetime null,
Nombre_Corredor char(30) not null,
Apellido_Corredor char(30) not null,
constraint pk_Corredor primary key (iD_Corredor)
)

create table F1_Equipos
(
ID_Equipo int identity(1,1) not null,
Central_Equipos char(30) null,
Jefe_Equipo char(50) null,
AñoD_Equipo int null,
Nombre_Equipo char(30) not null,
JefeT_Equipo char(30)null,
constraint pk_Equipo primary key (iD_Equipo)
)

create table F1_Circuitos
(
ID_Circuito int identity (1,1) not null,
PrimerGP_Circuito int null,
Nombre_Circuito char (50) not null,
Pais_Circuito char(30) null,
Longitud char(20) null,
constraint pk_Circuito primary key (id_Circuito)
)

create table F1_Temporadas
(
ID_Temporada int not null,
Nombre_Temporada char (20) not null,
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
Nombre_Carrera char(30) not null,
NumeroVueltas_Carrera int not null,
Distancia_Carrera char(20) null,
constraint pk_Carrera primary key (ID_Carrera)
)
create table F1_CarrerasxCorredor
(
IDCarrera_CC int not null,
idConductor_CC int not null,
Posiciongrilla_CC int not null,
PosicionFinal_CC int not null,
VueltasCompletadas_CC int not null,
Tiempo_CC  time not null,
constraint pk_CC primary key (Idcarrera_cc, idConductor_cc)
)

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
---------Procedimientos de Corredores--------------
CREATE PROCEDURE spInsertarCorredor
(

@NOMBRECorredor CHAR(30),
@ApellidoCorredor char(30),
@LugarNacimientoCorredor char (50),
@FechaNacCorr smalldatetime,
@PaisCorredor char(30))
AS
INSERT INTO F1_Corredores
(

Nombre_Corredor,
Apellido_Corredor,
LugarN_Corredor,
FechaN_Corredor,
Pais_Corredor
)
VALUES
(

@NOMBRECorredor ,
@ApellidoCorredor ,
@LugarNacimientoCorredor ,
@FechaNacCorr ,
@PaisCorredor
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
@NOMBRECorredor CHAR(30),
@ApellidoCorredor char(30),
@LugarNacimientoCorredor char (50),
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

use Formula_1
go

---------Procedimientos de Equipos--------------
CREATE PROCEDURE spInsertarEquipo
(

@NombreEquipo CHAR(30),
@CentralEquipo char(30),
@JefeEquipo char (50),
@JefeTEquipo char(30),
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

@NombreEquipo CHAR(30),
@CentralEquipo char(30),
@JefeEquipo char (50),
@JefeTEquipo char(30),
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

@NombreCircuito CHAR(50),
@PrimerGPCircuito int,
@PaisCircuito char (30),
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
@NombreCircuito CHAR(50),
@PrimerGPCircuito int,
@PaisCircuito char (30),
@LongitudCircuito char(20)
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

@NombreTemporada char(20),
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
@NombreTemporada char(20)
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

@NombreCarrera char(30),
@IDCircuito int,
@IDTemporada int,
@NumeroVueltas int,
@Distancia char(20)
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
@NombreCarrera char(30),
@IDCarrera int,
@IDCircuito int,
@IDTemporada int,
@NumeroVueltas int,
@Distancia char(20)
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



select PosicionFinal_CC,Nombre_Corredor,Nombre_Equipo,Posiciongrilla_CC,VueltasCompletadas_CC,Tiempo_CC,(PosicionFinal_CC*25) as Puntos
from F1_CarrerasxCorredor inner join F1_Corredores 
on (idConductor_CC = ID_Corredor) inner join F1_CorredoresxEquipoxTemporadas 
on (id_Corredor_CET = ID_Corredor) inner join F1_Equipos on
(ID_Equipo=id_Equipo_CET)
where IDCarrera_CC = '1' and id_Corredor_CET = '1'
order by PosicionFinal_CC asc
go

select id_Corredor_CET, Nombre_Corredor, id_Equipo_CET, id_Temporadas_CET 
from F1_CorredoresxEquipoxTemporadas inner join F1_Corredores 
on (id_Corredor_CET = ID_Corredor)

