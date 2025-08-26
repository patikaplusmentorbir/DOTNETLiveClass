

using EFCore_Basic.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Basic.Context
{
    public class PatikaGaleriContext : DbContext
    {
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=SRTN-NOTEBOOK\SQLEXPRESS; database=PatikaGaleriDb; Trusted_Connection=true; TrustServerCertificate=true;");
            // Projemin hangi adresteki dbye bağlanacağını belirttiğim yer.


            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ArabaEntity> Arabalar => Set<ArabaEntity>();
        public DbSet<CalisanEntity> Calisanlar => Set<CalisanEntity>();



    }
}
