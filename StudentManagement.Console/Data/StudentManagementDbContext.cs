using Microsoft.EntityFrameworkCore;
using StudentManagement.Console.Models;

namespace StudentManagement.Console.Data
{
    public class StudentManagementDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RJFBEE0;Initial Catalog=StudentManagementDb;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasOne<Instructor>()
                .WithMany()
                .HasForeignKey(d => d.DepartmentHeadId);
        }
    }
}
