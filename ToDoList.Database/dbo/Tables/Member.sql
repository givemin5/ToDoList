CREATE TABLE [dbo].[Member] (
    [Id]       INT           NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Account]  NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED ([Id] ASC)
);

