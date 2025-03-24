using Domain.Entity;
using Domain.Response;

namespace Infrastructure.Interfaces;

public interface IOrderService
{
    Task<Response<string>> AddOrderAsync(Order order);
    Task<Response<string>> UpdateOrderAsync(Order order);
    Task<Response<string>> DeleteOrderAsync(int orderId);
    Task<Response<Order>> GetOrderByIdAsync(int orderId);
    Task<Response<List<Order>>> GetOrdersAsync();
}