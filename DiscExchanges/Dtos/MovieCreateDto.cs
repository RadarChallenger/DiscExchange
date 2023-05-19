using System.ComponentModel.DataAnnotations;

namespace DiscExchanges.Dtos;

public class MovieCreateDto
{
    [Required]
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public string Format { get; set; }
}