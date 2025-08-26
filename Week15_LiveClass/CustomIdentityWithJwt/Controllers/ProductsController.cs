using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Models;
using CustomIdentityWithJwt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentityWithJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Create(ProductAddRequest request)
        {
            var productDto = new ProductAddDto
            {
                Name = request.Name,
            };

            _productService.AddProduct(productDto);

            return Ok();
        }
    }
}
