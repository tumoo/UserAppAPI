using API.Services.Models.Response;

namespace API.Services.Contracts
{
    public interface IProductService
    {
        Task<List<ProductResponseDM>> GetProducts();
        Task<ProductResponseDM> GetProduct(int id);
    }
}
