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
            ,new Profile
            {
                Id=2,
                UserName="YoYo",
                AccountId=1,
                AvatarLink="https://mir-s3-cdn-cf.behance.net/project_modules/disp/bf6e4a33850498.56ba69ac3064f.png"
            },new Profile
            {
                Id=3,
                UserName="RoRo",
                AccountId=1,
                AvatarLink="https://mir-s3-cdn-cf.behance.net/project_modules/disp/bf6e4a33850498.56ba69ac3064f.png"
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
            },

            new Film
            {
                Id=3,
                Name="Rampage: Out of Control",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2018,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.francetvinfo.fr/pictures/f9wGZUBj31FFuL6kQvKFkPtHCu0/752x423/2019/04/11/rampage_a.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=4,
                Name="The NorthMan",
                Pegi=Media.PegiTypes.Pegi18,
                RealeaseDate=new DateTime(2022,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://media2.ledevoir.com/images_galerie/nwd_1205172_954681/image.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=5,
                Name="The Pilgrim's Progress",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.ytimg.com/vi/ksu-zTG9HHg/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=6,
                Name="New Gods: Nezha Reborn",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2022,05,13),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.flixwatch.co/wp-content/uploads/81418302.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=7,
                Name="Avatar: The Shape of Water",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2022,12,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://images.bfmtv.com/vFdrtem8xl6HgTlN3LL5a1s7hLM=/3x2:1363x767/1360x0/images/-206289.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=8,
                Name="LightYear",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2023,04,24),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://static1.srcdn.com/wordpress/wp-content/uploads/2021/10/Lightyear-trailer-teases-the-origins-of-evil-emperor-zurg.jpeg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=9,
                Name="Spies In Disguise",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,12,7),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.comingsoon.net/assets/uploads/2018/10/SpiesF.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=10,
                Name="Howl's Moving Castle",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2004,09,5),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.critikat.com/wp-content/uploads/fly-images/31797/arton32-1450x800-c.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=11,
                Name="Princess Mononoké",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(1997,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://static.hitek.fr/img/actualite/ill_m/623669905/princessemononoke.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=12,
                Name="The Simpson's: The Movies",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2010,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.critikat.com/wp-content/uploads/fly-images/35368/arton1450-1450x800-c.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=13,
                Name="OnWard",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://lumiere-a.akamaihd.net/v1/images/onward_unauthenticateddetailhero_1_62adaf28.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=14,
                Name="Soul",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2021,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://3238leblogdemarvelll-1278.kxcdn.com/wp-content/uploads/2020/12/soul-pixar-disneyplus-banniere-scaled.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=15,
                Name="Big Hero 6",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2016,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="http://www.jmlalonde.com/wp-content/uploads/2014/11/big-hero-6-character-promo-image-550x302.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=16,
                Name="Over The Moon",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2016,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://news.dayfr.com/divertissement/content/uploads/2022/04/17/332059afdb.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=17,
                Name="Space Chimps",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2008,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://media.senscritique.com/media/000018453122/1200/Les_Chimpanzes_de_l_espace.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=18,
                Name="Flavor Of Youth",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2019,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABaKGGyhZTOvyji9QRhhVZG4Ldy0Dpk53Wr2YVtcthf8S9TgockeX1WoxYt9dpmO6802FZ2pWPBrblpfzPBesYooyF58RIWV_fvyN.jpg?r=7d2",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=19,
                Name="Spider-Man: Into the SpiderVerse",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2020,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="http://www.coupleofpixels.be/wp-content/uploads/2018/12/intothespiderverse1.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=20,
                Name="The Rain Children",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2020,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://imgsrc.cineserie.com/2020/04/136584.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=21,
                Name="Astro Boy",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2011,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.ytimg.com/vi/5Z123CARsTs/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=22,
                Name="The Mitchell VS The Machines",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2011,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://premiere.fr/sites/default/files/styles/scale_crop_1280x720/public/2020-03/de%CC%81connecte%CC%81s_0.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=23,
                Name="Flushed Away",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2006,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABe4Y3SGjIsx2bZXiRz2mxBwEmYP06MocUxTtTT_iYnkF7tRQV8IFKnNV17A950-x4xWeUUQ95y0DdFAbS3CftLIU6JE6KvEEWWcb.jpg?r=e38",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=24,
                Name="The Shining",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(1980,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i0.wp.com/halacine.com/wp-content/uploads/2022/03/The-Shining-de-Stephen-King-devient-une-piece-de-theatre.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=25,
                Name="Sinister",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2012,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.ytimg.com/vi/4sfzhzRAceE/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=26,
                Name="Mister Babaddook",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2014,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://catholicgirlbloggin.files.wordpress.com/2015/07/23babadook2-articlelarge.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=27,
                Name="A NightMare On Elm Street",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2012,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="http://idata.over-blog.com/2/80/11/49/photos-films/autres-images-blog/article-freddy-les-griffes-de-la-nuit.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=28,
                Name="It",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.noovomoi.ca/content/dam/style-de-vie/migrated/images/2019/05/09/it-chapter-two.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=29,
                Name="Death At a Funeral",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://a.ltrbxd.com/resized/sm/upload/96/1r/hy/ic/death-at-a-funeral-1200-1200-675-675-crop-000000.jpg?k=c96960e4b1",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=30,
                Name="Let's Be Cops",
                Pegi=Media.PegiTypes.Pegi13,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.gannett-cdn.com/-mm-/862d45e47a2718a9e56ef6e47538ecb266665222/c=0-297-5760-3537/local/-/media/LafayetteIN/2014/08/20/filmreviewletsbeccarr.jpg?width=3200&height=1800&fit=crop&format=pjpg&auto=webp",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=31,
                Name="The Interview",
                Pegi=Media.PegiTypes.Pegi16,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://i.blogs.es/62ac2a/650_1000_cartel-the-interview/1366_2000.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=32,
                Name="Bruce AlMighty",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.cinematheque.fr/cache/media/programmation/films/bruce-tout-puissant/s,725-549cdf.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=33,
                Name="Evan AlMighty",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2018,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://productplacementblog.com/wp-content/uploads/2018/01/Century-21-Real-Estate-Company-in-Evan-Almighty-3.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=34,
                Name="Megamind",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2009,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.premiere.fr/sites/default/files/styles/scale_crop_1280x720/public/2022-02/Megamind.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=35,
                Name="Iron Man 3",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(2014,07,12),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://img-31.ccm2.net/VXvUmaJweeWRShVXxn2cwrskiY8=/1240x/smart/8effb5b443a6483eaed2a8f886b037e3/ccmcms-hugo/10759516.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Film
            {
                Id=36,
                Name="Avengers",
                Pegi=Media.PegiTypes.Pegi13,
                RealeaseDate=new DateTime(2012,05,1),
                Description= "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                ThumbnailLink="https://www.telez.fr/content/uploads/2019/04/avengers-1-1280x720.jpg",
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
            },
            new TVShow
            {
                Id=37,
                Name="The Simpson's Tv Show",
                Pegi=Media.PegiTypes.ALL,
                RealeaseDate=new DateTime(1989,1,1),
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://img.betaseries.com/qWBzg3rSTSQk5IwvvKISgAa3i7Q=/500x282/smart/https%3A%2F%2Fwww.betaseries.com%2Fblog%2Fwp-content%2Fuploads%2F2021%2F07%2F12_62521772.jpeg"
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
                EpisodeNumber=2,
                Name ="Big Buck Bunny p1e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://image.tmdb.org/t/p/original/bZxwNUANy2KAYBjM9UyUlqiCMI1.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 3,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=3,
                Name ="Big Buck Bunny p1e3",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://upload.wikimedia.org/wikipedia/commons/3/31/Big.Buck.Bunny.-.Frank.Bunny.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 4,
                TVShowId=2,
                Season="Part 1",
                EpisodeNumber=4,
                Name ="Big Buck Bunny p1e4",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://upload.wikimedia.org/wikipedia/commons/4/44/Big.Buck.Bunny.-.Bunny.with.Bow.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 5,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p2e1",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://ddz4ak4pa3d19.cloudfront.net/cache/5e/e5/5ee50a089ff4e9d1593ad8b5278f2f48.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 6,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=2,
                Name ="Big Buck Bunny p2e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://i.ytimg.com/vi/4-Ddumty4mk/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 7,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=3,
                Name ="Big Buck Bunny p2e3",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://i.ytimg.com/vi/wWla97L1wng/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 8,
                TVShowId=2,
                Season="Partie 2!",
                EpisodeNumber=4,
                Name ="Big Buck Bunny p2e4",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://framalibre.org/sites/default/files/PeachBlender.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 9,
                TVShowId=2,
                Season="Partie 3!",
                EpisodeNumber=1,
                Name ="Big Buck Bunny p3e1",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://cutewallpaper.org/21/big-buck-bunny-wallpapers/Big-Buck-BUNNY-by-Blender-Foundation-ALPdigest-CHANNEL.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 10,
                TVShowId=2,
                Season="Partie 3!",
                EpisodeNumber=2,
                Name ="Big Buck Bunny p3e2",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://i.ytimg.com/vi/2tdp1FucyAk/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 11,
                TVShowId=2,
                Season="Partie 3!",
                EpisodeNumber=3,
                Name ="Big Buck Bunny p3e3",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://i0.wp.com/thinkinganimation.com/wp-content/uploads/2008/06/evil-frank.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 12,
                TVShowId=2,
                Season="Partie 3!",
                EpisodeNumber=4,
                Name ="Big Buck Bunny p3e4",
                Description= "Big Buck Bunny (code-named Project Peach) is a 2008 short computer-animated comedy film featuring animals of the forest, made by the Blender Institute, part of the Blender Foundation. Like the foundation's previous film, Elephants Dream, the film was made using Blender, a free and open-source software application for 3D computer modeling and animation developed by the same foundation. Unlike that earlier project, the tone and visuals departed from a cryptic story and dark visuals to one of comedy, cartoons, and light-heartedness.\nIt was released as an open-source film under the Creative Commons Attribution 2.5 license.",
                ThumbnailLink="https://flossmanuals.developpez.com/tutoriels/blender/jeu-video/images/yofrankie15.png",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 13,
                TVShowId=37,
                Season="Partie 1!",
                EpisodeNumber=1,
                Name ="Simpsons Roasting on Open Fire",
                Description= "While the Simpsons are Christmas shopping, Bart sneaks off and gets a tattoo. Marge soon discovers this and uses the family's Christmas savings to get it removed. Meanwhile, Homer discovers that he will not be getting a Christmas bonus from Mr. Burns and thus the family has no money to buy Christmas presents. He decides to keep their financial troubles a secret and get a job as a department store Santa, but later discovers that the job does not pay enough. Desperate for a miracle, Homer and Bart go to the dog track on Christmas Eve in hopes of earning some money. He bets it all on a long shot named Santa's Little Helper, who loses. Angry that he lost, the dog's owner disowns him. Homer lets Bart keep him. Later, Homer attempts to come clean to everyone, but Bart exclaims that they have a dog and everyone happily welcomes the newest member of the Simpson family.",
                ThumbnailLink="https://static3.srcdn.com/wordpress/wp-content/uploads/2019/04/SIMPSONS-PETS-RANKED.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 14,
                TVShowId=37,
                Season="Partie 1!",
                EpisodeNumber=2,
                Name ="Bart the genius",
                Description= "Bart has trouble on an intelligence test and sneakily switches tests with Martin Prince, the class genius. After the results are tabulated, the school psychiatrist labels Bart a genius and sends him to the Enriched Learning Center for Gifted Children. Homer starts treating Bart with respect, but Bart immediately feels out of place among his new classmates and alienated from his former peers. He confesses that he cheated on the test and is subsequently sent back to Springfield Elementary School.",
                ThumbnailLink="https://i.ytimg.com/vi/vTB26Fxp57Q/maxresdefault.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 15,
                TVShowId=37,
                Season="Partie 1!",
                EpisodeNumber=3,
                Name ="Homer's Odyssey",
                Description= "Bart's class visits the Springfield Nuclear Power Plant and Homer, anxious to look like he is working, accidentally crashes his cart into a radioactive pipe, causing him to be fired. Depressed and unable to find a new job, he decides to commit suicide by jumping off a bridge. His family discover his plan and try to stop him, but in the process they are almost run over by a truck. Discovering his new purpose, Homer embarks on a safety crusade and eventually decides to go after the Nuclear Plant and holds protest rallies. To end Homer's furor, Mr. Burns offers him a job as safety inspector, with increased salary, which Homer accepts.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BZTIxMDk3MTEtNDExYi00MDBhLTljMmMtZjI0Y2I1YTlkZGY1XkEyXkFqcGdeQXVyMjI4OTg3MTc@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 16,
                TVShowId=37,
                Season="Partie 1!",
                EpisodeNumber=4,
                Name ="There's no Disgrace Like Home",
                Description= "Homer takes his family to the company picnic at Mr. Burns's manor. Marge, Bart and Lisa embarrass Homer and he notices that Mr. Burns seems to favour a family who love and respect one another. Convinced that both he and his family are pathetic, he takes everyone to a family therapy center. When standard methods prove useless in civilizing them, the doctor resorts to shock therapy. Soon the Simpsons start shocking each other, causing the whole town to lose power.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BZTU3OTgxNjItMWQ2Mi00YjA4LWEwMzctNDYxNWRkYTY1NDYyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 17,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=1,
                Name ="Bart The General",
                Description= "Bart runs afoul of Nelson Muntz, the school bully, who begins attacking Bart every day after school. Homer suggests fighting back, which does not work. Desperate for a solution, Bart visits Grampa for advice. Grampa takes Bart to meet Herman, who suggests that Bart rally all the school children and declare war on Nelson. Bart and his army attack Nelson and successfully manage to convince him to give up his bullying ways.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BMzk4ZDU2OTMtZjM0NC00ZWIyLWFmNmQtMjcyZGQ1OWE0ZWMyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 18,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=2,
                Name ="Moaning Lisa",
                Description= "Lisa becomes depressed, which begins to affect her performance in school. Neither Marge nor Homer are able to make Lisa happier. One night, she hears distant Jazz music and sneaks out of her room to follow it. She meets Bleeding Gums Murphy, who teaches her how to express her music through the saxophone. When Marge drops Lisa off at school the next day, she suggests that Lisa smile no matter how she feels. However, Marge sees that Lisa is being denied her creativity and realizes that is what is disappointing her. Marge tells Lisa to just be herself, and the entire family go to see Murphy perform at a local Jazz club.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BOWFlN2U2NWYtZWIyYy00YTY5LTlhMDAtZmQwMWZhM2I3MjQ4XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 19,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=3,
                Name ="The Call of The Simpsons",
                Description= "Homer becomes envious of Flanders' new RV and goes to Bob's RV Round-up to buy one of his own. Settling on a dilapidated camper, he takes the family camping and in the process destroys the RV. Leaving Lisa and Marge behind, Bart and Homer try to find their way back to civilization, but have little luck. Later on, Homer is mistaken for Bigfoot and captured. Marge, Bart and Lisa are saved and Homer is released, although scientists say they can not determine which species he belongs to.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BOTkxMzY3Y2QtMWMyMC00NDllLTkyMTctZTY4MDFjZGExYTc1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 20,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=4,
                Name ="The Telltale Head",
                Description= "Bart becomes friends with Jimbo, Dolph, and Kearney, a group of local troublemakers. Trying to impress them, Bart decides to cut off and steal the head of the statue of Jebediah Springfield. The next day, the entire town grieves for the vandalized statue and Bart discovers that his new friends want to attack the vandal. Feeling remorse, Bart confesses to his family and Homer and Bart take the head back to the statue after passing through the furious people.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BNTFmZWU1YTAtOWIzMy00ZDY2LWFhNDktMjBmMjk5YmU5NmFiXkEyXkFqcGdeQXVyMjI4OTg3MTc@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 21,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=5,
                Name ="Life On The Fast Lane",
                Description= "Having forgotten about Marge's birthday, Homer rushes to the Springfield mall and impulsively buys her a bowling ball. Marge is not impressed with the gift and after discovering that he intends to use it, she decides to spite him by going bowling herself. While at the alley, she meets Jacques, a charming French bowling instructor, who offers her lessons. Jacques begins to fall for Marge and invites her to his apartment. Although she agrees, Marge undergoes a moral dilemma. In the end, Marge visits Homer at the nuclear plant.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BNjY3NzExYWYtNGFlZC00NmJkLTlhZjQtN2RlYWIyMTYzYWYwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 22,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=6,
                Name ="Homer's Night Out",
                Description= "Bart purchases a mini spy camera and manages to take a picture of Homer dancing next to stripper named Princess Kashmir at a co-worker's strip club party. He gives copies of the picture to his friends, and eventually the picture starts to circulate around until eventually Marge sees it. She kicks Homer out of the house, but the next day explains that she is not upset about his dancing next to a woman, but rather that Bart saw it. She demands that he take Bart and go apologize to Princess Kashmir. Homer agrees and says he is ready to start respecting women.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BMDFjMjQzYTMtMGM2YS00NjYyLTg3NzktMDAyZjJiY2E5MTcwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 23,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=7,
                Name ="The Crepes of Wrath",
                Description= "Principal Skinner finally becomes fed up with Bart's pranks and proposes that Bart be sent to France as part of the student exchange program. The family agrees and Bart is sent to the beautiful Château Maison, which is actually a dilapidated farmhouse on a neglected vineyard. Bart is treated like a slave by two unscrupulous winemakers, César and Ugolin, who eventually feed him wine tainted with antifreeze. Meanwhile, an Albanian boy named Adil starts to live with the Simpsons who, unbeknownst to Homer, is a spy sent by his country to obtain nuclear blueprints. Back in France, Bart learns French and reports the winemakers' crimes to the authorities.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BMDc0YzBhOWItYjk0OS00YTBiLWEwNDUtMzI2YzQ0NWM1YjNlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 24,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=8,
                Name ="Krusty Gets Busted",
                Description= "While buying ice cream at the Kwik-E-Mart, Homer witnesses a robbery perpetrated by a man believed to be Krusty the Clown, host of Krusty the Clown Show, Bart's favorite program. Krusty is sent to jail and his show is taken over by his assistant, Sideshow Bob. Bart is certain Krusty is innocent, and gathers evidence to support his claim, which he takes to Krusty's bestest friend, Sideshow Bob. Bart realizes the robbery was actually committed by Bob, who was trying to frame Krusty. Bob is arrested and Krusty thanks Bart for saving him.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BNDFhNjFkNzgtN2M4OC00YTg1LWI5NjEtZGIxNTUyNTMyNjg5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 25,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=9,
                Name ="Some Enchanted Evening",
                Description= "Marge, feeling unappreciated by Homer, makes a call to a radio therapist, which Homer overhears at work. Homer, wanting to make it up to Marge, decides to take her to dinner at a fancy restaurant and hires a babysitter to take care of Bart and Lisa. They are sent Ms. Botz, who Bart and Lisa soon discover is actually a burglar nicknamed The Babysitter Bandi. They are captured by Ms. Botz and tied up but eventually are freed by Maggie. Bart and Lisa capture Ms. Botz and call the police. Meanwhile, Marge and Homer return home and find Ms. Botz is tied up. Homer, unaware of her true identity, frees her and Ms. Botz makes a clean getaway just moments before the police arrive.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BZmFkZDY3MjItMGY0NS00YTFkLWI1YjMtYzEwMTliYTFiMmFkXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                Duration= new TimeSpan(0,10,35),
                SourceLink="https://upload.wikimedia.org/wikipedia/commons/transcoded/c/c0/Big_Buck_Bunny_4K.webm/Big_Buck_Bunny_4K.webm.720p.webm"
            },
            new Episode
            {
                Id = 26,
                TVShowId=37,
                Season="Partie 2!",
                EpisodeNumber=10,
                Name ="Bart Gets an F",
                Description= "Bart fails a test and is told he has one more chance to pass it or else he will be held back a year. Bart tries to get the class genius Martin Prince to help him, but after that fails, Bart prays for help. That night, Springfield is hit with a massive blizzard and the school is closed, giving Bart one more day to study. Despite his desperate attempts, Bart fails the test again. While crying, he mentions an obscure historical event and Mrs. Krabappel, noting that he applied practical knowledge, passes him.",
                ThumbnailLink="https://m.media-amazon.com/images/M/MV5BNzQ3ZDJjMTUtOTllNi00ZmY4LWI2MjktOWJiNmM4ZjBmZDgxXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
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
            },
            new Category
            {
                Id=4,
                Name="Horror"
            },
            new Category
            {
                Id=5,
                Name="Comedy"
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
            },
            new
            {
                CategoriesId = 3,
                MediasId = 2,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 3,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 4,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 5,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 5,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 5,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 6,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 6,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 6,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 7,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 8,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 8,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 8,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 9,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 9,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 9,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 10,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 10,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 10,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 11,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 11,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 11,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 12,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 12,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 12,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 13,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 13,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 13,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 14,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 14,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 14,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 15,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 15,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 15,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 16,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 16,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 16,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 17,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 17,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 17,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 18,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 18,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 18,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 19,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 19,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 19,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 20,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 20,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 20,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 21,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 21,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 21,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 22,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 22,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 22,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 23,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 23,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 23,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 24,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 25,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 26,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 27,
            },
            new
            {
                CategoriesId = 4,
                MediasId = 28,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 29,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 30,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 30,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 31,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 31,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 32,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 32,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 33,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 33,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 2,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 34,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 35,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 35,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 36,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 36,
            },
            new
            {
                CategoriesId = 5,
                MediasId = 37,
            },
            new
            {
                CategoriesId = 3,
                MediasId = 37,
            },
            new
            {
                CategoriesId = 1,
                MediasId = 37,
            }
        };
        public CrewMember[] CrewMembers => new CrewMember[]
        {
            new CrewMember
            {
                Id=1,
                FirstName="Matt",
                LastName="Groening"
            },
            new CrewMember
            {
                Id=2,
                FirstName="Dan",
                LastName="Castellaneta"
            },
            new CrewMember
            {
                Id=3,
                FirstName="Julie",
                LastName="Kavner"
            },
            new CrewMember
            {
                Id=4,
                FirstName="Nancy",
                LastName="CartWright"
            },
            new CrewMember
            {
                Id=5,
                FirstName="Yeardley",
                LastName="Smith"
            },
            new CrewMember
            {
                Id=6,
                FirstName="James",
                LastName="Earl Jones"
            },
            new CrewMember
            {
                Id=7,
                FirstName="Glenn",
                LastName="Close"
            },
            new CrewMember
            {
                Id=8,
                FirstName="Maggie",
                LastName="Roswell"
            },
            new CrewMember
            {
                Id=9,
                FirstName="Harry",
                LastName="Shearer"
            },
            new CrewMember
            {
                Id=10,
                FirstName="Marcia",
                LastName="Mitzman Gaven"
            },
            new CrewMember
            {
                Id=11,
                FirstName="Pamela",
                LastName="Hayden"
            },
            new CrewMember
            {
                Id=12,
                FirstName="Hank",
                LastName="Azaria"
            },
            new CrewMember
            {
                Id=13,
                FirstName="Jan",
                LastName="Hooks"
            },
            new CrewMember
            {
                Id=14,
                FirstName="Tress",
                LastName="MacNeille"
            },
            new CrewMember
            {
                Id=15,
                FirstName="Russi",
                LastName="Taylor"
            }
        };
        public MediaCrewMember[] MediaCrewMember => new MediaCrewMember[]
        {
            new MediaCrewMember
            {
                Id = 1,
                CrewMemberId=1,
                MediaId=37,
                Role="Realisator"
            },
            new MediaCrewMember
            {
                Id = 2,
                CrewMemberId=2,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 3,
                CrewMemberId=3,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 4,
                CrewMemberId=4,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 5,
                CrewMemberId=5,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 6,
                CrewMemberId=6,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 7,
                CrewMemberId=7,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 8,
                CrewMemberId=8,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 9,
                CrewMemberId=9,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 10,
                CrewMemberId=10,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 11,
                CrewMemberId=11,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 12,
                CrewMemberId=12,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 13,
                CrewMemberId=13,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 14,
                CrewMemberId=14,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 15,
                CrewMemberId=15,
                MediaId=37,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 16,
                CrewMemberId=1,
                MediaId=12,
                Role="Realisator"
            },
            new MediaCrewMember
            {
                Id = 17,
                CrewMemberId=2,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 18,
                CrewMemberId=3,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 19,
                CrewMemberId=4,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 20,
                CrewMemberId=5,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 21,
                CrewMemberId=6,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 22,
                CrewMemberId=7,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 23,
                CrewMemberId=8,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 24,
                CrewMemberId=9,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 25,
                CrewMemberId=10,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 26,
                CrewMemberId=11,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 27,
                CrewMemberId=12,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 28,
                CrewMemberId=13,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 29,
                CrewMemberId=14,
                MediaId=12,
                Role="Voice Actor"
            },
            new MediaCrewMember
            {
                Id = 30,
                CrewMemberId=15,
                MediaId=12,
                Role="Voice Actor"
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
            },
            new
            {
                ListsId = 1,
                MediasId = 3
            },
            new
            {
                ListsId = 1,
                MediasId = 4
            },
            new
            {
                ListsId = 1,
                MediasId = 5
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
            },
            new Like
            {
                Id=3,
                ProfileId = 1,
                MediaId = 3,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=4,
                ProfileId = 1,
                MediaId = 4,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=5,
                ProfileId = 1,
                MediaId = 5,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=6,
                ProfileId = 1,
                MediaId = 6,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=7,
                ProfileId = 1,
                MediaId = 7,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=8,
                ProfileId = 1,
                MediaId = 8,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=9,
                ProfileId = 1,
                MediaId = 9,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=10,
                ProfileId = 1,
                MediaId = 10,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=11,
                ProfileId = 1,
                MediaId = 11,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=12,
                ProfileId = 1,
                MediaId = 12,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=13,
                ProfileId = 1,
                MediaId = 13,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=14,
                ProfileId = 1,
                MediaId = 14,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=15,
                ProfileId = 1,
                MediaId = 15,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=16,
                ProfileId = 1,
                MediaId = 16,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=17,
                ProfileId = 1,
                MediaId = 17,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=18,
                ProfileId = 1,
                MediaId = 18,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=19,
                ProfileId = 1,
                MediaId = 19,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=20,
                ProfileId = 1,
                MediaId = 20,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=21,
                ProfileId = 1,
                MediaId = 21,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=22,
                ProfileId = 1,
                MediaId = 22,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=23,
                ProfileId = 1,
                MediaId = 23,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=24,
                ProfileId = 1,
                MediaId = 24,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=25,
                ProfileId = 1,
                MediaId = 25,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=26,
                ProfileId = 1,
                MediaId = 26,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=27,
                ProfileId = 1,
                MediaId = 27,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=28,
                ProfileId = 1,
                MediaId = 28,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=29,
                ProfileId = 1,
                MediaId = 29,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=30,
                ProfileId = 1,
                MediaId = 30,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=31,
                ProfileId = 1,
                MediaId = 31,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=32,
                ProfileId = 1,
                MediaId = 32,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=33,
                ProfileId = 1,
                MediaId = 33,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=34,
                ProfileId = 1,
                MediaId = 34,
                Type = Like.LikeTypes.Love
            },
            new Like
            {
                Id=35,
                ProfileId = 1,
                MediaId = 35,
                Type = Like.LikeTypes.Dislike
            },
            new Like
            {
                Id=36,
                ProfileId = 1,
                MediaId = 36,
                Type = Like.LikeTypes.Like
            },
            new Like
            {
                Id=37,
                ProfileId = 1,
                MediaId = 37,
                Type = Like.LikeTypes.Love
            }
        };
    }
}
