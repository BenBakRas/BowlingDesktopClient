using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BowlingDesktopClient.ControlLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;

namespace BowlingDesktopClient.GuiLayer
{
    public partial class BookingMenu : Form
    {
        readonly BookingControl _bookingControl;
        readonly CustomerControl _cusControl;
        readonly PriceControl _priceControl;
        readonly LaneControl _laneControl;
        public BookingMenu()
        {
            InitializeComponent();

            _bookingControl = new BookingControl();
            _cusControl = new CustomerControl();
            _priceControl = new PriceControl();
            _laneControl = new LaneControl();
        }

        private async void buttonCreateBooking_Click_1(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;
            // Values from testboxes must be fetched
            DateTime dateTime = DateTime.Now;
            int hoursToPlayer = int.Parse(textBoxHoursToPlay.Text);
            int players = int.Parse(textBoxPlayers.Text);
            string phoneNumber = textBoxCustomerPhone.Text;
            Customer customer = await _cusControl.FindCustomerByPhone(phoneNumber);

            // Evaluate and act accordingly
            if (InputIsOk(dateTime, hoursToPlayer, players, customer))
            {
                // Call the ControlLayer to get the data saved
                insertedId = await _bookingControl.SaveBooking(dateTime, hoursToPlayer, players, customer);
                messageText = (insertedId > 0) ? $"Booking saved with no {insertedId}" : "Failure: An error occurred!";
            }
            else
            {
                messageText = "Please input valid informations";
            }
            // Finally put out a message saying if the saving went well 
            labelProcessCreateBooking.Text = messageText;
        }
        private bool InputIsOk(DateTime startDateTime, int hoursToPlay, int noOfPlayers, Customer? customer)
        {
            bool isValidInput = false;
            string datetime = startDateTime.ToString();
            string htp = hoursToPlay.ToString();
            string players = noOfPlayers.ToString();
            if (!String.IsNullOrWhiteSpace(datetime) && !String.IsNullOrWhiteSpace(htp) && !String.IsNullOrWhiteSpace(players) && !String.IsNullOrWhiteSpace(customer.Phone))
            {
                if (hoursToPlay > 1 && noOfPlayers >= 1 && customer.Phone.Length > 6)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private async void buttonFindCusByPhone(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            string phone = textBoxFindBy.Text;
            List<Booking>? fetchedBooking = await _bookingControl.FindBookingByCustomerPhone(phone);
            if (fetchedBooking != null)
            {
                if (fetchedBooking != null)
                {
                    processText = "Ok";
                }
                else
                {
                    processText = "No customers found";
                }
            }
            else
            {
                processText = "Failure: An error occurred";
            }
            labelProcessBooking.Text = processText;
            listBoxBookings.DataSource = fetchedBooking;
        }

        private async void buttonFindAll_Click_1(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Booking>? fetchedBookings = await _bookingControl.GetAllBookings();
            if (fetchedBookings != null)
            {
                if (fetchedBookings.Count >= 1)
                {
                    processText = "Ok";

                    // Fetch Lane and Price objects based on IDs
                    foreach (var booking in fetchedBookings)
                    {
                        // Fetch Lane
                        Lane? lane = await _laneControl.FindLaneById(booking.LaneId);
                        if (lane != null)
                        {
                            booking.LaneId = lane.Id;
                        }

                        // Fetch Price
                        Price? price = await _priceControl.FindPriceById(booking.PriceId);
                        if (price != null)
                        {
                            booking.PriceId = price.Id;
                        }
                    }
                }
                else
                {
                    processText = "No Lanes found";
                }
            }
            else
            {
                processText = "Failure: An error occurred";
            }
            labelProcessBooking.Text = processText;
            listBoxBookings.DataSource = fetchedBookings;
        }

    }
}
