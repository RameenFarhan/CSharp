using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_and_register
{
    public partial class ViewBooking2 : Form
    {
        public ViewBooking2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");

        private void ViewBooking2_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void populate()
        {
            con.Open();
            string query = "Select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            View2DGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel admpnl = new AdminPanel();
            admpnl.Show();
            this.Hide();
        }
    }
}
