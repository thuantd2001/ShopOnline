namespace backend.Data
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
