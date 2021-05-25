﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class DrinksMenu : UserControl
    {
        private OrderNow DRINKSMENU = new OrderNow();
        private SaveFileDialog save = new SaveFileDialog();

        public DrinksMenu()
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
                    new OrderNow(labelDrinkName1.Text, labelDrinkPrice1.Text, DrinksNumericUpDown1.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelDrinkName1.Text, labelDrinkPrice1.Text, DrinksNumericUpDown1.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DRINKSMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelDrinkName2.Text, labelDrinkPrice2.Text, DrinksNumericUpDown2.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelDrinkName2.Text, labelDrinkPrice2.Text, DrinksNumericUpDown2.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DRINKSMENU.xml.Serialize(sw, Menu_Form.xb);
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
                    new OrderNow(labelDrinkName3.Text, labelDrinkPrice3.Text, DrinksNumericUpDown3.Value)
                    });
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Menu_Form.xb.AddRange(new OrderNow[] {
                    new OrderNow(labelDrinkName3.Text, labelDrinkPrice3.Text, DrinksNumericUpDown3.Value)
                    });

                    StreamWriter sw = new StreamWriter(save.FileName);
                    DRINKSMENU.xml.Serialize(sw, Menu_Form.xb);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }
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