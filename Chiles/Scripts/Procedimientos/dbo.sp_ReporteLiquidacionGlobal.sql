CREATE PROCEDURE [dbo].[sp_ReporteLiquidacionGlobal]  
 @IdProduccion as varchar(100)
AS  
--set @IdProduccion = replace(@idproduccion,',' ,''',''' )
--set @IdProduccion = '''' + @idproduccion + ''''
declare @sql as nvarchar(max) = 'select P.IdProduccion,P.Producto, p.Precio, l.Empleado, l.NoBotes,l.Lunes, l.Martes, l.Miercoles, l.Jueves, l.Viernes, l.Sabado
from Produccion P
inner join LiquidacionDetalle L
 on p.IdProduccion= L.IdProduccion

where p.IdProduccion in ('+@IdProduccion+') order by p.IdProduccion'

execute sp_executesql @sql