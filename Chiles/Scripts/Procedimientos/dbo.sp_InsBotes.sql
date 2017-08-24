CREATE procedure sp_InsBotes
@IdBotes int output,
@Empleado Int,
@BotesRecibidos int,
@Fecha datetime,
@IdProduccion int,
@PrecioBote float,
@FechaLetra varchar(20)
as
begin
set nocount on
merge [dbo].[Botes] as target
using (select @IdBotes,@Empleado,@BotesRecibidos,@Fecha,@IdProduccion,@PrecioBote,@FechaLetra) AS SOURCE (IdBotes,Empleado,BotesRecibidos,Fecha,IdProduccion,PrecioBote,FechaLetra)
ON (target.IdBotes = SOURCE.IdBotes)
WHEN MATCHED THEN
UPDATE SET Empleado = Source.Empleado,
		   BotesRecibidos = source.BotesRecibidos,
		   Fecha = Source.Fecha,
		   IdProduccion = Source.IdProduccion,
		   PrecioBote = source.PrecioBote,
		   FechaLetra = source.FechaLetra
WHEN NOT MATCHED THEN
        INSERT (Empleado,BotesRecibidos,Fecha,IdProduccion,PrecioBote,FechaLetra)
        VALUES (Source.Empleado,source.BotesRecibidos,Source.Fecha,Source.IdProduccion,source.PrecioBote,source.fechaletra);
		SET @IdBotes = SCOPE_IDENTITY()
END
RETURN @IdBotes