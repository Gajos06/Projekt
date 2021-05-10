CREATE TABLE [dbo].[BazaPytan]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Question] VARCHAR(255) NOT NULL, 
    [OptionA] VARCHAR(100) NOT NULL, 
    [OptionB] VARCHAR(100) NOT NULL, 
    [OptionC] VARCHAR(100) NOT NULL, 
    [OptionD] VARCHAR(100) NOT NULL, 
    [Answer] VARCHAR(100) NOT NULL
)
