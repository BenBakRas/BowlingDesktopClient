﻿using BowlingDesktopClient.ControlLayer;
using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BowlingDesktopClient
{
    public partial class MainForm : Form
    {
        private readonly CustomerController _customerController;
        private System.ComponentModel.IContainer components = null;

        private Button btnLoadCustomers;
        private ListBox lstCustomers;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainForm";
        }

        public MainForm()
        {
            InitializeComponent();
            _customerController = new CustomerController(new BowlingCustomerApiService());

            // Initialize btnLoadCustomers
            btnLoadCustomers = new Button();
            btnLoadCustomers.Text = "Load Customers";
            btnLoadCustomers.Location = new System.Drawing.Point(30, 30);
            btnLoadCustomers.Click += BtnLoadCustomers_Click;
            this.Controls.Add(btnLoadCustomers);

            // Initialize lstCustomers
            lstCustomers = new ListBox();
            lstCustomers.Location = new System.Drawing.Point(30, 70);
            lstCustomers.Size = new System.Drawing.Size(300, 300);
            this.Controls.Add(lstCustomers);
        }

        private async void BtnLoadCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                List<Customer> customers = await _customerController.GetAllCustomersAsync();
                lstCustomers.Items.Clear();
                foreach (var customer in customers)
                {
                    lstCustomers.Items.Add($"Customer ID: {customer.Id}, FirstName: {customer.FirstName}, LastName: {customer.LastName}, Email: {customer.Email}, Phone: {customer.Phone}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}