using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmEditCustomer : Form
    {
        private Customer customer;
        public frmEditCustomer(Customer customerInstance)
        {
            InitializeComponent();
            customer = customerInstance;
        }

        private void dtGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when an item is clicked, the group box fills with relevant infomration according to search string.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //searches db/list for strings matching the given string, then fills the data grid box with results for selecton..
            string searchText = txtSearch.Text.Trim().ToLower();

            // Clear previous results
            lstResults.Items.Clear();

            // Search through customers
            var results = library.Customer
                .Where(b => b.getName.ToLower().Contains(searchText) ||
                            b.getEmail.ToLower().Contains(searchText) ||
                            (b is Customer cust && PhoneNo.Description.ToLower().Contains(searchText)))
                .ToList();

            // Display results
            foreach (var customer in results)
            {
                lstResults.Items.Add(customer); // ToString() will control how it looks
            }

            // Optional: show message if no results
            if (results.Count == 0)
            {
                lstResults.Items.Add("No results found.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to main menu
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Hide();
        }
    }
}
