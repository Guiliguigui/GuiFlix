﻿// <auto-generated />
using System;
using GuiFlix_Repositories.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuiFlix_Repositories.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            MediasId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            MediasId = 2
                        },
                        new
                        {
                            CategoriesId = 2,
                            MediasId = 1
                        },
                        new
                        {
                            CategoriesId = 2,
                            MediasId = 2
                        });
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

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "guillaume@exemlpe.com",
                            FirstName = "Guillaume",
                            IsBanned = false,
                            LastName = "Mairesse",
                            Password = "UEFzczAwKysyZWVjNmYyNC0yMDQwLTQzYTEtYTVmNC01YTczMDFkYTczMTQ=",
                            Phone = "0607080910"
                        });
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
                            Password = "YWRtaW4yZWVjNmYyNC0yMDQwLTQzYTEtYTVmNC01YTczMDFkYTczMTQ=",
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kids"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Action"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Sacha",
                            LastName = "Goedegebure"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Duration = new TimeSpan(0, 0, 10, 35, 0),
                            EpisodeNumber = 1,
                            Name = "Big Buck Bunny p1e1",
                            RealeaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Season = "Part 1",
                            SourceLink = "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm",
                            TVShowId = 2,
                            ThumbnailLink = "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Duration = new TimeSpan(0, 0, 10, 35, 0),
                            EpisodeNumber = 1,
                            Name = "Big Buck Bunny p1e2",
                            RealeaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Season = "Part 1",
                            SourceLink = "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm",
                            TVShowId = 2,
                            ThumbnailLink = "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Duration = new TimeSpan(0, 0, 10, 35, 0),
                            EpisodeNumber = 1,
                            Name = "Big Buck Bunny p1e3",
                            RealeaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Season = "Part 1",
                            SourceLink = "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm",
                            TVShowId = 2,
                            ThumbnailLink = "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Duration = new TimeSpan(0, 0, 10, 35, 0),
                            EpisodeNumber = 1,
                            Name = "Big Buck Bunny p2e1",
                            RealeaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Season = "Partie 2!",
                            SourceLink = "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm",
                            TVShowId = 2,
                            ThumbnailLink = "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Duration = new TimeSpan(0, 0, 10, 35, 0),
                            EpisodeNumber = 1,
                            Name = "Big Buck Bunny p1e2",
                            RealeaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Season = "Partie 2!",
                            SourceLink = "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm",
                            TVShowId = 2,
                            ThumbnailLink = "https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg"
                        });
                });

            modelBuilder.Entity("GuiFlix_Models.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("ProfileId", "MediaId");

                    b.HasIndex("MediaId");

                    b.ToTable("Likes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MediaId = 1,
                            ProfileId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            MediaId = 2,
                            ProfileId = 1,
                            Type = 2
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "My List",
                            ProfileId = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CrewMemberId = 1,
                            MediaId = 1,
                            Role = "Realisator"
                        },
                        new
                        {
                            Id = 2,
                            CrewMemberId = 1,
                            MediaId = 2,
                            Role = "Realisator"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            AvatarLink = "https://upload.wikimedia.org/wikipedia/commons/0/0b/Netflix-avatar.png?20201013161117",
                            UserName = "Guigui"
                        });
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

                    b.HasData(
                        new
                        {
                            ListsId = 1,
                            MediasId = 1
                        },
                        new
                        {
                            ListsId = 1,
                            MediasId = 2
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Name = "Big Buck Bunny",
                            Pegi = 0,
                            RealeaseDate = new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThumbnailLink = "https://peach.blender.org/wp-content/uploads/bbb-splash.png",
                            Duration = new TimeSpan(0, 0, 10, 35, 0),
                            SourceLink = "https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
                        });
                });

            modelBuilder.Entity("GuiFlix_Models.Models.TVShow", b =>
                {
                    b.HasBaseType("GuiFlix_Models.Models.Media");

                    b.HasDiscriminator().HasValue("TVShow");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Description = "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                            Name = "Big Buck Bunny Tv Show",
                            Pegi = 0,
                            RealeaseDate = new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThumbnailLink = "https://www.embedded-france.org/wp-content/uploads/2013/04/big_buck_bunny_2008_11.jpg"
                        });
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
                    b.HasOne("GuiFlix_Models.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuiFlix_Models.Models.Profile", "Profile")
                        .WithMany("Likes")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Media");

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
