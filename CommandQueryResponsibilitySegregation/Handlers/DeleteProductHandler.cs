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

        public Task<int> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductById(command.Id);
            if (product == null)
                return default;

        }
    }
}
