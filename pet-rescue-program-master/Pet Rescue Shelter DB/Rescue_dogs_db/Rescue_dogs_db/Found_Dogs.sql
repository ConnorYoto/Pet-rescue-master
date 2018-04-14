CREATE TABLE [dbo].[Found_Dogs]
(
	[TagID] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(20) NULL, 
    [Breed] VARCHAR(20) NOT NULL, 
    [Identifiers] VARCHAR(MAX) NULL, 
    [Location] VARCHAR(50) NULL
)
