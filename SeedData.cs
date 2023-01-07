using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieProject.Data;
using System;
using System.Linq;

namespace MovieProject.Models
{
    public class SeedData
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
                var movies = new Movie[]
                {
                    new Movie { Title="Titanic", EngTitle="Titanic", Description = "Romantic", Age = "18",DurationMin = 180,Price=100,OpeningDate = DateTime.Parse("2005-09-01")},
                    new Movie { Title="Avengers", EngTitle="Titanic", Description = "Romantic", Age = "18",DurationMin = 180,Price=100,OpeningDate = DateTime.Parse("2005-09-01")},
                    new Movie { Title="Doremon", EngTitle="Titanic", Description = "Romantic", Age = "18",DurationMin = 180,Price=100,OpeningDate = DateTime.Parse("2005-09-01")},
                };
                foreach (Movie m in movies)
                {
                    context.Movies.Add(m);
                }
                context.SaveChanges();
                var categorys = new Category[]
                {
                    new Category { CategoryName = "Romantic"},

                    new Category { CategoryName = "Action"},

                    new Category { CategoryName = "Fiction"},

                };
                foreach (Category c in categorys) {
                    context.Categories.Add(c);
                
                }
                context.SaveChanges();
                var actors = new Actor[]
                {
                    new Actor {ActorName = "Jack",EngActor = "Jack"},

                    new Actor {ActorName = "Jonh",EngActor = "Jonh"},

                    new Actor {ActorName = "Jully",EngActor = "Jully"},
                };
                foreach (Actor a in actors) {
                context.Actors.Add(a);
                }
                context.SaveChanges();

                var directors = new Director[]
                { 
                    new Director {DirectorName= "Rose", EngDirector = "Rose"},


                    new Director {DirectorName= "Rosi", EngDirector = "Rosi"},


                    new Director {DirectorName= "Rosu", EngDirector = "Rosu"}
                };
                foreach (Director d in directors) 
                {
                    context.Directors.Add(d);
                }
                context.SaveChanges();
                var movieCategorys = new MovieCategory[]
                {
                    new MovieCategory {MovieId = movies.Single(m => m.Title == "Titanic").Id,CategoryId = categorys.Single(c=> c.CategoryName == "Romantic").Id},
                    new MovieCategory {MovieId = movies.Single(m => m.Title == "Avengers").Id,CategoryId = categorys.Single(c=>c.CategoryName == "Action").Id},
                    new MovieCategory {MovieId = movies.Single(m => m.Title == "Titanic").Id,CategoryId = categorys.Single(c=> c.CategoryName == "Action").Id},

                };
                foreach (MovieCategory mc in movieCategorys)
                {
                    context.MoviesCategories.Add(mc);
                }
                context.SaveChanges();

            }
        }
    }
}
