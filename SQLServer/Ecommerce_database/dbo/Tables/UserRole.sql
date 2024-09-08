CREATE TABLE [dbo].[UserRole] (
    [UserRoleId]   INT      NOT NULL,
    [UserId]       INT      NOT NULL,
    [RoleId]       INT      NOT NULL,
    [CreateDate]   DATETIME DEFAULT (getdate()) NOT NULL,
    [ModifiedDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([UserRoleId] ASC),
    CONSTRAINT [FK_UserRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId]),
    CONSTRAINT [FK_UserRole_UserLogin] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

