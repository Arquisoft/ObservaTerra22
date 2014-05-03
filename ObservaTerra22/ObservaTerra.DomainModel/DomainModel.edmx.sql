
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/03/2014 12:36:00
-- Generated from EDMX file: C:\Users\Javier\Documents\ObservaTerra22\ObservaTerra22\ObservaTerra.DomainModel\DomainModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Data];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Areas'
CREATE TABLE [dbo].[Areas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AreaId] int  NOT NULL
);
GO

-- Creating table 'CountrySet'
CREATE TABLE [dbo].[CountrySet] (
    [Continent] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Indicators'
CREATE TABLE [dbo].[Indicators] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Area_Id] int  NOT NULL,
    [Measure_Id] int  NOT NULL
);
GO

-- Creating table 'Measures'
CREATE TABLE [dbo].[Measures] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Organizations'
CREATE TABLE [dbo].[Organizations] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Observations'
CREATE TABLE [dbo].[Observations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CreationDate] time  NOT NULL,
    [SourceOrganization_Id] int  NOT NULL,
    [Indicator_Id] int  NOT NULL,
    [UserAuthor_Id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ITimes'
CREATE TABLE [dbo].[ITimes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Indicator_Id] int  NOT NULL
);
GO

-- Creating table 'TimeIntervalSet'
CREATE TABLE [dbo].[TimeIntervalSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'TimeInstantSet'
CREATE TABLE [dbo].[TimeInstantSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'IComponents'
CREATE TABLE [dbo].[IComponents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Observation_Id] int  NOT NULL
);
GO

-- Creating table 'ImageComponentSet'
CREATE TABLE [dbo].[ImageComponentSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'GraphComponentSet'
CREATE TABLE [dbo].[GraphComponentSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'VideoComponentSet'
CREATE TABLE [dbo].[VideoComponentSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'TextComponentSet'
CREATE TABLE [dbo].[TextComponentSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'DocumentComponentSet'
CREATE TABLE [dbo].[DocumentComponentSet] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'RoleSet'
CREATE TABLE [dbo].[RoleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrganizationUser'
CREATE TABLE [dbo].[OrganizationUser] (
    [Organizations_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- Creating table 'UserRole'
CREATE TABLE [dbo].[UserRole] (
    [Users_Id] int  NOT NULL,
    [Roles_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [PK_Areas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CountrySet'
ALTER TABLE [dbo].[CountrySet]
ADD CONSTRAINT [PK_CountrySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Indicators'
ALTER TABLE [dbo].[Indicators]
ADD CONSTRAINT [PK_Indicators]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Measures'
ALTER TABLE [dbo].[Measures]
ADD CONSTRAINT [PK_Measures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Organizations'
ALTER TABLE [dbo].[Organizations]
ADD CONSTRAINT [PK_Organizations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Observations'
ALTER TABLE [dbo].[Observations]
ADD CONSTRAINT [PK_Observations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ITimes'
ALTER TABLE [dbo].[ITimes]
ADD CONSTRAINT [PK_ITimes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TimeIntervalSet'
ALTER TABLE [dbo].[TimeIntervalSet]
ADD CONSTRAINT [PK_TimeIntervalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TimeInstantSet'
ALTER TABLE [dbo].[TimeInstantSet]
ADD CONSTRAINT [PK_TimeInstantSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IComponents'
ALTER TABLE [dbo].[IComponents]
ADD CONSTRAINT [PK_IComponents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ImageComponentSet'
ALTER TABLE [dbo].[ImageComponentSet]
ADD CONSTRAINT [PK_ImageComponentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GraphComponentSet'
ALTER TABLE [dbo].[GraphComponentSet]
ADD CONSTRAINT [PK_GraphComponentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VideoComponentSet'
ALTER TABLE [dbo].[VideoComponentSet]
ADD CONSTRAINT [PK_VideoComponentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TextComponentSet'
ALTER TABLE [dbo].[TextComponentSet]
ADD CONSTRAINT [PK_TextComponentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentComponentSet'
ALTER TABLE [dbo].[DocumentComponentSet]
ADD CONSTRAINT [PK_DocumentComponentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoleSet'
ALTER TABLE [dbo].[RoleSet]
ADD CONSTRAINT [PK_RoleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Organizations_Id], [Users_Id] in table 'OrganizationUser'
ALTER TABLE [dbo].[OrganizationUser]
ADD CONSTRAINT [PK_OrganizationUser]
    PRIMARY KEY CLUSTERED ([Organizations_Id], [Users_Id] ASC);
GO

-- Creating primary key on [Users_Id], [Roles_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [PK_UserRole]
    PRIMARY KEY CLUSTERED ([Users_Id], [Roles_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AreaId] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [FK_AreaArea]
    FOREIGN KEY ([AreaId])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaArea'
CREATE INDEX [IX_FK_AreaArea]
ON [dbo].[Areas]
    ([AreaId]);
GO

-- Creating foreign key on [Area_Id] in table 'Indicators'
ALTER TABLE [dbo].[Indicators]
ADD CONSTRAINT [FK_IndicatorArea]
    FOREIGN KEY ([Area_Id])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_IndicatorArea'
CREATE INDEX [IX_FK_IndicatorArea]
ON [dbo].[Indicators]
    ([Area_Id]);
GO

-- Creating foreign key on [Measure_Id] in table 'Indicators'
ALTER TABLE [dbo].[Indicators]
ADD CONSTRAINT [FK_IndicatorMeasure]
    FOREIGN KEY ([Measure_Id])
    REFERENCES [dbo].[Measures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_IndicatorMeasure'
CREATE INDEX [IX_FK_IndicatorMeasure]
ON [dbo].[Indicators]
    ([Measure_Id]);
GO

-- Creating foreign key on [SourceOrganization_Id] in table 'Observations'
ALTER TABLE [dbo].[Observations]
ADD CONSTRAINT [FK_ObservationOrganization]
    FOREIGN KEY ([SourceOrganization_Id])
    REFERENCES [dbo].[Organizations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ObservationOrganization'
CREATE INDEX [IX_FK_ObservationOrganization]
ON [dbo].[Observations]
    ([SourceOrganization_Id]);
GO

-- Creating foreign key on [Organizations_Id] in table 'OrganizationUser'
ALTER TABLE [dbo].[OrganizationUser]
ADD CONSTRAINT [FK_OrganizationUser_Organization]
    FOREIGN KEY ([Organizations_Id])
    REFERENCES [dbo].[Organizations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'OrganizationUser'
ALTER TABLE [dbo].[OrganizationUser]
ADD CONSTRAINT [FK_OrganizationUser_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrganizationUser_User'
CREATE INDEX [IX_FK_OrganizationUser_User]
ON [dbo].[OrganizationUser]
    ([Users_Id]);
GO

-- Creating foreign key on [Indicator_Id] in table 'Observations'
ALTER TABLE [dbo].[Observations]
ADD CONSTRAINT [FK_ObservationIndicator]
    FOREIGN KEY ([Indicator_Id])
    REFERENCES [dbo].[Indicators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ObservationIndicator'
CREATE INDEX [IX_FK_ObservationIndicator]
ON [dbo].[Observations]
    ([Indicator_Id]);
GO

-- Creating foreign key on [UserAuthor_Id] in table 'Observations'
ALTER TABLE [dbo].[Observations]
ADD CONSTRAINT [FK_ObservationUser]
    FOREIGN KEY ([UserAuthor_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ObservationUser'
CREATE INDEX [IX_FK_ObservationUser]
ON [dbo].[Observations]
    ([UserAuthor_Id]);
GO

-- Creating foreign key on [Indicator_Id] in table 'ITimes'
ALTER TABLE [dbo].[ITimes]
ADD CONSTRAINT [FK_ITimeIndicator]
    FOREIGN KEY ([Indicator_Id])
    REFERENCES [dbo].[Indicators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ITimeIndicator'
CREATE INDEX [IX_FK_ITimeIndicator]
ON [dbo].[ITimes]
    ([Indicator_Id]);
GO

-- Creating foreign key on [Observation_Id] in table 'IComponents'
ALTER TABLE [dbo].[IComponents]
ADD CONSTRAINT [FK_IComponentObservation]
    FOREIGN KEY ([Observation_Id])
    REFERENCES [dbo].[Observations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_IComponentObservation'
CREATE INDEX [IX_FK_IComponentObservation]
ON [dbo].[IComponents]
    ([Observation_Id]);
GO

-- Creating foreign key on [Users_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [FK_UserRole_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Roles_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [FK_UserRole_Role]
    FOREIGN KEY ([Roles_Id])
    REFERENCES [dbo].[RoleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRole_Role'
CREATE INDEX [IX_FK_UserRole_Role]
ON [dbo].[UserRole]
    ([Roles_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------