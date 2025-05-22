using Microsoft.AspNetCore.Mvc;
using TH01.Data;
using TH01.Models.Interfaces;

namespace TH01.Models.Services
{
    public class ProductRepository : IProductRepository

    {
        private CoffeeshopDbContext dbContext;
        public ProductRepository(CoffeeshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }
        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public string GetProductName(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }

    }
}