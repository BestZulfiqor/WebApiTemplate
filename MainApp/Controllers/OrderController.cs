using Domain.Entity;
using Domain.Response;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class OrderController
{
    private readonly OrdersService _ordersService = new();
    [HttpGet]
    public async Task<Response<List<Order>>> GetAllProductsAsync()
    {
        var orders = await _ordersService.GetOrdersAsync();
        return orders;
    }
}