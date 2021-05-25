using System;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class OrderView : UserControl
    {
        public OrderView()
        {
            InitializeComponent();
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString();

            Random rd = new Random();
            int rand_num = rd.Next(100, 999);
            labelOrderNumber.Text = "#" + rand_num;
        }
    }
}