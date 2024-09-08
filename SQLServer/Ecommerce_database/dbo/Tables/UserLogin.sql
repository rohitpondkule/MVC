CREATE TABLE [dbo].[UserLogin] (
    [UserId]        INT          IDENTITY (1, 1) NOT NULL,
    [UserName]      VARCHAR (20) NULL,
    [Password]      VARCHAR (20) NULL,
    [CreatedDate]   DATETIME     NULL,
    [ModifiedDate]  DATETIME     NULL,
    [LastLoginDate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

