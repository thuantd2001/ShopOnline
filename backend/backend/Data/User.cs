namespace backend.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        //relationship
        public ICollection<Order> Odrers { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }


    }
}
