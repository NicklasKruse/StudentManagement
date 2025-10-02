# Student Management Database Migrations

## Change-Based Migrations

### State based
- The entire model is represented in each migration
- Manual sql scripts defining complete desired state
- no deltas, each version is standalone. What rather than How.
# Branches
- initial-schema-state - Created the initial schema with Students, Courses, and Enrollments
- add-middlename-state - Added a MiddleName column to the Students table
- add-dateofbirth-state - Added a DateOfBirth column to the Students table
- add-instructor-state - Created an Instructors table
- rename-grade-state - Renamed the Grade column in the Enrollments table to FinalGrade
- add-department-state - Created a Departments table and added a DepartmentId foreign key to the Courses table
- modify-credits-type-state - Changed the Credits column in the Courses table from int to decimal
# Why use state-based migrations?
- Easier to understand the current state of the database at any point in time.
- Database-agnostic (pure sql)
- Tools can compare current to desired state

### Change based
- Incremental change based on prior deltas
- The migrations are generated from C# model changes
- If done correctly, each artifact contains only the specific change introduced.
# Branches
- initial-schema-ef - Created the initial schema with Students, Courses, and Enrollments tables.
- add-middlename-ef - Added a MiddleName column to the Students table.
- add-dateofbirth-ef - Added a DateOfBirth column to the Students table.
- add-instructor-ef - Created an Instructors table.
- rename-grade-ef - Renamed the Grade column in the Enrollments table to FinalGrade.
- add-department-ef - Created a Departments table and added a DepartmentId foreign key to the Courses table.
- modify-credits-type-ef - Changed the Credits column in the Courses table from int to decimal.
# Why use change-based migrations?
- Easier to track and understand changes over time.
- Good for agile and iterative development processes.
- Allows for more granular control over database schema evolution.


## issues?
- A few errors persist in the branches given mistakes made during migration-
- and wrongfully applying increments during the process. Fixed some of them, but not all.
- master is mostly correct, but you will notice fx. the AddInstructor have caused some issues.