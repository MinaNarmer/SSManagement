using Microsoft.EntityFrameworkCore;
using SSManagment.Data.Entities;

namespace SSManagement.Data
{
    public class SSContext : DbContext
    {
        public SSContext()
        {
        }

        public SSContext(DbContextOptions<SSContext> option) : base(option)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Scholarship> Scholarships { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<StudentScholarship> StudentScholarships { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Scholarship>().ToTable("Scholarships");
            modelBuilder.Entity<College>().ToTable("Colleges");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<University>().ToTable("Universities");
            modelBuilder.Entity<StudentScholarship>().ToTable("StudentScholarships");


            modelBuilder.Entity<College>().HasOne(x => x.University).WithMany(x => x.Colleges).HasForeignKey(x => x.UniversityId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Student>().HasOne(x => x.College).WithMany(x => x.Students).HasForeignKey(x => x.CollegeId)
                .OnDelete(DeleteBehavior.Restrict);

        }
             protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=SSManagmentDB;Trusted_Connection=True;");
            }

        }
    
    }
}
