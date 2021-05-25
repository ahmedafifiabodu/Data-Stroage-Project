using System;
using System.Collections.Generic;
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
            Stream st;
            XmlSerializer xml = new XmlSerializer(typeof(List<Staff_Info>));

            int nodeCount = 0;
            dataGridView1.RowTemplate.MinimumHeight = 100;

            if (Open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(Open.FileName);

                if ((st = Open.OpenFile()) != null)
                {
                    try
                    {
                        using (var reader = XmlReader.Create(Open.FileName))
                        {
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "Staff_Info")
                                {
                                    nodeCount++;
                                }
                            }

                            reader.Close();
                        }

                        List<Staff_Info> StaffInfo = (List<Staff_Info>)xml.Deserialize(read);
                        int nodeCounts = StaffInfo.Count;

                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();

                        for (int i = 0; i < nodeCounts; i++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["FirstName"].Value = StaffInfo[i].FirstName;
                            dataGridView1.Rows[i].Cells["LastName"].Value = StaffInfo[i].LastName;
                            dataGridView1.Rows[i].Cells["StreetAddress"].Value = StaffInfo[i].StreetAddress;
                            dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value = StaffInfo[i].StreetAddressLine2;
                            dataGridView1.Rows[i].Cells["City"].Value = StaffInfo[i].City;
                            dataGridView1.Rows[i].Cells["StateProvince"].Value = StaffInfo[i].StateProvince;
                            dataGridView1.Rows[i].Cells["PostalZipCode"].Value = StaffInfo[i].PostalZipCode;
                            dataGridView1.Rows[i].Cells["Phone"].Value = StaffInfo[i].Phone;
                            dataGridView1.Rows[i].Cells["Email"].Value = StaffInfo[i].Email;
                            dataGridView1.Rows[i].Cells["ApplyForPosition"].Value = StaffInfo[i].ApplyForPosition;
                            dataGridView1.Rows[i].Cells["WhenYouCanStart"].Value = StaffInfo[i].WhenYouCanStart;
                            dataGridView1.Rows[i].Cells["UploadCoverLetter"].Value = StaffInfo[i].UploadCoverLetterImage;
                            dataGridView1.Rows[i].Cells["UploadResume"].Value = StaffInfo[i].UploadResumeImage;
                            dataGridView1.Rows[i].Cells["YourComment"].Value = StaffInfo[i].YourComment;
                        }

                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                            {
                                ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                                ((DataGridViewImageColumn)dataGridView1.Columns[i + 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                                break;
                            }
                    }
                    catch
                    {
                        MessageBox.Show("Please select a valid XML file !", "Error", MessageBoxButtons.OK);
                    }

                    read.Close();
                    st.Close();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = File.Open(Save.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var reader = XmlReader.Create(stream))
                    {
                        XDocument doc = XDocument.Load(reader);
                        XElement StaffInfo = doc.Element("ArrayOfStaff_Info");

                        int nodeCount = 0;

                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element &&
                                reader.Name == "Staff_Info")
                            {
                                nodeCount++;
                            }
                        }

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
                SI.xmlSI.Serialize(streamWriter, ListCoustomerInfo);
                MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                streamWriter.Close();
            }
        }
    }
}