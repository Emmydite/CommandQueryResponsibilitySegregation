using CommandQueryResponsibilitySegregation.Repositories;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class CreateProductHandler
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
