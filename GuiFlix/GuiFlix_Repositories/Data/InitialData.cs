using GuiFlix_Models.Models;
using GuiFlix_Repositories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Repositories.Data
{
    public class InitialData
    {
        public CryptPasswordService _cryptPasswordService;
        public InitialData(string secretKey)
        {
            _cryptPasswordService = new CryptPasswordService(secretKey);
        }
        public Admin[] Admins => new Admin[]
        {
            new Admin
            {
                Id = 1,
                UserName = "admin",
                Password = _cryptPasswordService.EncryptPassword("admin")
            }
        };
        public Question[] Questions => new Question[]
        {
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
        };
        public Account[] Accounts => new Account[]
        {
            new Account
            {
                Id= 1,
                FirstName="Guillaume",
                LastName="Mairesse",
                Email="guillaume@exemlpe.com",
                Phone="0607080910",
                IsBanned=false,
                Password=_cryptPasswordService.EncryptPassword("PAss00++")
            }
        };
        public Profile[] Profiles => new Profile[]
        {
            new Profile
            {
                Id=1,
                UserName="Guigui",
                AccountId=1,
                AvatarLink="https://upload.wikimedia.org/wikipedia/commons/0/0b/Netflix-avatar.png?20201013161117"
            }
        };
        public Film[] Films => new Film[]
        {
            new Film
            {
                Id=1,
                Name="Big Buck Bunny",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2008,1,1),
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://peach.blender.org/wp-content/uploads/bbb-splash.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            }
        };
        public TVShow[] TVShows => new TVShow[]
        {
            new TVShow
            {
                Id=2,
                Name="Big Buck Bunny Tv Show",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2008,1,1),
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://www.embedded-france.org/wp-content/uploads/2013/04/big_buck_bunny_2008_11.jpg"
            }
        };
        public Episode[] Episodes => new Episode[]
        {
            new Episode
            {
                Id = 1,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e1",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 2,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 3,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e3",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 4,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p2e1",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 5,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p1e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://images-0.wuaki.tv/system/shots/184794/original/snapshot-1590658111.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            }
        };
        public Category[] Categories => new Category[]
        {
            new Category
            {
                Id=1,
                Name="Animation"
            },
            new Category
            {
                Id=2,
                Name="Kids"
            },
            new Category
            {
                Id=3,
                Name="Action"
            }
        };
        public object[] CategoryMedia => new object[]
        {
            new 
            {
                CategoriesId = 1,
                MediasId = 1,
            },
            new 
            {
                CategoriesId = 1,
                MediasId = 2,
            },
            new 
            {
                CategoriesId = 2,
                MediasId = 1,
            },
            new 
            {
                CategoriesId = 2,
                MediasId = 2,
            }
        };
        public CrewMember[] CrewMembers => new CrewMember[]
        {
            new CrewMember
            {
                Id=1,
                FirstName="Sacha",
                LastName="Goedegebure"
            }
        };
        public MediaCrewMember[] MediaCrewMember => new MediaCrewMember[]
        {
            new MediaCrewMember
            {
                Id = 1,
                CrewMemberId=1,
                MediaId=1,
                Role="Realisator"
            },
            new MediaCrewMember
            {
                Id = 2,
                CrewMemberId=1,
                MediaId=2,
                Role="Realisator"
            }
        };
        public List[] Lists => new List[]
        {
            new List
            {
                Id =1,
                Name="My List",
                ProfileId=1,
            }
        };
        public object[] ListMedia => new object[]
        {
            new
            {
                ListsId = 1,
                MediasId = 1
            },
            new
            {
                ListsId = 1,
                MediasId = 2
            }
        };
        public Like[] Likes => new Like[]
        {
            new Like
            {
                Id=1,
                ProfileId = 1,
                MediaId = 1,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=2,
                ProfileId = 1,
                MediaId = 2,
                Type = Like.LikeTypes.Dislike
            }
        };
    }
}
