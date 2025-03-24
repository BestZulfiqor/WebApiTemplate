using Domain.Entity;
using Domain.Response;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class OrdersService : IOrderService
{
    public Task<Response<string>> AddOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<Response<string>> UpdateOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<Response<string>> DeleteOrderAsync(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Order>> GetOrderByIdAsync(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<List<Order>>> GetOrdersAsync()
    {
        throw new NotImplementedException();
    }
}