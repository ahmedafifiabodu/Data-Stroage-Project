using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class StarterMenu : UserControl
    {
        public StarterMenu()
        {
            InitializeComponent();
        }

        private void buttonbuttonOrderNow1_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelStarterName1.Text, labelStarterPrice1.Text, StarterNumericUpDown1.Value);
        }

        private void buttonOrderNow2_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelStarterName2.Text, labelStarterPrice2.Text, StarterNumericUpDown2.Value);
        }

        private void buttonOrderNow3_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelStarterName3.Text, labelStarterPrice3.Text, StarterNumericUpDown3.Value);
        }

        private void DrinksNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelStarterPrice1.Text = "22.99";
            double Qty = Convert.ToDouble(labelStarterPrice1.Text);
            Qty = 22.99 * Convert.ToDouble(StarterNumericUpDown1.Value);
            labelStarterPrice1.Text = "$" + Qty.ToString();

            if (labelStarterPrice1.Text == "$0")
            {
                labelStarterPrice1.Text = "$0.00";
            }
        }

        private void DrinksNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelStarterPrice2.Text = "17.99";
            double Qty = Convert.ToDouble(labelStarterPrice2.Text);
            Qty = 17.99 * Convert.ToDouble(StarterNumericUpDown2.Value);
            labelStarterPrice2.Text = "$" + Qty.ToString();

            if (labelStarterPrice2.Text == "$0")
            {
                labelStarterPrice2.Text = "$0.00";
            }
        }

        private void DrinksNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            labelStarterPrice3.Text = "11.99";
            double Qty = Convert.ToDouble(labelStarterPrice3.Text);
            Qty = 11.99 * Convert.ToDouble(StarterNumericUpDown3.Value);
            labelStarterPrice3.Text = "$" + Qty.ToString();

            if (labelStarterPrice3.Text == "$0")
            {
                labelStarterPrice3.Text = "$0.00";
            }
        }
    }
}