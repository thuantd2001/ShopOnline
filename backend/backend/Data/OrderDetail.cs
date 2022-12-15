namespace backend.Data
{
    public class OrderDetail
    {

        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int ColorID { get; set; }
        public int SizeId { get; set; }

        // relationship
        public Order Order { get; set; }
    }
}
