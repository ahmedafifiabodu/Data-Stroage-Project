using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assignment_4.Customer___Staff
{
    public partial class Display_Staff : UserControl
    {
        private static List<Staff_Info> LSI = new List<Staff_Info>();
        private Staff_Info SI = new Staff_Info();

        private SaveFileDialog Save = new SaveFileDialog();
        private OpenFileDialog Open = new OpenFileDialog();

        public Display_Staff()
        {
            InitializeComponent();

            Save.Filter = "XML files (*.xml)|*.xml";
            Open.Filter = "XML files (*.xml)|*.xml";
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

            Helper.Deserialize("staff");
            dataGridView1.RowTemplate.MinimumHeight = 100;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            foreach (Staff_Info staff in Helper.StaffList)
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
            }

            ((DataGridViewImageColumn)dataGridView1.Columns[11]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            ((DataGridViewImageColumn)dataGridView1.Columns[12]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }




        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Helper.StaffList.Clear();

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
                    baseImage1 ="";
                    baseImage2 ="";
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
                dataGridView1.Rows[i].Cells[13].Value.ToString() ??""
                ));
                }


          
            Helper.Serialize(Helper.StaffList ,true);


        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Save.ShowDialog() == DialogResult.OK)
            {
                List<Staff_Info> ListCoustomerInfo = new List<Staff_Info>();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    ListCoustomerInfo.AddRange(new Staff_Info[] { new Staff_Info(
                        dataGridView1.Rows[i].Cells["FirstName"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["LastName"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["StreetAddress"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["City"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["StateProvince"].Value.ToString(),
                        Convert.ToInt32(dataGridView1.Rows[i].Cells["PostalZipCode"].Value),
                        dataGridView1.Rows[i].Cells["Phone"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["Email"].Value.ToString(),

                        dataGridView1.Rows[i].Cells["ApplyForPosition"].Value.ToString(),
                        dataGridView1.Rows[i].Cells["WhenYouCanStart"].Value.ToString(),
                        Convert.ToBase64String((byte[])dataGridView1.Rows[i].Cells["UploadCoverLetter"].Value),
                        Convert.ToBase64String((byte[])dataGridView1.Rows[i].Cells["UploadResume"].Value),
                        dataGridView1.Rows[i].Cells["YourComment"].Value.ToString()
                            )});
                }

                StreamWriter streamWriter = new StreamWriter(Save.FileName);
                // SI.xmlSI.Serialize(streamWriter, ListCoustomerInfo);
                MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                streamWriter.Close();
            }
        }
    }
}