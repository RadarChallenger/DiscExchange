using DiscExchanges.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiscExchanges.Repositories;

public class ApiDbContext : DbContext
{
    public virtual DbSet<ListingEntity> Listings { get; set; } = null!;
    public virtual DbSet<MovieEntity> Movies { get; set; } = null!;
    public virtual DbSet<UserEntity> Users { get; set; } = null!;

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
            .HasMany(e => e.Listings)
            .WithOne(e => e.Owner)
            .HasForeignKey(e => e.OwnerId)
            .IsRequired();

        modelBuilder.Entity<MovieEntity>()
            .HasOne(e => e.Listing)
            .WithOne(e => e.Movie)
            .HasForeignKey<ListingEntity>(e => e.MovieId)
            .IsRequired();
    }
}