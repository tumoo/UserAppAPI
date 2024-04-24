using API.Data;
using API.Data.Repositories.Contracts;
using API.Services.Contracts;
using API.Services.Models.Response;
using AutoMapper;
using System.Data.Entity;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProoductRepo _productRepo;
        private readonly IMapper _mapper;
        public ProductService(IProoductRepo productRepo,IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        public async Task<ProductResponseDM> GetProduct(int id)
        {
            var product = await _productRepo.GetProduct(id);
            return _mapper.Map<ProductResponseDM>(product);
        }

        public async Task<List<ProductResponseDM>> GetProducts()
        {
            try
            {
                var products = await _productRepo.GetProducts();
                var productsList = products.ToList();
                var mappedProducts = _mapper.Map<List<ProductResponseDM>>(productsList);
                return mappedProducts;
            }
            catch(Exception ex)
            {
              return new List<ProductResponseDM>();
            }  
        }
    }
}
