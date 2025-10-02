# Student Management Database Migrations

## Change-Based Migrations

### Rename Grade to FinalGrade in Enrollment (V5)
- Renamed Grade to FinalGrade in Enrollment
- This is a non-destructive change. EF uses `sp_rename` to rename the column, which preserves existing data.
- Generated migration artifact: `Data/Migrations/V5__RenameGradeToFinalGradeInEnrollment.sql`
- Branch: `/rename-grade-ef`