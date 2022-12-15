namespace backend.Data
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //relation ship
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
