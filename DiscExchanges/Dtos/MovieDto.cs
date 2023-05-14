namespace DiscExchanges.Dtos;

public class MovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public string Format { get; set; }
    public decimal Price { get; set; }
    public string Genre { get; set; }
    public string RegionCode { get; set; }
    public string Condition { get; set; }
}