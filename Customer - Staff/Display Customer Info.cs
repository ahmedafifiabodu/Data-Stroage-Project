using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assignment_4.Customer
{
    public partial class DisplayCustomer : UserControl
    {
        private CustomerInfo CustomerInfoClass = new CustomerInfo();

        private SaveFileDialog Save = new SaveFileDialog();
        private OpenFileDialog Open = new OpenFileDialog();

        public DisplayCustomer()
        {
            InitializeComponent();
            Save.Filter = "XML files (*.xml)|*.xml";
            Open.Filter = "XML files (*.xml)|*.xml";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (Save.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(Save.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = XmlReader.Create(stream))
                {
                    XDocument doc = XDocument.Load(reader);
                    XElement CustomerInfo = doc.Element("ArrayOfCustomerInfo");

                    int nodeCount = 0;

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "CustomerInfo")
                        {
                            nodeCount++;
                        }
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        CustomerInfo.Add(new XElement("CustomerInfo", new XElement("FirstName", dataGridView1.Rows[i].Cells["FirstName"].Value), new XElement("LastName", dataGridView1.Rows[i].Cells["LastName"].Value), new XElement("StreetAddress", dataGridView1.Rows[i].Cells["StreetAddress"].Value),
                        new XElement("StreetAddressLine2", dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value), new XElement("City", dataGridView1.Rows[i].Cells["City"].Value), new XElement("StateProvince", dataGridView1.Rows[i].Cells["StateProvince"].Value),
                        new XElement("PostalZipCode", dataGridView1.Rows[i].Cells["PostalZipCode"].Value), new XElement("Phone", dataGridView1.Rows[i].Cells["Phone"].Value), new XElement("Email", dataGridView1.Rows[i].Cells["Email"].Value),
                        new XElement("HearAboutUs", dataGridView1.Rows[i].Cells["HearAboutUs"].Value), new XElement("Feedback", dataGridView1.Rows[i].Cells["Feedback"].Value), new XElement("Suggestions", dataGridView1.Rows[i].Cells["Suggestions"].Value),
                        new XElement("Recommend", dataGridView1.Rows[i].Cells["Recommend"].Value)));
                    }
                    stream.Close();
                    reader.Close();
                    doc.Save(Save.FileName);

                    MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                }
            }
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            Stream st;
            XmlSerializer xml = new XmlSerializer(typeof(List<CustomerInfo>));
            int nodeCount = 0;

            if (Open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(Open.FileName);

                using (var reader = XmlReader.Create(Open.FileName))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "CustomerInfo")
                        {
                            nodeCount++;
                        }
                    }

                    reader.Close();
                }

                if ((st = Open.OpenFile()) != null)
                {
                    try
                    {
                        List<CustomerInfo> CustomerInfo = (List<CustomerInfo>)xml.Deserialize(read);
                        int nodeCounts = CustomerInfo.Count;

                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();

                        for (int i = 0; i < nodeCounts; i++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["FirstName"].Value = CustomerInfo[i].FirstName;
                            dataGridView1.Rows[i].Cells["LastName"].Value = CustomerInfo[i].LastName;
                            dataGridView1.Rows[i].Cells["StreetAddress"].Value = CustomerInfo[i].StreetAddress;
                            dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value = CustomerInfo[i].StreetAddressLine2;
                            dataGridView1.Rows[i].Cells["City"].Value = CustomerInfo[i].City;
                            dataGridView1.Rows[i].Cells["StateProvince"].Value = CustomerInfo[i].StateProvince;
                            dataGridView1.Rows[i].Cells["PostalZipCode"].Value = CustomerInfo[i].PostalZipCode;
                            dataGridView1.Rows[i].Cells["Phone"].Value = CustomerInfo[i].Phone;
                            dataGridView1.Rows[i].Cells["Email"].Value = CustomerInfo[i].Email;
                            dataGridView1.Rows[i].Cells["HearAboutUs"].Value = CustomerInfo[i].HearAboutUs;
                            dataGridView1.Rows[i].Cells["Feedback"].Value = CustomerInfo[i].Feedback;
                            dataGridView1.Rows[i].Cells["Suggestions"].Value = CustomerInfo[i].Suggestions;
                            dataGridView1.Rows[i].Cells["Recommend"].Value = CustomerInfo[i].Recommend;
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Save.ShowDialog() == DialogResult.OK)
            {
                List<CustomerInfo> ListCoustomerInfo = new List<CustomerInfo>();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    ListCoustomerInfo.AddRange(new CustomerInfo[] { new CustomerInfo(dataGridView1.Rows[i].Cells["FirstName"].Value.ToString(), dataGridView1.Rows[i].Cells["LastName"].Value.ToString(), dataGridView1.Rows[i].Cells["StreetAddress"].Value.ToString(),
                            dataGridView1.Rows[i].Cells["StreetAddressLine2"].Value.ToString(), dataGridView1.Rows[i].Cells["City"].Value.ToString(), dataGridView1.Rows[i].Cells["StateProvince"].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells["PostalZipCode"].Value),
                            dataGridView1.Rows[i].Cells["Phone"].Value.ToString(), dataGridView1.Rows[i].Cells["Email"].Value.ToString(), dataGridView1.Rows[i].Cells["HearAboutUs"].Value.ToString(),
                            dataGridView1.Rows[i].Cells["Feedback"].Value.ToString(), dataGridView1.Rows[i].Cells["Suggestions"].Value.ToString(), dataGridView1.Rows[i].Cells["Recommend"].Value.ToString())
                            });
                }

                StreamWriter streamWriter = new StreamWriter(Save.FileName);
                CustomerInfoClass.xmlCI.Serialize(streamWriter, ListCoustomerInfo);
                MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                streamWriter.Close();
            }
        }
    }
}