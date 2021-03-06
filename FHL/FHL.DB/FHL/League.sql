﻿CREATE TABLE [FHL].[League]
(
	[Id] INT NOT NULL IDENTITY(1,1) CONSTRAINT [PK_League] PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL CONSTRAINT [PK_League_Name] UNIQUE,
	[MaxNumberOfTeams] TINYINT NOT NULL,
	[NumberOfPlayoffRounds] TINYINT NOT NULL,
	[RosterSize] TINYINT NOT NULL,
	[FarmSize] TINYINT NOT NULL DEFAULT 0,
	[SalaryCap] TINYINT NULL,
	[TradeDeadlineDateTime] DATETIME NULL,
	[RosterFreezeDateTime] DATETIME NULL
)
