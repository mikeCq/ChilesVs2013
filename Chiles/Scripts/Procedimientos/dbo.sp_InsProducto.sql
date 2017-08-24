CREATE procedure sp_InsProducto
@IdProducto int output,
@Nombre varchar(20)
as
begin
set nocount on
merge [dbo].[Productos] as target
using (select @IdProducto,@Nombre) AS SOURCE (IdProducto,Nombre)
ON (target.IdProducto = SOURCE.IdProducto)
WHEN MATCHED THEN
UPDATE SET Nombre = Source.Nombre
WHEN NOT MATCHED THEN
        INSERT (Nombre)
        VALUES (Source.Nombre);
		SET @IdProducto = SCOPE_IDENTITY()
END
RETURN @IdProducto