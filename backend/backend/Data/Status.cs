namespace backend.Data
{
    public class Status
    {
        public int Id { get; set; }
        public string Description { get; set; }
        // relatioship
        public ICollection<Product> Products { get; set; }
    }
}
