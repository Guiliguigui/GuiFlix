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
            modelBuilder.Entity<Admin>().HasData(InitialData.Admins);
            modelBuilder.Entity<Question>().HasData(InitialData.Questions);
            modelBuilder.Entity<Account>().HasData(InitialData.Accounts);
            modelBuilder.Entity<Profile>().HasData(InitialData.Profiles);
            modelBuilder.Entity<Film>().HasData(InitialData.Films);
            modelBuilder.Entity<TVShow>().HasData(InitialData.TVShows);
            modelBuilder.Entity<Episode>().HasData(InitialData.Episodes);
            modelBuilder.Entity<Category>().HasData(InitialData.Categories);
            modelBuilder.Entity<Category>().HasMany(c => c.Medias).WithMany(m => m.Categories).UsingEntity(cm=>cm.ToTable("CategoryMedia").HasData(InitialData.CategoryMedia));
            modelBuilder.Entity<CrewMember>().HasData(InitialData.CrewMembers);
            modelBuilder.Entity<MediaCrewMember>().HasData(InitialData.MediaCrewMember);
            modelBuilder.Entity<List>().HasData(InitialData.Lists);
            modelBuilder.Entity<List>().HasMany(c => c.Medias).WithMany(m => m.Lists).UsingEntity(cm => cm.ToTable("ListMedia").HasData(InitialData.ListMedia));
            modelBuilder.Entity<Like>().HasData(InitialData.Likes);

            modelBuilder.Entity<Like>().HasAlternateKey("ProfileId", "MediaId");

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
