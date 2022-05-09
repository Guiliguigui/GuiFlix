﻿// <auto-generated />
using System;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuiFlix_Repositories.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220509120541_Question")]
    partial class Question
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryMedia", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("MediasId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "MediasId");

                    b.HasIndex("MediasId");

                    b.ToTable("CategoryMedia");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.CrewMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CrewMembers");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RealeaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Season")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TVShowId")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TVShowId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pegi")
                        .HasColumnType("int");

                    b.Property<DateTime>("RealeaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThumbnailLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medias");

                    b.HasDiscriminator<string>("Type").HasValue("Media");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.MediaCrewMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrewMemberId")
                        .HasColumnType("int");

                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CrewMemberId");

                    b.HasIndex("MediaId");

                    b.ToTable("MediaCrewMembers");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("AvatarLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "It's a Netflix-like streaming platform.",
                            Title = "What is Guiflix ?"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "It cost nothing.",
                            Title = "How much does Guiflix cost ?"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "You have to register to watch anything.",
                            Title = "Where can I watch ?"
                        },
                        new
                        {
                            Id = 4,
                            Answer = "You can delete your account at any moment in your account settings.",
                            Title = "How do I cancel ?"
                        },
                        new
                        {
                            Id = 5,
                            Answer = "Principaly, you can watch Films and Tv Shows.",
                            Title = "What can I watch on Netflix ?"
                        });
                });

            modelBuilder.Entity("ListMedia", b =>
                {
                    b.Property<int>("ListsId")
                        .HasColumnType("int");

                    b.Property<int>("MediasId")
                        .HasColumnType("int");

                    b.HasKey("ListsId", "MediasId");

                    b.HasIndex("MediasId");

                    b.ToTable("ListMedia");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Film", b =>
                {
                    b.HasBaseType("GuiFlix_Models.Models.Media");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("SourceLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.TVShow", b =>
                {
                    b.HasBaseType("GuiFlix_Models.Models.Media");

                    b.HasDiscriminator().HasValue("TVShow");
                });

            modelBuilder.Entity("CategoryMedia", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuiFlix_Models.Models.Media", null)
                        .WithMany()
                        .HasForeignKey("MediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Episode", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.TVShow", "TVShow")
                        .WithMany("Episodes")
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TVShow");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Like", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.Profile", "Profile")
                        .WithMany("Likes")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.List", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.Profile", "Profile")
                        .WithMany("Lists")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.MediaCrewMember", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.CrewMember", "CrewMember")
                        .WithMany("Medias")
                        .HasForeignKey("CrewMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuiFlix_Models.Models.Media", "Media")
                        .WithMany("CrewMembers")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CrewMember");

                    b.Navigation("Media");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Profile", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.Account", "Account")
                        .WithMany("Profiles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ListMedia", b =>
                {
                    b.HasOne("GuiFlix_Models.Models.List", null)
                        .WithMany()
                        .HasForeignKey("ListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuiFlix_Models.Models.Media", null)
                        .WithMany()
                        .HasForeignKey("MediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Account", b =>
                {
                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.CrewMember", b =>
                {
                    b.Navigation("Medias");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Media", b =>
                {
                    b.Navigation("CrewMembers");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Profile", b =>
                {
                    b.Navigation("Likes");

                    b.Navigation("Lists");
                });

            modelBuilder.Entity("GuiFlix_Models.Models.TVShow", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}
