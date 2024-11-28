
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/28/2024 17:53:56
-- Generated from EDMX file: C:\Users\marco_p\source\repos\Terminvereinbarung\TerminvereinbarungLib\TerminvereinbarungModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Terminvereinbarung];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Arzt_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Arzt] DROP CONSTRAINT [FK_Arzt_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Arzt_Behandlung]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Arzt] DROP CONSTRAINT [FK_Arzt_Behandlung];
GO
IF OBJECT_ID(N'[dbo].[FK_ArztTermin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TerminSet] DROP CONSTRAINT [FK_ArztTermin];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientTermin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TerminSet] DROP CONSTRAINT [FK_PatientTermin];
GO
IF OBJECT_ID(N'[dbo].[FK_BehandlungTermin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TerminSet] DROP CONSTRAINT [FK_BehandlungTermin];
GO
IF OBJECT_ID(N'[dbo].[FK_TerminZeitslot]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TerminSet] DROP CONSTRAINT [FK_TerminZeitslot];
GO
IF OBJECT_ID(N'[dbo].[FK_ArztZeitslot_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArztZeitslot] DROP CONSTRAINT [FK_ArztZeitslot_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ArztZeitslot_Zeitslot]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArztZeitslot] DROP CONSTRAINT [FK_ArztZeitslot_Zeitslot];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[BehandlungSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BehandlungSet];
GO
IF OBJECT_ID(N'[dbo].[TerminSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TerminSet];
GO
IF OBJECT_ID(N'[dbo].[ZeitslotSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZeitslotSet];
GO
IF OBJECT_ID(N'[dbo].[Arzt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Arzt];
GO
IF OBJECT_ID(N'[dbo].[ArztZeitslot]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArztZeitslot];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Vorname] nvarchar(max)  NOT NULL,
    [Nachname] nvarchar(max)  NOT NULL,
    [Geburtsdatum] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [EMail] nvarchar(max)  NOT NULL,
    [Krankenkasse] nvarchar(max)  NULL,
    [Arzt] bit  NOT NULL,
    [Admin] bit  NOT NULL,
    [Passwort] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BehandlungSet'
CREATE TABLE [dbo].[BehandlungSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Behandlungart] nvarchar(max)  NOT NULL,
    [Behandlungsdauer] time  NOT NULL
);
GO

-- Creating table 'TerminSet'
CREATE TABLE [dbo].[TerminSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ArztId] int  NOT NULL,
    [PatientId] int  NOT NULL,
    [angefragt] bit  NOT NULL,
    [bestätigt] bit  NOT NULL,
    [abgeschlossen] bit  NOT NULL,
    [BehandlungId] int  NOT NULL,
    [ZeitslotId] int  NOT NULL
);
GO

-- Creating table 'ZeitslotSet'
CREATE TABLE [dbo].[ZeitslotSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Startzeitpunkt] datetime  NOT NULL,
    [Dauer] time  NOT NULL
);
GO

-- Creating table 'Arzt'
CREATE TABLE [dbo].[Arzt] (
    [qualifizierteÄrzte_Id] int  NOT NULL,
    [Behandlungungen_Id] int  NOT NULL
);
GO

-- Creating table 'ArztZeitslot'
CREATE TABLE [dbo].[ArztZeitslot] (
    [verfügbareÄrzte_Id] int  NOT NULL,
    [ZeitslotArzt_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BehandlungSet'
ALTER TABLE [dbo].[BehandlungSet]
ADD CONSTRAINT [PK_BehandlungSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TerminSet'
ALTER TABLE [dbo].[TerminSet]
ADD CONSTRAINT [PK_TerminSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ZeitslotSet'
ALTER TABLE [dbo].[ZeitslotSet]
ADD CONSTRAINT [PK_ZeitslotSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [qualifizierteÄrzte_Id], [Behandlungungen_Id] in table 'Arzt'
ALTER TABLE [dbo].[Arzt]
ADD CONSTRAINT [PK_Arzt]
    PRIMARY KEY CLUSTERED ([qualifizierteÄrzte_Id], [Behandlungungen_Id] ASC);
GO

-- Creating primary key on [verfügbareÄrzte_Id], [ZeitslotArzt_Id] in table 'ArztZeitslot'
ALTER TABLE [dbo].[ArztZeitslot]
ADD CONSTRAINT [PK_ArztZeitslot]
    PRIMARY KEY CLUSTERED ([verfügbareÄrzte_Id], [ZeitslotArzt_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [qualifizierteÄrzte_Id] in table 'Arzt'
ALTER TABLE [dbo].[Arzt]
ADD CONSTRAINT [FK_Arzt_User]
    FOREIGN KEY ([qualifizierteÄrzte_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Behandlungungen_Id] in table 'Arzt'
ALTER TABLE [dbo].[Arzt]
ADD CONSTRAINT [FK_Arzt_Behandlung]
    FOREIGN KEY ([Behandlungungen_Id])
    REFERENCES [dbo].[BehandlungSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Arzt_Behandlung'
CREATE INDEX [IX_FK_Arzt_Behandlung]
ON [dbo].[Arzt]
    ([Behandlungungen_Id]);
GO

-- Creating foreign key on [ArztId] in table 'TerminSet'
ALTER TABLE [dbo].[TerminSet]
ADD CONSTRAINT [FK_ArztTermin]
    FOREIGN KEY ([ArztId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArztTermin'
CREATE INDEX [IX_FK_ArztTermin]
ON [dbo].[TerminSet]
    ([ArztId]);
GO

-- Creating foreign key on [PatientId] in table 'TerminSet'
ALTER TABLE [dbo].[TerminSet]
ADD CONSTRAINT [FK_PatientTermin]
    FOREIGN KEY ([PatientId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientTermin'
CREATE INDEX [IX_FK_PatientTermin]
ON [dbo].[TerminSet]
    ([PatientId]);
GO

-- Creating foreign key on [BehandlungId] in table 'TerminSet'
ALTER TABLE [dbo].[TerminSet]
ADD CONSTRAINT [FK_BehandlungTermin]
    FOREIGN KEY ([BehandlungId])
    REFERENCES [dbo].[BehandlungSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BehandlungTermin'
CREATE INDEX [IX_FK_BehandlungTermin]
ON [dbo].[TerminSet]
    ([BehandlungId]);
GO

-- Creating foreign key on [ZeitslotId] in table 'TerminSet'
ALTER TABLE [dbo].[TerminSet]
ADD CONSTRAINT [FK_TerminZeitslot]
    FOREIGN KEY ([ZeitslotId])
    REFERENCES [dbo].[ZeitslotSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TerminZeitslot'
CREATE INDEX [IX_FK_TerminZeitslot]
ON [dbo].[TerminSet]
    ([ZeitslotId]);
GO

-- Creating foreign key on [verfügbareÄrzte_Id] in table 'ArztZeitslot'
ALTER TABLE [dbo].[ArztZeitslot]
ADD CONSTRAINT [FK_ArztZeitslot_User]
    FOREIGN KEY ([verfügbareÄrzte_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ZeitslotArzt_Id] in table 'ArztZeitslot'
ALTER TABLE [dbo].[ArztZeitslot]
ADD CONSTRAINT [FK_ArztZeitslot_Zeitslot]
    FOREIGN KEY ([ZeitslotArzt_Id])
    REFERENCES [dbo].[ZeitslotSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArztZeitslot_Zeitslot'
CREATE INDEX [IX_FK_ArztZeitslot_Zeitslot]
ON [dbo].[ArztZeitslot]
    ([ZeitslotArzt_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------