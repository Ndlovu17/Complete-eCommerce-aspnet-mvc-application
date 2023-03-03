using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServiceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Clearwater New Metro",
                            Logo = "~/images/Clearwater.jpg",
                            Description = "Based in Roodepoort in the upper surbubs area."
                        },

                        new Cinema()
                        {
                            Name = "Cresta Mall New Metro",
                            Logo = "~/images/Crester.jpg",
                            Description = "Based in Randburg North Cliff."
                        },


                        new Cinema()
                        {
                            Name = "Westgate Mall New Metro",
                            Logo = "~/images/Westgate.jpg",
                            Description = "Based in Roodepoort in Horizon View area."
                        }
                    });

                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureURL = "~/images/eddie-murphy-gettyimages.jpg",
                            FullName = "Eddie Murphy",
                            Bio = "Edward Regan Murphy is an American actor, comedian, writer, producer, and singer. He rose to " +
                            "fame on the sketch comedy show Saturday Night Live, for which he was a regular cast member from 1980 to 1984."
                        },

                        new Actor()
                        {
                            ProfilePictureURL = "~/images/GerardButler.jpg",
                            FullName = "Gerard Butler",
                            Bio = "Gerard James Butler is a Scottish actor and film producer. After studying law, he turned to " +
                            "acting in the mid-1990s with small roles in productions such as Mrs Brown, the James Bond film Tomorrow " +
                            "Never Dies, and Tale of the Mummy."
                        },

                        new Actor()
                        {
                            ProfilePictureURL = "~/images/MartinLawrence.jpg",
                            FullName = "Martin Lawrence",
                            Bio = "Martin Fitzgerald Lawrence is an American comedian and actor. He came to fame during the 1990s, " +
                            "establishing a Hollywood career as a leading actor. He got his start playing Maurice Warfield in " +
                            "What's Happening Now."
                        },

                        new Actor()
                        {
                            ProfilePictureURL = "~/images/Leonardo.jpg",
                            FullName = "Leonardo DeCaprio",
                            Bio = "Leonardo Wilhelm DiCaprio is an American actor and film producer. Known for his work as a " +
                            "leading man in biopics and period films, he is the recipient of numerous accolades " +
                            "a British Academy Film Award, and three Golden Globe Awards"
                        }


                    }); ; ; ;
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProfilePictureURL = "~/images/JamesCameron.jpg",
                            FullName = "James Cameron",
                            Bio = "James Francis Cameron CC is a Canadian filmmaker. A major figure in the post-New Hollywood era, " +
                            "he is considered one of the industry's most innovative filmmakers and " +
                            "cinematic capability with his use of novel technologies"
                        },

                        new Producer()
                        {
                            ProfilePictureURL = "~/images/KurtWimmer.jpg",
                            FullName = "Kurt Wimmer",
                            Bio = "Kurt Wimmer (born 1964) is an American screenwriter, film producer and film director. Kurt Wimmer." +
                            " Born, 1964 (age 58–59). Honolulu, Hawaii, United States.."
                        },

                        new Producer()
                        {
                            ProfilePictureURL = "~/images/MartinLawrence.jpg",
                            FullName = "Martin Lawrence",
                            Bio = "Martin Fitzgerald Lawrence is an American comedian and actor. He came to fame during the 1990s, " +
                            "establishing a Hollywood career as a leading actor. He got his start playing Maurice Warfield in " +
                            "What's Happening Now."
                        },

                        new Producer()
                        {
                            ProfilePictureURL = "~/images/Leonardo.jpg",
                            FullName = "Leonardo DeCaprio",
                            Bio = "Leonardo Wilhelm DiCaprio is an American actor and film producer. Known for his work as a " +
                            "leading man in biopics and period films, he is the recipient of numerous accolades,  " +
                            "a British Academy Film Award, and three Golden Globe Awards"
                        }


                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            ImageUrl = "~/images/Law_abiding_citizen.jpg",
                            Name = "Law Abiding Citizen",
                            Description = "The film takes place in Philadelphia, telling the story of a man driven to seek justice while " +
                            "targeting not only his family's killer but also those who have supported a corrupt criminal justice system.",
                            StartDate = Convert.ToDateTime("22-Mar-2023"),
                            EndDate = Convert.ToDateTime("22-Apr-2023"),
                            Price = 150.00,
                            CinemaId = 1,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Drama

                        },

                         new Movie()
                        {
                            ImageUrl = "~/images/Titanic.jpg",
                            Name = "Titanic",
                            Description = "Titanic is a 1997 American epic romance and disaster film directed, " +
                            "Incorporating both historical and fictionalized aspects, it is based on accounts of the sinking of the RMS Titanic and stars",
                            StartDate = Convert.ToDateTime("22-Mar-2023"),
                            EndDate = Convert.ToDateTime("22-Apr-2023"),
                            Price = 150.00,
                            CinemaId = 2,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama

                        },
                        new Movie()
                        {
                            ImageUrl = "~/images/Titanic.jpg",
                            Name = "Titanic",
                            Description = "Titanic is a 1997 American epic romance and disaster film directed, " +
                            "Incorporating both historical and fictionalized aspects, it is based on accounts of the sinking of the RMS Titanic and stars ",
                            StartDate = Convert.ToDateTime("22-Mar-2023"),
                            EndDate = Convert.ToDateTime("22-Apr-2023"),
                            Price = 150.00,
                            CinemaId = 3,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama

                        },




                    });
                    context.SaveChanges();
                }

                //Actors and Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 3
                        },

                         new Actor_Movie()
                         {
                             ActorId = 8,
                             MovieId = 4
                         }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
