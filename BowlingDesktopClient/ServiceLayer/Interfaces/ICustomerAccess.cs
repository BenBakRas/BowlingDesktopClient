﻿using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface ICustomerAccess
    {
        Task<List<Customer>?>? GetCustomers(int id = -1);
        Task<int> SaveCustomer(Customer customerToSave);
        public Task<bool> DeleteCustomer(int customerId);
        public Task<bool> UpdateCustomer(int id, Customer customerToUpdate);
        Task<Customer?> FindCustomerByPhone(string phone);



    }
}
