using CustomIdentityWithJwt.Dtos;

namespace CustomIdentityWithJwt.Services
{
    public interface IProductService 
    {
        void AddProduct(ProductAddDto product);
    }
}
