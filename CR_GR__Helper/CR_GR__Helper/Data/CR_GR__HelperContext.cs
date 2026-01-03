using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CR_GR__Helper.Models;

namespace CR_GR__Helper.Data
{
    public class CR_GR__HelperContext : DbContext
    {
        public CR_GR__HelperContext(DbContextOptions<CR_GR__HelperContext> options)
            : base(options)
        {
        }

        public DbSet<CR_GR__Helper.Models.Student> Student { get; set; } = default!;
        public DbSet<CR_GR__Helper.Models.Teacher> Teacher { get; set; } = default!;
        //public DbSet<CR_GR__Helper.Models.Class> Class { get; set; } = default!;
        public DbSet<CR_GR__Helper.Models.Classes> Classes { get; set; } = default!;
        public DbSet<CR_GR__Helper.Models.Subject> Subject { get; set; } = default!;
        public DbSet<CR_GR__Helper.Models.CR_GR> CR_GR { get; set; } = default!;
        public DbSet<CR_GR__Helper.Models.Attendance> Attendance { get; set; } = default!;
        public DbSet<CR_GR__Helper.Models.Complain> Complain { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fix CGPA precision
            modelBuilder.Entity<Student>()
                .Property(s => s.CGPA)
                .HasColumnType("decimal(3,2)");

        }
        public DbSet<CR_GR__Helper.Models.Alert> Alert { get; set; } = default!;
    }
}
