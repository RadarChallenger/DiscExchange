namespace DiscExchanges.Dtos;

public class ListingCreateDto
{
    public int OwnerId { get; set; }
    public int MovieId { get; set; }
    public decimal Price { get; set; }
    public bool Selling { get; set; }
}