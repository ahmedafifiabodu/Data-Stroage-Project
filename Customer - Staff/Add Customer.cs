using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_4.Customer___Staff
{
    public partial class Add_Customer : UserControl
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private bool check = false;

        private void Check(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (textBoxFirstName.Text == "")
            {
                MessageBox.Show("Please enter your first name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Please enter your last name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxStreetAddress.Text == "")
            {
                MessageBox.Show("Please enter your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxStreetAddressLine2.Text == "")
            {
                MessageBox.Show("Please enter your address line 2!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxCity.Text == "")
            {
                MessageBox.Show("Please enter your city!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxStateProvince.Text == "")
            {
                MessageBox.Show("Please enter your state/province!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPostalZipCode.Text == "")
            {
                MessageBox.Show("Please enter your postal/ZIP code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPhone.Text == "(000) 000-0000")
            {
                MessageBox.Show("Please enter your phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxEmail.Text == "ex: email@yahoo.com")
            {
                MessageBox.Show("Please enter your email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxHearAboutUs.Text == "Please Select")
            {
                MessageBox.Show("Please let us know where did you hear about us?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (richTextBoxFeedback.Text == "")
            {
                MessageBox.Show("Please let us know about your feedback!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (richTextBoxSuggestions.Text == "")
            {
                MessageBox.Show("Please let us know about your suggestions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkedButton == null)
            {
                MessageBox.Show("Please let us know about your recommendation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                check = true;
                ButtonAdd_Click(sender, e);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (check == false)
            {
                Check(sender, e);
            }
            else
            {
                Helper.CustomerList.Add(new CustomerInfo(
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxStreetAddress.Text,
                    textBoxStreetAddressLine2.Text,
                    textBoxCity.Text,
                    textBoxStateProvince.Text,
                    Convert.ToInt32(textBoxPostalZipCode.Text),
                    textBoxPhone.Text,
                    textBoxEmail.Text,
                    comboBoxHearAboutUs.SelectedItem.ToString(),
                    richTextBoxFeedback.Text,
                    richTextBoxSuggestions.Text,
                    checkedButton.Text));

                MessageBox.Show("Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonClear_Click(sender, e);
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Helper.CustomerList.Count == 0)
            {
                MessageBox.Show("Please enter your customer information and click add first then click on submit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Helper.Serialize(Helper.CustomerList);
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
                textBoxPhone.Clear();
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
                textBoxEmail.Clear();
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

        private void ComboBoxHearAboutUs_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}