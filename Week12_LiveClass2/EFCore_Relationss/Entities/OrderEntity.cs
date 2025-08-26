namespace EFCore_Relationss.Entities
{
    public class OrderEntity : BaseEntity
    {

        // Relational Property

        public List<OrderDetailEntity> OrderDetails { get; set; }
    }
}
