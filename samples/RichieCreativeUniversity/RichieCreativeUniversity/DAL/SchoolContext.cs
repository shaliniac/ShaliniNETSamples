using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using RichieCreativeUniversity.Models;


namespace RichieCreativeUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}                                             
