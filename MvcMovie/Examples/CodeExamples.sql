CREATE TABLE [dbo].[CodeExamples]
(
	[exampleId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Title] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [Url] VARCHAR(100) NOT NULL, 
    [ImageUrl] VARCHAR(100) NOT NULL
)
