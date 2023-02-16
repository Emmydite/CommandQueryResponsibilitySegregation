using CommandQueryResponsibilitySegregation.Repositories;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class DeleteProductHandler
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository
        }
    }
}
