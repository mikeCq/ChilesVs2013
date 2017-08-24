CREATE PROCEDURE [dbo].[sp_LlenarLiquidaciones]
	@FechaIni as date,
	@FechaFin as Date,
	@Producto as varchar(20)
AS
begin
	if @FechaIni = '01/01/2000' and @FechaFin = '01/01/2000' and @Producto = ''
		begin
			select idProduccion,
				   Fecha,
				   Precio,
				   CantidadBotes,
				   SumaBotes,
				   Producto,
				   IdEstatus
			from   Produccion
			where  IdEstatus = 0
		end  
	end