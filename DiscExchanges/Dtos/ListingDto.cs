namespace DiscExchanges.Dtos;

public class ListingDto
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int MovieId { get; set; }
    public decimal Price { get; set; }
    public bool Selling { get; set; }
}