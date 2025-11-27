using JohnsStoreStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibrarySystem
{
    public partial class frmReturnBook : Form
    {
        private Library library;
        private Customer customer;
        public frmMainMenu mainMenu;
        private frmMainMenu frmMainMenu;

        public frmReturnBook(Library library, frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.library = library;
            this.frmMainMenu = frmMainMenu;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboName.Text) && !string.IsNullOrEmpty(txtTitle.Text))
            {
                /*Customer bookToReturn = customer.ShowCheckedOutBooks(txtTitle);

                if (customer != null)
                {
                    if (bookToReturn != null)
                    {
                        bool success = Book.ReturnBook(txtTitle);
                        if (success)
                        {
                            MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Book was not checked out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book not found in customer's checked-out list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
            }
            else
            {
                MessageBox.Show("There is nothing selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Will default to this
                cboName.Select();
            }
        }

        private void ResetForm()
        {
            cboName.Text = "";
            txtTitle.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Visible = true;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            /*  cboName.DataSource = library.Books.Select(b => b.getAuthor).ToList();
           cboName.SelectedIndex = -1;
           cboTitle.DataSource = library.Books.Select(b => b.getTitle).ToList();
           cboTitle.SelectedIndex = -1*/   

        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
