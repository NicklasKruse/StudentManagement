# Student Management Database Migrations

## Change-Based Migrations

### Modify Credits Data Type (V7)
- Changed Credits from int to decimal(5,2)
- Non-destructive migration because int to decimal is safe. Would've been destructive if going from decimal to int becuase of loss of precision.
- Generated migration artifact: `Data/Migrations/V7__ModifyCreditsDataType.sql`
- Branch: `/modify-credits-type-ef`

## 
- A few errors persist in the branches given mistakes made during migration-
- and wrongfully applying increments during the process. Fixed some of them, but not all.
- master is mostly correct, but you will notice fx. the AddInstructor have caused some issues.