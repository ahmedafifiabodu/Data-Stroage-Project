using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4.Customer___Staff
{
    public partial class Add_Staff : UserControl
    {

        private Staff_Info SI = new Staff_Info();

        private SaveFileDialog save = new SaveFileDialog();
        private OpenFileDialog OpenImage = new OpenFileDialog();

        private byte[] CoverLetterImage;
        private byte[] UploadResumeImage;

        public object XDoc { get; private set; }

        public Add_Staff()
        {
            InitializeComponent();
            buttonUploadCoverLetter.AllowDrop = true;

            OpenImage.Title = "Open Cover Letter file";
            OpenImage.Filter = "JPG Files (*.jpg)| *.jpg|PNG Files (*.png)| *.png";

            save.Filter = "XML files (*.xml)|*.xml";
        }

        private void comboBoxCountry_Enter(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text == "Please Select")
            {
                comboBoxCountry.Text = "";
                comboBoxCountry.ForeColor = SystemColors.GrayText;
            }
        }

        private void comboBoxCountry_Leave(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text.Length == 0)
            {
                comboBoxCountry.Text = "Please Select";
                comboBoxCountry.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "(000) 000-0000")
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text.Length == 0)
            {
                textBoxPhone.Text = "(000) 000-0000";
                textBoxPhone.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                textBoxEmail.Text = "ex: email@yahoo.com";
                textBoxEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "ex: email@yahoo.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = SystemColors.WindowText;
            }
        }

        private void comboBoxCountry_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
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

        private void buttonUploadCoverLetter_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCoverLetter.Image = new Bitmap(OpenImage.FileName);
                CoverLetterImage = File.ReadAllBytes(OpenImage.FileName);


            }
        }

        private void buttonUploadResume_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUploadResume.Image = new Bitmap(OpenImage.FileName);
                UploadResumeImage = File.ReadAllBytes(OpenImage.FileName);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           
            Helper.Serialize(Helper.StaffList);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CoverLetterImage == null || UploadResumeImage == null)
            {
                MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            }
        }
    }
}