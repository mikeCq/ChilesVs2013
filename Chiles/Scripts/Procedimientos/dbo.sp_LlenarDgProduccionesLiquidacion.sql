CREATE PROCEDURE [dbo].[sp_LlenarDgProduccionesLiquidacion]
AS
	select idproduccion, 
		   fecha, 
		   precio, 
		   cantidadbotes, 
		   sumabotes, 
		   producto,
		   CASE IdEstatus 
		    WHEN 0 THEN 'CERRADO'
			WHEN 1 THEN 'ABIERTO'
			WHEN 2 THEN 'LIQUIDADO'
		   END as IdEstatus
	from Produccion
	where IdEstatus = 0