using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_4.Customer___Staff
{
    public partial class Add_Customer : UserControl
    {
        private static List<CustomerInfo> LCI = new List<CustomerInfo>();
        private CustomerInfo CI = new CustomerInfo();
        private SaveFileDialog Save = new SaveFileDialog();

        public Add_Customer()
        {
            InitializeComponent();
            Save.Filter = "XML files (*.xml)|*.xml";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (Save.ShowDialog() == DialogResult.OK)
            {
                XDocument doc = XDocument.Load(Save.FileName);
                XElement school = doc.Element("ArrayOfCustomerInfo");
                school.Add(new XElement("CustomerInfo", new XElement("FirstName", textBoxFirstName.Text), new XElement("LastName", textBoxLastName.Text), new XElement("StreetAddress", textBoxStreetAddress.Text),
                    new XElement("StreetAddressLine2", textBoxStreetAddressLine2.Text), new XElement("City", textBoxCity.Text), new XElement("SateProvince", textBoxStateProvince.Text),
                    new XElement("PostalZipCode", textBoxPostalZipCode.Text), new XElement("Phone", textBoxPhone.Text), new XElement("Email", textBoxEmail.Text),
                    new XElement("HearAboutUs", comboBoxHearAboutUs.SelectedItem.ToString()), new XElement("Feedback", richTextBoxFeedback.Text), new XElement("Suggestions", richTextBoxSuggestions.Text),
                    new XElement("Recommend", checkedButton.Text)));

                doc.Save(Save.FileName);
                MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (dialogResult == DialogResult.Yes)
            {
                LCI.AddRange(new CustomerInfo[] {
                            new CustomerInfo(textBoxFirstName.Text, textBoxLastName.Text, textBoxStreetAddress.Text, textBoxStreetAddressLine2.Text,
                            textBoxCity.Text, textBoxStateProvince.Text, Convert.ToInt32(textBoxPostalZipCode.Text), textBoxPhone.Text, textBoxEmail.Text, comboBoxHearAboutUs.SelectedItem.ToString(),
                            richTextBoxFeedback.Text, richTextBoxSuggestions.Text, checkedButton.Text)
                            });
            }
            else
            {
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    LCI.AddRange(new CustomerInfo[] {
                            new CustomerInfo(textBoxFirstName.Text, textBoxLastName.Text, textBoxStreetAddress.Text, textBoxStreetAddressLine2.Text,
                            textBoxCity.Text, textBoxStateProvince.Text, Convert.ToInt32(textBoxPostalZipCode.Text), textBoxPhone.Text, textBoxEmail.Text, comboBoxHearAboutUs.SelectedItem.ToString(),
                            richTextBoxFeedback.Text, richTextBoxSuggestions.Text, checkedButton.Text)
                            });

                    StreamWriter sw = new StreamWriter(Save.FileName);
                    CI.xmlCI.Serialize(sw, LCI);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
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
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxStreetAddress.Clear();
            textBoxStreetAddressLine2.Clear();
            textBoxCity.Clear();
            textBoxStateProvince.Clear();
            textBoxPostalZipCode.Clear();
            richTextBoxFeedback.Clear();
            richTextBoxSuggestions.Clear();
            
            foreach(Control rb in Controls)
            {
                if(rb is RadioButton)
                {
                    (rb as RadioButton).Checked = false;
                }
                
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