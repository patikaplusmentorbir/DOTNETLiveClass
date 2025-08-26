using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Entities;
using CustomIdentityWithJwt.Repositories;
using CustomIdentityWithJwt.Services;

namespace CustomIdentityWithJwt.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IRepository<ProductEntity> _productRepository;
        public ProductManager(IRepository<ProductEntity> productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(ProductAddDto product)
        {
            var productEntity = new ProductEntity
            {
                Name = product.Name,
            };

            _productRepository.Add(productEntity);
        }
    }
}
