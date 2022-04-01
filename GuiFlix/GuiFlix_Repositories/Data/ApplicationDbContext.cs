using GuiFlix_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\GuiFlixDB;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                 new Admin
                 {
                     Id = 1,
                     UserName = "admin",
                     Password = "admin"
                 }
             );
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}
