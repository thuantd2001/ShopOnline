namespace backend.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // relatioship
        public ICollection<Size> Sizes { get; set; }
        public ICollection<Product> Products { get; set; }

        //{
        //    OrderDetails = new List<OrderDetail>();
        //} 
    }
}
