namespace backend.Data
{
    public class Quantity
    {
        public int QuantityOfProduct { get; set; }

        public int SizeId { get; set; }
        public Guid ProductId { get; set; }
        public int ColorId { get; set; }
        //relationship

        public Size Size { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }

    }
}
