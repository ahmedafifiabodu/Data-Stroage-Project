﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Assignment_4
{
    public static class OrderHelper
    {
        public static List<OrderNow> OrderList = new List<OrderNow>();
        private static SaveFileDialog save = new SaveFileDialog() { Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json" };
        public static JsonSerializer JSONserializer = new JsonSerializer();
        public static XmlSerializer xml = new XmlSerializer(typeof(List<OrderNow>));

        public static void Serialize(bool ExportJson = false)
        {
            StreamWriter sw = new StreamWriter(save.FileName);
            if (ExportJson == true)
            {
                JSONserializer.Serialize(sw, OrderList);
            }
            else
            {
                xml.Serialize(sw, OrderList);
            }
            sw.Close();
            MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
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
                        Serialize(false);

                    else
                        Serialize(true);

                }
            }
        }
    }
}
