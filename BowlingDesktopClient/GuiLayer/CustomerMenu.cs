using BowlingDesktopClient.ControlLayer;
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

namespace BowlingDesktopClient.GuiLayer
{
    public partial class CustomerMenu : Form
    {
        readonly CustomerControl _customerControl;
        public CustomerMenu()
        {
            InitializeComponent();

            _customerControl = new CustomerControl();
        }
     
        private async void buttonGetCustomers_Click_1(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Customer>? fethcedCustomers = await _customerControl.GetAllCustomers();
            if (fethcedCustomers != null)
            {
                if (fethcedCustomers.Count >= 1)
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
            labelCustomerText.Text = processText;
            listBoxCustomers.DataSource = fethcedCustomers;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Customer> fetchedCustomer = new List<Customer> { };
            Customer cus = await _customerControl.FindCustomerByPhone(textBoxFindBy.Text);
            fetchedCustomer.Add(cus);
            if (fetchedCustomer != null)
            {
                if (fetchedCustomer != null)
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
            labelCustomerText.Text = processText;
            listBoxCustomers.DataSource = fetchedCustomer;
        }

        private async void buttonSaveCustomer_Click_1(object sender, EventArgs e)
        {
            int insertedId = -1;
            string messageText;
            // Values from testboxes must be fetched
            string inFirstName = textBoxFirstName.Text;
            string inLastName = textBoxLastName.Text;
            string inEmail = textBoxEmail.Text;
            string inPhone = textBoxPhone.Text;
            // Evaluate and act accordingly
            if (InputIsOk(inFirstName, inLastName, inEmail, inPhone))
            {
                // Call the ControlLayer to get the data saved
                insertedId = await _customerControl.SaveCustomer(inFirstName, inLastName, inEmail, inPhone);
                messageText = (insertedId > 0) ? $"Customer saved with no {insertedId}" : "Failure: An error occurred!";
            }
            else
            {
                messageText = "Please input valid informations";
            }
            // Finally put out a message saying if the saving went well 
            labelProcessSaved.Text = messageText;
        }
        private bool InputIsOk(string fName, string lName, string email, string phone)
        {
            bool isValidInput = false;
            if (!String.IsNullOrWhiteSpace(fName) && !String.IsNullOrWhiteSpace(lName) && !String.IsNullOrWhiteSpace(email) && !String.IsNullOrWhiteSpace(phone))
            {
                if (fName.Length > 1 && lName.Length > 1 && email.Length > 2 && email.Contains('@') && phone.Length > 1)
                {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }
    }
    
}


