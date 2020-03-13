CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL
)
