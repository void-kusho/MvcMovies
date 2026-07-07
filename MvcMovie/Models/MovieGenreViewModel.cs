using Microsoft.AspNetCore.Mvc.Rendering;

namespace GabrielMovies.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public SelectList? Years { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
    public int? ReleaseYear { get; set; }
}
