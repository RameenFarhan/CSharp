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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (EventCB.SelectedIndex == -1 || VanuesCB.SelectedIndex == -1 || dateTimePicker1.Text == "" || TimeCB.SelectedIndex == -1 || NoPersonTB.Text == ""||ClintNameTB.Text==""||ClintIdTB.Text==""||TCostTB.Text==""||AdvanceTB.Text==""||BalanceTB.Text=="")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Booking values('" + EventCB.SelectedItem.ToString() + "','" + VanuesCB.SelectedItem.ToString() + "','" + dateTimePicker1.Text + "','" + TimeCB.SelectedItem.ToString() + "','" + NoPersonTB.Text + "','" +ClintNameTB.Text + "','" + ClintIdTB.Text + "','" + TCostTB.Text + "','" + AdvanceTB.Text + "','" + BalanceTB.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Booked");
                    con.Close();
                    //populate();
                    //clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void clear()
        {
            EventCB.SelectedIndex = -1;
            VanuesCB.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            TimeCB.SelectedIndex = -1;
            NoPersonTB.Text = "";
            ClintNameTB.Text = "";
            TCostTB.Text = "";
            AdvanceTB.Text = "";
            BalanceTB.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BookingBack_Click(object sender, EventArgs e)
        {
            MainForm mn = new MainForm();
            mn.Show();
            this.Hide();
        }
    }
}
