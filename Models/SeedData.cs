using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
        {
            if (context.Movie.Any())
            {
                return;
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "TV-14",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Casa Blanca",
                    ReleaseDate = DateTime.Parse("1942-11-26"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Coco",
                    ReleaseDate = DateTime.Parse("2017-11-22"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Finding Nemo",
                    ReleaseDate = DateTime.Parse("2003-5-30"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Kingdom of Heaven",
                    ReleaseDate = DateTime.Parse("2005-5-6"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Fury",
                    ReleaseDate = DateTime.Parse("2014-10-17"),
                    Genre = "War",
                    Rating = "R",
                    Price = 10.99M
                }
            );
            context.SaveChanges();
        }
    }
}
