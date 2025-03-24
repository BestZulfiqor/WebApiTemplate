using Domain.Entity;
using Domain.Response;

namespace Infrastructure.Interfaces;

public interface IProductService
{
    Task<Response<string>> AddProductAsync(Product product);
    Task<Response<List<Product>>> GetAllProductsAsync();
    Task<Response<string>> UpdateProductAsync(Product product);
    Task<Response<string>> DeleteProductAsync(int productId);
    Task<Response<Product>> GetProductByIdAsync(int productId);
}