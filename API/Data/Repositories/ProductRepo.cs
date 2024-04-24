using API.Data.Entities;
using API.Data.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace API.Data.Repositories
{
    public class ProductRepo : IProoductRepo
    {
        private readonly StoreContext _context;
        public ProductRepo(StoreContext context)
        {
            _context = context;
        }
        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IQueryable<Product>> GetProducts()
        {
            var products =  _context.Products;

            return await Task.FromResult(products);
        }
    }
}
