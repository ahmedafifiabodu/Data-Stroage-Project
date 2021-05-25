using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SteaksMenu : UserControl
    {
        private OrderNow STEAKSMENU = new OrderNow();
        private SaveFileDialog save = new SaveFileDialog();

        public SteaksMenu()
        {
            InitializeComponent();
            save.Filter = "XML files (*.xml)|*.xml";
        }

        private void buttonOrderNow1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSteakName1.Text, labelSteakPrice1.Text, SteaksNumericUpDown1.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSteakName1.Text, labelSteakPrice1.Text, SteaksNumericUpDown1.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    STEAKSMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
        }

        private void buttonOrderNow2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSteakName2.Text, labelSteakPrice2.Text, SteaksNumericUpDown2.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSteakName2.Text, labelSteakPrice2.Text, SteaksNumericUpDown2.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    STEAKSMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
        }

        private void buttonOrderNow3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSteakName3.Text, labelSteakPrice3.Text, SteaksNumericUpDown3.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSteakName3.Text, labelSteakPrice3.Text, SteaksNumericUpDown3.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    STEAKSMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
        }

        private void SaladsNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelSteakPrice1.Text = "28.99";
            double Qty = Convert.ToDouble(labelSteakPrice1.Text);
            Qty = 28.99 * Convert.ToDouble(SteaksNumericUpDown1.Value);
            labelSteakPrice1.Text = "$" + Qty.ToString();

            if (labelSteakPrice1.Text == "$0")
            {
                labelSteakPrice1.Text = "$0.00";
            }
        }

        private void SaladsNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelSteakPrice2.Text = "15.99";
            double Qty = Convert.ToDouble(labelSteakPrice2.Text);
            Qty = 15.99 * Convert.ToDouble(SteaksNumericUpDown2.Value);
            labelSteakPrice2.Text = "$" + Qty.ToString();

            if (labelSteakPrice2.Text == "$0")
            {
                labelSteakPrice2.Text = "$0.00";
            }
        }

        private void SaladsNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            labelSteakPrice3.Text = "31.99";
            double Qty = Convert.ToDouble(labelSteakPrice3.Text);
            Qty = 31.99 * Convert.ToDouble(SteaksNumericUpDown3.Value);
            labelSteakPrice3.Text = "$" + Qty.ToString();

            if (labelSteakPrice3.Text == "$0")
            {
                labelSteakPrice3.Text = "$0.00";
            }
        }
    }
}