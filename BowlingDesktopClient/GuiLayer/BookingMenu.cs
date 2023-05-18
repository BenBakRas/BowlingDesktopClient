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
        readonly BookingControl _bookingControl;

        public BookingMenu()
        {
            InitializeComponent();

            _bookingControl = new BookingControl();
        }

        private async void buttonCreateBooking_Click(object sender, EventArgs e)
        {
            /*{
                int insertedId = -1;
                string messageText;
                // Values from testboxes must be fetched
                int inHoursToPlay = int.Parse(textBoxHoursToPlay.Text);
                int inPlayers = int.Parse(textBoxPlayers.Text);
                Customer inCustomers = textBoxCustomers.Text;
                // Evaluate and act accordingly
                if (InputIsOk(inHoursToPlay, inPlayers, inCustomers))
                {
                    // Call the ControlLayer to get the data saved
                    insertedId = await _bookingControl.SaveBooking(inHoursToPlay, inPlayers, inCustomers);
                    messageText = (insertedId > 0) ? $"Booking saved with no {insertedId}" : "Failure: An error occurred!";
                }
                else
                {
                    messageText = "Please input valid informations";
                }
                // Finally put out a message saying if the saving went well 
                labelProcessSaved.Text = messageText;
            }
            private bool InputIsOk(String hoursToPlay, String noOfPlayers, Customer? cutomer)
            {
                bool isValidInput = false;
                if (!String.IsNullOrWhiteSpace(hoursToPlay) && !String.IsNullOrWhiteSpace(noOfPlayers) && !String.IsNullOrWhiteSpace(Customer))
                {
                    if (hoursToPlay.Length > 0 && noOfPlayers.Length > 1 && cutomer.Length > 0)
                    {
                        isValidInput = true;
                    }
                }
                return isValidInput;
            }*/
        }
    }
}
