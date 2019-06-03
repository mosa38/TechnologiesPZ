CREATE TABLE [dbo].[Job] (
    [JobId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Time] INT            NULL,
    [Priority]  INT            NULL,
    [Status]     NVARCHAR (MAX) NULL,
    [WorkerId]     INT       NOT NULL,
    CONSTRAINT [PK_dbo.Job] PRIMARY KEY CLUSTERED ([JobId] ASC),
    CONSTRAINT [FK_dbo.Job_dbo.Worker_WorkerId] FOREIGN KEY ([WorkerId]) REFERENCES [dbo].[Worker] ([WorkerId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_WorkerId]
    ON [dbo].[Job]([WorkerId] ASC);

