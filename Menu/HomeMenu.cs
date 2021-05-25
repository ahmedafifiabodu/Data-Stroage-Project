using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class HomeMenu : UserControl
    {
        private OrderNow DRINKSMENU = new OrderNow();
        private SaveFileDialog save = new SaveFileDialog();

        public HomeMenu()
        {
            InitializeComponent();
            save.Filter = "XML files (*.xml)|*.xml";
        }

        private void buttonOrderNow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelHomeName.Text, labelHomePrice.Text, HomeNumericUpDown.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelHomeName.Text, labelHomePrice.Text, HomeNumericUpDown.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DRINKSMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
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