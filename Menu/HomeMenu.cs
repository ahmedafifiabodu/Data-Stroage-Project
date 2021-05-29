using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void buttonOrderNow_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelHomeName.Text, labelHomePrice.Text, HomeNumericUpDown.Value);
        }

        private void HomeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            labelHomePrice.Text = "19.99";
            double Qty = Convert.ToDouble(labelHomePrice.Text);
            Qty = 19.99 * Convert.ToDouble(HomeNumericUpDown.Value);
            labelHomePrice.Text = "$" + Qty.ToString();

            if (labelHomePrice.Text == "$0")
            {
                labelHomePrice.Text = "$0.00";
            }
        }
    }
}