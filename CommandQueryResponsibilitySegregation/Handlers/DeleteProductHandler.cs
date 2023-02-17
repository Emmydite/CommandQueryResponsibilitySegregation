using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Repositories;
using MediatR;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
