namespace backend.Data
{
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        //realtion ship
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
