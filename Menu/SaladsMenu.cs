using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SaladsMenu : UserControl
    {
        private OrderNow SALADSMENU = new OrderNow();
        private SaveFileDialog save = new SaveFileDialog();

        public SaladsMenu()
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
                    new OrderNow(labelSaladName1.Text, labelSaladPrice1.Text, SaladsNumericUpDown1.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSaladName1.Text, labelSaladPrice1.Text, SaladsNumericUpDown1.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    SALADSMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelSaladName2.Text, labelSaladPrice2.Text, SaladsNumericUpDown2.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSaladName2.Text, labelSaladPrice2.Text, SaladsNumericUpDown2.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    SALADSMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelSaladName3.Text, labelSaladPrice3.Text, SaladsNumericUpDown3.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSaladName3.Text, labelSaladPrice3.Text, SaladsNumericUpDown3.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    SALADSMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
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