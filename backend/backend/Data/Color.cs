namespace backend.Data
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        //relationship
        public Product Product { get; set; }
        public ICollection<Quatity> Quatities { get; set; }
    }
}
