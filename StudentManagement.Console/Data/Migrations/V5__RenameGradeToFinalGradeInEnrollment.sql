BEGIN TRANSACTION;
ALTER TABLE [Students] ADD [MiddleName] nvarchar(max) NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002154655_AddMiddleNameToStudent', N'9.0.9');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002161738_AddDateOfBirthToStudent', N'9.0.9');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002163653_AddInstructor', N'9.0.9');

EXEC sp_rename N'[Enrollments].[Grade]', N'FinalGrade', 'COLUMN';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002164201_RenamedGradeToFinalGradeInEnrollment', N'9.0.9');

COMMIT;
GO

