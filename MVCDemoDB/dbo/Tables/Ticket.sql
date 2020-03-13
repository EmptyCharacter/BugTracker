CREATE TABLE [dbo].[Ticket]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [ProjectName] NVARCHAR(50) NOT NULL, 
    [DevAssigned] NVARCHAR(50) NOT NULL, 
    [TicketPriority] NVARCHAR(50) NOT NULL, 
    [TicketStatus] NVARCHAR(50) NOT NULL, 
    [TicketType] NVARCHAR(50) NOT NULL, 
    [TicketComments] NVARCHAR(MAX) NOT NULL, 
    [Created] DATE NOT NULL
)
