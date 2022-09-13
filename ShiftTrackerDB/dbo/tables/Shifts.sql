CREATE TABLE [dbo].[Shifts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StartDateTime] DATETIME NOT NULL, 
    [EndDateTime] DATETIME NOT NULL, 
    [Pay] MONEY NOT NULL, 
    [Minutes] DECIMAL(8, 2) NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL
)
