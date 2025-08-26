namespace EFCore_Basic.Entities
{
    public class CalisanEntity : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public decimal Maas { get; set; }

    }
}
