using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

        private void ButtonView_Click(object sender, EventArgs e)
        {
            Helper.Deserialize("customer");

            foreach (CustomerInfo customer in Helper.CustomerList)
            {
                dataGridView1.Rows.Add(customer.FirstName,
                customer.LastName,
                customer.StreetAddress,
                customer.StreetAddressLine2,
                customer.City,
                customer.StateProvince,
                customer.PostalZipCode,
                customer.Phone,
                customer.Email,
                customer.HearAboutUs,
                customer.Feedback,
                customer.Suggestions,
                customer.Recommend);
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

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            if (Open.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(Open.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = XmlReader.Create(stream))
                {
                    XDocument doc = XDocument.Load(reader);
                    XElement CustomerInfo = doc.Element("ArrayOfCustomerInfo");

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
                    doc.Save(Open.FileName);

                    MessageBox.Show("Saved Successfully (Serialize)\n" + Save.FileName, "Done");
                }
            }
        }
    }
}