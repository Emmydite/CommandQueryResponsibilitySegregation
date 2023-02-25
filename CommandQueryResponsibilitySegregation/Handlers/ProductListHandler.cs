using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class ProductListHandler : IRequestHandler<ProductListQuery, List<Product>>
    {
        private readonly IProductRepository _productRepository;
        public ProductListHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> Handle(ProductListQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.ProductList();
        }
    }
}
