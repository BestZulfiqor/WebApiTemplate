using Domain.Entity;
using Domain.Response;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ProductsService : IProductService
{
    public Task<Response<string>> AddProductAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Response<List<Product>>> GetAllProductsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Response<string>> UpdateProductAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Response<string>> DeleteProductAsync(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Product>> GetProductByIdAsync(int productId)
    {
        throw new NotImplementedException();
    }
}