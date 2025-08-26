using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Relationss.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

 
        public int CategoryId { get; set; }

        // Relational Property
        public CategoryEntity Category { get; set; }
        public List<OrderDetailEntity> OrderDetails { get; set; }
    }
}
