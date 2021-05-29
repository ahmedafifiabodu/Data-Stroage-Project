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
        public static List<Staff_Info> SaffList = new List<Staff_Info>();

        private static SaveFileDialog save = new SaveFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };
        private static OpenFileDialog open = new OpenFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };

        public static JsonSerializer JSONserializer = new JsonSerializer();
        public static XmlSerializer xml = new XmlSerializer(typeof(List<OrderNow>));

        public static void Serialize(object Serilizeable, bool ExportJson = false)
        {
            StreamWriter sw = new StreamWriter(save.FileName);
            if (ExportJson == true)
            {
                JSONserializer.Serialize(sw, Serilizeable);
            }
            else
            {
                xml.Serialize(sw, Serilizeable);
            }
            sw.Close();
            MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
        }






        public static void Deserialize(string NameOfList)
        {
            StreamReader read = new StreamReader(open.FileName);


            if (open.ShowDialog() == DialogResult.OK)
            {


                if (Path.GetExtension(open.FileName).ToLower() == ".xml")
                {

                    switch (NameOfList)
                    {

                        case "staff":
                            SaffList = (List<Staff_Info>)xml.Deserialize(read);
                            break;


                        case "customer":
                            CustomerList = (List<CustomerInfo>)xml.Deserialize(read);
                            break;



                        case "order":
                            OrderList = (List<OrderNow>)xml.Deserialize(read);
                            break;
                    }



                }
                else
                {


                    switch (NameOfList)
                    {

                        case "staff":
                            SaffList = JsonConvert.DeserializeObject<List<Staff_Info>>(read.ReadToEnd());
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
                        Serialize(OrderList, false);

                    else
                        Serialize(OrderList, true);

                }
            }
        }
    }
}
