using System.ComponentModel.DataAnnotations.Schema;

namespace DiscExchanges.Entities;

public class ListingEntity
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public UserEntity Owner { get; set; } = null!;
    public int MovieId { get; set; }
    public MovieEntity Movie { get; set; } = null!;
    public decimal Price { get; set; }
    public bool Selling { get; set; }
}