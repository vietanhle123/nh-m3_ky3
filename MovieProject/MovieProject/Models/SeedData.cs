using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieProject.Data;
using System;
using System.Linq;

namespace MovieProject.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MovieProjectContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MovieProjectContext>>()))
        {
            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

          


            var Accounts = new Account[]
            {
                new Account {Username="acu", Password="123"}
            };
            foreach ( Account s in Accounts)
            { context.Accounts.Add(s);
            }
            context.SaveChanges();


            var Actors = new Actor[]
            {
                new Actor { ActorName="huy", EngActor="mr.huy"},
                 new Actor { ActorName="v.anh", EngActor="mr.anh"},
                  new Actor { ActorName="nam", EngActor="mr.nam"}

            };
            foreach (Actor i in Actors )
            { context.Actors.Add(i); }
            context.SaveChanges();


         

            var Movies = new Movie[]
            {
                new  Movie{Title="nam", EngTitle="mr.cam",Description="ads" ,Age="13",DurationMin=180 ,Price=200,
                OpeningDate = DateTime.Parse("2010-09-01") , Trailer ="sap ra thoi", MainImg="", ThumbnailImg=""

            }
            };
            foreach (Movie d in Movies)
            {
                context.Movies.Add(d);
            }
            context.SaveChanges();


   var movieActors = new Casting[]
            {
                new Casting {MovieId= Movies.Single(d => d.Title == "nam" ).Id,ActorId = Actors.Single(i=> i.ActorName == "huy").Id , Cast="v.anh"}

            };
            foreach (Casting g in movieActors)
            {
                context.Castings.Add(g);
            }
            context.SaveChanges();



            var Categorys = new Category[]
            {
            new Category {CategoryName="truong"}
            };
            foreach (Category o in Categorys)
            {
                context.Categories.Add(o);
            }
            context.SaveChanges();


            var Directors = new Director[]
            {
                new Director {DirectorName="hiep", EngDirector="abc"}
            };
            foreach (Director p in Directors)
            {
                context.Directors.Add(p);

            }
            context.SaveChanges();


            var movieDirectors = new Directing[]
                {
                new Directing {MovieId= Movies.Single(d => d.Title == "nam" ).Id,DirectorId = Directors.Single(p => p.DirectorName =="hiep").Id }

                };
            foreach (Directing y in movieDirectors)
            {
                context.Directings.Add(y);
            }    
            context.SaveChanges();


            var moviesCategorys = new MovieCategory[]
                {
                new MovieCategory {MovieId= Movies.Single(d => d.Title == "nam" ).Id,CategoryId = Categorys.Single(o => o.CategoryName =="truong").Id }

                };
            foreach (MovieCategory u in moviesCategorys)
            {
                context.MoviesCategories.Add(u);
            }
            context.SaveChanges();


            var Users = new User[]
            {
                new User {Name="nam", Email="123@.com", DateOfBirth=DateTime.Parse("2010-09-01") ,PhoneNumber=012345, AccountId= Accounts.Single(s => s.Username == "acu").AccountId }

            };
              foreach (User t in Users)
            {
                context.Users.Add(t);
            }
              context.SaveChanges();

            var Votes = new Vote[]
            {
                new Vote {VoteName="AAA"}
            };
            foreach (Vote r in Votes)
            { context.Votes.Add(r); }    
       

        var userMovies = new Order[]
        {
            new Order {UserId= Users.Single(t=>t.Name == "nam").UserId,MovieId= Movies.Single(d => d.Title == "nam" ).Id,Price=100}
        };
            foreach (Order d in userMovies)
            {
                context.Orders.Add(d);
            }
            context.SaveChanges();


            var movieUserVotes = new Rating[]
                {
                    new Rating {MovieId= Movies.Single(d => d.Title == "nam" ).Id,UserId= Users.Single(t=>t.Name == "nam").UserId,VoteId= Votes.Single(r=>r.VoteName == "AAA").VoteId,Comment="tot"}

                };
            foreach (Rating h in movieUserVotes)
            { 
            context.Ratings.Add(h);
            }    
            context.SaveChanges();

            var TrailerContainers = new TrailerContainer[]
            {
                new TrailerContainer {MovieId= Movies.Single(d => d.Title == "nam" ).Id,PostingImg=""}
            };
            foreach (TrailerContainer e in TrailerContainers)
            {
                context.TrailerContainers.Add(e);
            }
            context.SaveChanges();  

 }
    }
}