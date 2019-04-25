using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return; //Database has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Titlt = "Love & Basketball",
                        ReleaseDate = DateTime.Parse("2000-16-04"),
                        Genre = "Drama/Sport",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Titlt = "Sister Act 2: Back in the Habit",
                        ReleaseDate = DateTime.Parse("1993-10-12"),
                        Genre = "Music/Musical",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Titlt = "Poetic Justice",
                        ReleaseDate = DateTime.Parse("1993-23-07"),
                        Genre = "Drama/Romance",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Titlt = "Last Holiday",
                        ReleaseDate = DateTime.Parse("2006-13-01"),
                        Genre = "Drama/Romance",
                        Price = 9.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
