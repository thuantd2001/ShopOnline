namespace backend.Data
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double DiscountPercent { get; set; }
        public DateTime ModifitedAt { get; set; }
        public DateTime ExpireAt { get; set; }

        //relationship
        public ICollection<Product> Products { get; set; }
    }
}
