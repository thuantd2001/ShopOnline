using Microsoft.EntityFrameworkCore;


namespace backend.Data
{
    public class ShopOnlineContext : DbContext
    {
        public ShopOnlineContext(DbContextOptions<ShopOnlineContext> opt) : base(opt) { }
        #region DbSet
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Quatity> Quatititys { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }



        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(e =>
            {
                e.ToTable("Category");
                e.HasKey(c => c.Id);
                e.Property(c => c.Name).IsRequired().HasMaxLength(120);

            });
            modelBuilder.Entity<Product>(e =>
            {
                e.ToTable("Product");
                e.HasKey(p => p.Id);
                e.Property(p => p.Name).HasMaxLength(255);
                e.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);
                e.HasOne(p => p.Discount).WithMany(p => p.Products).HasForeignKey(p => p.DiscountId);
                e.HasOne(p => p.Status).WithMany(p => p.Products).HasForeignKey(p => p.StatusId);

            });
            modelBuilder.Entity<Status>(e =>
            {
                e.ToTable("Status");
                e.HasKey(s => s.Id);
            });
            modelBuilder.Entity<Color>(e =>
            {
                e.ToTable("Color");
                e.HasKey(c => c.Id);
            });
            modelBuilder.Entity<Size>(e =>
            {
                e.ToTable("Size");
                e.HasKey(s => s.Id);
            });
        }
    }
}
