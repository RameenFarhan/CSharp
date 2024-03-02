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
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");

        private void populate()
        {
            con.Open();
            string query = "Select * from Booking";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            this.Hide();
        }

        private void bookingbutton_Click(object sender, EventArgs e)
        {

        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ViewDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
