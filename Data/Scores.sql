  
CREATE TABLE [dbo].[Scores] (
    [pos]     INT           IDENTITY (1, 1) NOT NULL,
    [score]   INT           NOT NULL,
    [description] VARCHAR (128) NOT NULL,
    PRIMARY KEY CLUSTERED ([pos] ASC)
);