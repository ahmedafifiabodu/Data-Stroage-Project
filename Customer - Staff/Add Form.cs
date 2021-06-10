using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            Sidepanel.Height = buttonAddCustomer.Height;
            add_Customer1.BringToFront();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonView.Height;
            Sidepanel.Top = buttonView.Top;
            DisplayCustomerInfo.BringToFront();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonAddStaff.Height;
            Sidepanel.Top = buttonAddStaff.Top;
            add_Staff1.BringToFront();
        }

        private void ButtonDisplayCustomer_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonDisplayCustomer.Height;
            Sidepanel.Top = buttonDisplayCustomer.Top;
            display_Staff1.BringToFront();
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonAddCustomer.Height;
            Sidepanel.Top = buttonAddCustomer.Top;
            add_Customer1.BringToFront();
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Menu_Form menu = new Menu_Form();
            this.Hide();
            menu.Show();
        }
    }
}