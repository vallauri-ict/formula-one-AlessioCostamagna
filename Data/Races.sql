CREATE TABLE [dbo].[Races] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (128) NOT NULL,
    [extCircuit] INT 		   NOT NULL,
    [date]       DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

SET IDENTITY_INSERT [dbo].[Races] ON;
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (1, N'Formula 1 Rolex Grosser Preis Von Österreich 2020', 9, N'2019-03-17');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (2, N'Formula 1 Pirelli Grosser Preis Der Steiermark 2020', 9, N'2019-03-31');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (3, N'Formula 1 Aramco Magyar Nagydíj 2020', 12, N'2019-03-31');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (4, N'Formula 1 Pirelli British Grand Prix 2020', 11, N'2019-04-28');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (5, N'Emirates Formula 1 70th Anniversary Grand Prix 2020', 11, N'2019-05-12');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (6, N'Formula 1 Aramco Gran Premio De España 2020', 8, N'2019-05-12');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (7, N'Formula 1 Rolex Belgian Grand Prix 2020', 13, N'2019-06-09');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (8, N'Formula 1 Gran Premio Heineken D’italia 2020', 10, N'2019-06-23');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (9, N'Formula 1 Pirelli Gran Premio Della Toscana Ferrari 1000 2020', 7, N'2019-06-30');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (10, N'Formula 1 VTB Russian Grand Prix 2020', 14, N'2019-07-12');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (11, N'Formula 1 Aramco Grosser Preis Der Eifel 2020', 5, N'2019-07-28');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (12, N'Formula 1 Heineken Grande Prémio De Portugal 2020', 4, N'2019-08-04');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (13, N'Formula 1 Emirates Gran Premio Dell’ emilia Romagna 2020', 3, N'2019-09-01');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (14, N'Formula 1 DHL Turkish Grand Prix 2020', 2, N'2019-11-08');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (15, N'Formula 1 Gulf Air Bahrain Grand Prix 2020', 6, N'2019-09-22');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (16, N'Formula 1 Rolex Sakhir Grand Prix 2020', 1, N'2019-09-29');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (17, N'Formula 1 Etihad Airways Abu Dhabi Grand Prix 2020', 15, N'2019-09-29');
SET IDENTITY_INSERT [dbo].[Races] OFF;