CREATE proc sp_InsLiqDet
@idproduccion as int 
as
begin
insert into LiquidacionDetalle (Empleado,Lunes,Martes,Miercoles,Jueves,Viernes,Sabado,IdProduccion)
SELECT
   EMPLEADO,
   COALESCE(LUNES, 0) LUNES,
   COALESCE(MARTES, 0)  MARTES,
   COALESCE(MIERCOLES, 0) MIERCOLES,
   COALESCE(JUEVES, 0) JUEVES,
   COALESCE(VIERNES, 0) VIERNES,
   COALESCE(SABADO, 0) SABADO,
   IDPRODUCCION
FROM
    (
	SELECT Empleado
		  ,SUM(PrecioBote) AS Pagar
		  ,dbo.RemoverTildes(FechaLetra) as FechaLetra
		  ,IdProduccion
	FROM Botes
	where IdProduccion = @idproduccion
	GROUP BY Empleado,PrecioBote,FechaLetra,IdProduccion
    ) SOURCE
PIVOT
    (
        SUM(SOURCE.Pagar) FOR SOURCE.FechaLetra IN (LUNES, MARTES, MIERCOLES,JUEVES,VIERNES,SABADO)
    ) AS PIVOTABLE;
end

DECLARE @NoBotes as int,
		@empleado as int

DECLARE NOBOTESEMPLEADO  CURSOR FOR  select empleado , sum(BotesRecibidos) as NoBotes from Botes where IdProduccion = @idproduccion group by Empleado

	OPEN NOBOTESEMPLEADO

	FETCH NEXT FROM NOBOTESEMPLEADO INTO @empleado,@NoBotes
	WHILE @@fetch_status = 0
	BEGIN
			update LiquidacionDetalle
			set NoBotes = @NoBotes
			where  IdProduccion = @idproduccion and Empleado = @empleado
			update Produccion
			set    IdEstatus = 2
			where  IdProduccion = @idproduccion			
	FETCH NEXT FROM NOBOTESEMPLEADO INTO  @empleado,@NoBotes
	END
	
	CLOSE NOBOTESEMPLEADO
	DEALLOCATE NOBOTESEMPLEADO