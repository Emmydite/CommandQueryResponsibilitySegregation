using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
