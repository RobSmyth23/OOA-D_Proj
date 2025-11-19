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
        private Book book;
        private frmMainMenu mainMenu;

        public frmReturnBook(Library libraryInstance, Book bookInstance,frmMainMenu mainMenu)
        {
            InitializeComponent();
            library = libraryInstance;
            book = bookInstance;
            this.mainMenu = mainMenu;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (cboName.Text != ("") && txtTitle.Text != ("")) // If both are selected.
            {
               // Book.ReturnBook();
            }
            else
            {
                MessageBox.Show("There is nothing selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Will default to this
                //Library.Return();
            }

            ResetForm();
        }

        private void ResetForm()
        {
            cboName.Text = "";
            txtTitle.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Visible = true;
        }
    }
}
