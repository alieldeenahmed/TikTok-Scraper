using Microsoft.EntityFrameworkCore;
using TikTokTasteProfiler.Models;

namespace TikTokTasteProfiler.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TikTokAccount> Accounts => Set<TikTokAccount>();
    public DbSet<Repost> Reposts => Set<Repost>();
    public DbSet<TasteProfile> TasteProfiles => Set<TasteProfile>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TikTokAccount>()
            .HasIndex(a => a.Handle)
            .IsUnique();
    }
}
 