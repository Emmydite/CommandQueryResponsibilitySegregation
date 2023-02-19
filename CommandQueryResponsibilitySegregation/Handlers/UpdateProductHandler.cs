using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


    }
}
