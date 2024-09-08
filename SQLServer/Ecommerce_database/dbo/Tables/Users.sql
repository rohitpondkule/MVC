CREATE TABLE [dbo].[Users] (
    [UserId]     INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (20)  NULL,
    [MiddleName] VARCHAR (20)  NULL,
    [LastName]   VARCHAR (20)  NULL,
    [DOB]        VARCHAR (10)  NULL,
    [MobileNo]   INT           NULL,
    [Email]      VARCHAR (50)  NULL,
    [Address]    VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

