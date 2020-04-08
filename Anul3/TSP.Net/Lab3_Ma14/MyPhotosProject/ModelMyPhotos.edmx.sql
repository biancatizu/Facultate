
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 20:13:12
-- Generated from EDMX file: D:\Facultate\Anul3\Semestrul2\TSP .NET\MyPhotos\MyPhotosProject\ModelMyPhotos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotosDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Media]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Media];
GO
IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [Id] int  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [date] datetime  NOT NULL,
    [location] nvarchar(max)  NOT NULL,
    [event] nvarchar(max)  NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [Id] int  NOT NULL,
    [personName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonsMedias'
CREATE TABLE [dbo].[PersonsMedias] (
    [MediaId] int  NOT NULL,
    [PersonsId] int  NOT NULL,
    [Id] int NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonsMedias'
ALTER TABLE [dbo].[PersonsMedias]
ADD CONSTRAINT [PK_PersonsMedias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MediaId] in table 'PersonsMedias'
ALTER TABLE [dbo].[PersonsMedias]
ADD CONSTRAINT [FK_PersonsMediaMedia]
    FOREIGN KEY ([MediaId])
    REFERENCES [dbo].[Media]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonsMediaMedia'
CREATE INDEX [IX_FK_PersonsMediaMedia]
ON [dbo].[PersonsMedias]
    ([MediaId]);
GO

-- Creating foreign key on [PersonsId] in table 'PersonsMedias'
ALTER TABLE [dbo].[PersonsMedias]
ADD CONSTRAINT [FK_PersonsMediaPersons]
    FOREIGN KEY ([PersonsId])
    REFERENCES [dbo].[Persons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonsMediaPersons'
CREATE INDEX [IX_FK_PersonsMediaPersons]
ON [dbo].[PersonsMedias]
    ([PersonsId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------