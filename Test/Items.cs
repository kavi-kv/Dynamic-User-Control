using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public class Items : Connections
    {
        public string name { get; set; }
        public float price { get; set; }


        public Items() { }
        public Items(string name, float price)
        {
            this.name = name;
            this.price = price;
        }



        public void addItem()
        {
            try
            {
                Items item = new Items();
                var sqlConn = item.GetSqlConnection();
                sqlConn.Open();
                var cmd = new SqlCommand("saveItem", sqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
                sqlConn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DisplayItem(FlowLayoutPanel panel)
        {
            var item = new Items();
            var sqlConn = item.GetSqlConnection();
            sqlConn.Open();
            var cmd = new SqlCommand("readItem",sqlConn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var electronic = new Electronics();
                electronic.name =  reader[0].ToString();
                electronic.price = (float) Convert.ToInt32(reader[1]);
                panel.Controls.Add(electronic);
            }
            sqlConn.Close();
            reader.Close();
        }
    }
}
