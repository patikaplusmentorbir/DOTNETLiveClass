namespace EFCore_Relationss.Entities
{

    // Hangi kullanıcı
    // Hangi üründen
    // Kaç tane
    // Toplam kaç para 
    public class OrderDetailEntity : BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }



        // Relational Property

        public UserEntity User { get; set; }
        public ProductEntity Product { get; set; }
        public OrderEntity Order { get; set; }
    }
}
