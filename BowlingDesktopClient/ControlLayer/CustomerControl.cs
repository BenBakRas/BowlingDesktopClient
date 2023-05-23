using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BowlingDesktopClient.ControlLayer
{
    public class CustomerControl
    {
        readonly ICustomerAccess _cAccess;

        public CustomerControl()
        {
            _cAccess = new CustomerServiceAccess();
        }

        public async Task<List<Customer>?> GetAllCustomers()
        {
            List<Customer>? foundCustomers = null;
            if (_cAccess != null)
            {
                foundCustomers = await _cAccess.GetCustomers();
            }
            return foundCustomers;
        }

        public async Task<int> SaveCustomer(string fName, string lName, string email, string mPhone)
        {
            Customer newCustomer = new(fName, lName, email, mPhone);
            int insertedId = await _cAccess.SaveCustomer(newCustomer);
            return insertedId;
        }
        public async Task<bool> DeleteCustomer(int customerId)
        {
            if (_cAccess != null)
            {
                return await _cAccess.DeleteCustomer(customerId);
            }
            return false;
        }

        public async Task<bool> UpdateCustomer(int id, Customer customerToUpdate)
        {
            bool isUpdated = false;

            if (_cAccess != null)
            {
                isUpdated = await _cAccess.UpdateCustomer(id, customerToUpdate);
            }

            return isUpdated;
        }

        public async Task<Customer?> FindCustomerByPhone(string customerPNO)
        {
            Customer? foundCustomer = null;

            if (_cAccess != null)
            {
                foundCustomer = await _cAccess.FindCustomerByPhone(customerPNO);
            }

            return foundCustomer;
        }


    }
}
