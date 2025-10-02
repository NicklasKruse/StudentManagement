# Student Management Database Migrations

## Change-Based Migrations

### Modify Credits Data Type (V7)
- Changed Credits from int to decimal(5,2)
- Non-destructive migration because int to decimal is safe. Would've been destructive if going from decimal to int becuase of loss of precision.
- Generated migration artifact: `Data/Migrations/V7__ModifyCreditsDataType.sql`
- Branch: `/modify-credits-type-ef`