
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/26/2024 12:48:46
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Krankenkasse] nvarchar(max)  NOT NULL,
    [Admin] bit  NOT NULL,
    [Arzt] bit  NOT NULL
);
GO

-- Creating table 'BehandlungSet'
CREATE TABLE [dbo].[BehandlungSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Behandlungsart] nvarchar(max)  NOT NULL,
    [Dauer] smallint  NOT NULL,
    [behandelnderArzt] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TerminSet'
CREATE TABLE [dbo].[TerminSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [angefragt] bit  NOT NULL,
    [bestätigt] bit  NOT NULL,
    [abgesagt] bit  NOT NULL,
    [abgeschlossen] bit  NOT NULL,
    [verfügbarerArzt] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ArztBehandlung'
CREATE TABLE [dbo].[ArztBehandlung] (
    [wirdangeboten_Id] int  NOT NULL,
    [bietetan_Id] int  NOT NULL
);
GO

-- Creating table 'ArztTermin'
CREATE TABLE [dbo].[ArztTermin] (
    [mitArztverfügbar_Id] int  NOT NULL,
    [freizu_Id] int  NOT NULL
);
GO

-- Creating table 'UserTerminBestätigung'
CREATE TABLE [dbo].[UserTerminBestätigung] (
    [wirdbestätigt_Id] int  NOT NULL,
    [bestätigt_Id] int  NOT NULL
);
GO

-- Creating table 'UserBehandlung'
CREATE TABLE [dbo].[UserBehandlung] (
    [wirdgewählt_Id] int  NOT NULL,
    [wähltBehandlung_Id] int  NOT NULL
);
GO

-- Creating table 'UserTermin'
CREATE TABLE [dbo].[UserTermin] (
    [wirdgewählt_Id] int  NOT NULL,
    [wähltTermin_Id] int  NOT NULL
);
GO

-- Creating table 'UserTermin1'
CREATE TABLE [dbo].[UserTermin1] (
    [CUD_T_Id] int  NOT NULL,
    [CUDT_Id] int  NOT NULL
);
GO

-- Creating table 'UserBehandlung1'
CREATE TABLE [dbo].[UserBehandlung1] (
    [CUD_B_Id] int  NOT NULL,
    [CUDB_Id] int  NOT NULL
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

-- Creating primary key on [wirdangeboten_Id], [bietetan_Id] in table 'ArztBehandlung'
ALTER TABLE [dbo].[ArztBehandlung]
ADD CONSTRAINT [PK_ArztBehandlung]
    PRIMARY KEY CLUSTERED ([wirdangeboten_Id], [bietetan_Id] ASC);
GO

-- Creating primary key on [mitArztverfügbar_Id], [freizu_Id] in table 'ArztTermin'
ALTER TABLE [dbo].[ArztTermin]
ADD CONSTRAINT [PK_ArztTermin]
    PRIMARY KEY CLUSTERED ([mitArztverfügbar_Id], [freizu_Id] ASC);
GO

-- Creating primary key on [wirdbestätigt_Id], [bestätigt_Id] in table 'UserTerminBestätigung'
ALTER TABLE [dbo].[UserTerminBestätigung]
ADD CONSTRAINT [PK_UserTerminBestätigung]
    PRIMARY KEY CLUSTERED ([wirdbestätigt_Id], [bestätigt_Id] ASC);
GO

-- Creating primary key on [wirdgewählt_Id], [wähltBehandlung_Id] in table 'UserBehandlung'
ALTER TABLE [dbo].[UserBehandlung]
ADD CONSTRAINT [PK_UserBehandlung]
    PRIMARY KEY CLUSTERED ([wirdgewählt_Id], [wähltBehandlung_Id] ASC);
GO

-- Creating primary key on [wirdgewählt_Id], [wähltTermin_Id] in table 'UserTermin'
ALTER TABLE [dbo].[UserTermin]
ADD CONSTRAINT [PK_UserTermin]
    PRIMARY KEY CLUSTERED ([wirdgewählt_Id], [wähltTermin_Id] ASC);
GO

-- Creating primary key on [CUD_T_Id], [CUDT_Id] in table 'UserTermin1'
ALTER TABLE [dbo].[UserTermin1]
ADD CONSTRAINT [PK_UserTermin1]
    PRIMARY KEY CLUSTERED ([CUD_T_Id], [CUDT_Id] ASC);
GO

-- Creating primary key on [CUD_B_Id], [CUDB_Id] in table 'UserBehandlung1'
ALTER TABLE [dbo].[UserBehandlung1]
ADD CONSTRAINT [PK_UserBehandlung1]
    PRIMARY KEY CLUSTERED ([CUD_B_Id], [CUDB_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [wirdangeboten_Id] in table 'ArztBehandlung'
ALTER TABLE [dbo].[ArztBehandlung]
ADD CONSTRAINT [FK_ArztBehandlung_User]
    FOREIGN KEY ([wirdangeboten_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [bietetan_Id] in table 'ArztBehandlung'
ALTER TABLE [dbo].[ArztBehandlung]
ADD CONSTRAINT [FK_ArztBehandlung_Behandlung]
    FOREIGN KEY ([bietetan_Id])
    REFERENCES [dbo].[BehandlungSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArztBehandlung_Behandlung'
CREATE INDEX [IX_FK_ArztBehandlung_Behandlung]
ON [dbo].[ArztBehandlung]
    ([bietetan_Id]);
GO

-- Creating foreign key on [mitArztverfügbar_Id] in table 'ArztTermin'
ALTER TABLE [dbo].[ArztTermin]
ADD CONSTRAINT [FK_ArztTermin_User]
    FOREIGN KEY ([mitArztverfügbar_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [freizu_Id] in table 'ArztTermin'
ALTER TABLE [dbo].[ArztTermin]
ADD CONSTRAINT [FK_ArztTermin_Termin]
    FOREIGN KEY ([freizu_Id])
    REFERENCES [dbo].[TerminSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArztTermin_Termin'
CREATE INDEX [IX_FK_ArztTermin_Termin]
ON [dbo].[ArztTermin]
    ([freizu_Id]);
GO

-- Creating foreign key on [wirdbestätigt_Id] in table 'UserTerminBestätigung'
ALTER TABLE [dbo].[UserTerminBestätigung]
ADD CONSTRAINT [FK_UserTerminBestätigung_User]
    FOREIGN KEY ([wirdbestätigt_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [bestätigt_Id] in table 'UserTerminBestätigung'
ALTER TABLE [dbo].[UserTerminBestätigung]
ADD CONSTRAINT [FK_UserTerminBestätigung_Termin]
    FOREIGN KEY ([bestätigt_Id])
    REFERENCES [dbo].[TerminSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTerminBestätigung_Termin'
CREATE INDEX [IX_FK_UserTerminBestätigung_Termin]
ON [dbo].[UserTerminBestätigung]
    ([bestätigt_Id]);
GO

-- Creating foreign key on [wirdgewählt_Id] in table 'UserBehandlung'
ALTER TABLE [dbo].[UserBehandlung]
ADD CONSTRAINT [FK_UserBehandlung_User]
    FOREIGN KEY ([wirdgewählt_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [wähltBehandlung_Id] in table 'UserBehandlung'
ALTER TABLE [dbo].[UserBehandlung]
ADD CONSTRAINT [FK_UserBehandlung_Behandlung]
    FOREIGN KEY ([wähltBehandlung_Id])
    REFERENCES [dbo].[BehandlungSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBehandlung_Behandlung'
CREATE INDEX [IX_FK_UserBehandlung_Behandlung]
ON [dbo].[UserBehandlung]
    ([wähltBehandlung_Id]);
GO

-- Creating foreign key on [wirdgewählt_Id] in table 'UserTermin'
ALTER TABLE [dbo].[UserTermin]
ADD CONSTRAINT [FK_UserTermin_User]
    FOREIGN KEY ([wirdgewählt_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [wähltTermin_Id] in table 'UserTermin'
ALTER TABLE [dbo].[UserTermin]
ADD CONSTRAINT [FK_UserTermin_Termin]
    FOREIGN KEY ([wähltTermin_Id])
    REFERENCES [dbo].[TerminSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTermin_Termin'
CREATE INDEX [IX_FK_UserTermin_Termin]
ON [dbo].[UserTermin]
    ([wähltTermin_Id]);
GO

-- Creating foreign key on [CUD_T_Id] in table 'UserTermin1'
ALTER TABLE [dbo].[UserTermin1]
ADD CONSTRAINT [FK_UserTermin1_User]
    FOREIGN KEY ([CUD_T_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CUDT_Id] in table 'UserTermin1'
ALTER TABLE [dbo].[UserTermin1]
ADD CONSTRAINT [FK_UserTermin1_Termin]
    FOREIGN KEY ([CUDT_Id])
    REFERENCES [dbo].[TerminSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTermin1_Termin'
CREATE INDEX [IX_FK_UserTermin1_Termin]
ON [dbo].[UserTermin1]
    ([CUDT_Id]);
GO

-- Creating foreign key on [CUD_B_Id] in table 'UserBehandlung1'
ALTER TABLE [dbo].[UserBehandlung1]
ADD CONSTRAINT [FK_UserBehandlung1_User]
    FOREIGN KEY ([CUD_B_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CUDB_Id] in table 'UserBehandlung1'
ALTER TABLE [dbo].[UserBehandlung1]
ADD CONSTRAINT [FK_UserBehandlung1_Behandlung]
    FOREIGN KEY ([CUDB_Id])
    REFERENCES [dbo].[BehandlungSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBehandlung1_Behandlung'
CREATE INDEX [IX_FK_UserBehandlung1_Behandlung]
ON [dbo].[UserBehandlung1]
    ([CUDB_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------