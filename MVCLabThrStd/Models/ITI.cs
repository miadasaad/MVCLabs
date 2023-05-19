using Microsoft.EntityFrameworkCore;

namespace MVCLabThrStd.Models
{
    public class ITI:DbContext
    {
        public ITI(DbContextOptions options) : base(options)
        {
        }
        public ITI()
        {

        }

        public virtual DbSet<StudentModel> Students { get; set; }
        public virtual DbSet<DepartmentModel> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MVC1;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
