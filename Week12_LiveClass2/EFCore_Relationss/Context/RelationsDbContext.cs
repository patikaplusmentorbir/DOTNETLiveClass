using EFCore_Relationss.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Relationss.Context
{
    public class RelationsDbContext : DbContext
    {
        // 1
        public RelationsDbContext(DbContextOptions<RelationsDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // FLUENT API

            modelBuilder.Entity<OrderDetailEntity>().Ignore("Id");
            modelBuilder.Entity<OrderDetailEntity>().HasKey("ProductId", "UserId");
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<UserDetailEntity> UserDetails => Set<UserDetailEntity>();
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
        public DbSet<OrderEntity> Orders => Set<OrderEntity>();
        public DbSet<OrderDetailEntity> OrderDetails => Set<OrderDetailEntity>();
    }
}
