BEGIN TRANSACTION;
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002202052_ModifyCreditsDataType', N'9.0.9');

COMMIT;
GO

