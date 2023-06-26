using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace incompleto
{
    public class Class1
    {
    }
}

--crea una base de datos
create database ge19

--crea una tabla
create table person(
idpersona int primary key identity(1,1) not null,
nombre varchar (25) not null,
apellidop varchar (25) not null,
apellidom varchar (25) not null,
edad int)

create table parka(
idgg int primary key identity (456,68) not null,
pan varchar (25) not null)
insert into parka values ('perrito')
select* from parka

--inserta valores a la tabla
insert into person values ('jacinto', 'villa', 'martinez', '32')

--muestra la tabla
select * from person


--actualizar valores de una tabla 
update person set nombre = 'jonathan' where idpersona = 1

--eliminar valores de una tabla 
delete person where  idpersona = 1

--buscar valores por la inicial de un valor
--el % indica la posicion en la que se hara la busqueda
select * from person where nombre like 'j%' and edad like '%3%'
select * from person where nombre like 'j%'
select * from person where nombre not like 'j%'

--cuenta los valores de toda la tabla
select count (*) from person
connectionstring
<add connectionString= "server = JONATHAN; database = ge19; integrated security = true" name = "sql" />
