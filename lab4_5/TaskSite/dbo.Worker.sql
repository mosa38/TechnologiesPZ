CREATE TABLE [dbo].[Worker] (
    [WorkerId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Busy]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Worker] PRIMARY KEY CLUSTERED ([WorkerId] ASC)
);