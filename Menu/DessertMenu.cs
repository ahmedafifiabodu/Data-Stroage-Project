using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class DessertMenu : UserControl
    {
        public DessertMenu()
        {
            InitializeComponent();
        }

        private void buttonOrderNow1_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelDessertName1.Text, labelDessertPrice1.Text, DessertNumericUpDown1.Value);
        }

        private void buttonOrderNow2_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelDessertName2.Text, labelDessertPrice2.Text, DessertNumericUpDown2.Value);
        }

        private void buttonOrderNow3_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelDessertName3.Text, labelDessertPrice3.Text, DessertNumericUpDown3.Value);
        }

        private void DessertNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelDessertPrice1.Text = "9.99";
            double Qty = Convert.ToDouble(labelDessertPrice1.Text);
            Qty = 9.99 * Convert.ToDouble(DessertNumericUpDown1.Value);
            labelDessertPrice1.Text = "$" + Qty.ToString();

            if (labelDessertPrice1.Text == "$0")
            {
                labelDessertPrice1.Text = "$0.00";
            }
        }

        private void DessertNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelDessertPrice2.Text = "14.99";
            double Qty = Convert.ToDouble(labelDessertPrice2.Text);
            Qty = 14.99 * Convert.ToDouble(DessertNumericUpDown2.Value);
            labelDessertPrice2.Text = "$" + Qty.ToString();

            if (labelDessertPrice2.Text == "$0")
            {
                labelDessertPrice2.Text = "$0.00";
            }
        }

        private void DessertNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            labelDessertPrice3.Text = "19.99";
            double Qty = Convert.ToDouble(labelDessertPrice3.Text);
            Qty = 19.99 * Convert.ToDouble(DessertNumericUpDown3.Value);
            labelDessertPrice3.Text = "$" + Qty.ToString();

            if (labelDessertPrice3.Text == "$0")
            {
                labelDessertPrice3.Text = "$0.00";
            }
        }
    }
}