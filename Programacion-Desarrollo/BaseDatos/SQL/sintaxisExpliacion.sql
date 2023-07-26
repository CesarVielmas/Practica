create database Ejemplo;
use Ejemplo;
create table datos(
	dato1 varchar(30),
    edad integer,
    domicilio varchar(40)
);
insert into datos(dato1,edad,domicilio) values("soy un dato 4",24,"San Pablo");
select edad from datos where domicilio ="Mision Real";
/*sql_safe_updates el cual lo tiene mysql */
select @@sql_safe_updates;
set SQL_SAFE_UPDATES=0;
select * from datos;
delete from datos;
describe datos;

update datos set domicilio = "Costa del rio Colima";
update datos set edad = 30 where domicilio = "Costa del rio Colima";


create table usuarios (
id integer auto_increment,
nombre varchar(40),
edad integer,
primary key(id)
);
describe usuarios;
drop table usuarios;
/*diferencias entre trucate table y delete table*/
insert into usuarios(nombre,edad) values("Cesar",21);

insert into usuarios(nombre,edad) values("flor",20);

insert into usuarios(nombre,edad) values("Rubi",22);
select * from usuarios;

truncate table usuarios;
delete from usuarios;
/*not null o null lo cual son los datos si los acepta o no */
create table nulos (
id integer auto_increment not null,
nombre varchar(50) null,
edad integer not null,
primary key(id)
);
describe nulos;
/*unsigned el cual indica que solo acepta valores positivos */
create table unasignado(
id integer auto_increment not null,
edad integer unsigned not null
);
/*para TEXT es el mayor para guardar texto y solo se usa para texto muy largo para varchar ya se
 sabe que se usa para texto de 255 max y char 255 max pero varchar es varible y char no , ademas char se usan comillas simples*/
create table texto (
id integer auto_increment not null,
nombre text(3000000),
primary key(id)
);
/* para los numeros se usa int o integer el cual es de 2 mil millones de numeros y usa 4 bytes , tambien esta el mediumint el cual reduce dicho 
tamaño a la mitad , tambien esta smallint el cual es la mitad de mediumint y por ultimo tinyint que es muy pequeño on 255 de maximo y el valor
mas grande es bigint el cual da una cantidad desmesurada de numeros tambien hay boolean que es un true o false */
create table numero(
id mediumint auto_increment not null,
edad smallint unsigned,
salario tinyint unsigned,
maximo bigint unsigned,
falso boolean,
primary key(id)
);
/* los datos de tipo fecha que existen son date , el cual acepta una fecha sin hora "1923-02-28" , los datetime los cuales aceptan una fecha y hora
"1923-02-25 02:34:48" y los time los cuales aceptan solo una hora "02:34:48" aunque ya por ultimo existe tambien los year los cuales solo aceptan
un año "*/
create table fechas(
anio year,
hora time not null,
fecha date not null,
fecha_hora datetime not null,
primary key(anio)
);
/*valores por defecto con default para que los elementos not null al no referenciarlos en un insert , tomen los valores por defecto*/
create table por_defecto(
nombre varchar(30) default"Cesar" not null,
edad integer default 21 not null
);
select * from por_defecto;
drop table por_defecto;
insert into por_defecto(edad) value(22);
/* ahora los valores con zerofill el cual lo que hace es que añade ceros "0" a la izquierda de los enteros , dependiendo su tamaño maximo*/
create table ceros(
edades int zerofill
);
insert into ceros (edades) value (20);
select edades from ceros;
/*Ahora se veran las columnas calculadas las cuales se sacan mediante calculas de alguna tabla*/
create table calculada(
salario mediumint default 596 not null,
descuento tinyint
);
insert into calculada(descuento) values(20);
insert into calculada(descuento) values(40);
 
 select salario * (descuento*.01) from calculada where descuento = 40;
 /*Algunas funciones utiles de mysql para select de strings*/
select ord("A");/*Pasa el numero ASCII de el caracter*/
select concat("Hola"," ","mi nombre es patricio");/*Para concatenar caracteres*/
select length("Hola");/*Pasa el lenght de alguna cadena como cualquier lenguaje*/
select concat_ws(" y ","Cesar","Rubi");/*Lo que hace es que el primer parametro hara que en cada separacion salga dicho caracter*/
select find_in_set("hola", "mundo,hola");/*lo que hace es que cuando un caracter es separado , busca dicha palabra y muetra la posicion de la separacion*/
select locate("hola","mundo hola");/*Lo que hace es que busca una palabra y manda la posicion por donde empieza dicha palabra*/
select position("a" in "hola mundo");/*retorna la posicion de busqueda de algun caracter en una cadena*/
select lpad("hola","100","a");/*lo que hace es que retorna alguna cadena y se le asigna un tamaño minimo que debe cumplir , si no lo cumple se le añade el tercer parametro*/
select rpad("hola","100","a");/*lo mismo que lpad pero a la derecha*/
select left("hola muy buenas tardes",10);/*Lo que hace es que asigna los primeros caracteres de la izquierda dados por el 2 parametro*/
select right("hola muy buenos dias",9);/*lo mismo pero ahora hacia la derecha*/
select lower("HOLA");/*convierte a minusculas*/
select upper("hola");/*convierte a mayusculas*/
/*Algunas funciones matematicas*/
select abs(-20);/*el valor absoluto*/
select ceiling(13.49);/*convierte un valor decimal a uno mayor */
select floor(13.93);/*convierte un valor decimal a uno menor*/
select greatest(23,45,23,56,563,432,345,65,32,34,56);/*de una lista devuelve el numero mayor*/
select power(35,3);/*Lo que hace es una elevacion , al cubo en este caso*/
select rand();/*crea un numero aleatorio*/
select round(23.44);/*redondea al numero mas cercano*/
select truncate(12.369,2);/*lo qe hace es redondear los decimales , dependiendo de cuandos se desean redondear*/
select sqrt(9);/*hace la raiz cuadrada*/
/*algunas funciones para fechas*/
select adddate("2006-01-02",interval 20 month);/*le añade ya sea dias horas meses o años a una fecha*/
select addtime("02:00:00","03:03:45");/*añade hora a una hora*/
select current_time();/*da la hora actual*/
select current_date();/*da la hora actual*/
select datediff("2002-02-28","2023-02-28");/*da la diferencia de años de ambas fechas*/
select extract(minute from "02:23:34");/*extrae ya sea minutos o años o dias etc*/
select now();/*retorna la fecha actual con su hora*/
/*usando order by el cual ordena de forma descendente o ascendente*/
create table ordenacion(
nombre varchar(30),
edad int,
apellido varchar(40)
);
insert into ordenacion(nombre,edad,apellido) values("Cesar",21,"Vielmas");
insert into ordenacion(nombre,edad,apellido) values("Rubi",22,"Valdez");

select * from ordenacion order by apellido desc;
select * from ordenacion order by apellido asc;
select * from ordenacion order by edad desc;
select * from ordenacion order by edad asc;
/*usando operadores logicos*/
select * from ordenacion where (apellido = "Vielmas") and (edad = 21);
select * from ordenacion where (nombre != "Cesar") or (nombre = "Rubi");
/*usando beetwen que significa "entre"*/
select * from ordenacion where edad between 20 and 22;
/*usando like y not like*/
select * from ordenacion where apellido like "Vielmas";
select * from ordenacion where apellido not like "Valdez";
select * from ordenacion where apellido like "%V%";
/*usando expresiones regulares*/
select * from ordenacion where apellido regexp 's';
select * from ordenacion where nombre regexp 'u';
/*propiedad count para contar la cantidad de filas*/
select count(*) from ordenacion;
/*propiedades sum - min - max*/
select sum(edad) from ordenacion;/*suma las columnas*/
select max(edad) from ordenacion;/*el valor maximo de las columnas^*/
select min(edad) from ordenacion; /* el valor minimo de las columnas*/
/*propiedad group by*/
select nombre from ordenacion group by nombre;/*group by da lo que se le pide , pero sin repetir valores*/
/*propiedad distinct*/
select distinct * from ordenacion;
select * from ordenacion;
/*distinct lo que hace es que manda los valores del select solo 1 vez y no incluira los repetidos*/

/*Los alias en sql*/
select sum(edad) as suma_edades from ordenacion;/*para usar el alias se usa "as" y al momento de hacer alguna operacion en la tabla saldra el alias*/

/*tener varias primary key */
create table varias_keys(
nombre varchar(30),
apellido varchar(40),
primary key(nombre,apellido)
);

show index from varias_keys;
/*indice index , el indice index sirve para darle un tipo de indice especial a 1 o mas campos*/
create table indice_index(
	nombre varchar(30),
    apellido varchar(30),
    edad int,
	index i_indice (nombre,apellido,edad)
);
show index from indice_index;
/* indice unique , el indice unique sirve para que no repita algun valor dependiendo de la tabla*/
create table indice_unique(
edad int,
nombre varchar(30),
unique i_unico (edad)
);
show index from indice_unique;
/*eliminar algun index*/
drop index i_unico on indice_unique;/*para eliminar el indice de alguna tabla en especifico*/

/*creacion de un index a alguna tabla existente*/
create index i_unico on indice_unique(edad);
create unique index i_unique_unico on indice_unique(nombre);

/*utilizar limit en select para obtener ciertos datos de la tabla empezando por cierta columna*/
select * from ordenacion  limit 7,10;

/*usar replace para remplazar algunos valores de una columna de una tabla*/
replace into ordenacion values("Cesar Alejandro", 21,"Vielmas");
select * from ordenacion;
/* mas que todo replace sirve para elementos como con un id unico que no se puede repetir*/

/*usar alter table para agregar algun campo a una tabla*/
alter table indice_unique add nombre varchar(50);/*para agregar con add*/
alter table indice_unique drop nombre;/*para eliminar con drop*/
alter table indice_unique modify nombre text;/*para modificar con modify*/
alter table indice_unique change nombre nombrecito varchar(50);/*para modificar el nombre con change*/
alter table indice_unique add primary key (nombre);/*para añadir una llave primaria*/
alter table indice_unique drop primary key;/*para borrar el primary key de una tabla*/
alter table indice_unique add unique index i_nombrecito (nombrecito); /*para agregar un index a una tabla existente*/
alter table indice_unique drop index i_nombrecito;/*para eliminar un indice*/
alter table indice_unique rename i_unique;/*para renombrar una tabla y cambiarle su nombre*/
select * from i_unique;

/*el valor de enum , enum para lo que sirve es como un array , sin embargo en ese dicho campo solo pueden almacenarse cosas que esten dentro del enum*/
create table enumeracion(
 datos enum("Cesar","Rubi")
);
insert into enumeracion(datos) value("Cesar");/*valor valido pues esta en el enum */
insert into enumeracion(datos) value("Flor");/*valor no valido pues no esta en el enum por lo que daria error*/

/*Ahora el valor set , el cual set lo que hace es poder guardar varios valores en 1 misma columna y es bastante similar como enum*/
create table setacion(
 datos set("Cesar","Flor","Rubi")
);
insert into setacion(datos) value("Cesar,Rubi,Flor");/*valor valido pues esta en el set */
insert into setacion(datos) value("Flor,Cesar,Pablo");/*valor no valido pues no esta en el set por lo que daria error*/

/*datos blob y text , el blob se usa para guardar cadenas binarias para imagenes o archivos y text para guardar texto muy largo*/
create table blob_text(
archivos blob,
texto_largo text
);

/*control de flujo if, esta funciona igual que cualquier otra solo que se usa para los select*/
select if(length(nombre)>30,"Entro al if","Entro al else") from ordenacion;/*como se puede ver funciona muy parecido pero se usa para los select*/

/* uso de join para unir 2 tablas al hacer alguna normalizacion*/
create table tabla1(
nombre varchar(40),
datos int
);

create table tabla2(
id_datos int auto_increment,
nomre_dato varchar(30),
edad int,
primary key (id_datos)
);

select * from tabla1 join tabla2 on tabla1.datos = tabla2.id_datos;/*como se puede ver para unir indicas la tabla y en el on igualas el elemento de la tabla con dicho id para unirlas*/
select * from tabla1 left join tabla2 on tabla1.datos = tabla2.id_datos;/*lo mismo pero mandando la tabla de datos a la izquierda*/
select * from tabla1 right join tabla2 on tabla1.datos = tabla2.id_datos;/*lo mismo pero mandando la tabla de datos a la derecha*/
select * from tabla1 join tabla2 on tabla1.datos = tabla2.id_datos join tabla2 on tabla2.id_datos = tabla3.id;/*para unir una o mas tablas con join*/
/*Variables de usuario para los select*/
create table tabla3(
id int,
nombre varchar(40),
edad int
);
/*creacion de dicha variable */
select @mostrar:= max(edad) from tabla3;
select @mostrar;

/*Subconsultas , las subconsultas es la utilizacion de un select dentro de otro select para que arroje un resultado*/

select (select @mostrar)-max(edad) from tabla3;/*se uso un select del mostrar dentro de otro para obtener un valor y a este restarlo*/


/*Ahora las vistas las cuales es como crear una tabla pero es solo una vista con los selects de alguna otra tabla*/
create view vista_tabla3 as
	select nombre as nombrecito,
	edad  as edadcito from tabla3;
    
select nombre , edad from vista_tabla3;
/*Una vista dentro de otra vista*/
create view vista_de_vista as
	select nombrecito as nombre,
	edadcito  as edad from vista_tabla3;
    
select nombre , edad from vista_tabla3;

/*Insertar o borrar o actualizar de una vista lo cual es igual como en una tabla*/
insert into vista_tabla3 (nombre,edad) values("Cesar",20);
delete vista_tabla3(nombre,edad) where nombre = "Cesar";
update vista_tabla3 set nombre = "Rubi" where nombre = "Cesar";

/*Procedimientos almacenados los cuales lo que hacen es hacer una serie de instrucciones con solo llamarlos para ahorrar tiempo*/
delimiter // 
create procedure pa_tabla3()
begin
select * from tabla3;
end //
delimiter ;
/*Para llamar a un procedimiento almacenado*/
call pa_tabla3();

/*Procedimiento almacenado con parametros */
delimiter //
create procedure pa_tabla2(in nombre varchar(30))
begin
select * from tabla2 where apellido = nombre;
end //
delimiter ;

call pa_tabla2("Cesar");

/*Ahora por ultimo los diferentes triggers , los triggers o disparadores , son eventos que se haran cuando se ejecute una ccion como una inserccion
un update o un delete de una tabla , por lo cual hara una accion antes de que ocurra y otra accion despues de que ocurra*/

/*para update*/
delimiter //
create trigger trigarte
before update
 on tabla2 for each row
 
begin
select * from tabla2 where apellido = nombre;
end //
delimiter ;

/*para insert*/
delimiter //
create trigger trigarte
before insert
 on tabla2 for each row
begin
select * from tabla2 where apellido = nombre;
end //
delimiter ;

/*para delete*/
delimiter //
create trigger trigarte
before delete
 on tabla2 for each row
begin
select * from tabla2 where apellido = nombre;
end //
delimiter ;