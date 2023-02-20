using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductById(command.Id);
            if (product == null)
                return default;

            product.ProductName = command.ProductName;
            product.ProductSKU = command.ProductSKU;
            product.Price = command.Price;

            return await _productRepository.UpdateProduct(product);
        }
    }
}
