using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_4.Customer___Staff
{
    public partial class Add_Customer : UserControl
    {
        private static List<CustomerInfo> ListCustomerInfo = new List<CustomerInfo>();
        private CustomerInfo CI = new CustomerInfo();
        private SaveFileDialog Save = new SaveFileDialog();
        private static JsonSerializer JSONserializer = new JsonSerializer();

        public Add_Customer()
        {
            InitializeComponent();
            Save.Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Helper.CustomerList.Add(new CustomerInfo(
                  textBoxFirstName.Text,
                  textBoxLastName.Text,
                  textBoxStreetAddress.Text,
                  textBoxStreetAddressLine2.Text,
                  textBoxCity.Text,
                  textBoxStateProvince.Text,
                  int.Parse(textBoxPostalZipCode.Text),
                  textBoxPhone.Text,
                  textBoxEmail.Text,
                  comboBoxHearAboutUs.SelectedItem.ToString(),
                  richTextBoxFeedback.Text,
                  richTextBoxSuggestions.Text,
                  combo_recommend.SelectedItem.ToString()));

            MessageBox.Show("Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (dialogResult == DialogResult.Yes)
            {
                ListCustomerInfo.AddRange(new CustomerInfo[] {
                            new CustomerInfo(textBoxFirstName.Text, textBoxLastName.Text, textBoxStreetAddress.Text, textBoxStreetAddressLine2.Text,
                            textBoxCity.Text, textBoxStateProvince.Text, Convert.ToInt32(textBoxPostalZipCode.Text), textBoxPhone.Text, textBoxEmail.Text, comboBoxHearAboutUs.SelectedItem.ToString(),
                            richTextBoxFeedback.Text, richTextBoxSuggestions.Text, checkedButton.Text)
                            });
            }
            else
            {
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    ListCustomerInfo.AddRange(new CustomerInfo[] {
                            new CustomerInfo(textBoxFirstName.Text, textBoxLastName.Text, textBoxStreetAddress.Text, textBoxStreetAddressLine2.Text,
                            textBoxCity.Text, textBoxStateProvince.Text, Convert.ToInt32(textBoxPostalZipCode.Text), textBoxPhone.Text, textBoxEmail.Text, comboBoxHearAboutUs.SelectedItem.ToString(),
                            richTextBoxFeedback.Text, richTextBoxSuggestions.Text, checkedButton.Text)
                            });

                    StreamWriter sw = new StreamWriter(Save.FileName);
                    if (Path.GetExtension(Save.FileName).ToLower() == ".json")
                    {
                        JSONserializer.Serialize(sw, ListCustomerInfo);
                    }
                    else
                    {
                        CI.xmlCI.Serialize(sw, ListCustomerInfo);
                        MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                    }
                    sw.Close();
                }
            }
        }

        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text.Length == 0)
            {
                textBoxPhone.Text = "(000) 000-0000";
                textBoxPhone.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "(000) 000-0000")
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                textBoxEmail.Text = "ex: email@yahoo.com";
                textBoxEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "ex: email@yahoo.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = SystemColors.WindowText;
            }
        }

        private void ComboBoxHearAboutUs_Leave(object sender, EventArgs e)
        {
            if (comboBoxHearAboutUs.Text.Length == 0)
            {
                comboBoxHearAboutUs.Text = "Please Select";
                comboBoxHearAboutUs.ForeColor = SystemColors.GrayText;
            }
            else
            {
                comboBoxHearAboutUs.ForeColor = SystemColors.ControlText;
            }
        }

        private void ComboBoxHearAboutUs_Enter(object sender, EventArgs e)
        {
            if (comboBoxHearAboutUs.Text == "Please Select")
            {
                comboBoxHearAboutUs.Text = "";
                comboBoxHearAboutUs.ForeColor = SystemColors.WindowText;
            }
            else
            {
                comboBoxHearAboutUs.ForeColor = SystemColors.ControlText;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (Control rb in Controls)
            {
                if (rb is RadioButton)
                    (rb as RadioButton).Checked = false;

                if (rb is TextBox)
                    (rb as TextBox).Clear();

                if (rb is RichTextBox)
                    (rb as RichTextBox).Clear();
            }

            comboBoxHearAboutUs.Text = "Please Select";
            comboBoxHearAboutUs.ForeColor = SystemColors.GrayText;

            textBoxPhone.Text = "(000) 000-0000";
            textBoxPhone.ForeColor = SystemColors.GrayText;

            textBoxEmail.Text = "ex: email@yahoo.com";
            textBoxEmail.ForeColor = SystemColors.GrayText;
        }

        private void comboBoxHearAboutUs_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}