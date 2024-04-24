using API.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Data.Repositories.Contracts
{
    public interface IProoductRepo
    {
        Task<IQueryable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
