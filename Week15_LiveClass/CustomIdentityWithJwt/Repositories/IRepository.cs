namespace CustomIdentityWithJwt.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Delete(int id);

        void Update(TEntity entity);

        TEntity GetById(int id);
    }
}

// IRepository<UserEntity>
// IRepository<ProductEntity>
// IRepository<CategoryEntity>
// IRepository<TeacherEntity>
