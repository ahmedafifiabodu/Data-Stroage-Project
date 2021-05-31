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

        private static SaveFileDialog save = new SaveFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };
        private static OpenFileDialog open = new OpenFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };

        public static JsonSerializer JSONserializer = new JsonSerializer();
        public static XmlSerializer xml;

        public static void Serialize(dynamic Serilizeable, bool silentSave = false)
        {
            string filename="";

            if (silentSave == true)
                filename = open.FileName;

            if (silentSave == false)
                if (save.ShowDialog() == DialogResult.OK)
                    filename = save.FileName;



          

                if (silentSave)
                    File.Delete(filename);

            StreamWriter sw = new StreamWriter(filename);
                
            if (Path.GetExtension(filename).ToLower() == ".xml")
            {
                xml = new XmlSerializer(Serilizeable);
                xml.Serialize(sw, Serilizeable);
            }
            else
                JSONserializer.Serialize(sw, Serilizeable);


                if (silentSave== true)
                    MessageBox.Show("Saved Successfully", "Done");

                else
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");



            

        }

        public static void Deserialize(string NameOfList)
        {


            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                if (Path.GetExtension(open.FileName).ToLower() == ".xml")
                {
                    switch (NameOfList)
                    {
                        case "staff":
                            xml = new XmlSerializer(typeof(List<Staff_Info>));
                            StaffList = (List<Staff_Info>)xml.Deserialize(read);
                            break;

                        case "customer":
                            xml = new XmlSerializer(typeof(List<CustomerInfo>));
                            CustomerList = (List<CustomerInfo>)xml.Deserialize(read);
                            break;

                        case "order":
                            xml = new XmlSerializer(typeof(List<OrderNow>));
                            OrderList = (List<OrderNow>)xml.Deserialize(read);
                            break;
                    }
                }
                else
                {
                    switch (NameOfList)
                    {
                        case "staff":
                            StaffList = JsonConvert.DeserializeObject<List<Staff_Info>>(read.ReadToEnd());
                            break;

                        case "customer":
                            CustomerList = JsonConvert.DeserializeObject<List<CustomerInfo>>(read.ReadToEnd());
                            break;

                        case "order":
                            OrderList = JsonConvert.DeserializeObject<List<OrderNow>>(read.ReadToEnd());
                            break;
                    }
                }
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
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(save.FileName).ToLower() == ".xml")
                        Serialize(OrderList);
                    else
                        Serialize(OrderList);
                }
            }
        }
    }
}