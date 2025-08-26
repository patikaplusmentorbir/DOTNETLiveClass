namespace CustomIdentityWithJwt.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }

       
    }

    public enum UserType
    {
        User, Admin
    }
}
