CREATE TABLE [dbo].[BlockDates] (
    [Id]   INT      IDENTITY (1, 1) NOT NULL,
    [Date] DATETIME NOT NULL,
    CONSTRAINT [PK_dbo.BlockDates] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[Makes] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Makes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[Models] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NULL,
    [Make_Id] INT            NULL,
    CONSTRAINT [PK_dbo.Models] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Models_dbo.Makes_Make_Id] FOREIGN KEY ([Make_Id]) REFERENCES [dbo].[Makes] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Make_Id]
    ON [dbo].[Models]([Make_Id] ASC);


GO

CREATE TABLE [dbo].[Services] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX)  NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [DealerPrice] DECIMAL (18, 2) NOT NULL,
    [Model_Id]    INT             NULL,
    CONSTRAINT [PK_dbo.Services] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Services_dbo.Models_Model_Id] FOREIGN KEY ([Model_Id]) REFERENCES [dbo].[Models] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Model_Id]
    ON [dbo].[Services]([Model_Id] ASC);


GO

CREATE TABLE [dbo].[Contacts] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Firstname]    NVARCHAR (MAX) NULL,
    [Lastname]     NVARCHAR (MAX) NULL,
    [Email]        NVARCHAR (MAX) NULL,
    [Telephone]    NVARCHAR (MAX) NULL,
    [Registration] NVARCHAR (MAX) NULL,
    [ModelId]      INT            NOT NULL,
    [Service_Id]   INT            NULL,
    CONSTRAINT [PK_dbo.Contacts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Contacts_dbo.Services_Service_Id] FOREIGN KEY ([Service_Id]) REFERENCES [dbo].[Services] ([Id]),
    CONSTRAINT [FK_dbo.Contacts_dbo.Models_ModelId] FOREIGN KEY ([ModelId]) REFERENCES [dbo].[Models] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ModelId]
    ON [dbo].[Contacts]([ModelId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Service_Id]
    ON [dbo].[Contacts]([Service_Id] ASC);

