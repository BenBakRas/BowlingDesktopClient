using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    internal interface ICustomerService
    {
        // CRUD metoder for Customer
        Task<ApiResponse<List<Customer>>> GetCustomersAsync();
        Task<ApiResponse<Customer>> CreateCustomerAsync(Customer customer);
        Task<ApiResponse<Customer>> UpdateCustomerAsync(int id, Customer customer);
        Task<ApiResponse<bool>> DeleteCustomerAsync(int id);
    }
}
