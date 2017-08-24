CREATE PROCEDURE [dbo].[sp_ConProduccion]
	@FechaIni datetime,
	@FechaFin datetime,
	@Producto varchar(20),
	@IdEstatus int
AS

   select Producto,
		  Fecha,
		  SumaBotes,
		  CantidadBotes,
		  Precio
   from Produccion      
   where Fecha between @FechaIni and @FechaFin
   and   Producto = @Producto
   and   IdEstatus = @IdEstatus