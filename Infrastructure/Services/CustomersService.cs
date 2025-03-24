using Domain.Entity;
using Domain.Response;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CustomersService : ICustomerService
{
    public Task<Response<string>> AddCustomerAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Response<string>> DeleteCustomerAsync(int customerId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<string>> UpdateCustomerAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Customer>> GetCustomerByIdAsync(int customerId)
    {
        throw new NotImplementedException();
    }

    public Task<Response<List<Customer>>> GetCustomersAsync()
    {
        throw new NotImplementedException();
    }
}