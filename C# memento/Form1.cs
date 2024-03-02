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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPasswordTb.Text == "" || StaffGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into StaffTbl values('" + StaffNameTb.Text + "','" + StaffPhoneTb.Text + "','" + StaffGenderCb.SelectedItem.ToString() + "','" + StaffPasswordTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Register");
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

        private void label6_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void clear()
        {
            StaffNameTb.Text = "";
            StaffPhoneTb.Text = "";
            StaffGenderCb.SelectedIndex = -1;
            StaffPasswordTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
