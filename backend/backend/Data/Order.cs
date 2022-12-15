namespace backend.Data
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime ShipDate { get; set; }
        public string ShipAdress { get; set; }
        public string Note { get; set; }
        public DateTime OrderDate { get; set; }
        public Boolean IsShipped { get; set; }

        // realtionship

        public User User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
