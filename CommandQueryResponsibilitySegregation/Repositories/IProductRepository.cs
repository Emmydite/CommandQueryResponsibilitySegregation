using CommandQueryResponsibilitySegregation.Models;

namespace CommandQueryResponsibilitySegregation.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> ProductList();
        public Task<Product> GetProductById(int Id);
        public Task<Product> AddProduct(Product studentDetails);
        public Task<int> UpdateProduct(Product studentDetails);
        public Task<int> DeleteProduct(int Id);
    }
}
