using CommandQueryResponsibilitySegregation.Data;
using CommandQueryResponsibilitySegregation.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryResponsibilitySegregation.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> AddProduct(Product productDetails)
        {
            var result = _dbContext.Products.Add(productDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteProduct(int Id)
        {
            var product = _dbContext.Products.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Products.Remove(product);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> GetProductById(int Id)
        {
            return await _dbContext.Products.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Product>> ProductList()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<int> UpdateProduct(Product productDetails)
        {
            _dbContext.Products.Update(productDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
