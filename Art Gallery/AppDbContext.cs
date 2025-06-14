using Art_Gallery.Model;
using Art_Gallery.Model.ArtPieceItems;
using Art_Gallery.Model.CategoryItems;
using Art_Gallery.Model.CustomerItems;
using Microsoft.EntityFrameworkCore;

namespace Art_Gallery
{
    public class AppDbContext : DbContext
    { 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArtPiece>().Property(a => a.ArtPiecePrice).HasPrecision(18, 2);
            modelBuilder.Entity<LoyaltyCard>().Property(a => a.Balance).HasPrecision(18, 2);
        }
        public DbSet<ArtPiece> ArtPieces { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
