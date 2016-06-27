using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StudentApp.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StudentApp.DAL
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection")
        {

        }

        public  DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
