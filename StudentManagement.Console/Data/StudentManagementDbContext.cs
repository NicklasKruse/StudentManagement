using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Console.Data
{
    public class StudentManagementDbContext : DbContext
    {
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Enrollment> Enrollments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RJFBEE0;Initial Catalog=StudentManagementDb;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
