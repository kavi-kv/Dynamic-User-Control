using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Electronics : UserControl
    {
        public string name { get; set; }    
        public float price { get; set; }
        public Electronics()
        {
            InitializeComponent();
            
        }

        private void Electronics_Load(object sender, EventArgs e)
        {
            txtPrice.Text = "Price: " + price;
            lblName.Text = "Name: " + name;
        }
    }
}
