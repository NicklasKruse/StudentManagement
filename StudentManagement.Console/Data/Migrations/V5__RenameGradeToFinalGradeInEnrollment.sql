BEGIN TRANSACTION;
EXEC sp_rename N'[Enrollments].[Grade]', N'FinalGrade', 'COLUMN';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251002164201_RenamedGradeToFinalGradeInEnrollment', N'9.0.9');

COMMIT;
GO

