using Microsoft.EntityFrameworkCore;
using StudentGradeCsharp.Model;

namespace StudentGradeCsharp.Database
{
    public class ConnectionContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<SchoolTestModel> SchoolTests { get; set;}
        
        public DbSet<GradeModel> Grades { get; set; }
        // Construtor que recebe DbContextOptions
        public ConnectionContext(DbContextOptions<ConnectionContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GradeModel>().HasKey(g => new { g.IdStudents, g.IdSchoolTest });

            modelBuilder.Entity<GradeModel>().HasOne(g => g.Student).WithMany().HasForeignKey(g => g.IdStudents);
            
            modelBuilder.Entity<GradeModel>().HasOne(g => g.SchoolTest).WithMany().HasForeignKey(g => g.IdSchoolTest);
        }
    }
}