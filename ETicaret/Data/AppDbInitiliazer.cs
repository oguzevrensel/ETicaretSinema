using ETicaret.Models;

namespace ETicaret.Data
{
    public class AppDbInitiliazer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                _ = context.Database.EnsureCreated();


                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>
                    {
                        new Actor
                        {
                            FullName = "Actor 1",
                            ProfilePictureUrl= "https://d.neoldu.com/gallery/1863_1.jpg",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 2",
                            ProfilePictureUrl= "https://im.haberturk.com/galeri/2013/07/18/ver1374138619/429440/c21b5a8eeeab146cd39b02d265eb473b_k.jpg",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 3",
                            ProfilePictureUrl= "https://i.cnnturk.com/i/cnnturk/75/0x555/5614389d496783211c180768",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 4",
                            ProfilePictureUrl= "https://i4.hurimg.com/i/hurriyet/75/866x494/5d79011545d2a023a0d6da63.jpg",
                            Bio = "Actor 1 biyografisi "
                        },
                        new Actor
                        {
                            FullName = "Actor 5",
                            ProfilePictureUrl= "https://cdn1.ntv.com.tr/gorsel/TL9EolV1S0ikO8Jad1u17g.jpg?width=1000&mode=crop&scale=both",
                            Bio = "Actor 1 biyografisi "
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>
                    {
                        new Cinema
                        {
                            Name = "Cinema 1",
                            Logo = "https://cdn.odatv4.com/images/2022_10/2022_10_17/odatv_image_87__927e7279ad6a4b.jpg",
                            Description = "Sinema hakkında bilgi"
                        },
                        new Cinema
                        {
                            Name = "Cinema 2",
                            Logo = "http://ozdemirpark.com/wp-content/uploads/2016/08/Avsar-Sinema-1.jpg",
                            Description = "Sinema hakkında bilgi"
                        },
                        new Cinema
                        {
                            Name = "Cinema 3",
                            Logo = "https://agorasinemalari.com/assets/images/agora-izmir.jpg",
                            Description = "Sinema hakkında bilgi"
                        },
                        new Cinema
                        {
                            Name = "Cinema 4",
                            Logo = "https://antalyacityzone.com/images/cityguideplaces/antalya-erasta-aksin-sinemalari/sinema1578985430.jpg",
                            Description = "Sinema hakkında bilgi"
                        }

                    });
                    context.SaveChanges();
                }

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>
                    {
                        new Producer
                        {
                            FullName = "Producer 1",
                            Bio = "Productor hakkında bilgi",
                            ProfilePictureUrl = "https://cdn.britannica.com/81/220481-050-55413025/Quentin-Tarantino-2020.jpg"
                        },
                        new Producer
                        {
                            FullName = "Producer 2",
                            Bio = "Productor hakkında bilgi",
                            ProfilePictureUrl = "https://flxt.tmsimg.com/assets/74068_v9_bb.jpg"
                        },
                        new Producer
                        {
                            FullName = "Producer 3",
                            Bio = "Productor hakkında bilgi",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ab/Festival_de_cinema_de_Sitges_2018_%2831305141408%29_%28cropped4%29.jpg"
                        }

                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>
                    {
                        new Movie
                        {
                            Name = "John Wick 4",
                            Description = "John Wick sets out to get revenge on the High Table and those who left him for dead",
                            Price = 100,
                            ImageUrl = "https://lionsgate.brightspotcdn.com/27/26/1761e2fe4faea9e2eb8ad0cbdebb/john-wick-chapter-4-movies-he-poster-02.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 5,
                             ProducerId=5,
                            MovieCategory = Enum.MovieCategory.Action
                        },
                        new Movie
                        {
                            Name = "Titanic",
                            Description = "British luxury passenger liner that sank on April 15, 1912",
                            Price = 100,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(7),
                            EndDate= DateTime.Now.AddDays(14),
                            CinemaId = 5,
                             ProducerId=4,
                            MovieCategory = Enum.MovieCategory.Horror
                        },new Movie
                        {
                            Name = "Skyfall",
                            Description = "James Bond's loyalty to M is tested when her past comes back to haunt her. ",
                            Price = 100,
                            ImageUrl = "https://tr.web.img2.acsta.net/medias/nmedia/18/88/95/51/20264212.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(14),
                            CinemaId = 7,
                            ProducerId=6,
                            MovieCategory = Enum.MovieCategory.Documentary
                        },new Movie
                        {
                            Name = "Togo",
                            Description = "The Disney+ movie Togo is about the heroic run of the titular Siberian husky,",
                            Price = 100,
                            ImageUrl = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/8AB1525C077AD6579FB1F0EBEC477B5531DF466FB9705BA36C7FF84A56E8FD16/scale?width=1200&aspectRatio=1.78&format=jpeg",
                            StartDate = DateTime.Now.AddMonths(1),
                            EndDate= DateTime.Now.AddMonths(1).AddDays(7),
                            CinemaId = 8,
                            ProducerId = 5,
                            MovieCategory = Enum.MovieCategory.Comedy
                        },new Movie
                        {
                            Name = "Assasins Creed",
                            Description = "The Knights of the Templar Order are seeking out the Apple of Eden",
                            Price = 100,
                            ImageUrl = "https://assets1.ignimgs.com/2016/11/23/assassinscreedver5xlgjpg-fe288c.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 5,
                            ProducerId=4,
                            MovieCategory = Enum.MovieCategory.Drama
                        },new Movie
                        {
                            Name = "Teddy Bear",
                            Description = "A teddy bear is a children's toy, made from soft or furry material",
                            Price = 100,
                            ImageUrl = "https://www.tampabay.com/resizer/F7MU44mlGIH5xaPKO0Zg8Y_6vGA=/1200x675/smart/cloudfront-us-east-1.images.arcpublishing.com/tbt/LEHNEUGHAQI6TBKNIBWI6S7HAY.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 6,
                            ProducerId = 6,
                            MovieCategory = Enum.MovieCategory.Action
                        },new Movie
                        {
                            Name = "Spider-Man 3",
                            Description = "A strange black entity from another world bonds with Peter Parker",
                            Price = 120,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7a/Spider-Man_3%2C_International_Poster.jpg/220px-Spider-Man_3%2C_International_Poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 7,
                            ProducerId=5,
                            MovieCategory = Enum.MovieCategory.Documentary
                        }
                        ,new Movie
                        {
                            Name = "Yes Man",
                            Description = "A man who decided at one point in his life to say \"yes\"",
                            Price = 135,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQUhwI99ZiVDbyZ0jcvDZPilj2gy8c4XUWFuQ&usqp=CAU",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 8,
                            ProducerId=4,
                            MovieCategory = Enum.MovieCategory.Documentary
                        }
                        ,new Movie
                        {
                            Name = "Forrest Gump",
                            Description = "Forrest Gump, American film, released in 1994, that chronicled 30 years",
                            Price = 125,
                            ImageUrl = "https://i.guim.co.uk/img/media/78eb1f6bd0f92d4d3cf19f5bddda1a902e2a6fcd/0_95_2371_1422/master/2371.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=4b18b0ace0dfc010f3a2fba9aa797665",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(7),
                            CinemaId = 5,
                            ProducerId=5,
                            MovieCategory = Enum.MovieCategory.Comedy
                        }

                    });
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>
                    {
                        new Actor_Movie
                        {
                           ActorId = 6,
                           MovieId = 6
                        },
                        new Actor_Movie
                        {
                           ActorId = 7,
                           MovieId = 6
                        },
                        new Actor_Movie
                        {
                           ActorId = 8,
                           MovieId = 7
                        },
                        new Actor_Movie
                        {
                           ActorId = 9,
                           MovieId = 7
                        },
                        new Actor_Movie
                        {
                           ActorId = 10,
                           MovieId = 8
                        },
                        new Actor_Movie
                        {
                           ActorId = 6,
                           MovieId = 8
                        },
                        new Actor_Movie
                        {
                           ActorId = 7,
                           MovieId = 9
                        },
                        new Actor_Movie
                        {
                           ActorId = 8,
                           MovieId = 9
                        },
                        new Actor_Movie
                        {
                           ActorId = 9,
                           MovieId = 10
                        },
                        new Actor_Movie
                        {
                           ActorId = 10,
                           MovieId = 10
                        },
                        new Actor_Movie
                        {
                           ActorId = 6,
                           MovieId = 11
                        },
                        new Actor_Movie
                        {
                           ActorId = 7,
                           MovieId = 11
                        },
                        new Actor_Movie
                        {
                           ActorId = 8,
                           MovieId = 12
                        },new Actor_Movie
                        {
                           ActorId = 9,
                           MovieId = 12
                        },
                        new Actor_Movie
                        {
                           ActorId = 10,
                           MovieId = 13
                        },
                        new Actor_Movie
                        {
                           ActorId = 6,
                           MovieId = 13
                        },
                        new Actor_Movie
                        {
                           ActorId = 7,
                           MovieId = 13
                        }
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
