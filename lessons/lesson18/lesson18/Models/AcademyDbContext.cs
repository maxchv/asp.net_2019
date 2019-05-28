using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using lesson18.Models;

namespace lesson18.Models
{
    public class AcademyDbContext : DbContext
    {
        private IConfiguration Configuration { get; }

        private static bool _init;

        public AcademyDbContext(IConfiguration conf)
        {
            Configuration = conf;
            _init = (!_init) ? Database.EnsureCreated() : true;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("academy");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                    new Student { Id = 1, Name = "Вася", Age = 19 },
                    new Student { Id = 2, Name = "Маша", Age = 21 }
            );
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "C++" },
                new Subject { Id = 2, Name = "C#" },
                new Subject { Id = 3, Name = "Java" },
                new Subject { Id = 4, Name = "PHP" }
            );

            modelBuilder.Entity<SubjectMarks>().HasData(
                new SubjectMarks { Id = 1, StudentId = 1, SubjectId = 1, Mark = 10},
                new SubjectMarks { Id = 2, StudentId = 1, SubjectId = 2, Mark = 11 },
                new SubjectMarks { Id = 3, StudentId = 1, SubjectId = 3, Mark = 9 },
                new SubjectMarks { Id = 4, StudentId = 1, SubjectId = 4, Mark = 10 }
            );
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectMarks> SubjectMarks { get; set; }
    }
}
