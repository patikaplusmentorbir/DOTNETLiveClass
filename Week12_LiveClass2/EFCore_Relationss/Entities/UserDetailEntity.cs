namespace EFCore_Relationss.Entities
{
    public class UserDetailEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int UserId { get; set; }

        // Relational Property

        public UserEntity User { get; set; }
    }
}
