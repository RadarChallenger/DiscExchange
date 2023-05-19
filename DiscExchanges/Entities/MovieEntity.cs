namespace DiscExchanges.Entities;

public class MovieEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public string Format { get; set; }
    public string Genre { get; set; }
    public string RegionCode { get; set; }
    public string Condition { get; set; }
    public ListingEntity? Listing { get; set; }
}