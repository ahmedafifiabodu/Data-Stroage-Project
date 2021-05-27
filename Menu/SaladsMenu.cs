using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SaladsMenu : UserControl
    {
        public SaladsMenu()
        {
            InitializeComponent();
        }

        private void buttonOrderNow1_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelSaladName1.Text, labelSaladPrice1.Text, SaladsNumericUpDown1.Value);
        }

        private void buttonOrderNow2_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelSaladName2.Text, labelSaladPrice2.Text, SaladsNumericUpDown2.Value);
        }

        private void buttonOrderNow3_Click(object sender, EventArgs e)
        {
            OrderHelper.NewOrder(labelSaladName3.Text, labelSaladPrice3.Text, SaladsNumericUpDown3.Value);
        }

        private void SaladsNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelSaladPrice1.Text = "8.99";
            double Qty = Convert.ToDouble(labelSaladPrice1.Text);
            Qty = 8.99 * Convert.ToDouble(SaladsNumericUpDown1.Value);
            labelSaladPrice1.Text = "$" + Qty.ToString();

            if (labelSaladPrice1.Text == "$0")
            {
                labelSaladPrice1.Text = "$0.00";
            }
        }

        private void SaladsNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelSaladPrice2.Text = "5.99";
            double Qty = Convert.ToDouble(labelSaladPrice2.Text);
            Qty = 5.99 * Convert.ToDouble(SaladsNumericUpDown2.Value);
            labelSaladPrice2.Text = "$" + Qty.ToString();

            if (labelSaladPrice2.Text == "$0")
            {
                labelSaladPrice2.Text = "$0.00";
            }
        }

        private void SaladsNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            labelSaladPrice3.Text = "7.99";
            double Qty = Convert.ToDouble(labelSaladPrice3.Text);
            Qty = 7.99 * Convert.ToDouble(SaladsNumericUpDown3.Value);
            labelSaladPrice3.Text = "$" + Qty.ToString();

            if (labelSaladPrice3.Text == "$0")
            {
                labelSaladPrice3.Text = "$0.00";
            }
        }
    }
}