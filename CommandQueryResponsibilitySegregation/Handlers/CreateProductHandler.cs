using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                ProductName = command.ProductName,
                ProductSKU = command.ProductSKU,
                Price = command.Price,
            };

            return await _productRepository.AddProduct(product);
        }
    }
}
