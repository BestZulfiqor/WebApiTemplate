using Domain.Entity;
using Domain.Response;

namespace Infrastructure.Interfaces;

public interface ICustomerService
{
    Task<Response<string>> AddCustomerAsync(Customer customer);
    Task<Response<string>> DeleteCustomerAsync(int customerId);
    Task<Response<string>> UpdateCustomerAsync(Customer customer);
    Task<Response<Customer>> GetCustomerByIdAsync(int customerId);
    Task<Response<List<Customer>>> GetCustomersAsync();
}