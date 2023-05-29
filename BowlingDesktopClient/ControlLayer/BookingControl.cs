using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.ServiceLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingDesktopClient.Security;
using System.Net;

namespace BowlingDesktopClient.ControlLayer
{
    public class BookingControl
    {
        readonly IBookingAccess _bAccess;

        public BookingControl()
        {
            _bAccess = new BookingServiceAccess();
        }

        public async Task<List<Booking>?> GetAllBookings()
        {
            List<Booking>? foundBookings = null;

            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);

            if(tokenValue != null)
            {
                foundBookings = await _bAccess.GetBookings(tokenValue);
                if(_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if (currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if (tokenValue != null)
                {
                    foundBookings = await _bAccess.GetBookings(tokenValue);
                }
            }
            foreach (Booking booking in foundBookings)
                {
                    Booking? foundByBookingId = await _bAccess.FindBookingById(tokenValue, booking.Id); // Find booking using booking ID

                    if (foundByBookingId != null)
                    {
                        booking.PriceId = foundByBookingId.PriceId; 
                        booking.LaneId = foundByBookingId.LaneId; 
                    }
               }
            
            return foundBookings;
        }

        public async Task<int> SaveBooking(DateTime StartDateTime, int hoursToPlay, int noOfPlayers, Customer customer)
        {
            int insertedId = -1;
            Booking newBooking = new Booking(StartDateTime, hoursToPlay, noOfPlayers, customer);
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                insertedId = await _bAccess.SaveBooking(tokenValue, newBooking);
                if (_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
                return insertedId;
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if (currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if (tokenValue != null)
                {
                    insertedId = await _bAccess.SaveBooking(tokenValue, newBooking);
                }
            }

            return insertedId;
        }
        public async Task<List<Booking>?> FindBookingByCustomerPhone(string customerPNO)
        {
            List<Booking>? foundBookings = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);

            if (tokenValue != null)
            {
                foundBookings = await _bAccess.FindBookingsByCustomerPhone(tokenValue, customerPNO);
                if (_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if (currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if (tokenValue != null)
                {
                    foundBookings = await _bAccess.FindBookingsByCustomerPhone(tokenValue, customerPNO);
                }
            }
            foundBookings = await _bAccess.FindBookingsByCustomerPhone(tokenValue, customerPNO);

            foreach (Booking booking in foundBookings)
            {
                Booking foundByBookingId = await _bAccess.FindBookingById(tokenValue, booking.Id); // Find booking using booking ID

                if (foundByBookingId != null)
                {
                    booking.PriceId = foundByBookingId.PriceId; // Update priceId
                    booking.LaneId = foundByBookingId.LaneId; // Update laneId
                }
            }

            return foundBookings;
        }

        public async Task<Booking?> FindBookingById(int bookingId)
        {
            Booking? foundBooking = null;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                foundBooking = await _bAccess.FindBookingById(tokenValue, bookingId);
                if (_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if (currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if (tokenValue != null)
                {
                    foundBooking = await _bAccess.FindBookingById(tokenValue, bookingId);
                }
            }
           
            return foundBooking;
        }
        public async Task<bool> DeleteBooking(int bookingId)
        {
            bool isDeleted = false;
            // Get token
            TokenState currentState = TokenState.Valid;        // Presumed state
            string? tokenValue = await GetToken(currentState);
            if (tokenValue != null)
            {
                isDeleted = await _bAccess.DeleteBooking(tokenValue, bookingId);
                if (_bAccess.CurrentHttpStatusCode == HttpStatusCode.Unauthorized)
                {
                    currentState = TokenState.Invalid;
                }
            }
            else
            {
                currentState = TokenState.Invalid;
            }
            if (currentState == TokenState.Invalid)
            {
                tokenValue = await GetToken(currentState);
                if (tokenValue != null)
                {
                    isDeleted = await _bAccess.DeleteBooking(tokenValue, bookingId);
                }
            }

            return isDeleted;
        }
        private async Task<string?> GetToken(TokenState useState)
        {
            TokenManager tokenHelp = new TokenManager();
            string? foundToken = await tokenHelp.GetToken(useState);
            return foundToken;
        }
    }
}
