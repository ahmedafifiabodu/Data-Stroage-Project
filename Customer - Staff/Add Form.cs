using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class AddForm : Form
    {
        private static List<CustomerInfo> LCI = new List<CustomerInfo>();
        private CustomerInfo CI = new CustomerInfo();
        private SaveFileDialog save = new SaveFileDialog();

        public AddForm()
        {
            InitializeComponent();
            Sidepanel.Height = buttonAddCustomer.Height;
            save.Filter = "XML files (*.xml)|*.xml";
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

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonAddStaff.Height;
            Sidepanel.Top = buttonAddStaff.Top;
            add_Staff1.BringToFront();
        }

        private void buttonDisplayCustomer_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonDisplayCustomer.Height;
            Sidepanel.Top = buttonDisplayCustomer.Top;
            display_Staff1.BringToFront();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonAddCustomer.Height;
            Sidepanel.Top = buttonAddCustomer.Top;
            add_Customer1.BringToFront();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu_Form menu = new Menu_Form();
            this.Hide();
            menu.Show();
        }

        private void display_Staff1_Load(object sender, EventArgs e)
        {

        }
    }
}