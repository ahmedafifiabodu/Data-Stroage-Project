using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Menu_Form : Form
    {
        // Navigate Based On Clicked Button Location
        private void navigate(int top)
        {
            OrderView.Visible = false;
            Sidepanel.Top = top;
        }

        public Menu_Form()
        {
            InitializeComponent();
            Sidepanel.Height = buttonHome.Height;
            HomeOrder.BringToFront();
        }

        // Handle Any Side Button Click
        private void Navigation_Buttons_Click(object sender, EventArgs e)
        {
            navigate(((Button)sender).Top);

            switch (((Button)sender).Name)
            {
                case "buttonHome":
                    HomeOrder.BringToFront();
                    break;

                case "buttonStarter":
                    StarterMenu.BringToFront();
                    break;

                case "buttonDrinks":
                    DrinksMenu.BringToFront();
                    break;

                case "buttonSeafood":
                    SeaFoodMenu.BringToFront();
                    break;

                case "buttonSalads":
                    SaladsMenu.BringToFront();
                    break;

                case "buttonSteaks":
                    SteaksMenu.BringToFront();
                    break;

                case "buttonDesserts":
                    DessertMenu.BringToFront();
                    break;

                default:
                    HomeOrder.BringToFront();
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonDeserialization_Click(object sender, EventArgs e)
        {
            OrderView.labelOrderCount.Text = "";

            Helper.Deserialize("order");
            decimal total = 0;

            OrderView.dataGridView1.Rows.Clear();
            OrderView.dataGridView1.Refresh();

            foreach (OrderNow order in Helper.OrderList)
            {
                OrderView.dataGridView1.Rows.Add(order.name, order.price, order.quantity);

                char[] TrimSgin = { '$' };
                total += Convert.ToDecimal(order.price.Trim(TrimSgin));
                OrderView.labelPriceTotal.Text = "$" + total.ToString();
            }

            OrderView.labelOrderCount.Text = "X" + Helper.OrderList.Count.ToString() + " Items";
            
        }

        private void buttonAddStaffCustomer_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            this.Hide();
            add.Show();
        }

        private void buttonAddStaffCustomer_MouseHover(object sender, EventArgs e)
        {
            toolTipAddCustomerOrStaff.Show("Add Customer or Staff Member", buttonAddStaffCustomer);
        }

        private void buttonNotify_MouseHover(object sender, EventArgs e)
        {
            OrderView.Visible = true;
            OrderView.BringToFront();
        }

        private void OrderView_MouseLeave(object sender, EventArgs e)
        {
            OrderView.Visible = false;
        }

        private void HomeOrder_Click(object sender, EventArgs e)
        {
            OrderView.Visible = false;
        }

        private void HomeOrder_Click(object sender, MouseEventArgs e)
        {
            OrderView.Visible = false;
        }
    }
}