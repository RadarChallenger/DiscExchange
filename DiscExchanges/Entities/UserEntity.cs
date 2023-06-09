namespace DiscExchanges.Entities;

public class UserEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public ICollection<ListingEntity> Listings { get; } = new List<ListingEntity>();
}