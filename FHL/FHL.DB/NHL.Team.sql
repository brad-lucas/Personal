﻿CREATE TABLE [NHL].[Team]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL,
    [Abbreviation] NCHAR(3) NOT NULL
)