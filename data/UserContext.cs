using Microsoft.EntityFrameworkCore;
using ProjectForYp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForYp2.data
{
    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Requests> Requests { get; set; } = null!;
        public DbSet<OrgTechType> OrgTechType { get; set; } = null!;
        public DbSet<Types> Types { get; set; } = null!;
        public DbSet<Statys> Statys { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ZEROYZ; Initial Catalog=YP2; TrustServerCertificate = true; Integrated Security = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Requests>().HasKey(x => x.Id);

        }
    }
}
