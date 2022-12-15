namespace backend.Data
{
    public class Size
    {
        public int Id { get; set; }
        public int ColorName { get; set; }
        //realationship
        public Category SizeCategory { get; set; }
        public ICollection<Quantity> Quantities { get; set; }
    }
}
