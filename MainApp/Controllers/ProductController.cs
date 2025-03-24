using Domain.Entity;
using Domain.Response;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductController
{
    private readonly ProductsService _productsService = new();
    [HttpGet]
    public async Task<Response<List<Product>>> GetAllProductsAsync()
    {
        var products = await _productsService.GetAllProductsAsync();
        return products;
    }
}