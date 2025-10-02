BEGIN TRANSACTION;
ALTER TABLE [Students] ADD [MiddleName] nvarchar(max) NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002154655_AddMiddleNameToStudent', N'9.0.9');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002161738_AddDateOfBirthToStudent', N'9.0.9');

COMMIT;
GO

