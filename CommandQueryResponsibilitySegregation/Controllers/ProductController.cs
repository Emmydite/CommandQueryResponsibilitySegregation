using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandQueryResponsibilitySegregation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Product>> GetProductList()
        {
            var productList = await _mediator.Send(new ProductListQuery());

            return productList;
        }

        [HttpGet("productId")]
        public async Task<Product> GetProductById(int productId)
        {
            var product = await _mediator.Send(new ProductByIdQuery() { Id = productId });

            return product;
        }

        [HttpPost]
        public async Task<Product> AddProduct(Product productDetails)
        {
            var product = await _mediator.Send(new CreateProductCommand(
                productDetails.ProductName,
                productDetails.ProductSKU,
                productDetails.Price));

            return product;
        }

        public async Task<int> UpdateProduct(Product productDetails)
        {
            
        }
    }
}
