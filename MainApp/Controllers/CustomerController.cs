using Domain.Entity;
using Domain.Response;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomerController
{
    private readonly CustomersService _customersService = new();
    [HttpGet]
    public async Task<Response<List<Customer>>> GetCustomers()
    {
        var customers = await _customersService.GetCustomersAsync();
        return customers;
    }
}