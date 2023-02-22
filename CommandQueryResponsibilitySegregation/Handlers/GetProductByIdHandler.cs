using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<ProductByIdQuery, Product>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductById(request.Id);
        }
    }
}
