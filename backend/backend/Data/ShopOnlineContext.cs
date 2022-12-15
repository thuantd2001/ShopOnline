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
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }




        #endregion
        #region modelBuider
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
                e.Property(p => p.Description).HasColumnType("text");

                e.HasOne(p => p.Category).WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);

                e.HasOne(p => p.Discount).WithMany(p => p.Products)
                .HasForeignKey(p => p.DiscountId);

                e.HasOne(p => p.Status).WithMany(p => p.Products)
                .HasForeignKey(p => p.StatusId);

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
            modelBuilder.Entity<Quantity>(e =>
            {
                e.ToTable("Quatity");
                e.HasKey(q => new { q.ProductId, q.ColorId, q.SizeId });

                // product
                e.HasOne(q => q.Product).WithMany(q => q.Quantities)
                .HasForeignKey(q => q.ProductId)
                .HasConstraintName("FK_Quantity_Product")
                .OnDelete(DeleteBehavior.ClientSetNull);


                //color
                e.HasOne(q => q.Color).WithMany(q => q.Quantities)
                .HasForeignKey(q => q.ColorId)
                .HasConstraintName("FK_Quantity_Color")
                .OnDelete(DeleteBehavior.ClientSetNull);

                //Size
                e.HasOne(q => q.Size).WithMany(q => q.Quantities)
                .HasForeignKey(q => q.SizeId)
                .HasConstraintName("FK_Quantity_Size")
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<ProductImage>(e =>
            {
                e.ToTable("ProductImage");
                e.HasKey(p => p.Id);

                e.HasOne(p => p.Product).WithMany(p => p.ProductImages)
                .HasForeignKey(p => p.ProductId);

                e.Property(p => p.ImgUrl).HasColumnType("text");
            });
            modelBuilder.Entity<Discount>(e =>
            {
                e.ToTable("Discount");
                e.HasKey(d => d.Id);

            });
            modelBuilder.Entity<Order>(e =>
            {
                e.ToTable("Order");
                e.HasKey(o => o.Id);
                e.Property()
            });
        }
        #endregion

    }
}
