
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2014 09:48:02
-- Generated from EDMX file: C:\Users\uo228152\Documents\ObservaTerra22\ObservaTerra22\ObservaTerra.DomainModel\DomainModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_AreaArea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Areas] DROP CONSTRAINT [FK_AreaArea];
GO
IF OBJECT_ID(N'[dbo].[FK_IndicatorArea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Indicators] DROP CONSTRAINT [FK_IndicatorArea];
GO
IF OBJECT_ID(N'[dbo].[FK_IndicatorMeasure]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Indicators] DROP CONSTRAINT [FK_IndicatorMeasure];
GO
IF OBJECT_ID(N'[dbo].[FK_ObservationIndicator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_ObservationIndicator];
GO
IF OBJECT_ID(N'[dbo].[FK_ITimeIndicator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ITimes] DROP CONSTRAINT [FK_ITimeIndicator];
GO
IF OBJECT_ID(N'[dbo].[FK_ObservationUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_ObservationUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ObservationOrganization]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_ObservationOrganization];
GO
IF OBJECT_ID(N'[dbo].[FK_OrganizationUser_Organization]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrganizationUser] DROP CONSTRAINT [FK_OrganizationUser_Organization];
GO
IF OBJECT_ID(N'[dbo].[FK_OrganizationUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrganizationUser] DROP CONSTRAINT [FK_OrganizationUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_IComponentObservation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IComponents] DROP CONSTRAINT [FK_IComponentObservation];
GO
IF OBJECT_ID(N'[dbo].[FK_Country_inherits_Area]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Areas_Country] DROP CONSTRAINT [FK_Country_inherits_Area];
GO
IF OBJECT_ID(N'[dbo].[FK_TimeInterval_inherits_ITime]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ITimes_TimeInterval] DROP CONSTRAINT [FK_TimeInterval_inherits_ITime];
GO
IF OBJECT_ID(N'[dbo].[FK_TimeInstant_inherits_ITime]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ITimes_TimeInstant] DROP CONSTRAINT [FK_TimeInstant_inherits_ITime];
GO
IF OBJECT_ID(N'[dbo].[FK_ImageComponent_inherits_IComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IComponents_ImageComponent] DROP CONSTRAINT [FK_ImageComponent_inherits_IComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_GraphComponent_inherits_IComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IComponents_GraphComponent] DROP CONSTRAINT [FK_GraphComponent_inherits_IComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_VideoComponent_inherits_IComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IComponents_VideoComponent] DROP CONSTRAINT [FK_VideoComponent_inherits_IComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_TextComponent_inherits_IComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IComponents_TextComponent] DROP CONSTRAINT [FK_TextComponent_inherits_IComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentComponent_inherits_IComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IComponents_DocumentComponent] DROP CONSTRAINT [FK_DocumentComponent_inherits_IComponent];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Areas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Areas];
GO
IF OBJECT_ID(N'[dbo].[Indicators]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Indicators];
GO
IF OBJECT_ID(N'[dbo].[Measures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Measures];
GO
IF OBJECT_ID(N'[dbo].[Organizations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Organizations];
GO
IF OBJECT_ID(N'[dbo].[Observations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Observations];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[ITimes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ITimes];
GO
IF OBJECT_ID(N'[dbo].[IComponents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IComponents];
GO
IF OBJECT_ID(N'[dbo].[Areas_Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Areas_Country];
GO
IF OBJECT_ID(N'[dbo].[ITimes_TimeInterval]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ITimes_TimeInterval];
GO
IF OBJECT_ID(N'[dbo].[ITimes_TimeInstant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ITimes_TimeInstant];
GO
IF OBJECT_ID(N'[dbo].[IComponents_ImageComponent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IComponents_ImageComponent];
GO
IF OBJECT_ID(N'[dbo].[IComponents_GraphComponent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IComponents_GraphComponent];
GO
IF OBJECT_ID(N'[dbo].[IComponents_VideoComponent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IComponents_VideoComponent];
GO
IF OBJECT_ID(N'[dbo].[IComponents_TextComponent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IComponents_TextComponent];
GO
IF OBJECT_ID(N'[dbo].[IComponents_DocumentComponent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IComponents_DocumentComponent];
GO
IF OBJECT_ID(N'[dbo].[OrganizationUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrganizationUser];
GO

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
    [Indicator_Id] int  NOT NULL,
    [UserAuthor_Id] int  NOT NULL,
    [SourceOrganization_Id] int  NOT NULL
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

-- Creating table 'IComponents'
CREATE TABLE [dbo].[IComponents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Observation_Id] int  NOT NULL
);
GO

-- Creating table 'RoleSet'
CREATE TABLE [dbo].[RoleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Areas_Country'
CREATE TABLE [dbo].[Areas_Country] (
    [Continent] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ITimes_TimeInterval'
CREATE TABLE [dbo].[ITimes_TimeInterval] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'ITimes_TimeInstant'
CREATE TABLE [dbo].[ITimes_TimeInstant] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'IComponents_ImageComponent'
CREATE TABLE [dbo].[IComponents_ImageComponent] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'IComponents_GraphComponent'
CREATE TABLE [dbo].[IComponents_GraphComponent] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'IComponents_VideoComponent'
CREATE TABLE [dbo].[IComponents_VideoComponent] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'IComponents_TextComponent'
CREATE TABLE [dbo].[IComponents_TextComponent] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'IComponents_DocumentComponent'
CREATE TABLE [dbo].[IComponents_DocumentComponent] (
    [Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'IComponents'
ALTER TABLE [dbo].[IComponents]
ADD CONSTRAINT [PK_IComponents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoleSet'
ALTER TABLE [dbo].[RoleSet]
ADD CONSTRAINT [PK_RoleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Areas_Country'
ALTER TABLE [dbo].[Areas_Country]
ADD CONSTRAINT [PK_Areas_Country]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ITimes_TimeInterval'
ALTER TABLE [dbo].[ITimes_TimeInterval]
ADD CONSTRAINT [PK_ITimes_TimeInterval]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ITimes_TimeInstant'
ALTER TABLE [dbo].[ITimes_TimeInstant]
ADD CONSTRAINT [PK_ITimes_TimeInstant]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IComponents_ImageComponent'
ALTER TABLE [dbo].[IComponents_ImageComponent]
ADD CONSTRAINT [PK_IComponents_ImageComponent]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IComponents_GraphComponent'
ALTER TABLE [dbo].[IComponents_GraphComponent]
ADD CONSTRAINT [PK_IComponents_GraphComponent]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IComponents_VideoComponent'
ALTER TABLE [dbo].[IComponents_VideoComponent]
ADD CONSTRAINT [PK_IComponents_VideoComponent]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IComponents_TextComponent'
ALTER TABLE [dbo].[IComponents_TextComponent]
ADD CONSTRAINT [PK_IComponents_TextComponent]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IComponents_DocumentComponent'
ALTER TABLE [dbo].[IComponents_DocumentComponent]
ADD CONSTRAINT [PK_IComponents_DocumentComponent]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Organizations_Id], [Users_Id] in table 'OrganizationUser'
ALTER TABLE [dbo].[OrganizationUser]
ADD CONSTRAINT [PK_OrganizationUser]
    PRIMARY KEY NONCLUSTERED ([Organizations_Id], [Users_Id] ASC);
GO

-- Creating primary key on [Users_Id], [Roles_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [PK_UserRole]
    PRIMARY KEY NONCLUSTERED ([Users_Id], [Roles_Id] ASC);
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

-- Creating foreign key on [Id] in table 'Areas_Country'
ALTER TABLE [dbo].[Areas_Country]
ADD CONSTRAINT [FK_Country_inherits_Area]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'ITimes_TimeInterval'
ALTER TABLE [dbo].[ITimes_TimeInterval]
ADD CONSTRAINT [FK_TimeInterval_inherits_ITime]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[ITimes]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'ITimes_TimeInstant'
ALTER TABLE [dbo].[ITimes_TimeInstant]
ADD CONSTRAINT [FK_TimeInstant_inherits_ITime]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[ITimes]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'IComponents_ImageComponent'
ALTER TABLE [dbo].[IComponents_ImageComponent]
ADD CONSTRAINT [FK_ImageComponent_inherits_IComponent]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[IComponents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'IComponents_GraphComponent'
ALTER TABLE [dbo].[IComponents_GraphComponent]
ADD CONSTRAINT [FK_GraphComponent_inherits_IComponent]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[IComponents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'IComponents_VideoComponent'
ALTER TABLE [dbo].[IComponents_VideoComponent]
ADD CONSTRAINT [FK_VideoComponent_inherits_IComponent]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[IComponents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'IComponents_TextComponent'
ALTER TABLE [dbo].[IComponents_TextComponent]
ADD CONSTRAINT [FK_TextComponent_inherits_IComponent]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[IComponents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'IComponents_DocumentComponent'
ALTER TABLE [dbo].[IComponents_DocumentComponent]
ADD CONSTRAINT [FK_DocumentComponent_inherits_IComponent]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[IComponents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------