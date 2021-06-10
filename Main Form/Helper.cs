using Assignment_4.Customer___Staff;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment_4
{
    public static class Helper
    {
        public static List<OrderNow> OrderList = new List<OrderNow>();
        public static List<CustomerInfo> CustomerList = new List<CustomerInfo>();
        public static List<Staff_Info> StaffList = new List<Staff_Info>();

        private static readonly SaveFileDialog save = new SaveFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };
        private static readonly OpenFileDialog open = new OpenFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };

        public static JsonSerializer JSONserializer = new JsonSerializer();
        public static XmlSerializer xml;

        public static void Serialize(dynamic Serilizeable)
        {
            string filename;

            if (save.ShowDialog() == DialogResult.OK)
                filename = save.FileName;
            else
                return;

            StreamWriter sw = new StreamWriter(filename);

            if (Serilizeable is List<OrderNow>)
            {
                if (Path.GetExtension(filename).ToLower() == ".xml")
                {
                    xml = new XmlSerializer(typeof(List<OrderNow>));
                    xml.Serialize(sw, OrderList);
                }
                else
                    JSONserializer.Serialize(sw, OrderList);

                OrderList.Clear();
            }
            else if (Serilizeable is List<CustomerInfo>)
            {
                if (Path.GetExtension(filename).ToLower() == ".xml")
                {
                    xml = new XmlSerializer(typeof(List<CustomerInfo>));
                    xml.Serialize(sw, CustomerList);
                }
                else
                    JSONserializer.Serialize(sw, CustomerList);

                CustomerList.Clear();
            }
            else if (Serilizeable is List<Staff_Info>)
            {
                if (Path.GetExtension(filename).ToLower() == ".xml")
                {
                    xml = new XmlSerializer(typeof(List<Staff_Info>));
                    xml.Serialize(sw, StaffList);
                }
                else
                    JSONserializer.Serialize(sw, StaffList);

                StaffList.Clear();
            }

            MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sw.Close();
        }

        public static void Deserialize(string NameOfList)
        {
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(open.FileName);
                    if (Path.GetExtension(open.FileName).ToLower() == ".xml")
                    {
                        switch (NameOfList)
                        {
                            case "staff":
                                StaffList.Clear();
                                xml = new XmlSerializer(typeof(List<Staff_Info>));
                                StaffList = (List<Staff_Info>)xml.Deserialize(read);
                                MessageBox.Show("Open Successfully (Deserialize)\n" + open.FileName, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "customer":
                                CustomerList.Clear();
                                xml = new XmlSerializer(typeof(List<CustomerInfo>));
                                CustomerList = (List<CustomerInfo>)xml.Deserialize(read);
                                MessageBox.Show("Open Successfully (Deserialize)\n" + open.FileName, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "order":
                                OrderList.Clear();
                                xml = new XmlSerializer(typeof(List<OrderNow>));
                                OrderList = (List<OrderNow>)xml.Deserialize(read);
                                MessageBox.Show("Please Hover On The Notify Button", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                        }
                    }
                    else
                    {
                        switch (NameOfList)
                        {
                            case "staff":
                                StaffList = JsonConvert.DeserializeObject<List<Staff_Info>>(read.ReadToEnd());
                                MessageBox.Show("Open Successfully (Deserialize)\n" + open.FileName, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "customer":
                                CustomerList = JsonConvert.DeserializeObject<List<CustomerInfo>>(read.ReadToEnd());
                                MessageBox.Show("Open Successfully (Deserialize)\n" + open.FileName, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "order":
                                OrderList = JsonConvert.DeserializeObject<List<OrderNow>>(read.ReadToEnd());
                                MessageBox.Show("Please Hover On The Notify Button", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                        }
                    }
                    read.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invaild File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void NewOrder(string name, string price, decimal quantity)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                OrderList.Add(new OrderNow(name, price, quantity));
            }
            else if (dialogResult == DialogResult.No)
            {
                OrderList.Add(new OrderNow(name, price, quantity));
                Serialize(OrderList);
            }
        }
    }
}