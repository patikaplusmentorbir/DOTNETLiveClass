namespace EFCore_Relationss.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }



        // Relational Property
        public UserDetailEntity UserDetail { get; set; }
        public List<OrderDetailEntity> OrderDetails { get; set; }

    }
}
