using EF_Crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Crud.Context
{
    public class PatikaGaleriContext :DbContext
    {
        public PatikaGaleriContext(DbContextOptions<PatikaGaleriContext> options) : base(options)
        {
            
        }




        public DbSet<CarEntity> Cars => Set<CarEntity>();
    }
}
