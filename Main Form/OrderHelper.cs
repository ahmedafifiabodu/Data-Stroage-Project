using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment_4
{
    public static class OrderHelper
    {
        public static List<OrderNow> OrderList = new List<OrderNow>();
        private static SaveFileDialog save = new SaveFileDialog() { Filter = "XML files (*.xml)|*.xml" };
        public static XmlSerializer xml = new XmlSerializer(typeof(List<OrderNow>));



        public static void NewOrder(string name, string price, decimal quantity)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to order more ?", "Question?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                OrderList.Add(new OrderNow(name, price, quantity));
            }
            else if (dialogResult == DialogResult.No)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(save.FileName);
                    xml.Serialize(sw, OrderList);
                    MessageBox.Show("Saved Successfully (Serialize)\n" + save.FileName, "Done");
                    sw.Close();
                }
            }



          

        }
    }
}
