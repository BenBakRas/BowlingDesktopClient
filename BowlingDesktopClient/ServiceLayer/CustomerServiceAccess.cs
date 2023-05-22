using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.Models;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Text;


namespace BowlingDesktopClient.ServiceLayer
{
    public class CustomerServiceAccess : ICustomerAccess
    {
        readonly IServiceConnection _customerService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/customers";
        public CustomerServiceAccess()
        {
            _customerService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Customer>?>? GetCustomers(int id = -1)
        {
            List<Customer>? customersFromService = null;

            _customerService.UseUrl = _customerService.BaseUrl;
            bool hasValidId = (id > 0);
            if (hasValidId)
            {
                _customerService.UseUrl += id.ToString();
            }
            if (_customerService != null)
            {
                try
                {
                    var serviceResponse = await _customerService.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        if (hasValidId)
                        {
                            Customer? foundCustomer = JsonConvert.DeserializeObject<Customer>(content);
                            if (foundCustomer != null)
                            {
                                customersFromService = new List<Customer>() { foundCustomer };
                            }
                        }
                        else
                        {
                            customersFromService = JsonConvert.DeserializeObject<List<Customer>>(content);
                        }
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            customersFromService = new List<Customer>();
                        }
                        else
                        {
                            customersFromService = null;
                        }
                    }
                }
                catch
                {
                    customersFromService = null;
                }
            }
            return customersFromService;
        }
        public async Task<int> SaveCustomer(Customer customerToSave)
        {
            int insertedCustomerId = -1;
            //
            _customerService.UseUrl = _customerService.BaseUrl;
            try
            {
                var json = JsonConvert.SerializeObject(customerToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _customerService.CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse.IsSuccessStatusCode)
                {
                    if (serviceResponse.IsSuccessStatusCode)
                    {
                        string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                        Int32.TryParse(resIdString, out insertedCustomerId);
                    }
                    else
                    {
                        insertedCustomerId = -2;
                    }
                }
            }
            catch
            {
                insertedCustomerId = -3;
            }
            return insertedCustomerId;
        }
        public async Task<bool> DeleteCustomer(int customerId)
        {
            bool isDeleted = false;

            _customerService.UseUrl = $"{_customerService.BaseUrl}/{customerId}";

            try
            {
                var serviceResponse = await _customerService.CallServiceDelete();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    isDeleted = true;
                }
            }
            catch
            {
                isDeleted = false;
            }

            return isDeleted;
        }
        public async Task<bool> UpdateCustomer(Customer customerToUpdate)
        {
            bool isUpdated = false;

            _customerService.UseUrl = $"{_customerService.BaseUrl}/{customerToUpdate.Id}";

            try
            {
                var json = JsonConvert.SerializeObject(customerToUpdate);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _customerService.CallServicePut(content);
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    isUpdated = true;
                }
            }
            catch
            {
                isUpdated = false;
            }

            return isUpdated;
        }
        public async Task<Customer?> FindCustomerByPhone(string phone)
        {
            _customerService.UseUrl = $"{_customerService.BaseUrl}/{phone}";

            try
            {
                var serviceResponse = await _customerService.CallServiceGet();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    var content = await serviceResponse.Content.ReadAsStringAsync();
                    Customer foundCustomer = JsonConvert.DeserializeObject<Customer>(content);
                    return foundCustomer;
                }
            }
            catch
            {
                // Handle any exceptions here
            }

            return null; // Return null if the customer is not found or if there was an error
        }

    }
}
