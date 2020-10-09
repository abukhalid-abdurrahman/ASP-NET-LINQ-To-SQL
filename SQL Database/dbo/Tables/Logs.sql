CREATE TABLE [dbo].[Logs] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Message]    NVARCHAR (MAX) NOT NULL,
    [CreateDate] DATETIME       NOT NULL
);

