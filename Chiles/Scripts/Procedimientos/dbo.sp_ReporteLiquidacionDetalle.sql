CREATE PROCEDURE [dbo].[sp_ReporteLiquidacionDetalle]
	@IdProduccion as int
AS
	select empleado
		  ,NoBotes
		  ,Lunes
		  ,Martes
		  ,Miercoles
		  ,Jueves
		  ,Viernes
		  ,Sabado
	from LiquidacionDetalle
	where IdProduccion = @IdProduccion