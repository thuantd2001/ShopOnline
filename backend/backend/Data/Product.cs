namespace backend.Data
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public int StatusId { get; set; }
        public Guid DiscountId { get; set; }
        //relationship
        public Category Category { get; set; }
        public Status Status { get; set; }
        public Discount Discount { get; set; }

        public ICollection<Color> Colors { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<Quatity> Quatities { get; set; }
    }
}
