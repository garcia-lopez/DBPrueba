SELECT Persona.primerNombre AS Nombre, Persona.primerApellido AS Apellido, Ciudad.nombre AS Ciudad
FROM     Ciudad INNER JOIN
                  Persona ON Ciudad.id = Persona.idCiudad


--Ver los registros de las personas que contienen al inicio del primer nombre la letra x

select * from Persona where primerNombre like N'%a'

select * from Persona where primerNombre like N'%a' and segundoNombre like N'P%'

select *, ciudad.nombre from Persona inner join ciudad on ciudad.id = Persona.idCiudad where ciudad.nombre like N'%m%'

Select primernombre, primerapellido, year(getDate()) - year(fechanac) as Edad from persona where year(getDate())-year(fechanac) between 18 and 30

Select primernombre, primerapellido, year(getDate()) - year(fechanac) as Edad from persona where year(getDate())-year(fechanac) Not in (18, 20)

Select primernombre, primerapellido, year(getDate()) - year(fechanac) as Edad from persona where year(getDate())-year(fechanac) in (18,20)

Select primernombre, primerapellido, year(getDate()) - year(fechanac) as Edad from persona where year(getDate())-year(fechanac) = 18

Select primernombre, primerapellido, year(getDate()) - year(fechanac) as Edad from persona where year(getDate())-year(fechanac) >= 18

insert into Ciudad(nombre) values (N'Rivas'), (N'Granada')

select *, ciudad.nombre from Persona inner join ciudad on ciudad.id = Persona.idCiudad where ciudad.nombre in (N'Rivas', N'Granada')

select * from Persona

insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'Ligia', N'Maria', N'Garcia', N'Serrano', '27/11/1975', 6),(N'Maria', N'Milagro', N'Rivera', N'Ortega', '11/05/2005', 6),(N'Alicia', N'del Socorro', N'Garcia', N'Serrano', '08/06/1992', 6)

delete from Persona where id = 4