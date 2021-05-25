using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class SeafoodMenu : UserControl
    {
        private OrderNow SEAFOODMENU = new OrderNow();
        private SaveFileDialog save = new SaveFileDialog();

        public SeafoodMenu()
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
                    new OrderNow(labelSeafoodName1.Text, labelSeafoodPrice1.Text, SeafoodNumericUpDown1.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSeafoodName1.Text, labelSeafoodPrice1.Text, SeafoodNumericUpDown1.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    SEAFOODMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelSeafoodName2.Text, labelSeafoodPrice2.Text, SeafoodNumericUpDown2.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSeafoodName2.Text, labelSeafoodPrice2.Text, SeafoodNumericUpDown2.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    SEAFOODMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelSeafoodName3.Text, labelSeafoodPrice3.Text, SeafoodNumericUpDown3.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelSeafoodName3.Text, labelSeafoodPrice3.Text, SeafoodNumericUpDown3.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    SEAFOODMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
        }

        private void SeafoodNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelSeafoodPrice1.Text = "28.99";
            double Qty = Convert.ToDouble(labelSeafoodPrice1.Text);
            Qty = 28.99 * Convert.ToDouble(SeafoodNumericUpDown1.Value);
            labelSeafoodPrice1.Text = "$" + Qty.ToString();

            if (labelSeafoodPrice1.Text == "$0")
            {
                labelSeafoodPrice1.Text = "$0.00";
            }
        }

        private void SeafoodNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            labelSeafoodPrice2.Text = "29.99";
            double Qty = Convert.ToDouble(labelSeafoodPrice2.Text);
            Qty = 29.99 * Convert.ToDouble(SeafoodNumericUpDown2.Value);
            labelSeafoodPrice2.Text = "$" + Qty.ToString();

            if (labelSeafoodPrice2.Text == "$0")
            {
                labelSeafoodPrice2.Text = "$0.00";
            }
        }

        private void SeafoodNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            labelSeafoodPrice3.Text = "21.99";
            double Qty = Convert.ToDouble(labelSeafoodPrice3.Text);
            Qty = 21.99 * Convert.ToDouble(SeafoodNumericUpDown3.Value);
            labelSeafoodPrice3.Text = "$" + Qty.ToString();

            if (labelSeafoodPrice3.Text == "$0")
            {
                labelSeafoodPrice3.Text = "$0.00";
            }
        }
    }
}