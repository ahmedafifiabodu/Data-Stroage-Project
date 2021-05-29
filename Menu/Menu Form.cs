using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment_4
{
    public partial class Menu_Form : Form
    {
        public static List<OrderNow> xb = new List<OrderNow>();
        private OpenFileDialog Open = new OpenFileDialog();

        public Menu_Form()
        {
            InitializeComponent();
            Sidepanel.Height = buttonHome.Height;
            HomeOrder.BringToFront();
            OrderView.Visible = false;
            Open.Filter = "XML files (*.xml)|*.xml";
        }

        private void buttonHome_Click(object sender, EventArgs e)
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

        private void buttonDesserts_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonDesserts.Height;
            Sidepanel.Top = buttonDesserts.Top;
            DessertMenu.BringToFront();
            OrderView.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonDeserialization_Click(object sender, EventArgs e)
        {
            OrderView.dataGridView1.Rows.Clear();
            OrderView.labelOrderCount.Text = "";

            Stream st;
            XmlSerializer xml = new XmlSerializer(typeof(List<OrderNow>));

            int nodeCount = 0;

            if (Open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(Open.FileName);

                if ((st = Open.OpenFile()) != null)
                {
                    try
                    {
                        List<OrderNow> order = (List<OrderNow>)xml.Deserialize(read);
                        decimal total = 0;
                        int nodeCounts = order.Count;

                        OrderView.dataGridView1.Rows.Clear();
                        OrderView.dataGridView1.Refresh();

                        for (int i = 0; i < nodeCounts; i++)
                        {
                            OrderView.dataGridView1.Rows.Add();
                            OrderView.dataGridView1.Rows[i].Cells["OrderName"].Value = order[i].name;
                            OrderView.dataGridView1.Rows[i].Cells["OrderPrice"].Value = order[i].price;
                            OrderView.dataGridView1.Rows[i].Cells["OrderQuantity"].Value = order[i].quantity;

                            char[] TrimSgin = { '$' };
                            total += Convert.ToDecimal(order[i].price.Trim(TrimSgin));
                            OrderView.labelPriceTotal.Text = "$" + total.ToString();
                        }

                        OrderView.labelOrderCount.Text = "X" + order.Count.ToString() + " Items";
                        read.Close();
                        MessageBox.Show("Please Hover On The Notify Button", "Alert!", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Please Select a vaild XML file !", "Error", MessageBoxButtons.OK);
                    }
                }
            }
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
    }
}