using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class ProductListHandler : IRequestHandler<ProductListQuery, Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductListHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


    }
}
