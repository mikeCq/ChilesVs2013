CREATE procedure sp_InsProduccion
@IdProduccion int output,
@Fecha datetime,
@FechaLetra varchar(20),
@Precio decimal(10,2),
@CantidadBotes int,
@SumaBotes decimal(10,2),
@Producto varchar(20),
@IdEstatus int output
as
begin
set nocount on
merge [dbo].[Produccion] as target
using (select @IdProduccion,@Fecha,@Precio,@CantidadBotes,@SumaBotes,@Producto,@IdEstatus,@FechaLetra) AS SOURCE (IdProduccion,Fecha,Precio,CantidadBotes,SumaBotes,Producto, IdEstatus, FechaLetra)
ON (target.IdProduccion = SOURCE.IdProduccion)
WHEN MATCHED THEN
UPDATE SET Fecha = Source.Fecha,
		   Precio = Source.Precio,
		   CantidadBotes = Source.CantidadBotes,
		   SumaBotes = Source.SumaBotes,
		   Producto = source.Producto,
		   IdEstatus = source.IdEstatus,
		   FechaLetra = source.FechaLetra
WHEN NOT MATCHED THEN
        INSERT (Fecha,Precio,CantidadBotes,SumaBotes,Producto,IdEstatus,FechaLetra)
        VALUES (Source.Fecha,Source.Precio,Source.CantidadBotes,Source.SumaBotes, source.Producto,source.IdEstatus,source.FechaLetra);
		SET @IdProduccion = SCOPE_IDENTITY()
END
RETURN @IdProduccion
return @IdEstatus