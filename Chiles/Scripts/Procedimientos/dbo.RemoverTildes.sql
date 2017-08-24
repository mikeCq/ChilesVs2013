CREATE FUNCTION RemoverTildes ( @Cadena VARCHAR(100) )
RETURNS VARCHAR(100)
AS BEGIN
 
     RETURN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@Cadena,'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U')
 
   END