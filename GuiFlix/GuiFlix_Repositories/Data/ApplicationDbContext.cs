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
            var initialData = new InitialData("2eec6f24-2040-43a1-a5f4-5a7301da7314");
            // If you change the secret key here, don't forget to put the same in GuiFlix_API/appsettings.json
            modelBuilder.Entity<Admin>().HasData(initialData.Admins);
            modelBuilder.Entity<Question>().HasData(initialData.Questions);
            modelBuilder.Entity<Account>().HasData(initialData.Accounts);
            modelBuilder.Entity<Profile>().HasData(initialData.Profiles);
            modelBuilder.Entity<Film>().HasData(initialData.Films);
            modelBuilder.Entity<TVShow>().HasData(initialData.TVShows);
            modelBuilder.Entity<Episode>().HasData(initialData.Episodes);
            modelBuilder.Entity<Category>().HasData(initialData.Categories);
            modelBuilder.Entity<Category>().HasMany(c => c.Medias).WithMany(m => m.Categories).UsingEntity(cm=>cm.ToTable("CategoryMedia").HasData(initialData.CategoryMedia));
            modelBuilder.Entity<CrewMember>().HasData(initialData.CrewMembers);
            modelBuilder.Entity<MediaCrewMember>().HasData(initialData.MediaCrewMember);
            modelBuilder.Entity<List>().HasData(initialData.Lists);
            modelBuilder.Entity<List>().HasMany(c => c.Medias).WithMany(m => m.Lists).UsingEntity(lm => lm.ToTable("ListMedia").HasData(initialData.ListMedia));
            modelBuilder.Entity<Like>().HasData(initialData.Likes);

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
