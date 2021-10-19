using CodingChallenge.SeniorDev.V1.Common.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.DataAccess.EF
{
    public class CodingChallengeDataContext : DbContext
    {
        public CodingChallengeDataContext(DbContextOptions options) : base(options)
        { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        public Task<List<Course>> GetAllCourses()
            => Courses.Where(c => !c.IsDeleted).OrderBy(c => c.Title).AsNoTracking().ToListAsync();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>()
                .HasKey(x => x.ID);

            builder.Entity<Course>()
                .HasKey(x => x.ID);

            builder.Entity<Teacher>()
                .HasKey(x => x.ID);

            builder.Entity<Subject>()
                .HasKey(x=> x.ID);

            builder.Entity<StudentCourse>()
                .HasKey(x => x.ID);
        }
    }
}
