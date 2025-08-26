using CustomIdentityWithJwt.Context;
using CustomIdentityWithJwt.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomIdentityWithJwt.Repositories
{

    // TEntity kısmına hangi tablo gelirse, o tablo için DB işlemleri yapılacak.

    // İstekler Controller'a düşüyor.
    // Controller Service/Manager çağırıyor.
    // Service/Manager hangi entity tipinde veri ile çalışıyorsa onu DB'ye  gönderecek olan Repository'i çekiyor.
    // Repository DB'ye erişiyor.

    // Repository neden var ?
    // DbContext içerisinde zaten mevcut olan veritabanı metotlarını istediğimiz gibi kullanmamızı sağlamak için. ( Editlemek , Kısıtlamak , Genişletmek ... )

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly CustomIdentityDbContext _db;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(CustomIdentityDbContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        // _dbSet yerine _db.Users -- _db.Products gibi yerleştirmeler gelecek.

        public void Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            _dbSet.Add(entity);
            _db.SaveChanges();

        }

        public void Delete(TEntity entity)
        {
           entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            _dbSet.Update(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
