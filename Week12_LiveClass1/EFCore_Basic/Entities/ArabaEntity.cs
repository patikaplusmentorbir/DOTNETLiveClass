namespace EFCore_Basic.Entities
{
    public class ArabaEntity : BaseEntity
    {
        public DateTime UretimTarihi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

    }
}
