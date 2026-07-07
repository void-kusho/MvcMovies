using Microsoft.EntityFrameworkCore;
using GabrielMovies.Data;

namespace GabrielMovies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new GabrielMoviesContext(
            serviceProvider.GetRequiredService<DbContextOptions<GabrielMoviesContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Fantasy",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Two Towers",
                    ReleaseDate = DateTime.Parse("2002-12-18"),
                    Genre = "Fantasy",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 9.99M,
                    Rating = "PG-13"
                }
            );
            context.SaveChanges();
        }
    }
}
