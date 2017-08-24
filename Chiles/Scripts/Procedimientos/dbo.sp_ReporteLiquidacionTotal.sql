CREATE PROCEDURE [dbo].[sp_ReporteLiquidacionTotal]
	@IdProduccion as int
AS
	SELECT  idproduccion
		   ,Fecha
		   ,Precio
		   ,CantidadBotes
		   ,SumaBotes
		   ,Producto
		   ,IdEstatus
		   ,FechaLetra
	FROM	Produccion
	WHERE IdProduccion = @IdProduccion and IdEstatus = 2