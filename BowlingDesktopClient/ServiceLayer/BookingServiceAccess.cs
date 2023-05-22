using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    public class BookingServiceAccess : IBookingAccess
    {
        readonly IServiceConnection _bookingService;
        readonly IServiceConnection _customerService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/bookings";
        readonly string _otherServiceBaseUrl = "https://localhost:7197/api/customers";
        public BookingServiceAccess()
        {
            _bookingService = new ServiceConnection(_serviceBaseUrl);
            _customerService = new ServiceConnection(_otherServiceBaseUrl);
        }

        public async Task<List<Booking>?>? GetBookings(int id = -1)
        {
            List<Booking>? bookingsFromService = null;

            _bookingService.UseUrl = _bookingService.BaseUrl;
            bool hasValidId = (id > 0);
            if (hasValidId)
            {
                _bookingService.UseUrl += id.ToString();
            }
            if (_bookingService != null)
            {
                try
                {
                    var serviceResponse = await _bookingService.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        if (hasValidId)
                        {
                            Booking? foundBooking = JsonConvert.DeserializeObject<Booking>(content);
                            if (foundBooking != null)
                            {
                                bookingsFromService = new List<Booking>() { foundBooking };
                            }
                        }
                        else
                        {
                            bookingsFromService = JsonConvert.DeserializeObject<List<Booking>>(content);
                        }
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            bookingsFromService = new List<Booking>();
                        }
                        else
                        {
                            bookingsFromService = null;
                        }
                    }
                }
                catch
                {
                    bookingsFromService = null;
                }
            }
            return bookingsFromService;
        }
        public async Task<int> SaveBooking(Booking bookingToSave)
        {
            int insertedBookingId = -1;

            try
            {
                CustomerServiceAccess csa = new CustomerServiceAccess();
                // Find customer by phone number
                Customer foundCustomer = await csa.FindCustomerByPhone(bookingToSave.Customer.Phone);

                if (foundCustomer != null)
                {
                    // Assign the found customer to the booking
                    bookingToSave.Customer = foundCustomer;

                    var json = JsonConvert.SerializeObject(bookingToSave);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var serviceResponse = await _bookingService.CallServicePost(content);
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        if (serviceResponse.IsSuccessStatusCode)
                        {
                            string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                            Int32.TryParse(resIdString, out insertedBookingId);
                        }
                        else
                        {
                            insertedBookingId = -2;
                        }
                    }
                }
                else
                {
                    insertedBookingId = -4; // Customer not found
                }
            }
            catch
            {
                insertedBookingId = -3;
            }

            return insertedBookingId;
        }

        public async Task<List<Booking>?> FindBookingsByCustomerPhone(string phone)
        {
            List<Booking>? bookings = null;

            try
            {
                // First, find the customer by phone number
                Customer? customer = await FindCustomerByPhone(phone);

                if (customer != null)
                {
                    bookings = new List<Booking>();

                    // Use the customer's ID to retrieve bookings associated with the customer
                    _bookingService.UseUrl = $"{_bookingService.BaseUrl}/customer/phone/{phone}";

                    var serviceResponse = await _bookingService.CallServiceGet();
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        bookings = JsonConvert.DeserializeObject<List<Booking>>(content);
                    }
                }
            }
            catch
            {
                // Handle any exceptions here
            }

            return bookings;
        }
        public async Task<Customer?> FindCustomerByPhone(string phone)
        {
            Customer? foundCustomer = null;

            _customerService.UseUrl = $"{_customerService.BaseUrl}/{phone}";

            try
            {
                var serviceResponse = await _customerService.CallServiceGet();
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode)
                {
                    var content = await serviceResponse.Content.ReadAsStringAsync();
                    foundCustomer = JsonConvert.DeserializeObject<Customer>(content);
                }
            }
            catch
            {
                // Handle any exceptions here
            }

            return foundCustomer;
        }
    }
}
