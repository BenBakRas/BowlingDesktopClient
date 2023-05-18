using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
