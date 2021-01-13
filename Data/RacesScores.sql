CREATE TABLE [dbo].[RacesScores]
(
	[id] INT NOT NULL IDENTITY(1, 1), 
	[extDriver] INT NOT NULL, 
	[extPos] INT NOT NULL, 
	[extRace] INT NOT NULL,
	[fastestLap] VARCHAR(30) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
);