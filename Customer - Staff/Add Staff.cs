using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4.Customer___Staff
{
    public partial class Add_Staff : UserControl
    {
        private readonly OpenFileDialog OpenImage = new OpenFileDialog();

        private byte[] CoverLetterImage;
        private byte[] UploadResumeImage;

        private bool check = false;

        public Add_Staff()
        {
            InitializeComponent();
            buttonUploadCoverLetter.AllowDrop = true;

            OpenImage.Title = "Open Cover Letter file";
            OpenImage.Filter = "JPG Files (*.jpg)| *.jpg|PNG Files (*.png)| *.png";
        }

        private void Check(object sender, EventArgs e)
        {
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
            else if (comboBoxCountry.Text == "Please Select")
            {
                MessageBox.Show("Please select your country!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPhone.Text == "(000) 000-0000")
            {
                MessageBox.Show("Please enter your phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxEmail.Text == "ex: email@yahoo.com")
            {
                MessageBox.Show("Please enter your email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxApplyForPosition.Text == "")
            {
                MessageBox.Show("Please let us know what is your job position?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxWhenYouCanStart.Text == "")
            {
                MessageBox.Show("Please let us know when you can start?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CoverLetterImage == null || UploadResumeImage == null)
            {
                MessageBox.Show("Please select an image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (richTextBoxYourComment.Text == "")
            {
                MessageBox.Show("Please let us know about your comment on the job!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                check = true;
                ButtonAdd_Click(sender, e);
            }
        }

        private void ComboBoxCountry_Enter(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text == "Please Select")
            {
                comboBoxCountry.Text = "";
                comboBoxCountry.ForeColor = SystemColors.GrayText;
            }
        }

        private void ComboBoxCountry_Leave(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text.Length == 0)
            {
                comboBoxCountry.Text = "Please Select";
                comboBoxCountry.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "(000) 000-0000")
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text.Length == 0)
            {
                textBoxPhone.Text = "(000) 000-0000";
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

        private void ComboBoxCountry_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
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
            textBoxApplyForPosition.Clear();
            textBoxWhenYouCanStart.Clear();
            richTextBoxYourComment.Clear();

            foreach (Control rb in Controls)
            {
                if (rb is RadioButton)
                {
                    (rb as RadioButton).Checked = false;
                }
            }

            CoverLetterImage = null;
            UploadResumeImage = null;

            pictureBoxCoverLetter.Image = null;
            pictureBoxUploadResume.Image = null;

            comboBoxCountry.Text = "Please Select";
            comboBoxCountry.ForeColor = SystemColors.GrayText;

            textBoxPhone.Text = "(000) 000-0000";
            textBoxPhone.ForeColor = SystemColors.GrayText;

            textBoxEmail.Text = "ex: email@yahoo.com";
            textBoxEmail.ForeColor = SystemColors.GrayText;
        }

        /*
        //Get Drag Drop File Name
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private void buttonUploadCoverLetter_DragDrop(object sender, DragEventArgs e)
        {
            //Take Dropped items and store in an array
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            //Loop true, All dropped item display them
            foreach(string file in droppedFiles)
            {
                string fileName = getFileName(file);
                MessageBox.Show("You dropped " + fileName);
            }
        }

        private void buttonUploadCoverLetter_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        */

        private void ButtonUploadCoverLetter_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCoverLetter.Image = new Bitmap(OpenImage.FileName);
                CoverLetterImage = File.ReadAllBytes(OpenImage.FileName);
            }
        }

        private void ButtonUploadResume_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUploadResume.Image = new Bitmap(OpenImage.FileName);
                UploadResumeImage = File.ReadAllBytes(OpenImage.FileName);
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Helper.StaffList.Count == 0)
            {
                MessageBox.Show("Please enter your staff information and click add first then click on submit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Helper.Serialize(Helper.StaffList);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                Check(sender, e);
            }
            else
            {
                Helper.StaffList.Add(new Staff_Info(
                                textBoxFirstName.Text,
                                textBoxLastName.Text,
                                textBoxStreetAddress.Text,
                                textBoxStreetAddressLine2.Text,
                                textBoxCity.Text,
                                textBoxStateProvince.Text,
                                Convert.ToInt32(textBoxPostalZipCode.Text),
                                textBoxPhone.Text,
                                textBoxEmail.Text,
                                textBoxApplyForPosition.Text,
                                textBoxWhenYouCanStart.Text,
                                Convert.ToBase64String(CoverLetterImage),
                                Convert.ToBase64String(UploadResumeImage),
                                richTextBoxYourComment.Text));

                MessageBox.Show("Added Successfully", "done", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ButtonClear_Click(sender, e);
            }
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