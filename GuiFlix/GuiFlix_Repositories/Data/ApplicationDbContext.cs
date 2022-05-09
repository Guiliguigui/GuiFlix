using GuiFlix_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
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
            modelBuilder.Entity<Question>().HasData(
                 new Question
                 {
                     Id = 1,
                     Title = "What is Guiflix ?",
                     Answer = "It's a Netflix-like streaming platform."
                 },
                 new Question
                 {
                     Id = 2,
                     Title = "How much does Guiflix cost ?",
                     Answer = "It cost nothing."
                 },
                 new Question
                 {
                     Id = 3,
                     Title = "Where can I watch ?",
                     Answer = "You have to register to watch anything."
                 },
                 new Question
                 {
                     Id = 4,
                     Title = "How do I cancel ?",
                     Answer = "You can delete your account at any moment in your account settings."
                 },
                 new Question
                 {
                     Id = 5,
                     Title = "What can I watch on Netflix ?",
                     Answer = "Principaly, you can watch Films and Tv Shows."
                 }
             );
            modelBuilder.Entity<Media>()
            .HasDiscriminator<string>(nameof(Media.Type))
            .HasValue<Film>(nameof(Film))
            .HasValue<TVShow>(nameof(TVShow));
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<MediaCrewMember> MediaCrewMembers { get; set; }
        public DbSet<TVShow> TVShows { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
