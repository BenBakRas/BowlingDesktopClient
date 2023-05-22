﻿using BowlingDesktopClient.ServiceLayer;
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

        public async Task<bool> UpdateCustomer(string fName, string lName, string email, string mPhone)
        {
            // Find the customer by ID
            Customer? customerToUpdate = await FindCustomerByPhone(mPhone);

            if (customerToUpdate != null)
            {
                // Update the customer's properties
                customerToUpdate.FirstName = fName;
                customerToUpdate.LastName = lName;
                customerToUpdate.Email = email;
                customerToUpdate.Phone = mPhone;

                // Call the update method in the service access layer
                return await _cAccess.UpdateCustomer(customerToUpdate);
            }

            return false;
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
