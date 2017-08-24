CREATE PROCEDURE [dbo].[sp_selProduccion]
	@IdProduccion int
AS
	SELECT IdProduccion, Fecha, Precio, CantidadBotes, SumaBotes,Producto,IdEstatus, FechaLetra
	from Produccion 
	where IdProduccion = @IdProduccion