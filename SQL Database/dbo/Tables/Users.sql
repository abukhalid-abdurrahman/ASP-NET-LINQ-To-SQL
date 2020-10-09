CREATE TABLE [dbo].[Users] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (15) NOT NULL,
    [Surname] NVARCHAR (15) NULL,
    [Phone]   INT           NULL,
    [Country] NVARCHAR (20) NULL
);


GO
CREATE TRIGGER TR_LogUserIns ON Users AFTER INSERT
	AS
		INSERT INTO Logs (Message, CreateDate)
		SELECT 'NEW USER WAS ADDED', GETDATE()
		FROM inserted
