----Create database LlantiRed
go
Use LlantiRed
go
create table TablaCategoria
(
Id int not null primary key,
Nombre varchar(10) not null
)
go
Create table TablaProveedor
(
Id int not null primary key,
Nombre varchar(100) not null,
Domicilio varchar(100) not null,
Telefono varchar(20),
Correo varchar(100)
)
go
Create table TablaGenero
(
Id int not null primary key,
Nombre varchar(30) not null
)
go
Create table TablaMarca
(
Id int not null primary key,
Nombre varchar(50) not null,
IdProveedor int not null,
foreign key(IdProveedor) references TablaProveedor(Id)
)
go
Create table TablaLlantas
(
Marca int not null,
Modelo varchar(100) not null,
Medida varchar(20) not null,
Precio money not null,
IdProveedor int not null,
IdCategoria int not null,
IdGenero int not null,
foreign key(IdCategoria) references TablaCategoria(Id) on delete no action on update no action,
foreign key(IdProveedor) references TablaProveedor(Id) on delete no action on update no action,
foreign key(IdGenero) references TablaGenero(Id) on delete no action on update no action,
foreign key(Marca) references TablaMarca(Id) on delete no action on update no action
)
go

Create table TablaLlantas2
(
Marca varchar(50) not null,
Modelo varchar(100) not null,
Medida varchar(20) not null,
Precio money not null,
Ecommerce varchar(50) not null
)
Insert into TablaLlantas2(Marca,Modelo,Medida,Precio,Ecommerce)
Select TablaMarca.Nombre,TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,TablaProveedor.Nombre
from TablaMarca inner join TablaLlantas on TablaLlantas.Marca=TablaMarca.Id inner join TablaProveedor
on TablaProveedor.Id=TablaLlantas.IdProveedor

Create procedure spGuardarLlanta2
@Marca varchar(50),
@Modelo varchar(100),
@Medida varchar(20),
@Precio money,
@Ecommerce varchar(50)
as
Begin
	if not exists(select Modelo+Medida from TablaLlantas2 where Modelo+Medida=@Modelo+@Medida)
		Insert into TablaLlantas2(Marca,Modelo,Medida,Precio,Ecommerce)
		values(@Marca,@Modelo,@Medida,@Precio,@Ecommerce)
	else
		Update TablaLlantas2 set Marca=@Marca,Precio=@Precio,Ecommerce=@Ecommerce where Modelo+Medida=@Modelo+@Medida
End

Create procedure spEliminarLlanta2
@Modelo varchar(100),
@Medida varchar(20)
as
Begin
	Delete from TablaLlantas2 where Modelo+Medida=@Modelo+@Medida
End

Create table TablaLlantiRed2
(
Marca varchar(50) not null,
Modelo varchar(100) not null,
Medida varchar(20) not null,
Precio money not null
)
Insert into TablaLlantiRed2(Marca,Modelo,Medida,Precio)
Select TablaMarca.Nombre,TablaLlantiRed.Modelo,TablaLlantiRed.Medida,TablaLlantiRed.Precio
from TablaMarca inner join TablaLlantiRed on TablaLlantiRed.Marca=TablaMarca.Id


--Procedimientos almacenados
Create procedure spGuardarLlanta
@Marca int,
@Modelo varchar(100),
@Medida varchar(20),
@Precio money,
@IdProveedor int,
@IdCategoria int,
@IdGenero int
as
Begin
	if not exists(select Modelo+Medida from TablaLlantas where Modelo+Medida=@Modelo+@Medida)
		Insert into TablaLlantas (Marca,Modelo,Medida,Precio,IdProveedor,IdCategoria,IdGenero)
		values(@Marca,@Modelo,@Medida,@Precio,@IdProveedor,@IdCategoria,@IdGenero)
	else
		Update TablaLlantas set Marca=@Marca,Precio=@Precio,IdProveedor=@IdProveedor,IdCategoria=@IdCategoria,
		IdGenero=@IdGenero where Modelo+Medida=@Modelo+@Medida
End

Create procedure spEliminarLlanta
@Modelo varchar(100),
@Medida varchar(20)
as
Begin
	Delete from TablaLlantas where Modelo+Medida=@Modelo+@Medida
End

CREATE procedure spGuardarProveedor
@Id int,
@Nombre varchar(100),
@Domicilio varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
as
Begin
	if not exists(Select Id from TablaProveedor)
		Select @Id=1

	if not exists(Select Id from TablaProveedor where Id=@Id)
		if(@Id>(select max(Id)+1 from TablaProveedor))
			Select @Id=max(Id)+1 from TablaProveedor
	if not exists(Select Id from TablaProveedor where Id=@Id)
		Insert into TablaProveedor (Id,Nombre,Domicilio,Telefono,Correo)values(@Id,@Nombre,@Domicilio,@Telefono,@Correo)
	else
		Update TablaProveedor set Nombre=@Nombre,Domicilio=@Domicilio,Telefono=@Telefono,Correo=@Correo where Id=@Id
End

Create procedure spEliminarProveedor
@Id int
as
Begin
	Delete from TablaProveedor where Id=@Id
End

CREATE procedure spGuardarMarca
@Id int,
@Nombre varchar(50),
@IdProveedor int
as
Begin
	if not exists(Select Id from TablaMarca)
		Select @Id=1
	if not exists(Select Id from TablaMarca where Id=@Id)
		if(@Id>(SELECT MAX(Id)+1 FROM TablaMarca))
			Select @Id=max(Id)+1 from TablaMarca
	if not exists(Select Id from TablaMarca where Id=@Id)
		Insert into TablaMarca (Id,Nombre,IdProveedor)values(@Id,@Nombre,@IdProveedor)
	else
		Update TablaMarca set Nombre=@Nombre,IdProveedor=@IdProveedor where Id=@Id
End

Create procedure spEliminarMarca
@Id int
as
Begin
	Delete from TablaMarca where Id=@Id
End




Create table TablaLlantiRed
(
Marca int not null,
Modelo varchar(100) not null,
Medida varchar(20) not null,
Precio money not null
)







Select TablaMarca.Nombre as Marca,TablaLlantas.Modelo,TablaLlantas.Medida,
TablaLlantas.Precio,TablaProveedor.Nombre as Proveedor,
TablaCategoria.Nombre as Categoria,TablaGenero.Nombre as Genero
from TablaMarca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca 
inner join TablaProveedor
on TablaProveedor.Id=TablaLlantas.IdProveedor inner join 
TablaCategoria on TablaCategoria.Id=TablaLlantas.IdCategoria
inner join TablaGenero on TablaGenero.Id=TablaLlantas.IdGenero


---------------Para buscar Marcas---------------
Select TablaMarca.Id,TablaMarca.Nombre,TablaProveedor.Nombre as [Proveedor] from TablaMarca 
inner join TablaProveedor on TablaMarca.IdProveedor=TablaProveedor.Id


Select Modelo,Medida,Precio,IdProveedor from TablaLlantas where Medida like '%220/55R15%' and IdProveedor=1


--string resultado = ventana.Busca("TablaLlantas", "Modelo,Medida,Precio", "Medida", " Modelo ", "Llantas");

Select Modelo,Medida,Precio,Modelo+Medida as Regresar from TablaLlantas where Medida like '%R%' order by Modelo




select * from TablaLlantas  where IdProveedor=1 and Modelo+Medida='ALL TERRAIN220/55R15' order by Modelo
Select * from TablaLlantas where IdProveedor=2 order by Modelo


Select Medida from TablaLlantiRed group by Medida

select Medida from TablaLlantiRed group by Medida order by Medida


----------------Esta es la buena creo. Esta es para esta base de datos(LlantiRed)-------------------------
Select TablaMarca.Nombre as [MarcaLlantiRed],TablaLlantiRed.Modelo as [ModeloLlantiRed],TablaLlantiRed.Medida as [MedidaLlantiRed],TablaLlantiRed.Precio as [PrecioLlantiRed],
TablaMarca.Nombre,TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,(TablaLlantas.Precio-TablaLlantiRed.Precio) as [DiferenciaPrecio],
(((TablaLlantas.Precio-TablaLlantiRed.Precio)/(TablaLlantas.Precio))*100) as DiferenciaPorcentaje from
TablaMarca inner join TablaLlantiRed on TablaMarca.Id=TablaLlantiRed.Marca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca
where TablaLlantiRed.Marca=TablaLlantas.Marca and TablaLlantiRed.Modelo=TablaLlantas.Modelo and
TablaLlantiRed.Medida=TablaLlantas.Medida



----------------------Por filtro------------------------------
Select TablaMarca.Nombre as [MarcaLlantiRed],TablaLlantiRed.Modelo as [ModeloLlantiRed],TablaLlantiRed.Medida as [MedidaLlantiRed],TablaLlantiRed.Precio as [PrecioLlantiRed],
TablaMarca.Nombre,TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,(TablaLlantas.Precio-TablaLlantiRed.Precio) as [DiferenciaPrecio],
(((TablaLlantas.Precio-TablaLlantiRed.Precio)/(TablaLlantas.Precio))*100) as DiferenciaPorcentaje from
TablaMarca inner join TablaLlantiRed on TablaMarca.Id=TablaLlantiRed.Marca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca
where TablaLlantiRed.Marca=TablaLlantas.Marca and TablaLlantiRed.Modelo=TablaLlantas.Modelo and
TablaLlantiRed.Medida=TablaLlantas.Medida and TablaLlantas.IdProveedor=1

Select TablaMarca.Nombre as [MarcaLlantiRed],TablaLlantiRed.Modelo as [ModeloLlantiRed],TablaLlantiRed.Medida as [MedidaLlantiRed],TablaLlantiRed.Precio as [PrecioLlantiRed],TablaMarca.Nombre as [Marca], TablaLlantas.Modelo, TablaLlantas.Medida, TablaLlantas.Precio, (TablaLlantas.Precio - TablaLlantiRed.Precio) as [DiferenciaPrecio],(((TablaLlantas.Precio - TablaLlantiRed.Precio) / (TablaLlantas.Precio)) * 100) as DiferenciaPorcentaje
from TablaMarca inner join TablaLlantiRed on TablaMarca.Id=TablaLlantiRed.Marca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca where TablaLlantiRed.Marca=TablaLlantas.Marca and TablaLlantiRed.Modelo=TablaLlantas.Modelo and TablaLlantiRed.Medida = TablaLlantas.Medida and TablaLlantas.IdProveedor=1








-------------Base de datos de ComparativaLlantiRed--------------------
-----------------Consulta para sacar las llantas comparadas------------------
Select TablaLlantiRed.Marca,TablaLlantiRed.Modelo,TablaLlantiRed.Medida,TablaLlantiRed.Precio,TablaLlantasProveedor.Marca,
TablaLlantasProveedor.Modelo,TablaLlantasProveedor.Medida,TablaLlantasProveedor.Precio from TablaLlantiRed inner join
TablaLlantasProveedor on TablaLlantiRed.Marca=TablaLlantasProveedor.Marca and TablaLlantiRed.Modelo=TablaLlantasProveedor.Modelo
and TablaLlantiRed.Medida=TablaLlantasProveedor.Medida
-------------Base de datos de ComparativaLlantiRed-----------------------
------------------Consulta para sacar las llantas comparadas y las diferencias de precio y porcentaje-------------------
Select TablaLlantiRed.Marca as [MarcaLlantiRed],TablaLlantiRed.Modelo as [ModeloLlantiRed],TablaLlantiRed.Medida as 
[MedidaLlantiRed],TablaLlantiRed.Precio as [PrecioLlantiRed],TablaLlantasProveedor.Marca,TablaLlantasProveedor.Modelo,
 TablaLlantasProveedor.Medida, TablaLlantasProveedor.Precio, (TablaLlantasProveedor.Precio-TablaLlantiRed.Precio) as DiferenciaPrecio, 
 (((TablaLlantasProveedor.Precio-TablaLlantiRed.Precio)/(TablaLlantasProveedor.Precio))*100) as DiferenciaPorcentaje from TablaLlantiRed 
 inner join TablaLlantasProveedor on TablaLlantiRed.Marca = TablaLlantasProveedor.Marca and 
 TablaLlantiRed.Modelo = TablaLlantasProveedor.Modelo and TablaLlantiRed.Medida = TablaLlantasProveedor.Medida












 ---------------------------Trigger de cale---------------------------

  Select Modelo, count(Modelo) as [CantidadLlantas] from TablaLlantas group by Modelo
 Create Table TablaTiposDeLlantas
 (
 Modelo varchar(50),
 CantidadLlantas int
 )
 go



 create trigger TR_Tipos_Insert
 on TablaLlantas
 AFTER INSERT,UPDATE,delete
 as
 Begin
 if exists(Select Modelo from TablaTiposDeLlantas)
	Delete from TablaTiposDeLlantas
 Insert into TablaTiposDeLlantas(Modelo,CantidadLlantas)
 Select Modelo, count(Modelo) from TablaLlantas group by Modelo
 End
 go


 Create Table TablaCantidadPrecio
 (
 CantidadLlantasLlantiRed int,
 CantidadPrecioLlantiRed numeric(12,2),
 CantidadLlantas int,
 CantidadPrecio numeric(12,2)
 )
 go

Create trigger TR_CantidadPrecio_Insert
on TablaLlantas
after Update,insert,delete
AS
Declare @CantidadLlantasLlantiRed int,
		@CantidadPrecioLlantiRed numeric(12,2),
		@CantidadLlantas int,
		@CantidadPrecio numeric(12,2)
BEGIN
if exists(Select CantidadLlantas from TablaCantidadPrecio)
	Delete from TablaCantidadPrecio
select @CantidadLlantasLlantiRed=count(Modelo) from TablaLlantiRed
select @CantidadPrecioLlantiRed=sum(Precio) from TablaLlantiRed
select @CantidadLlantas=count(Modelo) from TablaLlantas
select @CantidadPrecio=sum(Precio) from TablaLlantas
Insert into TablaCantidadPrecio(CantidadLlantasLlantiRed,CantidadPrecioLlantiRed,CantidadLlantas,CantidadPrecio)
values(@CantidadLlantasLlantiRed,@CantidadPrecioLlantiRed,@CantidadLlantas,@CantidadPrecio)
END
go


alter trigger TR_CantidadPrecio_Insert
on TablaLlantas
after Update,insert,delete
AS
Declare @CantidadLlantasLlantiRed int,
		@CantidadPrecioLlantiRed numeric(12,2),
		@CantidadLlantas int,
		@CantidadPrecio numeric(12,2)
BEGIN
if exists(Select CantidadLlantas from TablaCantidadPrecio)
	Delete from TablaCantidadPrecio
select @CantidadLlantasLlantiRed=count(Modelo) from TablaLlantiRed
select @CantidadPrecioLlantiRed=sum(Precio) from TablaLlantiRed
select @CantidadLlantas=count(Modelo) from TablaLlantas
select @CantidadPrecio=sum(Precio) from TablaLlantas
Insert into TablaCantidadPrecio(CantidadLlantasLlantiRed,CantidadPrecioLlantiRed,CantidadLlantas,CantidadPrecio)
values(@CantidadLlantasLlantiRed,@CantidadPrecioLlantiRed,@CantidadLlantas,@CantidadPrecio)
END
go


DECLARE @intFlag INT
SET @intFlag = 1
WHILE (@intFlag <=5)
BEGIN
PRINT @intFlag
SET @intFlag = @intFlag + 1
END
GO


Declare @indice int set @indice=1
while(@indice<=10)
Begin
print '2'+' '+' '+'X'+' '+Convert(varchar,@indice)+' '+'='+' '+COnvert(varchar,(2*@indice))
set @indice=@indice+1
End


Declare @ConsultaCursor varchar(100)
Declare PruebaCursor cursor for select Modelo from TablaLlantas
open PruebaCursor
Fetch Next from PruebaCursor into @ConcultaCursor
While @@FETCH_STATUS=0
Begin
	Print @ConsultaCursor
	Fetch next from PruebaCursor into @ConsultaCursor
End
Close PruebaCursor
Deallocate PruebaCursor

Select TablaLlantiRed.Medida,TablaLlantiRed.Precio from
TablaLlantiRed inner join TablaMarca on TablaLlantiRed.Marca=TablaMarca.Id where TablaMarca.Nombre='TOLEDO'

Select TablaMarca.Nombre,TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio from TablaLlantas inner join
TablaMarca on TablaLlantas.Marca=TablaMarca.Id inner join TablaCategoria on TablaLlantas.IdCategoria=TablaCategoria.Id
where TablaCategoria.Nombre='BAJA' and TablaLlantas.Medida=--Médida--



--Consulta para datagridview buscando llantas por medida y proveedor--
Select  TablaMarca.Nombre as [Marca],TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio from
TablaLlantas inner join TablaMarca on TablaLlantas.Marca = TablaMarca.Id inner join TablaCategoria on 
TablaLlantas.IdCategoria = TablaCategoria.Id 
inner join TablaProveedor on TablaLlantas.IdProveedor=TablaProveedor.Id where TablaCategoria.Nombre='BAJA'
and TablaLlantas.Medida='185/65R15' and TablaProveedor.Id=1--Aquí va el valor del proveedor



Select TablaMarca.Nombre as [MarcaLlantiRed],TablaLlantiRed.Modelo as [ModeloLlantiRed],TablaLlantiRed.Medida as [MedidaLlantiRed],TablaLlantiRed.Precio as [PrecioLlantiRed],
TablaMarca.Nombre,TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,(TablaLlantas.Precio-TablaLlantiRed.Precio) as [DiferenciaPrecio],
(((TablaLlantas.Precio-TablaLlantiRed.Precio)/(TablaLlantas.Precio))*100) as DiferenciaPorcentaje from
TablaMarca inner join TablaLlantiRed on TablaMarca.Id=TablaLlantiRed.Marca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca
where TablaLlantiRed.Marca=TablaLlantas.Marca and TablaLlantiRed.Modelo=TablaLlantas.Modelo and
TablaLlantiRed.Medida=TablaLlantas.Medida




Select TablaLlantiRed.Marca, TablaLlantiRed.Modelo,TablaLlantiRed.Medida as [MedidaLlantiRed],TablaLlantiRed.Precio
as [PrecioLlantiRed],TablaMarca.Nombre,TablaLlantas.Modelo,TablaLlantas.Medida,
TablaLlantas.Precio,(TablaLlantas.Precio-TablaLlantiRed.Precio) as [DiferenciaPrecio],
(((TablaLlantas.Precio-TablaLlantiRed.Precio)/(TablaLlantas.Precio))*100) as DiferenciaPorcentaje
 from TablaLlantiRed inner join TablaMarca on TablaMarca.Id=TablaLlantiRed.Marca inner join
 TablaLlantas on TablaMarca.Id=TablaLlantas.Marca inner join TablaCategoria on TablaLlantas.IdCategoria=TablaCategoria.Id where TablaLlantiRed.Medida=TablaLlantas.Medida
 and TablaCategoria.Id=3 and TablaMarca.Id=5

 ---------------------Compara todas las llantas toledo con cada una de las otras llantas de otras marcas con la misma médida--------------------
Select TablaLlantiRed.Modelo as [Modelo],TablaLlantiRed.Medida as [MedidaLlantiRed], TablaLlantiRed.Precio as [PrecioLlantiRed],
TablaMarca.Nombre AS [Marca],TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,
(TablaLlantas.Precio-TablaLlantiRed.Precio) as [DiferenciaPrecio],
(((TablaLlantas.Precio-TablaLlantiRed.Precio)/(TablaLlantas.Precio))*100) as DiferenciaPorcentaje
 from TablaLlantiRed  inner join TablaLlantas on 
TablaLlantiRed.Medida=TablaLlantas.Medida
inner join TablaCategoria on TablaCategoria.Id=TablaLlantas.IdCategoria inner join TablaMarca
on TablaMarca.Id=TablaLlantas.Marca
where TablaLlantiRed.Marca=5 and TablaLlantas.IdCategoria=3
order by TablaLlantiRed.Medida




--Cambio para varchar
Select TablaMarca.Nombre as [MarcaLlantiRed],TablaLlantiRed.Modelo as [ModeloLlantiRed],TablaLlantiRed.Medida as [MedidaLlantiRed],TablaLlantiRed.Precio as [PrecioLlantiRed],TablaMarca.Nombre as [Marca], TablaLlantas.Modelo, TablaLlantas.Medida, TablaLlantas.Precio, (TablaLlantas.Precio - TablaLlantiRed.Precio) as [DiferenciaPrecio],(((TablaLlantas.Precio - TablaLlantiRed.Precio) / (TablaLlantas.Precio)) * 100) as DiferenciaPorcentaje from TablaMarca inner join TablaLlantiRed on TablaMarca.Id=TablaLlantiRed.Marca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca where TablaLlantiRed.Marca=TablaLlantas.Marca and TablaLlantiRed.Modelo=TablaLlantas.Modelo and TablaLlantiRed.Medida = TablaLlantas.Medida and TablaLlantas.IdProveedor=1

Select TablaLlantiRed2.Marca as [MarcaLlantiRed],TablaLlantiRed2.Modelo as [ModeloLlantiRed],TablaLlantiRed2.Medida as [MedidaLlantiRed],TablaLlantiRed2.Precio as [PrecioLlantiRed],TablaLlantas2.Marca as [Marca], TablaLlantas2.Modelo, TablaLlantas2.Medida, TablaLlantas2.Precio, (TablaLlantas2.Precio - TablaLlantiRed2.Precio) as [DiferenciaPrecio],(((TablaLlantas2.Precio - TablaLlantiRed2.Precio) / (TablaLlantas2.Precio)) * 100) as DiferenciaPorcentaje from TablaLlantiRed2 inner join TablaLlantas2 on TablaLlantiRed2.Medida=TablaLlantas2.Medida where TablaLlantiRed2.Marca=TablaLlantas2.Marca and TablaLlantiRed2.Modelo=TablaLlantas2.Modelo and TablaLlantas2.Ecommerce='PRESUEL'


------------------------Practicando la instrucción PIVOT---------------------------
Select 
Pasajero,
case when January is not null then January else 0 end as Enero,
case when February is not null then February else 0 end as Febrero,
case when March is not null then March else 0 end as Marzo,
case when April is not null then April else 0 end as Abril,
case when May is not null then May else 0 end as Mayo,
case when June is not null then June else 0 end as Junio,
case when July is not null then July else 0 end as Julio,
case when August is not null then August else 0 end as Agosto,
case when September is not null then September else 0 end as Septiembre,
case when October is not null then October else 0 end as Octubre,
case when November is not null then November else 0 end as Noviembre,
case when December is not null then December else 0 end as Diciembre
 from
(
select pas.APaterno as Pasajero,
datename(month,pag.Fecha) as Mes,
sum(pag.Monto) as Total
from Pago pag inner join Pasajero pas
on pag.IdPasajero=pas.IdPasajero
group by pas.APaterno,
datename(month,pag.Fecha)
) T
PIVOT (sum(T.Total) for T.Mes in
([January],[February],[March],[April],[May],[June],[July],[August],[September],[October],[November],[December]))PVT







Select TablaLlantiRedNombre.Modelo as [Modelo],TablaLlantiRedNombre.Medida as [MedidaLlantiRed], TablaLlantiRedNombre.Precio as [PrecioLlantiRed],
TablaMarca.Nombre AS [Marca],TablaLlantas.Modelo,TablaLlantas.Medida,TablaLlantas.Precio,
(TablaLlantas.Precio-TablaLlantiRedNombre.Precio) as [DiferenciaPrecio],
(((TablaLlantas.Precio-TablaLlantiRedNombre.Precio)/(TablaLlantas.Precio))*100) as DiferenciaPorcentaje
 from TablaLlantiRedNombre  inner join TablaLlantas on 
TablaLlantiRedNombre.Medida=TablaLlantas.Medida
inner join TablaCategoria on TablaCategoria.Id=TablaLlantas.IdCategoria inner join TablaMarca
on TablaMarca.Id=TablaLlantas.Marca
where TablaLlantiRedNombre.Marca='TOLEDO' and TablaLlantas.IdCategoria=3
order by TablaLlantiRedNombre.Medida



Select TablaMarca.Nombre as [Marca de LlantiRed],TablaLlantiRed.Modelo as [Modelo de LlantiRed],TablaLlantiRed.Medida as [Medida de LlantiRed],TablaLlantiRed.Precio as [Precio de LlantiRed],TablaMarca.Nombre as [Marca], TablaLlantas.Modelo, TablaLlantas.Medida, TablaLlantas.Precio, substring(convert(varchar(20),TablaLlantiRed.Precio-TablaLlantas.Precio),0,CHARINDEX('.',(TablaLlantiRed.Precio-TablaLlantas.Precio))+3) as [Diferencia de Precio],CAST(CAST(round((((TablaLlantiRed.Precio - TablaLlantas.Precio) / (TablaLlantas.Precio)) * 100),0)as int)as varchar(100))+' %' as [Diferencia de Porcentaje] from TablaMarca inner join TablaLlantiRed on TablaMarca.Id=TablaLlantiRed.Marca inner join TablaLlantas on TablaMarca.Id=TablaLlantas.Marca where TablaLlantiRed.Marca=TablaLlantas.Marca and TablaLlantiRed.Modelo=TablaLlantas.Modelo and TablaLlantiRed.Medida = TablaLlantas.Medida and TablaLlantas.IdProveedor=1

--Cambio de comparativa con varchar
Select TablaLlantiRed2.Medida as [Medida de LlantiRed],TablaLlantiRed2.Precio as [Precio de LlantiRed],TablaLlantas2.Marca, TablaLlantas2.Modelo, TablaLlantas2.Medida, TablaLlantas2.Precio, substring(convert(varchar(20),TablaLlantiRed2.Precio-TablaLlantas2.Precio),0,CHARINDEX('.',(TablaLlantiRed2.Precio-TablaLlantas2.Precio))+3) as [Diferencia de Precio],CAST(CAST(round((((TablaLlantiRed2.Precio - TablaLlantas2.Precio) / (TablaLlantas2.Precio)) * 100),0)as int)as varchar(100))+' %' as [Diferencia de Porcentaje] from TablaLlantas2 inner join TablaLlantiRed2 on TablaLlantas2.Medida=TablaLlantiRed2.Medida
where TablaLlantiRed2.Marca='TOLEDO' and TablaLlantas2.Ecommerce='LLANTIJOSECHUY' order by TablaLlantiRed2.Medida

Select * from TablaLlantiRed2 where Marca='TOLEDO'




Select Marca,Modelo,Medida,Precio from TablaLlantas2 where Medida='220/55R20'











SELECT TablaLlantiRed2.Marca as [MarcaLlantiRed],TablaLlantiRed2.Modelo as [ModeloLlantiRed],TablaLlantiRed2.Medida as [MedidaLlantiRed],TablaLlantiRed2.Precio as [PrecioLlantiRed],TablaLlantas2.Marca as [Marca], TablaLlantas2.Modelo, TablaLlantas2.Medida, TablaLlantas2.Precio, (TablaLlantas2.Precio - TablaLlantiRed2.Precio) as [DiferenciaPrecio],(((TablaLlantas2.Precio - TablaLlantiRed2.Precio) / (TablaLlantas2.Precio)) * 100) as DiferenciaPorcentaje from TablaLlantiRed2 inner join TablaLlantas2 on TablaLlantiRed2.Medida=TablaLlantas2.Medida where TablaLlantiRed2.Marca=TablaLlantas2.Marca and TablaLlantiRed2.Modelo=TablaLlantas2.Modelo and TablaLlantiRed2.Marca='MICHELLIN' and TablaLlantiRed2.Modelo='PROGRAMACION' and TablaLlantas2.Ecommerce='COMPETENCIA DE JOSECHUY'