using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class DrinksMenu : UserControl
    {
        public DrinksMenu()
        {
            InitializeComponent();
        }

        private void buttonOrderNow1_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelDrinkName1.Text, labelDrinkPrice1.Text, DrinksNumericUpDown1.Value);
        }

        private void buttonOrderNow2_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelDrinkName2.Text, labelDrinkPrice2.Text, DrinksNumericUpDown2.Value);
        }

        private void buttonOrderNow3_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelDrinkName3.Text, labelDrinkPrice3.Text, DrinksNumericUpDown3.Value);
        }

        private void DrinksNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelDrinkPrice1.Text = "2.99";
            double Qty = Convert.ToDouble(labelDrinkPrice1.Text);
            Qty = 2.99 * Convert.ToDouble(DrinksNumericUpDown1.Value);
            labelDrinkPrice1.Text = "$" + Qty.ToString();

            if (labelDrinkPrice1.Text == "$0")
            {
                labelDrinkPrice1.Text = "$0.00";
            }
        }

        private void DrinksNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelDrinkPrice2.Text = "1.99";
            double Qty = Convert.ToDouble(labelDrinkPrice2.Text);
            Qty = 1.99 * Convert.ToDouble(DrinksNumericUpDown2.Value);
            labelDrinkPrice2.Text = "$" + Qty.ToString();

            if (labelDrinkPrice2.Text == "$0")
            {
                labelDrinkPrice2.Text = "$0.00";
            }
        }

        private void DrinksNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            labelDrinkPrice3.Text = "3.99";
            double Qty = Convert.ToDouble(labelDrinkPrice3.Text);
            Qty = 3.99 * Convert.ToDouble(DrinksNumericUpDown3.Value);
            labelDrinkPrice3.Text = "$" + Qty.ToString();

            if (labelDrinkPrice3.Text == "$0")
            {
                labelDrinkPrice3.Text = "$0.00";
            }
        }
    }
}