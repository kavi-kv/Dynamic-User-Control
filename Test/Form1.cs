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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerPnl_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(etNameTxt.Text == "" || etPriceTxt.Text == "")
            {
                MessageBox.Show("Fill all the required spaces.");
            }
            else
            {
                float price = (float) int.Parse(etPriceTxt.Text);
                var saveItem = new Items(etNameTxt.Text, price);
                saveItem.addItem();
                Items.DisplayItem(disLayout);
                etNameTxt.Text = "";
                etPriceTxt.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Items.DisplayItem(disLayout);
        }
    }
}
