﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Assignment_4.Customer___Staff
{
    public partial class Display_Staff : UserControl
    {
        private readonly SaveFileDialog Save = new SaveFileDialog();
        private readonly OpenFileDialog Open = new OpenFileDialog();

        public Display_Staff()
        {
            InitializeComponent();

            Save.Filter = "XML files (*.xml)|*.xml";
            Open.Filter = "XML files (*.xml)|*.xml";
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            Helper.Deserialize("staff");
            dataGridView1.RowTemplate.MinimumHeight = 100;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            /*foreach (Staff_Info staff in Helper.StaffList)
            {
                dataGridView1.Rows.Add(staff.FirstName,
                staff.LastName,
                staff.StreetAddress,
                staff.StreetAddressLine2,
                staff.City,
                staff.StateProvince,
                staff.PostalZipCode,
                staff.Phone,
                staff.Email,
                staff.ApplyForPosition,
                staff.WhenYouCanStart,
                staff.UploadCoverLetterPictureBase64,
                staff.UploadResumePictureBase64,
                staff.YourComment);
            }*/

            for (int i = 0; i < Helper.StaffList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["FirstName"].Value = Helper.StaffList[i].FirstName;
                dataGridView1.Rows[i].Cells["LastName"].Value = Helper.StaffList[i].LastName;
                dataGridView1.Rows[i].Cells["StreetAddress"].Value = Helper.StaffList[i].StreetAddress;
                dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value = Helper.StaffList[i].StreetAddressLine2;
                dataGridView1.Rows[i].Cells["City"].Value = Helper.StaffList[i].City;
                dataGridView1.Rows[i].Cells["StateProvince"].Value = Helper.StaffList[i].StateProvince;
                dataGridView1.Rows[i].Cells["PostalZipCode"].Value = Helper.StaffList[i].PostalZipCode;
                dataGridView1.Rows[i].Cells["Phone"].Value = Helper.StaffList[i].Phone;
                dataGridView1.Rows[i].Cells["Email"].Value = Helper.StaffList[i].Email;
                dataGridView1.Rows[i].Cells["ApplyForPosition"].Value = Helper.StaffList[i].ApplyForPosition;
                dataGridView1.Rows[i].Cells["WhenYouCanStart"].Value = Helper.StaffList[i].WhenYouCanStart;
                dataGridView1.Rows[i].Cells["UploadCoverLetter"].Value = Helper.StaffList[i].UploadCoverLetterImage;
                dataGridView1.Rows[i].Cells["UploadResume"].Value = Helper.StaffList[i].UploadResumeImage;
                dataGridView1.Rows[i].Cells["YourComment"].Value = Helper.StaffList[i].YourComment;
            }

            ((DataGridViewImageColumn)dataGridView1.Columns[11]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            ((DataGridViewImageColumn)dataGridView1.Columns[12]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            /*Helper.StaffList.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string baseImage1 = "";
                string baseImage2 = "";

                if (!(dataGridView1.Rows[i].Cells[11].Value is Bitmap))
                {
                    baseImage1 = Convert.ToBase64String((byte[])dataGridView1.Rows[i].Cells[11].Value);
                    baseImage2 = Convert.ToBase64String((byte[])dataGridView1.Rows[i].Cells[11].Value);
                }
                else
                {
                    baseImage1 = "";
                    baseImage2 = "";
                }

                Helper.StaffList.Add(new
                Staff_Info(
                dataGridView1.Rows[i].Cells[0].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[1].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[2].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[3].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[4].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[5].Value.ToString() ?? "",
                Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value ?? 0),
                dataGridView1.Rows[i].Cells[7].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[8].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[9].Value.ToString() ?? "",
                dataGridView1.Rows[i].Cells[10].Value.ToString() ?? "",
                baseImage1,
                baseImage2,
                dataGridView1.Rows[i].Cells[13].Value.ToString() ?? ""
                ));
            }

            Helper.Serialize(Helper.StaffList, true);
            */

            if (Save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = File.Open(Save.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var reader = XmlReader.Create(stream))
                    {
                        XDocument doc = XDocument.Load(reader);
                        XElement StaffInfo = doc.Element("ArrayOfCustomerInfo");

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            StaffInfo.Add(new XElement("Staff_Info",
                        new XElement("FirstName", dataGridView1.Rows[i].Cells["FirstName"].Value),
                        new XElement("LastName", dataGridView1.Rows[i].Cells["LastName"].Value),
                        new XElement("StreetAddress", dataGridView1.Rows[i].Cells["StreetAddress"].Value),
                        new XElement("StreetAddressLine2", dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value),
                        new XElement("City", dataGridView1.Rows[i].Cells["City"].Value),
                        new XElement("StateProvince", dataGridView1.Rows[i].Cells["StateProvince"].Value),
                        new XElement("PostalZipCode", dataGridView1.Rows[i].Cells["PostalZipCode"].Value),
                        new XElement("Phone", dataGridView1.Rows[i].Cells["Phone"].Value),
                        new XElement("Email", dataGridView1.Rows[i].Cells["Email"].Value),

                        new XElement("ApplyForPosition", dataGridView1.Rows[i].Cells["ApplyForPosition"].Value),
                        new XElement("WhenYouCanStart", dataGridView1.Rows[i].Cells["WhenYouCanStart"].Value),
                        new XElement("YourComment", dataGridView1.Rows[i].Cells["YourComment"].Value),
                        new XElement("UploadCoverLetterImage", Convert.ToBase64String((byte[])dataGridView1.Rows[i].Cells["UploadCoverLetter"].Value)),
                        new XElement("UploadResumeImage", Convert.ToBase64String((byte[])dataGridView1.Rows[i].Cells["UploadResume"].Value)),
                        new XElement("YourComment", dataGridView1.Rows[i].Cells["YourComment"].Value)));
                        }
                        stream.Close();
                        reader.Close();
                        doc.Save(Save.FileName);

                        MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File Not Found !", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}