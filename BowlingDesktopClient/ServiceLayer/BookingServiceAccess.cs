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
        readonly String _serviceBaseUrl = "https://localhost:7197/api/customers";
        public BookingServiceAccess()
        {
            _bookingService = new ServiceConnection(_serviceBaseUrl);
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
            //
            _bookingService.UseUrl = _bookingService.BaseUrl;
            try
            {
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
            catch
            {
                insertedBookingId = -3;
            }
            return insertedBookingId;
        }
    }
}
