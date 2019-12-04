
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/04/2019 11:35:13
-- Generated from EDMX file: D:\Repos\DotNet\CodeathonDesktop\DataModel\Codeathon.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Codeathon];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserProfile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_UserProfile];
GO
IF OBJECT_ID(N'[dbo].[FK_PLanguageChallengeResult]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChallengeResults] DROP CONSTRAINT [FK_PLanguageChallengeResult];
GO
IF OBJECT_ID(N'[dbo].[FK_UserChallengeResult]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChallengeResults] DROP CONSTRAINT [FK_UserChallengeResult];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_UserCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_RoleUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCompetition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Competitions] DROP CONSTRAINT [FK_UserCompetition];
GO
IF OBJECT_ID(N'[dbo].[FK_CompetitionCompetitionChallenge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetitionChallenges] DROP CONSTRAINT [FK_CompetitionCompetitionChallenge];
GO
IF OBJECT_ID(N'[dbo].[FK_CompetitionUser_Competition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetitionUser] DROP CONSTRAINT [FK_CompetitionUser_Competition];
GO
IF OBJECT_ID(N'[dbo].[FK_CompetitionUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetitionUser] DROP CONSTRAINT [FK_CompetitionUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserChallenge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Challenges] DROP CONSTRAINT [FK_UserChallenge];
GO
IF OBJECT_ID(N'[dbo].[FK_ChallengeChallengeResult]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChallengeResults] DROP CONSTRAINT [FK_ChallengeChallengeResult];
GO
IF OBJECT_ID(N'[dbo].[FK_ChallengeCompetitionChallenge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetitionChallenges] DROP CONSTRAINT [FK_ChallengeCompetitionChallenge];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryChallenge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Challenges] DROP CONSTRAINT [FK_CategoryChallenge];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Profiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profiles];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Challenges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Challenges];
GO
IF OBJECT_ID(N'[dbo].[TestCases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestCases];
GO
IF OBJECT_ID(N'[dbo].[ChallengeResults]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChallengeResults];
GO
IF OBJECT_ID(N'[dbo].[PLanguages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PLanguages];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Competitions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Competitions];
GO
IF OBJECT_ID(N'[dbo].[CompetitionChallenges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompetitionChallenges];
GO
IF OBJECT_ID(N'[dbo].[CompetitionUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompetitionUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UID] uniqueidentifier  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [HashPassword] nvarchar(max)  NOT NULL,
    [Profiles_Id] int  NOT NULL,
    [Role_Id] int  NOT NULL
);
GO

-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CoverImage] nvarchar(max)  NOT NULL,
    [User_UID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Challenges'
CREATE TABLE [dbo].[Challenges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [ShortDescription] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [LastUpdate] datetime  NOT NULL,
    [IsPublic] bit  NOT NULL,
    [Owner_UID] uniqueidentifier  NOT NULL,
    [Category_Id] int  NOT NULL
);
GO

-- Creating table 'TestCases'
CREATE TABLE [dbo].[TestCases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Input] nvarchar(max)  NOT NULL,
    [ExpectedOutput] nvarchar(max)  NOT NULL,
    [AllowView] bit  NOT NULL,
    [Timeout] int  NOT NULL
);
GO

-- Creating table 'ChallengeResults'
CREATE TABLE [dbo].[ChallengeResults] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SourceCode] nvarchar(max)  NOT NULL,
    [ExecuteTime] nvarchar(max)  NOT NULL,
    [PLanguage_Id] int  NOT NULL,
    [User_UID] uniqueidentifier  NOT NULL,
    [Challenge_Id] int  NOT NULL
);
GO

-- Creating table 'PLanguages'
CREATE TABLE [dbo].[PLanguages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Version] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Competitions'
CREATE TABLE [dbo].[Competitions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ShortDescription] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CoverImage] nvarchar(max)  NOT NULL,
    [MedalIcon] nvarchar(max)  NOT NULL,
    [ExpiredDate] datetime  NOT NULL,
    [DurationHours] int  NOT NULL,
    [LastUpdate] datetime  NOT NULL,
    [Owner_UID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'CompetitionChallenges'
CREATE TABLE [dbo].[CompetitionChallenges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Point] int  NOT NULL,
    [PrerequisiteId] int  NULL,
    [Competition_Id] int  NOT NULL,
    [Challenge_Id] int  NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [User_UID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'CompetitionUser'
CREATE TABLE [dbo].[CompetitionUser] (
    [EnrolledCompetitions_Id] int  NOT NULL,
    [InvitedUsers_UID] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UID] ASC);
GO

-- Creating primary key on [Id] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Challenges'
ALTER TABLE [dbo].[Challenges]
ADD CONSTRAINT [PK_Challenges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestCases'
ALTER TABLE [dbo].[TestCases]
ADD CONSTRAINT [PK_TestCases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ChallengeResults'
ALTER TABLE [dbo].[ChallengeResults]
ADD CONSTRAINT [PK_ChallengeResults]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PLanguages'
ALTER TABLE [dbo].[PLanguages]
ADD CONSTRAINT [PK_PLanguages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Competitions'
ALTER TABLE [dbo].[Competitions]
ADD CONSTRAINT [PK_Competitions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompetitionChallenges'
ALTER TABLE [dbo].[CompetitionChallenges]
ADD CONSTRAINT [PK_CompetitionChallenges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [EnrolledCompetitions_Id], [InvitedUsers_UID] in table 'CompetitionUser'
ALTER TABLE [dbo].[CompetitionUser]
ADD CONSTRAINT [PK_CompetitionUser]
    PRIMARY KEY CLUSTERED ([EnrolledCompetitions_Id], [InvitedUsers_UID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Profiles_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_UserProfile]
    FOREIGN KEY ([Profiles_Id])
    REFERENCES [dbo].[Profiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile'
CREATE INDEX [IX_FK_UserProfile]
ON [dbo].[Users]
    ([Profiles_Id]);
GO

-- Creating foreign key on [PLanguage_Id] in table 'ChallengeResults'
ALTER TABLE [dbo].[ChallengeResults]
ADD CONSTRAINT [FK_PLanguageChallengeResult]
    FOREIGN KEY ([PLanguage_Id])
    REFERENCES [dbo].[PLanguages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PLanguageChallengeResult'
CREATE INDEX [IX_FK_PLanguageChallengeResult]
ON [dbo].[ChallengeResults]
    ([PLanguage_Id]);
GO

-- Creating foreign key on [User_UID] in table 'ChallengeResults'
ALTER TABLE [dbo].[ChallengeResults]
ADD CONSTRAINT [FK_UserChallengeResult]
    FOREIGN KEY ([User_UID])
    REFERENCES [dbo].[Users]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserChallengeResult'
CREATE INDEX [IX_FK_UserChallengeResult]
ON [dbo].[ChallengeResults]
    ([User_UID]);
GO

-- Creating foreign key on [User_UID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_UserCategory]
    FOREIGN KEY ([User_UID])
    REFERENCES [dbo].[Users]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCategory'
CREATE INDEX [IX_FK_UserCategory]
ON [dbo].[Categories]
    ([User_UID]);
GO

-- Creating foreign key on [Role_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_RoleUser]
    FOREIGN KEY ([Role_Id])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUser'
CREATE INDEX [IX_FK_RoleUser]
ON [dbo].[Users]
    ([Role_Id]);
GO

-- Creating foreign key on [Owner_UID] in table 'Competitions'
ALTER TABLE [dbo].[Competitions]
ADD CONSTRAINT [FK_UserCompetition]
    FOREIGN KEY ([Owner_UID])
    REFERENCES [dbo].[Users]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCompetition'
CREATE INDEX [IX_FK_UserCompetition]
ON [dbo].[Competitions]
    ([Owner_UID]);
GO

-- Creating foreign key on [Competition_Id] in table 'CompetitionChallenges'
ALTER TABLE [dbo].[CompetitionChallenges]
ADD CONSTRAINT [FK_CompetitionCompetitionChallenge]
    FOREIGN KEY ([Competition_Id])
    REFERENCES [dbo].[Competitions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompetitionCompetitionChallenge'
CREATE INDEX [IX_FK_CompetitionCompetitionChallenge]
ON [dbo].[CompetitionChallenges]
    ([Competition_Id]);
GO

-- Creating foreign key on [EnrolledCompetitions_Id] in table 'CompetitionUser'
ALTER TABLE [dbo].[CompetitionUser]
ADD CONSTRAINT [FK_CompetitionUser_Competition]
    FOREIGN KEY ([EnrolledCompetitions_Id])
    REFERENCES [dbo].[Competitions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [InvitedUsers_UID] in table 'CompetitionUser'
ALTER TABLE [dbo].[CompetitionUser]
ADD CONSTRAINT [FK_CompetitionUser_User]
    FOREIGN KEY ([InvitedUsers_UID])
    REFERENCES [dbo].[Users]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompetitionUser_User'
CREATE INDEX [IX_FK_CompetitionUser_User]
ON [dbo].[CompetitionUser]
    ([InvitedUsers_UID]);
GO

-- Creating foreign key on [Owner_UID] in table 'Challenges'
ALTER TABLE [dbo].[Challenges]
ADD CONSTRAINT [FK_UserChallenge]
    FOREIGN KEY ([Owner_UID])
    REFERENCES [dbo].[Users]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserChallenge'
CREATE INDEX [IX_FK_UserChallenge]
ON [dbo].[Challenges]
    ([Owner_UID]);
GO

-- Creating foreign key on [Challenge_Id] in table 'ChallengeResults'
ALTER TABLE [dbo].[ChallengeResults]
ADD CONSTRAINT [FK_ChallengeChallengeResult]
    FOREIGN KEY ([Challenge_Id])
    REFERENCES [dbo].[Challenges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChallengeChallengeResult'
CREATE INDEX [IX_FK_ChallengeChallengeResult]
ON [dbo].[ChallengeResults]
    ([Challenge_Id]);
GO

-- Creating foreign key on [Challenge_Id] in table 'CompetitionChallenges'
ALTER TABLE [dbo].[CompetitionChallenges]
ADD CONSTRAINT [FK_ChallengeCompetitionChallenge]
    FOREIGN KEY ([Challenge_Id])
    REFERENCES [dbo].[Challenges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChallengeCompetitionChallenge'
CREATE INDEX [IX_FK_ChallengeCompetitionChallenge]
ON [dbo].[CompetitionChallenges]
    ([Challenge_Id]);
GO

-- Creating foreign key on [Category_Id] in table 'Challenges'
ALTER TABLE [dbo].[Challenges]
ADD CONSTRAINT [FK_CategoryChallenge]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryChallenge'
CREATE INDEX [IX_FK_CategoryChallenge]
ON [dbo].[Challenges]
    ([Category_Id]);
GO

-- Creating foreign key on [User_UID] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [FK_UserLog]
    FOREIGN KEY ([User_UID])
    REFERENCES [dbo].[Users]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLog'
CREATE INDEX [IX_FK_UserLog]
ON [dbo].[Logs]
    ([User_UID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------