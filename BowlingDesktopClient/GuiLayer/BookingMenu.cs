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

namespace BowlingDesktopClient.GuiLayer
{
    public partial class BookingMenu : Form
    {
        readonly BookingController _BookingController;

        public BookingMenu()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            {
                string processBooking = "OK";
                List<Booking>? fetchedBookings = await _BookingController.GetAllBookingsAsync();
                if (fetchedBookings != null)
                {
                    if (fetchedBookings.Count >= 1)
                    {
                        processBooking = "Ok";
                    }
                    else
                    {
                        processBooking = "No persons found";
                    }
                }
                else
                {
                    processBooking = "Failure: An error occurred";
                }
                labelProcessBooking.Text = processBooking; listBoxBookings.DataSource = fetchedBookings;
            }
        }
    }
}
