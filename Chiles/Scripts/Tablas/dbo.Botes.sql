CREATE TABLE [dbo].[Botes] (
    [IdBotes]        INT          IDENTITY (1, 1) NOT NULL,
    [Empleado]       INT          NULL,
    [BotesRecibidos] INT          NULL,
    [Fecha]          DATE         NULL,
    [IdProduccion]   INT          NOT NULL,
    [PrecioBote]     FLOAT (53)   NULL,
    [FechaLetra]     VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([IdBotes] ASC)
);

