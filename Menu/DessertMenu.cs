﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class DessertMenu : UserControl
    {
        private OrderNow DESSERTMENU = new OrderNow();
        private SaveFileDialog save = new SaveFileDialog();

        public DessertMenu()
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
                    new OrderNow(labelDessertName1.Text, labelDessertPrice1.Text, DessertNumericUpDown1.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelDessertName1.Text, labelDessertPrice1.Text, DessertNumericUpDown1.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DESSERTMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelDessertName2.Text, labelDessertPrice2.Text, DessertNumericUpDown2.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelDessertName2.Text, labelDessertPrice2.Text, DessertNumericUpDown2.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DESSERTMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelDessertName3.Text, labelDessertPrice3.Text, DessertNumericUpDown3.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelDessertName3.Text, labelDessertPrice3.Text, DessertNumericUpDown3.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DESSERTMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
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