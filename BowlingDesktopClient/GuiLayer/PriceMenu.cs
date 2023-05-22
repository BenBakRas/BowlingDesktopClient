﻿using BowlingDesktopClient.ControlLayer;
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
using System.Xml.Linq;

namespace BowlingDesktopClient.GuiLayer
{
    public partial class PriceMenu : Form
    {
        CreatePriceMenu cpm = new CreatePriceMenu();
        readonly PriceControl _priceControl;
        public PriceMenu()
        {
            InitializeComponent();
            _priceControl = new PriceControl();

        }
        private async void buttonFindAllPrices_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            List<Price>? fethcedPrices = await _priceControl.GetAllPrices();
            if (fethcedPrices != null)
            {
                if (fethcedPrices.Count >= 1)
                {
                    processText = "Ok";
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
            labelProcessText.Text = processText;
            listBoxPrices.DataSource = fethcedPrices;
        }

        private async void buttonSavePrice_Click(object sender, EventArgs e)
        {
            // Get the price ID and validate it
            if (!int.TryParse(textBoxPriceId.Text, out int priceId))
            {
                MessageBox.Show("Invalid price ID.");
                return;
            }

            // Get the price details
            double? normalPrice = null;
            double? specialPrice = null;
            string weekday = textBoxWeekday.Text;

            if (!string.IsNullOrWhiteSpace(textBoxNormalPrice.Text))
            {
                if (!double.TryParse(textBoxNormalPrice.Text, out double parsedNormalPrice))
                {
                    MessageBox.Show("Invalid normal price.");
                    return;
                }
                normalPrice = parsedNormalPrice;
            }

            if (!string.IsNullOrWhiteSpace(textBoxSpecialPrice.Text))
            {
                if (!double.TryParse(textBoxSpecialPrice.Text, out double parsedSpecialPrice))
                {
                    MessageBox.Show("Invalid special price.");
                    return;
                }
                specialPrice = parsedSpecialPrice;
            }

            // Create a new Price object with the updated details
            Price updatedPrice = new Price(normalPrice, specialPrice, weekday);

            // Update the price using PriceControl
            bool isUpdated = await _priceControl.UpdatePrice(priceId, updatedPrice);

            if (isUpdated)
            {
                MessageBox.Show("Price updated successfully.");
                // Perform any additional actions after successful update
            }
            else
            {
                MessageBox.Show("Failed to update price.");
                // Handle update failure
            }
        }
        private void buttonCreatePriceMenu_Click(object sender, EventArgs e)
        {
            cpm.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string processText = "Good or Not";
            int pID;
            if (!int.TryParse(textBoxFindBy.Text, out pID))
            {
                MessageBox.Show("Invalid price ID.");
                return;
            }

            Price price = await _priceControl.FindPriceById(pID);
            List<Price>? fetchedPrices = new List<Price>();

            if (price == null)
            {
                MessageBox.Show("Intet Prissæt eksistere med dette ID");
            }
            else if (string.IsNullOrEmpty(price.Weekday) || price.SpecialPrice == null || price.NormalPrice == null)
            {
                MessageBox.Show("Intet Prissæt eksistere med dette ID");
            }
            else
            {
                price.Id = pID;
                fetchedPrices.Add(price);
                if (fetchedPrices.Count >= 1)
                {
                    processText = "Ok";
                }
                else
                {
                    processText = "No Lanes found";
                }
            }
            labelProcessText.Text = processText;
            listBoxPrices.DataSource = fetchedPrices;
        }

        private async void buttonPriceToDelete_Click(object sender, EventArgs e)
        {
            int priceID = int.Parse(textBoxPriceToDelete.Text);
            //Delete The Price
            bool isDeleted = await _priceControl.DeletePrice(priceID);
            if (isDeleted)
            {
                // Lane was successfully deleted
                MessageBox.Show("Price Slettet.");
            }
            else
            {
                // Failed to delete lane
                MessageBox.Show("Fejl ved sletning.");
            }
        }
    }
}
