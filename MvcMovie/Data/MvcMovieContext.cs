using Microsoft.EntityFrameworkCore;
using GabrielMovies.Models;

namespace GabrielMovies.Data;

public class GabrielMoviesContext : DbContext
{
    public GabrielMoviesContext(DbContextOptions<GabrielMoviesContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; } = default!;
}
